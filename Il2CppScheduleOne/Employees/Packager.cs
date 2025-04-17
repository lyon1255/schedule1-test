using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
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
	// Token: 0x0200040A RID: 1034
	public class Packager : Employee
	{
		// Token: 0x0600585A RID: 22618 RVA: 0x0019BEC4 File Offset: 0x0019A0C4
		// Note: this type is marked as 'beforefieldinit'.
		static Packager()
		{
			Il2CppClassPointerStore<Packager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Packager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packager>.NativeClassPtr);
			Packager.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "typeIcon");
			Packager.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "configReplicator");
			Packager.NativeFieldInfoPtr_PackagingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "PackagingBehaviour");
			Packager.NativeFieldInfoPtr_BrickPressBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "BrickPressBehaviour");
			Packager.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "WorldspaceUIPrefab");
			Packager.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "uiPoint");
			Packager.NativeFieldInfoPtr_MaxAssignedStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "MaxAssignedStations");
			Packager.NativeFieldInfoPtr_PackagingSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "PackagingSpeedMultiplier");
			Packager.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "<configuration>k__BackingField");
			Packager.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Packager.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Packager.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Packager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted");
			Packager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.PackagerAssembly-CSharp.dll_Excuted");
			Packager.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674441);
			Packager.NativeMethodInfoPtr_get_configuration_Protected_get_PackagerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674442);
			Packager.NativeMethodInfoPtr_set_configuration_Protected_set_Void_PackagerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674443);
			Packager.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674444);
			Packager.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674445);
			Packager.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674446);
			Packager.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674447);
			Packager.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674448);
			Packager.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674449);
			Packager.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674450);
			Packager.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674451);
			Packager.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674452);
			Packager.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674453);
			Packager.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674454);
			Packager.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674455);
			Packager.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674456);
			Packager.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674457);
			Packager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674458);
			Packager.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674459);
			Packager.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674460);
			Packager.NativeMethodInfoPtr_StartPackaging_Private_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674461);
			Packager.NativeMethodInfoPtr_StartPress_Private_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674462);
			Packager.NativeMethodInfoPtr_StartMoveItem_Private_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674463);
			Packager.NativeMethodInfoPtr_StartMoveItem_Private_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674464);
			Packager.NativeMethodInfoPtr_GetStationToAttend_Protected_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674465);
			Packager.NativeMethodInfoPtr_GetBrickPress_Protected_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674466);
			Packager.NativeMethodInfoPtr_GetStationMoveItems_Protected_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674467);
			Packager.NativeMethodInfoPtr_GetBrickPressMoveItems_Protected_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674468);
			Packager.NativeMethodInfoPtr_GetTransitRouteReady_Protected_AdvancedTransitRoute_byref_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674469);
			Packager.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674470);
			Packager.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674471);
			Packager.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674472);
			Packager.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674473);
			Packager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674474);
			Packager.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674475);
			Packager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674476);
			Packager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674477);
			Packager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674478);
			Packager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674479);
			Packager.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674480);
			Packager.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674481);
			Packager.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674482);
			Packager.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674483);
			Packager.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674484);
			Packager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Packager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674485);
			Packager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager>.NativeClassPtr, 100674486);
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600585B RID: 22619 RVA: 0x0019C3A4 File Offset: 0x0019A5A4
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x0019C3E4 File Offset: 0x0019A5E4
		// (set) Token: 0x0600585D RID: 22621 RVA: 0x0019C424 File Offset: 0x0019A624
		public unsafe PackagerConfiguration configuration
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 185975, RefRangeEnd = 185983, XrefRangeStart = 185975, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_configuration_Protected_get_PackagerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagerConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185983, XrefRangeEnd = 185984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_set_configuration_Protected_set_Void_PackagerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x0019C468 File Offset: 0x0019A668
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x0600585F RID: 22623 RVA: 0x0019C4A8 File Offset: 0x0019A6A8
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06005860 RID: 22624 RVA: 0x0019C4E4 File Offset: 0x0019A6E4
		// (set) Token: 0x06005861 RID: 22625 RVA: 0x0019C524 File Offset: 0x0019A724
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185984, XrefRangeEnd = 185985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x0019C568 File Offset: 0x0019A768
		// (set) Token: 0x06005863 RID: 22627 RVA: 0x0019C5A8 File Offset: 0x0019A7A8
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 185993, RefRangeEnd = 185995, XrefRangeStart = 185985, XrefRangeEnd = 185993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x0019C5EC File Offset: 0x0019A7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185995, XrefRangeEnd = 186017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x0019C630 File Offset: 0x0019A830
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06005866 RID: 22630 RVA: 0x0019C670 File Offset: 0x0019A870
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0019C6B0 File Offset: 0x0019A8B0
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0019C6F0 File Offset: 0x0019A8F0
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06005869 RID: 22633 RVA: 0x0019C72C File Offset: 0x0019A92C
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0019C76C File Offset: 0x0019A96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186017, XrefRangeEnd = 186026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0019C7BC File Offset: 0x0019A9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186026, XrefRangeEnd = 186037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0019C7F8 File Offset: 0x0019A9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186037, XrefRangeEnd = 186055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x0019C848 File Offset: 0x0019AA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186055, XrefRangeEnd = 186072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x0019C88C File Offset: 0x0019AA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186072, XrefRangeEnd = 186102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x0019C8C8 File Offset: 0x0019AAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186102, XrefRangeEnd = 186114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPackaging(PackagingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_StartPackaging_Private_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0019C90C File Offset: 0x0019AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPress(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_StartPress_Private_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x0019C950 File Offset: 0x0019AB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186114, XrefRangeEnd = 186129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMoveItem(PackagingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_StartMoveItem_Private_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x0019C994 File Offset: 0x0019AB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186129, XrefRangeEnd = 186135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMoveItem(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_StartMoveItem_Private_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0019C9D8 File Offset: 0x0019ABD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186146, RefRangeEnd = 186147, XrefRangeStart = 186135, XrefRangeEnd = 186146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStation GetStationToAttend()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_GetStationToAttend_Protected_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0019CA18 File Offset: 0x0019AC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186158, RefRangeEnd = 186159, XrefRangeStart = 186147, XrefRangeEnd = 186158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPress GetBrickPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_GetBrickPress_Protected_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0019CA58 File Offset: 0x0019AC58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186174, RefRangeEnd = 186175, XrefRangeStart = 186159, XrefRangeEnd = 186174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStation GetStationMoveItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_GetStationMoveItems_Protected_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0019CA98 File Offset: 0x0019AC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186190, RefRangeEnd = 186191, XrefRangeStart = 186175, XrefRangeEnd = 186190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPress GetBrickPressMoveItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_GetBrickPressMoveItems_Protected_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0019CAD8 File Offset: 0x0019ACD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186206, RefRangeEnd = 186207, XrefRangeStart = 186191, XrefRangeEnd = 186206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute GetTransitRouteReady(out ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_GetTransitRouteReady_Protected_AdvancedTransitRoute_byref_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			item = ((intPtr4 == 0) ? null : new ItemInstance(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr5) : null;
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0019CB3C File Offset: 0x0019AD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186207, XrefRangeEnd = 186208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0019CB84 File Offset: 0x0019AD84
		[CallerCount(0)]
		public unsafe override BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x0019CBD0 File Offset: 0x0019ADD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186235, RefRangeEnd = 186236, XrefRangeStart = 186208, XrefRangeEnd = 186235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0019CC10 File Offset: 0x0019AE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186236, XrefRangeEnd = 186240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0019CC44 File Offset: 0x0019AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186240, XrefRangeEnd = 186250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x0019CC88 File Offset: 0x0019AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186250, XrefRangeEnd = 186272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0019CCE4 File Offset: 0x0019AEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186272, XrefRangeEnd = 186273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Packager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Packager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0019CD20 File Offset: 0x0019AF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186273, XrefRangeEnd = 186297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0019CD5C File Offset: 0x0019AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186297, XrefRangeEnd = 186298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0019CD98 File Offset: 0x0019AF98
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x0019CDD4 File Offset: 0x0019AFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186298, XrefRangeEnd = 186317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0019CE18 File Offset: 0x0019B018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185993, RefRangeEnd = 185995, XrefRangeStart = 185993, XrefRangeEnd = 185995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0019CE5C File Offset: 0x0019B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186317, XrefRangeEnd = 186321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x0019CEC0 File Offset: 0x0019B0C0
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x0019CF00 File Offset: 0x0019B100
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186330, RefRangeEnd = 186331, XrefRangeStart = 186321, XrefRangeEnd = 186330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x0019CF50 File Offset: 0x0019B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186331, XrefRangeEnd = 186335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Packager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Packager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x0019CFC4 File Offset: 0x0019B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Packager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x0002A087 File Offset: 0x00028287
		public Packager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x0600588A RID: 22666 RVA: 0x0019D000 File Offset: 0x0019B200
		// (set) Token: 0x0600588B RID: 22667 RVA: 0x0002A090 File Offset: 0x00028290
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x0600588C RID: 22668 RVA: 0x0019D030 File Offset: 0x0019B230
		// (set) Token: 0x0600588D RID: 22669 RVA: 0x0002A0AF File Offset: 0x000282AF
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x0019D060 File Offset: 0x0019B260
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x0002A0CE File Offset: 0x000282CE
		public unsafe PackagingStationBehaviour PackagingBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_PackagingBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_PackagingBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x0019D090 File Offset: 0x0019B290
		// (set) Token: 0x06005891 RID: 22673 RVA: 0x0002A0ED File Offset: 0x000282ED
		public unsafe BrickPressBehaviour BrickPressBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_BrickPressBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPressBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_BrickPressBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x0019D0C0 File Offset: 0x0019B2C0
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x0002A10C File Offset: 0x0002830C
		public unsafe PackagerUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x0019D0F0 File Offset: 0x0019B2F0
		// (set) Token: 0x06005895 RID: 22677 RVA: 0x0002A12B File Offset: 0x0002832B
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x0019D120 File Offset: 0x0019B320
		// (set) Token: 0x06005897 RID: 22679 RVA: 0x0002A14A File Offset: 0x0002834A
		public unsafe int MaxAssignedStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_MaxAssignedStations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_MaxAssignedStations)) = value;
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06005898 RID: 22680 RVA: 0x0019D148 File Offset: 0x0019B348
		// (set) Token: 0x06005899 RID: 22681 RVA: 0x0002A165 File Offset: 0x00028365
		public unsafe float PackagingSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_PackagingSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_PackagingSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x0019D170 File Offset: 0x0019B370
		// (set) Token: 0x0600589B RID: 22683 RVA: 0x0002A180 File Offset: 0x00028380
		public unsafe PackagerConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagerConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x0019D1A0 File Offset: 0x0019B3A0
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x0002A19F File Offset: 0x0002839F
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0019D1D0 File Offset: 0x0019B3D0
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x0002A1BE File Offset: 0x000283BE
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x0019D200 File Offset: 0x0019B400
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x0002A1DD File Offset: 0x000283DD
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x0019D230 File Offset: 0x0019B430
		// (set) Token: 0x060058A3 RID: 22691 RVA: 0x0002A1FC File Offset: 0x000283FC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x0019D258 File Offset: 0x0019B458
		// (set) Token: 0x060058A5 RID: 22693 RVA: 0x0002A217 File Offset: 0x00028417
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C23 RID: 15395
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003C24 RID: 15396
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003C25 RID: 15397
		private static readonly IntPtr NativeFieldInfoPtr_PackagingBehaviour;

		// Token: 0x04003C26 RID: 15398
		private static readonly IntPtr NativeFieldInfoPtr_BrickPressBehaviour;

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeFieldInfoPtr_MaxAssignedStations;

		// Token: 0x04003C2A RID: 15402
		private static readonly IntPtr NativeFieldInfoPtr_PackagingSpeedMultiplier;

		// Token: 0x04003C2B RID: 15403
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003C2C RID: 15404
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003C2D RID: 15405
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C2E RID: 15406
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C2F RID: 15407
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003C30 RID: 15408
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003C31 RID: 15409
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003C32 RID: 15410
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_PackagerConfiguration_0;

		// Token: 0x04003C33 RID: 15411
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_PackagerConfiguration_0;

		// Token: 0x04003C34 RID: 15412
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003C35 RID: 15413
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003C36 RID: 15414
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003C37 RID: 15415
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003C38 RID: 15416
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003C39 RID: 15417
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003C3A RID: 15418
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C3D RID: 15421
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C3E RID: 15422
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003C3F RID: 15423
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003C40 RID: 15424
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0;

		// Token: 0x04003C41 RID: 15425
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003C42 RID: 15426
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003C43 RID: 15427
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003C44 RID: 15428
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003C45 RID: 15429
		private static readonly IntPtr NativeMethodInfoPtr_StartPackaging_Private_Void_PackagingStation_0;

		// Token: 0x04003C46 RID: 15430
		private static readonly IntPtr NativeMethodInfoPtr_StartPress_Private_Void_BrickPress_0;

		// Token: 0x04003C47 RID: 15431
		private static readonly IntPtr NativeMethodInfoPtr_StartMoveItem_Private_Void_PackagingStation_0;

		// Token: 0x04003C48 RID: 15432
		private static readonly IntPtr NativeMethodInfoPtr_StartMoveItem_Private_Void_BrickPress_0;

		// Token: 0x04003C49 RID: 15433
		private static readonly IntPtr NativeMethodInfoPtr_GetStationToAttend_Protected_PackagingStation_0;

		// Token: 0x04003C4A RID: 15434
		private static readonly IntPtr NativeMethodInfoPtr_GetBrickPress_Protected_BrickPress_0;

		// Token: 0x04003C4B RID: 15435
		private static readonly IntPtr NativeMethodInfoPtr_GetStationMoveItems_Protected_PackagingStation_0;

		// Token: 0x04003C4C RID: 15436
		private static readonly IntPtr NativeMethodInfoPtr_GetBrickPressMoveItems_Protected_BrickPress_0;

		// Token: 0x04003C4D RID: 15437
		private static readonly IntPtr NativeMethodInfoPtr_GetTransitRouteReady_Protected_AdvancedTransitRoute_byref_ItemInstance_0;

		// Token: 0x04003C4E RID: 15438
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003C4F RID: 15439
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0;

		// Token: 0x04003C50 RID: 15440
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003C51 RID: 15441
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003C52 RID: 15442
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003C53 RID: 15443
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003C54 RID: 15444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C55 RID: 15445
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003C56 RID: 15446
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003C57 RID: 15447
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003C58 RID: 15448
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003C59 RID: 15449
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C5A RID: 15450
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003C5B RID: 15451
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003C5C RID: 15452
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003C5D RID: 15453
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Packager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003C5E RID: 15454
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009D2 RID: 2514
		[ObfuscatedName("ScheduleOne.Employees.Packager+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCC5 RID: 52421 RVA: 0x00315CB8 File Offset: 0x00313EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Packager>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr);
				Packager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				Packager.__c__DisplayClass40_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, "conn");
				Packager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, 100674487);
				Packager.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, 100674488);
				Packager.__c__DisplayClass40_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, 100674489);
			}

			// Token: 0x0600CCC6 RID: 52422 RVA: 0x00315D48 File Offset: 0x00313F48
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCC7 RID: 52423 RVA: 0x00315D84 File Offset: 0x00313F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185970, XrefRangeEnd = 185975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CCC8 RID: 52424 RVA: 0x00315DC4 File Offset: 0x00313FC4
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCC9 RID: 52425 RVA: 0x00063956 File Offset: 0x00061B56
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC8 RID: 16328
			// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x00315E00 File Offset: 0x00314000
			// (set) Token: 0x0600CCCB RID: 52427 RVA: 0x0006395F File Offset: 0x00061B5F
			public unsafe Packager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC9 RID: 16329
			// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00315E30 File Offset: 0x00314030
			// (set) Token: 0x0600CCCD RID: 52429 RVA: 0x0006397E File Offset: 0x00061B7E
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A6D RID: 35437
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A6E RID: 35438
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008A6F RID: 35439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A70 RID: 35440
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A71 RID: 35441
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C4D RID: 3149
			[ObfuscatedName("ScheduleOne.Employees.Packager+<>c__DisplayClass40_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2ED RID: 58093 RVA: 0x00354630 File Offset: 0x00352830
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674490);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674491);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674492);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674493);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674494);
					Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674495);
				}

				// Token: 0x0600E2EE RID: 58094 RVA: 0x00354710 File Offset: 0x00352910
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2EF RID: 58095 RVA: 0x00354758 File Offset: 0x00352958
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2F0 RID: 58096 RVA: 0x0035478C File Offset: 0x0035298C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185954, XrefRangeEnd = 185965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700466A RID: 18026
				// (get) Token: 0x0600E2F1 RID: 58097 RVA: 0x003547C8 File Offset: 0x003529C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2F2 RID: 58098 RVA: 0x00354808 File Offset: 0x00352A08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185965, XrefRangeEnd = 185970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700466B RID: 18027
				// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x0035483C File Offset: 0x00352A3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2F4 RID: 58100 RVA: 0x0006EA0A File Offset: 0x0006CC0A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004667 RID: 18023
				// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x0035487C File Offset: 0x00352A7C
				// (set) Token: 0x0600E2F6 RID: 58102 RVA: 0x0006EA13 File Offset: 0x0006CC13
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004668 RID: 18024
				// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x003548A4 File Offset: 0x00352AA4
				// (set) Token: 0x0600E2F8 RID: 58104 RVA: 0x0006EA2E File Offset: 0x0006CC2E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004669 RID: 18025
				// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x003548D4 File Offset: 0x00352AD4
				// (set) Token: 0x0600E2FA RID: 58106 RVA: 0x0006EA4D File Offset: 0x0006CC4D
				public unsafe Packager.__c__DisplayClass40_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager.__c__DisplayClass40_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Packager.__c__DisplayClass40_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097E0 RID: 38880
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097E1 RID: 38881
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097E2 RID: 38882
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097E3 RID: 38883
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097E4 RID: 38884
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097E5 RID: 38885
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097E6 RID: 38886
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097E7 RID: 38887
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097E8 RID: 38888
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
