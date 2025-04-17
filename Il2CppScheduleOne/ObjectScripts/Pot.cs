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
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000732 RID: 1842
	public class Pot : GridItem
	{
		// Token: 0x0600A76B RID: 42859 RVA: 0x0029D4B8 File Offset: 0x0029B6B8
		// Note: this type is marked as 'beforefieldinit'.
		static Pot()
		{
			Il2CppClassPointerStore<Pot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Pot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot>.NativeClassPtr);
			Pot.NativeFieldInfoPtr_DryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DryThreshold");
			Pot.NativeFieldInfoPtr_WaterloggedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterloggedThreshold");
			Pot.NativeFieldInfoPtr_ROTATION_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ROTATION_SPEED");
			Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MAX_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MIN_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_ModelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ModelTransform");
			Pot.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObj");
			Pot.NativeFieldInfoPtr_PourableStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PourableStartPoint");
			Pot.NativeFieldInfoPtr_SeedStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedStartPoint");
			Pot.NativeFieldInfoPtr_SeedRestingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedRestingPoint");
			Pot.NativeFieldInfoPtr_WaterLoggedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLoggedVisuals");
			Pot.NativeFieldInfoPtr_LookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LookAtPoint");
			Pot.NativeFieldInfoPtr_AdditivesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AdditivesContainer");
			Pot.NativeFieldInfoPtr_PlantContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PlantContainer");
			Pot.NativeFieldInfoPtr_IntObjLabel_Low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_Low");
			Pot.NativeFieldInfoPtr_IntObjLabel_High = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_High");
			Pot.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "uiPoint");
			Pot.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "configReplicator");
			Pot.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "accessPoints");
			Pot.NativeFieldInfoPtr_TaskBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "TaskBounds");
			Pot.NativeFieldInfoPtr_SoilCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCover");
			Pot.NativeFieldInfoPtr_LeafDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LeafDropPoint");
			Pot.NativeFieldInfoPtr_PoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofParticles");
			Pot.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofSound");
			Pot.NativeFieldInfoPtr_WaterCanvasContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCanvasContainer");
			Pot.NativeFieldInfoPtr_WaterLevelCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvas");
			Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvasGroup");
			Pot.NativeFieldInfoPtr_WaterLevelSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelSlider");
			Pot.NativeFieldInfoPtr_NoWaterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NoWaterIcon");
			Pot.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WorldspaceUIPrefab");
			Pot.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "typeIcon");
			Pot.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CameraContainer");
			Pot.NativeFieldInfoPtr_MidshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MidshotPosition");
			Pot.NativeFieldInfoPtr_CloseupPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CloseupPosition");
			Pot.NativeFieldInfoPtr_FullshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "FullshotPosition");
			Pot.NativeFieldInfoPtr_BirdsEyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "BirdsEyePosition");
			Pot.NativeFieldInfoPtr_AutoRotateCameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AutoRotateCameraContainer");
			Pot.NativeFieldInfoPtr_Dirt_Flat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Flat");
			Pot.NativeFieldInfoPtr_Dirt_Parted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Parted");
			Pot.NativeFieldInfoPtr_SoilChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilChunks");
			Pot.NativeFieldInfoPtr_DirtRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtRenderers");
			Pot.NativeFieldInfoPtr_PotRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PotRadius");
			Pot.NativeFieldInfoPtr_YieldMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "YieldMultiplier");
			Pot.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "GrowSpeedMultiplier");
			Pot.NativeFieldInfoPtr_MoistureDrainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MoistureDrainMultiplier");
			Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AlignLeafDropToPlayer");
			Pot.NativeFieldInfoPtr_SoilCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCapacity");
			Pot.NativeFieldInfoPtr_WaterCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCapacity");
			Pot.NativeFieldInfoPtr_WaterDrainPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterDrainPerHour");
			Pot.NativeFieldInfoPtr_DirtMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMinScale");
			Pot.NativeFieldInfoPtr_DirtMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMaxScale");
			Pot.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Target");
			Pot.NativeFieldInfoPtr_LightSourceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LightSourceOverride");
			Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__Plant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Plant>k__BackingField");
			Pot.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AppliedAdditives");
			Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<potConfiguration>k__BackingField");
			Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<InputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<OutputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Selectable>k__BackingField");
			Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			Pot.NativeFieldInfoPtr_intObjSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "intObjSetThisFrame");
			Pot.NativeFieldInfoPtr_outputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "outputSlot");
			Pot.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotation");
			Pot.NativeFieldInfoPtr_rotationOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotationOverridden");
			Pot.NativeFieldInfoPtr_appliedSoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "appliedSoilDefinition");
			Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683776);
			Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683777);
			Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683778);
			Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683779);
			Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683780);
			Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683781);
			Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683782);
			Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683783);
			Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683784);
			Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683785);
			Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683786);
			Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683787);
			Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683788);
			Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683789);
			Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683790);
			Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683791);
			Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683792);
			Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683793);
			Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683794);
			Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683795);
			Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683796);
			Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683797);
			Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683798);
			Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683799);
			Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683800);
			Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683801);
			Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683802);
			Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683803);
			Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683804);
			Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683805);
			Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683806);
			Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683807);
			Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683808);
			Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683809);
			Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683810);
			Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683811);
			Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683812);
			Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683813);
			Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683814);
			Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683815);
			Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683816);
			Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683817);
			Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683818);
			Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683819);
			Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683820);
			Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683821);
			Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683822);
			Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683823);
			Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683824);
			Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683825);
			Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683826);
			Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683827);
			Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683828);
			Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683829);
			Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683830);
			Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683831);
			Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683832);
			Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683833);
			Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683834);
			Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683835);
			Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683836);
			Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683837);
			Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683838);
			Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683839);
			Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683840);
			Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683841);
			Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683842);
			Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683843);
			Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683844);
			Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683845);
			Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683846);
			Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683847);
			Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683848);
			Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683849);
			Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683850);
			Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683851);
			Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683852);
			Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683853);
			Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683854);
			Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683855);
			Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683856);
			Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683857);
			Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683858);
			Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683859);
			Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683860);
			Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683861);
			Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683862);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683863);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683864);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683865);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683866);
			Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683867);
			Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683868);
			Pot.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683869);
			Pot.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683870);
			Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683871);
			Pot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683872);
			Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683873);
			Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683874);
			Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683875);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683876);
			Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683877);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683878);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683879);
			Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683880);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683881);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683882);
			Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683883);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683884);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683885);
			Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683886);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683887);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683888);
			Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683889);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683890);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683891);
			Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683892);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683893);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683894);
			Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683895);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683896);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683897);
			Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683898);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683899);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683900);
			Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683901);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683902);
			Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683903);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683904);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683905);
			Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683906);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683907);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683908);
			Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683909);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683910);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683911);
			Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683912);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683913);
			Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683914);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683915);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683916);
			Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683917);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683918);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683919);
			Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683920);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683921);
			Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683922);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683923);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683924);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683925);
			Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683926);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683927);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683928);
			Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683929);
			Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683930);
			Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683931);
			Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683932);
			Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683933);
			Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683934);
			Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683935);
			Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683936);
			Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683937);
			Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683938);
			Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683939);
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x0029E820 File Offset: 0x0029CA20
		// (set) Token: 0x0600A76D RID: 42861 RVA: 0x0029E85C File Offset: 0x0029CA5C
		public unsafe float SoilLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217240, RefRangeEnd = 217245, XrefRangeStart = 217240, XrefRangeEnd = 217245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291409, RefRangeEnd = 291413, XrefRangeStart = 291402, XrefRangeEnd = 291409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600A76E RID: 42862 RVA: 0x0029E89C File Offset: 0x0029CA9C
		// (set) Token: 0x0600A76F RID: 42863 RVA: 0x0029E8D4 File Offset: 0x0029CAD4
		public unsafe string SoilID
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291421, RefRangeEnd = 291425, XrefRangeStart = 291413, XrefRangeEnd = 291421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600A770 RID: 42864 RVA: 0x0029E918 File Offset: 0x0029CB18
		// (set) Token: 0x0600A771 RID: 42865 RVA: 0x0029E954 File Offset: 0x0029CB54
		public unsafe int RemainingSoilUses
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291432, RefRangeEnd = 291436, XrefRangeStart = 291425, XrefRangeEnd = 291432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600A772 RID: 42866 RVA: 0x0029E994 File Offset: 0x0029CB94
		// (set) Token: 0x0600A773 RID: 42867 RVA: 0x0029E9D0 File Offset: 0x0029CBD0
		public unsafe float WaterLevel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94031, RefRangeEnd = 94033, XrefRangeStart = 94031, XrefRangeEnd = 94033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 291443, RefRangeEnd = 291449, XrefRangeStart = 291436, XrefRangeEnd = 291443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600A774 RID: 42868 RVA: 0x0029EA10 File Offset: 0x0029CC10
		public unsafe float NormalizedWaterLevel
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 291449, RefRangeEnd = 291457, XrefRangeStart = 291449, XrefRangeEnd = 291449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600A775 RID: 42869 RVA: 0x0029EA4C File Offset: 0x0029CC4C
		public unsafe bool IsFilledWithSoil
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 291457, RefRangeEnd = 291465, XrefRangeStart = 291457, XrefRangeEnd = 291457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x0029EA88 File Offset: 0x0029CC88
		// (set) Token: 0x0600A777 RID: 42871 RVA: 0x0029EAC8 File Offset: 0x0029CCC8
		public unsafe Plant Plant
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600A778 RID: 42872 RVA: 0x0029EB0C File Offset: 0x0029CD0C
		// (set) Token: 0x0600A779 RID: 42873 RVA: 0x0029EB4C File Offset: 0x0029CD4C
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 291473, RefRangeEnd = 291475, XrefRangeStart = 291465, XrefRangeEnd = 291473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x0029EB90 File Offset: 0x0029CD90
		// (set) Token: 0x0600A77B RID: 42875 RVA: 0x0029EBD0 File Offset: 0x0029CDD0
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291475, XrefRangeEnd = 291483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x0029EC14 File Offset: 0x0029CE14
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 291483, RefRangeEnd = 291505, XrefRangeStart = 291483, XrefRangeEnd = 291483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x0029EC54 File Offset: 0x0029CE54
		// (set) Token: 0x0600A77E RID: 42878 RVA: 0x0029EC94 File Offset: 0x0029CE94
		public unsafe PotConfiguration potConfiguration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 291483, RefRangeEnd = 291505, XrefRangeStart = 291483, XrefRangeEnd = 291505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291505, XrefRangeEnd = 291506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600A77F RID: 42879 RVA: 0x0029ECD8 File Offset: 0x0029CED8
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 166351, RefRangeEnd = 166355, XrefRangeStart = 166351, XrefRangeEnd = 166355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600A780 RID: 42880 RVA: 0x0029ED18 File Offset: 0x0029CF18
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600A781 RID: 42881 RVA: 0x0029ED54 File Offset: 0x0029CF54
		// (set) Token: 0x0600A782 RID: 42882 RVA: 0x0029ED94 File Offset: 0x0029CF94
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 291506, RefRangeEnd = 291516, XrefRangeStart = 291506, XrefRangeEnd = 291506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291516, XrefRangeEnd = 291517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600A783 RID: 42883 RVA: 0x0029EDD8 File Offset: 0x0029CFD8
		// (set) Token: 0x0600A784 RID: 42884 RVA: 0x0029EE18 File Offset: 0x0029D018
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 291525, RefRangeEnd = 291527, XrefRangeStart = 291517, XrefRangeEnd = 291525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0029EE5C File Offset: 0x0029D05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291527, XrefRangeEnd = 291549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600A786 RID: 42886 RVA: 0x0029EEA0 File Offset: 0x0029D0A0
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600A787 RID: 42887 RVA: 0x0029EEE0 File Offset: 0x0029D0E0
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600A788 RID: 42888 RVA: 0x0029EF20 File Offset: 0x0029D120
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166349, RefRangeEnd = 166350, XrefRangeStart = 166349, XrefRangeEnd = 166350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600A789 RID: 42889 RVA: 0x0029EF60 File Offset: 0x0029D160
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x0029EF9C File Offset: 0x0029D19C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x0029EFD4 File Offset: 0x0029D1D4
		// (set) Token: 0x0600A78C RID: 42892 RVA: 0x0029F014 File Offset: 0x0029D214
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291549, XrefRangeEnd = 291550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x0029F058 File Offset: 0x0029D258
		// (set) Token: 0x0600A78E RID: 42894 RVA: 0x0029F098 File Offset: 0x0029D298
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291550, XrefRangeEnd = 291551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x0029F0DC File Offset: 0x0029D2DC
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166349, RefRangeEnd = 166350, XrefRangeStart = 166349, XrefRangeEnd = 166350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x0029F11C File Offset: 0x0029D31C
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166356, RefRangeEnd = 166371, XrefRangeStart = 166356, XrefRangeEnd = 166371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x0029F15C File Offset: 0x0029D35C
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x0029F198 File Offset: 0x0029D398
		// (set) Token: 0x0600A793 RID: 42899 RVA: 0x0029F1D4 File Offset: 0x0029D3D4
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x0029F214 File Offset: 0x0029D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291551, XrefRangeEnd = 291557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x0029F250 File Offset: 0x0029D450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291557, XrefRangeEnd = 291568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x0029F28C File Offset: 0x0029D48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291568, XrefRangeEnd = 291612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x0029F2DC File Offset: 0x0029D4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291612, XrefRangeEnd = 291629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x0029F320 File Offset: 0x0029D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291629, XrefRangeEnd = 291674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x0029F3B0 File Offset: 0x0029D5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291674, XrefRangeEnd = 291720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x0029F3FC File Offset: 0x0029D5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291720, XrefRangeEnd = 291755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x0029F438 File Offset: 0x0029D638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291814, RefRangeEnd = 291815, XrefRangeStart = 291755, XrefRangeEnd = 291814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x0029F46C File Offset: 0x0029D66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291815, XrefRangeEnd = 291821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x0029F4A0 File Offset: 0x0029D6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291821, XrefRangeEnd = 291842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsSkippped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSkippped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x0029F4E0 File Offset: 0x0029D6E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 291846, RefRangeEnd = 291854, XrefRangeStart = 291842, XrefRangeEnd = 291846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string message, InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHighLabelPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x0029F540 File Offset: 0x0029D740
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291876, RefRangeEnd = 291879, XrefRangeStart = 291854, XrefRangeEnd = 291876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionCameraContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x0029F574 File Offset: 0x0029D774
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 291901, RefRangeEnd = 291907, XrefRangeStart = 291879, XrefRangeEnd = 291901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x0029F5B8 File Offset: 0x0029D7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291929, RefRangeEnd = 291931, XrefRangeStart = 291907, XrefRangeEnd = 291929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x0029F5FC File Offset: 0x0029D7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291931, XrefRangeEnd = 291952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x0029F638 File Offset: 0x0029D838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291963, RefRangeEnd = 291964, XrefRangeStart = 291952, XrefRangeEnd = 291963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x0029F684 File Offset: 0x0029D884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291974, RefRangeEnd = 291975, XrefRangeStart = 291964, XrefRangeEnd = 291974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAcceptSeed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x0029F6DC File Offset: 0x0029D8DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291985, RefRangeEnd = 291987, XrefRangeStart = 291975, XrefRangeEnd = 291985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyForHarvest(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x0029F734 File Offset: 0x0029D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291987, XrefRangeEnd = 292003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x0029F798 File Offset: 0x0029D998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292003, RefRangeEnd = 292004, XrefRangeStart = 292003, XrefRangeEnd = 292003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideRotation(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x0029F7D8 File Offset: 0x0029D9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292004, RefRangeEnd = 292005, XrefRangeStart = 292004, XrefRangeEnd = 292004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetCameraPosition(Pot.ECameraPosition pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x0029F824 File Offset: 0x0029DA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292005, XrefRangeEnd = 292007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSoil(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x0029F870 File Offset: 0x0029DA70
		[CallerCount(0)]
		public unsafe void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _new;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x0029F8CC File Offset: 0x0029DACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292007, XrefRangeEnd = 292009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x0029F908 File Offset: 0x0029DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292009, XrefRangeEnd = 292018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x0029F958 File Offset: 0x0029DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292018, XrefRangeEnd = 292019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilUses(int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x0029F9A4 File Offset: 0x0029DBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292032, RefRangeEnd = 292034, XrefRangeStart = 292019, XrefRangeEnd = 292032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushSoilDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x0029F9D8 File Offset: 0x0029DBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292034, XrefRangeEnd = 292047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0029FA38 File Offset: 0x0029DC38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292055, RefRangeEnd = 292061, XrefRangeStart = 292047, XrefRangeEnd = 292055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilState(Pot.ESoilState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x0029FA78 File Offset: 0x0029DC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292061, XrefRangeEnd = 292088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x0029FAB4 File Offset: 0x0029DCB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 292093, RefRangeEnd = 292098, XrefRangeStart = 292088, XrefRangeEnd = 292093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeWaterAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x0029FAF4 File Offset: 0x0029DCF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292117, RefRangeEnd = 292119, XrefRangeStart = 292098, XrefRangeEnd = 292117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushWaterDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x0029FB28 File Offset: 0x0029DD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292119, XrefRangeEnd = 292138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWaterData(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x0029FB68 File Offset: 0x0029DD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292138, XrefRangeEnd = 292141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _new;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x0029FBC4 File Offset: 0x0029DDC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292144, RefRangeEnd = 292148, XrefRangeStart = 292141, XrefRangeEnd = 292144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x0029FC04 File Offset: 0x0029DE04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292159, RefRangeEnd = 292163, XrefRangeStart = 292148, XrefRangeEnd = 292159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x0029FC38 File Offset: 0x0029DE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292185, RefRangeEnd = 292186, XrefRangeStart = 292163, XrefRangeEnd = 292185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAdditive(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x0029FC88 File Offset: 0x0029DE88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292230, RefRangeEnd = 292236, XrefRangeStart = 292186, XrefRangeEnd = 292230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAdditive(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x0029FCEC File Offset: 0x0029DEEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292250, RefRangeEnd = 292251, XrefRangeStart = 292236, XrefRangeEnd = 292250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdditiveGrowthMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x0029FD28 File Offset: 0x0029DF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292251, XrefRangeEnd = 292265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetYieldChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x0029FD64 File Offset: 0x0029DF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292265, XrefRangeEnd = 292279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetQualityChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x0029FDA0 File Offset: 0x0029DFA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292294, RefRangeEnd = 292296, XrefRangeStart = 292279, XrefRangeEnd = 292294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive GetAdditive(string additiveName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr3) : null;
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x0029FDF0 File Offset: 0x0029DFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292317, RefRangeEnd = 292318, XrefRangeStart = 292296, XrefRangeEnd = 292317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullyGrowPlant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x0029FE24 File Offset: 0x0029E024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292342, RefRangeEnd = 292343, XrefRangeStart = 292318, XrefRangeEnd = 292342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x0029FE90 File Offset: 0x0029E090
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292391, RefRangeEnd = 292397, XrefRangeStart = 292343, XrefRangeEnd = 292391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x0029FF10 File Offset: 0x0029E110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292397, XrefRangeEnd = 292416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x0029FF50 File Offset: 0x0029E150
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292452, RefRangeEnd = 292456, XrefRangeStart = 292416, XrefRangeEnd = 292452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x0029FFBC File Offset: 0x0029E1BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292502, RefRangeEnd = 292506, XrefRangeStart = 292456, XrefRangeEnd = 292502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x002A001C File Offset: 0x0029E21C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 292538, RefRangeEnd = 292543, XrefRangeStart = 292506, XrefRangeEnd = 292538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x002A0068 File Offset: 0x0029E268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292566, RefRangeEnd = 292568, XrefRangeStart = 292543, XrefRangeEnd = 292566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x002A00B4 File Offset: 0x0029E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292568, XrefRangeEnd = 292569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x002A0100 File Offset: 0x0029E300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292596, RefRangeEnd = 292597, XrefRangeStart = 292569, XrefRangeEnd = 292596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x002A0140 File Offset: 0x0029E340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292597, XrefRangeEnd = 292601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x002A0174 File Offset: 0x0029E374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292601, XrefRangeEnd = 292632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x002A01B8 File Offset: 0x0029E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292632, XrefRangeEnd = 292654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x002A0214 File Offset: 0x0029E414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292654, XrefRangeEnd = 292667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadPlant(PlantData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x002A0264 File Offset: 0x0029E464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292667, XrefRangeEnd = 292699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x002A02A0 File Offset: 0x0029E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292699, XrefRangeEnd = 292884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CE RID: 42958 RVA: 0x002A02DC File Offset: 0x0029E4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292884, XrefRangeEnd = 292885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x002A0318 File Offset: 0x0029E518
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x002A0354 File Offset: 0x0029E554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292885, XrefRangeEnd = 292904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D1 RID: 42961 RVA: 0x002A0398 File Offset: 0x0029E598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291525, RefRangeEnd = 291527, XrefRangeStart = 291525, XrefRangeEnd = 291527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x002A03DC File Offset: 0x0029E5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292904, XrefRangeEnd = 292908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x002A0440 File Offset: 0x0029E640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292908, XrefRangeEnd = 292927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x002A0484 File Offset: 0x0029E684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292951, RefRangeEnd = 292953, XrefRangeStart = 292927, XrefRangeEnd = 292951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x002A04C8 File Offset: 0x0029E6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292953, XrefRangeEnd = 292957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x002A052C File Offset: 0x0029E72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292957, XrefRangeEnd = 292976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x002A0570 File Offset: 0x0029E770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291473, RefRangeEnd = 291475, XrefRangeStart = 291473, XrefRangeEnd = 291475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x002A05B4 File Offset: 0x0029E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292976, XrefRangeEnd = 292980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x002A0618 File Offset: 0x0029E818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292980, XrefRangeEnd = 292998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x002A064C File Offset: 0x0029E84C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293039, RefRangeEnd = 293041, XrefRangeStart = 292998, XrefRangeEnd = 293039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x002A0688 File Offset: 0x0029E888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293041, XrefRangeEnd = 293044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetPot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x002A06D8 File Offset: 0x0029E8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x002A0738 File Offset: 0x0029E938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293044, XrefRangeEnd = 293058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002A0798 File Offset: 0x0029E998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293058, XrefRangeEnd = 293077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoilData_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002A07FC File Offset: 0x0029E9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002A083C File Offset: 0x0029EA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293077, XrefRangeEnd = 293078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x002A087C File Offset: 0x0029EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293078, XrefRangeEnd = 293081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWaterData_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002A08E0 File Offset: 0x0029EAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293081, XrefRangeEnd = 293101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002A0930 File Offset: 0x0029EB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293101, XrefRangeEnd = 293102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x002A0980 File Offset: 0x0029EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293102, XrefRangeEnd = 293106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAdditive_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002A09E4 File Offset: 0x0029EBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293106, XrefRangeEnd = 293126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x002A0A48 File Offset: 0x0029EC48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293174, RefRangeEnd = 293177, XrefRangeStart = 293126, XrefRangeEnd = 293174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x002A0AAC File Offset: 0x0029ECAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293177, XrefRangeEnd = 293181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x002A0AFC File Offset: 0x0029ECFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293181, XrefRangeEnd = 293192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x002A0B60 File Offset: 0x0029ED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293192, XrefRangeEnd = 293196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x002A0BB0 File Offset: 0x0029EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293196, XrefRangeEnd = 293214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x002A0BE4 File Offset: 0x0029EDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293225, RefRangeEnd = 293227, XrefRangeStart = 293214, XrefRangeEnd = 293225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x002A0C18 File Offset: 0x0029EE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293227, XrefRangeEnd = 293230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FullyGrowPlant_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x002A0C68 File Offset: 0x0029EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293230, XrefRangeEnd = 293243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x002A0CD4 File Offset: 0x0029EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293243, XrefRangeEnd = 293244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x002A0D40 File Offset: 0x0029EF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293244, XrefRangeEnd = 293251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlantSeed_2530605204(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x002A0DA4 File Offset: 0x0029EFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293251, XrefRangeEnd = 293273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x002A0E24 File Offset: 0x0029F024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293273, XrefRangeEnd = 293274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x002A0EA4 File Offset: 0x0029F0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293274, XrefRangeEnd = 293281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x002A0EF4 File Offset: 0x0029F0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293281, XrefRangeEnd = 293294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x002A0F74 File Offset: 0x0029F174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293294, XrefRangeEnd = 293301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x002A0FC4 File Offset: 0x0029F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x002A1004 File Offset: 0x0029F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293301, XrefRangeEnd = 293312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x002A1044 File Offset: 0x0029F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293312, XrefRangeEnd = 293320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGrowProgress_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x002A1094 File Offset: 0x0029F294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293320, XrefRangeEnd = 293341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x002A10F4 File Offset: 0x0029F2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293341, XrefRangeEnd = 293342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x002A1154 File Offset: 0x0029F354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293342, XrefRangeEnd = 293347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x002A11A4 File Offset: 0x0029F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293347, XrefRangeEnd = 293359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x002A1204 File Offset: 0x0029F404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293359, XrefRangeEnd = 293364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x002A1254 File Offset: 0x0029F454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293364, XrefRangeEnd = 293385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x002A12A0 File Offset: 0x0029F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293385, XrefRangeEnd = 293386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x002A12EC File Offset: 0x0029F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293386, XrefRangeEnd = 293391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendHarvestableActive_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600A800 RID: 43008 RVA: 0x002A1350 File Offset: 0x0029F550
		// (set) Token: 0x0600A801 RID: 43009 RVA: 0x002A138C File Offset: 0x0029F58C
		public unsafe float SyncAccessor_<SoilLevel>k__BackingField
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217240, RefRangeEnd = 217245, XrefRangeStart = 217240, XrefRangeEnd = 217245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293399, RefRangeEnd = 293401, XrefRangeStart = 293391, XrefRangeEnd = 293399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x002A13D8 File Offset: 0x0029F5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293401, XrefRangeEnd = 293451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600A803 RID: 43011 RVA: 0x002A144C File Offset: 0x0029F64C
		// (set) Token: 0x0600A804 RID: 43012 RVA: 0x002A1484 File Offset: 0x0029F684
		public unsafe string SyncAccessor_<SoilID>k__BackingField
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293460, RefRangeEnd = 293462, XrefRangeStart = 293451, XrefRangeEnd = 293460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600A805 RID: 43013 RVA: 0x002A14D4 File Offset: 0x0029F6D4
		// (set) Token: 0x0600A806 RID: 43014 RVA: 0x002A1510 File Offset: 0x0029F710
		public unsafe int SyncAccessor_<RemainingSoilUses>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293470, RefRangeEnd = 293472, XrefRangeStart = 293462, XrefRangeEnd = 293470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600A807 RID: 43015 RVA: 0x002A155C File Offset: 0x0029F75C
		// (set) Token: 0x0600A808 RID: 43016 RVA: 0x002A1598 File Offset: 0x0029F798
		public unsafe float SyncAccessor_<WaterLevel>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94031, RefRangeEnd = 94033, XrefRangeStart = 94031, XrefRangeEnd = 94033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293480, RefRangeEnd = 293482, XrefRangeStart = 293472, XrefRangeEnd = 293480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x002A15E4 File Offset: 0x0029F7E4
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x002A1624 File Offset: 0x0029F824
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293491, RefRangeEnd = 293493, XrefRangeStart = 293482, XrefRangeEnd = 293491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600A80B RID: 43019 RVA: 0x002A1674 File Offset: 0x0029F874
		// (set) Token: 0x0600A80C RID: 43020 RVA: 0x002A16B4 File Offset: 0x0029F8B4
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293502, RefRangeEnd = 293504, XrefRangeStart = 293493, XrefRangeEnd = 293502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600A80D RID: 43021 RVA: 0x002A1704 File Offset: 0x0029F904
		// (set) Token: 0x0600A80E RID: 43022 RVA: 0x002A1744 File Offset: 0x0029F944
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293513, RefRangeEnd = 293514, XrefRangeStart = 293504, XrefRangeEnd = 293513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x002A1794 File Offset: 0x0029F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293514, XrefRangeEnd = 293520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x000527DF File Offset: 0x000509DF
		public Pot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600A811 RID: 43025 RVA: 0x002A17D0 File Offset: 0x0029F9D0
		// (set) Token: 0x0600A812 RID: 43026 RVA: 0x000527E8 File Offset: 0x000509E8
		public unsafe static float DryThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&value));
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600A813 RID: 43027 RVA: 0x002A17EC File Offset: 0x0029F9EC
		// (set) Token: 0x0600A814 RID: 43028 RVA: 0x000527F6 File Offset: 0x000509F6
		public unsafe static float WaterloggedThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&value));
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600A815 RID: 43029 RVA: 0x002A1808 File Offset: 0x0029FA08
		// (set) Token: 0x0600A816 RID: 43030 RVA: 0x00052804 File Offset: 0x00050A04
		public unsafe static float ROTATION_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600A817 RID: 43031 RVA: 0x002A1824 File Offset: 0x0029FA24
		// (set) Token: 0x0600A818 RID: 43032 RVA: 0x00052812 File Offset: 0x00050A12
		public unsafe static float MAX_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600A819 RID: 43033 RVA: 0x002A1840 File Offset: 0x0029FA40
		// (set) Token: 0x0600A81A RID: 43034 RVA: 0x00052820 File Offset: 0x00050A20
		public unsafe static float MIN_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600A81B RID: 43035 RVA: 0x002A185C File Offset: 0x0029FA5C
		// (set) Token: 0x0600A81C RID: 43036 RVA: 0x0005282E File Offset: 0x00050A2E
		public unsafe Transform ModelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x002A188C File Offset: 0x0029FA8C
		// (set) Token: 0x0600A81E RID: 43038 RVA: 0x0005284D File Offset: 0x00050A4D
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600A81F RID: 43039 RVA: 0x002A18BC File Offset: 0x0029FABC
		// (set) Token: 0x0600A820 RID: 43040 RVA: 0x0005286C File Offset: 0x00050A6C
		public unsafe Transform PourableStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x002A18EC File Offset: 0x0029FAEC
		// (set) Token: 0x0600A822 RID: 43042 RVA: 0x0005288B File Offset: 0x00050A8B
		public unsafe Transform SeedStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600A823 RID: 43043 RVA: 0x002A191C File Offset: 0x0029FB1C
		// (set) Token: 0x0600A824 RID: 43044 RVA: 0x000528AA File Offset: 0x00050AAA
		public unsafe Transform SeedRestingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x002A194C File Offset: 0x0029FB4C
		// (set) Token: 0x0600A826 RID: 43046 RVA: 0x000528C9 File Offset: 0x00050AC9
		public unsafe GameObject WaterLoggedVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A827 RID: 43047 RVA: 0x002A197C File Offset: 0x0029FB7C
		// (set) Token: 0x0600A828 RID: 43048 RVA: 0x000528E8 File Offset: 0x00050AE8
		public unsafe Transform LookAtPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A829 RID: 43049 RVA: 0x002A19AC File Offset: 0x0029FBAC
		// (set) Token: 0x0600A82A RID: 43050 RVA: 0x00052907 File Offset: 0x00050B07
		public unsafe Transform AdditivesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A82B RID: 43051 RVA: 0x002A19DC File Offset: 0x0029FBDC
		// (set) Token: 0x0600A82C RID: 43052 RVA: 0x00052926 File Offset: 0x00050B26
		public unsafe Transform PlantContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x002A1A0C File Offset: 0x0029FC0C
		// (set) Token: 0x0600A82E RID: 43054 RVA: 0x00052945 File Offset: 0x00050B45
		public unsafe Transform IntObjLabel_Low
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600A82F RID: 43055 RVA: 0x002A1A3C File Offset: 0x0029FC3C
		// (set) Token: 0x0600A830 RID: 43056 RVA: 0x00052964 File Offset: 0x00050B64
		public unsafe Transform IntObjLabel_High
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A831 RID: 43057 RVA: 0x002A1A6C File Offset: 0x0029FC6C
		// (set) Token: 0x0600A832 RID: 43058 RVA: 0x00052983 File Offset: 0x00050B83
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A833 RID: 43059 RVA: 0x002A1A9C File Offset: 0x0029FC9C
		// (set) Token: 0x0600A834 RID: 43060 RVA: 0x000529A2 File Offset: 0x00050BA2
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A835 RID: 43061 RVA: 0x002A1ACC File Offset: 0x0029FCCC
		// (set) Token: 0x0600A836 RID: 43062 RVA: 0x000529C1 File Offset: 0x00050BC1
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x002A1AFC File Offset: 0x0029FCFC
		// (set) Token: 0x0600A838 RID: 43064 RVA: 0x000529E0 File Offset: 0x00050BE0
		public unsafe Transform TaskBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A839 RID: 43065 RVA: 0x002A1B2C File Offset: 0x0029FD2C
		// (set) Token: 0x0600A83A RID: 43066 RVA: 0x000529FF File Offset: 0x00050BFF
		public unsafe PotSoilCover SoilCover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x002A1B5C File Offset: 0x0029FD5C
		// (set) Token: 0x0600A83C RID: 43068 RVA: 0x00052A1E File Offset: 0x00050C1E
		public unsafe Transform LeafDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x002A1B8C File Offset: 0x0029FD8C
		// (set) Token: 0x0600A83E RID: 43070 RVA: 0x00052A3D File Offset: 0x00050C3D
		public unsafe ParticleSystem PoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A83F RID: 43071 RVA: 0x002A1BBC File Offset: 0x0029FDBC
		// (set) Token: 0x0600A840 RID: 43072 RVA: 0x00052A5C File Offset: 0x00050C5C
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x002A1BEC File Offset: 0x0029FDEC
		// (set) Token: 0x0600A842 RID: 43074 RVA: 0x00052A7B File Offset: 0x00050C7B
		public unsafe Transform WaterCanvasContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A843 RID: 43075 RVA: 0x002A1C1C File Offset: 0x0029FE1C
		// (set) Token: 0x0600A844 RID: 43076 RVA: 0x00052A9A File Offset: 0x00050C9A
		public unsafe Canvas WaterLevelCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x002A1C4C File Offset: 0x0029FE4C
		// (set) Token: 0x0600A846 RID: 43078 RVA: 0x00052AB9 File Offset: 0x00050CB9
		public unsafe CanvasGroup WaterLevelCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A847 RID: 43079 RVA: 0x002A1C7C File Offset: 0x0029FE7C
		// (set) Token: 0x0600A848 RID: 43080 RVA: 0x00052AD8 File Offset: 0x00050CD8
		public unsafe Slider WaterLevelSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600A849 RID: 43081 RVA: 0x002A1CAC File Offset: 0x0029FEAC
		// (set) Token: 0x0600A84A RID: 43082 RVA: 0x00052AF7 File Offset: 0x00050CF7
		public unsafe GameObject NoWaterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600A84B RID: 43083 RVA: 0x002A1CDC File Offset: 0x0029FEDC
		// (set) Token: 0x0600A84C RID: 43084 RVA: 0x00052B16 File Offset: 0x00050D16
		public unsafe PotUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x002A1D0C File Offset: 0x0029FF0C
		// (set) Token: 0x0600A84E RID: 43086 RVA: 0x00052B35 File Offset: 0x00050D35
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600A84F RID: 43087 RVA: 0x002A1D3C File Offset: 0x0029FF3C
		// (set) Token: 0x0600A850 RID: 43088 RVA: 0x00052B54 File Offset: 0x00050D54
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600A851 RID: 43089 RVA: 0x002A1D6C File Offset: 0x0029FF6C
		// (set) Token: 0x0600A852 RID: 43090 RVA: 0x00052B73 File Offset: 0x00050D73
		public unsafe Transform MidshotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600A853 RID: 43091 RVA: 0x002A1D9C File Offset: 0x0029FF9C
		// (set) Token: 0x0600A854 RID: 43092 RVA: 0x00052B92 File Offset: 0x00050D92
		public unsafe Transform CloseupPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600A855 RID: 43093 RVA: 0x002A1DCC File Offset: 0x0029FFCC
		// (set) Token: 0x0600A856 RID: 43094 RVA: 0x00052BB1 File Offset: 0x00050DB1
		public unsafe Transform FullshotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x002A1DFC File Offset: 0x0029FFFC
		// (set) Token: 0x0600A858 RID: 43096 RVA: 0x00052BD0 File Offset: 0x00050DD0
		public unsafe Transform BirdsEyePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600A859 RID: 43097 RVA: 0x002A1E2C File Offset: 0x002A002C
		// (set) Token: 0x0600A85A RID: 43098 RVA: 0x00052BEF File Offset: 0x00050DEF
		public unsafe bool AutoRotateCameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer)) = value;
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x002A1E54 File Offset: 0x002A0054
		// (set) Token: 0x0600A85C RID: 43100 RVA: 0x00052C0A File Offset: 0x00050E0A
		public unsafe Transform Dirt_Flat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x002A1E84 File Offset: 0x002A0084
		// (set) Token: 0x0600A85E RID: 43102 RVA: 0x00052C29 File Offset: 0x00050E29
		public unsafe Transform Dirt_Parted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600A85F RID: 43103 RVA: 0x002A1EB4 File Offset: 0x002A00B4
		// (set) Token: 0x0600A860 RID: 43104 RVA: 0x00052C48 File Offset: 0x00050E48
		public unsafe Il2CppReferenceArray<SoilChunk> SoilChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoilChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600A861 RID: 43105 RVA: 0x002A1EE4 File Offset: 0x002A00E4
		// (set) Token: 0x0600A862 RID: 43106 RVA: 0x00052C67 File Offset: 0x00050E67
		public unsafe List<MeshRenderer> DirtRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600A863 RID: 43107 RVA: 0x002A1F14 File Offset: 0x002A0114
		// (set) Token: 0x0600A864 RID: 43108 RVA: 0x00052C86 File Offset: 0x00050E86
		public unsafe float PotRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius)) = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600A865 RID: 43109 RVA: 0x002A1F3C File Offset: 0x002A013C
		// (set) Token: 0x0600A866 RID: 43110 RVA: 0x00052CA1 File Offset: 0x00050EA1
		public unsafe float YieldMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier)) = value;
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600A867 RID: 43111 RVA: 0x002A1F64 File Offset: 0x002A0164
		// (set) Token: 0x0600A868 RID: 43112 RVA: 0x00052CBC File Offset: 0x00050EBC
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600A869 RID: 43113 RVA: 0x002A1F8C File Offset: 0x002A018C
		// (set) Token: 0x0600A86A RID: 43114 RVA: 0x00052CD7 File Offset: 0x00050ED7
		public unsafe float MoistureDrainMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier)) = value;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x002A1FB4 File Offset: 0x002A01B4
		// (set) Token: 0x0600A86C RID: 43116 RVA: 0x00052CF2 File Offset: 0x00050EF2
		public unsafe bool AlignLeafDropToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer)) = value;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600A86D RID: 43117 RVA: 0x002A1FDC File Offset: 0x002A01DC
		// (set) Token: 0x0600A86E RID: 43118 RVA: 0x00052D0D File Offset: 0x00050F0D
		public unsafe float SoilCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity)) = value;
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x002A2004 File Offset: 0x002A0204
		// (set) Token: 0x0600A870 RID: 43120 RVA: 0x00052D28 File Offset: 0x00050F28
		public unsafe float WaterCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity)) = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x002A202C File Offset: 0x002A022C
		// (set) Token: 0x0600A872 RID: 43122 RVA: 0x00052D43 File Offset: 0x00050F43
		public unsafe float WaterDrainPerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour)) = value;
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600A873 RID: 43123 RVA: 0x002A2054 File Offset: 0x002A0254
		// (set) Token: 0x0600A874 RID: 43124 RVA: 0x00052D5E File Offset: 0x00050F5E
		public unsafe Vector3 DirtMinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale)) = value;
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x002A207C File Offset: 0x002A027C
		// (set) Token: 0x0600A876 RID: 43126 RVA: 0x00052D79 File Offset: 0x00050F79
		public unsafe Vector3 DirtMaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale)) = value;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x002A20A4 File Offset: 0x002A02A4
		// (set) Token: 0x0600A878 RID: 43128 RVA: 0x00052D94 File Offset: 0x00050F94
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600A879 RID: 43129 RVA: 0x002A20D4 File Offset: 0x002A02D4
		// (set) Token: 0x0600A87A RID: 43130 RVA: 0x00052DB3 File Offset: 0x00050FB3
		public unsafe UsableLightSource LightSourceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsableLightSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600A87B RID: 43131 RVA: 0x002A2104 File Offset: 0x002A0304
		// (set) Token: 0x0600A87C RID: 43132 RVA: 0x00052DD2 File Offset: 0x00050FD2
		public unsafe float _SoilLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600A87D RID: 43133 RVA: 0x002A212C File Offset: 0x002A032C
		// (set) Token: 0x0600A87E RID: 43134 RVA: 0x00052DED File Offset: 0x00050FED
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600A87F RID: 43135 RVA: 0x002A2154 File Offset: 0x002A0354
		// (set) Token: 0x0600A880 RID: 43136 RVA: 0x00052E0C File Offset: 0x0005100C
		public unsafe int _RemainingSoilUses_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600A881 RID: 43137 RVA: 0x002A217C File Offset: 0x002A037C
		// (set) Token: 0x0600A882 RID: 43138 RVA: 0x00052E27 File Offset: 0x00051027
		public unsafe float _WaterLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600A883 RID: 43139 RVA: 0x002A21A4 File Offset: 0x002A03A4
		// (set) Token: 0x0600A884 RID: 43140 RVA: 0x00052E42 File Offset: 0x00051042
		public unsafe Plant _Plant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600A885 RID: 43141 RVA: 0x002A21D4 File Offset: 0x002A03D4
		// (set) Token: 0x0600A886 RID: 43142 RVA: 0x00052E61 File Offset: 0x00051061
		public unsafe List<Additive> AppliedAdditives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Additive>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600A887 RID: 43143 RVA: 0x002A2204 File Offset: 0x002A0404
		// (set) Token: 0x0600A888 RID: 43144 RVA: 0x00052E80 File Offset: 0x00051080
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x002A2234 File Offset: 0x002A0434
		// (set) Token: 0x0600A88A RID: 43146 RVA: 0x00052E9F File Offset: 0x0005109F
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600A88B RID: 43147 RVA: 0x002A2264 File Offset: 0x002A0464
		// (set) Token: 0x0600A88C RID: 43148 RVA: 0x00052EBE File Offset: 0x000510BE
		public unsafe PotConfiguration _potConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600A88D RID: 43149 RVA: 0x002A2294 File Offset: 0x002A0494
		// (set) Token: 0x0600A88E RID: 43150 RVA: 0x00052EDD File Offset: 0x000510DD
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600A88F RID: 43151 RVA: 0x002A22C4 File Offset: 0x002A04C4
		// (set) Token: 0x0600A890 RID: 43152 RVA: 0x00052EFC File Offset: 0x000510FC
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600A891 RID: 43153 RVA: 0x002A22F4 File Offset: 0x002A04F4
		// (set) Token: 0x0600A892 RID: 43154 RVA: 0x00052F1B File Offset: 0x0005111B
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600A893 RID: 43155 RVA: 0x002A2324 File Offset: 0x002A0524
		// (set) Token: 0x0600A894 RID: 43156 RVA: 0x00052F3A File Offset: 0x0005113A
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600A895 RID: 43157 RVA: 0x002A2354 File Offset: 0x002A0554
		// (set) Token: 0x0600A896 RID: 43158 RVA: 0x00052F59 File Offset: 0x00051159
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600A897 RID: 43159 RVA: 0x002A237C File Offset: 0x002A057C
		// (set) Token: 0x0600A898 RID: 43160 RVA: 0x00052F74 File Offset: 0x00051174
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600A899 RID: 43161 RVA: 0x002A23A4 File Offset: 0x002A05A4
		// (set) Token: 0x0600A89A RID: 43162 RVA: 0x00052F8F File Offset: 0x0005118F
		public unsafe bool intObjSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame)) = value;
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002A23CC File Offset: 0x002A05CC
		// (set) Token: 0x0600A89C RID: 43164 RVA: 0x00052FAA File Offset: 0x000511AA
		public unsafe ItemSlot outputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600A89D RID: 43165 RVA: 0x002A23FC File Offset: 0x002A05FC
		// (set) Token: 0x0600A89E RID: 43166 RVA: 0x00052FC9 File Offset: 0x000511C9
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600A89F RID: 43167 RVA: 0x002A2424 File Offset: 0x002A0624
		// (set) Token: 0x0600A8A0 RID: 43168 RVA: 0x00052FE4 File Offset: 0x000511E4
		public unsafe bool rotationOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden)) = value;
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002A244C File Offset: 0x002A064C
		// (set) Token: 0x0600A8A2 RID: 43170 RVA: 0x00052FFF File Offset: 0x000511FF
		public unsafe SoilDefinition appliedSoilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600A8A3 RID: 43171 RVA: 0x002A247C File Offset: 0x002A067C
		// (set) Token: 0x0600A8A4 RID: 43172 RVA: 0x0005301E File Offset: 0x0005121E
		public unsafe SyncVar<float> syncVar____SoilLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x002A24AC File Offset: 0x002A06AC
		// (set) Token: 0x0600A8A6 RID: 43174 RVA: 0x0005303D File Offset: 0x0005123D
		public unsafe SyncVar<string> syncVar____SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x002A24DC File Offset: 0x002A06DC
		// (set) Token: 0x0600A8A8 RID: 43176 RVA: 0x0005305C File Offset: 0x0005125C
		public unsafe SyncVar<int> syncVar____RemainingSoilUses_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002A250C File Offset: 0x002A070C
		// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x0005307B File Offset: 0x0005127B
		public unsafe SyncVar<float> syncVar____WaterLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002A253C File Offset: 0x002A073C
		// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x0005309A File Offset: 0x0005129A
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002A256C File Offset: 0x002A076C
		// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x000530B9 File Offset: 0x000512B9
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600A8AF RID: 43183 RVA: 0x002A259C File Offset: 0x002A079C
		// (set) Token: 0x0600A8B0 RID: 43184 RVA: 0x000530D8 File Offset: 0x000512D8
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002A25CC File Offset: 0x002A07CC
		// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x000530F7 File Offset: 0x000512F7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002A25F4 File Offset: 0x002A07F4
		// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x00053112 File Offset: 0x00051312
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400704B RID: 28747
		private static readonly IntPtr NativeFieldInfoPtr_DryThreshold;

		// Token: 0x0400704C RID: 28748
		private static readonly IntPtr NativeFieldInfoPtr_WaterloggedThreshold;

		// Token: 0x0400704D RID: 28749
		private static readonly IntPtr NativeFieldInfoPtr_ROTATION_SPEED;

		// Token: 0x0400704E RID: 28750
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CAMERA_DISTANCE;

		// Token: 0x0400704F RID: 28751
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CAMERA_DISTANCE;

		// Token: 0x04007050 RID: 28752
		private static readonly IntPtr NativeFieldInfoPtr_ModelTransform;

		// Token: 0x04007051 RID: 28753
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04007052 RID: 28754
		private static readonly IntPtr NativeFieldInfoPtr_PourableStartPoint;

		// Token: 0x04007053 RID: 28755
		private static readonly IntPtr NativeFieldInfoPtr_SeedStartPoint;

		// Token: 0x04007054 RID: 28756
		private static readonly IntPtr NativeFieldInfoPtr_SeedRestingPoint;

		// Token: 0x04007055 RID: 28757
		private static readonly IntPtr NativeFieldInfoPtr_WaterLoggedVisuals;

		// Token: 0x04007056 RID: 28758
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPoint;

		// Token: 0x04007057 RID: 28759
		private static readonly IntPtr NativeFieldInfoPtr_AdditivesContainer;

		// Token: 0x04007058 RID: 28760
		private static readonly IntPtr NativeFieldInfoPtr_PlantContainer;

		// Token: 0x04007059 RID: 28761
		private static readonly IntPtr NativeFieldInfoPtr_IntObjLabel_Low;

		// Token: 0x0400705A RID: 28762
		private static readonly IntPtr NativeFieldInfoPtr_IntObjLabel_High;

		// Token: 0x0400705B RID: 28763
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x0400705C RID: 28764
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x0400705D RID: 28765
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x0400705E RID: 28766
		private static readonly IntPtr NativeFieldInfoPtr_TaskBounds;

		// Token: 0x0400705F RID: 28767
		private static readonly IntPtr NativeFieldInfoPtr_SoilCover;

		// Token: 0x04007060 RID: 28768
		private static readonly IntPtr NativeFieldInfoPtr_LeafDropPoint;

		// Token: 0x04007061 RID: 28769
		private static readonly IntPtr NativeFieldInfoPtr_PoofParticles;

		// Token: 0x04007062 RID: 28770
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04007063 RID: 28771
		private static readonly IntPtr NativeFieldInfoPtr_WaterCanvasContainer;

		// Token: 0x04007064 RID: 28772
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvas;

		// Token: 0x04007065 RID: 28773
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvasGroup;

		// Token: 0x04007066 RID: 28774
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelSlider;

		// Token: 0x04007067 RID: 28775
		private static readonly IntPtr NativeFieldInfoPtr_NoWaterIcon;

		// Token: 0x04007068 RID: 28776
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04007069 RID: 28777
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x0400706A RID: 28778
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x0400706B RID: 28779
		private static readonly IntPtr NativeFieldInfoPtr_MidshotPosition;

		// Token: 0x0400706C RID: 28780
		private static readonly IntPtr NativeFieldInfoPtr_CloseupPosition;

		// Token: 0x0400706D RID: 28781
		private static readonly IntPtr NativeFieldInfoPtr_FullshotPosition;

		// Token: 0x0400706E RID: 28782
		private static readonly IntPtr NativeFieldInfoPtr_BirdsEyePosition;

		// Token: 0x0400706F RID: 28783
		private static readonly IntPtr NativeFieldInfoPtr_AutoRotateCameraContainer;

		// Token: 0x04007070 RID: 28784
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Flat;

		// Token: 0x04007071 RID: 28785
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Parted;

		// Token: 0x04007072 RID: 28786
		private static readonly IntPtr NativeFieldInfoPtr_SoilChunks;

		// Token: 0x04007073 RID: 28787
		private static readonly IntPtr NativeFieldInfoPtr_DirtRenderers;

		// Token: 0x04007074 RID: 28788
		private static readonly IntPtr NativeFieldInfoPtr_PotRadius;

		// Token: 0x04007075 RID: 28789
		private static readonly IntPtr NativeFieldInfoPtr_YieldMultiplier;

		// Token: 0x04007076 RID: 28790
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04007077 RID: 28791
		private static readonly IntPtr NativeFieldInfoPtr_MoistureDrainMultiplier;

		// Token: 0x04007078 RID: 28792
		private static readonly IntPtr NativeFieldInfoPtr_AlignLeafDropToPlayer;

		// Token: 0x04007079 RID: 28793
		private static readonly IntPtr NativeFieldInfoPtr_SoilCapacity;

		// Token: 0x0400707A RID: 28794
		private static readonly IntPtr NativeFieldInfoPtr_WaterCapacity;

		// Token: 0x0400707B RID: 28795
		private static readonly IntPtr NativeFieldInfoPtr_WaterDrainPerHour;

		// Token: 0x0400707C RID: 28796
		private static readonly IntPtr NativeFieldInfoPtr_DirtMinScale;

		// Token: 0x0400707D RID: 28797
		private static readonly IntPtr NativeFieldInfoPtr_DirtMaxScale;

		// Token: 0x0400707E RID: 28798
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400707F RID: 28799
		private static readonly IntPtr NativeFieldInfoPtr_LightSourceOverride;

		// Token: 0x04007080 RID: 28800
		private static readonly IntPtr NativeFieldInfoPtr__SoilLevel_k__BackingField;

		// Token: 0x04007081 RID: 28801
		private static readonly IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x04007082 RID: 28802
		private static readonly IntPtr NativeFieldInfoPtr__RemainingSoilUses_k__BackingField;

		// Token: 0x04007083 RID: 28803
		private static readonly IntPtr NativeFieldInfoPtr__WaterLevel_k__BackingField;

		// Token: 0x04007084 RID: 28804
		private static readonly IntPtr NativeFieldInfoPtr__Plant_k__BackingField;

		// Token: 0x04007085 RID: 28805
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x04007086 RID: 28806
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04007087 RID: 28807
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04007088 RID: 28808
		private static readonly IntPtr NativeFieldInfoPtr__potConfiguration_k__BackingField;

		// Token: 0x04007089 RID: 28809
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x0400708A RID: 28810
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400708B RID: 28811
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x0400708C RID: 28812
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x0400708D RID: 28813
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x0400708E RID: 28814
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x0400708F RID: 28815
		private static readonly IntPtr NativeFieldInfoPtr_intObjSetThisFrame;

		// Token: 0x04007090 RID: 28816
		private static readonly IntPtr NativeFieldInfoPtr_outputSlot;

		// Token: 0x04007091 RID: 28817
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04007092 RID: 28818
		private static readonly IntPtr NativeFieldInfoPtr_rotationOverridden;

		// Token: 0x04007093 RID: 28819
		private static readonly IntPtr NativeFieldInfoPtr_appliedSoilDefinition;

		// Token: 0x04007094 RID: 28820
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField;

		// Token: 0x04007095 RID: 28821
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____SoilID_k__BackingField;

		// Token: 0x04007096 RID: 28822
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField;

		// Token: 0x04007097 RID: 28823
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField;

		// Token: 0x04007098 RID: 28824
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04007099 RID: 28825
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x0400709A RID: 28826
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400709B RID: 28827
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400709C RID: 28828
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400709D RID: 28829
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0;

		// Token: 0x0400709E RID: 28830
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0;

		// Token: 0x0400709F RID: 28831
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x040070A0 RID: 28832
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x040070A1 RID: 28833
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0;

		// Token: 0x040070A2 RID: 28834
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0;

		// Token: 0x040070A3 RID: 28835
		private static readonly IntPtr NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0;

		// Token: 0x040070A4 RID: 28836
		private static readonly IntPtr NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0;

		// Token: 0x040070A5 RID: 28837
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0;

		// Token: 0x040070A6 RID: 28838
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0;

		// Token: 0x040070A7 RID: 28839
		private static readonly IntPtr NativeMethodInfoPtr_get_Plant_Public_get_Plant_0;

		// Token: 0x040070A8 RID: 28840
		private static readonly IntPtr NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0;

		// Token: 0x040070A9 RID: 28841
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070AA RID: 28842
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070AB RID: 28843
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070AC RID: 28844
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070AD RID: 28845
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x040070AE RID: 28846
		private static readonly IntPtr NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0;

		// Token: 0x040070AF RID: 28847
		private static readonly IntPtr NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0;

		// Token: 0x040070B0 RID: 28848
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x040070B1 RID: 28849
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x040070B2 RID: 28850
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x040070B3 RID: 28851
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x040070B4 RID: 28852
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070B5 RID: 28853
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070B6 RID: 28854
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070B7 RID: 28855
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040070B8 RID: 28856
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070B9 RID: 28857
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070BA RID: 28858
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070BB RID: 28859
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040070BC RID: 28860
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040070BD RID: 28861
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040070BE RID: 28862
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040070BF RID: 28863
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040070C0 RID: 28864
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070C1 RID: 28865
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040070C2 RID: 28866
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070C3 RID: 28867
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070C4 RID: 28868
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x040070C5 RID: 28869
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040070C6 RID: 28870
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040070C7 RID: 28871
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040070C8 RID: 28872
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x040070C9 RID: 28873
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x040070CA RID: 28874
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x040070CB RID: 28875
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040070CC RID: 28876
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0;

		// Token: 0x040070CD RID: 28877
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040070CE RID: 28878
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x040070CF RID: 28879
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0;

		// Token: 0x040070D0 RID: 28880
		private static readonly IntPtr NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0;

		// Token: 0x040070D1 RID: 28881
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070D2 RID: 28882
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070D3 RID: 28883
		private static readonly IntPtr NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0;

		// Token: 0x040070D4 RID: 28884
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0;

		// Token: 0x040070D5 RID: 28885
		private static readonly IntPtr NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0;

		// Token: 0x040070D6 RID: 28886
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0;

		// Token: 0x040070D7 RID: 28887
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x040070D8 RID: 28888
		private static readonly IntPtr NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0;

		// Token: 0x040070D9 RID: 28889
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0;

		// Token: 0x040070DA RID: 28890
		private static readonly IntPtr NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0;

		// Token: 0x040070DB RID: 28891
		private static readonly IntPtr NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x040070DC RID: 28892
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0;

		// Token: 0x040070DD RID: 28893
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0;

		// Token: 0x040070DE RID: 28894
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040070DF RID: 28895
		private static readonly IntPtr NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0;

		// Token: 0x040070E0 RID: 28896
		private static readonly IntPtr NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0;

		// Token: 0x040070E1 RID: 28897
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0;

		// Token: 0x040070E2 RID: 28898
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x040070E3 RID: 28899
		private static readonly IntPtr NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0;

		// Token: 0x040070E4 RID: 28900
		private static readonly IntPtr NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0;

		// Token: 0x040070E5 RID: 28901
		private static readonly IntPtr NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0;

		// Token: 0x040070E6 RID: 28902
		private static readonly IntPtr NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x040070E7 RID: 28903
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0;

		// Token: 0x040070E8 RID: 28904
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeTarget_Public_Void_0;

		// Token: 0x040070E9 RID: 28905
		private static readonly IntPtr NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0;

		// Token: 0x040070EA RID: 28906
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040070EB RID: 28907
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0;

		// Token: 0x040070EC RID: 28908
		private static readonly IntPtr NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0;

		// Token: 0x040070ED RID: 28909
		private static readonly IntPtr NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0;

		// Token: 0x040070EE RID: 28910
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0;

		// Token: 0x040070EF RID: 28911
		private static readonly IntPtr NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0;

		// Token: 0x040070F0 RID: 28912
		private static readonly IntPtr NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0;

		// Token: 0x040070F1 RID: 28913
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x040070F2 RID: 28914
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0;

		// Token: 0x040070F3 RID: 28915
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0;

		// Token: 0x040070F4 RID: 28916
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040070F5 RID: 28917
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x040070F6 RID: 28918
		private static readonly IntPtr NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0;

		// Token: 0x040070F7 RID: 28919
		private static readonly IntPtr NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x040070F8 RID: 28920
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x040070F9 RID: 28921
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x040070FA RID: 28922
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040070FB RID: 28923
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x040070FC RID: 28924
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0;

		// Token: 0x040070FD RID: 28925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040070FE RID: 28926
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040070FF RID: 28927
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007100 RID: 28928
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007101 RID: 28929
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007102 RID: 28930
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007103 RID: 28931
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007104 RID: 28932
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007105 RID: 28933
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007106 RID: 28934
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007107 RID: 28935
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007108 RID: 28936
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007109 RID: 28937
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400710A RID: 28938
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0;

		// Token: 0x0400710B RID: 28939
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x0400710C RID: 28940
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400710D RID: 28941
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0;

		// Token: 0x0400710E RID: 28942
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0;

		// Token: 0x0400710F RID: 28943
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007110 RID: 28944
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0;

		// Token: 0x04007111 RID: 28945
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0;

		// Token: 0x04007112 RID: 28946
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007113 RID: 28947
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04007114 RID: 28948
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04007115 RID: 28949
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007116 RID: 28950
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04007117 RID: 28951
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04007118 RID: 28952
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007119 RID: 28953
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400711A RID: 28954
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400711B RID: 28955
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0;

		// Token: 0x0400711C RID: 28956
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0;

		// Token: 0x0400711D RID: 28957
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400711E RID: 28958
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0;

		// Token: 0x0400711F RID: 28959
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04007120 RID: 28960
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007121 RID: 28961
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007122 RID: 28962
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007123 RID: 28963
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007124 RID: 28964
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007125 RID: 28965
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007126 RID: 28966
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x04007127 RID: 28967
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x04007128 RID: 28968
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007129 RID: 28969
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400712A RID: 28970
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400712B RID: 28971
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400712C RID: 28972
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400712D RID: 28973
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400712E RID: 28974
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x0400712F RID: 28975
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x04007130 RID: 28976
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007131 RID: 28977
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x04007132 RID: 28978
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04007133 RID: 28979
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04007134 RID: 28980
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0;

		// Token: 0x04007135 RID: 28981
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04007136 RID: 28982
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0;

		// Token: 0x04007137 RID: 28983
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04007138 RID: 28984
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x04007139 RID: 28985
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x0400713A RID: 28986
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400713B RID: 28987
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400713C RID: 28988
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400713D RID: 28989
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400713E RID: 28990
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400713F RID: 28991
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04007140 RID: 28992
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BD4 RID: 3028
		[OriginalName("Assembly-CSharp.dll", "", "ECameraPosition")]
		public enum ECameraPosition
		{
			// Token: 0x04009505 RID: 38149
			Closeup,
			// Token: 0x04009506 RID: 38150
			Midshot,
			// Token: 0x04009507 RID: 38151
			Fullshot,
			// Token: 0x04009508 RID: 38152
			BirdsEye
		}

		// Token: 0x02000BD5 RID: 3029
		[OriginalName("Assembly-CSharp.dll", "", "ESoilState")]
		public enum ESoilState
		{
			// Token: 0x0400950A RID: 38154
			Flat,
			// Token: 0x0400950B RID: 38155
			Parted,
			// Token: 0x0400950C RID: 38156
			Packed
		}

		// Token: 0x02000BD6 RID: 3030
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE93 RID: 56979 RVA: 0x00347E74 File Offset: 0x00346074
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Pot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr);
				Pot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9");
				Pot.__c.NativeFieldInfoPtr___9__194_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9__194_0");
				Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100683941);
				Pot.__c.NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100683942);
			}

			// Token: 0x0600DE94 RID: 56980 RVA: 0x00347EF0 File Offset: 0x003460F0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE95 RID: 56981 RVA: 0x00347F2C File Offset: 0x0034612C
			[CallerCount(0)]
			public unsafe string _GetSaveString_b__194_0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DE96 RID: 56982 RVA: 0x0006C867 File Offset: 0x0006AA67
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x00347F74 File Offset: 0x00346174
			// (set) Token: 0x0600DE98 RID: 56984 RVA: 0x0006C870 File Offset: 0x0006AA70
			public unsafe static Pot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0600DE99 RID: 56985 RVA: 0x00347F9C File Offset: 0x0034619C
			// (set) Token: 0x0600DE9A RID: 56986 RVA: 0x0006C882 File Offset: 0x0006AA82
			public unsafe static Converter<Additive, string> __9__194_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9__194_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<Additive, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9__194_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400950D RID: 38157
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400950E RID: 38158
			private static readonly IntPtr NativeFieldInfoPtr___9__194_0;

			// Token: 0x0400950F RID: 38159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009510 RID: 38160
			private static readonly IntPtr NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0;
		}

		// Token: 0x02000BD7 RID: 3031
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE9B RID: 56987 RVA: 0x00347FC4 File Offset: 0x003461C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr);
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "conn");
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683943);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683944);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683945);
			}

			// Token: 0x0600DE9C RID: 56988 RVA: 0x00348054 File Offset: 0x00346254
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9D RID: 56989 RVA: 0x00348090 File Offset: 0x00346290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291331, XrefRangeEnd = 291336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DE9E RID: 56990 RVA: 0x003480D0 File Offset: 0x003462D0
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE9F RID: 56991 RVA: 0x0006C894 File Offset: 0x0006AA94
			public __c__DisplayClass143_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0600DEA0 RID: 56992 RVA: 0x0034810C File Offset: 0x0034630C
			// (set) Token: 0x0600DEA1 RID: 56993 RVA: 0x0006C89D File Offset: 0x0006AA9D
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x0034813C File Offset: 0x0034633C
			// (set) Token: 0x0600DEA3 RID: 56995 RVA: 0x0006C8BC File Offset: 0x0006AABC
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009511 RID: 38161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009512 RID: 38162
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04009513 RID: 38163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009514 RID: 38164
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009515 RID: 38165
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C84 RID: 3204
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6B8 RID: 59064 RVA: 0x0035F8A0 File Offset: 0x0035DAA0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683946);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683947);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683948);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683949);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683950);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683951);
				}

				// Token: 0x0600E6B9 RID: 59065 RVA: 0x0035F980 File Offset: 0x0035DB80
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6BA RID: 59066 RVA: 0x0035F9C8 File Offset: 0x0035DBC8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6BB RID: 59067 RVA: 0x0035F9FC File Offset: 0x0035DBFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291315, XrefRangeEnd = 291326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047DE RID: 18398
				// (get) Token: 0x0600E6BC RID: 59068 RVA: 0x0035FA38 File Offset: 0x0035DC38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6BD RID: 59069 RVA: 0x0035FA78 File Offset: 0x0035DC78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291326, XrefRangeEnd = 291331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047DF RID: 18399
				// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x0035FAAC File Offset: 0x0035DCAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6BF RID: 59071 RVA: 0x00070A4F File Offset: 0x0006EC4F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047DB RID: 18395
				// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x0035FAEC File Offset: 0x0035DCEC
				// (set) Token: 0x0600E6C1 RID: 59073 RVA: 0x00070A58 File Offset: 0x0006EC58
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047DC RID: 18396
				// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x0035FB14 File Offset: 0x0035DD14
				// (set) Token: 0x0600E6C3 RID: 59075 RVA: 0x00070A73 File Offset: 0x0006EC73
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047DD RID: 18397
				// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x0035FB44 File Offset: 0x0035DD44
				// (set) Token: 0x0600E6C5 RID: 59077 RVA: 0x00070A92 File Offset: 0x0006EC92
				public unsafe Pot.__c__DisplayClass143_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass143_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A2E RID: 39470
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A2F RID: 39471
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A30 RID: 39472
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A31 RID: 39473
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A32 RID: 39474
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A33 RID: 39475
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A34 RID: 39476
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A35 RID: 39477
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A36 RID: 39478
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BD8 RID: 3032
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEA4 RID: 56996 RVA: 0x0034816C File Offset: 0x0034636C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr);
				Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, "additiveAssetPath");
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100683952);
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100683953);
			}

			// Token: 0x0600DEA5 RID: 56997 RVA: 0x003481D4 File Offset: 0x003463D4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA6 RID: 56998 RVA: 0x00348210 File Offset: 0x00346410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ApplyAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEA7 RID: 56999 RVA: 0x0006C8DB File Offset: 0x0006AADB
			public __c__DisplayClass178_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004506 RID: 17670
			// (get) Token: 0x0600DEA8 RID: 57000 RVA: 0x00348260 File Offset: 0x00346460
			// (set) Token: 0x0600DEA9 RID: 57001 RVA: 0x0006C8E4 File Offset: 0x0006AAE4
			public unsafe string additiveAssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009516 RID: 38166
			private static readonly IntPtr NativeFieldInfoPtr_additiveAssetPath;

			// Token: 0x04009517 RID: 38167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009518 RID: 38168
			private static readonly IntPtr NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000BD9 RID: 3033
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEAA RID: 57002 RVA: 0x00348288 File Offset: 0x00346488
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr);
				Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, "additiveName");
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100683954);
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100683955);
			}

			// Token: 0x0600DEAB RID: 57003 RVA: 0x003482F0 File Offset: 0x003464F0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEAC RID: 57004 RVA: 0x0034832C File Offset: 0x0034652C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEAD RID: 57005 RVA: 0x0006C903 File Offset: 0x0006AB03
			public __c__DisplayClass182_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x0034837C File Offset: 0x0034657C
			// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x0006C90C File Offset: 0x0006AB0C
			public unsafe string additiveName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009519 RID: 38169
			private static readonly IntPtr NativeFieldInfoPtr_additiveName;

			// Token: 0x0400951A RID: 38170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400951B RID: 38171
			private static readonly IntPtr NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000BDA RID: 3034
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0")]
		public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEB0 RID: 57008 RVA: 0x003483A4 File Offset: 0x003465A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass196_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass196_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr);
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "data");
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683956);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683957);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683958);
			}

			// Token: 0x0600DEB1 RID: 57009 RVA: 0x00348434 File Offset: 0x00346634
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass196_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEB2 RID: 57010 RVA: 0x00348470 File Offset: 0x00346670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291395, XrefRangeEnd = 291400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DEB3 RID: 57011 RVA: 0x003484B0 File Offset: 0x003466B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291400, XrefRangeEnd = 291402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlant_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEB4 RID: 57012 RVA: 0x0006C92B File Offset: 0x0006AB2B
			public __c__DisplayClass196_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0600DEB5 RID: 57013 RVA: 0x003484EC File Offset: 0x003466EC
			// (set) Token: 0x0600DEB6 RID: 57014 RVA: 0x0006C934 File Offset: 0x0006AB34
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004509 RID: 17673
			// (get) Token: 0x0600DEB7 RID: 57015 RVA: 0x0034851C File Offset: 0x0034671C
			// (set) Token: 0x0600DEB8 RID: 57016 RVA: 0x0006C953 File Offset: 0x0006AB53
			public unsafe PlantData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400951C RID: 38172
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400951D RID: 38173
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400951E RID: 38174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400951F RID: 38175
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009520 RID: 38176
			private static readonly IntPtr NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0;

			// Token: 0x02000C85 RID: 3205
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0+<<LoadPlant>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6C6 RID: 59078 RVA: 0x0035FB74 File Offset: 0x0035DD74
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<<LoadPlant>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683959);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683960);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683961);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683962);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683963);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683964);
				}

				// Token: 0x0600E6C7 RID: 59079 RVA: 0x0035FC54 File Offset: 0x0035DE54
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6C8 RID: 59080 RVA: 0x0035FC9C File Offset: 0x0035DE9C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6C9 RID: 59081 RVA: 0x0035FCD0 File Offset: 0x0035DED0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291336, XrefRangeEnd = 291390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047E3 RID: 18403
				// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x0035FD0C File Offset: 0x0035DF0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6CB RID: 59083 RVA: 0x0035FD4C File Offset: 0x0035DF4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291390, XrefRangeEnd = 291395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047E4 RID: 18404
				// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x0035FD80 File Offset: 0x0035DF80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6CD RID: 59085 RVA: 0x00070AB1 File Offset: 0x0006ECB1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E0 RID: 18400
				// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0035FDC0 File Offset: 0x0035DFC0
				// (set) Token: 0x0600E6CF RID: 59087 RVA: 0x00070ABA File Offset: 0x0006ECBA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E1 RID: 18401
				// (get) Token: 0x0600E6D0 RID: 59088 RVA: 0x0035FDE8 File Offset: 0x0035DFE8
				// (set) Token: 0x0600E6D1 RID: 59089 RVA: 0x00070AD5 File Offset: 0x0006ECD5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E2 RID: 18402
				// (get) Token: 0x0600E6D2 RID: 59090 RVA: 0x0035FE18 File Offset: 0x0035E018
				// (set) Token: 0x0600E6D3 RID: 59091 RVA: 0x00070AF4 File Offset: 0x0006ECF4
				public unsafe Pot.__c__DisplayClass196_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass196_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A37 RID: 39479
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A38 RID: 39480
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A39 RID: 39481
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A3A RID: 39482
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A3B RID: 39483
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A3C RID: 39484
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A3D RID: 39485
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A3E RID: 39486
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A3F RID: 39487
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
