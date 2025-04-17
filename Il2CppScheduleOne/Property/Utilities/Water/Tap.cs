using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000515 RID: 1301
	public class Tap : NetworkBehaviour
	{
		// Token: 0x0600738A RID: 29578 RVA: 0x001F84C0 File Offset: 0x001F66C0
		// Note: this type is marked as 'beforefieldinit'.
		static Tap()
		{
			Il2CppClassPointerStore<Tap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Water", "Tap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tap>.NativeClassPtr);
			Tap.NativeFieldInfoPtr_MaxFlowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "MaxFlowRate");
			Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "IntObj");
			Tap.NativeFieldInfoPtr_CameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "CameraPos");
			Tap.NativeFieldInfoPtr_WateringCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WateringCamPos");
			Tap.NativeFieldInfoPtr_HandleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "HandleCollider");
			Tap.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "Handle");
			Tap.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "HandleClickable");
			Tap.NativeFieldInfoPtr_WaterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WaterParticles");
			Tap.NativeFieldInfoPtr_SqueakSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "SqueakSound");
			Tap.NativeFieldInfoPtr_WaterRunningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WaterRunningSound");
			Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_tapFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "tapFlow");
			Tap.NativeFieldInfoPtr_wateringCanModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "wateringCanModel");
			Tap.NativeFieldInfoPtr_intObjSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "intObjSetThisFrame");
			Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677823);
			Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677824);
			Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677825);
			Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677826);
			Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677827);
			Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677828);
			Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677829);
			Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677830);
			Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677831);
			Tap.NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677832);
			Tap.NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677833);
			Tap.NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677834);
			Tap.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677835);
			Tap.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677836);
			Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677837);
			Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677838);
			Tap.NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677839);
			Tap.NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677840);
			Tap.NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677841);
			Tap.NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677842);
			Tap.NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677843);
			Tap.NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677844);
			Tap.NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677845);
			Tap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677846);
			Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677847);
			Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677848);
			Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677849);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677850);
			Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677851);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677852);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677853);
			Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677854);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677855);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677856);
			Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677857);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677858);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677859);
			Tap.NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677860);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677861);
			Tap.NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677862);
			Tap.NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677863);
			Tap.NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677864);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677865);
			Tap.NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677866);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677867);
			Tap.NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677868);
			Tap.NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677869);
			Tap.NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677870);
			Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677871);
			Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677872);
			Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677873);
			Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677874);
			Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677875);
			Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677876);
			Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677877);
			Tap.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677878);
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x0600738B RID: 29579 RVA: 0x001F8AF4 File Offset: 0x001F6CF4
		// (set) Token: 0x0600738C RID: 29580 RVA: 0x001F8B30 File Offset: 0x001F6D30
		public unsafe bool IsHeldOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225986, XrefRangeEnd = 225993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x0600738D RID: 29581 RVA: 0x001F8B70 File Offset: 0x001F6D70
		public unsafe float ActualFlowRate
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 225993, RefRangeEnd = 225996, XrefRangeStart = 225993, XrefRangeEnd = 225993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x0600738E RID: 29582 RVA: 0x001F8BAC File Offset: 0x001F6DAC
		// (set) Token: 0x0600738F RID: 29583 RVA: 0x001F8BEC File Offset: 0x001F6DEC
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226004, RefRangeEnd = 226006, XrefRangeStart = 225996, XrefRangeEnd = 226004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06007390 RID: 29584 RVA: 0x001F8C30 File Offset: 0x001F6E30
		// (set) Token: 0x06007391 RID: 29585 RVA: 0x001F8C70 File Offset: 0x001F6E70
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226006, XrefRangeEnd = 226014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x001F8CB4 File Offset: 0x001F6EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226014, XrefRangeEnd = 226028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x001F8CF0 File Offset: 0x001F6EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226028, XrefRangeEnd = 226046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x001F8D2C File Offset: 0x001F6F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226046, XrefRangeEnd = 226047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableObject(string message, InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x001F8D7C File Offset: 0x001F6F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226047, XrefRangeEnd = 226051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTapVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x001F8DB0 File Offset: 0x001F6FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226051, XrefRangeEnd = 226053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaterSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x001F8DE4 File Offset: 0x001F6FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226053, XrefRangeEnd = 226054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x001F8E18 File Offset: 0x001F7018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226054, XrefRangeEnd = 226068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x001F8E4C File Offset: 0x001F704C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226090, RefRangeEnd = 226092, XrefRangeStart = 226068, XrefRangeEnd = 226090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x001F8E90 File Offset: 0x001F7090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226092, XrefRangeEnd = 226114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x001F8ED4 File Offset: 0x001F70D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226136, RefRangeEnd = 226139, XrefRangeStart = 226114, XrefRangeEnd = 226136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeldOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x001F8F14 File Offset: 0x001F7114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226139, XrefRangeEnd = 226149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x001F8F5C File Offset: 0x001F715C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226171, RefRangeEnd = 226172, XrefRangeStart = 226149, XrefRangeEnd = 226171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWateringCanModel(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x001F8FA0 File Offset: 0x001F71A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226195, RefRangeEnd = 226197, XrefRangeStart = 226172, XrefRangeEnd = 226195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateWateringCanModel(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x001F8FE4 File Offset: 0x001F71E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226218, RefRangeEnd = 226219, XrefRangeStart = 226197, XrefRangeEnd = 226218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClearWateringCanModelModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x001F9018 File Offset: 0x001F7218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226240, RefRangeEnd = 226242, XrefRangeStart = 226219, XrefRangeEnd = 226240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWateringCanModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x001F904C File Offset: 0x001F724C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 226287, RefRangeEnd = 226292, XrefRangeStart = 226242, XrefRangeEnd = 226287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject CreateWateringCanModel_Local(string ID, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x001F90AC File Offset: 0x001F72AC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x001F90E8 File Offset: 0x001F72E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226292, XrefRangeEnd = 226368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x001F9124 File Offset: 0x001F7324
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x001F9160 File Offset: 0x001F7360
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x001F919C File Offset: 0x001F739C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226368, XrefRangeEnd = 226387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x001F91E0 File Offset: 0x001F73E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226411, RefRangeEnd = 226413, XrefRangeStart = 226387, XrefRangeEnd = 226411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x001F9224 File Offset: 0x001F7424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226413, XrefRangeEnd = 226417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x001F9288 File Offset: 0x001F7488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226417, XrefRangeEnd = 226436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x001F92CC File Offset: 0x001F74CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226004, RefRangeEnd = 226006, XrefRangeStart = 226004, XrefRangeEnd = 226006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x001F9310 File Offset: 0x001F7510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226436, XrefRangeEnd = 226440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x001F9374 File Offset: 0x001F7574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226440, XrefRangeEnd = 226459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x001F93B4 File Offset: 0x001F75B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226466, RefRangeEnd = 226468, XrefRangeStart = 226459, XrefRangeEnd = 226466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x001F93F4 File Offset: 0x001F75F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226468, XrefRangeEnd = 226471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x001F9458 File Offset: 0x001F7658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226471, XrefRangeEnd = 226490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x001F949C File Offset: 0x001F769C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226195, RefRangeEnd = 226197, XrefRangeStart = 226195, XrefRangeEnd = 226197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x001F94E0 File Offset: 0x001F76E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226490, XrefRangeEnd = 226494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x001F9544 File Offset: 0x001F7744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226494, XrefRangeEnd = 226513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x001F9588 File Offset: 0x001F7788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226513, XrefRangeEnd = 226515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x001F95CC File Offset: 0x001F77CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226515, XrefRangeEnd = 226520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x001F961C File Offset: 0x001F781C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226520, XrefRangeEnd = 226538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClearWateringCanModelModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x001F9650 File Offset: 0x001F7850
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226240, RefRangeEnd = 226242, XrefRangeStart = 226240, XrefRangeEnd = 226242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClearWateringCanModelModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x001F9684 File Offset: 0x001F7884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226538, XrefRangeEnd = 226541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClearWateringCanModelModel_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x001F96E8 File Offset: 0x001F78E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226541, XrefRangeEnd = 226559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWateringCanModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x001F971C File Offset: 0x001F791C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226567, RefRangeEnd = 226570, XrefRangeStart = 226559, XrefRangeEnd = 226567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWateringCanModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x001F9750 File Offset: 0x001F7950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226570, XrefRangeEnd = 226573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWateringCanModel_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060073BB RID: 29627 RVA: 0x001F97A0 File Offset: 0x001F79A0
		// (set) Token: 0x060073BC RID: 29628 RVA: 0x001F97DC File Offset: 0x001F79DC
		public unsafe bool SyncAccessor_<IsHeldOpen>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226581, RefRangeEnd = 226583, XrefRangeStart = 226573, XrefRangeEnd = 226581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x001F9828 File Offset: 0x001F7A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226583, XrefRangeEnd = 226602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x001F989C File Offset: 0x001F7A9C
		// (set) Token: 0x060073BF RID: 29631 RVA: 0x001F98DC File Offset: 0x001F7ADC
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226611, RefRangeEnd = 226613, XrefRangeStart = 226602, XrefRangeEnd = 226611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x060073C0 RID: 29632 RVA: 0x001F992C File Offset: 0x001F7B2C
		// (set) Token: 0x060073C1 RID: 29633 RVA: 0x001F996C File Offset: 0x001F7B6C
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226622, RefRangeEnd = 226623, XrefRangeStart = 226613, XrefRangeEnd = 226622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x001F99BC File Offset: 0x001F7BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226623, XrefRangeEnd = 226637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00036EBF File Offset: 0x000350BF
		public Tap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x001F99F0 File Offset: 0x001F7BF0
		// (set) Token: 0x060073C5 RID: 29637 RVA: 0x00036EC8 File Offset: 0x000350C8
		public unsafe static float MaxFlowRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tap.NativeFieldInfoPtr_MaxFlowRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tap.NativeFieldInfoPtr_MaxFlowRate, (void*)(&value));
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x060073C6 RID: 29638 RVA: 0x001F9A0C File Offset: 0x001F7C0C
		// (set) Token: 0x060073C7 RID: 29639 RVA: 0x00036ED6 File Offset: 0x000350D6
		public unsafe bool _IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x060073C8 RID: 29640 RVA: 0x001F9A34 File Offset: 0x001F7C34
		// (set) Token: 0x060073C9 RID: 29641 RVA: 0x00036EF1 File Offset: 0x000350F1
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x060073CA RID: 29642 RVA: 0x001F9A64 File Offset: 0x001F7C64
		// (set) Token: 0x060073CB RID: 29643 RVA: 0x00036F10 File Offset: 0x00035110
		public unsafe Transform CameraPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_CameraPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_CameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x060073CC RID: 29644 RVA: 0x001F9A94 File Offset: 0x001F7C94
		// (set) Token: 0x060073CD RID: 29645 RVA: 0x00036F2F File Offset: 0x0003512F
		public unsafe Transform WateringCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WateringCamPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WateringCamPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x001F9AC4 File Offset: 0x001F7CC4
		// (set) Token: 0x060073CF RID: 29647 RVA: 0x00036F4E File Offset: 0x0003514E
		public unsafe Collider HandleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x060073D0 RID: 29648 RVA: 0x001F9AF4 File Offset: 0x001F7CF4
		// (set) Token: 0x060073D1 RID: 29649 RVA: 0x00036F6D File Offset: 0x0003516D
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x001F9B24 File Offset: 0x001F7D24
		// (set) Token: 0x060073D3 RID: 29651 RVA: 0x00036F8C File Offset: 0x0003518C
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x060073D4 RID: 29652 RVA: 0x001F9B54 File Offset: 0x001F7D54
		// (set) Token: 0x060073D5 RID: 29653 RVA: 0x00036FAB File Offset: 0x000351AB
		public unsafe ParticleSystem WaterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x001F9B84 File Offset: 0x001F7D84
		// (set) Token: 0x060073D7 RID: 29655 RVA: 0x00036FCA File Offset: 0x000351CA
		public unsafe AudioSourceController SqueakSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_SqueakSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_SqueakSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x001F9BB4 File Offset: 0x001F7DB4
		// (set) Token: 0x060073D9 RID: 29657 RVA: 0x00036FE9 File Offset: 0x000351E9
		public unsafe AudioSourceController WaterRunningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterRunningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterRunningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x060073DA RID: 29658 RVA: 0x001F9BE4 File Offset: 0x001F7DE4
		// (set) Token: 0x060073DB RID: 29659 RVA: 0x00037008 File Offset: 0x00035208
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x060073DC RID: 29660 RVA: 0x001F9C14 File Offset: 0x001F7E14
		// (set) Token: 0x060073DD RID: 29661 RVA: 0x00037027 File Offset: 0x00035227
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x001F9C44 File Offset: 0x001F7E44
		// (set) Token: 0x060073DF RID: 29663 RVA: 0x00037046 File Offset: 0x00035246
		public unsafe float tapFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_tapFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_tapFlow)) = value;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x060073E0 RID: 29664 RVA: 0x001F9C6C File Offset: 0x001F7E6C
		// (set) Token: 0x060073E1 RID: 29665 RVA: 0x00037061 File Offset: 0x00035261
		public unsafe GameObject wateringCanModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_wateringCanModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_wateringCanModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x001F9C9C File Offset: 0x001F7E9C
		// (set) Token: 0x060073E3 RID: 29667 RVA: 0x00037080 File Offset: 0x00035280
		public unsafe bool intObjSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_intObjSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_intObjSetThisFrame)) = value;
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x001F9CC4 File Offset: 0x001F7EC4
		// (set) Token: 0x060073E5 RID: 29669 RVA: 0x0003709B File Offset: 0x0003529B
		public unsafe SyncVar<bool> syncVar____IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x001F9CF4 File Offset: 0x001F7EF4
		// (set) Token: 0x060073E7 RID: 29671 RVA: 0x000370BA File Offset: 0x000352BA
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x001F9D24 File Offset: 0x001F7F24
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x000370D9 File Offset: 0x000352D9
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x001F9D54 File Offset: 0x001F7F54
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x000370F8 File Offset: 0x000352F8
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x001F9D7C File Offset: 0x001F7F7C
		// (set) Token: 0x060073ED RID: 29677 RVA: 0x00037113 File Offset: 0x00035313
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004EDF RID: 20191
		private static readonly IntPtr NativeFieldInfoPtr_MaxFlowRate;

		// Token: 0x04004EE0 RID: 20192
		private static readonly IntPtr NativeFieldInfoPtr__IsHeldOpen_k__BackingField;

		// Token: 0x04004EE1 RID: 20193
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004EE2 RID: 20194
		private static readonly IntPtr NativeFieldInfoPtr_CameraPos;

		// Token: 0x04004EE3 RID: 20195
		private static readonly IntPtr NativeFieldInfoPtr_WateringCamPos;

		// Token: 0x04004EE4 RID: 20196
		private static readonly IntPtr NativeFieldInfoPtr_HandleCollider;

		// Token: 0x04004EE5 RID: 20197
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04004EE6 RID: 20198
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04004EE7 RID: 20199
		private static readonly IntPtr NativeFieldInfoPtr_WaterParticles;

		// Token: 0x04004EE8 RID: 20200
		private static readonly IntPtr NativeFieldInfoPtr_SqueakSound;

		// Token: 0x04004EE9 RID: 20201
		private static readonly IntPtr NativeFieldInfoPtr_WaterRunningSound;

		// Token: 0x04004EEA RID: 20202
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04004EEB RID: 20203
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04004EEC RID: 20204
		private static readonly IntPtr NativeFieldInfoPtr_tapFlow;

		// Token: 0x04004EED RID: 20205
		private static readonly IntPtr NativeFieldInfoPtr_wateringCanModel;

		// Token: 0x04004EEE RID: 20206
		private static readonly IntPtr NativeFieldInfoPtr_intObjSetThisFrame;

		// Token: 0x04004EEF RID: 20207
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField;

		// Token: 0x04004EF0 RID: 20208
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04004EF1 RID: 20209
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04004EF2 RID: 20210
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004EF3 RID: 20211
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004EF4 RID: 20212
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0;

		// Token: 0x04004EF5 RID: 20213
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0;

		// Token: 0x04004EF6 RID: 20214
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0;

		// Token: 0x04004EF7 RID: 20215
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004EF8 RID: 20216
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004EF9 RID: 20217
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004EFA RID: 20218
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004EFB RID: 20219
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004EFC RID: 20220
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004EFD RID: 20221
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0;

		// Token: 0x04004EFE RID: 20222
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0;

		// Token: 0x04004EFF RID: 20223
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0;

		// Token: 0x04004F00 RID: 20224
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04004F01 RID: 20225
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04004F02 RID: 20226
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F03 RID: 20227
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F04 RID: 20228
		private static readonly IntPtr NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0;

		// Token: 0x04004F05 RID: 20229
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004F06 RID: 20230
		private static readonly IntPtr NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0;

		// Token: 0x04004F07 RID: 20231
		private static readonly IntPtr NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0;

		// Token: 0x04004F08 RID: 20232
		private static readonly IntPtr NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0;

		// Token: 0x04004F09 RID: 20233
		private static readonly IntPtr NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0;

		// Token: 0x04004F0A RID: 20234
		private static readonly IntPtr NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0;

		// Token: 0x04004F0B RID: 20235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F0C RID: 20236
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F0D RID: 20237
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F0E RID: 20238
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F0F RID: 20239
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004F10 RID: 20240
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F11 RID: 20241
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F12 RID: 20242
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004F13 RID: 20243
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F14 RID: 20244
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F15 RID: 20245
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004F16 RID: 20246
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004F17 RID: 20247
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F18 RID: 20248
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F19 RID: 20249
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0;

		// Token: 0x04004F1A RID: 20250
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F1B RID: 20251
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F1C RID: 20252
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F1D RID: 20253
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F1E RID: 20254
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0;

		// Token: 0x04004F1F RID: 20255
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0;

		// Token: 0x04004F20 RID: 20256
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F21 RID: 20257
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0;

		// Token: 0x04004F22 RID: 20258
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0;

		// Token: 0x04004F23 RID: 20259
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F24 RID: 20260
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004F25 RID: 20261
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004F26 RID: 20262
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004F27 RID: 20263
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04004F28 RID: 20264
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04004F29 RID: 20265
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04004F2A RID: 20266
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04004F2B RID: 20267
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
