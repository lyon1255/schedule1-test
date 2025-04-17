using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Phone.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200047A RID: 1146
	public class DeliveryManager : NetworkSingleton<DeliveryManager>
	{
		// Token: 0x0600630B RID: 25355 RVA: 0x001C1760 File Offset: 0x001BF960
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryManager()
		{
			Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr);
			DeliveryManager.NativeFieldInfoPtr_Deliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "Deliveries");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCreated");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "loader");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr_writtenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "writtenVehicles");
			DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "minsSinceVehicleEmpty");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675843);
			DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675844);
			DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675845);
			DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675846);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675847);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675848);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675849);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675850);
			DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675851);
			DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675852);
			DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675853);
			DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675854);
			DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675855);
			DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675856);
			DeliveryManager.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675857);
			DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675858);
			DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675859);
			DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675860);
			DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675861);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675862);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675863);
			DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675864);
			DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675865);
			DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675866);
			DeliveryManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675867);
			DeliveryManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675868);
			DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675869);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675870);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675871);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675872);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675873);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675874);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675875);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675876);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675877);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675878);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675879);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675880);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675881);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675882);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675883);
			DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675884);
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x001C1BB4 File Offset: 0x001BFDB4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202755, XrefRangeEnd = 202757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x001C1BEC File Offset: 0x001BFDEC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202757, XrefRangeEnd = 202759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x001C1C24 File Offset: 0x001BFE24
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x001C1C64 File Offset: 0x001BFE64
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x001C1CA0 File Offset: 0x001BFEA0
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x001C1CE0 File Offset: 0x001BFEE0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x001C1D24 File Offset: 0x001BFF24
		// (set) Token: 0x06006313 RID: 25363 RVA: 0x001C1D64 File Offset: 0x001BFF64
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x001C1DA8 File Offset: 0x001BFFA8
		// (set) Token: 0x06006315 RID: 25365 RVA: 0x001C1DE4 File Offset: 0x001BFFE4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x001C1E24 File Offset: 0x001C0024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202759, XrefRangeEnd = 202762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x001C1E60 File Offset: 0x001C0060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202762, XrefRangeEnd = 202783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x001C1E9C File Offset: 0x001C009C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202783, XrefRangeEnd = 202789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x001C1ED8 File Offset: 0x001C00D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202789, XrefRangeEnd = 202824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x001C1F28 File Offset: 0x001C0128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202824, XrefRangeEnd = 202870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x001C1F5C File Offset: 0x001C015C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202874, RefRangeEnd = 202875, XrefRangeStart = 202870, XrefRangeEnd = 202874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x001C1FB8 File Offset: 0x001C01B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202894, RefRangeEnd = 202896, XrefRangeStart = 202875, XrefRangeEnd = 202894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDelivery(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x001C1FFC File Offset: 0x001C01FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202927, RefRangeEnd = 202929, XrefRangeStart = 202896, XrefRangeEnd = 202927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x001C2050 File Offset: 0x001C0250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202929, XrefRangeEnd = 202931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x001C20A0 File Offset: 0x001C02A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 202946, RefRangeEnd = 202950, XrefRangeStart = 202931, XrefRangeEnd = 202946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(string deliveryID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x001C20F0 File Offset: 0x001C02F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202950, XrefRangeEnd = 202965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(Property destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x001C2140 File Offset: 0x001C0340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202980, RefRangeEnd = 202982, XrefRangeStart = 202965, XrefRangeEnd = 202980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x001C2190 File Offset: 0x001C0390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202982, XrefRangeEnd = 203001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface GetShopInterface(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x001C21E0 File Offset: 0x001C03E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203001, XrefRangeEnd = 203009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x001C2224 File Offset: 0x001C0424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203009, XrefRangeEnd = 203051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x001C2280 File Offset: 0x001C0480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203051, XrefRangeEnd = 203069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x001C22D0 File Offset: 0x001C04D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203069, XrefRangeEnd = 203117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x001C230C File Offset: 0x001C050C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203117, XrefRangeEnd = 203146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x001C2348 File Offset: 0x001C0548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203146, XrefRangeEnd = 203149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x001C2384 File Offset: 0x001C0584
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x001C23C0 File Offset: 0x001C05C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202894, RefRangeEnd = 202896, XrefRangeStart = 202894, XrefRangeEnd = 202896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x001C2404 File Offset: 0x001C0604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203149, XrefRangeEnd = 203150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x001C2448 File Offset: 0x001C0648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203150, XrefRangeEnd = 203153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x001C24AC File Offset: 0x001C06AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203153, XrefRangeEnd = 203172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x001C2500 File Offset: 0x001C0700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203182, RefRangeEnd = 203184, XrefRangeStart = 203172, XrefRangeEnd = 203182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x001C2554 File Offset: 0x001C0754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203184, XrefRangeEnd = 203187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x001C25A4 File Offset: 0x001C07A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203187, XrefRangeEnd = 203206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x001C25F8 File Offset: 0x001C07F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203206, XrefRangeEnd = 203210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x001C2648 File Offset: 0x001C0848
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 203240, RefRangeEnd = 203244, XrefRangeStart = 203210, XrefRangeEnd = 203240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x001C2698 File Offset: 0x001C0898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 203252, RefRangeEnd = 203255, XrefRangeStart = 203244, XrefRangeEnd = 203252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x001C26E8 File Offset: 0x001C08E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203255, XrefRangeEnd = 203260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x001C2738 File Offset: 0x001C0938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203260, XrefRangeEnd = 203263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		public DeliveryManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x001C2774 File Offset: 0x001C0974
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x0002EDB9 File Offset: 0x0002CFB9
		public unsafe List<DeliveryInstance> Deliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x001C27A4 File Offset: 0x001C09A4
		// (set) Token: 0x0600633A RID: 25402 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		public unsafe UnityEvent<DeliveryInstance> onDeliveryCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600633B RID: 25403 RVA: 0x001C27D4 File Offset: 0x001C09D4
		// (set) Token: 0x0600633C RID: 25404 RVA: 0x0002EDF7 File Offset: 0x0002CFF7
		public unsafe UnityEvent<DeliveryInstance> onDeliveryCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x001C2804 File Offset: 0x001C0A04
		// (set) Token: 0x0600633E RID: 25406 RVA: 0x0002EE16 File Offset: 0x0002D016
		public unsafe DeliveriesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveriesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600633F RID: 25407 RVA: 0x001C2834 File Offset: 0x001C0A34
		// (set) Token: 0x06006340 RID: 25408 RVA: 0x0002EE35 File Offset: 0x0002D035
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06006341 RID: 25409 RVA: 0x001C2864 File Offset: 0x001C0A64
		// (set) Token: 0x06006342 RID: 25410 RVA: 0x0002EE54 File Offset: 0x0002D054
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06006343 RID: 25411 RVA: 0x001C2894 File Offset: 0x001C0A94
		// (set) Token: 0x06006344 RID: 25412 RVA: 0x0002EE73 File Offset: 0x0002D073
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06006345 RID: 25413 RVA: 0x001C28BC File Offset: 0x001C0ABC
		// (set) Token: 0x06006346 RID: 25414 RVA: 0x0002EE8E File Offset: 0x0002D08E
		public unsafe List<string> writtenVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06006347 RID: 25415 RVA: 0x001C28EC File Offset: 0x001C0AEC
		// (set) Token: 0x06006348 RID: 25416 RVA: 0x0002EEAD File Offset: 0x0002D0AD
		public unsafe Dictionary<DeliveryInstance, int> minsSinceVehicleEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DeliveryInstance, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_minsSinceVehicleEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x06006349 RID: 25417 RVA: 0x001C291C File Offset: 0x001C0B1C
		// (set) Token: 0x0600634A RID: 25418 RVA: 0x0002EECC File Offset: 0x0002D0CC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x001C2944 File Offset: 0x001C0B44
		// (set) Token: 0x0600634C RID: 25420 RVA: 0x0002EEE7 File Offset: 0x0002D0E7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004391 RID: 17297
		private static readonly IntPtr NativeFieldInfoPtr_Deliveries;

		// Token: 0x04004392 RID: 17298
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCreated;

		// Token: 0x04004393 RID: 17299
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x04004394 RID: 17300
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004395 RID: 17301
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004396 RID: 17302
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004397 RID: 17303
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004398 RID: 17304
		private static readonly IntPtr NativeFieldInfoPtr_writtenVehicles;

		// Token: 0x04004399 RID: 17305
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceVehicleEmpty;

		// Token: 0x0400439A RID: 17306
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400439B RID: 17307
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400439C RID: 17308
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400439D RID: 17309
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400439E RID: 17310
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400439F RID: 17311
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043A0 RID: 17312
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040043A1 RID: 17313
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040043A2 RID: 17314
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040043A3 RID: 17315
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040043A4 RID: 17316
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043A5 RID: 17317
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040043A6 RID: 17318
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040043A7 RID: 17319
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040043A8 RID: 17320
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040043A9 RID: 17321
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040043AA RID: 17322
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040043AB RID: 17323
		private static readonly IntPtr NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0;

		// Token: 0x040043AC RID: 17324
		private static readonly IntPtr NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x040043AD RID: 17325
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x040043AE RID: 17326
		private static readonly IntPtr NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0;

		// Token: 0x040043B2 RID: 17330
		private static readonly IntPtr NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0;

		// Token: 0x040043B3 RID: 17331
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040043B8 RID: 17336
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040043B9 RID: 17337
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040043BA RID: 17338
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0;

		// Token: 0x040043BB RID: 17339
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0;

		// Token: 0x040043BC RID: 17340
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040043BD RID: 17341
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x040043BE RID: 17342
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x040043BF RID: 17343
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043C0 RID: 17344
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x040043C1 RID: 17345
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043C2 RID: 17346
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x040043C3 RID: 17347
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x040043C4 RID: 17348
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043C5 RID: 17349
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A25 RID: 2597
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Object
		{
			// Token: 0x0600CF1D RID: 53021 RVA: 0x0031C4D8 File Offset: 0x0031A6D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, "deliveryID");
				DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, 100675885);
				DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr, 100675886);
			}

			// Token: 0x0600CF1E RID: 53022 RVA: 0x0031C540 File Offset: 0x0031A740
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF1F RID: 53023 RVA: 0x0031C57C File Offset: 0x0031A77C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass35_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF20 RID: 53024 RVA: 0x00064C2A File Offset: 0x00062E2A
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004064 RID: 16484
			// (get) Token: 0x0600CF21 RID: 53025 RVA: 0x0031C5CC File Offset: 0x0031A7CC
			// (set) Token: 0x0600CF22 RID: 53026 RVA: 0x00064C33 File Offset: 0x00062E33
			public unsafe string deliveryID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass35_0.NativeFieldInfoPtr_deliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008BC2 RID: 35778
			private static readonly IntPtr NativeFieldInfoPtr_deliveryID;

			// Token: 0x04008BC3 RID: 35779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BC4 RID: 35780
			private static readonly IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A26 RID: 2598
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Object
		{
			// Token: 0x0600CF23 RID: 53027 RVA: 0x0031C5F4 File Offset: 0x0031A7F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, "destination");
				DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, 100675887);
				DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr, 100675888);
			}

			// Token: 0x0600CF24 RID: 53028 RVA: 0x0031C65C File Offset: 0x0031A85C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF25 RID: 53029 RVA: 0x0031C698 File Offset: 0x0031A898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202751, XrefRangeEnd = 202753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF26 RID: 53030 RVA: 0x00064C52 File Offset: 0x00062E52
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004065 RID: 16485
			// (get) Token: 0x0600CF27 RID: 53031 RVA: 0x0031C6E8 File Offset: 0x0031A8E8
			// (set) Token: 0x0600CF28 RID: 53032 RVA: 0x00064C5B File Offset: 0x00062E5B
			public unsafe Property destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass36_0.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BC5 RID: 35781
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008BC6 RID: 35782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BC7 RID: 35783
			private static readonly IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A27 RID: 2599
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Object
		{
			// Token: 0x0600CF29 RID: 53033 RVA: 0x0031C718 File Offset: 0x0031A918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, "shop");
				DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, 100675889);
				DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr, 100675890);
			}

			// Token: 0x0600CF2A RID: 53034 RVA: 0x0031C780 File Offset: 0x0031A980
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF2B RID: 53035 RVA: 0x0031C7BC File Offset: 0x0031A9BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202753, XrefRangeEnd = 202755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetActiveShopDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass37_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF2C RID: 53036 RVA: 0x00064C7A File Offset: 0x00062E7A
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004066 RID: 16486
			// (get) Token: 0x0600CF2D RID: 53037 RVA: 0x0031C80C File Offset: 0x0031AA0C
			// (set) Token: 0x0600CF2E RID: 53038 RVA: 0x00064C83 File Offset: 0x00062E83
			public unsafe DeliveryShop shop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass37_0.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BC8 RID: 35784
			private static readonly IntPtr NativeFieldInfoPtr_shop;

			// Token: 0x04008BC9 RID: 35785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BCA RID: 35786
			private static readonly IntPtr NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000A28 RID: 2600
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Object
		{
			// Token: 0x0600CF2F RID: 53039 RVA: 0x0031C83C File Offset: 0x0031AA3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, "shopName");
				DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, 100675891);
				DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr, 100675892);
			}

			// Token: 0x0600CF30 RID: 53040 RVA: 0x0031C8A4 File Offset: 0x0031AAA4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF31 RID: 53041 RVA: 0x0031C8E0 File Offset: 0x0031AAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShopInterface_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass38_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF32 RID: 53042 RVA: 0x00064CA2 File Offset: 0x00062EA2
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004067 RID: 16487
			// (get) Token: 0x0600CF33 RID: 53043 RVA: 0x0031C930 File Offset: 0x0031AB30
			// (set) Token: 0x0600CF34 RID: 53044 RVA: 0x00064CAB File Offset: 0x00062EAB
			public unsafe string shopName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass38_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008BCB RID: 35787
			private static readonly IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x04008BCC RID: 35788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BCD RID: 35789
			private static readonly IntPtr NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
