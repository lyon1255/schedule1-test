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
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000406 RID: 1030
	public class Cleaner : Employee
	{
		// Token: 0x06005755 RID: 22357 RVA: 0x00197A68 File Offset: 0x00195C68
		// Note: this type is marked as 'beforefieldinit'.
		static Cleaner()
		{
			Il2CppClassPointerStore<Cleaner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Cleaner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner>.NativeClassPtr);
			Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "MAX_ASSIGNED_BINS");
			Cleaner.NativeFieldInfoPtr_TrashGrabberDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "TrashGrabberDef");
			Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "PickUpTrashBehaviour");
			Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "EmptyTrashGrabberBehaviour");
			Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "BagTrashCanBehaviour");
			Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "DisposeTrashBagBehaviour");
			Cleaner.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "typeIcon");
			Cleaner.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "configReplicator");
			Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "WorldspaceUIPrefab");
			Cleaner.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "uiPoint");
			Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<trashGrabberInstance>k__BackingField");
			Cleaner.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<configuration>k__BackingField");
			Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted");
			Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted");
			Cleaner.NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674286);
			Cleaner.NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674287);
			Cleaner.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674288);
			Cleaner.NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674289);
			Cleaner.NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674290);
			Cleaner.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674291);
			Cleaner.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674292);
			Cleaner.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674293);
			Cleaner.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674294);
			Cleaner.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674295);
			Cleaner.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674296);
			Cleaner.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674297);
			Cleaner.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674298);
			Cleaner.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674299);
			Cleaner.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674300);
			Cleaner.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674301);
			Cleaner.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674302);
			Cleaner.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674303);
			Cleaner.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674304);
			Cleaner.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674305);
			Cleaner.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674306);
			Cleaner.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674307);
			Cleaner.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674308);
			Cleaner.NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674309);
			Cleaner.NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674310);
			Cleaner.NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674311);
			Cleaner.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674312);
			Cleaner.NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674313);
			Cleaner.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674314);
			Cleaner.NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674315);
			Cleaner.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674316);
			Cleaner.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674317);
			Cleaner.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674318);
			Cleaner.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674319);
			Cleaner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674320);
			Cleaner.NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__51_0_Private_Int32_TrashContainerItem_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674321);
			Cleaner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674322);
			Cleaner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674323);
			Cleaner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674324);
			Cleaner.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674325);
			Cleaner.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674326);
			Cleaner.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674327);
			Cleaner.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674328);
			Cleaner.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674329);
			Cleaner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674330);
			Cleaner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674331);
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x00197F84 File Offset: 0x00196184
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x00197FC4 File Offset: 0x001961C4
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184026, RefRangeEnd = 184030, XrefRangeStart = 184026, XrefRangeEnd = 184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x00198008 File Offset: 0x00196208
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94041, RefRangeEnd = 94045, XrefRangeStart = 94041, XrefRangeEnd = 94045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x00198048 File Offset: 0x00196248
		// (set) Token: 0x0600575A RID: 22362 RVA: 0x00198088 File Offset: 0x00196288
		public unsafe CleanerConfiguration configuration
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94041, RefRangeEnd = 94045, XrefRangeStart = 94041, XrefRangeEnd = 94045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CleanerConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x001980CC File Offset: 0x001962CC
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x0019810C File Offset: 0x0019630C
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 184621, RefRangeEnd = 184638, XrefRangeStart = 184621, XrefRangeEnd = 184621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x0600575D RID: 22365 RVA: 0x00198148 File Offset: 0x00196348
		// (set) Token: 0x0600575E RID: 22366 RVA: 0x00198188 File Offset: 0x00196388
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183348, RefRangeEnd = 183351, XrefRangeStart = 183348, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184638, XrefRangeEnd = 184639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x0600575F RID: 22367 RVA: 0x001981CC File Offset: 0x001963CC
		// (set) Token: 0x06005760 RID: 22368 RVA: 0x0019820C File Offset: 0x0019640C
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184649, RefRangeEnd = 184651, XrefRangeStart = 184641, XrefRangeEnd = 184649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00198250 File Offset: 0x00196450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184651, XrefRangeEnd = 184673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x00198294 File Offset: 0x00196494
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x001982D4 File Offset: 0x001964D4
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48827, RefRangeEnd = 48829, XrefRangeStart = 48827, XrefRangeEnd = 48829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x00198314 File Offset: 0x00196514
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x00198354 File Offset: 0x00196554
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x00198390 File Offset: 0x00196590
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x001983D0 File Offset: 0x001965D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184673, XrefRangeEnd = 184682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x00198420 File Offset: 0x00196620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184682, XrefRangeEnd = 184693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x0019845C File Offset: 0x0019665C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184693, XrefRangeEnd = 184711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x001984AC File Offset: 0x001966AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184711, XrefRangeEnd = 184728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x001984F0 File Offset: 0x001966F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184728, XrefRangeEnd = 184741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0019852C File Offset: 0x0019672C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184784, RefRangeEnd = 184785, XrefRangeStart = 184741, XrefRangeEnd = 184784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartNewTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x00198560 File Offset: 0x00196760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184785, XrefRangeEnd = 184803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerItem GetFirstNonFullBin(Il2CppReferenceArray<TrashContainerItem> bins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bins);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr3) : null;
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x001985B0 File Offset: 0x001967B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184803, XrefRangeEnd = 184811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref idle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x001985FC File Offset: 0x001967FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184811, XrefRangeEnd = 184823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashContainerItem> GetTrashContainersOrderedByDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashContainerItem>>(intPtr3) : null;
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0019863C File Offset: 0x0019683C
		[CallerCount(0)]
		public unsafe override BedItem GetBed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00198688 File Offset: 0x00196888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184823, XrefRangeEnd = 184832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureTrashGrabberInInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x001986BC File Offset: 0x001968BC
		[CallerCount(0)]
		public unsafe bool AnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x001986F8 File Offset: 0x001968F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184832, XrefRangeEnd = 184834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashGrabberAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x00198734 File Offset: 0x00196934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184861, RefRangeEnd = 184862, XrefRangeStart = 184834, XrefRangeEnd = 184861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00198774 File Offset: 0x00196974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184862, XrefRangeEnd = 184866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x001987A8 File Offset: 0x001969A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184866, XrefRangeEnd = 184876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x001987EC File Offset: 0x001969EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184876, XrefRangeEnd = 184898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00198848 File Offset: 0x00196A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cleaner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00198884 File Offset: 0x00196A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184898, XrefRangeEnd = 184917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetTrashContainersOrderedByDistance_b__51_0(TrashContainerItem x, TrashContainerItem y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__51_0_Private_Int32_TrashContainerItem_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x001988E4 File Offset: 0x00196AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184917, XrefRangeEnd = 184941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00198920 File Offset: 0x00196B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184941, XrefRangeEnd = 184942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0019895C File Offset: 0x00196B5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00198998 File Offset: 0x00196B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184942, XrefRangeEnd = 184961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x001989DC File Offset: 0x00196BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184649, RefRangeEnd = 184651, XrefRangeStart = 184649, XrefRangeEnd = 184651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00198A20 File Offset: 0x00196C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184961, XrefRangeEnd = 184965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06005780 RID: 22400 RVA: 0x00198A84 File Offset: 0x00196C84
		// (set) Token: 0x06005781 RID: 22401 RVA: 0x00198AC4 File Offset: 0x00196CC4
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184639, RefRangeEnd = 184641, XrefRangeStart = 184639, XrefRangeEnd = 184641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 184974, RefRangeEnd = 184975, XrefRangeStart = 184965, XrefRangeEnd = 184974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x00198B14 File Offset: 0x00196D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184975, XrefRangeEnd = 184979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00198B88 File Offset: 0x00196D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x000299CC File Offset: 0x00027BCC
		public Cleaner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06005785 RID: 22405 RVA: 0x00198BC4 File Offset: 0x00196DC4
		// (set) Token: 0x06005786 RID: 22406 RVA: 0x000299D5 File Offset: 0x00027BD5
		public unsafe static int MAX_ASSIGNED_BINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS, (void*)(&value));
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x00198BE0 File Offset: 0x00196DE0
		// (set) Token: 0x06005788 RID: 22408 RVA: 0x000299E3 File Offset: 0x00027BE3
		public unsafe TrashGrabberDefinition TrashGrabberDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_TrashGrabberDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_TrashGrabberDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06005789 RID: 22409 RVA: 0x00198C10 File Offset: 0x00196E10
		// (set) Token: 0x0600578A RID: 22410 RVA: 0x00029A02 File Offset: 0x00027C02
		public unsafe PickUpTrashBehaviour PickUpTrashBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickUpTrashBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600578B RID: 22411 RVA: 0x00198C40 File Offset: 0x00196E40
		// (set) Token: 0x0600578C RID: 22412 RVA: 0x00029A21 File Offset: 0x00027C21
		public unsafe EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyTrashGrabberBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600578D RID: 22413 RVA: 0x00198C70 File Offset: 0x00196E70
		// (set) Token: 0x0600578E RID: 22414 RVA: 0x00029A40 File Offset: 0x00027C40
		public unsafe BagTrashCanBehaviour BagTrashCanBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BagTrashCanBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x0600578F RID: 22415 RVA: 0x00198CA0 File Offset: 0x00196EA0
		// (set) Token: 0x06005790 RID: 22416 RVA: 0x00029A5F File Offset: 0x00027C5F
		public unsafe DisposeTrashBagBehaviour DisposeTrashBagBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisposeTrashBagBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x00198CD0 File Offset: 0x00196ED0
		// (set) Token: 0x06005792 RID: 22418 RVA: 0x00029A7E File Offset: 0x00027C7E
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x00198D00 File Offset: 0x00196F00
		// (set) Token: 0x06005794 RID: 22420 RVA: 0x00029A9D File Offset: 0x00027C9D
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06005795 RID: 22421 RVA: 0x00198D30 File Offset: 0x00196F30
		// (set) Token: 0x06005796 RID: 22422 RVA: 0x00029ABC File Offset: 0x00027CBC
		public unsafe CleanerUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x00198D60 File Offset: 0x00196F60
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x00029ADB File Offset: 0x00027CDB
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x00198D90 File Offset: 0x00196F90
		// (set) Token: 0x0600579A RID: 22426 RVA: 0x00029AFA File Offset: 0x00027CFA
		public unsafe TrashGrabberInstance _trashGrabberInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x0600579B RID: 22427 RVA: 0x00198DC0 File Offset: 0x00196FC0
		// (set) Token: 0x0600579C RID: 22428 RVA: 0x00029B19 File Offset: 0x00027D19
		public unsafe CleanerConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x00198DF0 File Offset: 0x00196FF0
		// (set) Token: 0x0600579E RID: 22430 RVA: 0x00029B38 File Offset: 0x00027D38
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x00198E20 File Offset: 0x00197020
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x00029B57 File Offset: 0x00027D57
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x00198E50 File Offset: 0x00197050
		// (set) Token: 0x060057A2 RID: 22434 RVA: 0x00029B76 File Offset: 0x00027D76
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x00198E80 File Offset: 0x00197080
		// (set) Token: 0x060057A4 RID: 22436 RVA: 0x00029B95 File Offset: 0x00027D95
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060057A5 RID: 22437 RVA: 0x00198EA8 File Offset: 0x001970A8
		// (set) Token: 0x060057A6 RID: 22438 RVA: 0x00029BB0 File Offset: 0x00027DB0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ASSIGNED_BINS;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeFieldInfoPtr_TrashGrabberDef;

		// Token: 0x04003B5B RID: 15195
		private static readonly IntPtr NativeFieldInfoPtr_PickUpTrashBehaviour;

		// Token: 0x04003B5C RID: 15196
		private static readonly IntPtr NativeFieldInfoPtr_EmptyTrashGrabberBehaviour;

		// Token: 0x04003B5D RID: 15197
		private static readonly IntPtr NativeFieldInfoPtr_BagTrashCanBehaviour;

		// Token: 0x04003B5E RID: 15198
		private static readonly IntPtr NativeFieldInfoPtr_DisposeTrashBagBehaviour;

		// Token: 0x04003B5F RID: 15199
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003B60 RID: 15200
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003B61 RID: 15201
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003B62 RID: 15202
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003B63 RID: 15203
		private static readonly IntPtr NativeFieldInfoPtr__trashGrabberInstance_k__BackingField;

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003B65 RID: 15205
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003B66 RID: 15206
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003B67 RID: 15207
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003B68 RID: 15208
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003B69 RID: 15209
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003B6A RID: 15210
		private static readonly IntPtr NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0;

		// Token: 0x04003B6B RID: 15211
		private static readonly IntPtr NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0;

		// Token: 0x04003B6C RID: 15212
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003B6D RID: 15213
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0;

		// Token: 0x04003B6E RID: 15214
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0;

		// Token: 0x04003B6F RID: 15215
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003B70 RID: 15216
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003B71 RID: 15217
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003B72 RID: 15218
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003B73 RID: 15219
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003B74 RID: 15220
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003B75 RID: 15221
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003B76 RID: 15222
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003B77 RID: 15223
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003B78 RID: 15224
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003B79 RID: 15225
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003B7A RID: 15226
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003B7B RID: 15227
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_0;

		// Token: 0x04003B7C RID: 15228
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003B7D RID: 15229
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003B7E RID: 15230
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003B7F RID: 15231
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04003B80 RID: 15232
		private static readonly IntPtr NativeMethodInfoPtr_TryStartNewTask_Private_Void_0;

		// Token: 0x04003B81 RID: 15233
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0;

		// Token: 0x04003B82 RID: 15234
		private static readonly IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003B83 RID: 15235
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0;

		// Token: 0x04003B84 RID: 15236
		private static readonly IntPtr NativeMethodInfoPtr_GetBed_Public_Virtual_BedItem_0;

		// Token: 0x04003B85 RID: 15237
		private static readonly IntPtr NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0;

		// Token: 0x04003B86 RID: 15238
		private static readonly IntPtr NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0;

		// Token: 0x04003B87 RID: 15239
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0;

		// Token: 0x04003B88 RID: 15240
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003B89 RID: 15241
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003B8A RID: 15242
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003B8B RID: 15243
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003B8C RID: 15244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B8D RID: 15245
		private static readonly IntPtr NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__51_0_Private_Int32_TrashContainerItem_TrashContainerItem_0;

		// Token: 0x04003B8E RID: 15246
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B8F RID: 15247
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B90 RID: 15248
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B91 RID: 15249
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003B92 RID: 15250
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003B93 RID: 15251
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B94 RID: 15252
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003B95 RID: 15253
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003B96 RID: 15254
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003B97 RID: 15255
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009CD RID: 2509
		[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CC9E RID: 52382 RVA: 0x00315638 File Offset: 0x00313838
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr);
				Cleaner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, "<>9");
				Cleaner.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, "<>9__49_0");
				Cleaner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, 100674333);
				Cleaner.__c.NativeMethodInfoPtr__GetFirstNonFullBin_b__49_0_Internal_Boolean_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, 100674334);
			}

			// Token: 0x0600CC9F RID: 52383 RVA: 0x003156B4 File Offset: 0x003138B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCA0 RID: 52384 RVA: 0x003156F0 File Offset: 0x003138F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184599, XrefRangeEnd = 184600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFirstNonFullBin_b__49_0(TrashContainerItem bin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c.NativeMethodInfoPtr__GetFirstNonFullBin_b__49_0_Internal_Boolean_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCA1 RID: 52385 RVA: 0x00063815 File Offset: 0x00061A15
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FBE RID: 16318
			// (get) Token: 0x0600CCA2 RID: 52386 RVA: 0x00315740 File Offset: 0x00313940
			// (set) Token: 0x0600CCA3 RID: 52387 RVA: 0x0006381E File Offset: 0x00061A1E
			public unsafe static Cleaner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Cleaner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Cleaner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBF RID: 16319
			// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x00315768 File Offset: 0x00313968
			// (set) Token: 0x0600CCA5 RID: 52389 RVA: 0x00063830 File Offset: 0x00061A30
			public unsafe static Func<TrashContainerItem, bool> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Cleaner.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrashContainerItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Cleaner.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A5A RID: 35418
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A5B RID: 35419
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04008A5C RID: 35420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A5D RID: 35421
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstNonFullBin_b__49_0_Internal_Boolean_TrashContainerItem_0;
		}

		// Token: 0x020009CE RID: 2510
		[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCA6 RID: 52390 RVA: 0x00315790 File Offset: 0x00313990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr);
				Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, "conn");
				Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, 100674335);
				Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, 100674336);
				Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, 100674337);
			}

			// Token: 0x0600CCA7 RID: 52391 RVA: 0x00315820 File Offset: 0x00313A20
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCA8 RID: 52392 RVA: 0x0031585C File Offset: 0x00313A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184616, XrefRangeEnd = 184621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CCA9 RID: 52393 RVA: 0x0031589C File Offset: 0x00313A9C
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCAA RID: 52394 RVA: 0x00063842 File Offset: 0x00061A42
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC0 RID: 16320
			// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x003158D8 File Offset: 0x00313AD8
			// (set) Token: 0x0600CCAC RID: 52396 RVA: 0x0006384B File Offset: 0x00061A4B
			public unsafe Cleaner __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x00315908 File Offset: 0x00313B08
			// (set) Token: 0x0600CCAE RID: 52398 RVA: 0x0006386A File Offset: 0x00061A6A
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A5E RID: 35422
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A5F RID: 35423
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008A60 RID: 35424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A61 RID: 35425
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A62 RID: 35426
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C4C RID: 3148
			[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c__DisplayClass46_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2DF RID: 58079 RVA: 0x0035435C File Offset: 0x0035255C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674338);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674339);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674340);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674341);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674342);
					Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674343);
				}

				// Token: 0x0600E2E0 RID: 58080 RVA: 0x0035443C File Offset: 0x0035263C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2E1 RID: 58081 RVA: 0x00354484 File Offset: 0x00352684
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2E2 RID: 58082 RVA: 0x003544B8 File Offset: 0x003526B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184600, XrefRangeEnd = 184611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004665 RID: 18021
				// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x003544F4 File Offset: 0x003526F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2E4 RID: 58084 RVA: 0x00354534 File Offset: 0x00352734
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184611, XrefRangeEnd = 184616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004666 RID: 18022
				// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x00354568 File Offset: 0x00352768
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2E6 RID: 58086 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004662 RID: 18018
				// (get) Token: 0x0600E2E7 RID: 58087 RVA: 0x003545A8 File Offset: 0x003527A8
				// (set) Token: 0x0600E2E8 RID: 58088 RVA: 0x0006E9B1 File Offset: 0x0006CBB1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004663 RID: 18019
				// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x003545D0 File Offset: 0x003527D0
				// (set) Token: 0x0600E2EA RID: 58090 RVA: 0x0006E9CC File Offset: 0x0006CBCC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004664 RID: 18020
				// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x00354600 File Offset: 0x00352800
				// (set) Token: 0x0600E2EC RID: 58092 RVA: 0x0006E9EB File Offset: 0x0006CBEB
				public unsafe Cleaner.__c__DisplayClass46_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner.__c__DisplayClass46_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass46_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097D7 RID: 38871
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097D8 RID: 38872
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097D9 RID: 38873
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097DA RID: 38874
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097DB RID: 38875
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097DC RID: 38876
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097DD RID: 38877
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097DE RID: 38878
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097DF RID: 38879
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
