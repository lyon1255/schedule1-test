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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000745 RID: 1861
	public class LabOven : GridItem
	{
		// Token: 0x0600AD77 RID: 44407 RVA: 0x002B4F0C File Offset: 0x002B310C
		// Note: this type is marked as 'beforefieldinit'.
		static LabOven()
		{
			Il2CppClassPointerStore<LabOven>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOven");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOven>.NativeClassPtr);
			LabOven.NativeFieldInfoPtr_SOLID_INGREDIENT_COOK_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "SOLID_INGREDIENT_COOK_LIMIT");
			LabOven.NativeFieldInfoPtr_FOV_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "FOV_OVERRIDE");
			LabOven.NativeFieldInfoPtr__CurrentOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<CurrentOperation>k__BackingField");
			LabOven.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<ItemSlots>k__BackingField");
			LabOven.NativeFieldInfoPtr_LightMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "LightMode");
			LabOven.NativeFieldInfoPtr_CameraPosition_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CameraPosition_Default");
			LabOven.NativeFieldInfoPtr_CameraPosition_Pour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CameraPosition_Pour");
			LabOven.NativeFieldInfoPtr_CameraPosition_PlaceItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CameraPosition_PlaceItems");
			LabOven.NativeFieldInfoPtr_CameraPosition_Breaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CameraPosition_Breaking");
			LabOven.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "IntObj");
			LabOven.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "Door");
			LabOven.NativeFieldInfoPtr_WireTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "WireTray");
			LabOven.NativeFieldInfoPtr_OvenLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "OvenLight");
			LabOven.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "Button");
			LabOven.NativeFieldInfoPtr_TimerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "TimerLabel");
			LabOven.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "Light");
			LabOven.NativeFieldInfoPtr_PourableContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "PourableContainer");
			LabOven.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ItemContainer");
			LabOven.NativeFieldInfoPtr_PourAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "PourAnimation");
			LabOven.NativeFieldInfoPtr_LiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "LiquidMesh");
			LabOven.NativeFieldInfoPtr_InputVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "InputVisuals");
			LabOven.NativeFieldInfoPtr_OutputVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "OutputVisuals");
			LabOven.NativeFieldInfoPtr_CookedLiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CookedLiquidMesh");
			LabOven.NativeFieldInfoPtr_RemoveTrayAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "RemoveTrayAnimation");
			LabOven.NativeFieldInfoPtr_SquareTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "SquareTray");
			LabOven.NativeFieldInfoPtr_HammerSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "HammerSpawnPoint");
			LabOven.NativeFieldInfoPtr_HammerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "HammerContainer");
			LabOven.NativeFieldInfoPtr_OafBastard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "OafBastard");
			LabOven.NativeFieldInfoPtr_DecalContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "DecalContainer");
			LabOven.NativeFieldInfoPtr_DecalMaxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "DecalMaxBounds");
			LabOven.NativeFieldInfoPtr_DecalMinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "DecalMinBounds");
			LabOven.NativeFieldInfoPtr_CookedLiquidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "CookedLiquidCollider");
			LabOven.NativeFieldInfoPtr_ShardSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ShardSpawnPoints");
			LabOven.NativeFieldInfoPtr_ShatterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ShatterParticles");
			LabOven.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "uiPoint");
			LabOven.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "accessPoints");
			LabOven.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "configReplicator");
			LabOven.NativeFieldInfoPtr_SolidIngredientSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "SolidIngredientSpawnPoints");
			LabOven.NativeFieldInfoPtr_TrayDetectionArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "TrayDetectionArea");
			LabOven.NativeFieldInfoPtr_ButtonSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ButtonSound");
			LabOven.NativeFieldInfoPtr_DingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "DingSound");
			LabOven.NativeFieldInfoPtr_RunLoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "RunLoopSound");
			LabOven.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ImpactSound");
			LabOven.NativeFieldInfoPtr_ShatterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "ShatterSound");
			LabOven.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "WorldspaceUIPrefab");
			LabOven.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "typeIcon");
			LabOven.NativeFieldInfoPtr_HammerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "HammerPrefab");
			LabOven.NativeFieldInfoPtr_SmashDecalPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "SmashDecalPrefab");
			LabOven.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			LabOven.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			LabOven.NativeFieldInfoPtr_IngredientSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "IngredientSlot");
			LabOven.NativeFieldInfoPtr_OutputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "OutputSlot");
			LabOven.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<InputSlots>k__BackingField");
			LabOven.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<OutputSlots>k__BackingField");
			LabOven.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<Selectable>k__BackingField");
			LabOven.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			LabOven.NativeFieldInfoPtr__ovenConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<ovenConfiguration>k__BackingField");
			LabOven.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			LabOven.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			LabOven.NativeFieldInfoPtr_pourableContainerDefaultPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "pourableContainerDefaultPos");
			LabOven.NativeFieldInfoPtr_pourableContainerDefaultRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "pourableContainerDefaultRot");
			LabOven.NativeFieldInfoPtr_squareTrayDefaultPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "squareTrayDefaultPos");
			LabOven.NativeFieldInfoPtr_squareTrayDefaultRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "squareTrayDefaultRot");
			LabOven.NativeFieldInfoPtr_decals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "decals");
			LabOven.NativeFieldInfoPtr_shards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "shards");
			LabOven.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			LabOven.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			LabOven.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			LabOven.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted");
			LabOven.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.LabOvenAssembly-CSharp.dll_Excuted");
			LabOven.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684628);
			LabOven.NativeMethodInfoPtr_get_CurrentOperation_Public_get_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684629);
			LabOven.NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684630);
			LabOven.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684631);
			LabOven.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684632);
			LabOven.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684633);
			LabOven.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684634);
			LabOven.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684635);
			LabOven.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684636);
			LabOven.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684637);
			LabOven.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684638);
			LabOven.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684639);
			LabOven.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684640);
			LabOven.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684641);
			LabOven.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684642);
			LabOven.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684643);
			LabOven.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684644);
			LabOven.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684645);
			LabOven.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684646);
			LabOven.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684647);
			LabOven.NativeMethodInfoPtr_get_ovenConfiguration_Protected_get_LabOvenConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684648);
			LabOven.NativeMethodInfoPtr_set_ovenConfiguration_Protected_set_Void_LabOvenConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684649);
			LabOven.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684650);
			LabOven.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684651);
			LabOven.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684652);
			LabOven.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684653);
			LabOven.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684654);
			LabOven.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684655);
			LabOven.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684656);
			LabOven.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684657);
			LabOven.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684658);
			LabOven.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684659);
			LabOven.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684660);
			LabOven.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684661);
			LabOven.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684662);
			LabOven.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684663);
			LabOven.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684664);
			LabOven.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684665);
			LabOven.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684666);
			LabOven.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684667);
			LabOven.NativeMethodInfoPtr_UpdateOvenAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684668);
			LabOven.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684669);
			LabOven.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684670);
			LabOven.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684671);
			LabOven.NativeMethodInfoPtr_SetOvenLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684672);
			LabOven.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684673);
			LabOven.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684674);
			LabOven.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684675);
			LabOven.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684676);
			LabOven.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684677);
			LabOven.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684678);
			LabOven.NativeMethodInfoPtr_IsIngredientCookable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684679);
			LabOven.NativeMethodInfoPtr_SendCookOperation_Public_Void_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684680);
			LabOven.NativeMethodInfoPtr_SetCookOperation_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684681);
			LabOven.NativeMethodInfoPtr_IsReadyToStart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684682);
			LabOven.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684683);
			LabOven.NativeMethodInfoPtr_CanOutputSpaceFitCurrentOperation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684684);
			LabOven.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684685);
			LabOven.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684686);
			LabOven.NativeMethodInfoPtr_CreateStationItems_Public_Il2CppReferenceArray_1_StationItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684687);
			LabOven.NativeMethodInfoPtr_ResetPourableContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684688);
			LabOven.NativeMethodInfoPtr_ResetSquareTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684689);
			LabOven.NativeMethodInfoPtr_CreateHammer_Public_LabOvenHammer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684690);
			LabOven.NativeMethodInfoPtr_CreateImpactEffects_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684691);
			LabOven.NativeMethodInfoPtr_Shatter_Public_Void_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684692);
			LabOven.NativeMethodInfoPtr_ClearShards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684693);
			LabOven.NativeMethodInfoPtr_ClearDecals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684694);
			LabOven.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684695);
			LabOven.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684696);
			LabOven.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684697);
			LabOven.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684698);
			LabOven.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684699);
			LabOven.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684700);
			LabOven.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684701);
			LabOven.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684702);
			LabOven.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684703);
			LabOven.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684704);
			LabOven.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684705);
			LabOven.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684706);
			LabOven.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684707);
			LabOven.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684708);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684709);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684710);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684711);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684712);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684713);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684714);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684715);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684716);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684717);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SendCookOperation_3708012700_Private_Void_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684718);
			LabOven.NativeMethodInfoPtr_RpcLogic___SendCookOperation_3708012700_Public_Void_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684719);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SendCookOperation_3708012700_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684720);
			LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684721);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetCookOperation_2611294368_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684722);
			LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684723);
			LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684724);
			LabOven.NativeMethodInfoPtr_RpcReader___Target_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684725);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684726);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684727);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684728);
			LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684729);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684730);
			LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684731);
			LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684732);
			LabOven.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684733);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684734);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684735);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684736);
			LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684737);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684738);
			LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684739);
			LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684740);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684741);
			LabOven.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684742);
			LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684743);
			LabOven.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684744);
			LabOven.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684745);
			LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684746);
			LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684747);
			LabOven.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684748);
			LabOven.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684749);
			LabOven.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_LabOven_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684750);
			LabOven.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684751);
			LabOven.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684752);
			LabOven.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684753);
			LabOven.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684754);
			LabOven.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven>.NativeClassPtr, 100684755);
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600AD78 RID: 44408 RVA: 0x002B5EB4 File Offset: 0x002B40B4
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300449, XrefRangeEnd = 300454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600AD79 RID: 44409 RVA: 0x002B5EF0 File Offset: 0x002B40F0
		// (set) Token: 0x0600AD7A RID: 44410 RVA: 0x002B5F30 File Offset: 0x002B4130
		public unsafe OvenCookOperation CurrentOperation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_CurrentOperation_Public_get_OvenCookOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OvenCookOperation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_OvenCookOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600AD7B RID: 44411 RVA: 0x002B5F74 File Offset: 0x002B4174
		// (set) Token: 0x0600AD7C RID: 44412 RVA: 0x002B5FB4 File Offset: 0x002B41B4
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 224434, RefRangeEnd = 224436, XrefRangeStart = 224434, XrefRangeEnd = 224436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600AD7D RID: 44413 RVA: 0x002B5FF8 File Offset: 0x002B41F8
		// (set) Token: 0x0600AD7E RID: 44414 RVA: 0x002B6038 File Offset: 0x002B4238
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300462, RefRangeEnd = 300464, XrefRangeStart = 300454, XrefRangeEnd = 300462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600AD7F RID: 44415 RVA: 0x002B607C File Offset: 0x002B427C
		// (set) Token: 0x0600AD80 RID: 44416 RVA: 0x002B60BC File Offset: 0x002B42BC
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300472, RefRangeEnd = 300474, XrefRangeStart = 300464, XrefRangeEnd = 300472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600AD81 RID: 44417 RVA: 0x002B6100 File Offset: 0x002B4300
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600AD82 RID: 44418 RVA: 0x002B6138 File Offset: 0x002B4338
		// (set) Token: 0x0600AD83 RID: 44419 RVA: 0x002B6178 File Offset: 0x002B4378
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600AD84 RID: 44420 RVA: 0x002B61BC File Offset: 0x002B43BC
		// (set) Token: 0x0600AD85 RID: 44421 RVA: 0x002B61FC File Offset: 0x002B43FC
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300474, XrefRangeEnd = 300475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600AD86 RID: 44422 RVA: 0x002B6240 File Offset: 0x002B4440
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600AD87 RID: 44423 RVA: 0x002B6280 File Offset: 0x002B4480
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600AD88 RID: 44424 RVA: 0x002B62C0 File Offset: 0x002B44C0
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600AD89 RID: 44425 RVA: 0x002B62FC File Offset: 0x002B44FC
		// (set) Token: 0x0600AD8A RID: 44426 RVA: 0x002B6338 File Offset: 0x002B4538
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600AD8B RID: 44427 RVA: 0x002B6378 File Offset: 0x002B4578
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 291506, RefRangeEnd = 291516, XrefRangeStart = 291506, XrefRangeEnd = 291516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600AD8C RID: 44428 RVA: 0x002B63B8 File Offset: 0x002B45B8
		// (set) Token: 0x0600AD8D RID: 44429 RVA: 0x002B63F8 File Offset: 0x002B45F8
		public unsafe LabOvenConfiguration ovenConfiguration
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 291506, RefRangeEnd = 291516, XrefRangeStart = 291506, XrefRangeEnd = 291516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_ovenConfiguration_Protected_get_LabOvenConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOvenConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_ovenConfiguration_Protected_set_Void_LabOvenConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600AD8E RID: 44430 RVA: 0x002B643C File Offset: 0x002B463C
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600AD8F RID: 44431 RVA: 0x002B647C File Offset: 0x002B467C
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 77736, RefRangeEnd = 77743, XrefRangeStart = 77736, XrefRangeEnd = 77743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600AD90 RID: 44432 RVA: 0x002B64B8 File Offset: 0x002B46B8
		// (set) Token: 0x0600AD91 RID: 44433 RVA: 0x002B64F8 File Offset: 0x002B46F8
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300475, XrefRangeEnd = 300476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x002B653C File Offset: 0x002B473C
		// (set) Token: 0x0600AD93 RID: 44435 RVA: 0x002B657C File Offset: 0x002B477C
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300484, RefRangeEnd = 300486, XrefRangeStart = 300476, XrefRangeEnd = 300484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x002B65C0 File Offset: 0x002B47C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300486, XrefRangeEnd = 300508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600AD95 RID: 44437 RVA: 0x002B6604 File Offset: 0x002B4804
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 295221, RefRangeEnd = 295232, XrefRangeStart = 295221, XrefRangeEnd = 295232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600AD96 RID: 44438 RVA: 0x002B6644 File Offset: 0x002B4844
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600AD97 RID: 44439 RVA: 0x002B6684 File Offset: 0x002B4884
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x002B66C4 File Offset: 0x002B48C4
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x002B6700 File Offset: 0x002B4900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300508, XrefRangeEnd = 300509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x002B673C File Offset: 0x002B493C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300509, XrefRangeEnd = 300556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x002B67CC File Offset: 0x002B49CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300556, XrefRangeEnd = 300578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x002B681C File Offset: 0x002B4A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300578, XrefRangeEnd = 300595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x002B6860 File Offset: 0x002B4A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300595, XrefRangeEnd = 300603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x002B6894 File Offset: 0x002B4A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300603, XrefRangeEnd = 300608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD9F RID: 44447 RVA: 0x002B68C8 File Offset: 0x002B4AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300608, XrefRangeEnd = 300613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsSkippped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSkippped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x002B6908 File Offset: 0x002B4B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300618, RefRangeEnd = 300620, XrefRangeStart = 300613, XrefRangeEnd = 300618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOvenAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_UpdateOvenAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x002B693C File Offset: 0x002B4B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300620, XrefRangeEnd = 300632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA2 RID: 44450 RVA: 0x002B6980 File Offset: 0x002B4B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300632, XrefRangeEnd = 300651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600ADA3 RID: 44451 RVA: 0x002B69E4 File Offset: 0x002B4BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300651, XrefRangeEnd = 300698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x002B6A30 File Offset: 0x002B4C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300698, XrefRangeEnd = 300700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOvenLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetOvenLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x002B6A70 File Offset: 0x002B4C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300722, RefRangeEnd = 300724, XrefRangeStart = 300700, XrefRangeEnd = 300722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x002B6AB4 File Offset: 0x002B4CB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300746, RefRangeEnd = 300749, XrefRangeStart = 300724, XrefRangeEnd = 300746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002B6AF8 File Offset: 0x002B4CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300749, XrefRangeEnd = 300760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x002B6B2C File Offset: 0x002B4D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300760, XrefRangeEnd = 300768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x002B6B60 File Offset: 0x002B4D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300812, RefRangeEnd = 300813, XrefRangeStart = 300768, XrefRangeEnd = 300812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x002B6B94 File Offset: 0x002B4D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300851, RefRangeEnd = 300852, XrefRangeStart = 300813, XrefRangeEnd = 300851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x002B6BC8 File Offset: 0x002B4DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300863, RefRangeEnd = 300866, XrefRangeStart = 300852, XrefRangeEnd = 300863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIngredientCookable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_IsIngredientCookable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ADAC RID: 44460 RVA: 0x002B6C04 File Offset: 0x002B4E04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 300887, RefRangeEnd = 300892, XrefRangeStart = 300866, XrefRangeEnd = 300887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCookOperation(OvenCookOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SendCookOperation_Public_Void_OvenCookOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAD RID: 44461 RVA: 0x002B6C48 File Offset: 0x002B4E48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 300936, RefRangeEnd = 300941, XrefRangeStart = 300892, XrefRangeEnd = 300936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCookOperation(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playButtonPress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetCookOperation_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAE RID: 44462 RVA: 0x002B6CAC File Offset: 0x002B4EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300953, RefRangeEnd = 300954, XrefRangeStart = 300941, XrefRangeEnd = 300953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_IsReadyToStart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ADAF RID: 44463 RVA: 0x002B6CE8 File Offset: 0x002B4EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300955, RefRangeEnd = 300956, XrefRangeStart = 300954, XrefRangeEnd = 300955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyForHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ADB0 RID: 44464 RVA: 0x002B6D24 File Offset: 0x002B4F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300966, RefRangeEnd = 300968, XrefRangeStart = 300956, XrefRangeEnd = 300966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOutputSpaceFitCurrentOperation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_CanOutputSpaceFitCurrentOperation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ADB1 RID: 44465 RVA: 0x002B6D60 File Offset: 0x002B4F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300968, XrefRangeEnd = 300970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB2 RID: 44466 RVA: 0x002B6DA0 File Offset: 0x002B4FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300975, RefRangeEnd = 300978, XrefRangeStart = 300970, XrefRangeEnd = 300975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x002B6DD4 File Offset: 0x002B4FD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301019, RefRangeEnd = 301021, XrefRangeStart = 300978, XrefRangeEnd = 301019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<StationItem> CreateStationItems(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_CreateStationItems_Public_Il2CppReferenceArray_1_StationItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StationItem>>(intPtr3) : null;
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x002B6E20 File Offset: 0x002B5020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301023, RefRangeEnd = 301024, XrefRangeStart = 301021, XrefRangeEnd = 301023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPourableContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_ResetPourableContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x002B6E54 File Offset: 0x002B5054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301028, RefRangeEnd = 301030, XrefRangeStart = 301024, XrefRangeEnd = 301028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetSquareTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_ResetSquareTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x002B6E88 File Offset: 0x002B5088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301046, RefRangeEnd = 301047, XrefRangeStart = 301030, XrefRangeEnd = 301046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenHammer CreateHammer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_CreateHammer_Public_LabOvenHammer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOvenHammer>(intPtr3) : null;
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x002B6EC8 File Offset: 0x002B50C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301069, RefRangeEnd = 301070, XrefRangeStart = 301047, XrefRangeEnd = 301069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateImpactEffects(Vector3 point, bool playSound = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_CreateImpactEffects_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x002B6F14 File Offset: 0x002B5114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301116, RefRangeEnd = 301118, XrefRangeStart = 301070, XrefRangeEnd = 301116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Shatter(int shardQuantity, GameObject shardPrefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shardQuantity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shardPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_Shatter_Public_Void_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADB9 RID: 44473 RVA: 0x002B6F64 File Offset: 0x002B5164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301130, RefRangeEnd = 301132, XrefRangeStart = 301118, XrefRangeEnd = 301130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearShards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_ClearShards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBA RID: 44474 RVA: 0x002B6F98 File Offset: 0x002B5198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301143, RefRangeEnd = 301146, XrefRangeStart = 301132, XrefRangeEnd = 301143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDecals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_ClearDecals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBB RID: 44475 RVA: 0x002B6FCC File Offset: 0x002B51CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301146, XrefRangeEnd = 301173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBC RID: 44476 RVA: 0x002B7030 File Offset: 0x002B5230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301198, RefRangeEnd = 301201, XrefRangeStart = 301173, XrefRangeEnd = 301198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBD RID: 44477 RVA: 0x002B7094 File Offset: 0x002B5294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301201, XrefRangeEnd = 301226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBE RID: 44478 RVA: 0x002B70E0 File Offset: 0x002B52E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301254, RefRangeEnd = 301257, XrefRangeStart = 301226, XrefRangeEnd = 301254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADBF RID: 44479 RVA: 0x002B712C File Offset: 0x002B532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301257, XrefRangeEnd = 301286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC0 RID: 44480 RVA: 0x002B71B0 File Offset: 0x002B53B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301336, RefRangeEnd = 301339, XrefRangeStart = 301286, XrefRangeEnd = 301336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC1 RID: 44481 RVA: 0x002B7234 File Offset: 0x002B5434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301366, RefRangeEnd = 301367, XrefRangeStart = 301339, XrefRangeEnd = 301366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600ADC2 RID: 44482 RVA: 0x002B7274 File Offset: 0x002B5474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301367, XrefRangeEnd = 301371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x002B72A8 File Offset: 0x002B54A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301371, XrefRangeEnd = 301405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x002B72EC File Offset: 0x002B54EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301405, XrefRangeEnd = 301427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x002B7348 File Offset: 0x002B5548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301427, XrefRangeEnd = 301457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOven() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOven>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x002B7384 File Offset: 0x002B5584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301457, XrefRangeEnd = 301574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x002B73C0 File Offset: 0x002B55C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301574, XrefRangeEnd = 301575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC8 RID: 44488 RVA: 0x002B73FC File Offset: 0x002B55FC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x002B7438 File Offset: 0x002B5638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301575, XrefRangeEnd = 301594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x002B747C File Offset: 0x002B567C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300484, RefRangeEnd = 300486, XrefRangeStart = 300484, XrefRangeEnd = 300486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x002B74C0 File Offset: 0x002B56C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301594, XrefRangeEnd = 301598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x002B7524 File Offset: 0x002B5724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301598, XrefRangeEnd = 301617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCD RID: 44493 RVA: 0x002B7568 File Offset: 0x002B5768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300472, RefRangeEnd = 300474, XrefRangeStart = 300472, XrefRangeEnd = 300474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x002B75AC File Offset: 0x002B57AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301617, XrefRangeEnd = 301621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x002B7610 File Offset: 0x002B5810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301621, XrefRangeEnd = 301640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x002B7654 File Offset: 0x002B5854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300462, RefRangeEnd = 300464, XrefRangeStart = 300462, XrefRangeEnd = 300464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x002B7698 File Offset: 0x002B5898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301640, XrefRangeEnd = 301644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x002B76FC File Offset: 0x002B58FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301644, XrefRangeEnd = 301663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCookOperation_3708012700(OvenCookOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SendCookOperation_3708012700_Private_Void_OvenCookOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x002B7740 File Offset: 0x002B5940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301663, XrefRangeEnd = 301664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCookOperation_3708012700(OvenCookOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SendCookOperation_3708012700_Public_Void_OvenCookOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x002B7784 File Offset: 0x002B5984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301664, XrefRangeEnd = 301668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCookOperation_3708012700(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SendCookOperation_3708012700_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x002B77E8 File Offset: 0x002B59E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301668, XrefRangeEnd = 301688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playButtonPress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD6 RID: 44502 RVA: 0x002B784C File Offset: 0x002B5A4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301702, RefRangeEnd = 301705, XrefRangeStart = 301688, XrefRangeEnd = 301702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playButtonPress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetCookOperation_2611294368_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD7 RID: 44503 RVA: 0x002B78B0 File Offset: 0x002B5AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301705, XrefRangeEnd = 301709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD8 RID: 44504 RVA: 0x002B7900 File Offset: 0x002B5B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301709, XrefRangeEnd = 301720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetCookOperation_2611294368(NetworkConnection conn, OvenCookOperation operation, bool playButtonPress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(operation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playButtonPress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADD9 RID: 44505 RVA: 0x002B7964 File Offset: 0x002B5B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301720, XrefRangeEnd = 301724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetCookOperation_2611294368(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Target_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDA RID: 44506 RVA: 0x002B79B4 File Offset: 0x002B5BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301724, XrefRangeEnd = 301737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDB RID: 44507 RVA: 0x002B7A18 File Offset: 0x002B5C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301737, XrefRangeEnd = 301741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDC RID: 44508 RVA: 0x002B7A7C File Offset: 0x002B5C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301741, XrefRangeEnd = 301749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDD RID: 44509 RVA: 0x002B7AE0 File Offset: 0x002B5CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301749, XrefRangeEnd = 301770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDE RID: 44510 RVA: 0x002B7B44 File Offset: 0x002B5D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301770, XrefRangeEnd = 301776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADDF RID: 44511 RVA: 0x002B7BA8 File Offset: 0x002B5DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301776, XrefRangeEnd = 301784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE0 RID: 44512 RVA: 0x002B7BF8 File Offset: 0x002B5DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301784, XrefRangeEnd = 301796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE1 RID: 44513 RVA: 0x002B7C5C File Offset: 0x002B5E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301796, XrefRangeEnd = 301805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x002B7CAC File Offset: 0x002B5EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301805, XrefRangeEnd = 301827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x002B7CF8 File Offset: 0x002B5EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301827, XrefRangeEnd = 301828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x002B7D44 File Offset: 0x002B5F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301828, XrefRangeEnd = 301835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE5 RID: 44517 RVA: 0x002B7DA8 File Offset: 0x002B5FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301835, XrefRangeEnd = 301857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE6 RID: 44518 RVA: 0x002B7DF4 File Offset: 0x002B5FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301862, RefRangeEnd = 301863, XrefRangeStart = 301857, XrefRangeEnd = 301862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE7 RID: 44519 RVA: 0x002B7E40 File Offset: 0x002B6040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301863, XrefRangeEnd = 301870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE8 RID: 44520 RVA: 0x002B7E90 File Offset: 0x002B6090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301870, XrefRangeEnd = 301885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADE9 RID: 44521 RVA: 0x002B7F14 File Offset: 0x002B6114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301885, XrefRangeEnd = 301889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADEA RID: 44522 RVA: 0x002B7F98 File Offset: 0x002B6198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301889, XrefRangeEnd = 301898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADEB RID: 44523 RVA: 0x002B7FFC File Offset: 0x002B61FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301898, XrefRangeEnd = 301912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADEC RID: 44524 RVA: 0x002B8080 File Offset: 0x002B6280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301920, RefRangeEnd = 301923, XrefRangeStart = 301912, XrefRangeEnd = 301920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADED RID: 44525 RVA: 0x002B8104 File Offset: 0x002B6304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301923, XrefRangeEnd = 301931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADEE RID: 44526 RVA: 0x002B8154 File Offset: 0x002B6354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301931, XrefRangeEnd = 301954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADEF RID: 44527 RVA: 0x002B81D8 File Offset: 0x002B63D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301954, XrefRangeEnd = 301961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600ADF0 RID: 44528 RVA: 0x002B8228 File Offset: 0x002B6428
		// (set) Token: 0x0600ADF1 RID: 44529 RVA: 0x002B8268 File Offset: 0x002B6468
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 301970, RefRangeEnd = 301972, XrefRangeStart = 301961, XrefRangeEnd = 301970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600ADF2 RID: 44530 RVA: 0x002B82B8 File Offset: 0x002B64B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301972, XrefRangeEnd = 301990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_LabOven(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_LabOven_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600ADF3 RID: 44531 RVA: 0x002B832C File Offset: 0x002B652C
		// (set) Token: 0x0600ADF4 RID: 44532 RVA: 0x002B836C File Offset: 0x002B656C
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 301999, RefRangeEnd = 302001, XrefRangeStart = 301990, XrefRangeEnd = 301999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600ADF5 RID: 44533 RVA: 0x002B83BC File Offset: 0x002B65BC
		// (set) Token: 0x0600ADF6 RID: 44534 RVA: 0x002B83FC File Offset: 0x002B65FC
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302010, RefRangeEnd = 302011, XrefRangeStart = 302001, XrefRangeEnd = 302010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600ADF7 RID: 44535 RVA: 0x002B844C File Offset: 0x002B664C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302027, RefRangeEnd = 302028, XrefRangeStart = 302011, XrefRangeEnd = 302027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOven.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADF8 RID: 44536 RVA: 0x00055381 File Offset: 0x00053581
		public LabOven(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600ADF9 RID: 44537 RVA: 0x002B8488 File Offset: 0x002B6688
		// (set) Token: 0x0600ADFA RID: 44538 RVA: 0x0005538A File Offset: 0x0005358A
		public unsafe static int SOLID_INGREDIENT_COOK_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LabOven.NativeFieldInfoPtr_SOLID_INGREDIENT_COOK_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOven.NativeFieldInfoPtr_SOLID_INGREDIENT_COOK_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600ADFB RID: 44539 RVA: 0x002B84A4 File Offset: 0x002B66A4
		// (set) Token: 0x0600ADFC RID: 44540 RVA: 0x00055398 File Offset: 0x00053598
		public unsafe static float FOV_OVERRIDE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOven.NativeFieldInfoPtr_FOV_OVERRIDE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOven.NativeFieldInfoPtr_FOV_OVERRIDE, (void*)(&value));
			}
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600ADFD RID: 44541 RVA: 0x002B84C0 File Offset: 0x002B66C0
		// (set) Token: 0x0600ADFE RID: 44542 RVA: 0x000553A6 File Offset: 0x000535A6
		public unsafe OvenCookOperation _CurrentOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__CurrentOperation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OvenCookOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__CurrentOperation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600ADFF RID: 44543 RVA: 0x002B84F0 File Offset: 0x002B66F0
		// (set) Token: 0x0600AE00 RID: 44544 RVA: 0x000553C5 File Offset: 0x000535C5
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600AE01 RID: 44545 RVA: 0x002B8520 File Offset: 0x002B6720
		// (set) Token: 0x0600AE02 RID: 44546 RVA: 0x000553E4 File Offset: 0x000535E4
		public unsafe LabOven.ELightMode LightMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_LightMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_LightMode)) = value;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600AE03 RID: 44547 RVA: 0x002B8548 File Offset: 0x002B6748
		// (set) Token: 0x0600AE04 RID: 44548 RVA: 0x000553FF File Offset: 0x000535FF
		public unsafe Transform CameraPosition_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Default);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Default), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x002B8578 File Offset: 0x002B6778
		// (set) Token: 0x0600AE06 RID: 44550 RVA: 0x0005541E File Offset: 0x0005361E
		public unsafe Transform CameraPosition_Pour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Pour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Pour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x002B85A8 File Offset: 0x002B67A8
		// (set) Token: 0x0600AE08 RID: 44552 RVA: 0x0005543D File Offset: 0x0005363D
		public unsafe Transform CameraPosition_PlaceItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_PlaceItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_PlaceItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x002B85D8 File Offset: 0x002B67D8
		// (set) Token: 0x0600AE0A RID: 44554 RVA: 0x0005545C File Offset: 0x0005365C
		public unsafe Transform CameraPosition_Breaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Breaking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CameraPosition_Breaking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x002B8608 File Offset: 0x002B6808
		// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x0005547B File Offset: 0x0005367B
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x002B8638 File Offset: 0x002B6838
		// (set) Token: 0x0600AE0E RID: 44558 RVA: 0x0005549A File Offset: 0x0005369A
		public unsafe LabOvenDoor Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x002B8668 File Offset: 0x002B6868
		// (set) Token: 0x0600AE10 RID: 44560 RVA: 0x000554B9 File Offset: 0x000536B9
		public unsafe LabOvenWireTray WireTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_WireTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenWireTray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_WireTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600AE11 RID: 44561 RVA: 0x002B8698 File Offset: 0x002B6898
		// (set) Token: 0x0600AE12 RID: 44562 RVA: 0x000554D8 File Offset: 0x000536D8
		public unsafe ToggleableLight OvenLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OvenLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OvenLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600AE13 RID: 44563 RVA: 0x002B86C8 File Offset: 0x002B68C8
		// (set) Token: 0x0600AE14 RID: 44564 RVA: 0x000554F7 File Offset: 0x000536F7
		public unsafe LabOvenButton Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x002B86F8 File Offset: 0x002B68F8
		// (set) Token: 0x0600AE16 RID: 44566 RVA: 0x00055516 File Offset: 0x00053716
		public unsafe TextMeshPro TimerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_TimerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_TimerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600AE17 RID: 44567 RVA: 0x002B8728 File Offset: 0x002B6928
		// (set) Token: 0x0600AE18 RID: 44568 RVA: 0x00055535 File Offset: 0x00053735
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600AE19 RID: 44569 RVA: 0x002B8758 File Offset: 0x002B6958
		// (set) Token: 0x0600AE1A RID: 44570 RVA: 0x00055554 File Offset: 0x00053754
		public unsafe Transform PourableContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_PourableContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_PourableContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x002B8788 File Offset: 0x002B6988
		// (set) Token: 0x0600AE1C RID: 44572 RVA: 0x00055573 File Offset: 0x00053773
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600AE1D RID: 44573 RVA: 0x002B87B8 File Offset: 0x002B69B8
		// (set) Token: 0x0600AE1E RID: 44574 RVA: 0x00055592 File Offset: 0x00053792
		public unsafe Animation PourAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_PourAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_PourAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600AE1F RID: 44575 RVA: 0x002B87E8 File Offset: 0x002B69E8
		// (set) Token: 0x0600AE20 RID: 44576 RVA: 0x000555B1 File Offset: 0x000537B1
		public unsafe SkinnedMeshRenderer LiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_LiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_LiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600AE21 RID: 44577 RVA: 0x002B8818 File Offset: 0x002B6A18
		// (set) Token: 0x0600AE22 RID: 44578 RVA: 0x000555D0 File Offset: 0x000537D0
		public unsafe StorageVisualizer InputVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_InputVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_InputVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600AE23 RID: 44579 RVA: 0x002B8848 File Offset: 0x002B6A48
		// (set) Token: 0x0600AE24 RID: 44580 RVA: 0x000555EF File Offset: 0x000537EF
		public unsafe StorageVisualizer OutputVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OutputVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OutputVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600AE25 RID: 44581 RVA: 0x002B8878 File Offset: 0x002B6A78
		// (set) Token: 0x0600AE26 RID: 44582 RVA: 0x0005560E File Offset: 0x0005380E
		public unsafe MeshRenderer CookedLiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CookedLiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CookedLiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600AE27 RID: 44583 RVA: 0x002B88A8 File Offset: 0x002B6AA8
		// (set) Token: 0x0600AE28 RID: 44584 RVA: 0x0005562D File Offset: 0x0005382D
		public unsafe Animation RemoveTrayAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_RemoveTrayAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_RemoveTrayAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600AE29 RID: 44585 RVA: 0x002B88D8 File Offset: 0x002B6AD8
		// (set) Token: 0x0600AE2A RID: 44586 RVA: 0x0005564C File Offset: 0x0005384C
		public unsafe Transform SquareTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SquareTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SquareTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x002B8908 File Offset: 0x002B6B08
		// (set) Token: 0x0600AE2C RID: 44588 RVA: 0x0005566B File Offset: 0x0005386B
		public unsafe Transform HammerSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600AE2D RID: 44589 RVA: 0x002B8938 File Offset: 0x002B6B38
		// (set) Token: 0x0600AE2E RID: 44590 RVA: 0x0005568A File Offset: 0x0005388A
		public unsafe Transform HammerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600AE2F RID: 44591 RVA: 0x002B8968 File Offset: 0x002B6B68
		// (set) Token: 0x0600AE30 RID: 44592 RVA: 0x000556A9 File Offset: 0x000538A9
		public unsafe Transform OafBastard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OafBastard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OafBastard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600AE31 RID: 44593 RVA: 0x002B8998 File Offset: 0x002B6B98
		// (set) Token: 0x0600AE32 RID: 44594 RVA: 0x000556C8 File Offset: 0x000538C8
		public unsafe Transform DecalContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600AE33 RID: 44595 RVA: 0x002B89C8 File Offset: 0x002B6BC8
		// (set) Token: 0x0600AE34 RID: 44596 RVA: 0x000556E7 File Offset: 0x000538E7
		public unsafe Transform DecalMaxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalMaxBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalMaxBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600AE35 RID: 44597 RVA: 0x002B89F8 File Offset: 0x002B6BF8
		// (set) Token: 0x0600AE36 RID: 44598 RVA: 0x00055706 File Offset: 0x00053906
		public unsafe Transform DecalMinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalMinBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DecalMinBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x002B8A28 File Offset: 0x002B6C28
		// (set) Token: 0x0600AE38 RID: 44600 RVA: 0x00055725 File Offset: 0x00053925
		public unsafe BoxCollider CookedLiquidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CookedLiquidCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_CookedLiquidCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600AE39 RID: 44601 RVA: 0x002B8A58 File Offset: 0x002B6C58
		// (set) Token: 0x0600AE3A RID: 44602 RVA: 0x00055744 File Offset: 0x00053944
		public unsafe Il2CppReferenceArray<Transform> ShardSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShardSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShardSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600AE3B RID: 44603 RVA: 0x002B8A88 File Offset: 0x002B6C88
		// (set) Token: 0x0600AE3C RID: 44604 RVA: 0x00055763 File Offset: 0x00053963
		public unsafe ParticleSystem ShatterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShatterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShatterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600AE3D RID: 44605 RVA: 0x002B8AB8 File Offset: 0x002B6CB8
		// (set) Token: 0x0600AE3E RID: 44606 RVA: 0x00055782 File Offset: 0x00053982
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600AE3F RID: 44607 RVA: 0x002B8AE8 File Offset: 0x002B6CE8
		// (set) Token: 0x0600AE40 RID: 44608 RVA: 0x000557A1 File Offset: 0x000539A1
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x002B8B18 File Offset: 0x002B6D18
		// (set) Token: 0x0600AE42 RID: 44610 RVA: 0x000557C0 File Offset: 0x000539C0
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600AE43 RID: 44611 RVA: 0x002B8B48 File Offset: 0x002B6D48
		// (set) Token: 0x0600AE44 RID: 44612 RVA: 0x000557DF File Offset: 0x000539DF
		public unsafe Il2CppReferenceArray<Transform> SolidIngredientSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SolidIngredientSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SolidIngredientSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600AE45 RID: 44613 RVA: 0x002B8B78 File Offset: 0x002B6D78
		// (set) Token: 0x0600AE46 RID: 44614 RVA: 0x000557FE File Offset: 0x000539FE
		public unsafe BoxCollider TrayDetectionArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_TrayDetectionArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_TrayDetectionArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600AE47 RID: 44615 RVA: 0x002B8BA8 File Offset: 0x002B6DA8
		// (set) Token: 0x0600AE48 RID: 44616 RVA: 0x0005581D File Offset: 0x00053A1D
		public unsafe AudioSourceController ButtonSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ButtonSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ButtonSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x002B8BD8 File Offset: 0x002B6DD8
		// (set) Token: 0x0600AE4A RID: 44618 RVA: 0x0005583C File Offset: 0x00053A3C
		public unsafe AudioSourceController DingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_DingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600AE4B RID: 44619 RVA: 0x002B8C08 File Offset: 0x002B6E08
		// (set) Token: 0x0600AE4C RID: 44620 RVA: 0x0005585B File Offset: 0x00053A5B
		public unsafe AudioSourceController RunLoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_RunLoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_RunLoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600AE4D RID: 44621 RVA: 0x002B8C38 File Offset: 0x002B6E38
		// (set) Token: 0x0600AE4E RID: 44622 RVA: 0x0005587A File Offset: 0x00053A7A
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600AE4F RID: 44623 RVA: 0x002B8C68 File Offset: 0x002B6E68
		// (set) Token: 0x0600AE50 RID: 44624 RVA: 0x00055899 File Offset: 0x00053A99
		public unsafe AudioSourceController ShatterSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShatterSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_ShatterSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600AE51 RID: 44625 RVA: 0x002B8C98 File Offset: 0x002B6E98
		// (set) Token: 0x0600AE52 RID: 44626 RVA: 0x000558B8 File Offset: 0x00053AB8
		public unsafe LabOvenUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x002B8CC8 File Offset: 0x002B6EC8
		// (set) Token: 0x0600AE54 RID: 44628 RVA: 0x000558D7 File Offset: 0x00053AD7
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600AE55 RID: 44629 RVA: 0x002B8CF8 File Offset: 0x002B6EF8
		// (set) Token: 0x0600AE56 RID: 44630 RVA: 0x000558F6 File Offset: 0x00053AF6
		public unsafe LabOvenHammer HammerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenHammer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_HammerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600AE57 RID: 44631 RVA: 0x002B8D28 File Offset: 0x002B6F28
		// (set) Token: 0x0600AE58 RID: 44632 RVA: 0x00055915 File Offset: 0x00053B15
		public unsafe GameObject SmashDecalPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SmashDecalPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_SmashDecalPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600AE59 RID: 44633 RVA: 0x002B8D58 File Offset: 0x002B6F58
		// (set) Token: 0x0600AE5A RID: 44634 RVA: 0x00055934 File Offset: 0x00053B34
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x002B8D88 File Offset: 0x002B6F88
		// (set) Token: 0x0600AE5C RID: 44636 RVA: 0x00055953 File Offset: 0x00053B53
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x002B8DB8 File Offset: 0x002B6FB8
		// (set) Token: 0x0600AE5E RID: 44638 RVA: 0x00055972 File Offset: 0x00053B72
		public unsafe ItemSlot IngredientSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_IngredientSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_IngredientSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x002B8DE8 File Offset: 0x002B6FE8
		// (set) Token: 0x0600AE60 RID: 44640 RVA: 0x00055991 File Offset: 0x00053B91
		public unsafe ItemSlot OutputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OutputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_OutputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600AE61 RID: 44641 RVA: 0x002B8E18 File Offset: 0x002B7018
		// (set) Token: 0x0600AE62 RID: 44642 RVA: 0x000559B0 File Offset: 0x00053BB0
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600AE63 RID: 44643 RVA: 0x002B8E48 File Offset: 0x002B7048
		// (set) Token: 0x0600AE64 RID: 44644 RVA: 0x000559CF File Offset: 0x00053BCF
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600AE65 RID: 44645 RVA: 0x002B8E78 File Offset: 0x002B7078
		// (set) Token: 0x0600AE66 RID: 44646 RVA: 0x000559EE File Offset: 0x00053BEE
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600AE67 RID: 44647 RVA: 0x002B8EA0 File Offset: 0x002B70A0
		// (set) Token: 0x0600AE68 RID: 44648 RVA: 0x00055A09 File Offset: 0x00053C09
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x002B8EC8 File Offset: 0x002B70C8
		// (set) Token: 0x0600AE6A RID: 44650 RVA: 0x00055A24 File Offset: 0x00053C24
		public unsafe LabOvenConfiguration _ovenConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__ovenConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__ovenConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x002B8EF8 File Offset: 0x002B70F8
		// (set) Token: 0x0600AE6C RID: 44652 RVA: 0x00055A43 File Offset: 0x00053C43
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600AE6D RID: 44653 RVA: 0x002B8F28 File Offset: 0x002B7128
		// (set) Token: 0x0600AE6E RID: 44654 RVA: 0x00055A62 File Offset: 0x00053C62
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x002B8F58 File Offset: 0x002B7158
		// (set) Token: 0x0600AE70 RID: 44656 RVA: 0x00055A81 File Offset: 0x00053C81
		public unsafe Vector3 pourableContainerDefaultPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_pourableContainerDefaultPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_pourableContainerDefaultPos)) = value;
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x002B8F80 File Offset: 0x002B7180
		// (set) Token: 0x0600AE72 RID: 44658 RVA: 0x00055A9C File Offset: 0x00053C9C
		public unsafe Quaternion pourableContainerDefaultRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_pourableContainerDefaultRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_pourableContainerDefaultRot)) = value;
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x002B8FA8 File Offset: 0x002B71A8
		// (set) Token: 0x0600AE74 RID: 44660 RVA: 0x00055AB7 File Offset: 0x00053CB7
		public unsafe Vector3 squareTrayDefaultPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_squareTrayDefaultPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_squareTrayDefaultPos)) = value;
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600AE75 RID: 44661 RVA: 0x002B8FD0 File Offset: 0x002B71D0
		// (set) Token: 0x0600AE76 RID: 44662 RVA: 0x00055AD2 File Offset: 0x00053CD2
		public unsafe Quaternion squareTrayDefaultRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_squareTrayDefaultRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_squareTrayDefaultRot)) = value;
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600AE77 RID: 44663 RVA: 0x002B8FF8 File Offset: 0x002B71F8
		// (set) Token: 0x0600AE78 RID: 44664 RVA: 0x00055AED File Offset: 0x00053CED
		public unsafe List<GameObject> decals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_decals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_decals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600AE79 RID: 44665 RVA: 0x002B9028 File Offset: 0x002B7228
		// (set) Token: 0x0600AE7A RID: 44666 RVA: 0x00055B0C File Offset: 0x00053D0C
		public unsafe List<GameObject> shards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_shards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_shards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x002B9058 File Offset: 0x002B7258
		// (set) Token: 0x0600AE7C RID: 44668 RVA: 0x00055B2B File Offset: 0x00053D2B
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600AE7D RID: 44669 RVA: 0x002B9088 File Offset: 0x002B7288
		// (set) Token: 0x0600AE7E RID: 44670 RVA: 0x00055B4A File Offset: 0x00053D4A
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600AE7F RID: 44671 RVA: 0x002B90B8 File Offset: 0x002B72B8
		// (set) Token: 0x0600AE80 RID: 44672 RVA: 0x00055B69 File Offset: 0x00053D69
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600AE81 RID: 44673 RVA: 0x002B90E8 File Offset: 0x002B72E8
		// (set) Token: 0x0600AE82 RID: 44674 RVA: 0x00055B88 File Offset: 0x00053D88
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600AE83 RID: 44675 RVA: 0x002B9110 File Offset: 0x002B7310
		// (set) Token: 0x0600AE84 RID: 44676 RVA: 0x00055BA3 File Offset: 0x00053DA3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040074B8 RID: 29880
		private static readonly IntPtr NativeFieldInfoPtr_SOLID_INGREDIENT_COOK_LIMIT;

		// Token: 0x040074B9 RID: 29881
		private static readonly IntPtr NativeFieldInfoPtr_FOV_OVERRIDE;

		// Token: 0x040074BA RID: 29882
		private static readonly IntPtr NativeFieldInfoPtr__CurrentOperation_k__BackingField;

		// Token: 0x040074BB RID: 29883
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x040074BC RID: 29884
		private static readonly IntPtr NativeFieldInfoPtr_LightMode;

		// Token: 0x040074BD RID: 29885
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition_Default;

		// Token: 0x040074BE RID: 29886
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition_Pour;

		// Token: 0x040074BF RID: 29887
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition_PlaceItems;

		// Token: 0x040074C0 RID: 29888
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition_Breaking;

		// Token: 0x040074C1 RID: 29889
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040074C2 RID: 29890
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x040074C3 RID: 29891
		private static readonly IntPtr NativeFieldInfoPtr_WireTray;

		// Token: 0x040074C4 RID: 29892
		private static readonly IntPtr NativeFieldInfoPtr_OvenLight;

		// Token: 0x040074C5 RID: 29893
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040074C6 RID: 29894
		private static readonly IntPtr NativeFieldInfoPtr_TimerLabel;

		// Token: 0x040074C7 RID: 29895
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040074C8 RID: 29896
		private static readonly IntPtr NativeFieldInfoPtr_PourableContainer;

		// Token: 0x040074C9 RID: 29897
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040074CA RID: 29898
		private static readonly IntPtr NativeFieldInfoPtr_PourAnimation;

		// Token: 0x040074CB RID: 29899
		private static readonly IntPtr NativeFieldInfoPtr_LiquidMesh;

		// Token: 0x040074CC RID: 29900
		private static readonly IntPtr NativeFieldInfoPtr_InputVisuals;

		// Token: 0x040074CD RID: 29901
		private static readonly IntPtr NativeFieldInfoPtr_OutputVisuals;

		// Token: 0x040074CE RID: 29902
		private static readonly IntPtr NativeFieldInfoPtr_CookedLiquidMesh;

		// Token: 0x040074CF RID: 29903
		private static readonly IntPtr NativeFieldInfoPtr_RemoveTrayAnimation;

		// Token: 0x040074D0 RID: 29904
		private static readonly IntPtr NativeFieldInfoPtr_SquareTray;

		// Token: 0x040074D1 RID: 29905
		private static readonly IntPtr NativeFieldInfoPtr_HammerSpawnPoint;

		// Token: 0x040074D2 RID: 29906
		private static readonly IntPtr NativeFieldInfoPtr_HammerContainer;

		// Token: 0x040074D3 RID: 29907
		private static readonly IntPtr NativeFieldInfoPtr_OafBastard;

		// Token: 0x040074D4 RID: 29908
		private static readonly IntPtr NativeFieldInfoPtr_DecalContainer;

		// Token: 0x040074D5 RID: 29909
		private static readonly IntPtr NativeFieldInfoPtr_DecalMaxBounds;

		// Token: 0x040074D6 RID: 29910
		private static readonly IntPtr NativeFieldInfoPtr_DecalMinBounds;

		// Token: 0x040074D7 RID: 29911
		private static readonly IntPtr NativeFieldInfoPtr_CookedLiquidCollider;

		// Token: 0x040074D8 RID: 29912
		private static readonly IntPtr NativeFieldInfoPtr_ShardSpawnPoints;

		// Token: 0x040074D9 RID: 29913
		private static readonly IntPtr NativeFieldInfoPtr_ShatterParticles;

		// Token: 0x040074DA RID: 29914
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x040074DB RID: 29915
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x040074DC RID: 29916
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x040074DD RID: 29917
		private static readonly IntPtr NativeFieldInfoPtr_SolidIngredientSpawnPoints;

		// Token: 0x040074DE RID: 29918
		private static readonly IntPtr NativeFieldInfoPtr_TrayDetectionArea;

		// Token: 0x040074DF RID: 29919
		private static readonly IntPtr NativeFieldInfoPtr_ButtonSound;

		// Token: 0x040074E0 RID: 29920
		private static readonly IntPtr NativeFieldInfoPtr_DingSound;

		// Token: 0x040074E1 RID: 29921
		private static readonly IntPtr NativeFieldInfoPtr_RunLoopSound;

		// Token: 0x040074E2 RID: 29922
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x040074E3 RID: 29923
		private static readonly IntPtr NativeFieldInfoPtr_ShatterSound;

		// Token: 0x040074E4 RID: 29924
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x040074E5 RID: 29925
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x040074E6 RID: 29926
		private static readonly IntPtr NativeFieldInfoPtr_HammerPrefab;

		// Token: 0x040074E7 RID: 29927
		private static readonly IntPtr NativeFieldInfoPtr_SmashDecalPrefab;

		// Token: 0x040074E8 RID: 29928
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x040074E9 RID: 29929
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x040074EA RID: 29930
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlot;

		// Token: 0x040074EB RID: 29931
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlot;

		// Token: 0x040074EC RID: 29932
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x040074ED RID: 29933
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x040074EE RID: 29934
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x040074EF RID: 29935
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x040074F0 RID: 29936
		private static readonly IntPtr NativeFieldInfoPtr__ovenConfiguration_k__BackingField;

		// Token: 0x040074F1 RID: 29937
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x040074F2 RID: 29938
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x040074F3 RID: 29939
		private static readonly IntPtr NativeFieldInfoPtr_pourableContainerDefaultPos;

		// Token: 0x040074F4 RID: 29940
		private static readonly IntPtr NativeFieldInfoPtr_pourableContainerDefaultRot;

		// Token: 0x040074F5 RID: 29941
		private static readonly IntPtr NativeFieldInfoPtr_squareTrayDefaultPos;

		// Token: 0x040074F6 RID: 29942
		private static readonly IntPtr NativeFieldInfoPtr_squareTrayDefaultRot;

		// Token: 0x040074F7 RID: 29943
		private static readonly IntPtr NativeFieldInfoPtr_decals;

		// Token: 0x040074F8 RID: 29944
		private static readonly IntPtr NativeFieldInfoPtr_shards;

		// Token: 0x040074F9 RID: 29945
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x040074FA RID: 29946
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x040074FB RID: 29947
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x040074FC RID: 29948
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040074FD RID: 29949
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040074FE RID: 29950
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040074FF RID: 29951
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentOperation_Public_get_OvenCookOperation_0;

		// Token: 0x04007500 RID: 29952
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentOperation_Private_set_Void_OvenCookOperation_0;

		// Token: 0x04007501 RID: 29953
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04007502 RID: 29954
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04007503 RID: 29955
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007504 RID: 29956
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007505 RID: 29957
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007506 RID: 29958
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04007507 RID: 29959
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04007508 RID: 29960
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04007509 RID: 29961
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400750A RID: 29962
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400750B RID: 29963
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400750C RID: 29964
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400750D RID: 29965
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x0400750E RID: 29966
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400750F RID: 29967
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04007510 RID: 29968
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04007511 RID: 29969
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04007512 RID: 29970
		private static readonly IntPtr NativeMethodInfoPtr_get_ovenConfiguration_Protected_get_LabOvenConfiguration_0;

		// Token: 0x04007513 RID: 29971
		private static readonly IntPtr NativeMethodInfoPtr_set_ovenConfiguration_Protected_set_Void_LabOvenConfiguration_0;

		// Token: 0x04007514 RID: 29972
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04007515 RID: 29973
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04007516 RID: 29974
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04007517 RID: 29975
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04007518 RID: 29976
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04007519 RID: 29977
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400751A RID: 29978
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400751B RID: 29979
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x0400751C RID: 29980
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400751D RID: 29981
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400751E RID: 29982
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400751F RID: 29983
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007520 RID: 29984
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04007521 RID: 29985
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007522 RID: 29986
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04007523 RID: 29987
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007524 RID: 29988
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007525 RID: 29989
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x04007526 RID: 29990
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOvenAppearance_Private_Void_0;

		// Token: 0x04007527 RID: 29991
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007528 RID: 29992
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007529 RID: 29993
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400752A RID: 29994
		private static readonly IntPtr NativeMethodInfoPtr_SetOvenLit_Public_Void_Boolean_0;

		// Token: 0x0400752B RID: 29995
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400752C RID: 29996
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400752D RID: 29997
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400752E RID: 29998
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400752F RID: 29999
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007530 RID: 30000
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007531 RID: 30001
		private static readonly IntPtr NativeMethodInfoPtr_IsIngredientCookable_Public_Boolean_0;

		// Token: 0x04007532 RID: 30002
		private static readonly IntPtr NativeMethodInfoPtr_SendCookOperation_Public_Void_OvenCookOperation_0;

		// Token: 0x04007533 RID: 30003
		private static readonly IntPtr NativeMethodInfoPtr_SetCookOperation_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0;

		// Token: 0x04007534 RID: 30004
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToStart_Public_Boolean_0;

		// Token: 0x04007535 RID: 30005
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_0;

		// Token: 0x04007536 RID: 30006
		private static readonly IntPtr NativeMethodInfoPtr_CanOutputSpaceFitCurrentOperation_Public_Boolean_0;

		// Token: 0x04007537 RID: 30007
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_0;

		// Token: 0x04007538 RID: 30008
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLiquid_Private_Void_0;

		// Token: 0x04007539 RID: 30009
		private static readonly IntPtr NativeMethodInfoPtr_CreateStationItems_Public_Il2CppReferenceArray_1_StationItem_Int32_0;

		// Token: 0x0400753A RID: 30010
		private static readonly IntPtr NativeMethodInfoPtr_ResetPourableContainer_Public_Void_0;

		// Token: 0x0400753B RID: 30011
		private static readonly IntPtr NativeMethodInfoPtr_ResetSquareTray_Public_Void_0;

		// Token: 0x0400753C RID: 30012
		private static readonly IntPtr NativeMethodInfoPtr_CreateHammer_Public_LabOvenHammer_0;

		// Token: 0x0400753D RID: 30013
		private static readonly IntPtr NativeMethodInfoPtr_CreateImpactEffects_Public_Void_Vector3_Boolean_0;

		// Token: 0x0400753E RID: 30014
		private static readonly IntPtr NativeMethodInfoPtr_Shatter_Public_Void_Int32_GameObject_0;

		// Token: 0x0400753F RID: 30015
		private static readonly IntPtr NativeMethodInfoPtr_ClearShards_Public_Void_0;

		// Token: 0x04007540 RID: 30016
		private static readonly IntPtr NativeMethodInfoPtr_ClearDecals_Public_Void_0;

		// Token: 0x04007541 RID: 30017
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007542 RID: 30018
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007543 RID: 30019
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04007544 RID: 30020
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04007545 RID: 30021
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007546 RID: 30022
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007547 RID: 30023
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04007548 RID: 30024
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04007549 RID: 30025
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400754A RID: 30026
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x0400754B RID: 30027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400754C RID: 30028
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400754D RID: 30029
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400754E RID: 30030
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400754F RID: 30031
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007550 RID: 30032
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007551 RID: 30033
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007552 RID: 30034
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007553 RID: 30035
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007554 RID: 30036
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007555 RID: 30037
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007556 RID: 30038
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007557 RID: 30039
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007558 RID: 30040
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCookOperation_3708012700_Private_Void_OvenCookOperation_0;

		// Token: 0x04007559 RID: 30041
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCookOperation_3708012700_Public_Void_OvenCookOperation_0;

		// Token: 0x0400755A RID: 30042
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCookOperation_3708012700_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400755B RID: 30043
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0;

		// Token: 0x0400755C RID: 30044
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCookOperation_2611294368_Public_Void_NetworkConnection_OvenCookOperation_Boolean_0;

		// Token: 0x0400755D RID: 30045
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400755E RID: 30046
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetCookOperation_2611294368_Private_Void_NetworkConnection_OvenCookOperation_Boolean_0;

		// Token: 0x0400755F RID: 30047
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetCookOperation_2611294368_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007560 RID: 30048
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007561 RID: 30049
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007562 RID: 30050
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007563 RID: 30051
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007564 RID: 30052
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007565 RID: 30053
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007566 RID: 30054
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04007567 RID: 30055
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007568 RID: 30056
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04007569 RID: 30057
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x0400756A RID: 30058
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400756B RID: 30059
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400756C RID: 30060
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400756D RID: 30061
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400756E RID: 30062
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400756F RID: 30063
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007570 RID: 30064
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007571 RID: 30065
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007572 RID: 30066
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007573 RID: 30067
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007574 RID: 30068
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04007575 RID: 30069
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007576 RID: 30070
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04007577 RID: 30071
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04007578 RID: 30072
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_LabOven_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04007579 RID: 30073
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400757A RID: 30074
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400757B RID: 30075
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400757C RID: 30076
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400757D RID: 30077
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BEB RID: 3051
		[OriginalName("Assembly-CSharp.dll", "", "ELightMode")]
		public enum ELightMode
		{
			// Token: 0x04009579 RID: 38265
			Off,
			// Token: 0x0400957A RID: 38266
			On,
			// Token: 0x0400957B RID: 38267
			Flash
		}

		// Token: 0x02000BEC RID: 3052
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400957D RID: 38269
			CanBegin,
			// Token: 0x0400957E RID: 38270
			MissingItems,
			// Token: 0x0400957F RID: 38271
			InsufficentProduct,
			// Token: 0x04009580 RID: 38272
			OutputSlotFull,
			// Token: 0x04009581 RID: 38273
			Mismatch
		}

		// Token: 0x02000BED RID: 3053
		[ObfuscatedName("ScheduleOne.ObjectScripts.LabOven+<>c__DisplayClass125_0")]
		public sealed class __c__DisplayClass125_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF35 RID: 57141 RVA: 0x00349C28 File Offset: 0x00347E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass125_0()
			{
				Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOven>.NativeClassPtr, "<>c__DisplayClass125_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr);
				LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, "<>4__this");
				LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, "conn");
				LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, 100684756);
				LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, 100684757);
				LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, 100684758);
			}

			// Token: 0x0600DF36 RID: 57142 RVA: 0x00349CB8 File Offset: 0x00347EB8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass125_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF37 RID: 57143 RVA: 0x00349CF4 File Offset: 0x00347EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300444, XrefRangeEnd = 300449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF38 RID: 57144 RVA: 0x00349D34 File Offset: 0x00347F34
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF39 RID: 57145 RVA: 0x0006CD1E File Offset: 0x0006AF1E
			public __c__DisplayClass125_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700452B RID: 17707
			// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x00349D70 File Offset: 0x00347F70
			// (set) Token: 0x0600DF3B RID: 57147 RVA: 0x0006CD27 File Offset: 0x0006AF27
			public unsafe LabOven __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452C RID: 17708
			// (get) Token: 0x0600DF3C RID: 57148 RVA: 0x00349DA0 File Offset: 0x00347FA0
			// (set) Token: 0x0600DF3D RID: 57149 RVA: 0x0006CD46 File Offset: 0x0006AF46
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009582 RID: 38274
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009583 RID: 38275
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04009584 RID: 38276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009585 RID: 38277
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009586 RID: 38278
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C8B RID: 3211
			[ObfuscatedName("ScheduleOne.ObjectScripts.LabOven+<>c__DisplayClass125_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E71A RID: 59162 RVA: 0x00360C6C File Offset: 0x0035EE6C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684759);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684760);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684761);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684762);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684763);
					LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684764);
				}

				// Token: 0x0600E71B RID: 59163 RVA: 0x00360D4C File Offset: 0x0035EF4C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E71C RID: 59164 RVA: 0x00360D94 File Offset: 0x0035EF94
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E71D RID: 59165 RVA: 0x00360DC8 File Offset: 0x0035EFC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300428, XrefRangeEnd = 300439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004801 RID: 18433
				// (get) Token: 0x0600E71E RID: 59166 RVA: 0x00360E04 File Offset: 0x0035F004
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E71F RID: 59167 RVA: 0x00360E44 File Offset: 0x0035F044
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300439, XrefRangeEnd = 300444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004802 RID: 18434
				// (get) Token: 0x0600E720 RID: 59168 RVA: 0x00360E78 File Offset: 0x0035F078
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E721 RID: 59169 RVA: 0x00070CFD File Offset: 0x0006EEFD
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047FE RID: 18430
				// (get) Token: 0x0600E722 RID: 59170 RVA: 0x00360EB8 File Offset: 0x0035F0B8
				// (set) Token: 0x0600E723 RID: 59171 RVA: 0x00070D06 File Offset: 0x0006EF06
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047FF RID: 18431
				// (get) Token: 0x0600E724 RID: 59172 RVA: 0x00360EE0 File Offset: 0x0035F0E0
				// (set) Token: 0x0600E725 RID: 59173 RVA: 0x00070D21 File Offset: 0x0006EF21
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004800 RID: 18432
				// (get) Token: 0x0600E726 RID: 59174 RVA: 0x00360F10 File Offset: 0x0035F110
				// (set) Token: 0x0600E727 RID: 59175 RVA: 0x00070D40 File Offset: 0x0006EF40
				public unsafe LabOven.__c__DisplayClass125_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven.__c__DisplayClass125_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOven.__c__DisplayClass125_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A6D RID: 39533
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A6E RID: 39534
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A6F RID: 39535
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A70 RID: 39536
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A71 RID: 39537
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A72 RID: 39538
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A73 RID: 39539
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A74 RID: 39540
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A75 RID: 39541
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
