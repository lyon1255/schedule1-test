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
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Decoration;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000750 RID: 1872
	public class PackagingStation : GridItem
	{
		// Token: 0x0600B0FA RID: 45306 RVA: 0x002C2750 File Offset: 0x002C0950
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStation()
		{
			Il2CppClassPointerStore<PackagingStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "PackagingStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr);
			PackagingStation.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<ItemSlots>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_OverheadLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "OverheadLight");
			PackagingStation.NativeFieldInfoPtr_OverheadLightMeshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "OverheadLightMeshRend");
			PackagingStation.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "Switch");
			PackagingStation.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "CameraPosition");
			PackagingStation.NativeFieldInfoPtr_CameraPosition_Task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "CameraPosition_Task");
			PackagingStation.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "IntObj");
			PackagingStation.NativeFieldInfoPtr_ActivePackagingAlignent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ActivePackagingAlignent");
			PackagingStation.NativeFieldInfoPtr_ActiveProductAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ActiveProductAlignments");
			PackagingStation.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "Container");
			PackagingStation.NativeFieldInfoPtr_OutputCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "OutputCollider");
			PackagingStation.NativeFieldInfoPtr_Hatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "Hatch");
			PackagingStation.NativeFieldInfoPtr_PackagingAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "PackagingAlignments");
			PackagingStation.NativeFieldInfoPtr_ProductAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ProductAlignments");
			PackagingStation.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "uiPoint");
			PackagingStation.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "configReplicator");
			PackagingStation.NativeFieldInfoPtr_StandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "StandPoint");
			PackagingStation.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "accessPoints");
			PackagingStation.NativeFieldInfoPtr_HatchOpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "HatchOpenSound");
			PackagingStation.NativeFieldInfoPtr_HatchCloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "HatchCloseSound");
			PackagingStation.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "WorldspaceUIPrefab");
			PackagingStation.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "typeIcon");
			PackagingStation.NativeFieldInfoPtr_PackagingSlotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "PackagingSlotPosition");
			PackagingStation.NativeFieldInfoPtr_ProductSlotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ProductSlotPosition");
			PackagingStation.NativeFieldInfoPtr_OutputSlotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "OutputSlotPosition");
			PackagingStation.NativeFieldInfoPtr_LightMeshOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "LightMeshOnMat");
			PackagingStation.NativeFieldInfoPtr_LightMeshOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "LightMeshOffMat");
			PackagingStation.NativeFieldInfoPtr_PackagerEmployeeSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "PackagerEmployeeSpeedMultiplier");
			PackagingStation.NativeFieldInfoPtr_HatchClosedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "HatchClosedRotation");
			PackagingStation.NativeFieldInfoPtr_HatchOpenRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "HatchOpenRotation");
			PackagingStation.NativeFieldInfoPtr_HatchLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "HatchLerpTime");
			PackagingStation.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_PackagingSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "PackagingSlot");
			PackagingStation.NativeFieldInfoPtr_ProductSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ProductSlot");
			PackagingStation.NativeFieldInfoPtr_OutputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "OutputSlot");
			PackagingStation.NativeFieldInfoPtr_hatchOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "hatchOpen");
			PackagingStation.NativeFieldInfoPtr_hatchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "hatchRoutine");
			PackagingStation.NativeFieldInfoPtr_PackagingSlotModelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "PackagingSlotModelID");
			PackagingStation.NativeFieldInfoPtr_ProductSlotModelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "ProductSlotModelID");
			PackagingStation.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<InputSlots>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<OutputSlots>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<Selectable>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__stationConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<stationConfiguration>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			PackagingStation.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_visualsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "visualsLocked");
			PackagingStation.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted");
			PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PackagingStationAssembly-CSharp.dll_Excuted");
			PackagingStation.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685079);
			PackagingStation.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685080);
			PackagingStation.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685081);
			PackagingStation.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685082);
			PackagingStation.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685083);
			PackagingStation.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685084);
			PackagingStation.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685085);
			PackagingStation.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685086);
			PackagingStation.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685087);
			PackagingStation.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685088);
			PackagingStation.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685089);
			PackagingStation.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685090);
			PackagingStation.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685091);
			PackagingStation.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685092);
			PackagingStation.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685093);
			PackagingStation.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685094);
			PackagingStation.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685095);
			PackagingStation.NativeMethodInfoPtr_get_stationConfiguration_Protected_get_PackagingStationConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685096);
			PackagingStation.NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_PackagingStationConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685097);
			PackagingStation.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685098);
			PackagingStation.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685099);
			PackagingStation.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685100);
			PackagingStation.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685101);
			PackagingStation.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685102);
			PackagingStation.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685103);
			PackagingStation.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685104);
			PackagingStation.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685105);
			PackagingStation.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685106);
			PackagingStation.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685107);
			PackagingStation.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685108);
			PackagingStation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685109);
			PackagingStation.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685110);
			PackagingStation.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685111);
			PackagingStation.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685112);
			PackagingStation.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685113);
			PackagingStation.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685114);
			PackagingStation.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685115);
			PackagingStation.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685116);
			PackagingStation.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685117);
			PackagingStation.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685118);
			PackagingStation.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685119);
			PackagingStation.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685120);
			PackagingStation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685121);
			PackagingStation.NativeMethodInfoPtr_GetState_Public_EState_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685122);
			PackagingStation.NativeMethodInfoPtr_Unpack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685123);
			PackagingStation.NativeMethodInfoPtr_PackSingleInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685124);
			PackagingStation.NativeMethodInfoPtr_SetHatchOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685125);
			PackagingStation.NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685126);
			PackagingStation.NativeMethodInfoPtr_SetVisualsLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685127);
			PackagingStation.NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685128);
			PackagingStation.NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685129);
			PackagingStation.NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685130);
			PackagingStation.NativeMethodInfoPtr_StartTask_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685131);
			PackagingStation.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685132);
			PackagingStation.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685133);
			PackagingStation.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685134);
			PackagingStation.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685135);
			PackagingStation.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685136);
			PackagingStation.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685137);
			PackagingStation.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685138);
			PackagingStation.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685139);
			PackagingStation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685140);
			PackagingStation.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685141);
			PackagingStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685142);
			PackagingStation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685143);
			PackagingStation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685144);
			PackagingStation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685145);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685146);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685147);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685148);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685149);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685150);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685151);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685152);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685153);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685154);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685155);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685156);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685157);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685158);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685159);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685160);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685161);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685162);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685163);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685164);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685165);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685166);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685167);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685168);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685169);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685170);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685171);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685172);
			PackagingStation.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685173);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685174);
			PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685175);
			PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685176);
			PackagingStation.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685177);
			PackagingStation.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685178);
			PackagingStation.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PackagingStation_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685179);
			PackagingStation.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685180);
			PackagingStation.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685181);
			PackagingStation.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685182);
			PackagingStation.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685183);
			PackagingStation.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, 100685184);
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600B0FB RID: 45307 RVA: 0x002C33EC File Offset: 0x002C15EC
		// (set) Token: 0x0600B0FC RID: 45308 RVA: 0x002C342C File Offset: 0x002C162C
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600B0FD RID: 45309 RVA: 0x002C3470 File Offset: 0x002C1670
		// (set) Token: 0x0600B0FE RID: 45310 RVA: 0x002C34B0 File Offset: 0x002C16B0
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 293739, RefRangeEnd = 293753, XrefRangeStart = 293739, XrefRangeEnd = 293753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 305147, RefRangeEnd = 305149, XrefRangeStart = 305139, XrefRangeEnd = 305147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600B0FF RID: 45311 RVA: 0x002C34F4 File Offset: 0x002C16F4
		// (set) Token: 0x0600B100 RID: 45312 RVA: 0x002C3534 File Offset: 0x002C1734
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305149, XrefRangeEnd = 305157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600B101 RID: 45313 RVA: 0x002C3578 File Offset: 0x002C1778
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600B102 RID: 45314 RVA: 0x002C35B0 File Offset: 0x002C17B0
		// (set) Token: 0x0600B103 RID: 45315 RVA: 0x002C35F0 File Offset: 0x002C17F0
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600B104 RID: 45316 RVA: 0x002C3634 File Offset: 0x002C1834
		// (set) Token: 0x0600B105 RID: 45317 RVA: 0x002C3674 File Offset: 0x002C1874
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305157, XrefRangeEnd = 305158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600B106 RID: 45318 RVA: 0x002C36B8 File Offset: 0x002C18B8
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600B107 RID: 45319 RVA: 0x002C36F8 File Offset: 0x002C18F8
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x002C3738 File Offset: 0x002C1938
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x002C3774 File Offset: 0x002C1974
		// (set) Token: 0x0600B10A RID: 45322 RVA: 0x002C37B0 File Offset: 0x002C19B0
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600B10B RID: 45323 RVA: 0x002C37F0 File Offset: 0x002C19F0
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 295221, RefRangeEnd = 295232, XrefRangeStart = 295221, XrefRangeEnd = 295232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600B10C RID: 45324 RVA: 0x002C3830 File Offset: 0x002C1A30
		// (set) Token: 0x0600B10D RID: 45325 RVA: 0x002C3870 File Offset: 0x002C1A70
		public unsafe PackagingStationConfiguration stationConfiguration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 295221, RefRangeEnd = 295232, XrefRangeStart = 295221, XrefRangeEnd = 295232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_stationConfiguration_Protected_get_PackagingStationConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStationConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_PackagingStationConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600B10E RID: 45326 RVA: 0x002C38B4 File Offset: 0x002C1AB4
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600B10F RID: 45327 RVA: 0x002C38F4 File Offset: 0x002C1AF4
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600B110 RID: 45328 RVA: 0x002C3930 File Offset: 0x002C1B30
		// (set) Token: 0x0600B111 RID: 45329 RVA: 0x002C3970 File Offset: 0x002C1B70
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305158, XrefRangeEnd = 305159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600B112 RID: 45330 RVA: 0x002C39B4 File Offset: 0x002C1BB4
		// (set) Token: 0x0600B113 RID: 45331 RVA: 0x002C39F4 File Offset: 0x002C1BF4
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 305167, RefRangeEnd = 305169, XrefRangeStart = 305159, XrefRangeEnd = 305167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x002C3A38 File Offset: 0x002C1C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305169, XrefRangeEnd = 305191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600B115 RID: 45333 RVA: 0x002C3A7C File Offset: 0x002C1C7C
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600B116 RID: 45334 RVA: 0x002C3ABC File Offset: 0x002C1CBC
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x002C3AFC File Offset: 0x002C1CFC
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600B118 RID: 45336 RVA: 0x002C3B3C File Offset: 0x002C1D3C
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x002C3B78 File Offset: 0x002C1D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305192, RefRangeEnd = 305193, XrefRangeStart = 305191, XrefRangeEnd = 305192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x002C3BB4 File Offset: 0x002C1DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305193, XrefRangeEnd = 305211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x002C3C44 File Offset: 0x002C1E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305211, XrefRangeEnd = 305232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x002C3C94 File Offset: 0x002C1E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305232, XrefRangeEnd = 305249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x002C3CD8 File Offset: 0x002C1ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305249, XrefRangeEnd = 305260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x002C3D1C File Offset: 0x002C1F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305260, XrefRangeEnd = 305276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x002C3D80 File Offset: 0x002C1F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305276, XrefRangeEnd = 305293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x002C3DCC File Offset: 0x002C1FCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305315, RefRangeEnd = 305317, XrefRangeStart = 305293, XrefRangeEnd = 305315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x002C3E10 File Offset: 0x002C2010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305339, RefRangeEnd = 305342, XrefRangeStart = 305317, XrefRangeEnd = 305339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x002C3E54 File Offset: 0x002C2054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305342, XrefRangeEnd = 305353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x002C3E88 File Offset: 0x002C2088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305353, XrefRangeEnd = 305361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B124 RID: 45348 RVA: 0x002C3EBC File Offset: 0x002C20BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305405, RefRangeEnd = 305406, XrefRangeStart = 305361, XrefRangeEnd = 305405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B125 RID: 45349 RVA: 0x002C3EF0 File Offset: 0x002C20F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305459, RefRangeEnd = 305460, XrefRangeStart = 305406, XrefRangeEnd = 305459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B126 RID: 45350 RVA: 0x002C3F24 File Offset: 0x002C2124
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 305465, RefRangeEnd = 305472, XrefRangeStart = 305460, XrefRangeEnd = 305465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStation.EState GetState(PackagingStation.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_GetState_Public_EState_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x002C3F70 File Offset: 0x002C2170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305472, XrefRangeEnd = 305482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unpack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_Unpack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x002C3FA4 File Offset: 0x002C21A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305511, RefRangeEnd = 305513, XrefRangeStart = 305482, XrefRangeEnd = 305511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PackSingleInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_PackSingleInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x002C3FD8 File Offset: 0x002C21D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305526, RefRangeEnd = 305529, XrefRangeStart = 305513, XrefRangeEnd = 305526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHatchOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetHatchOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x002C4018 File Offset: 0x002C2218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305532, RefRangeEnd = 305535, XrefRangeStart = 305529, XrefRangeEnd = 305532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePackagingVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x002C404C File Offset: 0x002C224C
		[CallerCount(0)]
		public unsafe void SetVisualsLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetVisualsLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x002C408C File Offset: 0x002C228C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305596, RefRangeEnd = 305599, XrefRangeStart = 305535, XrefRangeEnd = 305596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePackagingVisuals(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x002C40CC File Offset: 0x002C22CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305602, RefRangeEnd = 305605, XrefRangeStart = 305599, XrefRangeEnd = 305602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProductVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x002C4100 File Offset: 0x002C2300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305664, RefRangeEnd = 305667, XrefRangeStart = 305605, XrefRangeEnd = 305664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProductVisuals(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x002C4140 File Offset: 0x002C2340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305667, XrefRangeEnd = 305671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_StartTask_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x002C417C File Offset: 0x002C237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305671, XrefRangeEnd = 305698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x002C41E0 File Offset: 0x002C23E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305723, RefRangeEnd = 305726, XrefRangeStart = 305698, XrefRangeEnd = 305723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x002C4244 File Offset: 0x002C2444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305726, XrefRangeEnd = 305751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x002C4290 File Offset: 0x002C2490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305779, RefRangeEnd = 305782, XrefRangeStart = 305751, XrefRangeEnd = 305779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x002C42DC File Offset: 0x002C24DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305782, XrefRangeEnd = 305811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x002C4360 File Offset: 0x002C2560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 305861, RefRangeEnd = 305864, XrefRangeStart = 305811, XrefRangeEnd = 305861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x002C43E4 File Offset: 0x002C25E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305891, RefRangeEnd = 305892, XrefRangeStart = 305864, XrefRangeEnd = 305891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x002C4424 File Offset: 0x002C2624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305892, XrefRangeEnd = 305896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x002C4458 File Offset: 0x002C2658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305896, XrefRangeEnd = 305905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x002C449C File Offset: 0x002C269C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305905, XrefRangeEnd = 305928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x002C44F8 File Offset: 0x002C26F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305958, RefRangeEnd = 305959, XrefRangeStart = 305928, XrefRangeEnd = 305958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x002C4534 File Offset: 0x002C2734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306058, RefRangeEnd = 306059, XrefRangeStart = 305959, XrefRangeEnd = 306058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x002C4570 File Offset: 0x002C2770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306060, RefRangeEnd = 306061, XrefRangeStart = 306059, XrefRangeEnd = 306060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x002C45AC File Offset: 0x002C27AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x002C45E8 File Offset: 0x002C27E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306061, XrefRangeEnd = 306080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x002C462C File Offset: 0x002C282C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305167, RefRangeEnd = 305169, XrefRangeStart = 305167, XrefRangeEnd = 305169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x002C4670 File Offset: 0x002C2870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306080, XrefRangeEnd = 306084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x002C46D4 File Offset: 0x002C28D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306084, XrefRangeEnd = 306103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x002C4718 File Offset: 0x002C2918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306150, RefRangeEnd = 306152, XrefRangeStart = 306103, XrefRangeEnd = 306150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x002C475C File Offset: 0x002C295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306152, XrefRangeEnd = 306156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x002C47C0 File Offset: 0x002C29C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306156, XrefRangeEnd = 306175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x002C4804 File Offset: 0x002C2A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305147, RefRangeEnd = 305149, XrefRangeStart = 305147, XrefRangeEnd = 305149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x002C4848 File Offset: 0x002C2A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306175, XrefRangeEnd = 306179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x002C48AC File Offset: 0x002C2AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306179, XrefRangeEnd = 306192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x002C4910 File Offset: 0x002C2B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306192, XrefRangeEnd = 306196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x002C4974 File Offset: 0x002C2B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306196, XrefRangeEnd = 306204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x002C49D8 File Offset: 0x002C2BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306204, XrefRangeEnd = 306225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14B RID: 45387 RVA: 0x002C4A3C File Offset: 0x002C2C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306225, XrefRangeEnd = 306231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x002C4AA0 File Offset: 0x002C2CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306231, XrefRangeEnd = 306239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x002C4AF0 File Offset: 0x002C2CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306239, XrefRangeEnd = 306251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x002C4B54 File Offset: 0x002C2D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306251, XrefRangeEnd = 306260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x002C4BA4 File Offset: 0x002C2DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306260, XrefRangeEnd = 306282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x002C4BF0 File Offset: 0x002C2DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306282, XrefRangeEnd = 306283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B151 RID: 45393 RVA: 0x002C4C3C File Offset: 0x002C2E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306283, XrefRangeEnd = 306290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B152 RID: 45394 RVA: 0x002C4CA0 File Offset: 0x002C2EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306290, XrefRangeEnd = 306312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B153 RID: 45395 RVA: 0x002C4CEC File Offset: 0x002C2EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306317, RefRangeEnd = 306318, XrefRangeStart = 306312, XrefRangeEnd = 306317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x002C4D38 File Offset: 0x002C2F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306318, XrefRangeEnd = 306325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B155 RID: 45397 RVA: 0x002C4D88 File Offset: 0x002C2F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306325, XrefRangeEnd = 306340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x002C4E0C File Offset: 0x002C300C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306340, XrefRangeEnd = 306344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x002C4E90 File Offset: 0x002C3090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306344, XrefRangeEnd = 306353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x002C4EF4 File Offset: 0x002C30F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306353, XrefRangeEnd = 306367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B159 RID: 45401 RVA: 0x002C4F78 File Offset: 0x002C3178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306375, RefRangeEnd = 306378, XrefRangeStart = 306367, XrefRangeEnd = 306375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x002C4FFC File Offset: 0x002C31FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306378, XrefRangeEnd = 306386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x002C504C File Offset: 0x002C324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306386, XrefRangeEnd = 306409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x002C50D0 File Offset: 0x002C32D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306409, XrefRangeEnd = 306416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600B15D RID: 45405 RVA: 0x002C5120 File Offset: 0x002C3320
		// (set) Token: 0x0600B15E RID: 45406 RVA: 0x002C5160 File Offset: 0x002C3360
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 293739, RefRangeEnd = 293753, XrefRangeStart = 293739, XrefRangeEnd = 293753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306425, RefRangeEnd = 306427, XrefRangeStart = 306416, XrefRangeEnd = 306425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x002C51B0 File Offset: 0x002C33B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306427, XrefRangeEnd = 306445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_PackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PackagingStation_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600B160 RID: 45408 RVA: 0x002C5224 File Offset: 0x002C3424
		// (set) Token: 0x0600B161 RID: 45409 RVA: 0x002C5264 File Offset: 0x002C3464
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 306454, RefRangeEnd = 306456, XrefRangeStart = 306445, XrefRangeEnd = 306454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600B162 RID: 45410 RVA: 0x002C52B4 File Offset: 0x002C34B4
		// (set) Token: 0x0600B163 RID: 45411 RVA: 0x002C52F4 File Offset: 0x002C34F4
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306465, RefRangeEnd = 306466, XrefRangeStart = 306456, XrefRangeEnd = 306465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x002C5344 File Offset: 0x002C3544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306545, RefRangeEnd = 306546, XrefRangeStart = 306466, XrefRangeEnd = 306545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStation.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x00056DCB File Offset: 0x00054FCB
		public PackagingStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600B166 RID: 45414 RVA: 0x002C5380 File Offset: 0x002C3580
		// (set) Token: 0x0600B167 RID: 45415 RVA: 0x00056DD4 File Offset: 0x00054FD4
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600B168 RID: 45416 RVA: 0x002C53B0 File Offset: 0x002C35B0
		// (set) Token: 0x0600B169 RID: 45417 RVA: 0x00056DF3 File Offset: 0x00054FF3
		public unsafe Light OverheadLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OverheadLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OverheadLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600B16A RID: 45418 RVA: 0x002C53E0 File Offset: 0x002C35E0
		// (set) Token: 0x0600B16B RID: 45419 RVA: 0x00056E12 File Offset: 0x00055012
		public unsafe MeshRenderer OverheadLightMeshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OverheadLightMeshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OverheadLightMeshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600B16C RID: 45420 RVA: 0x002C5410 File Offset: 0x002C3610
		// (set) Token: 0x0600B16D RID: 45421 RVA: 0x00056E31 File Offset: 0x00055031
		public unsafe RockerSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockerSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600B16E RID: 45422 RVA: 0x002C5440 File Offset: 0x002C3640
		// (set) Token: 0x0600B16F RID: 45423 RVA: 0x00056E50 File Offset: 0x00055050
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600B170 RID: 45424 RVA: 0x002C5470 File Offset: 0x002C3670
		// (set) Token: 0x0600B171 RID: 45425 RVA: 0x00056E6F File Offset: 0x0005506F
		public unsafe Transform CameraPosition_Task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_CameraPosition_Task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_CameraPosition_Task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600B172 RID: 45426 RVA: 0x002C54A0 File Offset: 0x002C36A0
		// (set) Token: 0x0600B173 RID: 45427 RVA: 0x00056E8E File Offset: 0x0005508E
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600B174 RID: 45428 RVA: 0x002C54D0 File Offset: 0x002C36D0
		// (set) Token: 0x0600B175 RID: 45429 RVA: 0x00056EAD File Offset: 0x000550AD
		public unsafe Transform ActivePackagingAlignent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ActivePackagingAlignent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ActivePackagingAlignent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600B176 RID: 45430 RVA: 0x002C5500 File Offset: 0x002C3700
		// (set) Token: 0x0600B177 RID: 45431 RVA: 0x00056ECC File Offset: 0x000550CC
		public unsafe Il2CppReferenceArray<Transform> ActiveProductAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ActiveProductAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ActiveProductAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600B178 RID: 45432 RVA: 0x002C5530 File Offset: 0x002C3730
		// (set) Token: 0x0600B179 RID: 45433 RVA: 0x00056EEB File Offset: 0x000550EB
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600B17A RID: 45434 RVA: 0x002C5560 File Offset: 0x002C3760
		// (set) Token: 0x0600B17B RID: 45435 RVA: 0x00056F0A File Offset: 0x0005510A
		public unsafe Collider OutputCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x002C5590 File Offset: 0x002C3790
		// (set) Token: 0x0600B17D RID: 45437 RVA: 0x00056F29 File Offset: 0x00055129
		public unsafe Transform Hatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Hatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_Hatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x002C55C0 File Offset: 0x002C37C0
		// (set) Token: 0x0600B17F RID: 45439 RVA: 0x00056F48 File Offset: 0x00055148
		public unsafe Il2CppReferenceArray<Transform> PackagingAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600B180 RID: 45440 RVA: 0x002C55F0 File Offset: 0x002C37F0
		// (set) Token: 0x0600B181 RID: 45441 RVA: 0x00056F67 File Offset: 0x00055167
		public unsafe Il2CppReferenceArray<Transform> ProductAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600B182 RID: 45442 RVA: 0x002C5620 File Offset: 0x002C3820
		// (set) Token: 0x0600B183 RID: 45443 RVA: 0x00056F86 File Offset: 0x00055186
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600B184 RID: 45444 RVA: 0x002C5650 File Offset: 0x002C3850
		// (set) Token: 0x0600B185 RID: 45445 RVA: 0x00056FA5 File Offset: 0x000551A5
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600B186 RID: 45446 RVA: 0x002C5680 File Offset: 0x002C3880
		// (set) Token: 0x0600B187 RID: 45447 RVA: 0x00056FC4 File Offset: 0x000551C4
		public unsafe Transform StandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_StandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_StandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x002C56B0 File Offset: 0x002C38B0
		// (set) Token: 0x0600B189 RID: 45449 RVA: 0x00056FE3 File Offset: 0x000551E3
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x002C56E0 File Offset: 0x002C38E0
		// (set) Token: 0x0600B18B RID: 45451 RVA: 0x00057002 File Offset: 0x00055202
		public unsafe AudioSourceController HatchOpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchOpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchOpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x002C5710 File Offset: 0x002C3910
		// (set) Token: 0x0600B18D RID: 45453 RVA: 0x00057021 File Offset: 0x00055221
		public unsafe AudioSourceController HatchCloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchCloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchCloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x002C5740 File Offset: 0x002C3940
		// (set) Token: 0x0600B18F RID: 45455 RVA: 0x00057040 File Offset: 0x00055240
		public unsafe PackagingStationUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x002C5770 File Offset: 0x002C3970
		// (set) Token: 0x0600B191 RID: 45457 RVA: 0x0005705F File Offset: 0x0005525F
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x002C57A0 File Offset: 0x002C39A0
		// (set) Token: 0x0600B193 RID: 45459 RVA: 0x0005707E File Offset: 0x0005527E
		public unsafe Transform PackagingSlotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x002C57D0 File Offset: 0x002C39D0
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x0005709D File Offset: 0x0005529D
		public unsafe Transform ProductSlotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x002C5800 File Offset: 0x002C3A00
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x000570BC File Offset: 0x000552BC
		public unsafe Transform OutputSlotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputSlotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputSlotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600B198 RID: 45464 RVA: 0x002C5830 File Offset: 0x002C3A30
		// (set) Token: 0x0600B199 RID: 45465 RVA: 0x000570DB File Offset: 0x000552DB
		public unsafe Material LightMeshOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_LightMeshOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_LightMeshOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600B19A RID: 45466 RVA: 0x002C5860 File Offset: 0x002C3A60
		// (set) Token: 0x0600B19B RID: 45467 RVA: 0x000570FA File Offset: 0x000552FA
		public unsafe Material LightMeshOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_LightMeshOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_LightMeshOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600B19C RID: 45468 RVA: 0x002C5890 File Offset: 0x002C3A90
		// (set) Token: 0x0600B19D RID: 45469 RVA: 0x00057119 File Offset: 0x00055319
		public unsafe float PackagerEmployeeSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagerEmployeeSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagerEmployeeSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600B19E RID: 45470 RVA: 0x002C58B8 File Offset: 0x002C3AB8
		// (set) Token: 0x0600B19F RID: 45471 RVA: 0x00057134 File Offset: 0x00055334
		public unsafe Vector3 HatchClosedRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchClosedRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchClosedRotation)) = value;
			}
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600B1A0 RID: 45472 RVA: 0x002C58E0 File Offset: 0x002C3AE0
		// (set) Token: 0x0600B1A1 RID: 45473 RVA: 0x0005714F File Offset: 0x0005534F
		public unsafe Vector3 HatchOpenRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchOpenRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchOpenRotation)) = value;
			}
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600B1A2 RID: 45474 RVA: 0x002C5908 File Offset: 0x002C3B08
		// (set) Token: 0x0600B1A3 RID: 45475 RVA: 0x0005716A File Offset: 0x0005536A
		public unsafe float HatchLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_HatchLerpTime)) = value;
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600B1A4 RID: 45476 RVA: 0x002C5930 File Offset: 0x002C3B30
		// (set) Token: 0x0600B1A5 RID: 45477 RVA: 0x00057185 File Offset: 0x00055385
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600B1A6 RID: 45478 RVA: 0x002C5960 File Offset: 0x002C3B60
		// (set) Token: 0x0600B1A7 RID: 45479 RVA: 0x000571A4 File Offset: 0x000553A4
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600B1A8 RID: 45480 RVA: 0x002C5990 File Offset: 0x002C3B90
		// (set) Token: 0x0600B1A9 RID: 45481 RVA: 0x000571C3 File Offset: 0x000553C3
		public unsafe ItemSlot PackagingSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600B1AA RID: 45482 RVA: 0x002C59C0 File Offset: 0x002C3BC0
		// (set) Token: 0x0600B1AB RID: 45483 RVA: 0x000571E2 File Offset: 0x000553E2
		public unsafe ItemSlot ProductSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600B1AC RID: 45484 RVA: 0x002C59F0 File Offset: 0x002C3BF0
		// (set) Token: 0x0600B1AD RID: 45485 RVA: 0x00057201 File Offset: 0x00055401
		public unsafe ItemSlot OutputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_OutputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600B1AE RID: 45486 RVA: 0x002C5A20 File Offset: 0x002C3C20
		// (set) Token: 0x0600B1AF RID: 45487 RVA: 0x00057220 File Offset: 0x00055420
		public unsafe bool hatchOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_hatchOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_hatchOpen)) = value;
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600B1B0 RID: 45488 RVA: 0x002C5A48 File Offset: 0x002C3C48
		// (set) Token: 0x0600B1B1 RID: 45489 RVA: 0x0005723B File Offset: 0x0005543B
		public unsafe Coroutine hatchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_hatchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_hatchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600B1B2 RID: 45490 RVA: 0x002C5A78 File Offset: 0x002C3C78
		// (set) Token: 0x0600B1B3 RID: 45491 RVA: 0x0005725A File Offset: 0x0005545A
		public unsafe List<string> PackagingSlotModelID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlotModelID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_PackagingSlotModelID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600B1B4 RID: 45492 RVA: 0x002C5AA8 File Offset: 0x002C3CA8
		// (set) Token: 0x0600B1B5 RID: 45493 RVA: 0x00057279 File Offset: 0x00055479
		public unsafe List<string> ProductSlotModelID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlotModelID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_ProductSlotModelID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600B1B6 RID: 45494 RVA: 0x002C5AD8 File Offset: 0x002C3CD8
		// (set) Token: 0x0600B1B7 RID: 45495 RVA: 0x00057298 File Offset: 0x00055498
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600B1B8 RID: 45496 RVA: 0x002C5B08 File Offset: 0x002C3D08
		// (set) Token: 0x0600B1B9 RID: 45497 RVA: 0x000572B7 File Offset: 0x000554B7
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600B1BA RID: 45498 RVA: 0x002C5B38 File Offset: 0x002C3D38
		// (set) Token: 0x0600B1BB RID: 45499 RVA: 0x000572D6 File Offset: 0x000554D6
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600B1BC RID: 45500 RVA: 0x002C5B60 File Offset: 0x002C3D60
		// (set) Token: 0x0600B1BD RID: 45501 RVA: 0x000572F1 File Offset: 0x000554F1
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600B1BE RID: 45502 RVA: 0x002C5B88 File Offset: 0x002C3D88
		// (set) Token: 0x0600B1BF RID: 45503 RVA: 0x0005730C File Offset: 0x0005550C
		public unsafe PackagingStationConfiguration _stationConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__stationConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__stationConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600B1C0 RID: 45504 RVA: 0x002C5BB8 File Offset: 0x002C3DB8
		// (set) Token: 0x0600B1C1 RID: 45505 RVA: 0x0005732B File Offset: 0x0005552B
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600B1C2 RID: 45506 RVA: 0x002C5BE8 File Offset: 0x002C3DE8
		// (set) Token: 0x0600B1C3 RID: 45507 RVA: 0x0005734A File Offset: 0x0005554A
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600B1C4 RID: 45508 RVA: 0x002C5C18 File Offset: 0x002C3E18
		// (set) Token: 0x0600B1C5 RID: 45509 RVA: 0x00057369 File Offset: 0x00055569
		public unsafe bool visualsLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_visualsLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_visualsLocked)) = value;
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600B1C6 RID: 45510 RVA: 0x002C5C40 File Offset: 0x002C3E40
		// (set) Token: 0x0600B1C7 RID: 45511 RVA: 0x00057384 File Offset: 0x00055584
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600B1C8 RID: 45512 RVA: 0x002C5C70 File Offset: 0x002C3E70
		// (set) Token: 0x0600B1C9 RID: 45513 RVA: 0x000573A3 File Offset: 0x000555A3
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600B1CA RID: 45514 RVA: 0x002C5CA0 File Offset: 0x002C3EA0
		// (set) Token: 0x0600B1CB RID: 45515 RVA: 0x000573C2 File Offset: 0x000555C2
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600B1CC RID: 45516 RVA: 0x002C5CD0 File Offset: 0x002C3ED0
		// (set) Token: 0x0600B1CD RID: 45517 RVA: 0x000573E1 File Offset: 0x000555E1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600B1CE RID: 45518 RVA: 0x002C5CF8 File Offset: 0x002C3EF8
		// (set) Token: 0x0600B1CF RID: 45519 RVA: 0x000573FC File Offset: 0x000555FC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007744 RID: 30532
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x04007745 RID: 30533
		private static readonly IntPtr NativeFieldInfoPtr_OverheadLight;

		// Token: 0x04007746 RID: 30534
		private static readonly IntPtr NativeFieldInfoPtr_OverheadLightMeshRend;

		// Token: 0x04007747 RID: 30535
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x04007748 RID: 30536
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04007749 RID: 30537
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition_Task;

		// Token: 0x0400774A RID: 30538
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400774B RID: 30539
		private static readonly IntPtr NativeFieldInfoPtr_ActivePackagingAlignent;

		// Token: 0x0400774C RID: 30540
		private static readonly IntPtr NativeFieldInfoPtr_ActiveProductAlignments;

		// Token: 0x0400774D RID: 30541
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400774E RID: 30542
		private static readonly IntPtr NativeFieldInfoPtr_OutputCollider;

		// Token: 0x0400774F RID: 30543
		private static readonly IntPtr NativeFieldInfoPtr_Hatch;

		// Token: 0x04007750 RID: 30544
		private static readonly IntPtr NativeFieldInfoPtr_PackagingAlignments;

		// Token: 0x04007751 RID: 30545
		private static readonly IntPtr NativeFieldInfoPtr_ProductAlignments;

		// Token: 0x04007752 RID: 30546
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04007753 RID: 30547
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04007754 RID: 30548
		private static readonly IntPtr NativeFieldInfoPtr_StandPoint;

		// Token: 0x04007755 RID: 30549
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x04007756 RID: 30550
		private static readonly IntPtr NativeFieldInfoPtr_HatchOpenSound;

		// Token: 0x04007757 RID: 30551
		private static readonly IntPtr NativeFieldInfoPtr_HatchCloseSound;

		// Token: 0x04007758 RID: 30552
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04007759 RID: 30553
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x0400775A RID: 30554
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotPosition;

		// Token: 0x0400775B RID: 30555
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotPosition;

		// Token: 0x0400775C RID: 30556
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotPosition;

		// Token: 0x0400775D RID: 30557
		private static readonly IntPtr NativeFieldInfoPtr_LightMeshOnMat;

		// Token: 0x0400775E RID: 30558
		private static readonly IntPtr NativeFieldInfoPtr_LightMeshOffMat;

		// Token: 0x0400775F RID: 30559
		private static readonly IntPtr NativeFieldInfoPtr_PackagerEmployeeSpeedMultiplier;

		// Token: 0x04007760 RID: 30560
		private static readonly IntPtr NativeFieldInfoPtr_HatchClosedRotation;

		// Token: 0x04007761 RID: 30561
		private static readonly IntPtr NativeFieldInfoPtr_HatchOpenRotation;

		// Token: 0x04007762 RID: 30562
		private static readonly IntPtr NativeFieldInfoPtr_HatchLerpTime;

		// Token: 0x04007763 RID: 30563
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04007764 RID: 30564
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04007765 RID: 30565
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlot;

		// Token: 0x04007766 RID: 30566
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlot;

		// Token: 0x04007767 RID: 30567
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlot;

		// Token: 0x04007768 RID: 30568
		private static readonly IntPtr NativeFieldInfoPtr_hatchOpen;

		// Token: 0x04007769 RID: 30569
		private static readonly IntPtr NativeFieldInfoPtr_hatchRoutine;

		// Token: 0x0400776A RID: 30570
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSlotModelID;

		// Token: 0x0400776B RID: 30571
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotModelID;

		// Token: 0x0400776C RID: 30572
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x0400776D RID: 30573
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x0400776E RID: 30574
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x0400776F RID: 30575
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04007770 RID: 30576
		private static readonly IntPtr NativeFieldInfoPtr__stationConfiguration_k__BackingField;

		// Token: 0x04007771 RID: 30577
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04007772 RID: 30578
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04007773 RID: 30579
		private static readonly IntPtr NativeFieldInfoPtr_visualsLocked;

		// Token: 0x04007774 RID: 30580
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04007775 RID: 30581
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04007776 RID: 30582
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04007777 RID: 30583
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007778 RID: 30584
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007779 RID: 30585
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400777A RID: 30586
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400777B RID: 30587
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400777C RID: 30588
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400777D RID: 30589
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x0400777E RID: 30590
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400777F RID: 30591
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04007780 RID: 30592
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04007781 RID: 30593
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04007782 RID: 30594
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04007783 RID: 30595
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04007784 RID: 30596
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007785 RID: 30597
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04007786 RID: 30598
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007787 RID: 30599
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007788 RID: 30600
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007789 RID: 30601
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x0400778A RID: 30602
		private static readonly IntPtr NativeMethodInfoPtr_get_stationConfiguration_Protected_get_PackagingStationConfiguration_0;

		// Token: 0x0400778B RID: 30603
		private static readonly IntPtr NativeMethodInfoPtr_set_stationConfiguration_Protected_set_Void_PackagingStationConfiguration_0;

		// Token: 0x0400778C RID: 30604
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x0400778D RID: 30605
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x0400778E RID: 30606
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x0400778F RID: 30607
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04007790 RID: 30608
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007791 RID: 30609
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007792 RID: 30610
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007793 RID: 30611
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04007794 RID: 30612
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007795 RID: 30613
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04007796 RID: 30614
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007797 RID: 30615
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007798 RID: 30616
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04007799 RID: 30617
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400779A RID: 30618
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x0400779B RID: 30619
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400779C RID: 30620
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x0400779D RID: 30621
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400779E RID: 30622
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400779F RID: 30623
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040077A0 RID: 30624
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040077A1 RID: 30625
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040077A2 RID: 30626
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040077A3 RID: 30627
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040077A4 RID: 30628
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_EState_EMode_0;

		// Token: 0x040077A5 RID: 30629
		private static readonly IntPtr NativeMethodInfoPtr_Unpack_Public_Void_0;

		// Token: 0x040077A6 RID: 30630
		private static readonly IntPtr NativeMethodInfoPtr_PackSingleInstance_Public_Void_0;

		// Token: 0x040077A7 RID: 30631
		private static readonly IntPtr NativeMethodInfoPtr_SetHatchOpen_Public_Void_Boolean_0;

		// Token: 0x040077A8 RID: 30632
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_0;

		// Token: 0x040077A9 RID: 30633
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualsLocked_Public_Void_Boolean_0;

		// Token: 0x040077AA RID: 30634
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePackagingVisuals_Public_Void_Int32_0;

		// Token: 0x040077AB RID: 30635
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_0;

		// Token: 0x040077AC RID: 30636
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProductVisuals_Public_Void_Int32_0;

		// Token: 0x040077AD RID: 30637
		private static readonly IntPtr NativeMethodInfoPtr_StartTask_Public_Virtual_New_Void_0;

		// Token: 0x040077AE RID: 30638
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077AF RID: 30639
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077B0 RID: 30640
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x040077B1 RID: 30641
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x040077B2 RID: 30642
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077B3 RID: 30643
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077B4 RID: 30644
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x040077B5 RID: 30645
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x040077B6 RID: 30646
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040077B7 RID: 30647
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x040077B8 RID: 30648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040077B9 RID: 30649
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040077BA RID: 30650
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040077BB RID: 30651
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040077BC RID: 30652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040077BD RID: 30653
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040077BE RID: 30654
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077BF RID: 30655
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040077C0 RID: 30656
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040077C1 RID: 30657
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077C2 RID: 30658
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040077C3 RID: 30659
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040077C4 RID: 30660
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077C5 RID: 30661
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077C6 RID: 30662
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077C7 RID: 30663
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077C8 RID: 30664
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077C9 RID: 30665
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077CA RID: 30666
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077CB RID: 30667
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040077CC RID: 30668
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077CD RID: 30669
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040077CE RID: 30670
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x040077CF RID: 30671
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077D0 RID: 30672
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040077D1 RID: 30673
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x040077D2 RID: 30674
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077D3 RID: 30675
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077D4 RID: 30676
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077D5 RID: 30677
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077D6 RID: 30678
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077D7 RID: 30679
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077D8 RID: 30680
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077D9 RID: 30681
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040077DA RID: 30682
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077DB RID: 30683
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040077DC RID: 30684
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040077DD RID: 30685
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_PackagingStation_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040077DE RID: 30686
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040077DF RID: 30687
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040077E0 RID: 30688
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040077E1 RID: 30689
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040077E2 RID: 30690
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BF0 RID: 3056
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x0400959B RID: 38299
			Package,
			// Token: 0x0400959C RID: 38300
			Unpackage
		}

		// Token: 0x02000BF1 RID: 3057
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400959E RID: 38302
			CanBegin,
			// Token: 0x0400959F RID: 38303
			MissingItems,
			// Token: 0x040095A0 RID: 38304
			InsufficentProduct,
			// Token: 0x040095A1 RID: 38305
			OutputSlotFull,
			// Token: 0x040095A2 RID: 38306
			Mismatch,
			// Token: 0x040095A3 RID: 38307
			PackageSlotFull,
			// Token: 0x040095A4 RID: 38308
			ProductSlotFull
		}

		// Token: 0x02000BF2 RID: 3058
		[ObfuscatedName("ScheduleOne.ObjectScripts.PackagingStation+<>c__DisplayClass103_0")]
		public sealed class __c__DisplayClass103_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF5F RID: 57183 RVA: 0x0034A380 File Offset: 0x00348580
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass103_0()
			{
				Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<>c__DisplayClass103_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr);
				PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, "<>4__this");
				PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, "conn");
				PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, 100685185);
				PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, 100685186);
				PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, 100685187);
			}

			// Token: 0x0600DF60 RID: 57184 RVA: 0x0034A410 File Offset: 0x00348610
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass103_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF61 RID: 57185 RVA: 0x0034A44C File Offset: 0x0034864C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305109, XrefRangeEnd = 305114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF62 RID: 57186 RVA: 0x0034A48C File Offset: 0x0034868C
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF63 RID: 57187 RVA: 0x0006CE99 File Offset: 0x0006B099
			public __c__DisplayClass103_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004539 RID: 17721
			// (get) Token: 0x0600DF64 RID: 57188 RVA: 0x0034A4C8 File Offset: 0x003486C8
			// (set) Token: 0x0600DF65 RID: 57189 RVA: 0x0006CEA2 File Offset: 0x0006B0A2
			public unsafe PackagingStation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453A RID: 17722
			// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x0034A4F8 File Offset: 0x003486F8
			// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x0006CEC1 File Offset: 0x0006B0C1
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095A5 RID: 38309
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095A6 RID: 38310
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040095A7 RID: 38311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095A8 RID: 38312
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040095A9 RID: 38313
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C8D RID: 3213
			[ObfuscatedName("ScheduleOne.ObjectScripts.PackagingStation+<>c__DisplayClass103_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E736 RID: 59190 RVA: 0x00361214 File Offset: 0x0035F414
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685188);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685189);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685190);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685191);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685192);
					PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100685193);
				}

				// Token: 0x0600E737 RID: 59191 RVA: 0x003612F4 File Offset: 0x0035F4F4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E738 RID: 59192 RVA: 0x0036133C File Offset: 0x0035F53C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E739 RID: 59193 RVA: 0x00361370 File Offset: 0x0035F570
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305093, XrefRangeEnd = 305104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700480B RID: 18443
				// (get) Token: 0x0600E73A RID: 59194 RVA: 0x003613AC File Offset: 0x0035F5AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E73B RID: 59195 RVA: 0x003613EC File Offset: 0x0035F5EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305104, XrefRangeEnd = 305109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700480C RID: 18444
				// (get) Token: 0x0600E73C RID: 59196 RVA: 0x00361420 File Offset: 0x0035F620
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E73D RID: 59197 RVA: 0x00070DC1 File Offset: 0x0006EFC1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004808 RID: 18440
				// (get) Token: 0x0600E73E RID: 59198 RVA: 0x00361460 File Offset: 0x0035F660
				// (set) Token: 0x0600E73F RID: 59199 RVA: 0x00070DCA File Offset: 0x0006EFCA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004809 RID: 18441
				// (get) Token: 0x0600E740 RID: 59200 RVA: 0x00361488 File Offset: 0x0035F688
				// (set) Token: 0x0600E741 RID: 59201 RVA: 0x00070DE5 File Offset: 0x0006EFE5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700480A RID: 18442
				// (get) Token: 0x0600E742 RID: 59202 RVA: 0x003614B8 File Offset: 0x0035F6B8
				// (set) Token: 0x0600E743 RID: 59203 RVA: 0x00070E04 File Offset: 0x0006F004
				public unsafe PackagingStation.__c__DisplayClass103_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation.__c__DisplayClass103_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass103_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A7F RID: 39551
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A80 RID: 39552
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A81 RID: 39553
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A82 RID: 39554
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A83 RID: 39555
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A84 RID: 39556
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A85 RID: 39557
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A86 RID: 39558
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A87 RID: 39559
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BF3 RID: 3059
		[ObfuscatedName("ScheduleOne.ObjectScripts.PackagingStation+<>c__DisplayClass116_0")]
		public sealed class __c__DisplayClass116_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF68 RID: 57192 RVA: 0x0034A528 File Offset: 0x00348728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass116_0()
			{
				Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStation>.NativeClassPtr, "<>c__DisplayClass116_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr);
				PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr, "<>4__this");
				PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr, "open");
				PackagingStation.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr, 100685194);
				PackagingStation.__c__DisplayClass116_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr, 100685195);
			}

			// Token: 0x0600DF69 RID: 57193 RVA: 0x0034A5A4 File Offset: 0x003487A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass116_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF6A RID: 57194 RVA: 0x0034A5E0 File Offset: 0x003487E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305134, XrefRangeEnd = 305139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF6B RID: 57195 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
			public __c__DisplayClass116_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453B RID: 17723
			// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x0034A620 File Offset: 0x00348820
			// (set) Token: 0x0600DF6D RID: 57197 RVA: 0x0006CEE9 File Offset: 0x0006B0E9
			public unsafe PackagingStation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453C RID: 17724
			// (get) Token: 0x0600DF6E RID: 57198 RVA: 0x0034A650 File Offset: 0x00348850
			// (set) Token: 0x0600DF6F RID: 57199 RVA: 0x0006CF08 File Offset: 0x0006B108
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x040095AA RID: 38314
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095AB RID: 38315
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x040095AC RID: 38316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095AD RID: 38317
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C8E RID: 3214
			[ObfuscatedName("ScheduleOne.ObjectScripts.PackagingStation+<>c__DisplayClass116_0+<<SetHatchOpen>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E744 RID: 59204 RVA: 0x003614E8 File Offset: 0x0035F6E8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique()
				{
					Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0>.NativeClassPtr, "<<SetHatchOpen>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<>1__state");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<>2__current");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<>4__this");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<startRot>5__2");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__endRot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<endRot>5__3");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, "<i>5__4");
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685196);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685197);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685198);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685199);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685200);
					PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr, 100685201);
				}

				// Token: 0x0600E745 RID: 59205 RVA: 0x00361604 File Offset: 0x0035F804
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E746 RID: 59206 RVA: 0x0036164C File Offset: 0x0035F84C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E747 RID: 59207 RVA: 0x00361680 File Offset: 0x0035F880
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305114, XrefRangeEnd = 305129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004813 RID: 18451
				// (get) Token: 0x0600E748 RID: 59208 RVA: 0x003616BC File Offset: 0x0035F8BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E749 RID: 59209 RVA: 0x003616FC File Offset: 0x0035F8FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305129, XrefRangeEnd = 305134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004814 RID: 18452
				// (get) Token: 0x0600E74A RID: 59210 RVA: 0x00361730 File Offset: 0x0035F930
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E74B RID: 59211 RVA: 0x00070E23 File Offset: 0x0006F023
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700480D RID: 18445
				// (get) Token: 0x0600E74C RID: 59212 RVA: 0x00361770 File Offset: 0x0035F970
				// (set) Token: 0x0600E74D RID: 59213 RVA: 0x00070E2C File Offset: 0x0006F02C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700480E RID: 18446
				// (get) Token: 0x0600E74E RID: 59214 RVA: 0x00361798 File Offset: 0x0035F998
				// (set) Token: 0x0600E74F RID: 59215 RVA: 0x00070E47 File Offset: 0x0006F047
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700480F RID: 18447
				// (get) Token: 0x0600E750 RID: 59216 RVA: 0x003617C8 File Offset: 0x0035F9C8
				// (set) Token: 0x0600E751 RID: 59217 RVA: 0x00070E66 File Offset: 0x0006F066
				public unsafe PackagingStation.__c__DisplayClass116_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation.__c__DisplayClass116_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004810 RID: 18448
				// (get) Token: 0x0600E752 RID: 59218 RVA: 0x003617F8 File Offset: 0x0035F9F8
				// (set) Token: 0x0600E753 RID: 59219 RVA: 0x00070E85 File Offset: 0x0006F085
				public unsafe Quaternion _startRot_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__startRot_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__startRot_5__2)) = value;
					}
				}

				// Token: 0x17004811 RID: 18449
				// (get) Token: 0x0600E754 RID: 59220 RVA: 0x00361820 File Offset: 0x0035FA20
				// (set) Token: 0x0600E755 RID: 59221 RVA: 0x00070EA0 File Offset: 0x0006F0A0
				public unsafe Quaternion _endRot_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__endRot_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__endRot_5__3)) = value;
					}
				}

				// Token: 0x17004812 RID: 18450
				// (get) Token: 0x0600E756 RID: 59222 RVA: 0x00361848 File Offset: 0x0035FA48
				// (set) Token: 0x0600E757 RID: 59223 RVA: 0x00070EBB File Offset: 0x0006F0BB
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStation.__c__DisplayClass116_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009A88 RID: 39560
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A89 RID: 39561
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A8A RID: 39562
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A8B RID: 39563
				private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

				// Token: 0x04009A8C RID: 39564
				private static readonly IntPtr NativeFieldInfoPtr__endRot_5__3;

				// Token: 0x04009A8D RID: 39565
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009A8E RID: 39566
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A8F RID: 39567
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A90 RID: 39568
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A91 RID: 39569
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A92 RID: 39570
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A93 RID: 39571
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
