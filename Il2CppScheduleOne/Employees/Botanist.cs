using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000404 RID: 1028
	public class Botanist : Employee
	{
		// Token: 0x06005686 RID: 22150 RVA: 0x0019463C File Offset: 0x0019283C
		// Note: this type is marked as 'beforefieldinit'.
		static Botanist()
		{
			Il2CppClassPointerStore<Botanist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Botanist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist>.NativeClassPtr);
			Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "CRITICAL_WATERING_THRESHOLD");
			Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WATERING_THRESHOLD");
			Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "TARGET_WATER_LEVEL_MIN");
			Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "TARGET_WATER_LEVEL_MAX");
			Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SOIL_POUR_TIME");
			Botanist.NativeFieldInfoPtr_WATER_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WATER_POUR_TIME");
			Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "ADDITIVE_POUR_TIME");
			Botanist.NativeFieldInfoPtr_SEED_SOW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SEED_SOW_TIME");
			Botanist.NativeFieldInfoPtr_HARVEST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "HARVEST_TIME");
			Botanist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "typeIcon");
			Botanist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "configReplicator");
			Botanist.NativeFieldInfoPtr_PotActionBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "PotActionBehaviour");
			Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "StartDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "StopDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WorldspaceUIPrefab");
			Botanist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "uiPoint");
			Botanist.NativeFieldInfoPtr_MaxAssignedPots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MaxAssignedPots");
			Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoAssignedStationsDialogue");
			Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "UnspecifiedPotsDialogue");
			Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NullDestinationPotsDialogue");
			Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MissingMaterialsDialogue");
			Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoPotsRequireWorkDialogue");
			Botanist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<configuration>k__BackingField");
			Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674153);
			Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674154);
			Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674155);
			Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674156);
			Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674157);
			Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674158);
			Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674159);
			Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674160);
			Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674161);
			Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674162);
			Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674163);
			Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674164);
			Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674165);
			Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674166);
			Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674167);
			Botanist.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674168);
			Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674169);
			Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674170);
			Botanist.NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674171);
			Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674172);
			Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674173);
			Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674174);
			Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674175);
			Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674176);
			Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674177);
			Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674178);
			Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674179);
			Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674180);
			Botanist.NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674181);
			Botanist.NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674182);
			Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674183);
			Botanist.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674184);
			Botanist.NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674185);
			Botanist.NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674186);
			Botanist.NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674187);
			Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674188);
			Botanist.NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674189);
			Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674190);
			Botanist.NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674191);
			Botanist.NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674192);
			Botanist.NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674193);
			Botanist.NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674194);
			Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674195);
			Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674196);
			Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674197);
			Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674198);
			Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674199);
			Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674200);
			Botanist.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674201);
			Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674202);
			Botanist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674203);
			Botanist.NativeMethodInfoPtr__GetAccessableEntities_b__75_0_Private_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674204);
			Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674205);
			Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674206);
			Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674207);
			Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674208);
			Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674209);
			Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674210);
			Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674211);
			Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674212);
			Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674213);
			Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674214);
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06005687 RID: 22151 RVA: 0x00194D74 File Offset: 0x00192F74
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 183303, RefRangeEnd = 183314, XrefRangeStart = 183303, XrefRangeEnd = 183303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x00194DB4 File Offset: 0x00192FB4
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x00194DF4 File Offset: 0x00192FF4
		public unsafe BotanistConfiguration configuration
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 183303, RefRangeEnd = 183314, XrefRangeStart = 183303, XrefRangeEnd = 183314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183314, XrefRangeEnd = 183315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x00194E38 File Offset: 0x00193038
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x00194E78 File Offset: 0x00193078
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 120991, RefRangeEnd = 120996, XrefRangeStart = 120991, XrefRangeEnd = 120996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x00194EB4 File Offset: 0x001930B4
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x00194EF4 File Offset: 0x001930F4
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183315, XrefRangeEnd = 183316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x00194F38 File Offset: 0x00193138
		// (set) Token: 0x0600568F RID: 22159 RVA: 0x00194F78 File Offset: 0x00193178
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 183324, RefRangeEnd = 183326, XrefRangeStart = 183316, XrefRangeEnd = 183324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x00194FBC File Offset: 0x001931BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183326, XrefRangeEnd = 183348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06005691 RID: 22161 RVA: 0x00195000 File Offset: 0x00193200
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00195040 File Offset: 0x00193240
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06005693 RID: 22163 RVA: 0x00195080 File Offset: 0x00193280
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x001950C0 File Offset: 0x001932C0
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06005695 RID: 22165 RVA: 0x001950FC File Offset: 0x001932FC
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x0019513C File Offset: 0x0019333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183351, XrefRangeEnd = 183352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x00195178 File Offset: 0x00193378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183352, XrefRangeEnd = 183398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x001951B4 File Offset: 0x001933B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183406, RefRangeEnd = 183409, XrefRangeStart = 183398, XrefRangeEnd = 183406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEntityAccessible(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x00195204 File Offset: 0x00193404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183411, RefRangeEnd = 183412, XrefRangeStart = 183409, XrefRangeEnd = 183411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x00195254 File Offset: 0x00193454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183412, XrefRangeEnd = 183415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00195298 File Offset: 0x00193498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183415, XrefRangeEnd = 183418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x001952DC File Offset: 0x001934DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183418, XrefRangeEnd = 183436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x0019532C File Offset: 0x0019352C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183436, XrefRangeEnd = 183453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00195370 File Offset: 0x00193570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183453, XrefRangeEnd = 183462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x001953C0 File Offset: 0x001935C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183462, XrefRangeEnd = 183473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x001953FC File Offset: 0x001935FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183473, XrefRangeEnd = 183496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &moveQuantity;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dryable = ((intPtr5 == 0) ? null : new QualityItemInstance(intPtr5));
			IntPtr intPtr6 = intPtr2;
			destinationRack = ((intPtr6 == 0) ? null : new DryingRack(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x0019548C File Offset: 0x0019368C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183535, RefRangeEnd = 183536, XrefRangeStart = 183496, XrefRangeEnd = 183535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetDryableInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x001954CC File Offset: 0x001936CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183552, RefRangeEnd = 183553, XrefRangeStart = 183536, XrefRangeEnd = 183552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dryable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rackInputCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x0019552C File Offset: 0x0019372C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 183591, RefRangeEnd = 183595, XrefRangeStart = 183553, XrefRangeEnd = 183591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemInSupplies(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x0019557C File Offset: 0x0019377C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183633, RefRangeEnd = 183634, XrefRangeStart = 183595, XrefRangeEnd = 183633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSeedInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x001955BC File Offset: 0x001937BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183634, XrefRangeEnd = 183635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00195604 File Offset: 0x00193804
		[CallerCount(0)]
		public unsafe override BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00195650 File Offset: 0x00193850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183635, XrefRangeEnd = 183647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreThereUnspecifiedPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x0019568C File Offset: 0x0019388C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183647, XrefRangeEnd = 183665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreThereNullDestinationPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x001956C8 File Offset: 0x001938C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183665, XrefRangeEnd = 183678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMissingRequiredMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00195704 File Offset: 0x00193904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183698, RefRangeEnd = 183699, XrefRangeStart = 183678, XrefRangeEnd = 183698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeFullyGrowm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00195760 File Offset: 0x00193960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183710, RefRangeEnd = 183711, XrefRangeStart = 183699, XrefRangeEnd = 183710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForSoilSour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x001957A0 File Offset: 0x001939A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183728, RefRangeEnd = 183729, XrefRangeStart = 183711, XrefRangeEnd = 183728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsReadyForSeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x001957E0 File Offset: 0x001939E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183729, XrefRangeEnd = 183747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAccessableEntity<T>(T entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = entity;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref entity;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric_GetAccessableEntity_Private_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x00195878 File Offset: 0x00193A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183747, XrefRangeEnd = 183750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetAccessableEntities<T>(List<T> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric_GetAccessableEntities_Private_List_1_T_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x001958C8 File Offset: 0x00193AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183750, XrefRangeEnd = 183780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> FilterPotsForSpecifiedSeed(List<Pot> pots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00195918 File Offset: 0x00193B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183780, XrefRangeEnd = 183791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForAdditives(out int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &additiveNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00195964 File Offset: 0x00193B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183791, XrefRangeEnd = 183808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsForHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x001959A4 File Offset: 0x00193BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183808, XrefRangeEnd = 183825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x001959E4 File Offset: 0x00193BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183825, XrefRangeEnd = 183842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00195A24 File Offset: 0x00193C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183842, XrefRangeEnd = 183865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00195A64 File Offset: 0x00193C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183892, RefRangeEnd = 183893, XrefRangeStart = 183865, XrefRangeEnd = 183892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00195AA4 File Offset: 0x00193CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183893, XrefRangeEnd = 183897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00195AD8 File Offset: 0x00193CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183897, XrefRangeEnd = 183907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x00195B1C File Offset: 0x00193D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183907, XrefRangeEnd = 183929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00195B78 File Offset: 0x00193D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183929, XrefRangeEnd = 183930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Botanist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00195BB4 File Offset: 0x00193DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183930, XrefRangeEnd = 183942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetAccessableEntities_b__75_0<T>(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric__GetAccessableEntities_b__75_0_Private_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00195C4C File Offset: 0x00193E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183942, XrefRangeEnd = 183966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00195C88 File Offset: 0x00193E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183966, XrefRangeEnd = 183967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00195CC4 File Offset: 0x00193EC4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00195D00 File Offset: 0x00193F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183967, XrefRangeEnd = 183986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00195D44 File Offset: 0x00193F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183324, RefRangeEnd = 183326, XrefRangeStart = 183324, XrefRangeEnd = 183326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00195D88 File Offset: 0x00193F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183986, XrefRangeEnd = 183990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060056C1 RID: 22209 RVA: 0x00195DEC File Offset: 0x00193FEC
		// (set) Token: 0x060056C2 RID: 22210 RVA: 0x00195E2C File Offset: 0x0019402C
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 183999, RefRangeEnd = 184000, XrefRangeStart = 183990, XrefRangeEnd = 183999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00195E7C File Offset: 0x0019407C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184000, XrefRangeEnd = 184004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00195EF0 File Offset: 0x001940F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184004, XrefRangeEnd = 184005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x000294AF File Offset: 0x000276AF
		public Botanist(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x00195F2C File Offset: 0x0019412C
		// (set) Token: 0x060056C7 RID: 22215 RVA: 0x000294B8 File Offset: 0x000276B8
		public unsafe float CRITICAL_WATERING_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD)) = value;
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060056C8 RID: 22216 RVA: 0x00195F54 File Offset: 0x00194154
		// (set) Token: 0x060056C9 RID: 22217 RVA: 0x000294D3 File Offset: 0x000276D3
		public unsafe float WATERING_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD)) = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060056CA RID: 22218 RVA: 0x00195F7C File Offset: 0x0019417C
		// (set) Token: 0x060056CB RID: 22219 RVA: 0x000294EE File Offset: 0x000276EE
		public unsafe float TARGET_WATER_LEVEL_MIN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN)) = value;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060056CC RID: 22220 RVA: 0x00195FA4 File Offset: 0x001941A4
		// (set) Token: 0x060056CD RID: 22221 RVA: 0x00029509 File Offset: 0x00027709
		public unsafe float TARGET_WATER_LEVEL_MAX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX)) = value;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060056CE RID: 22222 RVA: 0x00195FCC File Offset: 0x001941CC
		// (set) Token: 0x060056CF RID: 22223 RVA: 0x00029524 File Offset: 0x00027724
		public unsafe float SOIL_POUR_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060056D0 RID: 22224 RVA: 0x00195FF4 File Offset: 0x001941F4
		// (set) Token: 0x060056D1 RID: 22225 RVA: 0x0002953F File Offset: 0x0002773F
		public unsafe float WATER_POUR_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATER_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATER_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060056D2 RID: 22226 RVA: 0x0019601C File Offset: 0x0019421C
		// (set) Token: 0x060056D3 RID: 22227 RVA: 0x0002955A File Offset: 0x0002775A
		public unsafe float ADDITIVE_POUR_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060056D4 RID: 22228 RVA: 0x00196044 File Offset: 0x00194244
		// (set) Token: 0x060056D5 RID: 22229 RVA: 0x00029575 File Offset: 0x00027775
		public unsafe float SEED_SOW_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SEED_SOW_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SEED_SOW_TIME)) = value;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060056D6 RID: 22230 RVA: 0x0019606C File Offset: 0x0019426C
		// (set) Token: 0x060056D7 RID: 22231 RVA: 0x00029590 File Offset: 0x00027790
		public unsafe float HARVEST_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_HARVEST_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_HARVEST_TIME)) = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060056D8 RID: 22232 RVA: 0x00196094 File Offset: 0x00194294
		// (set) Token: 0x060056D9 RID: 22233 RVA: 0x000295AB File Offset: 0x000277AB
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060056DA RID: 22234 RVA: 0x001960C4 File Offset: 0x001942C4
		// (set) Token: 0x060056DB RID: 22235 RVA: 0x000295CA File Offset: 0x000277CA
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060056DC RID: 22236 RVA: 0x001960F4 File Offset: 0x001942F4
		// (set) Token: 0x060056DD RID: 22237 RVA: 0x000295E9 File Offset: 0x000277E9
		public unsafe PotActionBehaviour PotActionBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_PotActionBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_PotActionBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x00196124 File Offset: 0x00194324
		// (set) Token: 0x060056DF RID: 22239 RVA: 0x00029608 File Offset: 0x00027808
		public unsafe StartDryingRackBehaviour StartDryingRackBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x00196154 File Offset: 0x00194354
		// (set) Token: 0x060056E1 RID: 22241 RVA: 0x00029627 File Offset: 0x00027827
		public unsafe StopDryingRackBehaviour StopDryingRackBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x00196184 File Offset: 0x00194384
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x00029646 File Offset: 0x00027846
		public unsafe BotanistUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060056E4 RID: 22244 RVA: 0x001961B4 File Offset: 0x001943B4
		// (set) Token: 0x060056E5 RID: 22245 RVA: 0x00029665 File Offset: 0x00027865
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x001961E4 File Offset: 0x001943E4
		// (set) Token: 0x060056E7 RID: 22247 RVA: 0x00029684 File Offset: 0x00027884
		public unsafe int MaxAssignedPots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots)) = value;
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x060056E8 RID: 22248 RVA: 0x0019620C File Offset: 0x0019440C
		// (set) Token: 0x060056E9 RID: 22249 RVA: 0x0002969F File Offset: 0x0002789F
		public unsafe DialogueContainer NoAssignedStationsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x060056EA RID: 22250 RVA: 0x0019623C File Offset: 0x0019443C
		// (set) Token: 0x060056EB RID: 22251 RVA: 0x000296BE File Offset: 0x000278BE
		public unsafe DialogueContainer UnspecifiedPotsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x0019626C File Offset: 0x0019446C
		// (set) Token: 0x060056ED RID: 22253 RVA: 0x000296DD File Offset: 0x000278DD
		public unsafe DialogueContainer NullDestinationPotsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x060056EE RID: 22254 RVA: 0x0019629C File Offset: 0x0019449C
		// (set) Token: 0x060056EF RID: 22255 RVA: 0x000296FC File Offset: 0x000278FC
		public unsafe DialogueContainer MissingMaterialsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x060056F0 RID: 22256 RVA: 0x001962CC File Offset: 0x001944CC
		// (set) Token: 0x060056F1 RID: 22257 RVA: 0x0002971B File Offset: 0x0002791B
		public unsafe DialogueContainer NoPotsRequireWorkDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x001962FC File Offset: 0x001944FC
		// (set) Token: 0x060056F3 RID: 22259 RVA: 0x0002973A File Offset: 0x0002793A
		public unsafe BotanistConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x0019632C File Offset: 0x0019452C
		// (set) Token: 0x060056F5 RID: 22261 RVA: 0x00029759 File Offset: 0x00027959
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x060056F6 RID: 22262 RVA: 0x0019635C File Offset: 0x0019455C
		// (set) Token: 0x060056F7 RID: 22263 RVA: 0x00029778 File Offset: 0x00027978
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x060056F8 RID: 22264 RVA: 0x0019638C File Offset: 0x0019458C
		// (set) Token: 0x060056F9 RID: 22265 RVA: 0x00029797 File Offset: 0x00027997
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x001963BC File Offset: 0x001945BC
		// (set) Token: 0x060056FB RID: 22267 RVA: 0x000297B6 File Offset: 0x000279B6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x001963E4 File Offset: 0x001945E4
		// (set) Token: 0x060056FD RID: 22269 RVA: 0x000297D1 File Offset: 0x000279D1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003ABA RID: 15034
		private static readonly IntPtr NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD;

		// Token: 0x04003ABB RID: 15035
		private static readonly IntPtr NativeFieldInfoPtr_WATERING_THRESHOLD;

		// Token: 0x04003ABC RID: 15036
		private static readonly IntPtr NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN;

		// Token: 0x04003ABD RID: 15037
		private static readonly IntPtr NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX;

		// Token: 0x04003ABE RID: 15038
		private static readonly IntPtr NativeFieldInfoPtr_SOIL_POUR_TIME;

		// Token: 0x04003ABF RID: 15039
		private static readonly IntPtr NativeFieldInfoPtr_WATER_POUR_TIME;

		// Token: 0x04003AC0 RID: 15040
		private static readonly IntPtr NativeFieldInfoPtr_ADDITIVE_POUR_TIME;

		// Token: 0x04003AC1 RID: 15041
		private static readonly IntPtr NativeFieldInfoPtr_SEED_SOW_TIME;

		// Token: 0x04003AC2 RID: 15042
		private static readonly IntPtr NativeFieldInfoPtr_HARVEST_TIME;

		// Token: 0x04003AC3 RID: 15043
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003AC4 RID: 15044
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003AC5 RID: 15045
		private static readonly IntPtr NativeFieldInfoPtr_PotActionBehaviour;

		// Token: 0x04003AC6 RID: 15046
		private static readonly IntPtr NativeFieldInfoPtr_StartDryingRackBehaviour;

		// Token: 0x04003AC7 RID: 15047
		private static readonly IntPtr NativeFieldInfoPtr_StopDryingRackBehaviour;

		// Token: 0x04003AC8 RID: 15048
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003AC9 RID: 15049
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003ACA RID: 15050
		private static readonly IntPtr NativeFieldInfoPtr_MaxAssignedPots;

		// Token: 0x04003ACB RID: 15051
		private static readonly IntPtr NativeFieldInfoPtr_NoAssignedStationsDialogue;

		// Token: 0x04003ACC RID: 15052
		private static readonly IntPtr NativeFieldInfoPtr_UnspecifiedPotsDialogue;

		// Token: 0x04003ACD RID: 15053
		private static readonly IntPtr NativeFieldInfoPtr_NullDestinationPotsDialogue;

		// Token: 0x04003ACE RID: 15054
		private static readonly IntPtr NativeFieldInfoPtr_MissingMaterialsDialogue;

		// Token: 0x04003ACF RID: 15055
		private static readonly IntPtr NativeFieldInfoPtr_NoPotsRequireWorkDialogue;

		// Token: 0x04003AD0 RID: 15056
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003AD1 RID: 15057
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003AD2 RID: 15058
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003AD3 RID: 15059
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003AD4 RID: 15060
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003AD5 RID: 15061
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003AD6 RID: 15062
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0;

		// Token: 0x04003AD8 RID: 15064
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0;

		// Token: 0x04003AD9 RID: 15065
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003ADA RID: 15066
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003ADB RID: 15067
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003ADC RID: 15068
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003ADD RID: 15069
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003ADE RID: 15070
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003ADF RID: 15071
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003AE0 RID: 15072
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003AE1 RID: 15073
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003AE2 RID: 15074
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003AE3 RID: 15075
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003AE4 RID: 15076
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003AE5 RID: 15077
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003AE6 RID: 15078
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003AE7 RID: 15079
		private static readonly IntPtr NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0;

		// Token: 0x04003AE8 RID: 15080
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0;

		// Token: 0x04003AE9 RID: 15081
		private static readonly IntPtr NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0;

		// Token: 0x04003AEA RID: 15082
		private static readonly IntPtr NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0;

		// Token: 0x04003AEB RID: 15083
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003AEC RID: 15084
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003AED RID: 15085
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0;

		// Token: 0x04003AEE RID: 15086
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003AEF RID: 15087
		private static readonly IntPtr NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0;

		// Token: 0x04003AF0 RID: 15088
		private static readonly IntPtr NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0;

		// Token: 0x04003AF1 RID: 15089
		private static readonly IntPtr NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0;

		// Token: 0x04003AF2 RID: 15090
		private static readonly IntPtr NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0;

		// Token: 0x04003AF3 RID: 15091
		private static readonly IntPtr NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0;

		// Token: 0x04003AF4 RID: 15092
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003AF5 RID: 15093
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0;

		// Token: 0x04003AF6 RID: 15094
		private static readonly IntPtr NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0;

		// Token: 0x04003AF7 RID: 15095
		private static readonly IntPtr NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0;

		// Token: 0x04003AF8 RID: 15096
		private static readonly IntPtr NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0;

		// Token: 0x04003AF9 RID: 15097
		private static readonly IntPtr NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0;

		// Token: 0x04003AFA RID: 15098
		private static readonly IntPtr NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0;

		// Token: 0x04003AFB RID: 15099
		private static readonly IntPtr NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0;

		// Token: 0x04003AFC RID: 15100
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0;

		// Token: 0x04003AFD RID: 15101
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0;

		// Token: 0x04003AFE RID: 15102
		private static readonly IntPtr NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0;

		// Token: 0x04003AFF RID: 15103
		private static readonly IntPtr NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0;

		// Token: 0x04003B00 RID: 15104
		private static readonly IntPtr NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0;

		// Token: 0x04003B01 RID: 15105
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0;

		// Token: 0x04003B02 RID: 15106
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0;

		// Token: 0x04003B03 RID: 15107
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0;

		// Token: 0x04003B04 RID: 15108
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003B05 RID: 15109
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr__GetAccessableEntities_b__75_0_Private_Boolean_T_0;

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009C8 RID: 2504
		[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC89 RID: 52361 RVA: 0x003151EC File Offset: 0x003133EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr);
				Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
				Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "conn");
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674215);
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674216);
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674217);
			}

			// Token: 0x0600CC8A RID: 52362 RVA: 0x0031527C File Offset: 0x0031347C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC8B RID: 52363 RVA: 0x003152B8 File Offset: 0x003134B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183298, XrefRangeEnd = 183303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CC8C RID: 52364 RVA: 0x003152F8 File Offset: 0x003134F8
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC8D RID: 52365 RVA: 0x00063787 File Offset: 0x00061987
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FBA RID: 16314
			// (get) Token: 0x0600CC8E RID: 52366 RVA: 0x00315334 File Offset: 0x00313534
			// (set) Token: 0x0600CC8F RID: 52367 RVA: 0x00063790 File Offset: 0x00061990
			public unsafe Botanist __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBB RID: 16315
			// (get) Token: 0x0600CC90 RID: 52368 RVA: 0x00315364 File Offset: 0x00313564
			// (set) Token: 0x0600CC91 RID: 52369 RVA: 0x000637AF File Offset: 0x000619AF
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A4D RID: 35405
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A4E RID: 35406
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008A4F RID: 35407
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A50 RID: 35408
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A51 RID: 35409
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C4A RID: 3146
			[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass58_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2C3 RID: 58051 RVA: 0x00353DB4 File Offset: 0x00351FB4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674218);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674219);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674220);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674221);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674222);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674223);
				}

				// Token: 0x0600E2C4 RID: 58052 RVA: 0x00353E94 File Offset: 0x00352094
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2C5 RID: 58053 RVA: 0x00353EDC File Offset: 0x003520DC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2C6 RID: 58054 RVA: 0x00353F10 File Offset: 0x00352110
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183282, XrefRangeEnd = 183293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700465B RID: 18011
				// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x00353F4C File Offset: 0x0035214C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2C8 RID: 58056 RVA: 0x00353F8C File Offset: 0x0035218C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183293, XrefRangeEnd = 183298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700465C RID: 18012
				// (get) Token: 0x0600E2C9 RID: 58057 RVA: 0x00353FC0 File Offset: 0x003521C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2CA RID: 58058 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004658 RID: 18008
				// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x00354000 File Offset: 0x00352200
				// (set) Token: 0x0600E2CC RID: 58060 RVA: 0x0006E8ED File Offset: 0x0006CAED
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004659 RID: 18009
				// (get) Token: 0x0600E2CD RID: 58061 RVA: 0x00354028 File Offset: 0x00352228
				// (set) Token: 0x0600E2CE RID: 58062 RVA: 0x0006E908 File Offset: 0x0006CB08
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700465A RID: 18010
				// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x00354058 File Offset: 0x00352258
				// (set) Token: 0x0600E2D0 RID: 58064 RVA: 0x0006E927 File Offset: 0x0006CB27
				public unsafe Botanist.__c__DisplayClass58_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist.__c__DisplayClass58_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097C5 RID: 38853
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097C6 RID: 38854
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097C7 RID: 38855
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097C8 RID: 38856
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097C9 RID: 38857
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097CA RID: 38858
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097CB RID: 38859
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097CC RID: 38860
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097CD RID: 38861
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009C9 RID: 2505
		private sealed class MethodInfoStoreGeneric_GetAccessableEntity_Private_T_T_0<T>
		{
			// Token: 0x04008A52 RID: 35410
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009CA RID: 2506
		private sealed class MethodInfoStoreGeneric_GetAccessableEntities_Private_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04008A53 RID: 35411
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009CB RID: 2507
		private sealed class MethodInfoStoreGeneric__GetAccessableEntities_b__75_0_Private_Boolean_T_0<T>
		{
			// Token: 0x04008A54 RID: 35412
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr__GetAccessableEntities_b__75_0_Private_Boolean_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
