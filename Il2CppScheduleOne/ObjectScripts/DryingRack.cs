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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000744 RID: 1860
	public class DryingRack : GridItem
	{
		// Token: 0x0600ACA6 RID: 44198 RVA: 0x002B12F4 File Offset: 0x002AF4F4
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRack()
		{
			Il2CppClassPointerStore<DryingRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "DryingRack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRack>.NativeClassPtr);
			DryingRack.NativeFieldInfoPtr_DRY_MINS_PER_TIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "DRY_MINS_PER_TIER");
			DryingRack.NativeFieldInfoPtr_ItemCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "ItemCapacity");
			DryingRack.NativeFieldInfoPtr_CameraPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "CameraPositions");
			DryingRack.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "IntObj");
			DryingRack.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "uiPoint");
			DryingRack.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "accessPoints");
			DryingRack.NativeFieldInfoPtr_InputVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "InputVisuals");
			DryingRack.NativeFieldInfoPtr_OutputVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "OutputVisuals");
			DryingRack.NativeFieldInfoPtr_HangingVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "HangingVisuals");
			DryingRack.NativeFieldInfoPtr_HangAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "HangAlignments");
			DryingRack.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "configReplicator");
			DryingRack.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "WorldspaceUIPrefab");
			DryingRack.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "typeIcon");
			DryingRack.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			DryingRack.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			DryingRack.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<ItemSlots>k__BackingField");
			DryingRack.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<InputSlots>k__BackingField");
			DryingRack.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<OutputSlots>k__BackingField");
			DryingRack.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<Selectable>k__BackingField");
			DryingRack.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			DryingRack.NativeFieldInfoPtr__stationConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<stationConfiguration>k__BackingField");
			DryingRack.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			DryingRack.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			DryingRack.NativeFieldInfoPtr__InputSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<InputSlot>k__BackingField");
			DryingRack.NativeFieldInfoPtr__OutputSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<OutputSlot>k__BackingField");
			DryingRack.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<IsOpen>k__BackingField");
			DryingRack.NativeFieldInfoPtr__DryingOperations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<DryingOperations>k__BackingField");
			DryingRack.NativeFieldInfoPtr_onOperationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "onOperationStart");
			DryingRack.NativeFieldInfoPtr_onOperationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "onOperationComplete");
			DryingRack.NativeFieldInfoPtr_onOperationsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "onOperationsChanged");
			DryingRack.NativeFieldInfoPtr_hangSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "hangSlots");
			DryingRack.NativeFieldInfoPtr_requestIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "requestIDs");
			DryingRack.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			DryingRack.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			DryingRack.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			DryingRack.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted");
			DryingRack.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted");
			DryingRack.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684479);
			DryingRack.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684480);
			DryingRack.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684481);
			DryingRack.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684482);
			DryingRack.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684483);
			DryingRack.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684484);
			DryingRack.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684485);
			DryingRack.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684486);
			DryingRack.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684487);
			DryingRack.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684488);
			DryingRack.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684489);
			DryingRack.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684490);
			DryingRack.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684491);
			DryingRack.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684492);
			DryingRack.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684493);
			DryingRack.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684494);
			DryingRack.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684495);
			DryingRack.NativeMethodInfoPtr_get_stationConfiguration_Protected_get_DryingRackConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684496);
			DryingRack.NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_DryingRackConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684497);
			DryingRack.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684498);
			DryingRack.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684499);
			DryingRack.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684500);
			DryingRack.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684501);
			DryingRack.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684502);
			DryingRack.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684503);
			DryingRack.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684504);
			DryingRack.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684505);
			DryingRack.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684506);
			DryingRack.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684507);
			DryingRack.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684508);
			DryingRack.NativeMethodInfoPtr_get_InputSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684509);
			DryingRack.NativeMethodInfoPtr_set_InputSlot_Private_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684510);
			DryingRack.NativeMethodInfoPtr_get_OutputSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684511);
			DryingRack.NativeMethodInfoPtr_set_OutputSlot_Private_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684512);
			DryingRack.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684513);
			DryingRack.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684514);
			DryingRack.NativeMethodInfoPtr_get_DryingOperations_Public_get_List_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684515);
			DryingRack.NativeMethodInfoPtr_set_DryingOperations_Public_set_Void_List_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684516);
			DryingRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684517);
			DryingRack.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684518);
			DryingRack.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684519);
			DryingRack.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684520);
			DryingRack.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684521);
			DryingRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684522);
			DryingRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684523);
			DryingRack.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684524);
			DryingRack.NativeMethodInfoPtr_CanStartOperation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684525);
			DryingRack.NativeMethodInfoPtr_StartOperation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684526);
			DryingRack.NativeMethodInfoPtr_TryEndOperation_Public_Void_Int32_Boolean_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684527);
			DryingRack.NativeMethodInfoPtr_GetOperationsAtTargetQuality_Public_List_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684528);
			DryingRack.NativeMethodInfoPtr_GetOutputCapacityForOperation_Public_Int32_DryingOperation_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684529);
			DryingRack.NativeMethodInfoPtr_SendOperation_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684530);
			DryingRack.NativeMethodInfoPtr_PleaseReceiveOp_Private_Void_NetworkConnection_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684531);
			DryingRack.NativeMethodInfoPtr_RemoveOperation_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684532);
			DryingRack.NativeMethodInfoPtr_SetOperationQuantity_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684533);
			DryingRack.NativeMethodInfoPtr_GetTotalDryingItems_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684534);
			DryingRack.NativeMethodInfoPtr_RefreshHangingVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684535);
			DryingRack.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684536);
			DryingRack.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684537);
			DryingRack.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684538);
			DryingRack.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684539);
			DryingRack.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684540);
			DryingRack.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684541);
			DryingRack.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684542);
			DryingRack.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684543);
			DryingRack.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684544);
			DryingRack.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684545);
			DryingRack.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684546);
			DryingRack.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684547);
			DryingRack.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684548);
			DryingRack.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684549);
			DryingRack.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684550);
			DryingRack.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684551);
			DryingRack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684552);
			DryingRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684553);
			DryingRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684554);
			DryingRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684555);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684556);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684557);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684558);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_TryEndOperation_4146970406_Private_Void_Int32_Boolean_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684559);
			DryingRack.NativeMethodInfoPtr_RpcLogic___TryEndOperation_4146970406_Public_Void_Int32_Boolean_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684560);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_TryEndOperation_4146970406_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684561);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SendOperation_1307702229_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684562);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SendOperation_1307702229_Private_Void_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684563);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SendOperation_1307702229_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684564);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Target_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684565);
			DryingRack.NativeMethodInfoPtr_RpcLogic___PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684566);
			DryingRack.NativeMethodInfoPtr_RpcReader___Target_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684567);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684568);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684569);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_RemoveOperation_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684570);
			DryingRack.NativeMethodInfoPtr_RpcLogic___RemoveOperation_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684571);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_RemoveOperation_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684572);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684573);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684574);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetOperationQuantity_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684575);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684576);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684577);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684578);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684579);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684580);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684581);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684582);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684583);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684584);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684585);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684586);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684587);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684588);
			DryingRack.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684589);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684590);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684591);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684592);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684593);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684594);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684595);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684596);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684597);
			DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684598);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684599);
			DryingRack.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684600);
			DryingRack.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684601);
			DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684602);
			DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684603);
			DryingRack.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684604);
			DryingRack.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684605);
			DryingRack.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_DryingRack_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684606);
			DryingRack.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684607);
			DryingRack.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684608);
			DryingRack.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684609);
			DryingRack.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684610);
			DryingRack.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, 100684611);
		}

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002B206C File Offset: 0x002B026C
		// (set) Token: 0x0600ACA8 RID: 44200 RVA: 0x002B20AC File Offset: 0x002B02AC
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 166351, RefRangeEnd = 166355, XrefRangeStart = 166351, XrefRangeEnd = 166355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298733, RefRangeEnd = 298735, XrefRangeStart = 298725, XrefRangeEnd = 298733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x002B20F0 File Offset: 0x002B02F0
		// (set) Token: 0x0600ACAA RID: 44202 RVA: 0x002B2130 File Offset: 0x002B0330
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298743, RefRangeEnd = 298745, XrefRangeStart = 298735, XrefRangeEnd = 298743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600ACAB RID: 44203 RVA: 0x002B2174 File Offset: 0x002B0374
		// (set) Token: 0x0600ACAC RID: 44204 RVA: 0x002B21B4 File Offset: 0x002B03B4
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298745, XrefRangeEnd = 298746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x002B21F8 File Offset: 0x002B03F8
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x002B2230 File Offset: 0x002B0430
		// (set) Token: 0x0600ACAF RID: 44207 RVA: 0x002B2270 File Offset: 0x002B0470
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298746, XrefRangeEnd = 298747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x002B22B4 File Offset: 0x002B04B4
		// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x002B22F4 File Offset: 0x002B04F4
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x002B2338 File Offset: 0x002B0538
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600ACB3 RID: 44211 RVA: 0x002B2378 File Offset: 0x002B0578
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x002B23B8 File Offset: 0x002B05B8
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600ACB5 RID: 44213 RVA: 0x002B23F4 File Offset: 0x002B05F4
		// (set) Token: 0x0600ACB6 RID: 44214 RVA: 0x002B2430 File Offset: 0x002B0630
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600ACB7 RID: 44215 RVA: 0x002B2470 File Offset: 0x002B0670
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 298747, RefRangeEnd = 298758, XrefRangeStart = 298747, XrefRangeEnd = 298747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600ACB8 RID: 44216 RVA: 0x002B24B0 File Offset: 0x002B06B0
		// (set) Token: 0x0600ACB9 RID: 44217 RVA: 0x002B24F0 File Offset: 0x002B06F0
		public unsafe DryingRackConfiguration stationConfiguration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 298747, RefRangeEnd = 298758, XrefRangeStart = 298747, XrefRangeEnd = 298758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_stationConfiguration_Protected_get_DryingRackConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRackConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298758, XrefRangeEnd = 298759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_DryingRackConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600ACBA RID: 44218 RVA: 0x002B2534 File Offset: 0x002B0734
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600ACBB RID: 44219 RVA: 0x002B2574 File Offset: 0x002B0774
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600ACBC RID: 44220 RVA: 0x002B25B0 File Offset: 0x002B07B0
		// (set) Token: 0x0600ACBD RID: 44221 RVA: 0x002B25F0 File Offset: 0x002B07F0
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600ACBE RID: 44222 RVA: 0x002B2634 File Offset: 0x002B0834
		// (set) Token: 0x0600ACBF RID: 44223 RVA: 0x002B2674 File Offset: 0x002B0874
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298767, RefRangeEnd = 298769, XrefRangeStart = 298759, XrefRangeEnd = 298767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x002B26B8 File Offset: 0x002B08B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298769, XrefRangeEnd = 298791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600ACC1 RID: 44225 RVA: 0x002B26FC File Offset: 0x002B08FC
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166349, RefRangeEnd = 166350, XrefRangeStart = 166349, XrefRangeEnd = 166350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600ACC2 RID: 44226 RVA: 0x002B273C File Offset: 0x002B093C
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600ACC3 RID: 44227 RVA: 0x002B277C File Offset: 0x002B097C
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600ACC4 RID: 44228 RVA: 0x002B27BC File Offset: 0x002B09BC
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600ACC5 RID: 44229 RVA: 0x002B27F8 File Offset: 0x002B09F8
		// (set) Token: 0x0600ACC6 RID: 44230 RVA: 0x002B2838 File Offset: 0x002B0A38
		public unsafe ItemSlot InputSlot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_InputSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298791, XrefRangeEnd = 298792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_InputSlot_Private_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600ACC7 RID: 44231 RVA: 0x002B287C File Offset: 0x002B0A7C
		// (set) Token: 0x0600ACC8 RID: 44232 RVA: 0x002B28BC File Offset: 0x002B0ABC
		public unsafe ItemSlot OutputSlot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_OutputSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298792, XrefRangeEnd = 298793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_OutputSlot_Private_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600ACC9 RID: 44233 RVA: 0x002B2900 File Offset: 0x002B0B00
		// (set) Token: 0x0600ACCA RID: 44234 RVA: 0x002B293C File Offset: 0x002B0B3C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600ACCB RID: 44235 RVA: 0x002B297C File Offset: 0x002B0B7C
		// (set) Token: 0x0600ACCC RID: 44236 RVA: 0x002B29BC File Offset: 0x002B0BBC
		public unsafe List<DryingOperation> DryingOperations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118902, RefRangeEnd = 118903, XrefRangeStart = 118902, XrefRangeEnd = 118903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_get_DryingOperations_Public_get_List_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingOperation>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_set_DryingOperations_Public_set_Void_List_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x002B2A00 File Offset: 0x002B0C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298793, XrefRangeEnd = 298794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x002B2A3C File Offset: 0x002B0C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298794, XrefRangeEnd = 298826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x002B2ACC File Offset: 0x002B0CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298826, XrefRangeEnd = 298858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x002B2B1C File Offset: 0x002B0D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298858, XrefRangeEnd = 298871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x002B2B60 File Offset: 0x002B0D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298871, XrefRangeEnd = 298872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x002B2BA4 File Offset: 0x002B0DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298872, XrefRangeEnd = 298888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x002B2C08 File Offset: 0x002B0E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298888, XrefRangeEnd = 298922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x002B2C54 File Offset: 0x002B0E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298922, XrefRangeEnd = 298934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x002B2C88 File Offset: 0x002B0E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298937, RefRangeEnd = 298938, XrefRangeStart = 298934, XrefRangeEnd = 298937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_CanStartOperation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x002B2CC4 File Offset: 0x002B0EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298969, RefRangeEnd = 298970, XrefRangeStart = 298938, XrefRangeEnd = 298969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_StartOperation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x002B2CF8 File Offset: 0x002B0EF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298997, RefRangeEnd = 299001, XrefRangeStart = 298970, XrefRangeEnd = 298997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryEndOperation(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSplitting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_TryEndOperation_Public_Void_Int32_Boolean_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x002B2D60 File Offset: 0x002B0F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299020, RefRangeEnd = 299022, XrefRangeStart = 299001, XrefRangeEnd = 299020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingOperation> GetOperationsAtTargetQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_GetOperationsAtTargetQuality_Public_List_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingOperation>>(intPtr3) : null;
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x002B2DA0 File Offset: 0x002B0FA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 299028, RefRangeEnd = 299032, XrefRangeStart = 299022, XrefRangeEnd = 299028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOutputCapacityForOperation(DryingOperation operation, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_GetOutputCapacityForOperation_Public_Int32_DryingOperation_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x002B2DFC File Offset: 0x002B0FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299032, XrefRangeEnd = 299051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOperation(DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SendOperation_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x002B2E40 File Offset: 0x002B1040
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299082, RefRangeEnd = 299085, XrefRangeStart = 299051, XrefRangeEnd = 299082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PleaseReceiveOp(NetworkConnection conn, DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_PleaseReceiveOp_Private_Void_NetworkConnection_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x002B2E94 File Offset: 0x002B1094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299085, XrefRangeEnd = 299108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOperation(int opIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RemoveOperation_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x002B2ED4 File Offset: 0x002B10D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299108, XrefRangeEnd = 299130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOperationQuantity(int opIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetOperationQuantity_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x002B2F20 File Offset: 0x002B1120
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 299148, RefRangeEnd = 299154, XrefRangeStart = 299130, XrefRangeEnd = 299148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalDryingItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_GetTotalDryingItems_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x002B2F5C File Offset: 0x002B115C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299231, RefRangeEnd = 299233, XrefRangeStart = 299154, XrefRangeEnd = 299231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHangingVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RefreshHangingVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x002B2F90 File Offset: 0x002B1190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299260, RefRangeEnd = 299261, XrefRangeStart = 299233, XrefRangeEnd = 299260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x002B2FD0 File Offset: 0x002B11D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299261, XrefRangeEnd = 299265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x002B3004 File Offset: 0x002B1204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299287, RefRangeEnd = 299289, XrefRangeStart = 299265, XrefRangeEnd = 299287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x002B3048 File Offset: 0x002B1248
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 299311, RefRangeEnd = 299315, XrefRangeStart = 299289, XrefRangeEnd = 299311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x002B308C File Offset: 0x002B128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299315, XrefRangeEnd = 299326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x002B30C0 File Offset: 0x002B12C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299326, XrefRangeEnd = 299334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x002B30F4 File Offset: 0x002B12F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299402, RefRangeEnd = 299403, XrefRangeStart = 299334, XrefRangeEnd = 299402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x002B3128 File Offset: 0x002B1328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299441, RefRangeEnd = 299442, XrefRangeStart = 299403, XrefRangeEnd = 299441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x002B315C File Offset: 0x002B135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299442, XrefRangeEnd = 299469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x002B31C0 File Offset: 0x002B13C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299494, RefRangeEnd = 299497, XrefRangeStart = 299469, XrefRangeEnd = 299494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x002B3224 File Offset: 0x002B1424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299497, XrefRangeEnd = 299522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x002B3270 File Offset: 0x002B1470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299550, RefRangeEnd = 299553, XrefRangeStart = 299522, XrefRangeEnd = 299550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x002B32BC File Offset: 0x002B14BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299553, XrefRangeEnd = 299582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x002B3340 File Offset: 0x002B1540
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299632, RefRangeEnd = 299635, XrefRangeStart = 299582, XrefRangeEnd = 299632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x002B33C4 File Offset: 0x002B15C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299635, XrefRangeEnd = 299670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x002B3408 File Offset: 0x002B1608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299670, XrefRangeEnd = 299692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x002B3464 File Offset: 0x002B1664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299692, XrefRangeEnd = 299724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x002B34A0 File Offset: 0x002B16A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299724, XrefRangeEnd = 299859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x002B34DC File Offset: 0x002B16DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299859, XrefRangeEnd = 299860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x002B3518 File Offset: 0x002B1718
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x002B3554 File Offset: 0x002B1754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299860, XrefRangeEnd = 299879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x002B3598 File Offset: 0x002B1798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298767, RefRangeEnd = 298769, XrefRangeStart = 298767, XrefRangeEnd = 298769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x002B35DC File Offset: 0x002B17DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299879, XrefRangeEnd = 299883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x002B3640 File Offset: 0x002B1840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299883, XrefRangeEnd = 299898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSplitting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_TryEndOperation_4146970406_Private_Void_Int32_Boolean_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x002B36A8 File Offset: 0x002B18A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299920, RefRangeEnd = 299922, XrefRangeStart = 299898, XrefRangeEnd = 299920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSplitting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___TryEndOperation_4146970406_Public_Void_Int32_Boolean_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x002B3710 File Offset: 0x002B1910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299922, XrefRangeEnd = 299930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_TryEndOperation_4146970406(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_TryEndOperation_4146970406_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x002B3774 File Offset: 0x002B1974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendOperation_1307702229(DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SendOperation_1307702229_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x002B37B8 File Offset: 0x002B19B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299930, XrefRangeEnd = 299931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendOperation_1307702229(DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SendOperation_1307702229_Private_Void_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x002B37FC File Offset: 0x002B19FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299931, XrefRangeEnd = 299934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendOperation_1307702229(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SendOperation_1307702229_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x002B3860 File Offset: 0x002B1A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299934, XrefRangeEnd = 299953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Target_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x002B38B4 File Offset: 0x002B1AB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299967, RefRangeEnd = 299969, XrefRangeStart = 299953, XrefRangeEnd = 299967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x002B3908 File Offset: 0x002B1B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299969, XrefRangeEnd = 299973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Target_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x002B3958 File Offset: 0x002B1B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299973, XrefRangeEnd = 299992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x002B39AC File Offset: 0x002B1BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299992, XrefRangeEnd = 299995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x002B39FC File Offset: 0x002B1BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299995, XrefRangeEnd = 300015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveOperation_3316948804(int opIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_RemoveOperation_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x002B3A3C File Offset: 0x002B1C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300026, RefRangeEnd = 300028, XrefRangeStart = 300015, XrefRangeEnd = 300026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveOperation_3316948804(int opIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___RemoveOperation_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x002B3A7C File Offset: 0x002B1C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300028, XrefRangeEnd = 300033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveOperation_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_RemoveOperation_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x002B3ACC File Offset: 0x002B1CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x002B3B18 File Offset: 0x002B1D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300033, XrefRangeEnd = 300043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref opIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x002B3B64 File Offset: 0x002B1D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300043, XrefRangeEnd = 300058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOperationQuantity_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetOperationQuantity_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD08 RID: 44296 RVA: 0x002B3BB4 File Offset: 0x002B1DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300058, XrefRangeEnd = 300077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x002B3BF8 File Offset: 0x002B1DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298743, RefRangeEnd = 298745, XrefRangeStart = 298743, XrefRangeEnd = 298745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x002B3C3C File Offset: 0x002B1E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300077, XrefRangeEnd = 300081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x002B3CA0 File Offset: 0x002B1EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300081, XrefRangeEnd = 300100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x002B3CE4 File Offset: 0x002B1EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298733, RefRangeEnd = 298735, XrefRangeStart = 298733, XrefRangeEnd = 298735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x002B3D28 File Offset: 0x002B1F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300100, XrefRangeEnd = 300104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x002B3D8C File Offset: 0x002B1F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300104, XrefRangeEnd = 300117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x002B3DF0 File Offset: 0x002B1FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300117, XrefRangeEnd = 300121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x002B3E54 File Offset: 0x002B2054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300121, XrefRangeEnd = 300129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD11 RID: 44305 RVA: 0x002B3EB8 File Offset: 0x002B20B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300129, XrefRangeEnd = 300150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD12 RID: 44306 RVA: 0x002B3F1C File Offset: 0x002B211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300150, XrefRangeEnd = 300156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x002B3F80 File Offset: 0x002B2180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300156, XrefRangeEnd = 300164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x002B3FD0 File Offset: 0x002B21D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300164, XrefRangeEnd = 300176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD15 RID: 44309 RVA: 0x002B4034 File Offset: 0x002B2234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300176, XrefRangeEnd = 300185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x002B4084 File Offset: 0x002B2284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300185, XrefRangeEnd = 300207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x002B40D0 File Offset: 0x002B22D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300207, XrefRangeEnd = 300208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x002B411C File Offset: 0x002B231C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300208, XrefRangeEnd = 300215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD19 RID: 44313 RVA: 0x002B4180 File Offset: 0x002B2380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300215, XrefRangeEnd = 300237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1A RID: 44314 RVA: 0x002B41CC File Offset: 0x002B23CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300242, RefRangeEnd = 300243, XrefRangeStart = 300237, XrefRangeEnd = 300242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1B RID: 44315 RVA: 0x002B4218 File Offset: 0x002B2418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300243, XrefRangeEnd = 300250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1C RID: 44316 RVA: 0x002B4268 File Offset: 0x002B2468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300250, XrefRangeEnd = 300265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1D RID: 44317 RVA: 0x002B42EC File Offset: 0x002B24EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300265, XrefRangeEnd = 300269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1E RID: 44318 RVA: 0x002B4370 File Offset: 0x002B2570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300269, XrefRangeEnd = 300278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD1F RID: 44319 RVA: 0x002B43D4 File Offset: 0x002B25D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300278, XrefRangeEnd = 300292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD20 RID: 44320 RVA: 0x002B4458 File Offset: 0x002B2658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300300, RefRangeEnd = 300303, XrefRangeStart = 300292, XrefRangeEnd = 300300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD21 RID: 44321 RVA: 0x002B44DC File Offset: 0x002B26DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300303, XrefRangeEnd = 300311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x002B452C File Offset: 0x002B272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300311, XrefRangeEnd = 300334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x002B45B0 File Offset: 0x002B27B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300334, XrefRangeEnd = 300341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600AD24 RID: 44324 RVA: 0x002B4600 File Offset: 0x002B2800
		// (set) Token: 0x0600AD25 RID: 44325 RVA: 0x002B4640 File Offset: 0x002B2840
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 166351, RefRangeEnd = 166355, XrefRangeStart = 166351, XrefRangeEnd = 166355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300350, RefRangeEnd = 300352, XrefRangeStart = 300341, XrefRangeEnd = 300350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AD26 RID: 44326 RVA: 0x002B4690 File Offset: 0x002B2890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300352, XrefRangeEnd = 300370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_DryingRack(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_DryingRack_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x002B4704 File Offset: 0x002B2904
		// (set) Token: 0x0600AD28 RID: 44328 RVA: 0x002B4744 File Offset: 0x002B2944
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300379, RefRangeEnd = 300381, XrefRangeStart = 300370, XrefRangeEnd = 300379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x002B4794 File Offset: 0x002B2994
		// (set) Token: 0x0600AD2A RID: 44330 RVA: 0x002B47D4 File Offset: 0x002B29D4
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300390, RefRangeEnd = 300391, XrefRangeStart = 300381, XrefRangeEnd = 300390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AD2B RID: 44331 RVA: 0x002B4824 File Offset: 0x002B2A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300427, RefRangeEnd = 300428, XrefRangeStart = 300391, XrefRangeEnd = 300427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRack.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD2C RID: 44332 RVA: 0x00054F26 File Offset: 0x00053126
		public DryingRack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600AD2D RID: 44333 RVA: 0x002B4860 File Offset: 0x002B2A60
		// (set) Token: 0x0600AD2E RID: 44334 RVA: 0x00054F2F File Offset: 0x0005312F
		public unsafe static int DRY_MINS_PER_TIER
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DryingRack.NativeFieldInfoPtr_DRY_MINS_PER_TIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DryingRack.NativeFieldInfoPtr_DRY_MINS_PER_TIER, (void*)(&value));
			}
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x002B487C File Offset: 0x002B2A7C
		// (set) Token: 0x0600AD30 RID: 44336 RVA: 0x00054F3D File Offset: 0x0005313D
		public unsafe int ItemCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_ItemCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_ItemCapacity)) = value;
			}
		}

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600AD31 RID: 44337 RVA: 0x002B48A4 File Offset: 0x002B2AA4
		// (set) Token: 0x0600AD32 RID: 44338 RVA: 0x00054F58 File Offset: 0x00053158
		public unsafe Il2CppReferenceArray<Transform> CameraPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_CameraPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_CameraPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600AD33 RID: 44339 RVA: 0x002B48D4 File Offset: 0x002B2AD4
		// (set) Token: 0x0600AD34 RID: 44340 RVA: 0x00054F77 File Offset: 0x00053177
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600AD35 RID: 44341 RVA: 0x002B4904 File Offset: 0x002B2B04
		// (set) Token: 0x0600AD36 RID: 44342 RVA: 0x00054F96 File Offset: 0x00053196
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x002B4934 File Offset: 0x002B2B34
		// (set) Token: 0x0600AD38 RID: 44344 RVA: 0x00054FB5 File Offset: 0x000531B5
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x002B4964 File Offset: 0x002B2B64
		// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x00054FD4 File Offset: 0x000531D4
		public unsafe StorageVisualizer InputVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_InputVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_InputVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x002B4994 File Offset: 0x002B2B94
		// (set) Token: 0x0600AD3C RID: 44348 RVA: 0x00054FF3 File Offset: 0x000531F3
		public unsafe StorageVisualizer OutputVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_OutputVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_OutputVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x002B49C4 File Offset: 0x002B2BC4
		// (set) Token: 0x0600AD3E RID: 44350 RVA: 0x00055012 File Offset: 0x00053212
		public unsafe StorageVisualizer HangingVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_HangingVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_HangingVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x002B49F4 File Offset: 0x002B2BF4
		// (set) Token: 0x0600AD40 RID: 44352 RVA: 0x00055031 File Offset: 0x00053231
		public unsafe Il2CppReferenceArray<Transform> HangAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_HangAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_HangAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x002B4A24 File Offset: 0x002B2C24
		// (set) Token: 0x0600AD42 RID: 44354 RVA: 0x00055050 File Offset: 0x00053250
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600AD43 RID: 44355 RVA: 0x002B4A54 File Offset: 0x002B2C54
		// (set) Token: 0x0600AD44 RID: 44356 RVA: 0x0005506F File Offset: 0x0005326F
		public unsafe DryingRackUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRackUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600AD45 RID: 44357 RVA: 0x002B4A84 File Offset: 0x002B2C84
		// (set) Token: 0x0600AD46 RID: 44358 RVA: 0x0005508E File Offset: 0x0005328E
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600AD47 RID: 44359 RVA: 0x002B4AB4 File Offset: 0x002B2CB4
		// (set) Token: 0x0600AD48 RID: 44360 RVA: 0x000550AD File Offset: 0x000532AD
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600AD49 RID: 44361 RVA: 0x002B4AE4 File Offset: 0x002B2CE4
		// (set) Token: 0x0600AD4A RID: 44362 RVA: 0x000550CC File Offset: 0x000532CC
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x002B4B14 File Offset: 0x002B2D14
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x000550EB File Offset: 0x000532EB
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x002B4B44 File Offset: 0x002B2D44
		// (set) Token: 0x0600AD4E RID: 44366 RVA: 0x0005510A File Offset: 0x0005330A
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600AD4F RID: 44367 RVA: 0x002B4B74 File Offset: 0x002B2D74
		// (set) Token: 0x0600AD50 RID: 44368 RVA: 0x00055129 File Offset: 0x00053329
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600AD51 RID: 44369 RVA: 0x002B4BA4 File Offset: 0x002B2DA4
		// (set) Token: 0x0600AD52 RID: 44370 RVA: 0x00055148 File Offset: 0x00053348
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600AD53 RID: 44371 RVA: 0x002B4BCC File Offset: 0x002B2DCC
		// (set) Token: 0x0600AD54 RID: 44372 RVA: 0x00055163 File Offset: 0x00053363
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600AD55 RID: 44373 RVA: 0x002B4BF4 File Offset: 0x002B2DF4
		// (set) Token: 0x0600AD56 RID: 44374 RVA: 0x0005517E File Offset: 0x0005337E
		public unsafe DryingRackConfiguration _stationConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__stationConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRackConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__stationConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600AD57 RID: 44375 RVA: 0x002B4C24 File Offset: 0x002B2E24
		// (set) Token: 0x0600AD58 RID: 44376 RVA: 0x0005519D File Offset: 0x0005339D
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x002B4C54 File Offset: 0x002B2E54
		// (set) Token: 0x0600AD5A RID: 44378 RVA: 0x000551BC File Offset: 0x000533BC
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600AD5B RID: 44379 RVA: 0x002B4C84 File Offset: 0x002B2E84
		// (set) Token: 0x0600AD5C RID: 44380 RVA: 0x000551DB File Offset: 0x000533DB
		public unsafe ItemSlot _InputSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__InputSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__InputSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600AD5D RID: 44381 RVA: 0x002B4CB4 File Offset: 0x002B2EB4
		// (set) Token: 0x0600AD5E RID: 44382 RVA: 0x000551FA File Offset: 0x000533FA
		public unsafe ItemSlot _OutputSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__OutputSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__OutputSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600AD5F RID: 44383 RVA: 0x002B4CE4 File Offset: 0x002B2EE4
		// (set) Token: 0x0600AD60 RID: 44384 RVA: 0x00055219 File Offset: 0x00053419
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600AD61 RID: 44385 RVA: 0x002B4D0C File Offset: 0x002B2F0C
		// (set) Token: 0x0600AD62 RID: 44386 RVA: 0x00055234 File Offset: 0x00053434
		public unsafe List<DryingOperation> _DryingOperations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__DryingOperations_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr__DryingOperations_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x002B4D3C File Offset: 0x002B2F3C
		// (set) Token: 0x0600AD64 RID: 44388 RVA: 0x00055253 File Offset: 0x00053453
		public unsafe Action<DryingOperation> onOperationStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600AD65 RID: 44389 RVA: 0x002B4D6C File Offset: 0x002B2F6C
		// (set) Token: 0x0600AD66 RID: 44390 RVA: 0x00055272 File Offset: 0x00053472
		public unsafe Action<DryingOperation> onOperationComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600AD67 RID: 44391 RVA: 0x002B4D9C File Offset: 0x002B2F9C
		// (set) Token: 0x0600AD68 RID: 44392 RVA: 0x00055291 File Offset: 0x00053491
		public unsafe Action onOperationsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_onOperationsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600AD69 RID: 44393 RVA: 0x002B4DCC File Offset: 0x002B2FCC
		// (set) Token: 0x0600AD6A RID: 44394 RVA: 0x000552B0 File Offset: 0x000534B0
		public unsafe Il2CppReferenceArray<ItemSlot> hangSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_hangSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_hangSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600AD6B RID: 44395 RVA: 0x002B4DFC File Offset: 0x002B2FFC
		// (set) Token: 0x0600AD6C RID: 44396 RVA: 0x000552CF File Offset: 0x000534CF
		public unsafe List<int> requestIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_requestIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_requestIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600AD6D RID: 44397 RVA: 0x002B4E2C File Offset: 0x002B302C
		// (set) Token: 0x0600AD6E RID: 44398 RVA: 0x000552EE File Offset: 0x000534EE
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600AD6F RID: 44399 RVA: 0x002B4E5C File Offset: 0x002B305C
		// (set) Token: 0x0600AD70 RID: 44400 RVA: 0x0005530D File Offset: 0x0005350D
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600AD71 RID: 44401 RVA: 0x002B4E8C File Offset: 0x002B308C
		// (set) Token: 0x0600AD72 RID: 44402 RVA: 0x0005532C File Offset: 0x0005352C
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600AD73 RID: 44403 RVA: 0x002B4EBC File Offset: 0x002B30BC
		// (set) Token: 0x0600AD74 RID: 44404 RVA: 0x0005534B File Offset: 0x0005354B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600AD75 RID: 44405 RVA: 0x002B4EE4 File Offset: 0x002B30E4
		// (set) Token: 0x0600AD76 RID: 44406 RVA: 0x00055366 File Offset: 0x00053566
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400740E RID: 29710
		private static readonly IntPtr NativeFieldInfoPtr_DRY_MINS_PER_TIER;

		// Token: 0x0400740F RID: 29711
		private static readonly IntPtr NativeFieldInfoPtr_ItemCapacity;

		// Token: 0x04007410 RID: 29712
		private static readonly IntPtr NativeFieldInfoPtr_CameraPositions;

		// Token: 0x04007411 RID: 29713
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04007412 RID: 29714
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04007413 RID: 29715
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x04007414 RID: 29716
		private static readonly IntPtr NativeFieldInfoPtr_InputVisuals;

		// Token: 0x04007415 RID: 29717
		private static readonly IntPtr NativeFieldInfoPtr_OutputVisuals;

		// Token: 0x04007416 RID: 29718
		private static readonly IntPtr NativeFieldInfoPtr_HangingVisuals;

		// Token: 0x04007417 RID: 29719
		private static readonly IntPtr NativeFieldInfoPtr_HangAlignments;

		// Token: 0x04007418 RID: 29720
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04007419 RID: 29721
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x0400741A RID: 29722
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x0400741B RID: 29723
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x0400741C RID: 29724
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x0400741D RID: 29725
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x0400741E RID: 29726
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x0400741F RID: 29727
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04007420 RID: 29728
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04007421 RID: 29729
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04007422 RID: 29730
		private static readonly IntPtr NativeFieldInfoPtr__stationConfiguration_k__BackingField;

		// Token: 0x04007423 RID: 29731
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04007424 RID: 29732
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04007425 RID: 29733
		private static readonly IntPtr NativeFieldInfoPtr__InputSlot_k__BackingField;

		// Token: 0x04007426 RID: 29734
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlot_k__BackingField;

		// Token: 0x04007427 RID: 29735
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007428 RID: 29736
		private static readonly IntPtr NativeFieldInfoPtr__DryingOperations_k__BackingField;

		// Token: 0x04007429 RID: 29737
		private static readonly IntPtr NativeFieldInfoPtr_onOperationStart;

		// Token: 0x0400742A RID: 29738
		private static readonly IntPtr NativeFieldInfoPtr_onOperationComplete;

		// Token: 0x0400742B RID: 29739
		private static readonly IntPtr NativeFieldInfoPtr_onOperationsChanged;

		// Token: 0x0400742C RID: 29740
		private static readonly IntPtr NativeFieldInfoPtr_hangSlots;

		// Token: 0x0400742D RID: 29741
		private static readonly IntPtr NativeFieldInfoPtr_requestIDs;

		// Token: 0x0400742E RID: 29742
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x0400742F RID: 29743
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04007430 RID: 29744
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04007431 RID: 29745
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007432 RID: 29746
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007433 RID: 29747
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007434 RID: 29748
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007435 RID: 29749
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007436 RID: 29750
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007437 RID: 29751
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04007438 RID: 29752
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04007439 RID: 29753
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400743A RID: 29754
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400743B RID: 29755
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400743C RID: 29756
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400743D RID: 29757
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400743E RID: 29758
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400743F RID: 29759
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04007440 RID: 29760
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007441 RID: 29761
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007442 RID: 29762
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007443 RID: 29763
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04007444 RID: 29764
		private static readonly IntPtr NativeMethodInfoPtr_get_stationConfiguration_Protected_get_DryingRackConfiguration_0;

		// Token: 0x04007445 RID: 29765
		private static readonly IntPtr NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_DryingRackConfiguration_0;

		// Token: 0x04007446 RID: 29766
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04007447 RID: 29767
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04007448 RID: 29768
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04007449 RID: 29769
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x0400744A RID: 29770
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400744B RID: 29771
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400744C RID: 29772
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400744D RID: 29773
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x0400744E RID: 29774
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400744F RID: 29775
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007450 RID: 29776
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007451 RID: 29777
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlot_Public_get_ItemSlot_0;

		// Token: 0x04007452 RID: 29778
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlot_Private_set_Void_ItemSlot_0;

		// Token: 0x04007453 RID: 29779
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlot_Public_get_ItemSlot_0;

		// Token: 0x04007454 RID: 29780
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlot_Private_set_Void_ItemSlot_0;

		// Token: 0x04007455 RID: 29781
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007456 RID: 29782
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007457 RID: 29783
		private static readonly IntPtr NativeMethodInfoPtr_get_DryingOperations_Public_get_List_1_DryingOperation_0;

		// Token: 0x04007458 RID: 29784
		private static readonly IntPtr NativeMethodInfoPtr_set_DryingOperations_Public_set_Void_List_1_DryingOperation_0;

		// Token: 0x04007459 RID: 29785
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400745A RID: 29786
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x0400745B RID: 29787
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400745C RID: 29788
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x0400745D RID: 29789
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400745E RID: 29790
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x0400745F RID: 29791
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007460 RID: 29792
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007461 RID: 29793
		private static readonly IntPtr NativeMethodInfoPtr_CanStartOperation_Public_Boolean_0;

		// Token: 0x04007462 RID: 29794
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Public_Void_0;

		// Token: 0x04007463 RID: 29795
		private static readonly IntPtr NativeMethodInfoPtr_TryEndOperation_Public_Void_Int32_Boolean_EQuality_Int32_0;

		// Token: 0x04007464 RID: 29796
		private static readonly IntPtr NativeMethodInfoPtr_GetOperationsAtTargetQuality_Public_List_1_DryingOperation_0;

		// Token: 0x04007465 RID: 29797
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputCapacityForOperation_Public_Int32_DryingOperation_EQuality_0;

		// Token: 0x04007466 RID: 29798
		private static readonly IntPtr NativeMethodInfoPtr_SendOperation_Private_Void_DryingOperation_0;

		// Token: 0x04007467 RID: 29799
		private static readonly IntPtr NativeMethodInfoPtr_PleaseReceiveOp_Private_Void_NetworkConnection_DryingOperation_0;

		// Token: 0x04007468 RID: 29800
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOperation_Private_Void_Int32_0;

		// Token: 0x04007469 RID: 29801
		private static readonly IntPtr NativeMethodInfoPtr_SetOperationQuantity_Private_Void_Int32_Int32_0;

		// Token: 0x0400746A RID: 29802
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalDryingItems_Public_Int32_0;

		// Token: 0x0400746B RID: 29803
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHangingVisuals_Public_Void_0;

		// Token: 0x0400746C RID: 29804
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x0400746D RID: 29805
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400746E RID: 29806
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400746F RID: 29807
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007470 RID: 29808
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007471 RID: 29809
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007472 RID: 29810
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007473 RID: 29811
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007474 RID: 29812
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007475 RID: 29813
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007476 RID: 29814
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04007477 RID: 29815
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04007478 RID: 29816
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007479 RID: 29817
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400747A RID: 29818
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400747B RID: 29819
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x0400747C RID: 29820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400747D RID: 29821
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400747E RID: 29822
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400747F RID: 29823
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007480 RID: 29824
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007481 RID: 29825
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007482 RID: 29826
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007483 RID: 29827
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_TryEndOperation_4146970406_Private_Void_Int32_Boolean_EQuality_Int32_0;

		// Token: 0x04007484 RID: 29828
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TryEndOperation_4146970406_Public_Void_Int32_Boolean_EQuality_Int32_0;

		// Token: 0x04007485 RID: 29829
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_TryEndOperation_4146970406_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007486 RID: 29830
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendOperation_1307702229_Private_Void_DryingOperation_0;

		// Token: 0x04007487 RID: 29831
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendOperation_1307702229_Private_Void_DryingOperation_0;

		// Token: 0x04007488 RID: 29832
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendOperation_1307702229_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007489 RID: 29833
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0;

		// Token: 0x0400748A RID: 29834
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0;

		// Token: 0x0400748B RID: 29835
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400748C RID: 29836
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PleaseReceiveOp_1575047616_Private_Void_NetworkConnection_DryingOperation_0;

		// Token: 0x0400748D RID: 29837
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PleaseReceiveOp_1575047616_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400748E RID: 29838
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveOperation_3316948804_Private_Void_Int32_0;

		// Token: 0x0400748F RID: 29839
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveOperation_3316948804_Private_Void_Int32_0;

		// Token: 0x04007490 RID: 29840
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveOperation_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007491 RID: 29841
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04007492 RID: 29842
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOperationQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04007493 RID: 29843
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOperationQuantity_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007494 RID: 29844
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007495 RID: 29845
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007496 RID: 29846
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007497 RID: 29847
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007498 RID: 29848
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007499 RID: 29849
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400749A RID: 29850
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400749B RID: 29851
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400749C RID: 29852
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400749D RID: 29853
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400749E RID: 29854
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400749F RID: 29855
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x040074A0 RID: 29856
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040074A1 RID: 29857
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x040074A2 RID: 29858
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040074A3 RID: 29859
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x040074A4 RID: 29860
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040074A5 RID: 29861
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040074A6 RID: 29862
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040074A7 RID: 29863
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x040074A8 RID: 29864
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040074A9 RID: 29865
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040074AA RID: 29866
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040074AB RID: 29867
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040074AC RID: 29868
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040074AD RID: 29869
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040074AE RID: 29870
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040074AF RID: 29871
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040074B0 RID: 29872
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040074B1 RID: 29873
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040074B2 RID: 29874
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_DryingRack_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040074B3 RID: 29875
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040074B4 RID: 29876
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040074B5 RID: 29877
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040074B6 RID: 29878
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040074B7 RID: 29879
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BE8 RID: 3048
		[ObfuscatedName("ScheduleOne.ObjectScripts.DryingRack+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF18 RID: 57112 RVA: 0x003496CC File Offset: 0x003478CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr);
				DryingRack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, "<>9");
				DryingRack.__c.NativeFieldInfoPtr___9__111_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, "<>9__111_0");
				DryingRack.__c.NativeFieldInfoPtr___9__112_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, "<>9__112_0");
				DryingRack.__c.NativeFieldInfoPtr___9__112_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, "<>9__112_1");
				DryingRack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, 100684613);
				DryingRack.__c.NativeMethodInfoPtr__GetTotalDryingItems_b__111_0_Internal_Int32_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, 100684614);
				DryingRack.__c.NativeMethodInfoPtr__RefreshHangingVisuals_b__112_0_Internal_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, 100684615);
				DryingRack.__c.NativeMethodInfoPtr__RefreshHangingVisuals_b__112_1_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr, 100684616);
			}

			// Token: 0x0600DF19 RID: 57113 RVA: 0x00349798 File Offset: 0x00347998
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF1A RID: 57114 RVA: 0x003497D4 File Offset: 0x003479D4
			[CallerCount(0)]
			public unsafe int _GetTotalDryingItems_b__111_0(DryingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c.NativeMethodInfoPtr__GetTotalDryingItems_b__111_0_Internal_Int32_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF1B RID: 57115 RVA: 0x00349824 File Offset: 0x00347A24
			[CallerCount(0)]
			public unsafe bool _RefreshHangingVisuals_b__112_0(StoredItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c.NativeMethodInfoPtr__RefreshHangingVisuals_b__112_0_Internal_Boolean_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF1C RID: 57116 RVA: 0x00349874 File Offset: 0x00347A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298696, XrefRangeEnd = 298701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshHangingVisuals_b__112_1(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c.NativeMethodInfoPtr__RefreshHangingVisuals_b__112_1_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF1D RID: 57117 RVA: 0x0006CC62 File Offset: 0x0006AE62
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004524 RID: 17700
			// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x003498C4 File Offset: 0x00347AC4
			// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x0006CC6B File Offset: 0x0006AE6B
			public unsafe static DryingRack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DryingRack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DryingRack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004525 RID: 17701
			// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x003498EC File Offset: 0x00347AEC
			// (set) Token: 0x0600DF21 RID: 57121 RVA: 0x0006CC7D File Offset: 0x0006AE7D
			public unsafe static Func<DryingOperation, int> __9__111_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DryingRack.__c.NativeFieldInfoPtr___9__111_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DryingOperation, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DryingRack.__c.NativeFieldInfoPtr___9__111_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004526 RID: 17702
			// (get) Token: 0x0600DF22 RID: 57122 RVA: 0x00349914 File Offset: 0x00347B14
			// (set) Token: 0x0600DF23 RID: 57123 RVA: 0x0006CC8F File Offset: 0x0006AE8F
			public unsafe static Func<StoredItem, bool> __9__112_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DryingRack.__c.NativeFieldInfoPtr___9__112_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StoredItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DryingRack.__c.NativeFieldInfoPtr___9__112_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004527 RID: 17703
			// (get) Token: 0x0600DF24 RID: 57124 RVA: 0x0034993C File Offset: 0x00347B3C
			// (set) Token: 0x0600DF25 RID: 57125 RVA: 0x0006CCA1 File Offset: 0x0006AEA1
			public unsafe static Func<Transform, bool> __9__112_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DryingRack.__c.NativeFieldInfoPtr___9__112_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DryingRack.__c.NativeFieldInfoPtr___9__112_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009568 RID: 38248
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009569 RID: 38249
			private static readonly IntPtr NativeFieldInfoPtr___9__111_0;

			// Token: 0x0400956A RID: 38250
			private static readonly IntPtr NativeFieldInfoPtr___9__112_0;

			// Token: 0x0400956B RID: 38251
			private static readonly IntPtr NativeFieldInfoPtr___9__112_1;

			// Token: 0x0400956C RID: 38252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400956D RID: 38253
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalDryingItems_b__111_0_Internal_Int32_DryingOperation_0;

			// Token: 0x0400956E RID: 38254
			private static readonly IntPtr NativeMethodInfoPtr__RefreshHangingVisuals_b__112_0_Internal_Boolean_StoredItem_0;

			// Token: 0x0400956F RID: 38255
			private static readonly IntPtr NativeMethodInfoPtr__RefreshHangingVisuals_b__112_1_Internal_Boolean_Transform_0;
		}

		// Token: 0x02000BE9 RID: 3049
		[ObfuscatedName("ScheduleOne.ObjectScripts.DryingRack+<>c__DisplayClass105_0")]
		public sealed class __c__DisplayClass105_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF26 RID: 57126 RVA: 0x00349964 File Offset: 0x00347B64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass105_0()
			{
				Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<>c__DisplayClass105_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr);
				DryingRack.__c__DisplayClass105_0.NativeFieldInfoPtr_targetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr, "targetQuality");
				DryingRack.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr, 100684617);
				DryingRack.__c__DisplayClass105_0.NativeMethodInfoPtr__GetOperationsAtTargetQuality_b__0_Internal_Boolean_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr, 100684618);
			}

			// Token: 0x0600DF27 RID: 57127 RVA: 0x003499CC File Offset: 0x00347BCC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass105_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRack.__c__DisplayClass105_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass105_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF28 RID: 57128 RVA: 0x00349A08 File Offset: 0x00347C08
			[CallerCount(0)]
			public unsafe bool _GetOperationsAtTargetQuality_b__0(DryingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass105_0.NativeMethodInfoPtr__GetOperationsAtTargetQuality_b__0_Internal_Boolean_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF29 RID: 57129 RVA: 0x0006CCB3 File Offset: 0x0006AEB3
			public __c__DisplayClass105_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004528 RID: 17704
			// (get) Token: 0x0600DF2A RID: 57130 RVA: 0x00349A58 File Offset: 0x00347C58
			// (set) Token: 0x0600DF2B RID: 57131 RVA: 0x0006CCBC File Offset: 0x0006AEBC
			public unsafe EQuality targetQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass105_0.NativeFieldInfoPtr_targetQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass105_0.NativeFieldInfoPtr_targetQuality)) = value;
				}
			}

			// Token: 0x04009570 RID: 38256
			private static readonly IntPtr NativeFieldInfoPtr_targetQuality;

			// Token: 0x04009571 RID: 38257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009572 RID: 38258
			private static readonly IntPtr NativeMethodInfoPtr__GetOperationsAtTargetQuality_b__0_Internal_Boolean_DryingOperation_0;
		}

		// Token: 0x02000BEA RID: 3050
		[ObfuscatedName("ScheduleOne.ObjectScripts.DryingRack+<>c__DisplayClass97_0")]
		public sealed class __c__DisplayClass97_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF2C RID: 57132 RVA: 0x00349A80 File Offset: 0x00347C80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRack>.NativeClassPtr, "<>c__DisplayClass97_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr);
				DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, "<>4__this");
				DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, "conn");
				DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, 100684619);
				DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, 100684620);
				DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, 100684621);
			}

			// Token: 0x0600DF2D RID: 57133 RVA: 0x00349B10 File Offset: 0x00347D10
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF2E RID: 57134 RVA: 0x00349B4C File Offset: 0x00347D4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298722, RefRangeEnd = 298724, XrefRangeStart = 298717, XrefRangeEnd = 298722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF2F RID: 57135 RVA: 0x00349B8C File Offset: 0x00347D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298724, XrefRangeEnd = 298725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF30 RID: 57136 RVA: 0x0006CCD7 File Offset: 0x0006AED7
			public __c__DisplayClass97_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004529 RID: 17705
			// (get) Token: 0x0600DF31 RID: 57137 RVA: 0x00349BC8 File Offset: 0x00347DC8
			// (set) Token: 0x0600DF32 RID: 57138 RVA: 0x0006CCE0 File Offset: 0x0006AEE0
			public unsafe DryingRack __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452A RID: 17706
			// (get) Token: 0x0600DF33 RID: 57139 RVA: 0x00349BF8 File Offset: 0x00347DF8
			// (set) Token: 0x0600DF34 RID: 57140 RVA: 0x0006CCFF File Offset: 0x0006AEFF
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009573 RID: 38259
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009574 RID: 38260
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04009575 RID: 38261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009576 RID: 38262
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04009577 RID: 38263
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C8A RID: 3210
			[ObfuscatedName("ScheduleOne.ObjectScripts.DryingRack+<>c__DisplayClass97_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E70C RID: 59148 RVA: 0x00360998 File Offset: 0x0035EB98
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684622);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684623);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684624);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684625);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684626);
					DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684627);
				}

				// Token: 0x0600E70D RID: 59149 RVA: 0x00360A78 File Offset: 0x0035EC78
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E70E RID: 59150 RVA: 0x00360AC0 File Offset: 0x0035ECC0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E70F RID: 59151 RVA: 0x00360AF4 File Offset: 0x0035ECF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298701, XrefRangeEnd = 298712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047FC RID: 18428
				// (get) Token: 0x0600E710 RID: 59152 RVA: 0x00360B30 File Offset: 0x0035ED30
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E711 RID: 59153 RVA: 0x00360B70 File Offset: 0x0035ED70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298712, XrefRangeEnd = 298717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047FD RID: 18429
				// (get) Token: 0x0600E712 RID: 59154 RVA: 0x00360BA4 File Offset: 0x0035EDA4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E713 RID: 59155 RVA: 0x00070C9B File Offset: 0x0006EE9B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047F9 RID: 18425
				// (get) Token: 0x0600E714 RID: 59156 RVA: 0x00360BE4 File Offset: 0x0035EDE4
				// (set) Token: 0x0600E715 RID: 59157 RVA: 0x00070CA4 File Offset: 0x0006EEA4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047FA RID: 18426
				// (get) Token: 0x0600E716 RID: 59158 RVA: 0x00360C0C File Offset: 0x0035EE0C
				// (set) Token: 0x0600E717 RID: 59159 RVA: 0x00070CBF File Offset: 0x0006EEBF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047FB RID: 18427
				// (get) Token: 0x0600E718 RID: 59160 RVA: 0x00360C3C File Offset: 0x0035EE3C
				// (set) Token: 0x0600E719 RID: 59161 RVA: 0x00070CDE File Offset: 0x0006EEDE
				public unsafe DryingRack.__c__DisplayClass97_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack.__c__DisplayClass97_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRack.__c__DisplayClass97_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A64 RID: 39524
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A65 RID: 39525
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A66 RID: 39526
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A67 RID: 39527
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A68 RID: 39528
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A69 RID: 39529
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A6A RID: 39530
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A6B RID: 39531
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A6C RID: 39532
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
