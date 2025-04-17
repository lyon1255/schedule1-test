using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FC RID: 1020
	public class BuildableItem : NetworkBehaviour
	{
		// Token: 0x060054F2 RID: 21746 RVA: 0x0018D57C File Offset: 0x0018B77C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItem()
		{
			Il2CppClassPointerStore<BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr);
			BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ItemInstance>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ParentProperty>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<Initialized>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<GUID>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsCulled>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "isGhost");
			BuildableItem.NativeFieldInfoPtr_buildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "buildHandler");
			BuildableItem.NativeFieldInfoPtr_HoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "HoldDistance");
			BuildableItem.NativeFieldInfoPtr_BuildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BuildPoint");
			BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MidAirCenterPoint");
			BuildableItem.NativeFieldInfoPtr_BoundingCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BoundingCollider");
			BuildableItem.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineRenderers");
			BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "IncludeOutlineRendererChildren");
			BuildableItem.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineEffect");
			BuildableItem.NativeFieldInfoPtr_GameObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "GameObjectsToCull");
			BuildableItem.NativeFieldInfoPtr_MeshesToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MeshesToCull");
			BuildableItem.NativeFieldInfoPtr_onInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onInitialized");
			BuildableItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyed");
			BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyedWithParameter");
			BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocallyBuilt>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673855);
			BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673856);
			BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673857);
			BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673858);
			BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673859);
			BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673860);
			BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673861);
			BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673862);
			BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673863);
			BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673864);
			BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673865);
			BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673866);
			BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673867);
			BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673868);
			BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673869);
			BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673870);
			BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673871);
			BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673872);
			BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673873);
			BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673874);
			BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673875);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673876);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673877);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673878);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673879);
			BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673880);
			BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673881);
			BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673882);
			BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673883);
			BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673884);
			BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673885);
			BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673886);
			BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673887);
			BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673888);
			BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673889);
			BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673890);
			BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673891);
			BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673892);
			BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673893);
			BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673894);
			BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673895);
			BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673896);
			BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673897);
			BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673898);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673899);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673900);
			BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673901);
			BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673902);
			BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673903);
			BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673904);
			BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673905);
			BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673906);
			BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673907);
			BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673908);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673909);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673910);
			BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673911);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673912);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673913);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673914);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673915);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673916);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673917);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673918);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673919);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673920);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673921);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673922);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673923);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673924);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673925);
			BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673926);
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x0018DD54 File Offset: 0x0018BF54
		// (set) Token: 0x060054F4 RID: 21748 RVA: 0x0018DD94 File Offset: 0x0018BF94
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180301, XrefRangeEnd = 180302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x0018DDD8 File Offset: 0x0018BFD8
		// (set) Token: 0x060054F6 RID: 21750 RVA: 0x0018DE18 File Offset: 0x0018C018
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x0018DE5C File Offset: 0x0018C05C
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x0018DE98 File Offset: 0x0018C098
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x0018DED8 File Offset: 0x0018C0D8
		// (set) Token: 0x060054FA RID: 21754 RVA: 0x0018DF14 File Offset: 0x0018C114
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x0018DF54 File Offset: 0x0018C154
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x0018DF90 File Offset: 0x0018C190
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x0018DFD0 File Offset: 0x0018C1D0
		// (set) Token: 0x060054FE RID: 21758 RVA: 0x0018E00C File Offset: 0x0018C20C
		public unsafe bool IsCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x0018E04C File Offset: 0x0018C24C
		public unsafe GameObject BuildHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x0018E08C File Offset: 0x0018C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180302, XrefRangeEnd = 180331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x0018E0C0 File Offset: 0x0018C2C0
		// (set) Token: 0x06005502 RID: 21762 RVA: 0x0018E0FC File Offset: 0x0018C2FC
		public unsafe bool LocallyBuilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x0018E13C File Offset: 0x0018C33C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180331, RefRangeEnd = 180334, XrefRangeStart = 180331, XrefRangeEnd = 180331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocallyBuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06005504 RID: 21764 RVA: 0x0018E170 File Offset: 0x0018C370
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180339, RefRangeEnd = 180340, XrefRangeStart = 180334, XrefRangeEnd = 180339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x0018E1A8 File Offset: 0x0018C3A8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180340, XrefRangeEnd = 180342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06005506 RID: 21766 RVA: 0x0018E1E0 File Offset: 0x0018C3E0
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x0018E220 File Offset: 0x0018C420
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x0018E25C File Offset: 0x0018C45C
		// (set) Token: 0x06005509 RID: 21769 RVA: 0x0018E29C File Offset: 0x0018C49C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180342, XrefRangeEnd = 180343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x0018E2E0 File Offset: 0x0018C4E0
		// (set) Token: 0x0600550B RID: 21771 RVA: 0x0018E320 File Offset: 0x0018C520
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180343, XrefRangeEnd = 180344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x0018E364 File Offset: 0x0018C564
		// (set) Token: 0x0600550D RID: 21773 RVA: 0x0018E3A0 File Offset: 0x0018C5A0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x0018E3E0 File Offset: 0x0018C5E0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x0018E41C File Offset: 0x0018C61C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 180359, RefRangeEnd = 180366, XrefRangeStart = 180344, XrefRangeEnd = 180359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x0018E458 File Offset: 0x0018C658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180380, RefRangeEnd = 180381, XrefRangeStart = 180366, XrefRangeEnd = 180380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x0018E4B4 File Offset: 0x0018C6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180381, XrefRangeEnd = 180387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x0018E4F0 File Offset: 0x0018C6F0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 180389, RefRangeEnd = 180399, XrefRangeStart = 180387, XrefRangeEnd = 180389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x0018E540 File Offset: 0x0018C740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180399, XrefRangeEnd = 180407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x0018E590 File Offset: 0x0018C790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180407, XrefRangeEnd = 180419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x0018E5F8 File Offset: 0x0018C7F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180454, RefRangeEnd = 180457, XrefRangeStart = 180419, XrefRangeEnd = 180454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x0018E674 File Offset: 0x0018C874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180538, RefRangeEnd = 180541, XrefRangeStart = 180457, XrefRangeEnd = 180538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x0018E6E8 File Offset: 0x0018C8E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180550, RefRangeEnd = 180552, XrefRangeStart = 180541, XrefRangeEnd = 180550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBePickedUp(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x0018E740 File Offset: 0x0018C940
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 180555, RefRangeEnd = 180568, XrefRangeStart = 180552, XrefRangeEnd = 180555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x0018E7A4 File Offset: 0x0018C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180568, XrefRangeEnd = 180578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PickupItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0018E7E0 File Offset: 0x0018C9E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180607, RefRangeEnd = 180609, XrefRangeStart = 180578, XrefRangeEnd = 180607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0018E82C File Offset: 0x0018CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180609, XrefRangeEnd = 180627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x0018E860 File Offset: 0x0018CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180627, XrefRangeEnd = 180645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyItemWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x0018E894 File Offset: 0x0018CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180645, XrefRangeEnd = 180649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x0018E8D4 File Offset: 0x0018CAD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180649, RefRangeEnd = 180654, XrefRangeStart = 180649, XrefRangeEnd = 180649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x0018E914 File Offset: 0x0018CB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180711, RefRangeEnd = 180712, XrefRangeStart = 180654, XrefRangeEnd = 180711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x0018E960 File Offset: 0x0018CB60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 180715, RefRangeEnd = 180719, XrefRangeStart = 180712, XrefRangeEnd = 180715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x0018E9A0 File Offset: 0x0018CBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180728, RefRangeEnd = 180729, XrefRangeStart = 180719, XrefRangeEnd = 180728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0018E9DC File Offset: 0x0018CBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180729, XrefRangeEnd = 180808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0018EA28 File Offset: 0x0018CC28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 180999, RefRangeEnd = 181005, XrefRangeStart = 180808, XrefRangeEnd = 180999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPenetration(out float x, out float z, out float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x0018EA90 File Offset: 0x0018CC90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181034, RefRangeEnd = 181040, XrefRangeStart = 181005, XrefRangeEnd = 181034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0018EADC File Offset: 0x0018CCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181040, XrefRangeEnd = 181064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0018EB28 File Offset: 0x0018CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181064, XrefRangeEnd = 181069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0018EB6C File Offset: 0x0018CD6C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 181075, RefRangeEnd = 181091, XrefRangeStart = 181069, XrefRangeEnd = 181075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x0018EBC8 File Offset: 0x0018CDC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 181111, RefRangeEnd = 181115, XrefRangeStart = 181091, XrefRangeEnd = 181111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x0018EC04 File Offset: 0x0018CE04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 181147, RefRangeEnd = 181151, XrefRangeStart = 181115, XrefRangeEnd = 181147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x0018EC40 File Offset: 0x0018CE40
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x0018EC7C File Offset: 0x0018CE7C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x0018ECB8 File Offset: 0x0018CEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x0018ED20 File Offset: 0x0018CF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181151, XrefRangeEnd = 181152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x0018ED88 File Offset: 0x0018CF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181152, XrefRangeEnd = 181157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x0018EDEC File Offset: 0x0018CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181157, XrefRangeEnd = 181178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x0018EE68 File Offset: 0x0018D068
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0018EEE4 File Offset: 0x0018D0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181178, XrefRangeEnd = 181182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x0018EF34 File Offset: 0x0018D134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181182, XrefRangeEnd = 181194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0018EFB0 File Offset: 0x0018D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181194, XrefRangeEnd = 181199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x0018F000 File Offset: 0x0018D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x0018F034 File Offset: 0x0018D234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181199, XrefRangeEnd = 181222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x0018F068 File Offset: 0x0018D268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181222, XrefRangeEnd = 181246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x0018F0CC File Offset: 0x0018D2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x0018F100 File Offset: 0x0018D300
		[CallerCount(0)]
		public unsafe void RpcLogic___DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x0018F134 File Offset: 0x0018D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181246, XrefRangeEnd = 181247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x0018F184 File Offset: 0x0018D384
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00028C56 File Offset: 0x00026E56
		public BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600553C RID: 21820 RVA: 0x0018F1C0 File Offset: 0x0018D3C0
		// (set) Token: 0x0600553D RID: 21821 RVA: 0x00028C5F File Offset: 0x00026E5F
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x0018F1F0 File Offset: 0x0018D3F0
		// (set) Token: 0x0600553F RID: 21823 RVA: 0x00028C7E File Offset: 0x00026E7E
		public unsafe Property _ParentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x0018F220 File Offset: 0x0018D420
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x00028C9D File Offset: 0x00026E9D
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x0018F248 File Offset: 0x0018D448
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x00028CB8 File Offset: 0x00026EB8
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x0018F270 File Offset: 0x0018D470
		// (set) Token: 0x06005545 RID: 21829 RVA: 0x00028CD3 File Offset: 0x00026ED3
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x0018F298 File Offset: 0x0018D498
		// (set) Token: 0x06005547 RID: 21831 RVA: 0x00028CEE File Offset: 0x00026EEE
		public unsafe bool _IsCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x0018F2C0 File Offset: 0x0018D4C0
		// (set) Token: 0x06005549 RID: 21833 RVA: 0x00028D09 File Offset: 0x00026F09
		public unsafe bool isGhost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600554A RID: 21834 RVA: 0x0018F2E8 File Offset: 0x0018D4E8
		// (set) Token: 0x0600554B RID: 21835 RVA: 0x00028D24 File Offset: 0x00026F24
		public unsafe GameObject buildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600554C RID: 21836 RVA: 0x0018F318 File Offset: 0x0018D518
		// (set) Token: 0x0600554D RID: 21837 RVA: 0x00028D43 File Offset: 0x00026F43
		public unsafe float HoldDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance)) = value;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x0018F340 File Offset: 0x0018D540
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x00028D5E File Offset: 0x00026F5E
		public unsafe Transform BuildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x0018F370 File Offset: 0x0018D570
		// (set) Token: 0x06005551 RID: 21841 RVA: 0x00028D7D File Offset: 0x00026F7D
		public unsafe Transform MidAirCenterPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x0018F3A0 File Offset: 0x0018D5A0
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x00028D9C File Offset: 0x00026F9C
		public unsafe BoxCollider BoundingCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x0018F3D0 File Offset: 0x0018D5D0
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x00028DBB File Offset: 0x00026FBB
		public unsafe List<GameObject> OutlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x0018F400 File Offset: 0x0018D600
		// (set) Token: 0x06005557 RID: 21847 RVA: 0x00028DDA File Offset: 0x00026FDA
		public unsafe bool IncludeOutlineRendererChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren)) = value;
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x0018F428 File Offset: 0x0018D628
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x00028DF5 File Offset: 0x00026FF5
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x0018F458 File Offset: 0x0018D658
		// (set) Token: 0x0600555B RID: 21851 RVA: 0x00028E14 File Offset: 0x00027014
		public unsafe Il2CppReferenceArray<GameObject> GameObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x0018F488 File Offset: 0x0018D688
		// (set) Token: 0x0600555D RID: 21853 RVA: 0x00028E33 File Offset: 0x00027033
		public unsafe List<MeshRenderer> MeshesToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x0018F4B8 File Offset: 0x0018D6B8
		// (set) Token: 0x0600555F RID: 21855 RVA: 0x00028E52 File Offset: 0x00027052
		public unsafe UnityEvent onInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x0018F4E8 File Offset: 0x0018D6E8
		// (set) Token: 0x06005561 RID: 21857 RVA: 0x00028E71 File Offset: 0x00027071
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x0018F518 File Offset: 0x0018D718
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x00028E90 File Offset: 0x00027090
		public unsafe Action<BuildableItem> onDestroyedWithParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x0018F548 File Offset: 0x0018D748
		// (set) Token: 0x06005565 RID: 21861 RVA: 0x00028EAF File Offset: 0x000270AF
		public unsafe bool _LocallyBuilt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField)) = value;
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x06005566 RID: 21862 RVA: 0x0018F570 File Offset: 0x0018D770
		// (set) Token: 0x06005567 RID: 21863 RVA: 0x00028ECA File Offset: 0x000270CA
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x0018F5A0 File Offset: 0x0018D7A0
		// (set) Token: 0x06005569 RID: 21865 RVA: 0x00028EE9 File Offset: 0x000270E9
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x0018F5D0 File Offset: 0x0018D7D0
		// (set) Token: 0x0600556B RID: 21867 RVA: 0x00028F08 File Offset: 0x00027108
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600556C RID: 21868 RVA: 0x0018F5F8 File Offset: 0x0018D7F8
		// (set) Token: 0x0600556D RID: 21869 RVA: 0x00028F23 File Offset: 0x00027123
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x0018F620 File Offset: 0x0018D820
		// (set) Token: 0x0600556F RID: 21871 RVA: 0x00028F3E File Offset: 0x0002713E
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400397C RID: 14716
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x0400397D RID: 14717
		private static readonly IntPtr NativeFieldInfoPtr__ParentProperty_k__BackingField;

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003981 RID: 14721
		private static readonly IntPtr NativeFieldInfoPtr__IsCulled_k__BackingField;

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeFieldInfoPtr_buildHandler;

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeFieldInfoPtr_HoldDistance;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeFieldInfoPtr_BuildPoint;

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeFieldInfoPtr_MidAirCenterPoint;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeFieldInfoPtr_BoundingCollider;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeFieldInfoPtr_IncludeOutlineRendererChildren;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeFieldInfoPtr_GameObjectsToCull;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeFieldInfoPtr_MeshesToCull;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeFieldInfoPtr_onInitialized;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyedWithParameter;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeFieldInfoPtr__LocallyBuilt_k__BackingField;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_AddChildMeshes_Public_Void_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0;

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0;

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039CC RID: 14796
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040039CD RID: 14797
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039D7 RID: 14807
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040039D8 RID: 14808
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040039D9 RID: 14809
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039DA RID: 14810
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x040039DB RID: 14811
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x040039DC RID: 14812
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039DD RID: 14813
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009B9 RID: 2489
		[OriginalName("Assembly-CSharp.dll", "", "EOutlineColor")]
		public enum EOutlineColor
		{
			// Token: 0x040089F0 RID: 35312
			White,
			// Token: 0x040089F1 RID: 35313
			Blue,
			// Token: 0x040089F2 RID: 35314
			LightBlue
		}

		// Token: 0x020009BA RID: 2490
		[ObfuscatedName("ScheduleOne.EntityFramework.BuildableItem+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC0B RID: 52235 RVA: 0x0031394C File Offset: 0x00311B4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr);
				BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, "parentPropertyCode");
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673927);
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673928);
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673929);
			}

			// Token: 0x0600CC0C RID: 52236 RVA: 0x003139C8 File Offset: 0x00311BC8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC0D RID: 52237 RVA: 0x00313A04 File Offset: 0x00311C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180299, XrefRangeEnd = 180301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC0E RID: 52238 RVA: 0x00313A54 File Offset: 0x00311C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__1(Business b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC0F RID: 52239 RVA: 0x00063426 File Offset: 0x00061626
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F92 RID: 16274
			// (get) Token: 0x0600CC10 RID: 52240 RVA: 0x00313AA4 File Offset: 0x00311CA4
			// (set) Token: 0x0600CC11 RID: 52241 RVA: 0x0006342F File Offset: 0x0006162F
			public unsafe string parentPropertyCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089F3 RID: 35315
			private static readonly IntPtr NativeFieldInfoPtr_parentPropertyCode;

			// Token: 0x040089F4 RID: 35316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089F5 RID: 35317
			private static readonly IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0;

			// Token: 0x040089F6 RID: 35318
			private static readonly IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0;
		}
	}
}
