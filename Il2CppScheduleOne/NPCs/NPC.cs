using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs.Actions;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D3 RID: 723
	public class NPC : NetworkBehaviour
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00111168 File Offset: 0x0010F368
		// Note: this type is marked as 'beforefieldinit'.
		static NPC()
		{
			Il2CppClassPointerStore<NPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC>.NativeClassPtr);
			NPC.NativeFieldInfoPtr_PANIC_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "PANIC_DURATION");
			NPC.NativeFieldInfoPtr_RequiresRegionUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "RequiresRegionUnlocked");
			NPC.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "FirstName");
			NPC.NativeFieldInfoPtr_hasLastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "hasLastName");
			NPC.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "LastName");
			NPC.NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<Scale>k__BackingField");
			NPC.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "ID");
			NPC.NativeFieldInfoPtr_AutoGenerateMugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "AutoGenerateMugshot");
			NPC.NativeFieldInfoPtr_MugshotSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "MugshotSprite");
			NPC.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Region");
			NPC.NativeFieldInfoPtr_IsImportant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "IsImportant");
			NPC.NativeFieldInfoPtr_Aggression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Aggression");
			NPC.NativeFieldInfoPtr_modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "modelContainer");
			NPC.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "movement");
			NPC.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "intObj");
			NPC.NativeFieldInfoPtr_dialogueHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "dialogueHandler");
			NPC.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Avatar");
			NPC.NativeFieldInfoPtr_awareness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "awareness");
			NPC.NativeFieldInfoPtr_responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "responses");
			NPC.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "actions");
			NPC.NativeFieldInfoPtr_behaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "behaviour");
			NPC.NativeFieldInfoPtr__Inventory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<Inventory>k__BackingField");
			NPC.NativeFieldInfoPtr_VoiceOverEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "VoiceOverEmitter");
			NPC.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Health");
			NPC.NativeFieldInfoPtr__CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<CurrentVehicle>k__BackingField");
			NPC.NativeFieldInfoPtr_onEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "onEnterVehicle");
			NPC.NativeFieldInfoPtr_onExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "onExitVehicle");
			NPC.NativeFieldInfoPtr__CurrentBuilding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<CurrentBuilding>k__BackingField");
			NPC.NativeFieldInfoPtr__LastEnteredDoor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<LastEnteredDoor>k__BackingField");
			NPC.NativeFieldInfoPtr_CanBeSummoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "CanBeSummoned");
			NPC.NativeFieldInfoPtr_RelationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "RelationData");
			NPC.NativeFieldInfoPtr_NPCUnlockedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "NPCUnlockedVariable");
			NPC.NativeFieldInfoPtr_ShowRelationshipInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "ShowRelationshipInfo");
			NPC.NativeFieldInfoPtr_ConversationCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "ConversationCategories");
			NPC.NativeFieldInfoPtr__MSGConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<MSGConversation>k__BackingField");
			NPC.NativeFieldInfoPtr_ConversationCanBeHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "ConversationCanBeHidden");
			NPC.NativeFieldInfoPtr_onConversationCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "onConversationCreated");
			NPC.NativeFieldInfoPtr_CanOpenDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "CanOpenDoors");
			NPC.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "OutlineRenderers");
			NPC.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "OutlineEffect");
			NPC.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			NPC.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			NPC.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<HasChanged>k__BackingField");
			NPC.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "BakedGUID");
			NPC.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<GUID>k__BackingField");
			NPC.NativeFieldInfoPtr__isVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<isVisible>k__BackingField");
			NPC.NativeFieldInfoPtr_onVisibilityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "onVisibilityChanged");
			NPC.NativeFieldInfoPtr_PlayerConversant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "PlayerConversant");
			NPC.NativeFieldInfoPtr__isUnsettled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<isUnsettled>k__BackingField");
			NPC.NativeFieldInfoPtr_resetUnsettledCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "resetUnsettledCoroutine");
			NPC.NativeFieldInfoPtr__timeSincePanicked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<timeSincePanicked>k__BackingField");
			NPC.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "impactHistory");
			NPC.NativeFieldInfoPtr_headlightStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "headlightStartTime");
			NPC.NativeFieldInfoPtr_heaedLightsEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "heaedLightsEndTime");
			NPC.NativeFieldInfoPtr_defaultAggression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "defaultAggression");
			NPC.NativeFieldInfoPtr_lerpScaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "lerpScaleRoutine");
			NPC.NativeFieldInfoPtr_syncVar___PlayerConversant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "syncVar___PlayerConversant");
			NPC.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted");
			NPC.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCAssembly-CSharp.dll_Excuted");
			NPC.NativeMethodInfoPtr_get_fullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668935);
			NPC.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668936);
			NPC.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668937);
			NPC.NativeMethodInfoPtr_get_IsConscious_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668938);
			NPC.NativeMethodInfoPtr_get_Movement_Public_get_NPCMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668939);
			NPC.NativeMethodInfoPtr_get_Inventory_Public_get_NPCInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668940);
			NPC.NativeMethodInfoPtr_set_Inventory_Protected_set_Void_NPCInventory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668941);
			NPC.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668942);
			NPC.NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668943);
			NPC.NativeMethodInfoPtr_get_IsInVehicle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668944);
			NPC.NativeMethodInfoPtr_get_isInBuilding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668945);
			NPC.NativeMethodInfoPtr_get_CurrentBuilding_Public_get_NPCEnterableBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668946);
			NPC.NativeMethodInfoPtr_set_CurrentBuilding_Protected_set_Void_NPCEnterableBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668947);
			NPC.NativeMethodInfoPtr_get_LastEnteredDoor_Public_get_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668948);
			NPC.NativeMethodInfoPtr_set_LastEnteredDoor_Public_set_Void_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668949);
			NPC.NativeMethodInfoPtr_get_MSGConversation_Public_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668950);
			NPC.NativeMethodInfoPtr_set_MSGConversation_Protected_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668951);
			NPC.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668952);
			NPC.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668953);
			NPC.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668954);
			NPC.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668955);
			NPC.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668956);
			NPC.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668957);
			NPC.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668958);
			NPC.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668959);
			NPC.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668960);
			NPC.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668961);
			NPC.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668962);
			NPC.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668963);
			NPC.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668964);
			NPC.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668965);
			NPC.NativeMethodInfoPtr_get_isUnsettled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668966);
			NPC.NativeMethodInfoPtr_set_isUnsettled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668967);
			NPC.NativeMethodInfoPtr_get_IsPanicked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668968);
			NPC.NativeMethodInfoPtr_get_timeSincePanicked_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668969);
			NPC.NativeMethodInfoPtr_set_timeSincePanicked_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668970);
			NPC.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668971);
			NPC.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668972);
			NPC.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668973);
			NPC.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668974);
			NPC.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668975);
			NPC.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668976);
			NPC.NativeMethodInfoPtr_SendTextMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668977);
			NPC.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668978);
			NPC.NativeMethodInfoPtr_GetHealth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668979);
			NPC.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668980);
			NPC.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668981);
			NPC.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668982);
			NPC.NativeMethodInfoPtr_SetTransform_Private_Void_NetworkConnection_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668983);
			NPC.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668984);
			NPC.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668985);
			NPC.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668986);
			NPC.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668987);
			NPC.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668988);
			NPC.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668989);
			NPC.NativeMethodInfoPtr_AimedAtByPlayer_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668990);
			NPC.NativeMethodInfoPtr_OverrideAggression_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668991);
			NPC.NativeMethodInfoPtr_ResetAggression_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668992);
			NPC.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668993);
			NPC.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668994);
			NPC.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668995);
			NPC.NativeMethodInfoPtr_EnterVehicle_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668996);
			NPC.NativeMethodInfoPtr_ExitVehicle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668997);
			NPC.NativeMethodInfoPtr_SendWorldspaceDialogueKey_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668998);
			NPC.NativeMethodInfoPtr_PlayWorldspaceDialogue_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100668999);
			NPC.NativeMethodInfoPtr_SetConversant_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669000);
			NPC.NativeMethodInfoPtr_Hovered_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669001);
			NPC.NativeMethodInfoPtr_Interacted_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669002);
			NPC.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669003);
			NPC.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669004);
			NPC.NativeMethodInfoPtr_EnterBuilding_Public_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669005);
			NPC.NativeMethodInfoPtr_ExitBuilding_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669006);
			NPC.NativeMethodInfoPtr_SetEquippable_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669007);
			NPC.NativeMethodInfoPtr_SetEquippable_Networked_Return_Public_AvatarEquippable_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669008);
			NPC.NativeMethodInfoPtr_SetEquippable_Return_Public_AvatarEquippable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669009);
			NPC.NativeMethodInfoPtr_SetEquippable_Networked_ExcludeServer_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669010);
			NPC.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669011);
			NPC.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_NetworkConnection_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669012);
			NPC.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669013);
			NPC.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669014);
			NPC.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669015);
			NPC.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669016);
			NPC.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669017);
			NPC.NativeMethodInfoPtr_SetCrouched_Networked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669018);
			NPC.NativeMethodInfoPtr_SetAnimationBool_Networked_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669019);
			NPC.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669020);
			NPC.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_New_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669021);
			NPC.NativeMethodInfoPtr_SetUnsettled_30s_Protected_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669022);
			NPC.NativeMethodInfoPtr_SetUnsettled_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669023);
			NPC.NativeMethodInfoPtr_SetPanicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669024);
			NPC.NativeMethodInfoPtr_ReceivePanicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669025);
			NPC.NativeMethodInfoPtr_RemovePanicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669026);
			NPC.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669027);
			NPC.NativeMethodInfoPtr_PlayVO_Public_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669028);
			NPC.NativeMethodInfoPtr_ReceiveRelationshipData_Public_Void_NetworkConnection_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669029);
			NPC.NativeMethodInfoPtr_SetIsBeingPickPocketed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669030);
			NPC.NativeMethodInfoPtr_SendRelationship_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669031);
			NPC.NativeMethodInfoPtr_SetRelationship_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669032);
			NPC.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Final_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669033);
			NPC.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669034);
			NPC.NativeMethodInfoPtr_HideOutline_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669035);
			NPC.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669036);
			NPC.NativeMethodInfoPtr_ShouldSaveRelationshipData_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669037);
			NPC.NativeMethodInfoPtr_ShouldSaveMessages_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669038);
			NPC.NativeMethodInfoPtr_ShouldSaveInventory_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669039);
			NPC.NativeMethodInfoPtr_ShouldSaveHealth_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669040);
			NPC.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669041);
			NPC.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669042);
			NPC.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669043);
			NPC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669044);
			NPC.NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669045);
			NPC.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669046);
			NPC.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669047);
			NPC.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669048);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669049);
			NPC.NativeMethodInfoPtr_RpcLogic___SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669050);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_4260003484_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669051);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_AimedAtByPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669052);
			NPC.NativeMethodInfoPtr_RpcLogic___AimedAtByPlayer_3323014238_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669053);
			NPC.NativeMethodInfoPtr_RpcReader___Server_AimedAtByPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669054);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669055);
			NPC.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669056);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669057);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669058);
			NPC.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669059);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669060);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669061);
			NPC.NativeMethodInfoPtr_RpcLogic___EnterVehicle_3321926803_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669062);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669063);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669064);
			NPC.NativeMethodInfoPtr_RpcReader___Target_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669065);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_ExitVehicle_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669066);
			NPC.NativeMethodInfoPtr_RpcLogic___ExitVehicle_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669067);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_ExitVehicle_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669068);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SendWorldspaceDialogueKey_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669069);
			NPC.NativeMethodInfoPtr_RpcLogic___SendWorldspaceDialogueKey_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669070);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SendWorldspaceDialogueKey_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669071);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669072);
			NPC.NativeMethodInfoPtr_RpcLogic___PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669073);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_PlayWorldspaceDialogue_606697822_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669074);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SetConversant_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669075);
			NPC.NativeMethodInfoPtr_RpcLogic___SetConversant_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669076);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SetConversant_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669077);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669078);
			NPC.NativeMethodInfoPtr_RpcLogic___EnterBuilding_3905681115_Public_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669079);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669080);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669081);
			NPC.NativeMethodInfoPtr_RpcReader___Target_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669082);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_ExitBuilding_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669083);
			NPC.NativeMethodInfoPtr_RpcLogic___ExitBuilding_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669084);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_ExitBuilding_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669085);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669086);
			NPC.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669087);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669088);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669089);
			NPC.NativeMethodInfoPtr_RpcReader___Target_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669090);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669091);
			NPC.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669092);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669093);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669094);
			NPC.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669095);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669096);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669097);
			NPC.NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669098);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669099);
			NPC.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_4022222929_Public_Void_NetworkConnection_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669100);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669101);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669102);
			NPC.NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669103);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669104);
			NPC.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669105);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669106);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669107);
			NPC.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669108);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669109);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669110);
			NPC.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669111);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669112);
			NPC.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669113);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669114);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669115);
			NPC.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669116);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetCrouched_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669117);
			NPC.NativeMethodInfoPtr_RpcLogic___SetCrouched_Networked_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669118);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetCrouched_Networked_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669119);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669120);
			NPC.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_Networked_619441887_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669121);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669122);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669123);
			NPC.NativeMethodInfoPtr_RpcReader___Target_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669124);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SetPanicked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669125);
			NPC.NativeMethodInfoPtr_RpcLogic___SetPanicked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669126);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SetPanicked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669127);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePanicked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669128);
			NPC.NativeMethodInfoPtr_RpcLogic___ReceivePanicked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669129);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_ReceivePanicked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669130);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_RemovePanicked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669131);
			NPC.NativeMethodInfoPtr_RpcLogic___RemovePanicked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669132);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_RemovePanicked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669133);
			NPC.NativeMethodInfoPtr_RpcWriter___Target_ReceiveRelationshipData_4052192084_Private_Void_NetworkConnection_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669134);
			NPC.NativeMethodInfoPtr_RpcLogic___ReceiveRelationshipData_4052192084_Public_Void_NetworkConnection_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669135);
			NPC.NativeMethodInfoPtr_RpcReader___Target_ReceiveRelationshipData_4052192084_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669136);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SetIsBeingPickPocketed_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669137);
			NPC.NativeMethodInfoPtr_RpcLogic___SetIsBeingPickPocketed_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669138);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SetIsBeingPickPocketed_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669139);
			NPC.NativeMethodInfoPtr_RpcWriter___Server_SendRelationship_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669140);
			NPC.NativeMethodInfoPtr_RpcLogic___SendRelationship_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669141);
			NPC.NativeMethodInfoPtr_RpcReader___Server_SendRelationship_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669142);
			NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetRelationship_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669143);
			NPC.NativeMethodInfoPtr_RpcLogic___SetRelationship_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669144);
			NPC.NativeMethodInfoPtr_RpcReader___Observers_SetRelationship_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669145);
			NPC.NativeMethodInfoPtr_sync___get_value_PlayerConversant_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669146);
			NPC.NativeMethodInfoPtr_sync___set_value_PlayerConversant_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669147);
			NPC.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPC_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669148);
			NPC.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100669149);
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x00112700 File Offset: 0x00110900
		public unsafe string fullName
		{
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 131771, RefRangeEnd = 131847, XrefRangeStart = 131770, XrefRangeEnd = 131771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_fullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x00112738 File Offset: 0x00110938
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00112774 File Offset: 0x00110974
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x001127B4 File Offset: 0x001109B4
		public unsafe bool IsConscious
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 131847, RefRangeEnd = 131864, XrefRangeStart = 131847, XrefRangeEnd = 131847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_IsConscious_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x001127F0 File Offset: 0x001109F0
		public unsafe NPCMovement Movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Movement_Public_get_NPCMovement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr3) : null;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00112830 File Offset: 0x00110A30
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x00112870 File Offset: 0x00110A70
		public unsafe NPCInventory Inventory
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 131864, RefRangeEnd = 131874, XrefRangeStart = 131864, XrefRangeEnd = 131864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Inventory_Public_get_NPCInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCInventory>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131874, XrefRangeEnd = 131875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Inventory_Protected_set_Void_NPCInventory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x001128B4 File Offset: 0x00110AB4
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x001128F4 File Offset: 0x00110AF4
		public unsafe LandVehicle CurrentVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131875, XrefRangeEnd = 131876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00112938 File Offset: 0x00110B38
		public unsafe bool IsInVehicle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 131880, RefRangeEnd = 131888, XrefRangeStart = 131876, XrefRangeEnd = 131880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_IsInVehicle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x00112974 File Offset: 0x00110B74
		public unsafe bool isInBuilding
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 131892, RefRangeEnd = 131895, XrefRangeStart = 131888, XrefRangeEnd = 131892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_isInBuilding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x001129B0 File Offset: 0x00110BB0
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x001129F0 File Offset: 0x00110BF0
		public unsafe NPCEnterableBuilding CurrentBuilding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_CurrentBuilding_Public_get_NPCEnterableBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_CurrentBuilding_Protected_set_Void_NPCEnterableBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x00112A34 File Offset: 0x00110C34
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00112A74 File Offset: 0x00110C74
		public unsafe StaticDoor LastEnteredDoor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_LastEnteredDoor_Public_get_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131895, XrefRangeEnd = 131896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_LastEnteredDoor_Public_set_Void_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x00112AB8 File Offset: 0x00110CB8
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00112AF8 File Offset: 0x00110CF8
		public unsafe MSGConversation MSGConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_MSGConversation_Public_get_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131896, XrefRangeEnd = 131897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_MSGConversation_Protected_set_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x00112B3C File Offset: 0x00110D3C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(76)]
			[CachedScanResults(RefRangeStart = 131771, RefRangeEnd = 131847, XrefRangeStart = 131771, XrefRangeEnd = 131847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x00112B74 File Offset: 0x00110D74
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131897, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x00112BAC File Offset: 0x00110DAC
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x00112BEC File Offset: 0x00110DEC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x00112C28 File Offset: 0x00110E28
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00112C68 File Offset: 0x00110E68
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131899, XrefRangeEnd = 131900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x00112CAC File Offset: 0x00110EAC
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00112CEC File Offset: 0x00110EEC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131900, XrefRangeEnd = 131901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00112D30 File Offset: 0x00110F30
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00112D6C File Offset: 0x00110F6C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00112DAC File Offset: 0x00110FAC
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x00112DE8 File Offset: 0x00110FE8
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00112E28 File Offset: 0x00111028
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00112E64 File Offset: 0x00111064
		public unsafe bool isVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x00112EA4 File Offset: 0x001110A4
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00112EE0 File Offset: 0x001110E0
		public unsafe bool isUnsettled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_isUnsettled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_isUnsettled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x00112F20 File Offset: 0x00111120
		public unsafe bool IsPanicked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_IsPanicked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x00112F5C File Offset: 0x0011115C
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x00112F98 File Offset: 0x00111198
		public unsafe float timeSincePanicked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_timeSincePanicked_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_timeSincePanicked_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00112FD8 File Offset: 0x001111D8
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 131902, RefRangeEnd = 131977, XrefRangeStart = 131901, XrefRangeEnd = 131902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00113014 File Offset: 0x00111214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131977, XrefRangeEnd = 131983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00113050 File Offset: 0x00111250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131987, RefRangeEnd = 131988, XrefRangeStart = 131983, XrefRangeEnd = 131987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00113090 File Offset: 0x00111290
		[CallerCount(0)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x001130C4 File Offset: 0x001112C4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x00113100 File Offset: 0x00111300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132007, RefRangeEnd = 132008, XrefRangeStart = 131988, XrefRangeEnd = 132007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0011313C File Offset: 0x0011133C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132008, XrefRangeEnd = 132014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTextMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendTextMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x00113180 File Offset: 0x00111380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132047, RefRangeEnd = 132048, XrefRangeStart = 132014, XrefRangeEnd = 132047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001131BC File Offset: 0x001113BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132064, RefRangeEnd = 132066, XrefRangeStart = 132048, XrefRangeEnd = 132064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetHealth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GetHealth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x001131F0 File Offset: 0x001113F0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 132121, RefRangeEnd = 132137, XrefRangeStart = 132066, XrefRangeEnd = 132121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0011322C File Offset: 0x0011142C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132153, RefRangeEnd = 132154, XrefRangeStart = 132137, XrefRangeEnd = 132153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x00113268 File Offset: 0x00111468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132200, RefRangeEnd = 132203, XrefRangeStart = 132154, XrefRangeEnd = 132200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001132B8 File Offset: 0x001114B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132203, XrefRangeEnd = 132204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetTransform_Private_Void_NetworkConnection_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x00113318 File Offset: 0x00111518
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 132254, RefRangeEnd = 132260, XrefRangeStart = 132204, XrefRangeEnd = 132254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00113354 File Offset: 0x00111554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132260, RefRangeEnd = 132261, XrefRangeStart = 132260, XrefRangeEnd = 132260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00113390 File Offset: 0x00111590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132261, XrefRangeEnd = 132265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x001133DC File Offset: 0x001115DC
		[CallerCount(0)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0011341C File Offset: 0x0011161C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132283, RefRangeEnd = 132285, XrefRangeStart = 132265, XrefRangeEnd = 132283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00113468 File Offset: 0x00111668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132285, XrefRangeEnd = 132287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x001134A4 File Offset: 0x001116A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132287, XrefRangeEnd = 132306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AimedAtByPlayer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_AimedAtByPlayer_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x001134F4 File Offset: 0x001116F4
		[CallerCount(0)]
		public unsafe void OverrideAggression(float aggression)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aggression;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_OverrideAggression_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00113534 File Offset: 0x00111734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132306, RefRangeEnd = 132307, XrefRangeStart = 132306, XrefRangeEnd = 132306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAggression()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ResetAggression_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00113568 File Offset: 0x00111768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132307, XrefRangeEnd = 132328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x001135B8 File Offset: 0x001117B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132328, XrefRangeEnd = 132350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00113608 File Offset: 0x00111808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132350, XrefRangeEnd = 132351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00113670 File Offset: 0x00111870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132351, XrefRangeEnd = 132393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EnterVehicle(NetworkConnection connection, LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_EnterVehicle_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x001136D0 File Offset: 0x001118D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132393, XrefRangeEnd = 132414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ExitVehicle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0011370C File Offset: 0x0011190C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132414, XrefRangeEnd = 132437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWorldspaceDialogueKey(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendWorldspaceDialogueKey_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0011375C File Offset: 0x0011195C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132458, RefRangeEnd = 132460, XrefRangeStart = 132437, XrefRangeEnd = 132458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayWorldspaceDialogue(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_PlayWorldspaceDialogue_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x001137AC File Offset: 0x001119AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132482, RefRangeEnd = 132484, XrefRangeStart = 132460, XrefRangeEnd = 132482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConversant(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetConversant_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x001137F0 File Offset: 0x001119F0
		[CallerCount(0)]
		public unsafe void Hovered_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Hovered_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00113824 File Offset: 0x00111A24
		[CallerCount(0)]
		public unsafe void Interacted_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Interacted_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00113858 File Offset: 0x00111A58
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00113894 File Offset: 0x00111A94
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x001138D0 File Offset: 0x00111AD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132530, RefRangeEnd = 132534, XrefRangeStart = 132484, XrefRangeEnd = 132530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterBuilding(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_EnterBuilding_Public_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00113934 File Offset: 0x00111B34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 132556, RefRangeEnd = 132561, XrefRangeStart = 132534, XrefRangeEnd = 132556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitBuilding(string buildingID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ExitBuilding_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00113978 File Offset: 0x00111B78
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 132571, RefRangeEnd = 132593, XrefRangeStart = 132561, XrefRangeEnd = 132571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable_Networked(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetEquippable_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x001139CC File Offset: 0x00111BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132615, RefRangeEnd = 132616, XrefRangeStart = 132593, XrefRangeEnd = 132615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable SetEquippable_Networked_Return(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetEquippable_Networked_Return_Public_AvatarEquippable_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00113A30 File Offset: 0x00111C30
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 132617, RefRangeEnd = 132628, XrefRangeStart = 132616, XrefRangeEnd = 132617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable SetEquippable_Return(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetEquippable_Return_Public_AvatarEquippable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00113A80 File Offset: 0x00111C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132628, XrefRangeEnd = 132648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable_Networked_ExcludeServer(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetEquippable_Networked_ExcludeServer_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00113AD4 File Offset: 0x00111CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132658, RefRangeEnd = 132661, XrefRangeStart = 132648, XrefRangeEnd = 132658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00113B28 File Offset: 0x00111D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132674, RefRangeEnd = 132676, XrefRangeStart = 132661, XrefRangeEnd = 132674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked_Vector(NetworkConnection conn, string message, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_NetworkConnection_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x00113B8C File Offset: 0x00111D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132695, RefRangeEnd = 132696, XrefRangeStart = 132676, XrefRangeEnd = 132695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00113BD0 File Offset: 0x00111DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132706, RefRangeEnd = 132708, XrefRangeStart = 132696, XrefRangeEnd = 132706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00113C24 File Offset: 0x00111E24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132710, RefRangeEnd = 132714, XrefRangeStart = 132708, XrefRangeEnd = 132710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00113C68 File Offset: 0x00111E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132714, XrefRangeEnd = 132724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00113CBC File Offset: 0x00111EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132726, RefRangeEnd = 132727, XrefRangeStart = 132724, XrefRangeEnd = 132726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x00113D00 File Offset: 0x00111F00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132749, RefRangeEnd = 132752, XrefRangeStart = 132727, XrefRangeEnd = 132749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched_Networked(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetCrouched_Networked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00113D40 File Offset: 0x00111F40
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 132763, RefRangeEnd = 132772, XrefRangeStart = 132752, XrefRangeEnd = 132763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationBool_Networked(NetworkConnection conn, string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetAnimationBool_Networked_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x00113DA4 File Offset: 0x00111FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132774, RefRangeEnd = 132776, XrefRangeStart = 132772, XrefRangeEnd = 132774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationBool(string trigger, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00113DF4 File Offset: 0x00111FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132777, RefRangeEnd = 132778, XrefRangeStart = 132776, XrefRangeEnd = 132777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_New_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00113E4C File Offset: 0x0011204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132778, XrefRangeEnd = 132796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUnsettled_30s(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_SetUnsettled_30s_Protected_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00113E9C File Offset: 0x0011209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132796, XrefRangeEnd = 132814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnsettled(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetUnsettled_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00113EDC File Offset: 0x001120DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132814, XrefRangeEnd = 132832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPanicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetPanicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00113F10 File Offset: 0x00112110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132832, XrefRangeEnd = 132850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePanicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ReceivePanicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00113F44 File Offset: 0x00112144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132850, XrefRangeEnd = 132868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePanicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RemovePanicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00113F78 File Offset: 0x00112178
		[CallerCount(0)]
		public unsafe virtual string GetNameAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00113FBC File Offset: 0x001121BC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 132869, RefRangeEnd = 132923, XrefRangeStart = 132868, XrefRangeEnd = 132869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayVO(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_PlayVO_Public_Void_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003305 RID: 13061 RVA: 0x00113FFC File Offset: 0x001121FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132923, XrefRangeEnd = 132934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRelationshipData(NetworkConnection conn, float relationship, bool unlocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relationship;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ReceiveRelationshipData_Public_Void_NetworkConnection_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0011405C File Offset: 0x0011225C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132953, RefRangeEnd = 132955, XrefRangeStart = 132934, XrefRangeEnd = 132953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsBeingPickPocketed(bool pickpocketed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pickpocketed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetIsBeingPickPocketed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0011409C File Offset: 0x0011229C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132974, RefRangeEnd = 132975, XrefRangeStart = 132955, XrefRangeEnd = 132974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRelationship(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SendRelationship_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x001140DC File Offset: 0x001122DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132975, XrefRangeEnd = 132994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRelationship(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetRelationship_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x0011411C File Offset: 0x0011231C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133043, RefRangeEnd = 133045, XrefRangeStart = 132994, XrefRangeEnd = 133043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Final_New_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0011415C File Offset: 0x0011235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133045, XrefRangeEnd = 133047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x0011419C File Offset: 0x0011239C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133052, RefRangeEnd = 133054, XrefRangeStart = 133047, XrefRangeEnd = 133052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_HideOutline_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x001141D0 File Offset: 0x001123D0
		[CallerCount(0)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00114218 File Offset: 0x00112418
		[CallerCount(0)]
		public unsafe virtual bool ShouldSaveRelationshipData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldSaveRelationshipData_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00114260 File Offset: 0x00112460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133054, XrefRangeEnd = 133055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSaveMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldSaveMessages_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x001142A8 File Offset: 0x001124A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133055, XrefRangeEnd = 133058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSaveInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldSaveInventory_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x001142F0 File Offset: 0x001124F0
		[CallerCount(0)]
		public unsafe virtual bool ShouldSaveHealth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ShouldSaveHealth_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00114338 File Offset: 0x00112538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133058, XrefRangeEnd = 133063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x0011437C File Offset: 0x0011257C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 133128, RefRangeEnd = 133136, XrefRangeStart = 133063, XrefRangeEnd = 133128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x001143D8 File Offset: 0x001125D8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00114438 File Offset: 0x00112638
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 133189, RefRangeEnd = 133263, XrefRangeStart = 133136, XrefRangeEnd = 133189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00114474 File Offset: 0x00112674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133263, XrefRangeEnd = 133275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EUnlockType_Boolean_PDM_0(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x001144C0 File Offset: 0x001126C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 133503, RefRangeEnd = 133577, XrefRangeStart = 133275, XrefRangeEnd = 133503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x001144FC File Offset: 0x001126FC
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 133577, RefRangeEnd = 133648, XrefRangeStart = 133577, XrefRangeEnd = 133577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00114538 File Offset: 0x00112738
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00114574 File Offset: 0x00112774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133673, RefRangeEnd = 133675, XrefRangeStart = 133648, XrefRangeEnd = 133673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x001145D4 File Offset: 0x001127D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133675, XrefRangeEnd = 133679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00114634 File Offset: 0x00112834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133679, XrefRangeEnd = 133690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTransform_4260003484(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_4260003484_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00114684 File Offset: 0x00112884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AimedAtByPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_AimedAtByPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x001146C8 File Offset: 0x001128C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133690, XrefRangeEnd = 133694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AimedAtByPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_RpcLogic___AimedAtByPlayer_3323014238_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00114718 File Offset: 0x00112918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133694, XrefRangeEnd = 133699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AimedAtByPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_AimedAtByPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0011477C File Offset: 0x0011297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133699, XrefRangeEnd = 133718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x001147C0 File Offset: 0x001129C0
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00114810 File Offset: 0x00112A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133718, XrefRangeEnd = 133721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00114874 File Offset: 0x00112A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133721, XrefRangeEnd = 133740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x001148B8 File Offset: 0x00112AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133749, RefRangeEnd = 133751, XrefRangeStart = 133740, XrefRangeEnd = 133749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00114908 File Offset: 0x00112B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133751, XrefRangeEnd = 133755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00114958 File Offset: 0x00112B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133755, XrefRangeEnd = 133774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x001149AC File Offset: 0x00112BAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 133798, RefRangeEnd = 133801, XrefRangeStart = 133774, XrefRangeEnd = 133798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_RpcLogic___EnterVehicle_3321926803_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00114A0C File Offset: 0x00112C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133801, XrefRangeEnd = 133805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00114A5C File Offset: 0x00112C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133805, XrefRangeEnd = 133824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00114AB0 File Offset: 0x00112CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133824, XrefRangeEnd = 133828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00114B00 File Offset: 0x00112D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133828, XrefRangeEnd = 133846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitVehicle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_ExitVehicle_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00114B34 File Offset: 0x00112D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133883, RefRangeEnd = 133885, XrefRangeStart = 133846, XrefRangeEnd = 133883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ExitVehicle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_RpcLogic___ExitVehicle_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00114B70 File Offset: 0x00112D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133885, XrefRangeEnd = 133888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitVehicle_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_ExitVehicle_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00114BC0 File Offset: 0x00112DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133888, XrefRangeEnd = 133908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SendWorldspaceDialogueKey_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00114C10 File Offset: 0x00112E10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132458, RefRangeEnd = 132460, XrefRangeStart = 132458, XrefRangeEnd = 132460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SendWorldspaceDialogueKey_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00114C60 File Offset: 0x00112E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133908, XrefRangeEnd = 133913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWorldspaceDialogueKey_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SendWorldspaceDialogueKey_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00114CC4 File Offset: 0x00112EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133913, XrefRangeEnd = 133933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayWorldspaceDialogue_606697822(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00114D14 File Offset: 0x00112F14
		[CallerCount(0)]
		public unsafe void RpcLogic___PlayWorldspaceDialogue_606697822(string key, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00114D64 File Offset: 0x00112F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133933, XrefRangeEnd = 133937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayWorldspaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_PlayWorldspaceDialogue_606697822_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00114DB4 File Offset: 0x00112FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133937, XrefRangeEnd = 133956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConversant_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SetConversant_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00114DF8 File Offset: 0x00112FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133964, RefRangeEnd = 133966, XrefRangeStart = 133956, XrefRangeEnd = 133964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetConversant_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetConversant_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00114E3C File Offset: 0x0011303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133966, XrefRangeEnd = 133970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConversant_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SetConversant_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00114EA0 File Offset: 0x001130A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133970, XrefRangeEnd = 133991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00114F04 File Offset: 0x00113104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134046, RefRangeEnd = 134049, XrefRangeStart = 133991, XrefRangeEnd = 134046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___EnterBuilding_3905681115_Public_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00114F68 File Offset: 0x00113168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134049, XrefRangeEnd = 134055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00114FB8 File Offset: 0x001131B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134055, XrefRangeEnd = 134067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0011501C File Offset: 0x0011321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134067, XrefRangeEnd = 134073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0011506C File Offset: 0x0011326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134073, XrefRangeEnd = 134092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_ExitBuilding_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x001150B0 File Offset: 0x001132B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134142, RefRangeEnd = 134145, XrefRangeStart = 134092, XrefRangeEnd = 134142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitBuilding_3615296227(string buildingID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___ExitBuilding_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x001150F4 File Offset: 0x001132F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134145, XrefRangeEnd = 134149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitBuilding_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_ExitBuilding_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00115144 File Offset: 0x00113344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134149, XrefRangeEnd = 134168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00115198 File Offset: 0x00113398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134168, XrefRangeEnd = 134169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x001151EC File Offset: 0x001133EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134169, XrefRangeEnd = 134172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0011523C File Offset: 0x0011343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134172, XrefRangeEnd = 134191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00115290 File Offset: 0x00113490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134191, XrefRangeEnd = 134194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x001152E0 File Offset: 0x001134E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00115334 File Offset: 0x00113534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00115388 File Offset: 0x00113588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134194, XrefRangeEnd = 134197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x001153D8 File Offset: 0x001135D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134197, XrefRangeEnd = 134216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0011542C File Offset: 0x0011362C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134216, XrefRangeEnd = 134217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00115480 File Offset: 0x00113680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134217, XrefRangeEnd = 134220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x001154D0 File Offset: 0x001136D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134220, XrefRangeEnd = 134239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00115524 File Offset: 0x00113724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134239, XrefRangeEnd = 134242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00115574 File Offset: 0x00113774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134242, XrefRangeEnd = 134264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x001155D8 File Offset: 0x001137D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134264, XrefRangeEnd = 134267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_4022222929_Public_Void_NetworkConnection_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x0011563C File Offset: 0x0011383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134267, XrefRangeEnd = 134276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0011568C File Offset: 0x0011388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134276, XrefRangeEnd = 134289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x001156F0 File Offset: 0x001138F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134289, XrefRangeEnd = 134298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00115740 File Offset: 0x00113940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132695, RefRangeEnd = 132696, XrefRangeStart = 132695, XrefRangeEnd = 132696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00115784 File Offset: 0x00113984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134298, XrefRangeEnd = 134299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x001157C8 File Offset: 0x001139C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134299, XrefRangeEnd = 134302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x0011582C File Offset: 0x00113A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134302, XrefRangeEnd = 134321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00115880 File Offset: 0x00113A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134321, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x001158D4 File Offset: 0x00113AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134323, XrefRangeEnd = 134327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00115924 File Offset: 0x00113B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134327, XrefRangeEnd = 134346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00115978 File Offset: 0x00113B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134346, XrefRangeEnd = 134350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x001159C8 File Offset: 0x00113BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134350, XrefRangeEnd = 134369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x00115A1C File Offset: 0x00113C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134369, XrefRangeEnd = 134371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00115A70 File Offset: 0x00113C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134371, XrefRangeEnd = 134375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00115AC0 File Offset: 0x00113CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134375, XrefRangeEnd = 134394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00115B14 File Offset: 0x00113D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134394, XrefRangeEnd = 134398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00115B64 File Offset: 0x00113D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134398, XrefRangeEnd = 134417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetCrouched_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x00115BA4 File Offset: 0x00113DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134417, XrefRangeEnd = 134419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCrouched_Networked_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetCrouched_Networked_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x00115BE4 File Offset: 0x00113DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134419, XrefRangeEnd = 134422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCrouched_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetCrouched_Networked_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x00115C34 File Offset: 0x00113E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134422, XrefRangeEnd = 134442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x00115C98 File Offset: 0x00113E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134442, XrefRangeEnd = 134444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_Networked_619441887_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x00115CFC File Offset: 0x00113EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134444, XrefRangeEnd = 134448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003363 RID: 13155 RVA: 0x00115D4C File Offset: 0x00113F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134448, XrefRangeEnd = 134459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003364 RID: 13156 RVA: 0x00115DB0 File Offset: 0x00113FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134459, XrefRangeEnd = 134463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00115E00 File Offset: 0x00114000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SetPanicked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00115E34 File Offset: 0x00114034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134463, XrefRangeEnd = 134472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetPanicked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00115E68 File Offset: 0x00114068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134472, XrefRangeEnd = 134482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPanicked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SetPanicked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00115ECC File Offset: 0x001140CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePanicked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00115F00 File Offset: 0x00114100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134490, RefRangeEnd = 134491, XrefRangeStart = 134482, XrefRangeEnd = 134490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___ReceivePanicked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00115F34 File Offset: 0x00114134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134491, XrefRangeEnd = 134493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_ReceivePanicked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00115F84 File Offset: 0x00114184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_RemovePanicked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00115FB8 File Offset: 0x001141B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134493, XrefRangeEnd = 134502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePanicked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___RemovePanicked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x00115FEC File Offset: 0x001141EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134502, XrefRangeEnd = 134511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_RemovePanicked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x0011603C File Offset: 0x0011423C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relationship;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Target_ReceiveRelationshipData_4052192084_Private_Void_NetworkConnection_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0011609C File Offset: 0x0011429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134511, XrefRangeEnd = 134527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relationship;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___ReceiveRelationshipData_4052192084_Public_Void_NetworkConnection_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x001160FC File Offset: 0x001142FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134527, XrefRangeEnd = 134546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveRelationshipData_4052192084(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Target_ReceiveRelationshipData_4052192084_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x0011614C File Offset: 0x0011434C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132953, RefRangeEnd = 132955, XrefRangeStart = 132953, XrefRangeEnd = 132955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pickpocketed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SetIsBeingPickPocketed_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x0011618C File Offset: 0x0011438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134546, XrefRangeEnd = 134549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pickpocketed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetIsBeingPickPocketed_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x001161CC File Offset: 0x001143CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134549, XrefRangeEnd = 134551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsBeingPickPocketed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SetIsBeingPickPocketed_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x00116230 File Offset: 0x00114430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132974, RefRangeEnd = 132975, XrefRangeStart = 132974, XrefRangeEnd = 132975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRelationship_431000436(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Server_SendRelationship_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00116270 File Offset: 0x00114470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRelationship_431000436(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SendRelationship_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x001162B0 File Offset: 0x001144B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134551, XrefRangeEnd = 134563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRelationship_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Server_SendRelationship_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00116314 File Offset: 0x00114514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRelationship_431000436(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcWriter___Observers_SetRelationship_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00116354 File Offset: 0x00114554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134563, XrefRangeEnd = 134564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRelationship_431000436(float relationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcLogic___SetRelationship_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00116394 File Offset: 0x00114594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134564, XrefRangeEnd = 134566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRelationship_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcReader___Observers_SetRelationship_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x001163E4 File Offset: 0x001145E4
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x00116424 File Offset: 0x00114624
		public unsafe NetworkObject SyncAccessor_PlayerConversant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_sync___get_value_PlayerConversant_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134575, RefRangeEnd = 134576, XrefRangeStart = 134566, XrefRangeEnd = 134575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_sync___set_value_PlayerConversant_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00116474 File Offset: 0x00114674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134576, XrefRangeEnd = 134580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_NPC(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPC_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x001164E8 File Offset: 0x001146E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 134747, RefRangeEnd = 134755, XrefRangeStart = 134580, XrefRangeEnd = 134747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0001B02F File Offset: 0x0001922F
		public NPC(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x0600337F RID: 13183 RVA: 0x00116524 File Offset: 0x00114724
		// (set) Token: 0x06003380 RID: 13184 RVA: 0x0001B038 File Offset: 0x00019238
		public unsafe static float PANIC_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPC.NativeFieldInfoPtr_PANIC_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPC.NativeFieldInfoPtr_PANIC_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06003381 RID: 13185 RVA: 0x00116540 File Offset: 0x00114740
		// (set) Token: 0x06003382 RID: 13186 RVA: 0x0001B046 File Offset: 0x00019246
		public unsafe static bool RequiresRegionUnlocked
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NPC.NativeFieldInfoPtr_RequiresRegionUnlocked, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPC.NativeFieldInfoPtr_RequiresRegionUnlocked, (void*)(&value));
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06003383 RID: 13187 RVA: 0x0011655C File Offset: 0x0011475C
		// (set) Token: 0x06003384 RID: 13188 RVA: 0x0001B054 File Offset: 0x00019254
		public unsafe string FirstName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x00116584 File Offset: 0x00114784
		// (set) Token: 0x06003386 RID: 13190 RVA: 0x0001B073 File Offset: 0x00019273
		public unsafe bool hasLastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_hasLastName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_hasLastName)) = value;
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x001165AC File Offset: 0x001147AC
		// (set) Token: 0x06003388 RID: 13192 RVA: 0x0001B08E File Offset: 0x0001928E
		public unsafe string LastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x001165D4 File Offset: 0x001147D4
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x0001B0AD File Offset: 0x000192AD
		public unsafe float _Scale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__Scale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__Scale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x001165FC File Offset: 0x001147FC
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x0001B0C8 File Offset: 0x000192C8
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x00116624 File Offset: 0x00114824
		// (set) Token: 0x0600338E RID: 13198 RVA: 0x0001B0E7 File Offset: 0x000192E7
		public unsafe bool AutoGenerateMugshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_AutoGenerateMugshot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_AutoGenerateMugshot)) = value;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x0600338F RID: 13199 RVA: 0x0011664C File Offset: 0x0011484C
		// (set) Token: 0x06003390 RID: 13200 RVA: 0x0001B102 File Offset: 0x00019302
		public unsafe Sprite MugshotSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_MugshotSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_MugshotSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06003391 RID: 13201 RVA: 0x0011667C File Offset: 0x0011487C
		// (set) Token: 0x06003392 RID: 13202 RVA: 0x0001B121 File Offset: 0x00019321
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x001166A4 File Offset: 0x001148A4
		// (set) Token: 0x06003394 RID: 13204 RVA: 0x0001B13C File Offset: 0x0001933C
		public unsafe bool IsImportant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_IsImportant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_IsImportant)) = value;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x001166CC File Offset: 0x001148CC
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x0001B157 File Offset: 0x00019357
		public unsafe float Aggression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Aggression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Aggression)) = value;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06003397 RID: 13207 RVA: 0x001166F4 File Offset: 0x001148F4
		// (set) Token: 0x06003398 RID: 13208 RVA: 0x0001B172 File Offset: 0x00019372
		public unsafe Transform modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003399 RID: 13209 RVA: 0x00116724 File Offset: 0x00114924
		// (set) Token: 0x0600339A RID: 13210 RVA: 0x0001B191 File Offset: 0x00019391
		public unsafe NPCMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x00116754 File Offset: 0x00114954
		// (set) Token: 0x0600339C RID: 13212 RVA: 0x0001B1B0 File Offset: 0x000193B0
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x0600339D RID: 13213 RVA: 0x00116784 File Offset: 0x00114984
		// (set) Token: 0x0600339E RID: 13214 RVA: 0x0001B1CF File Offset: 0x000193CF
		public unsafe DialogueHandler dialogueHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_dialogueHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_dialogueHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x001167B4 File Offset: 0x001149B4
		// (set) Token: 0x060033A0 RID: 13216 RVA: 0x0001B1EE File Offset: 0x000193EE
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x001167E4 File Offset: 0x001149E4
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x0001B20D File Offset: 0x0001940D
		public unsafe NPCAwareness awareness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_awareness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAwareness>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_awareness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00116814 File Offset: 0x00114A14
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x0001B22C File Offset: 0x0001942C
		public unsafe NPCResponses responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x00116844 File Offset: 0x00114A44
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x0001B24B File Offset: 0x0001944B
		public unsafe NPCActions actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCActions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x00116874 File Offset: 0x00114A74
		// (set) Token: 0x060033A8 RID: 13224 RVA: 0x0001B26A File Offset: 0x0001946A
		public unsafe NPCBehaviour behaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_behaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_behaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x001168A4 File Offset: 0x00114AA4
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x0001B289 File Offset: 0x00019489
		public unsafe NPCInventory _Inventory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__Inventory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCInventory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__Inventory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x001168D4 File Offset: 0x00114AD4
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x0001B2A8 File Offset: 0x000194A8
		public unsafe VOEmitter VoiceOverEmitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_VoiceOverEmitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VOEmitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_VoiceOverEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x00116904 File Offset: 0x00114B04
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x0001B2C7 File Offset: 0x000194C7
		public unsafe NPCHealth Health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Health);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCHealth>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Health), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x00116934 File Offset: 0x00114B34
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x0001B2E6 File Offset: 0x000194E6
		public unsafe LandVehicle _CurrentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__CurrentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x00116964 File Offset: 0x00114B64
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x0001B305 File Offset: 0x00019505
		public unsafe Action<LandVehicle> onEnterVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onEnterVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x00116994 File Offset: 0x00114B94
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x0001B324 File Offset: 0x00019524
		public unsafe Action<LandVehicle> onExitVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onExitVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x001169C4 File Offset: 0x00114BC4
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x0001B343 File Offset: 0x00019543
		public unsafe NPCEnterableBuilding _CurrentBuilding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__CurrentBuilding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__CurrentBuilding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x001169F4 File Offset: 0x00114BF4
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x0001B362 File Offset: 0x00019562
		public unsafe StaticDoor _LastEnteredDoor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LastEnteredDoor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LastEnteredDoor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x00116A24 File Offset: 0x00114C24
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x0001B381 File Offset: 0x00019581
		public unsafe bool CanBeSummoned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_CanBeSummoned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_CanBeSummoned)) = value;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x00116A4C File Offset: 0x00114C4C
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x0001B39C File Offset: 0x0001959C
		public unsafe NPCRelationData RelationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_RelationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCRelationData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_RelationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x00116A7C File Offset: 0x00114C7C
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x0001B3BB File Offset: 0x000195BB
		public unsafe string NPCUnlockedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_NPCUnlockedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_NPCUnlockedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x00116AA4 File Offset: 0x00114CA4
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x0001B3DA File Offset: 0x000195DA
		public unsafe bool ShowRelationshipInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ShowRelationshipInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ShowRelationshipInfo)) = value;
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x00116ACC File Offset: 0x00114CCC
		// (set) Token: 0x060033C2 RID: 13250 RVA: 0x0001B3F5 File Offset: 0x000195F5
		public unsafe List<EConversationCategory> ConversationCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ConversationCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ConversationCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x00116AFC File Offset: 0x00114CFC
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x0001B414 File Offset: 0x00019614
		public unsafe MSGConversation _MSGConversation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__MSGConversation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__MSGConversation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x00116B2C File Offset: 0x00114D2C
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x0001B433 File Offset: 0x00019633
		public unsafe bool ConversationCanBeHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ConversationCanBeHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ConversationCanBeHidden)) = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00116B54 File Offset: 0x00114D54
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x0001B44E File Offset: 0x0001964E
		public unsafe Action onConversationCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onConversationCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onConversationCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x00116B84 File Offset: 0x00114D84
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x0001B46D File Offset: 0x0001966D
		public unsafe bool CanOpenDoors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_CanOpenDoors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_CanOpenDoors)) = value;
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x00116BAC File Offset: 0x00114DAC
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x0001B488 File Offset: 0x00019688
		public unsafe List<GameObject> OutlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_OutlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x00116BDC File Offset: 0x00114DDC
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x0001B4A7 File Offset: 0x000196A7
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_OutlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x00116C0C File Offset: 0x00114E0C
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x0001B4C6 File Offset: 0x000196C6
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x00116C3C File Offset: 0x00114E3C
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x0001B4E5 File Offset: 0x000196E5
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x00116C6C File Offset: 0x00114E6C
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x0001B504 File Offset: 0x00019704
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x00116C94 File Offset: 0x00114E94
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x0001B51F File Offset: 0x0001971F
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x00116CBC File Offset: 0x00114EBC
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x0001B53E File Offset: 0x0001973E
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x00116CE4 File Offset: 0x00114EE4
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x0001B559 File Offset: 0x00019759
		public unsafe bool _isVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__isVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__isVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x00116D0C File Offset: 0x00114F0C
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x0001B574 File Offset: 0x00019774
		public unsafe Action<bool> onVisibilityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onVisibilityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_onVisibilityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00116D3C File Offset: 0x00114F3C
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x0001B593 File Offset: 0x00019793
		public unsafe NetworkObject PlayerConversant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_PlayerConversant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_PlayerConversant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x00116D6C File Offset: 0x00114F6C
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x0001B5B2 File Offset: 0x000197B2
		public unsafe bool _isUnsettled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__isUnsettled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__isUnsettled_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x00116D94 File Offset: 0x00114F94
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x0001B5CD File Offset: 0x000197CD
		public unsafe Coroutine resetUnsettledCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_resetUnsettledCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_resetUnsettledCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00116DC4 File Offset: 0x00114FC4
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x0001B5EC File Offset: 0x000197EC
		public unsafe float _timeSincePanicked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__timeSincePanicked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr__timeSincePanicked_k__BackingField)) = value;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00116DEC File Offset: 0x00114FEC
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x0001B607 File Offset: 0x00019807
		public unsafe List<int> impactHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_impactHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x00116E1C File Offset: 0x0011501C
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x0001B626 File Offset: 0x00019826
		public unsafe int headlightStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_headlightStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_headlightStartTime)) = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00116E44 File Offset: 0x00115044
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x0001B641 File Offset: 0x00019841
		public unsafe int heaedLightsEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_heaedLightsEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_heaedLightsEndTime)) = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00116E6C File Offset: 0x0011506C
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x0001B65C File Offset: 0x0001985C
		public unsafe float defaultAggression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_defaultAggression);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_defaultAggression)) = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x00116E94 File Offset: 0x00115094
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x0001B677 File Offset: 0x00019877
		public unsafe Coroutine lerpScaleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_lerpScaleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_lerpScaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x060033EF RID: 13295 RVA: 0x00116EC4 File Offset: 0x001150C4
		// (set) Token: 0x060033F0 RID: 13296 RVA: 0x0001B696 File Offset: 0x00019896
		public unsafe SyncVar<NetworkObject> syncVar___PlayerConversant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_syncVar___PlayerConversant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_syncVar___PlayerConversant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x00116EF4 File Offset: 0x001150F4
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x0001B6B5 File Offset: 0x000198B5
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x00116F1C File Offset: 0x0011511C
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x0001B6D0 File Offset: 0x000198D0
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeFieldInfoPtr_PANIC_DURATION;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeFieldInfoPtr_RequiresRegionUnlocked;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr_hasLastName;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeFieldInfoPtr_AutoGenerateMugshot;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr_MugshotSprite;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeFieldInfoPtr_IsImportant;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeFieldInfoPtr_Aggression;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeFieldInfoPtr_modelContainer;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeFieldInfoPtr_dialogueHandler;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_awareness;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_responses;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_actions;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_behaviour;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr__Inventory_k__BackingField;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_VoiceOverEmitter;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeFieldInfoPtr__CurrentVehicle_k__BackingField;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_onEnterVehicle;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeFieldInfoPtr_onExitVehicle;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBuilding_k__BackingField;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr__LastEnteredDoor_k__BackingField;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_CanBeSummoned;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_RelationData;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_NPCUnlockedVariable;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_ShowRelationshipInfo;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_ConversationCategories;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr__MSGConversation_k__BackingField;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_ConversationCanBeHidden;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_onConversationCreated;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_CanOpenDoors;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr__isVisible_k__BackingField;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_onVisibilityChanged;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_PlayerConversant;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeFieldInfoPtr__isUnsettled_k__BackingField;

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_resetUnsettledCoroutine;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr__timeSincePanicked_k__BackingField;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_headlightStartTime;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_heaedLightsEndTime;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_defaultAggression;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeFieldInfoPtr_lerpScaleRoutine;

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___PlayerConversant;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeMethodInfoPtr_get_fullName_Public_get_String_0;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConscious_Public_get_Boolean_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr_get_Movement_Public_get_NPCMovement_0;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr_get_Inventory_Public_get_NPCInventory_0;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr_set_Inventory_Protected_set_Void_NPCInventory_0;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentVehicle_Public_get_LandVehicle_0;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInVehicle_Public_get_Boolean_0;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeMethodInfoPtr_get_isInBuilding_Public_get_Boolean_0;

		// Token: 0x04002113 RID: 8467
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBuilding_Public_get_NPCEnterableBuilding_0;

		// Token: 0x04002114 RID: 8468
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBuilding_Protected_set_Void_NPCEnterableBuilding_0;

		// Token: 0x04002115 RID: 8469
		private static readonly IntPtr NativeMethodInfoPtr_get_LastEnteredDoor_Public_get_StaticDoor_0;

		// Token: 0x04002116 RID: 8470
		private static readonly IntPtr NativeMethodInfoPtr_set_LastEnteredDoor_Public_set_Void_StaticDoor_0;

		// Token: 0x04002117 RID: 8471
		private static readonly IntPtr NativeMethodInfoPtr_get_MSGConversation_Public_get_MSGConversation_0;

		// Token: 0x04002118 RID: 8472
		private static readonly IntPtr NativeMethodInfoPtr_set_MSGConversation_Protected_set_Void_MSGConversation_0;

		// Token: 0x04002119 RID: 8473
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400211A RID: 8474
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400211B RID: 8475
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400211C RID: 8476
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400211D RID: 8477
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400211E RID: 8478
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr_get_isUnsettled_Public_get_Boolean_0;

		// Token: 0x04002128 RID: 8488
		private static readonly IntPtr NativeMethodInfoPtr_set_isUnsettled_Protected_set_Void_Boolean_0;

		// Token: 0x04002129 RID: 8489
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPanicked_Public_get_Boolean_0;

		// Token: 0x0400212A RID: 8490
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSincePanicked_Public_get_Single_0;

		// Token: 0x0400212B RID: 8491
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSincePanicked_Protected_set_Void_Single_0;

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400212F RID: 8495
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04002130 RID: 8496
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04002131 RID: 8497
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_New_Void_1;

		// Token: 0x04002132 RID: 8498
		private static readonly IntPtr NativeMethodInfoPtr_SendTextMessage_Public_Void_String_0;

		// Token: 0x04002133 RID: 8499
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04002134 RID: 8500
		private static readonly IntPtr NativeMethodInfoPtr_GetHealth_Private_Void_0;

		// Token: 0x04002135 RID: 8501
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002136 RID: 8502
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04002137 RID: 8503
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002138 RID: 8504
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Private_Void_NetworkConnection_Vector3_Quaternion_0;

		// Token: 0x04002139 RID: 8505
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x0400213A RID: 8506
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400213B RID: 8507
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400213C RID: 8508
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x0400213D RID: 8509
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0;

		// Token: 0x0400213E RID: 8510
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1;

		// Token: 0x0400213F RID: 8511
		private static readonly IntPtr NativeMethodInfoPtr_AimedAtByPlayer_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04002140 RID: 8512
		private static readonly IntPtr NativeMethodInfoPtr_OverrideAggression_Public_Void_Single_0;

		// Token: 0x04002141 RID: 8513
		private static readonly IntPtr NativeMethodInfoPtr_ResetAggression_Public_Void_0;

		// Token: 0x04002142 RID: 8514
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0;

		// Token: 0x04002146 RID: 8518
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Virtual_New_Void_0;

		// Token: 0x04002147 RID: 8519
		private static readonly IntPtr NativeMethodInfoPtr_SendWorldspaceDialogueKey_Public_Void_String_Single_0;

		// Token: 0x04002148 RID: 8520
		private static readonly IntPtr NativeMethodInfoPtr_PlayWorldspaceDialogue_Private_Void_String_Single_0;

		// Token: 0x04002149 RID: 8521
		private static readonly IntPtr NativeMethodInfoPtr_SetConversant_Public_Void_NetworkObject_0;

		// Token: 0x0400214A RID: 8522
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Internal_Private_Void_0;

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Internal_Private_Void_0;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_1;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_1;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_EnterBuilding_Public_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_ExitBuilding_Public_Void_String_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Networked_Return_Public_AvatarEquippable_NetworkConnection_String_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Return_Public_AvatarEquippable_String_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Networked_ExcludeServer_Private_Void_NetworkConnection_String_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_NetworkConnection_String_Vector3_0;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x0400215A RID: 8538
		private static readonly IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0;

		// Token: 0x0400215B RID: 8539
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Networked_Public_Void_Boolean_0;

		// Token: 0x0400215C RID: 8540
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationBool_Networked_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400215D RID: 8541
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0;

		// Token: 0x0400215E RID: 8542
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_New_Boolean_Player_0;

		// Token: 0x0400215F RID: 8543
		private static readonly IntPtr NativeMethodInfoPtr_SetUnsettled_30s_Protected_Virtual_New_Void_Player_0;

		// Token: 0x04002160 RID: 8544
		private static readonly IntPtr NativeMethodInfoPtr_SetUnsettled_Protected_Void_Single_0;

		// Token: 0x04002161 RID: 8545
		private static readonly IntPtr NativeMethodInfoPtr_SetPanicked_Public_Void_0;

		// Token: 0x04002162 RID: 8546
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePanicked_Private_Void_0;

		// Token: 0x04002163 RID: 8547
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanicked_Private_Void_0;

		// Token: 0x04002164 RID: 8548
		private static readonly IntPtr NativeMethodInfoPtr_GetNameAddress_Public_Virtual_New_String_0;

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_PlayVO_Public_Void_EVOLineType_0;

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRelationshipData_Public_Void_NetworkConnection_Single_Boolean_0;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr_SetIsBeingPickPocketed_Public_Void_Boolean_0;

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeMethodInfoPtr_SendRelationship_Public_Void_Single_0;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationship_Private_Void_Single_0;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_Final_New_Void_Color_0;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveRelationshipData_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveMessages_Protected_Virtual_New_Boolean_0;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveInventory_Protected_Virtual_New_Boolean_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveHealth_Protected_Virtual_New_Boolean_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_NPCData_String_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_4260003484_Private_Void_NetworkConnection_Vector3_Quaternion_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTransform_4260003484_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AimedAtByPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AimedAtByPlayer_3323014238_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AimedAtByPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnterVehicle_3321926803_Public_Virtual_New_Void_NetworkConnection_LandVehicle_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnterVehicle_3321926803_Private_Void_NetworkConnection_LandVehicle_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnterVehicle_3321926803_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitVehicle_2166136261_Private_Void_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitVehicle_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitVehicle_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWorldspaceDialogueKey_606697822_Private_Void_String_Single_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWorldspaceDialogueKey_606697822_Public_Void_String_Single_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWorldspaceDialogueKey_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayWorldspaceDialogue_606697822_Private_Void_String_Single_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayWorldspaceDialogue_606697822_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConversant_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConversant_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002196 RID: 8598
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConversant_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002197 RID: 8599
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04002198 RID: 8600
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnterBuilding_3905681115_Public_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04002199 RID: 8601
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400219A RID: 8602
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnterBuilding_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x0400219B RID: 8603
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnterBuilding_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitBuilding_3615296227_Private_Void_String_0;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitBuilding_3615296227_Public_Void_String_0;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitBuilding_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetEquippable_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetEquippable_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_4022222929_Public_Void_NetworkConnection_String_Vector3_0;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_NetworkConnection_String_Vector3_0;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCrouched_Networked_1140765316_Private_Void_Boolean_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCrouched_Networked_1140765316_Public_Void_Boolean_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCrouched_Networked_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationBool_Networked_619441887_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetAnimationBool_Networked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetAnimationBool_Networked_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPanicked_2166136261_Private_Void_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPanicked_2166136261_Public_Void_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPanicked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePanicked_2166136261_Private_Void_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePanicked_2166136261_Private_Void_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePanicked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePanicked_2166136261_Private_Void_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemovePanicked_2166136261_Private_Void_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePanicked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveRelationshipData_4052192084_Private_Void_NetworkConnection_Single_Boolean_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRelationshipData_4052192084_Public_Void_NetworkConnection_Single_Boolean_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveRelationshipData_4052192084_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsBeingPickPocketed_1140765316_Private_Void_Boolean_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsBeingPickPocketed_1140765316_Public_Void_Boolean_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsBeingPickPocketed_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRelationship_431000436_Private_Void_Single_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRelationship_431000436_Public_Void_Single_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRelationship_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRelationship_431000436_Private_Void_Single_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRelationship_431000436_Private_Void_Single_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRelationship_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_PlayerConversant_Public_get_NetworkObject_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_PlayerConversant_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPC_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200091A RID: 2330
		[ObfuscatedName("ScheduleOne.NPCs.NPC+<>c__DisplayClass132_0")]
		public sealed class __c__DisplayClass132_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C622 RID: 50722 RVA: 0x0030239C File Offset: 0x0030059C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass132_0()
			{
				Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<>c__DisplayClass132_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr);
				NPC.__c__DisplayClass132_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, "<>4__this");
				NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, "startScale");
				NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, "scale");
				NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, "lerpTime");
				NPC.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, 100669150);
				NPC.__c__DisplayClass132_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, 100669151);
			}

			// Token: 0x0600C623 RID: 50723 RVA: 0x00302440 File Offset: 0x00300640
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass132_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C624 RID: 50724 RVA: 0x0030247C File Offset: 0x0030067C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131737, XrefRangeEnd = 131742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C625 RID: 50725 RVA: 0x00060712 File Offset: 0x0005E912
			public __c__DisplayClass132_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC0 RID: 15808
			// (get) Token: 0x0600C626 RID: 50726 RVA: 0x003024BC File Offset: 0x003006BC
			// (set) Token: 0x0600C627 RID: 50727 RVA: 0x0006071B File Offset: 0x0005E91B
			public unsafe NPC __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DC1 RID: 15809
			// (get) Token: 0x0600C628 RID: 50728 RVA: 0x003024EC File Offset: 0x003006EC
			// (set) Token: 0x0600C629 RID: 50729 RVA: 0x0006073A File Offset: 0x0005E93A
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17003DC2 RID: 15810
			// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00302514 File Offset: 0x00300714
			// (set) Token: 0x0600C62B RID: 50731 RVA: 0x00060755 File Offset: 0x0005E955
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17003DC3 RID: 15811
			// (get) Token: 0x0600C62C RID: 50732 RVA: 0x0030253C File Offset: 0x0030073C
			// (set) Token: 0x0600C62D RID: 50733 RVA: 0x00060770 File Offset: 0x0005E970
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x04008624 RID: 34340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008625 RID: 34341
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04008626 RID: 34342
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04008627 RID: 34343
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008628 RID: 34344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008629 RID: 34345
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3D RID: 3133
			[ObfuscatedName("ScheduleOne.NPCs.NPC+<>c__DisplayClass132_0+<<SetScale>g__LerpScale|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1F1 RID: 57841 RVA: 0x00351598 File Offset: 0x0034F798
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0>.NativeClassPtr, "<<SetScale>g__LerpScale|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669152);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669153);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669154);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669155);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669156);
					NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100669157);
				}

				// Token: 0x0600E1F2 RID: 57842 RVA: 0x0035168C File Offset: 0x0034F88C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1F3 RID: 57843 RVA: 0x003516D4 File Offset: 0x0034F8D4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1F4 RID: 57844 RVA: 0x00351708 File Offset: 0x0034F908
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131724, XrefRangeEnd = 131732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700460D RID: 17933
				// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x00351744 File Offset: 0x0034F944
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1F6 RID: 57846 RVA: 0x00351784 File Offset: 0x0034F984
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131732, XrefRangeEnd = 131737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700460E RID: 17934
				// (get) Token: 0x0600E1F7 RID: 57847 RVA: 0x003517B8 File Offset: 0x0034F9B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1F8 RID: 57848 RVA: 0x0006E268 File Offset: 0x0006C468
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004609 RID: 17929
				// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x003517F8 File Offset: 0x0034F9F8
				// (set) Token: 0x0600E1FA RID: 57850 RVA: 0x0006E271 File Offset: 0x0006C471
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700460A RID: 17930
				// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x00351820 File Offset: 0x0034FA20
				// (set) Token: 0x0600E1FC RID: 57852 RVA: 0x0006E28C File Offset: 0x0006C48C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700460B RID: 17931
				// (get) Token: 0x0600E1FD RID: 57853 RVA: 0x00351850 File Offset: 0x0034FA50
				// (set) Token: 0x0600E1FE RID: 57854 RVA: 0x0006E2AB File Offset: 0x0006C4AB
				public unsafe NPC.__c__DisplayClass132_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC.__c__DisplayClass132_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700460C RID: 17932
				// (get) Token: 0x0600E1FF RID: 57855 RVA: 0x00351880 File Offset: 0x0034FA80
				// (set) Token: 0x0600E200 RID: 57856 RVA: 0x0006E2CA File Offset: 0x0006C4CA
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass132_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009742 RID: 38722
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009743 RID: 38723
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009744 RID: 38724
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009745 RID: 38725
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009746 RID: 38726
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009747 RID: 38727
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009748 RID: 38728
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009749 RID: 38729
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400974A RID: 38730
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400974B RID: 38731
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200091B RID: 2331
		[ObfuscatedName("ScheduleOne.NPCs.NPC+<>c__DisplayClass167_0")]
		public sealed class __c__DisplayClass167_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C62E RID: 50734 RVA: 0x00302564 File Offset: 0x00300764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass167_0()
			{
				Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<>c__DisplayClass167_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr);
				NPC.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr, "<>4__this");
				NPC.__c__DisplayClass167_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr, "duration");
				NPC.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr, 100669158);
				NPC.__c__DisplayClass167_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr, 100669159);
			}

			// Token: 0x0600C62F RID: 50735 RVA: 0x003025E0 File Offset: 0x003007E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass167_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C630 RID: 50736 RVA: 0x0030261C File Offset: 0x0030081C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131765, XrefRangeEnd = 131770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C631 RID: 50737 RVA: 0x0006078B File Offset: 0x0005E98B
			public __c__DisplayClass167_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC4 RID: 15812
			// (get) Token: 0x0600C632 RID: 50738 RVA: 0x0030265C File Offset: 0x0030085C
			// (set) Token: 0x0600C633 RID: 50739 RVA: 0x00060794 File Offset: 0x0005E994
			public unsafe NPC __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DC5 RID: 15813
			// (get) Token: 0x0600C634 RID: 50740 RVA: 0x0030268C File Offset: 0x0030088C
			// (set) Token: 0x0600C635 RID: 50741 RVA: 0x000607B3 File Offset: 0x0005E9B3
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x0400862A RID: 34346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400862B RID: 34347
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400862C RID: 34348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400862D RID: 34349
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3E RID: 3134
			[ObfuscatedName("ScheduleOne.NPCs.NPC+<>c__DisplayClass167_0+<<SetUnsettled>g__ResetUnsettled|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E201 RID: 57857 RVA: 0x003518A8 File Offset: 0x0034FAA8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0>.NativeClassPtr, "<<SetUnsettled>g__ResetUnsettled|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669160);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669161);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669162);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669163);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669164);
					NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100669165);
				}

				// Token: 0x0600E202 RID: 57858 RVA: 0x00351988 File Offset: 0x0034FB88
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E203 RID: 57859 RVA: 0x003519D0 File Offset: 0x0034FBD0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E204 RID: 57860 RVA: 0x00351A04 File Offset: 0x0034FC04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131742, XrefRangeEnd = 131760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004612 RID: 17938
				// (get) Token: 0x0600E205 RID: 57861 RVA: 0x00351A40 File Offset: 0x0034FC40
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E206 RID: 57862 RVA: 0x00351A80 File Offset: 0x0034FC80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131760, XrefRangeEnd = 131765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004613 RID: 17939
				// (get) Token: 0x0600E207 RID: 57863 RVA: 0x00351AB4 File Offset: 0x0034FCB4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E208 RID: 57864 RVA: 0x0006E2E5 File Offset: 0x0006C4E5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700460F RID: 17935
				// (get) Token: 0x0600E209 RID: 57865 RVA: 0x00351AF4 File Offset: 0x0034FCF4
				// (set) Token: 0x0600E20A RID: 57866 RVA: 0x0006E2EE File Offset: 0x0006C4EE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004610 RID: 17936
				// (get) Token: 0x0600E20B RID: 57867 RVA: 0x00351B1C File Offset: 0x0034FD1C
				// (set) Token: 0x0600E20C RID: 57868 RVA: 0x0006E309 File Offset: 0x0006C509
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004611 RID: 17937
				// (get) Token: 0x0600E20D RID: 57869 RVA: 0x00351B4C File Offset: 0x0034FD4C
				// (set) Token: 0x0600E20E RID: 57870 RVA: 0x0006E328 File Offset: 0x0006C528
				public unsafe NPC.__c__DisplayClass167_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC.__c__DisplayClass167_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.__c__DisplayClass167_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400974C RID: 38732
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400974D RID: 38733
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400974E RID: 38734
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400974F RID: 38735
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009750 RID: 38736
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009751 RID: 38737
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009752 RID: 38738
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009753 RID: 38739
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009754 RID: 38740
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
