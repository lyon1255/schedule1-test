using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000405 RID: 1029
	public class Chemist : Employee
	{
		// Token: 0x060056FE RID: 22270 RVA: 0x0019640C File Offset: 0x0019460C
		// Note: this type is marked as 'beforefieldinit'.
		static Chemist()
		{
			Il2CppClassPointerStore<Chemist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Chemist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist>.NativeClassPtr);
			Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "MAX_ASSIGNED_STATIONS");
			Chemist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "typeIcon");
			Chemist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "configReplicator");
			Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartChemistryStationBehaviour");
			Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "FinishLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_StartCauldronBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartCauldronBehaviour");
			Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartMixingStationBehaviour");
			Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "WorldspaceUIPrefab");
			Chemist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "uiPoint");
			Chemist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<configuration>k__BackingField");
			Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674224);
			Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674225);
			Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674226);
			Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674227);
			Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674228);
			Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674229);
			Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674230);
			Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674231);
			Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674232);
			Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674233);
			Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674234);
			Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674235);
			Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674236);
			Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674237);
			Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674238);
			Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674239);
			Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674240);
			Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674241);
			Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674242);
			Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674243);
			Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674244);
			Chemist.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674245);
			Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674246);
			Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674247);
			Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674248);
			Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674249);
			Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674250);
			Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674251);
			Chemist.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674252);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674253);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674254);
			Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674255);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674256);
			Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674257);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674258);
			Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674259);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674260);
			Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674261);
			Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674262);
			Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674263);
			Chemist.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674264);
			Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674265);
			Chemist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674266);
			Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674267);
			Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674268);
			Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674269);
			Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674270);
			Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674271);
			Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674272);
			Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674273);
			Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674274);
			Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674275);
			Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674276);
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x001969A0 File Offset: 0x00194BA0
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x001969E0 File Offset: 0x00194BE0
		// (set) Token: 0x06005701 RID: 22273 RVA: 0x00196A20 File Offset: 0x00194C20
		public unsafe ChemistConfiguration configuration
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184030, XrefRangeEnd = 184031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x00196A64 File Offset: 0x00194C64
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x00196AA4 File Offset: 0x00194CA4
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x00196AE0 File Offset: 0x00194CE0
		// (set) Token: 0x06005705 RID: 22277 RVA: 0x00196B20 File Offset: 0x00194D20
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94041, RefRangeEnd = 94045, XrefRangeStart = 94041, XrefRangeEnd = 94045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184031, XrefRangeEnd = 184032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x00196B64 File Offset: 0x00194D64
		// (set) Token: 0x06005707 RID: 22279 RVA: 0x00196BA4 File Offset: 0x00194DA4
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184040, RefRangeEnd = 184042, XrefRangeStart = 184032, XrefRangeEnd = 184040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00196BE8 File Offset: 0x00194DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184042, XrefRangeEnd = 184064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06005709 RID: 22281 RVA: 0x00196C2C File Offset: 0x00194E2C
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x00196C6C File Offset: 0x00194E6C
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x00196CAC File Offset: 0x00194EAC
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x00196CEC File Offset: 0x00194EEC
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x00196D28 File Offset: 0x00194F28
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x00196D68 File Offset: 0x00194F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184064, XrefRangeEnd = 184073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00196DB8 File Offset: 0x00194FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184073, XrefRangeEnd = 184084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00196DF4 File Offset: 0x00194FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184084, XrefRangeEnd = 184102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00196E44 File Offset: 0x00195044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184102, XrefRangeEnd = 184119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00196E88 File Offset: 0x00195088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184119, XrefRangeEnd = 184127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00196EC4 File Offset: 0x001950C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184182, RefRangeEnd = 184183, XrefRangeStart = 184127, XrefRangeEnd = 184182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartNewTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00196EF8 File Offset: 0x001950F8
		[CallerCount(0)]
		public unsafe bool AnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00196F34 File Offset: 0x00195134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184183, XrefRangeEnd = 184184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00196F7C File Offset: 0x0019517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184184, XrefRangeEnd = 184187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartChemistryStation(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00196FC0 File Offset: 0x001951C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184187, XrefRangeEnd = 184190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCauldron(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x00197004 File Offset: 0x00195204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184190, XrefRangeEnd = 184193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00197048 File Offset: 0x00195248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184193, XrefRangeEnd = 184196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0019708C File Offset: 0x0019528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184196, XrefRangeEnd = 184199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixingStation(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x001970D0 File Offset: 0x001952D0
		[CallerCount(0)]
		public unsafe override BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x0019711C File Offset: 0x0019531C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184228, RefRangeEnd = 184229, XrefRangeStart = 184199, XrefRangeEnd = 184228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0019715C File Offset: 0x0019535C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184257, RefRangeEnd = 184258, XrefRangeStart = 184229, XrefRangeEnd = 184257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x0019719C File Offset: 0x0019539C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184293, RefRangeEnd = 184294, XrefRangeStart = 184258, XrefRangeEnd = 184293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr3) : null;
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x001971DC File Offset: 0x001953DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184322, RefRangeEnd = 184323, XrefRangeStart = 184294, XrefRangeEnd = 184322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr3) : null;
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x0019721C File Offset: 0x0019541C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184355, RefRangeEnd = 184356, XrefRangeStart = 184323, XrefRangeEnd = 184355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixingStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr3) : null;
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x0019725C File Offset: 0x0019545C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184384, RefRangeEnd = 184385, XrefRangeStart = 184356, XrefRangeEnd = 184384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x0019729C File Offset: 0x0019549C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184413, RefRangeEnd = 184414, XrefRangeStart = 184385, XrefRangeEnd = 184413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr3) : null;
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x001972DC File Offset: 0x001954DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184442, RefRangeEnd = 184443, XrefRangeStart = 184414, XrefRangeEnd = 184442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr3) : null;
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x0019731C File Offset: 0x0019551C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184471, RefRangeEnd = 184472, XrefRangeStart = 184443, XrefRangeEnd = 184471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr3) : null;
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x0019735C File Offset: 0x0019555C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184499, RefRangeEnd = 184500, XrefRangeStart = 184472, XrefRangeEnd = 184499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0019739C File Offset: 0x0019559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184500, XrefRangeEnd = 184504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x001973D0 File Offset: 0x001955D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184504, XrefRangeEnd = 184514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00197414 File Offset: 0x00195614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184514, XrefRangeEnd = 184536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00197470 File Offset: 0x00195670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184536, XrefRangeEnd = 184537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chemist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x001974AC File Offset: 0x001956AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184537, XrefRangeEnd = 184561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x001974E8 File Offset: 0x001956E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184561, XrefRangeEnd = 184562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00197524 File Offset: 0x00195724
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00197560 File Offset: 0x00195760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184562, XrefRangeEnd = 184581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x001975A4 File Offset: 0x001957A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184040, RefRangeEnd = 184042, XrefRangeStart = 184040, XrefRangeEnd = 184042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x001975E8 File Offset: 0x001957E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184581, XrefRangeEnd = 184585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06005730 RID: 22320 RVA: 0x0019764C File Offset: 0x0019584C
		// (set) Token: 0x06005731 RID: 22321 RVA: 0x0019768C File Offset: 0x0019588C
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 184594, RefRangeEnd = 184595, XrefRangeStart = 184585, XrefRangeEnd = 184594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x001976DC File Offset: 0x001958DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184595, XrefRangeEnd = 184599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x00197750 File Offset: 0x00195950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x000297EC File Offset: 0x000279EC
		public Chemist(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x0019778C File Offset: 0x0019598C
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x000297F5 File Offset: 0x000279F5
		public unsafe static int MAX_ASSIGNED_STATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&value));
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x001977A8 File Offset: 0x001959A8
		// (set) Token: 0x06005738 RID: 22328 RVA: 0x00029803 File Offset: 0x00027A03
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x001977D8 File Offset: 0x001959D8
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x00029822 File Offset: 0x00027A22
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x00197808 File Offset: 0x00195A08
		// (set) Token: 0x0600573C RID: 22332 RVA: 0x00029841 File Offset: 0x00027A41
		public unsafe StartChemistryStationBehaviour StartChemistryStationBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartChemistryStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x00197838 File Offset: 0x00195A38
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x00029860 File Offset: 0x00027A60
		public unsafe StartLabOvenBehaviour StartLabOvenBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00197868 File Offset: 0x00195A68
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x0002987F File Offset: 0x00027A7F
		public unsafe FinishLabOvenBehaviour FinishLabOvenBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinishLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x00197898 File Offset: 0x00195A98
		// (set) Token: 0x06005742 RID: 22338 RVA: 0x0002989E File Offset: 0x00027A9E
		public unsafe StartCauldronBehaviour StartCauldronBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartCauldronBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x001978C8 File Offset: 0x00195AC8
		// (set) Token: 0x06005744 RID: 22340 RVA: 0x000298BD File Offset: 0x00027ABD
		public unsafe StartMixingStationBehaviour StartMixingStationBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMixingStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x001978F8 File Offset: 0x00195AF8
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x000298DC File Offset: 0x00027ADC
		public unsafe ChemistUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06005747 RID: 22343 RVA: 0x00197928 File Offset: 0x00195B28
		// (set) Token: 0x06005748 RID: 22344 RVA: 0x000298FB File Offset: 0x00027AFB
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06005749 RID: 22345 RVA: 0x00197958 File Offset: 0x00195B58
		// (set) Token: 0x0600574A RID: 22346 RVA: 0x0002991A File Offset: 0x00027B1A
		public unsafe ChemistConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600574B RID: 22347 RVA: 0x00197988 File Offset: 0x00195B88
		// (set) Token: 0x0600574C RID: 22348 RVA: 0x00029939 File Offset: 0x00027B39
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600574D RID: 22349 RVA: 0x001979B8 File Offset: 0x00195BB8
		// (set) Token: 0x0600574E RID: 22350 RVA: 0x00029958 File Offset: 0x00027B58
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600574F RID: 22351 RVA: 0x001979E8 File Offset: 0x00195BE8
		// (set) Token: 0x06005750 RID: 22352 RVA: 0x00029977 File Offset: 0x00027B77
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06005751 RID: 22353 RVA: 0x00197A18 File Offset: 0x00195C18
		// (set) Token: 0x06005752 RID: 22354 RVA: 0x00029996 File Offset: 0x00027B96
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06005753 RID: 22355 RVA: 0x00197A40 File Offset: 0x00195C40
		// (set) Token: 0x06005754 RID: 22356 RVA: 0x000299B1 File Offset: 0x00027BB1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B14 RID: 15124
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS;

		// Token: 0x04003B15 RID: 15125
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003B16 RID: 15126
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003B17 RID: 15127
		private static readonly IntPtr NativeFieldInfoPtr_StartChemistryStationBehaviour;

		// Token: 0x04003B18 RID: 15128
		private static readonly IntPtr NativeFieldInfoPtr_StartLabOvenBehaviour;

		// Token: 0x04003B19 RID: 15129
		private static readonly IntPtr NativeFieldInfoPtr_FinishLabOvenBehaviour;

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeFieldInfoPtr_StartCauldronBehaviour;

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeFieldInfoPtr_StartMixingStationBehaviour;

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0;

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0;

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr_TryStartNewTask_Private_Void_0;

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0;

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0;

		// Token: 0x04003B3D RID: 15165
		private static readonly IntPtr NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0;

		// Token: 0x04003B3E RID: 15166
		private static readonly IntPtr NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0;

		// Token: 0x04003B3F RID: 15167
		private static readonly IntPtr NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0;

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0;

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0;

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0;

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0;

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0;

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0;

		// Token: 0x04003B49 RID: 15177
		private static readonly IntPtr NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0;

		// Token: 0x04003B4A RID: 15178
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009CC RID: 2508
		[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC95 RID: 52373 RVA: 0x00315490 File Offset: 0x00313690
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr);
				Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, "conn");
				Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, 100674277);
				Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, 100674278);
				Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, 100674279);
			}

			// Token: 0x0600CC96 RID: 52374 RVA: 0x00315520 File Offset: 0x00313720
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC97 RID: 52375 RVA: 0x0031555C File Offset: 0x0031375C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184021, XrefRangeEnd = 184026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CC98 RID: 52376 RVA: 0x0031559C File Offset: 0x0031379C
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC99 RID: 52377 RVA: 0x000637CE File Offset: 0x000619CE
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FBC RID: 16316
			// (get) Token: 0x0600CC9A RID: 52378 RVA: 0x003155D8 File Offset: 0x003137D8
			// (set) Token: 0x0600CC9B RID: 52379 RVA: 0x000637D7 File Offset: 0x000619D7
			public unsafe Chemist __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBD RID: 16317
			// (get) Token: 0x0600CC9C RID: 52380 RVA: 0x00315608 File Offset: 0x00313808
			// (set) Token: 0x0600CC9D RID: 52381 RVA: 0x000637F6 File Offset: 0x000619F6
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A55 RID: 35413
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A56 RID: 35414
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008A57 RID: 35415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A58 RID: 35416
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A59 RID: 35417
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C4B RID: 3147
			[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass42_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2D1 RID: 58065 RVA: 0x00354088 File Offset: 0x00352288
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674280);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674281);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674282);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674283);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674284);
					Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674285);
				}

				// Token: 0x0600E2D2 RID: 58066 RVA: 0x00354168 File Offset: 0x00352368
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2D3 RID: 58067 RVA: 0x003541B0 File Offset: 0x003523B0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2D4 RID: 58068 RVA: 0x003541E4 File Offset: 0x003523E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184005, XrefRangeEnd = 184016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004660 RID: 18016
				// (get) Token: 0x0600E2D5 RID: 58069 RVA: 0x00354220 File Offset: 0x00352420
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2D6 RID: 58070 RVA: 0x00354260 File Offset: 0x00352460
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184016, XrefRangeEnd = 184021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004661 RID: 18017
				// (get) Token: 0x0600E2D7 RID: 58071 RVA: 0x00354294 File Offset: 0x00352494
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2D8 RID: 58072 RVA: 0x0006E946 File Offset: 0x0006CB46
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700465D RID: 18013
				// (get) Token: 0x0600E2D9 RID: 58073 RVA: 0x003542D4 File Offset: 0x003524D4
				// (set) Token: 0x0600E2DA RID: 58074 RVA: 0x0006E94F File Offset: 0x0006CB4F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700465E RID: 18014
				// (get) Token: 0x0600E2DB RID: 58075 RVA: 0x003542FC File Offset: 0x003524FC
				// (set) Token: 0x0600E2DC RID: 58076 RVA: 0x0006E96A File Offset: 0x0006CB6A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700465F RID: 18015
				// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x0035432C File Offset: 0x0035252C
				// (set) Token: 0x0600E2DE RID: 58078 RVA: 0x0006E989 File Offset: 0x0006CB89
				public unsafe Chemist.__c__DisplayClass42_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist.__c__DisplayClass42_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097CE RID: 38862
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097CF RID: 38863
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097D0 RID: 38864
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097D1 RID: 38865
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097D2 RID: 38866
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097D3 RID: 38867
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097D4 RID: 38868
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097D5 RID: 38869
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097D6 RID: 38870
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
