using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000726 RID: 1830
	public class MoneyManager : NetworkSingleton<MoneyManager>
	{
		// Token: 0x0600A505 RID: 42245 RVA: 0x0029510C File Offset: 0x0029330C
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyManager()
		{
			Il2CppClassPointerStore<MoneyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "MoneyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr);
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR");
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR_DARKER");
			MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ONLINE_BALANCE_COLOR");
			MoneyManager.NativeFieldInfoPtr_ledger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ledger");
			MoneyManager.NativeFieldInfoPtr_onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onlineBalance");
			MoneyManager.NativeFieldInfoPtr_lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LastCalculatedNetworth>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_CashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "CashSound");
			MoneyManager.NativeFieldInfoPtr_moneyChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "moneyChangePrefab");
			MoneyManager.NativeFieldInfoPtr_cashChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "cashChangePrefab");
			MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "LaunderingNotificationIcon");
			MoneyManager.NativeFieldInfoPtr_onNetworthCalculation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onNetworthCalculation");
			MoneyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "loader");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___onlineBalance");
			MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683461);
			MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683462);
			MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683463);
			MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683464);
			MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683465);
			MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683466);
			MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683467);
			MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683468);
			MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683469);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683470);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683471);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683472);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683473);
			MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683474);
			MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683475);
			MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683476);
			MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683477);
			MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683478);
			MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683479);
			MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683480);
			MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683481);
			MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683482);
			MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683483);
			MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683484);
			MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683485);
			MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683486);
			MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683487);
			MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683488);
			MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683489);
			MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683490);
			MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683491);
			MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683492);
			MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683493);
			MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683494);
			MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683495);
			MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683496);
			MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683497);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683498);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683499);
			MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683500);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683501);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683502);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683503);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683504);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683505);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683506);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683507);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683508);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683509);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683510);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683511);
			MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683512);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683513);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683514);
			MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683515);
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A506 RID: 42246 RVA: 0x00295718 File Offset: 0x00293918
		public unsafe float LifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59140, XrefRangeStart = 59139, XrefRangeEnd = 59140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A507 RID: 42247 RVA: 0x00295754 File Offset: 0x00293954
		// (set) Token: 0x0600A508 RID: 42248 RVA: 0x00295790 File Offset: 0x00293990
		public unsafe float LastCalculatedNetworth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A509 RID: 42249 RVA: 0x002957D0 File Offset: 0x002939D0
		public unsafe float cashBalance
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 288263, RefRangeEnd = 288290, XrefRangeStart = 288262, XrefRangeEnd = 288263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A50A RID: 42250 RVA: 0x0029580C File Offset: 0x00293A0C
		public unsafe CashInstance cashInstance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 288294, RefRangeEnd = 288300, XrefRangeStart = 288290, XrefRangeEnd = 288294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x0029584C File Offset: 0x00293A4C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288300, XrefRangeEnd = 288302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A50C RID: 42252 RVA: 0x00295884 File Offset: 0x00293A84
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288302, XrefRangeEnd = 288304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x002958BC File Offset: 0x00293ABC
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A50E RID: 42254 RVA: 0x002958FC File Offset: 0x00293AFC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A50F RID: 42255 RVA: 0x00295938 File Offset: 0x00293B38
		// (set) Token: 0x0600A510 RID: 42256 RVA: 0x00295978 File Offset: 0x00293B78
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x002959BC File Offset: 0x00293BBC
		// (set) Token: 0x0600A512 RID: 42258 RVA: 0x002959FC File Offset: 0x00293BFC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A513 RID: 42259 RVA: 0x00295A40 File Offset: 0x00293C40
		// (set) Token: 0x0600A514 RID: 42260 RVA: 0x00295A7C File Offset: 0x00293C7C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x00295ABC File Offset: 0x00293CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288304, XrefRangeEnd = 288307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x00295AF8 File Offset: 0x00293CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288307, XrefRangeEnd = 288313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x00295B34 File Offset: 0x00293D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288313, XrefRangeEnd = 288365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x00295B70 File Offset: 0x00293D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288365, XrefRangeEnd = 288374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x00295BAC File Offset: 0x00293DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288374, XrefRangeEnd = 288381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x00295BE8 File Offset: 0x00293DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288381, XrefRangeEnd = 288429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x00295C24 File Offset: 0x00293E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288429, XrefRangeEnd = 288436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x00295C58 File Offset: 0x00293E58
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x00295C8C File Offset: 0x00293E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288436, XrefRangeEnd = 288464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x00295CC0 File Offset: 0x00293EC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288472, RefRangeEnd = 288475, XrefRangeStart = 288464, XrefRangeEnd = 288472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance GetCashInstance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x00295D0C File Offset: 0x00293F0C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 288500, RefRangeEnd = 288512, XrefRangeStart = 288475, XrefRangeEnd = 288500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x00295D80 File Offset: 0x00293F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288525, RefRangeEnd = 288527, XrefRangeStart = 288512, XrefRangeEnd = 288525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x00295DF4 File Offset: 0x00293FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288527, XrefRangeEnd = 288532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x00295E44 File Offset: 0x00294044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288551, RefRangeEnd = 288552, XrefRangeStart = 288532, XrefRangeEnd = 288551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLifetimeEarnings(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x00295E84 File Offset: 0x00294084
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 288602, RefRangeEnd = 288626, XrefRangeStart = 288552, XrefRangeEnd = 288602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visualizeChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playCashSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x00295EE0 File Offset: 0x002940E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288626, XrefRangeEnd = 288631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x00295F30 File Offset: 0x00294130
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 288662, RefRangeEnd = 288770, XrefRangeStart = 288631, XrefRangeEnd = 288662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showDecimals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x00295F84 File Offset: 0x00294184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288770, XrefRangeEnd = 288783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x00295FC8 File Offset: 0x002941C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288808, RefRangeEnd = 288809, XrefRangeStart = 288783, XrefRangeEnd = 288808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoneyData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x0029600C File Offset: 0x0029420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288809, XrefRangeEnd = 288823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNetworthAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x00296040 File Offset: 0x00294240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288827, RefRangeEnd = 288829, XrefRangeStart = 288823, XrefRangeEnd = 288827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetWorth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x0029607C File Offset: 0x0029427C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288829, XrefRangeEnd = 288856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x002960B8 File Offset: 0x002942B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288856, XrefRangeEnd = 288902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x002960F4 File Offset: 0x002942F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288902, XrefRangeEnd = 288905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x00296130 File Offset: 0x00294330
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x0029616C File Offset: 0x0029436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288905, XrefRangeEnd = 288918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x002961E0 File Offset: 0x002943E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288525, RefRangeEnd = 288527, XrefRangeStart = 288525, XrefRangeEnd = 288527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x00296254 File Offset: 0x00294454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288918, XrefRangeEnd = 288925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x002962B8 File Offset: 0x002944B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288525, RefRangeEnd = 288527, XrefRangeStart = 288525, XrefRangeEnd = 288527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x0029632C File Offset: 0x0029452C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288996, RefRangeEnd = 288997, XrefRangeStart = 288925, XrefRangeEnd = 288996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x002963A0 File Offset: 0x002945A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288997, XrefRangeEnd = 289003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x002963F0 File Offset: 0x002945F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288551, RefRangeEnd = 288552, XrefRangeStart = 288551, XrefRangeEnd = 288552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x00296430 File Offset: 0x00294630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289003, XrefRangeEnd = 289019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x00296470 File Offset: 0x00294670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289019, XrefRangeEnd = 289037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A537 RID: 42295 RVA: 0x002964D4 File Offset: 0x002946D4
		// (set) Token: 0x0600A538 RID: 42296 RVA: 0x00296510 File Offset: 0x00294710
		public unsafe float SyncAccessor_onlineBalance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 289045, RefRangeEnd = 289046, XrefRangeStart = 289037, XrefRangeEnd = 289045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x0029655C File Offset: 0x0029475C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289046, XrefRangeEnd = 289050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Money_MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x002965D0 File Offset: 0x002947D0
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x0029660C File Offset: 0x0029480C
		public unsafe float SyncAccessor_lifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59140, XrefRangeStart = 59139, XrefRangeEnd = 59140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289050, XrefRangeEnd = 289058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x00296658 File Offset: 0x00294858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289058, XrefRangeEnd = 289061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x0005153E File Offset: 0x0004F73E
		public MoneyManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600A53E RID: 42302 RVA: 0x00296694 File Offset: 0x00294894
		// (set) Token: 0x0600A53F RID: 42303 RVA: 0x00051547 File Offset: 0x0004F747
		public unsafe static string MONEY_TEXT_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x002966B4 File Offset: 0x002948B4
		// (set) Token: 0x0600A541 RID: 42305 RVA: 0x00051559 File Offset: 0x0004F759
		public unsafe static string MONEY_TEXT_COLOR_DARKER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600A542 RID: 42306 RVA: 0x002966D4 File Offset: 0x002948D4
		// (set) Token: 0x0600A543 RID: 42307 RVA: 0x0005156B File Offset: 0x0004F76B
		public unsafe static string ONLINE_BALANCE_COLOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x002966F4 File Offset: 0x002948F4
		// (set) Token: 0x0600A545 RID: 42309 RVA: 0x0005157D File Offset: 0x0004F77D
		public unsafe List<Transaction> ledger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transaction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x00296724 File Offset: 0x00294924
		// (set) Token: 0x0600A547 RID: 42311 RVA: 0x0005159C File Offset: 0x0004F79C
		public unsafe float onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance)) = value;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x0029674C File Offset: 0x0029494C
		// (set) Token: 0x0600A549 RID: 42313 RVA: 0x000515B7 File Offset: 0x0004F7B7
		public unsafe float lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings)) = value;
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x00296774 File Offset: 0x00294974
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x000515D2 File Offset: 0x0004F7D2
		public unsafe float _LastCalculatedNetworth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField)) = value;
			}
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x0029679C File Offset: 0x0029499C
		// (set) Token: 0x0600A54D RID: 42317 RVA: 0x000515ED File Offset: 0x0004F7ED
		public unsafe AudioSourceController CashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A54E RID: 42318 RVA: 0x002967CC File Offset: 0x002949CC
		// (set) Token: 0x0600A54F RID: 42319 RVA: 0x0005160C File Offset: 0x0004F80C
		public unsafe GameObject moneyChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x002967FC File Offset: 0x002949FC
		// (set) Token: 0x0600A551 RID: 42321 RVA: 0x0005162B File Offset: 0x0004F82B
		public unsafe GameObject cashChangePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600A552 RID: 42322 RVA: 0x0029682C File Offset: 0x00294A2C
		// (set) Token: 0x0600A553 RID: 42323 RVA: 0x0005164A File Offset: 0x0004F84A
		public unsafe Sprite LaunderingNotificationIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600A554 RID: 42324 RVA: 0x0029685C File Offset: 0x00294A5C
		// (set) Token: 0x0600A555 RID: 42325 RVA: 0x00051669 File Offset: 0x0004F869
		public unsafe Action<MoneyManager.FloatContainer> onNetworthCalculation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MoneyManager.FloatContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600A556 RID: 42326 RVA: 0x0029688C File Offset: 0x00294A8C
		// (set) Token: 0x0600A557 RID: 42327 RVA: 0x00051688 File Offset: 0x0004F888
		public unsafe MoneyLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoneyLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x002968BC File Offset: 0x00294ABC
		// (set) Token: 0x0600A559 RID: 42329 RVA: 0x000516A7 File Offset: 0x0004F8A7
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600A55A RID: 42330 RVA: 0x002968EC File Offset: 0x00294AEC
		// (set) Token: 0x0600A55B RID: 42331 RVA: 0x000516C6 File Offset: 0x0004F8C6
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x0029691C File Offset: 0x00294B1C
		// (set) Token: 0x0600A55D RID: 42333 RVA: 0x000516E5 File Offset: 0x0004F8E5
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600A55E RID: 42334 RVA: 0x00296944 File Offset: 0x00294B44
		// (set) Token: 0x0600A55F RID: 42335 RVA: 0x00051700 File Offset: 0x0004F900
		public unsafe SyncVar<float> syncVar___onlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x00296974 File Offset: 0x00294B74
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x0005171F File Offset: 0x0004F91F
		public unsafe SyncVar<float> syncVar___lifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x002969A4 File Offset: 0x00294BA4
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x0005173E File Offset: 0x0004F93E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x002969CC File Offset: 0x00294BCC
		// (set) Token: 0x0600A565 RID: 42341 RVA: 0x00051759 File Offset: 0x0004F959
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006EA1 RID: 28321
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR;

		// Token: 0x04006EA2 RID: 28322
		private static readonly IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER;

		// Token: 0x04006EA3 RID: 28323
		private static readonly IntPtr NativeFieldInfoPtr_ONLINE_BALANCE_COLOR;

		// Token: 0x04006EA4 RID: 28324
		private static readonly IntPtr NativeFieldInfoPtr_ledger;

		// Token: 0x04006EA5 RID: 28325
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalance;

		// Token: 0x04006EA6 RID: 28326
		private static readonly IntPtr NativeFieldInfoPtr_lifetimeEarnings;

		// Token: 0x04006EA7 RID: 28327
		private static readonly IntPtr NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField;

		// Token: 0x04006EA8 RID: 28328
		private static readonly IntPtr NativeFieldInfoPtr_CashSound;

		// Token: 0x04006EA9 RID: 28329
		private static readonly IntPtr NativeFieldInfoPtr_moneyChangePrefab;

		// Token: 0x04006EAA RID: 28330
		private static readonly IntPtr NativeFieldInfoPtr_cashChangePrefab;

		// Token: 0x04006EAB RID: 28331
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingNotificationIcon;

		// Token: 0x04006EAC RID: 28332
		private static readonly IntPtr NativeFieldInfoPtr_onNetworthCalculation;

		// Token: 0x04006EAD RID: 28333
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04006EAE RID: 28334
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04006EAF RID: 28335
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04006EB0 RID: 28336
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04006EB1 RID: 28337
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___onlineBalance;

		// Token: 0x04006EB2 RID: 28338
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___lifetimeEarnings;

		// Token: 0x04006EB3 RID: 28339
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006EB4 RID: 28340
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006EB5 RID: 28341
		private static readonly IntPtr NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0;

		// Token: 0x04006EB6 RID: 28342
		private static readonly IntPtr NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0;

		// Token: 0x04006EB7 RID: 28343
		private static readonly IntPtr NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0;

		// Token: 0x04006EB8 RID: 28344
		private static readonly IntPtr NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0;

		// Token: 0x04006EB9 RID: 28345
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0;

		// Token: 0x04006EBA RID: 28346
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006EBB RID: 28347
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006EBC RID: 28348
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04006EBD RID: 28349
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006EBE RID: 28350
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006EBF RID: 28351
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006EC0 RID: 28352
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006EC1 RID: 28353
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006EC2 RID: 28354
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006EC3 RID: 28355
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04006EC4 RID: 28356
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006EC5 RID: 28357
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04006EC6 RID: 28358
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04006EC7 RID: 28359
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04006EC8 RID: 28360
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04006EC9 RID: 28361
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04006ECA RID: 28362
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x04006ECB RID: 28363
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006ECC RID: 28364
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04006ECD RID: 28365
		private static readonly IntPtr NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0;

		// Token: 0x04006ECE RID: 28366
		private static readonly IntPtr NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0;

		// Token: 0x04006ECF RID: 28367
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006ED0 RID: 28368
		private static readonly IntPtr NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04006ED1 RID: 28369
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0;

		// Token: 0x04006ED2 RID: 28370
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x04006ED3 RID: 28371
		private static readonly IntPtr NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04006ED4 RID: 28372
		private static readonly IntPtr NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0;

		// Token: 0x04006ED5 RID: 28373
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04006ED6 RID: 28374
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_MoneyData_0;

		// Token: 0x04006ED7 RID: 28375
		private static readonly IntPtr NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0;

		// Token: 0x04006ED8 RID: 28376
		private static readonly IntPtr NativeMethodInfoPtr_GetNetWorth_Public_Single_0;

		// Token: 0x04006ED9 RID: 28377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006EDA RID: 28378
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006EDB RID: 28379
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006EDC RID: 28380
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006EDD RID: 28381
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EDE RID: 28382
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0;

		// Token: 0x04006EDF RID: 28383
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006EE0 RID: 28384
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EE1 RID: 28385
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x04006EE2 RID: 28386
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006EE3 RID: 28387
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0;

		// Token: 0x04006EE4 RID: 28388
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0;

		// Token: 0x04006EE5 RID: 28389
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006EE6 RID: 28390
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0;

		// Token: 0x04006EE7 RID: 28391
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0;

		// Token: 0x04006EE8 RID: 28392
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04006EE9 RID: 28393
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0;

		// Token: 0x04006EEA RID: 28394
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0;

		// Token: 0x04006EEB RID: 28395
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BCA RID: 3018
		public class FloatContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DDF1 RID: 56817 RVA: 0x00346120 File Offset: 0x00344320
			// Note: this type is marked as 'beforefieldinit'.
			static FloatContainer()
			{
				Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "FloatContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr);
				MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, "<value>k__BackingField");
				MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683516);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683517);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683518);
				MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100683519);
			}

			// Token: 0x170044C4 RID: 17604
			// (get) Token: 0x0600DDF2 RID: 56818 RVA: 0x003461B0 File Offset: 0x003443B0
			// (set) Token: 0x0600DDF3 RID: 56819 RVA: 0x003461EC File Offset: 0x003443EC
			public unsafe float value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 29949, RefRangeEnd = 29953, XrefRangeStart = 29949, XrefRangeEnd = 29953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600DDF4 RID: 56820 RVA: 0x0034622C File Offset: 0x0034442C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118666, RefRangeEnd = 118672, XrefRangeStart = 118666, XrefRangeEnd = 118672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangeValue(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF5 RID: 56821 RVA: 0x0034626C File Offset: 0x0034446C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF6 RID: 56822 RVA: 0x0006C2F0 File Offset: 0x0006A4F0
			public FloatContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C3 RID: 17603
			// (get) Token: 0x0600DDF7 RID: 56823 RVA: 0x003462A8 File Offset: 0x003444A8
			// (set) Token: 0x0600DDF8 RID: 56824 RVA: 0x0006C2F9 File Offset: 0x0006A4F9
			public unsafe float _value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField)) = value;
				}
			}

			// Token: 0x0400949E RID: 38046
			private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

			// Token: 0x0400949F RID: 38047
			private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

			// Token: 0x040094A0 RID: 38048
			private static readonly IntPtr NativeMethodInfoPtr_set_value_Private_set_Void_Single_0;

			// Token: 0x040094A1 RID: 38049
			private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0;

			// Token: 0x040094A2 RID: 38050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BCB RID: 3019
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowCashChange>d__58")]
		public sealed class _ShowCashChange_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600DDF9 RID: 56825 RVA: 0x003462D0 File Offset: 0x003444D0
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowCashChange_d__58()
			{
				Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowCashChange>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr);
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683520);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683521);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683522);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683523);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683524);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100683525);
			}

			// Token: 0x0600DDFA RID: 56826 RVA: 0x00346414 File Offset: 0x00344614
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowCashChange_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDFB RID: 56827 RVA: 0x0034645C File Offset: 0x0034465C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDFC RID: 56828 RVA: 0x00346490 File Offset: 0x00344690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288204, XrefRangeEnd = 288228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044CD RID: 17613
			// (get) Token: 0x0600DDFD RID: 56829 RVA: 0x003464CC File Offset: 0x003446CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDFE RID: 56830 RVA: 0x0034650C File Offset: 0x0034470C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288228, XrefRangeEnd = 288233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044CE RID: 17614
			// (get) Token: 0x0600DDFF RID: 56831 RVA: 0x00346540 File Offset: 0x00344740
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE00 RID: 56832 RVA: 0x0006C314 File Offset: 0x0006A514
			public _ShowCashChange_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C5 RID: 17605
			// (get) Token: 0x0600DE01 RID: 56833 RVA: 0x00346580 File Offset: 0x00344780
			// (set) Token: 0x0600DE02 RID: 56834 RVA: 0x0006C31D File Offset: 0x0006A51D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044C6 RID: 17606
			// (get) Token: 0x0600DE03 RID: 56835 RVA: 0x003465A8 File Offset: 0x003447A8
			// (set) Token: 0x0600DE04 RID: 56836 RVA: 0x0006C338 File Offset: 0x0006A538
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C7 RID: 17607
			// (get) Token: 0x0600DE05 RID: 56837 RVA: 0x003465D8 File Offset: 0x003447D8
			// (set) Token: 0x0600DE06 RID: 56838 RVA: 0x0006C357 File Offset: 0x0006A557
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C8 RID: 17608
			// (get) Token: 0x0600DE07 RID: 56839 RVA: 0x00346608 File Offset: 0x00344808
			// (set) Token: 0x0600DE08 RID: 56840 RVA: 0x0006C376 File Offset: 0x0006A576
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C9 RID: 17609
			// (get) Token: 0x0600DE09 RID: 56841 RVA: 0x00346638 File Offset: 0x00344838
			// (set) Token: 0x0600DE0A RID: 56842 RVA: 0x0006C395 File Offset: 0x0006A595
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x170044CA RID: 17610
			// (get) Token: 0x0600DE0B RID: 56843 RVA: 0x00346660 File Offset: 0x00344860
			// (set) Token: 0x0600DE0C RID: 56844 RVA: 0x0006C3B0 File Offset: 0x0006A5B0
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170044CB RID: 17611
			// (get) Token: 0x0600DE0D RID: 56845 RVA: 0x00346688 File Offset: 0x00344888
			// (set) Token: 0x0600DE0E RID: 56846 RVA: 0x0006C3CB File Offset: 0x0006A5CB
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x170044CC RID: 17612
			// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x003466B0 File Offset: 0x003448B0
			// (set) Token: 0x0600DE10 RID: 56848 RVA: 0x0006C3E6 File Offset: 0x0006A5E6
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040094A3 RID: 38051
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094A4 RID: 38052
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094A5 RID: 38053
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x040094A6 RID: 38054
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x040094A7 RID: 38055
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x040094A8 RID: 38056
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040094A9 RID: 38057
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x040094AA RID: 38058
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040094AB RID: 38059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094AC RID: 38060
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094AD RID: 38061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094AE RID: 38062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094AF RID: 38063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094B0 RID: 38064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BCC RID: 3020
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowOnlineBalanceChange>d__55")]
		public sealed class _ShowOnlineBalanceChange_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600DE11 RID: 56849 RVA: 0x003466D8 File Offset: 0x003448D8
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnlineBalanceChange_d__55()
			{
				Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowOnlineBalanceChange>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683526);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683527);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683528);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683529);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683530);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100683531);
			}

			// Token: 0x0600DE12 RID: 56850 RVA: 0x0034681C File Offset: 0x00344A1C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnlineBalanceChange_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE13 RID: 56851 RVA: 0x00346864 File Offset: 0x00344A64
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE14 RID: 56852 RVA: 0x00346898 File Offset: 0x00344A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288233, XrefRangeEnd = 288257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0600DE15 RID: 56853 RVA: 0x003468D4 File Offset: 0x00344AD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE16 RID: 56854 RVA: 0x00346914 File Offset: 0x00344B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288257, XrefRangeEnd = 288262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044D8 RID: 17624
			// (get) Token: 0x0600DE17 RID: 56855 RVA: 0x00346948 File Offset: 0x00344B48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE18 RID: 56856 RVA: 0x0006C401 File Offset: 0x0006A601
			public _ShowOnlineBalanceChange_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044CF RID: 17615
			// (get) Token: 0x0600DE19 RID: 56857 RVA: 0x00346988 File Offset: 0x00344B88
			// (set) Token: 0x0600DE1A RID: 56858 RVA: 0x0006C40A File Offset: 0x0006A60A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044D0 RID: 17616
			// (get) Token: 0x0600DE1B RID: 56859 RVA: 0x003469B0 File Offset: 0x00344BB0
			// (set) Token: 0x0600DE1C RID: 56860 RVA: 0x0006C425 File Offset: 0x0006A625
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D1 RID: 17617
			// (get) Token: 0x0600DE1D RID: 56861 RVA: 0x003469E0 File Offset: 0x00344BE0
			// (set) Token: 0x0600DE1E RID: 56862 RVA: 0x0006C444 File Offset: 0x0006A644
			public unsafe RectTransform changeDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D2 RID: 17618
			// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x00346A10 File Offset: 0x00344C10
			// (set) Token: 0x0600DE20 RID: 56864 RVA: 0x0006C463 File Offset: 0x0006A663
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D3 RID: 17619
			// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x00346A40 File Offset: 0x00344C40
			// (set) Token: 0x0600DE22 RID: 56866 RVA: 0x0006C482 File Offset: 0x0006A682
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x170044D4 RID: 17620
			// (get) Token: 0x0600DE23 RID: 56867 RVA: 0x00346A68 File Offset: 0x00344C68
			// (set) Token: 0x0600DE24 RID: 56868 RVA: 0x0006C49D File Offset: 0x0006A69D
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170044D5 RID: 17621
			// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x00346A90 File Offset: 0x00344C90
			// (set) Token: 0x0600DE26 RID: 56870 RVA: 0x0006C4B8 File Offset: 0x0006A6B8
			public unsafe float _vertOffset_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x170044D6 RID: 17622
			// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x00346AB8 File Offset: 0x00344CB8
			// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x0006C4D3 File Offset: 0x0006A6D3
			public unsafe float _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x040094B1 RID: 38065
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094B2 RID: 38066
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094B3 RID: 38067
			private static readonly IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x040094B4 RID: 38068
			private static readonly IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x040094B5 RID: 38069
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x040094B6 RID: 38070
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040094B7 RID: 38071
			private static readonly IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x040094B8 RID: 38072
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x040094B9 RID: 38073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094BA RID: 38074
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094BB RID: 38075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094BC RID: 38076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094BD RID: 38077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094BE RID: 38078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
