using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050E RID: 1294
	public class Property : NetworkBehaviour
	{
		// Token: 0x06007283 RID: 29315 RVA: 0x001F4AF4 File Offset: 0x001F2CF4
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Property");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property>.NativeClassPtr);
			Property.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Properties");
			Property.NativeFieldInfoPtr_UnownedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "UnownedProperties");
			Property.NativeFieldInfoPtr_OwnedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedProperties");
			Property.NativeFieldInfoPtr_onPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onPropertyAcquired");
			Property.NativeFieldInfoPtr_onThisPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onThisPropertyAcquired");
			Property.NativeFieldInfoPtr__IsOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsOwned>k__BackingField");
			Property.NativeFieldInfoPtr__Employees_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<Employees>k__BackingField");
			Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<WorldspaceUIContainer>k__BackingField");
			Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsContentCulled>k__BackingField");
			Property.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyName");
			Property.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "AvailableInDemo");
			Property.NativeFieldInfoPtr_propertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyCode");
			Property.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Price");
			Property.NativeFieldInfoPtr_DefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DefaultRotation");
			Property.NativeFieldInfoPtr_EmployeeCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeCapacity");
			Property.NativeFieldInfoPtr_OwnedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedByDefault");
			Property.NativeFieldInfoPtr_DEBUG_SET_OWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DEBUG_SET_OWNED");
			Property.NativeFieldInfoPtr_IsOwnedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "IsOwnedVariable");
			Property.NativeFieldInfoPtr_ContentCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ContentCullingEnabled");
			Property.NativeFieldInfoPtr_MinimumCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MinimumCullingDistance");
			Property.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ObjectsToCull");
			Property.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Container");
			Property.NativeFieldInfoPtr_EmployeeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeContainer");
			Property.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "SpawnPoint");
			Property.NativeFieldInfoPtr_InteriorSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "InteriorSpawnPoint");
			Property.NativeFieldInfoPtr_ForSaleSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ForSaleSign");
			Property.NativeFieldInfoPtr_BoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BoundingBox");
			Property.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "PoI");
			Property.NativeFieldInfoPtr_ListingPoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ListingPoster");
			Property.NativeFieldInfoPtr_NPCSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NPCSpawnPoint");
			Property.NativeFieldInfoPtr_EmployeeIdlePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeIdlePoints");
			Property.NativeFieldInfoPtr_Switches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Switches");
			Property.NativeFieldInfoPtr_Toggleables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Toggleables");
			Property.NativeFieldInfoPtr_DisposalArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DisposalArea");
			Property.NativeFieldInfoPtr_LoadingDocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "LoadingDocks");
			Property.NativeFieldInfoPtr_BuildableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BuildableItems");
			Property.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Configurables");
			Property.NativeFieldInfoPtr_propertyBoundsColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyBoundsColliders");
			Property.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "loader");
			Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Property.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<HasChanged>k__BackingField");
			Property.NativeFieldInfoPtr_savedObjectPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedObjectPaths");
			Property.NativeFieldInfoPtr_savedEmployeePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedEmployeePaths");
			Property.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677670);
			Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677671);
			Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677672);
			Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677673);
			Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677674);
			Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677675);
			Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677676);
			Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677677);
			Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677678);
			Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677679);
			Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677680);
			Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677681);
			Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677682);
			Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677683);
			Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677684);
			Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677685);
			Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677686);
			Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677687);
			Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677688);
			Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677689);
			Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677690);
			Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677691);
			Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677692);
			Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677693);
			Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677694);
			Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677695);
			Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677696);
			Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677697);
			Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677698);
			Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677699);
			Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677700);
			Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677701);
			Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677702);
			Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677703);
			Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677704);
			Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677705);
			Property.NativeMethodInfoPtr_SetOwned_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677706);
			Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677707);
			Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677708);
			Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677709);
			Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677710);
			Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677711);
			Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677712);
			Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677713);
			Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677714);
			Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677715);
			Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677716);
			Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677717);
			Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677718);
			Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677719);
			Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677720);
			Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677721);
			Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677723);
			Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677724);
			Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677725);
			Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677726);
			Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677727);
			Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677728);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677729);
			Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677730);
			Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677731);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677732);
			Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677733);
			Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677734);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677735);
			Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677736);
			Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677737);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677738);
			Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677739);
			Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677740);
			Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677741);
			Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677742);
			Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677743);
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06007284 RID: 29316 RVA: 0x001F5470 File Offset: 0x001F3670
		// (set) Token: 0x06007285 RID: 29317 RVA: 0x001F54AC File Offset: 0x001F36AC
		public unsafe bool IsOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x06007286 RID: 29318 RVA: 0x001F54EC File Offset: 0x001F36EC
		// (set) Token: 0x06007287 RID: 29319 RVA: 0x001F552C File Offset: 0x001F372C
		public unsafe List<Employee> Employees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x001F5570 File Offset: 0x001F3770
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x001F55B0 File Offset: 0x001F37B0
		public unsafe RectTransform WorldspaceUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x001F55F4 File Offset: 0x001F37F4
		// (set) Token: 0x0600728B RID: 29323 RVA: 0x001F5630 File Offset: 0x001F3830
		public unsafe bool IsContentCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x001F5670 File Offset: 0x001F3870
		public unsafe string PropertyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x001F56A8 File Offset: 0x001F38A8
		public unsafe string PropertyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x001F56E0 File Offset: 0x001F38E0
		public unsafe int LoadingDockCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 224429, RefRangeEnd = 224432, XrefRangeStart = 224429, XrefRangeEnd = 224429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x001F571C File Offset: 0x001F391C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06007290 RID: 29328 RVA: 0x001F5754 File Offset: 0x001F3954
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224432, XrefRangeEnd = 224434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x001F578C File Offset: 0x001F398C
		public unsafe virtual Loader Loader
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 166225, RefRangeEnd = 166239, XrefRangeStart = 166225, XrefRangeEnd = 166239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x06007292 RID: 29330 RVA: 0x001F57CC File Offset: 0x001F39CC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x001F5808 File Offset: 0x001F3A08
		// (set) Token: 0x06007294 RID: 29332 RVA: 0x001F5848 File Offset: 0x001F3A48
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x001F588C File Offset: 0x001F3A8C
		// (set) Token: 0x06007296 RID: 29334 RVA: 0x001F58CC File Offset: 0x001F3ACC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 224434, RefRangeEnd = 224436, XrefRangeStart = 224434, XrefRangeEnd = 224434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224436, XrefRangeEnd = 224437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x001F5910 File Offset: 0x001F3B10
		// (set) Token: 0x06007298 RID: 29336 RVA: 0x001F594C File Offset: 0x001F3B4C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x001F598C File Offset: 0x001F3B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224437, XrefRangeEnd = 224438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x001F59C8 File Offset: 0x001F3BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224438, XrefRangeEnd = 224444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x001F5A04 File Offset: 0x001F3C04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 224462, RefRangeEnd = 224467, XrefRangeStart = 224444, XrefRangeEnd = 224462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x001F5A40 File Offset: 0x001F3C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224467, XrefRangeEnd = 224468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x001F5A7C File Offset: 0x001F3C7C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 224474, RefRangeEnd = 224486, XrefRangeStart = 224468, XrefRangeEnd = 224474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x001F5AC0 File Offset: 0x001F3CC0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 224492, RefRangeEnd = 224504, XrefRangeStart = 224486, XrefRangeEnd = 224492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x001F5B04 File Offset: 0x001F3D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224526, RefRangeEnd = 224527, XrefRangeStart = 224504, XrefRangeEnd = 224526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x001F5B38 File Offset: 0x001F3D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224536, RefRangeEnd = 224538, XrefRangeStart = 224527, XrefRangeEnd = 224536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x001F5B88 File Offset: 0x001F3D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224572, RefRangeEnd = 224573, XrefRangeStart = 224538, XrefRangeEnd = 224572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x001F5BC4 File Offset: 0x001F3DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224573, XrefRangeEnd = 224574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x001F5C14 File Offset: 0x001F3E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224574, XrefRangeEnd = 224593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x001F5C50 File Offset: 0x001F3E50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224614, RefRangeEnd = 224618, XrefRangeStart = 224593, XrefRangeEnd = 224614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A5 RID: 29349 RVA: 0x001F5C84 File Offset: 0x001F3E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224638, RefRangeEnd = 224640, XrefRangeStart = 224618, XrefRangeEnd = 224638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOwned_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x001F5CB8 File Offset: 0x001F3EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224696, RefRangeEnd = 224697, XrefRangeStart = 224640, XrefRangeEnd = 224696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x001F5CF4 File Offset: 0x001F3EF4
		[CallerCount(0)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x001F5D3C File Offset: 0x001F3F3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224698, RefRangeEnd = 224701, XrefRangeStart = 224697, XrefRangeEnd = 224698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x001F5D70 File Offset: 0x001F3F70
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundsVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x001F5DB0 File Offset: 0x001F3FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224701, XrefRangeEnd = 224724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x001F5DFC File Offset: 0x001F3FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224734, RefRangeEnd = 224735, XrefRangeStart = 224724, XrefRangeEnd = 224734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RegisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072AC RID: 29356 RVA: 0x001F5E4C File Offset: 0x001F404C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224739, RefRangeEnd = 224740, XrefRangeStart = 224735, XrefRangeEnd = 224739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072AD RID: 29357 RVA: 0x001F5E90 File Offset: 0x001F4090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224740, XrefRangeEnd = 224755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleableActioned(InteractableToggleable toggleable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggleable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x001F5ED4 File Offset: 0x001F40D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224755, XrefRangeEnd = 224776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToggleableState(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x001F5F20 File Offset: 0x001F4120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224811, RefRangeEnd = 224814, XrefRangeStart = 224776, XrefRangeEnd = 224811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x001F5F80 File Offset: 0x001F4180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224814, XrefRangeEnd = 224846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x001F5FC4 File Offset: 0x001F41C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224846, XrefRangeEnd = 224920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x001F6020 File Offset: 0x001F4220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224920, XrefRangeEnd = 224947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x001F6070 File Offset: 0x001F4270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224947, XrefRangeEnd = 224960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PropertyData propertyData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x001F60D0 File Offset: 0x001F42D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 224966, RefRangeEnd = 224972, XrefRangeStart = 224960, XrefRangeEnd = 224966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x001F611C File Offset: 0x001F431C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224982, RefRangeEnd = 224983, XrefRangeStart = 224972, XrefRangeEnd = 224982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(box);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x001F6178 File Offset: 0x001F4378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225008, RefRangeEnd = 225009, XrefRangeStart = 224983, XrefRangeEnd = 225008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Bed> GetUnassignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Bed>>(intPtr3) : null;
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x001F61B8 File Offset: 0x001F43B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225090, RefRangeEnd = 225095, XrefRangeStart = 225009, XrefRangeEnd = 225090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x001F61F4 File Offset: 0x001F43F4
		[CallerCount(0)]
		public unsafe void _Awake_b__80_0(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x001F6234 File Offset: 0x001F4434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225095, XrefRangeEnd = 225100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x001F6274 File Offset: 0x001F4474
		[CallerCount(0)]
		public unsafe bool _RecieveOwned_b__93_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x001F62B0 File Offset: 0x001F44B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225132, RefRangeEnd = 225137, XrefRangeStart = 225100, XrefRangeEnd = 225132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x001F62EC File Offset: 0x001F44EC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x001F6328 File Offset: 0x001F4528
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x001F6364 File Offset: 0x001F4564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225137, XrefRangeEnd = 225155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x001F6398 File Offset: 0x001F4598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224638, RefRangeEnd = 224640, XrefRangeStart = 224638, XrefRangeEnd = 224640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001F63CC File Offset: 0x001F45CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225155, XrefRangeEnd = 225158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x001F6430 File Offset: 0x001F4630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225158, XrefRangeEnd = 225176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x001F6464 File Offset: 0x001F4664
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x001F6498 File Offset: 0x001F4698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225176, XrefRangeEnd = 225178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x001F64E8 File Offset: 0x001F46E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x001F6534 File Offset: 0x001F4734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225178, XrefRangeEnd = 225179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x001F6580 File Offset: 0x001F4780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225179, XrefRangeEnd = 225183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x001F65E4 File Offset: 0x001F47E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225183, XrefRangeEnd = 225204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x001F6644 File Offset: 0x001F4844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225209, RefRangeEnd = 225211, XrefRangeStart = 225204, XrefRangeEnd = 225209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x001F66A4 File Offset: 0x001F48A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225211, XrefRangeEnd = 225215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x001F66F4 File Offset: 0x001F48F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225215, XrefRangeEnd = 225227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x001F6754 File Offset: 0x001F4954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225227, XrefRangeEnd = 225232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x001F67A4 File Offset: 0x001F49A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 225408, RefRangeEnd = 225414, XrefRangeStart = 225232, XrefRangeEnd = 225408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00036725 File Offset: 0x00034925
		public Property(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x060072CE RID: 29390 RVA: 0x001F67E0 File Offset: 0x001F49E0
		// (set) Token: 0x060072CF RID: 29391 RVA: 0x0003672E File Offset: 0x0003492E
		public unsafe static List<Property> Properties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_Properties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_Properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x060072D0 RID: 29392 RVA: 0x001F6808 File Offset: 0x001F4A08
		// (set) Token: 0x060072D1 RID: 29393 RVA: 0x00036740 File Offset: 0x00034940
		public unsafe static List<Property> UnownedProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_UnownedProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_UnownedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x001F6830 File Offset: 0x001F4A30
		// (set) Token: 0x060072D3 RID: 29395 RVA: 0x00036752 File Offset: 0x00034952
		public unsafe static List<Property> OwnedProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_OwnedProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_OwnedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x001F6858 File Offset: 0x001F4A58
		// (set) Token: 0x060072D5 RID: 29397 RVA: 0x00036764 File Offset: 0x00034964
		public unsafe static Property.PropertyChange onPropertyAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_onPropertyAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.PropertyChange>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_onPropertyAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x001F6880 File Offset: 0x001F4A80
		// (set) Token: 0x060072D7 RID: 29399 RVA: 0x00036776 File Offset: 0x00034976
		public unsafe UnityEvent onThisPropertyAcquired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x001F68B0 File Offset: 0x001F4AB0
		// (set) Token: 0x060072D9 RID: 29401 RVA: 0x00036795 File Offset: 0x00034995
		public unsafe bool _IsOwned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x001F68D8 File Offset: 0x001F4AD8
		// (set) Token: 0x060072DB RID: 29403 RVA: 0x000367B0 File Offset: 0x000349B0
		public unsafe List<Employee> _Employees_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x060072DC RID: 29404 RVA: 0x001F6908 File Offset: 0x001F4B08
		// (set) Token: 0x060072DD RID: 29405 RVA: 0x000367CF File Offset: 0x000349CF
		public unsafe RectTransform _WorldspaceUIContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060072DE RID: 29406 RVA: 0x001F6938 File Offset: 0x001F4B38
		// (set) Token: 0x060072DF RID: 29407 RVA: 0x000367EE File Offset: 0x000349EE
		public unsafe bool _IsContentCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x001F6960 File Offset: 0x001F4B60
		// (set) Token: 0x060072E1 RID: 29409 RVA: 0x00036809 File Offset: 0x00034A09
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x001F6988 File Offset: 0x001F4B88
		// (set) Token: 0x060072E3 RID: 29411 RVA: 0x00036828 File Offset: 0x00034A28
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x060072E4 RID: 29412 RVA: 0x001F69B0 File Offset: 0x001F4BB0
		// (set) Token: 0x060072E5 RID: 29413 RVA: 0x00036843 File Offset: 0x00034A43
		public unsafe string propertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x060072E6 RID: 29414 RVA: 0x001F69D8 File Offset: 0x001F4BD8
		// (set) Token: 0x060072E7 RID: 29415 RVA: 0x00036862 File Offset: 0x00034A62
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x001F6A00 File Offset: 0x001F4C00
		// (set) Token: 0x060072E9 RID: 29417 RVA: 0x0003687D File Offset: 0x00034A7D
		public unsafe float DefaultRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation)) = value;
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x001F6A28 File Offset: 0x001F4C28
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x00036898 File Offset: 0x00034A98
		public unsafe int EmployeeCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity)) = value;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x001F6A50 File Offset: 0x001F4C50
		// (set) Token: 0x060072ED RID: 29421 RVA: 0x000368B3 File Offset: 0x00034AB3
		public unsafe bool OwnedByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault)) = value;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x060072EE RID: 29422 RVA: 0x001F6A78 File Offset: 0x001F4C78
		// (set) Token: 0x060072EF RID: 29423 RVA: 0x000368CE File Offset: 0x00034ACE
		public unsafe bool DEBUG_SET_OWNED
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED)) = value;
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x060072F0 RID: 29424 RVA: 0x001F6AA0 File Offset: 0x001F4CA0
		// (set) Token: 0x060072F1 RID: 29425 RVA: 0x000368E9 File Offset: 0x00034AE9
		public unsafe string IsOwnedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x060072F2 RID: 29426 RVA: 0x001F6AC8 File Offset: 0x001F4CC8
		// (set) Token: 0x060072F3 RID: 29427 RVA: 0x00036908 File Offset: 0x00034B08
		public unsafe bool ContentCullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled)) = value;
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x060072F4 RID: 29428 RVA: 0x001F6AF0 File Offset: 0x001F4CF0
		// (set) Token: 0x060072F5 RID: 29429 RVA: 0x00036923 File Offset: 0x00034B23
		public unsafe float MinimumCullingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance)) = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x060072F6 RID: 29430 RVA: 0x001F6B18 File Offset: 0x001F4D18
		// (set) Token: 0x060072F7 RID: 29431 RVA: 0x0003693E File Offset: 0x00034B3E
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x060072F8 RID: 29432 RVA: 0x001F6B48 File Offset: 0x001F4D48
		// (set) Token: 0x060072F9 RID: 29433 RVA: 0x0003695D File Offset: 0x00034B5D
		public unsafe PropertyContentsContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyContentsContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x060072FA RID: 29434 RVA: 0x001F6B78 File Offset: 0x001F4D78
		// (set) Token: 0x060072FB RID: 29435 RVA: 0x0003697C File Offset: 0x00034B7C
		public unsafe Transform EmployeeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x060072FC RID: 29436 RVA: 0x001F6BA8 File Offset: 0x001F4DA8
		// (set) Token: 0x060072FD RID: 29437 RVA: 0x0003699B File Offset: 0x00034B9B
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x060072FE RID: 29438 RVA: 0x001F6BD8 File Offset: 0x001F4DD8
		// (set) Token: 0x060072FF RID: 29439 RVA: 0x000369BA File Offset: 0x00034BBA
		public unsafe Transform InteriorSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06007300 RID: 29440 RVA: 0x001F6C08 File Offset: 0x001F4E08
		// (set) Token: 0x06007301 RID: 29441 RVA: 0x000369D9 File Offset: 0x00034BD9
		public unsafe GameObject ForSaleSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06007302 RID: 29442 RVA: 0x001F6C38 File Offset: 0x001F4E38
		// (set) Token: 0x06007303 RID: 29443 RVA: 0x000369F8 File Offset: 0x00034BF8
		public unsafe GameObject BoundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06007304 RID: 29444 RVA: 0x001F6C68 File Offset: 0x001F4E68
		// (set) Token: 0x06007305 RID: 29445 RVA: 0x00036A17 File Offset: 0x00034C17
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06007306 RID: 29446 RVA: 0x001F6C98 File Offset: 0x001F4E98
		// (set) Token: 0x06007307 RID: 29447 RVA: 0x00036A36 File Offset: 0x00034C36
		public unsafe Transform ListingPoster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x001F6CC8 File Offset: 0x001F4EC8
		// (set) Token: 0x06007309 RID: 29449 RVA: 0x00036A55 File Offset: 0x00034C55
		public unsafe Transform NPCSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x001F6CF8 File Offset: 0x001F4EF8
		// (set) Token: 0x0600730B RID: 29451 RVA: 0x00036A74 File Offset: 0x00034C74
		public unsafe Il2CppReferenceArray<Transform> EmployeeIdlePoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600730C RID: 29452 RVA: 0x001F6D28 File Offset: 0x001F4F28
		// (set) Token: 0x0600730D RID: 29453 RVA: 0x00036A93 File Offset: 0x00034C93
		public unsafe List<ModularSwitch> Switches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModularSwitch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600730E RID: 29454 RVA: 0x001F6D58 File Offset: 0x001F4F58
		// (set) Token: 0x0600730F RID: 29455 RVA: 0x00036AB2 File Offset: 0x00034CB2
		public unsafe List<InteractableToggleable> Toggleables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InteractableToggleable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06007310 RID: 29456 RVA: 0x001F6D88 File Offset: 0x001F4F88
		// (set) Token: 0x06007311 RID: 29457 RVA: 0x00036AD1 File Offset: 0x00034CD1
		public unsafe PropertyDisposalArea DisposalArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDisposalArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x06007312 RID: 29458 RVA: 0x001F6DB8 File Offset: 0x001F4FB8
		// (set) Token: 0x06007313 RID: 29459 RVA: 0x00036AF0 File Offset: 0x00034CF0
		public unsafe Il2CppReferenceArray<LoadingDock> LoadingDocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoadingDock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x06007314 RID: 29460 RVA: 0x001F6DE8 File Offset: 0x001F4FE8
		// (set) Token: 0x06007315 RID: 29461 RVA: 0x00036B0F File Offset: 0x00034D0F
		public unsafe List<BuildableItem> BuildableItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x06007316 RID: 29462 RVA: 0x001F6E18 File Offset: 0x001F5018
		// (set) Token: 0x06007317 RID: 29463 RVA: 0x00036B2E File Offset: 0x00034D2E
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06007318 RID: 29464 RVA: 0x001F6E48 File Offset: 0x001F5048
		// (set) Token: 0x06007319 RID: 29465 RVA: 0x00036B4D File Offset: 0x00034D4D
		public unsafe Il2CppReferenceArray<BoxCollider> propertyBoundsColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600731A RID: 29466 RVA: 0x001F6E78 File Offset: 0x001F5078
		// (set) Token: 0x0600731B RID: 29467 RVA: 0x00036B6C File Offset: 0x00034D6C
		public unsafe PropertyLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600731C RID: 29468 RVA: 0x001F6EA8 File Offset: 0x001F50A8
		// (set) Token: 0x0600731D RID: 29469 RVA: 0x00036B8B File Offset: 0x00034D8B
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x001F6ED8 File Offset: 0x001F50D8
		// (set) Token: 0x0600731F RID: 29471 RVA: 0x00036BAA File Offset: 0x00034DAA
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x001F6F08 File Offset: 0x001F5108
		// (set) Token: 0x06007321 RID: 29473 RVA: 0x00036BC9 File Offset: 0x00034DC9
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06007322 RID: 29474 RVA: 0x001F6F30 File Offset: 0x001F5130
		// (set) Token: 0x06007323 RID: 29475 RVA: 0x00036BE4 File Offset: 0x00034DE4
		public unsafe List<string> savedObjectPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06007324 RID: 29476 RVA: 0x001F6F60 File Offset: 0x001F5160
		// (set) Token: 0x06007325 RID: 29477 RVA: 0x00036C03 File Offset: 0x00034E03
		public unsafe List<string> savedEmployeePaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x001F6F90 File Offset: 0x001F5190
		// (set) Token: 0x06007327 RID: 29479 RVA: 0x00036C22 File Offset: 0x00034E22
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06007328 RID: 29480 RVA: 0x001F6FB8 File Offset: 0x001F51B8
		// (set) Token: 0x06007329 RID: 29481 RVA: 0x00036C3D File Offset: 0x00034E3D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004E27 RID: 20007
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04004E28 RID: 20008
		private static readonly IntPtr NativeFieldInfoPtr_UnownedProperties;

		// Token: 0x04004E29 RID: 20009
		private static readonly IntPtr NativeFieldInfoPtr_OwnedProperties;

		// Token: 0x04004E2A RID: 20010
		private static readonly IntPtr NativeFieldInfoPtr_onPropertyAcquired;

		// Token: 0x04004E2B RID: 20011
		private static readonly IntPtr NativeFieldInfoPtr_onThisPropertyAcquired;

		// Token: 0x04004E2C RID: 20012
		private static readonly IntPtr NativeFieldInfoPtr__IsOwned_k__BackingField;

		// Token: 0x04004E2D RID: 20013
		private static readonly IntPtr NativeFieldInfoPtr__Employees_k__BackingField;

		// Token: 0x04004E2E RID: 20014
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField;

		// Token: 0x04004E2F RID: 20015
		private static readonly IntPtr NativeFieldInfoPtr__IsContentCulled_k__BackingField;

		// Token: 0x04004E30 RID: 20016
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04004E31 RID: 20017
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04004E32 RID: 20018
		private static readonly IntPtr NativeFieldInfoPtr_propertyCode;

		// Token: 0x04004E33 RID: 20019
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04004E34 RID: 20020
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRotation;

		// Token: 0x04004E35 RID: 20021
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeCapacity;

		// Token: 0x04004E36 RID: 20022
		private static readonly IntPtr NativeFieldInfoPtr_OwnedByDefault;

		// Token: 0x04004E37 RID: 20023
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_SET_OWNED;

		// Token: 0x04004E38 RID: 20024
		private static readonly IntPtr NativeFieldInfoPtr_IsOwnedVariable;

		// Token: 0x04004E39 RID: 20025
		private static readonly IntPtr NativeFieldInfoPtr_ContentCullingEnabled;

		// Token: 0x04004E3A RID: 20026
		private static readonly IntPtr NativeFieldInfoPtr_MinimumCullingDistance;

		// Token: 0x04004E3B RID: 20027
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04004E3C RID: 20028
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004E3D RID: 20029
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeContainer;

		// Token: 0x04004E3E RID: 20030
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeFieldInfoPtr_InteriorSpawnPoint;

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeFieldInfoPtr_ForSaleSign;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeFieldInfoPtr_BoundingBox;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04004E43 RID: 20035
		private static readonly IntPtr NativeFieldInfoPtr_ListingPoster;

		// Token: 0x04004E44 RID: 20036
		private static readonly IntPtr NativeFieldInfoPtr_NPCSpawnPoint;

		// Token: 0x04004E45 RID: 20037
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeIdlePoints;

		// Token: 0x04004E46 RID: 20038
		private static readonly IntPtr NativeFieldInfoPtr_Switches;

		// Token: 0x04004E47 RID: 20039
		private static readonly IntPtr NativeFieldInfoPtr_Toggleables;

		// Token: 0x04004E48 RID: 20040
		private static readonly IntPtr NativeFieldInfoPtr_DisposalArea;

		// Token: 0x04004E49 RID: 20041
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDocks;

		// Token: 0x04004E4A RID: 20042
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItems;

		// Token: 0x04004E4B RID: 20043
		private static readonly IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04004E4C RID: 20044
		private static readonly IntPtr NativeFieldInfoPtr_propertyBoundsColliders;

		// Token: 0x04004E4D RID: 20045
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004E4E RID: 20046
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004E4F RID: 20047
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004E50 RID: 20048
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004E51 RID: 20049
		private static readonly IntPtr NativeFieldInfoPtr_savedObjectPaths;

		// Token: 0x04004E52 RID: 20050
		private static readonly IntPtr NativeFieldInfoPtr_savedEmployeePaths;

		// Token: 0x04004E53 RID: 20051
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004E54 RID: 20052
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004E55 RID: 20053
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0;

		// Token: 0x04004E56 RID: 20054
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004E57 RID: 20055
		private static readonly IntPtr NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0;

		// Token: 0x04004E58 RID: 20056
		private static readonly IntPtr NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0;

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0;

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0;

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004E63 RID: 20067
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E64 RID: 20068
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E65 RID: 20069
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E66 RID: 20070
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E67 RID: 20071
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E68 RID: 20072
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E69 RID: 20073
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004E6A RID: 20074
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004E6B RID: 20075
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004E6C RID: 20076
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004E6D RID: 20077
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004E6E RID: 20078
		private static readonly IntPtr NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004E72 RID: 20082
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004E73 RID: 20083
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0;

		// Token: 0x04004E74 RID: 20084
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004E75 RID: 20085
		private static readonly IntPtr NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0;

		// Token: 0x04004E76 RID: 20086
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0;

		// Token: 0x04004E77 RID: 20087
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1;

		// Token: 0x04004E78 RID: 20088
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04004E79 RID: 20089
		private static readonly IntPtr NativeMethodInfoPtr_SetOwned_Public_Void_0;

		// Token: 0x04004E7A RID: 20090
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0;

		// Token: 0x04004E7B RID: 20091
		private static readonly IntPtr NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004E7C RID: 20092
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0;

		// Token: 0x04004E7D RID: 20093
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0;

		// Token: 0x04004E7E RID: 20094
		private static readonly IntPtr NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0;

		// Token: 0x04004E7F RID: 20095
		private static readonly IntPtr NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0;

		// Token: 0x04004E80 RID: 20096
		private static readonly IntPtr NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004E81 RID: 20097
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004E82 RID: 20098
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004E83 RID: 20099
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04004E84 RID: 20100
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0;

		// Token: 0x04004E85 RID: 20101
		private static readonly IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0;

		// Token: 0x04004E86 RID: 20102
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0;

		// Token: 0x04004E87 RID: 20103
		private static readonly IntPtr NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0;

		// Token: 0x04004E88 RID: 20104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E89 RID: 20105
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0;

		// Token: 0x04004E8A RID: 20106
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04004E8B RID: 20107
		private static readonly IntPtr NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0;

		// Token: 0x04004E8C RID: 20108
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0;

		// Token: 0x04004E90 RID: 20112
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004E92 RID: 20114
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04004E93 RID: 20115
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04004E94 RID: 20116
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E95 RID: 20117
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x04004E96 RID: 20118
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x04004E97 RID: 20119
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004E98 RID: 20120
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004E9A RID: 20122
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E9B RID: 20123
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004E9C RID: 20124
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E9D RID: 20125
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A85 RID: 2693
		public sealed class PropertyChange : MulticastDelegate
		{
			// Token: 0x0600D210 RID: 53776 RVA: 0x00324430 File Offset: 0x00322630
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyChange()
			{
				Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "PropertyChange");
				Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677744);
				Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677745);
				Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677746);
				Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677747);
			}

			// Token: 0x0600D211 RID: 53777 RVA: 0x003244A4 File Offset: 0x003226A4
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81883, XrefRangeEnd = 82515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D212 RID: 53778 RVA: 0x00324500 File Offset: 0x00322700
			[CallerCount(0)]
			public unsafe void Invoke(Property property)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D213 RID: 53779 RVA: 0x00324544 File Offset: 0x00322744
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Property property, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D214 RID: 53780 RVA: 0x003245B8 File Offset: 0x003227B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D215 RID: 53781 RVA: 0x000664B6 File Offset: 0x000646B6
			public PropertyChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D216 RID: 53782 RVA: 0x000664BF File Offset: 0x000646BF
			public static implicit operator Property.PropertyChange(Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<Property.PropertyChange>(A_0);
			}

			// Token: 0x0600D217 RID: 53783 RVA: 0x000664C7 File Offset: 0x000646C7
			public static Property.PropertyChange operator +(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Property.PropertyChange>();
			}

			// Token: 0x0600D218 RID: 53784 RVA: 0x000664D5 File Offset: 0x000646D5
			public static Property.PropertyChange operator -(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Property.PropertyChange>();
				}
				return result;
			}

			// Token: 0x04008DB1 RID: 36273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008DB2 RID: 36274
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x04008DB3 RID: 36275
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x04008DB4 RID: 36276
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A86 RID: 2694
		[ObfuscatedName("ScheduleOne.Property.Property+<<RecieveOwned>g__Wait|93_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D219 RID: 53785 RVA: 0x003245FC File Offset: 0x003227FC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<<RecieveOwned>g__Wait|93_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677748);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677749);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677750);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677751);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677752);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677753);
			}

			// Token: 0x0600D21A RID: 53786 RVA: 0x003246DC File Offset: 0x003228DC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21B RID: 53787 RVA: 0x00324724 File Offset: 0x00322924
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D21C RID: 53788 RVA: 0x00324758 File Offset: 0x00322958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224391, XrefRangeEnd = 224404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004137 RID: 16695
			// (get) Token: 0x0600D21D RID: 53789 RVA: 0x00324794 File Offset: 0x00322994
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D21E RID: 53790 RVA: 0x003247D4 File Offset: 0x003229D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224404, XrefRangeEnd = 224409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004138 RID: 16696
			// (get) Token: 0x0600D21F RID: 53791 RVA: 0x00324808 File Offset: 0x00322A08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D220 RID: 53792 RVA: 0x000664E6 File Offset: 0x000646E6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004134 RID: 16692
			// (get) Token: 0x0600D221 RID: 53793 RVA: 0x00324848 File Offset: 0x00322A48
			// (set) Token: 0x0600D222 RID: 53794 RVA: 0x000664EF File Offset: 0x000646EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004135 RID: 16693
			// (get) Token: 0x0600D223 RID: 53795 RVA: 0x00324870 File Offset: 0x00322A70
			// (set) Token: 0x0600D224 RID: 53796 RVA: 0x0006650A File Offset: 0x0006470A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004136 RID: 16694
			// (get) Token: 0x0600D225 RID: 53797 RVA: 0x003248A0 File Offset: 0x00322AA0
			// (set) Token: 0x0600D226 RID: 53798 RVA: 0x00066529 File Offset: 0x00064729
			public unsafe Property __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DB5 RID: 36277
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DB6 RID: 36278
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DB7 RID: 36279
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DB8 RID: 36280
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DB9 RID: 36281
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DBA RID: 36282
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DBB RID: 36283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DBC RID: 36284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DBD RID: 36285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A87 RID: 2695
		[ObfuscatedName("ScheduleOne.Property.Property+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D227 RID: 53799 RVA: 0x003248D0 File Offset: 0x00322AD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Property.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c>.NativeClassPtr);
				Property.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9");
				Property.__c.NativeFieldInfoPtr___9__109_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9__109_0");
				Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100677755);
				Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100677756);
			}

			// Token: 0x0600D228 RID: 53800 RVA: 0x0032494C File Offset: 0x00322B4C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D229 RID: 53801 RVA: 0x00324988 File Offset: 0x00322B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224409, XrefRangeEnd = 224414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnassignedBeds_b__109_0(Bed x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D22A RID: 53802 RVA: 0x00066548 File Offset: 0x00064748
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004139 RID: 16697
			// (get) Token: 0x0600D22B RID: 53803 RVA: 0x003249D8 File Offset: 0x00322BD8
			// (set) Token: 0x0600D22C RID: 53804 RVA: 0x00066551 File Offset: 0x00064751
			public unsafe static Property.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700413A RID: 16698
			// (get) Token: 0x0600D22D RID: 53805 RVA: 0x00324A00 File Offset: 0x00322C00
			// (set) Token: 0x0600D22E RID: 53806 RVA: 0x00066563 File Offset: 0x00064763
			public unsafe static Func<Bed, bool> __9__109_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9__109_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Bed, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9__109_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DBE RID: 36286
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DBF RID: 36287
			private static readonly IntPtr NativeFieldInfoPtr___9__109_0;

			// Token: 0x04008DC0 RID: 36288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DC1 RID: 36289
			private static readonly IntPtr NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0;
		}

		// Token: 0x02000A88 RID: 2696
		[ObfuscatedName("ScheduleOne.Property.Property+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D22F RID: 53807 RVA: 0x00324A28 File Offset: 0x00322C28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr);
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "toggleable1");
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100677757);
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100677758);
			}

			// Token: 0x0600D230 RID: 53808 RVA: 0x00324AA4 File Offset: 0x00322CA4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D231 RID: 53809 RVA: 0x00324AE0 File Offset: 0x00322CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224414, XrefRangeEnd = 224429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D232 RID: 53810 RVA: 0x00066575 File Offset: 0x00064775
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413B RID: 16699
			// (get) Token: 0x0600D233 RID: 53811 RVA: 0x00324B14 File Offset: 0x00322D14
			// (set) Token: 0x0600D234 RID: 53812 RVA: 0x0006657E File Offset: 0x0006477E
			public unsafe InteractableToggleable toggleable1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableToggleable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700413C RID: 16700
			// (get) Token: 0x0600D235 RID: 53813 RVA: 0x00324B44 File Offset: 0x00322D44
			// (set) Token: 0x0600D236 RID: 53814 RVA: 0x0006659D File Offset: 0x0006479D
			public unsafe Property __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DC2 RID: 36290
			private static readonly IntPtr NativeFieldInfoPtr_toggleable1;

			// Token: 0x04008DC3 RID: 36291
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DC4 RID: 36292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DC5 RID: 36293
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}
	}
}
