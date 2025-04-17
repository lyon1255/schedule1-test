using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.ATM;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000724 RID: 1828
	public class ATM : NetworkBehaviour
	{
		// Token: 0x0600A49E RID: 42142 RVA: 0x00293B24 File Offset: 0x00291D24
		// Note: this type is marked as 'beforefieldinit'.
		static ATM()
		{
			Il2CppClassPointerStore<ATM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "ATM");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATM>.NativeClassPtr);
			ATM.NativeFieldInfoPtr_DepositLimitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "DepositLimitEnabled");
			ATM.NativeFieldInfoPtr_WEEKLY_DEPOSIT_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "WEEKLY_DEPOSIT_LIMIT");
			ATM.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "IMPACT_THRESHOLD_BREAK");
			ATM.NativeFieldInfoPtr_REPAIR_TIME_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "REPAIR_TIME_DAYS");
			ATM.NativeFieldInfoPtr_MIN_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "MIN_CASH_DROP");
			ATM.NativeFieldInfoPtr_MAX_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "MAX_CASH_DROP");
			ATM.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "WeeklyDepositSum");
			ATM.NativeFieldInfoPtr__IsBroken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<IsBroken>k__BackingField");
			ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<DaysUntilRepair>k__BackingField");
			ATM.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "CashPrefab");
			ATM.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "intObj");
			ATM.NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "camPos");
			ATM.NativeFieldInfoPtr_interfaceATM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "interfaceATM");
			ATM.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "AccessPoint");
			ATM.NativeFieldInfoPtr_CashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "CashSpawnPoint");
			ATM.NativeFieldInfoPtr_Damageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "Damageable");
			ATM.NativeFieldInfoPtr_viewLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "viewLerpTime");
			ATM.NativeFieldInfoPtr__isInUse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<isInUse>k__BackingField");
			ATM.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<GUID>k__BackingField");
			ATM.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "BakedGUID");
			ATM.NativeFieldInfoPtr_onBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "onBreak");
			ATM.NativeFieldInfoPtr_onRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "onRepair");
			ATM.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted");
			ATM.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted");
			ATM.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683405);
			ATM.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683406);
			ATM.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683407);
			ATM.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683408);
			ATM.NativeMethodInfoPtr_get_isInUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683409);
			ATM.NativeMethodInfoPtr_set_isInUse_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683410);
			ATM.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683411);
			ATM.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683412);
			ATM.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683413);
			ATM.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683414);
			ATM.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683415);
			ATM.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683416);
			ATM.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683417);
			ATM.NativeMethodInfoPtr_DayPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683418);
			ATM.NativeMethodInfoPtr_WeekPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683419);
			ATM.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683420);
			ATM.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683421);
			ATM.NativeMethodInfoPtr_Enter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683422);
			ATM.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683423);
			ATM.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683424);
			ATM.NativeMethodInfoPtr_SendBreak_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683425);
			ATM.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683426);
			ATM.NativeMethodInfoPtr_Repair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683427);
			ATM.NativeMethodInfoPtr_DropCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683428);
			ATM.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683429);
			ATM.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683430);
			ATM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683431);
			ATM.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683433);
			ATM.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683434);
			ATM.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683435);
			ATM.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683436);
			ATM.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683437);
			ATM.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683438);
			ATM.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683439);
			ATM.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683440);
			ATM.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683441);
			ATM.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683442);
			ATM.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683443);
			ATM.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683444);
			ATM.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683445);
			ATM.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683446);
			ATM.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683447);
			ATM.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683448);
			ATM.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683449);
			ATM.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683450);
			ATM.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100683451);
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600A49F RID: 42143 RVA: 0x002940CC File Offset: 0x002922CC
		// (set) Token: 0x0600A4A0 RID: 42144 RVA: 0x00294108 File Offset: 0x00292308
		public unsafe bool IsBroken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600A4A1 RID: 42145 RVA: 0x00294148 File Offset: 0x00292348
		// (set) Token: 0x0600A4A2 RID: 42146 RVA: 0x00294184 File Offset: 0x00292384
		public unsafe int DaysUntilRepair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600A4A3 RID: 42147 RVA: 0x002941C4 File Offset: 0x002923C4
		// (set) Token: 0x0600A4A4 RID: 42148 RVA: 0x00294200 File Offset: 0x00292400
		public unsafe bool isInUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_isInUse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_isInUse_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600A4A5 RID: 42149 RVA: 0x00294240 File Offset: 0x00292440
		// (set) Token: 0x0600A4A6 RID: 42150 RVA: 0x0029427C File Offset: 0x0029247C
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x002942BC File Offset: 0x002924BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287736, XrefRangeEnd = 287739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x002942F0 File Offset: 0x002924F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287739, XrefRangeEnd = 287760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x0029432C File Offset: 0x0029252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287760, XrefRangeEnd = 287800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x00294368 File Offset: 0x00292568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287800, XrefRangeEnd = 287802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x002943B8 File Offset: 0x002925B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287802, XrefRangeEnd = 287806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x002943F8 File Offset: 0x002925F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287806, XrefRangeEnd = 287816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_DayPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x0029442C File Offset: 0x0029262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287816, XrefRangeEnd = 287820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_WeekPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AE RID: 42158 RVA: 0x00294460 File Offset: 0x00292660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287820, XrefRangeEnd = 287823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x00294494 File Offset: 0x00292694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287823, XrefRangeEnd = 287824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x002944C8 File Offset: 0x002926C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287857, RefRangeEnd = 287858, XrefRangeStart = 287824, XrefRangeEnd = 287857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Enter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x002944FC File Offset: 0x002926FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287887, RefRangeEnd = 287888, XrefRangeStart = 287858, XrefRangeEnd = 287887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x00294530 File Offset: 0x00292730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287888, XrefRangeEnd = 287931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Impacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x00294574 File Offset: 0x00292774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287931, XrefRangeEnd = 287952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_SendBreak_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x002945A8 File Offset: 0x002927A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 287989, RefRangeEnd = 287995, XrefRangeStart = 287952, XrefRangeEnd = 287989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x002945EC File Offset: 0x002927EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287995, XrefRangeEnd = 288013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Repair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Repair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x00294620 File Offset: 0x00292820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288013, XrefRangeEnd = 288031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_DropCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x00294654 File Offset: 0x00292854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288031, XrefRangeEnd = 288038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x00294698 File Offset: 0x00292898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288038, XrefRangeEnd = 288049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x002946D8 File Offset: 0x002928D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288049, XrefRangeEnd = 288053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATM() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATM>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x00294714 File Offset: 0x00292914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288053, XrefRangeEnd = 288058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x00294754 File Offset: 0x00292954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288058, XrefRangeEnd = 288090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x00294790 File Offset: 0x00292990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112829, RefRangeEnd = 112830, XrefRangeStart = 112829, XrefRangeEnd = 112830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x002947CC File Offset: 0x002929CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x00294808 File Offset: 0x00292A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288090, XrefRangeEnd = 288108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x0029483C File Offset: 0x00292A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288108, XrefRangeEnd = 288109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x00294870 File Offset: 0x00292A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288109, XrefRangeEnd = 288112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x002948D4 File Offset: 0x00292AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288112, XrefRangeEnd = 288130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x00294918 File Offset: 0x00292B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288130, XrefRangeEnd = 288131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0029495C File Offset: 0x00292B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288131, XrefRangeEnd = 288134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x002949AC File Offset: 0x00292BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288134, XrefRangeEnd = 288152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x002949F0 File Offset: 0x00292BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288152, XrefRangeEnd = 288155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x00294A40 File Offset: 0x00292C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x00294A74 File Offset: 0x00292C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288155, XrefRangeEnd = 288156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x00294AA8 File Offset: 0x00292CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288156, XrefRangeEnd = 288158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x00294AF8 File Offset: 0x00292CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4CA RID: 42186 RVA: 0x00294B2C File Offset: 0x00292D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288179, RefRangeEnd = 288180, XrefRangeStart = 288158, XrefRangeEnd = 288179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x00294B60 File Offset: 0x00292D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288180, XrefRangeEnd = 288182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x00294BC4 File Offset: 0x00292DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288182, XrefRangeEnd = 288200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x000512D6 File Offset: 0x0004F4D6
		public ATM(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A4CE RID: 42190 RVA: 0x00294BF8 File Offset: 0x00292DF8
		// (set) Token: 0x0600A4CF RID: 42191 RVA: 0x000512DF File Offset: 0x0004F4DF
		public unsafe static bool DepositLimitEnabled
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_DepositLimitEnabled, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_DepositLimitEnabled, (void*)(&value));
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x00294C14 File Offset: 0x00292E14
		// (set) Token: 0x0600A4D1 RID: 42193 RVA: 0x000512ED File Offset: 0x0004F4ED
		public unsafe static float WEEKLY_DEPOSIT_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_WEEKLY_DEPOSIT_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_WEEKLY_DEPOSIT_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600A4D2 RID: 42194 RVA: 0x00294C30 File Offset: 0x00292E30
		// (set) Token: 0x0600A4D3 RID: 42195 RVA: 0x000512FB File Offset: 0x0004F4FB
		public unsafe static float IMPACT_THRESHOLD_BREAK
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&value));
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x00294C4C File Offset: 0x00292E4C
		// (set) Token: 0x0600A4D5 RID: 42197 RVA: 0x00051309 File Offset: 0x0004F509
		public unsafe static int REPAIR_TIME_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&value));
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x00294C68 File Offset: 0x00292E68
		// (set) Token: 0x0600A4D7 RID: 42199 RVA: 0x00051317 File Offset: 0x0004F517
		public unsafe static int MIN_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600A4D8 RID: 42200 RVA: 0x00294C84 File Offset: 0x00292E84
		// (set) Token: 0x0600A4D9 RID: 42201 RVA: 0x00051325 File Offset: 0x0004F525
		public unsafe static int MAX_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600A4DA RID: 42202 RVA: 0x00294CA0 File Offset: 0x00292EA0
		// (set) Token: 0x0600A4DB RID: 42203 RVA: 0x00051333 File Offset: 0x0004F533
		public unsafe static float WeeklyDepositSum
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_WeeklyDepositSum, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_WeeklyDepositSum, (void*)(&value));
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600A4DC RID: 42204 RVA: 0x00294CBC File Offset: 0x00292EBC
		// (set) Token: 0x0600A4DD RID: 42205 RVA: 0x00051341 File Offset: 0x0004F541
		public unsafe bool _IsBroken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__IsBroken_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__IsBroken_k__BackingField)) = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600A4DE RID: 42206 RVA: 0x00294CE4 File Offset: 0x00292EE4
		// (set) Token: 0x0600A4DF RID: 42207 RVA: 0x0005135C File Offset: 0x0004F55C
		public unsafe int _DaysUntilRepair_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField)) = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600A4E0 RID: 42208 RVA: 0x00294D0C File Offset: 0x00292F0C
		// (set) Token: 0x0600A4E1 RID: 42209 RVA: 0x00051377 File Offset: 0x0004F577
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600A4E2 RID: 42210 RVA: 0x00294D3C File Offset: 0x00292F3C
		// (set) Token: 0x0600A4E3 RID: 42211 RVA: 0x00051396 File Offset: 0x0004F596
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600A4E4 RID: 42212 RVA: 0x00294D6C File Offset: 0x00292F6C
		// (set) Token: 0x0600A4E5 RID: 42213 RVA: 0x000513B5 File Offset: 0x0004F5B5
		public unsafe Transform camPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_camPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_camPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600A4E6 RID: 42214 RVA: 0x00294D9C File Offset: 0x00292F9C
		// (set) Token: 0x0600A4E7 RID: 42215 RVA: 0x000513D4 File Offset: 0x0004F5D4
		public unsafe ATMInterface interfaceATM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_interfaceATM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_interfaceATM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600A4E8 RID: 42216 RVA: 0x00294DCC File Offset: 0x00292FCC
		// (set) Token: 0x0600A4E9 RID: 42217 RVA: 0x000513F3 File Offset: 0x0004F5F3
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600A4EA RID: 42218 RVA: 0x00294DFC File Offset: 0x00292FFC
		// (set) Token: 0x0600A4EB RID: 42219 RVA: 0x00051412 File Offset: 0x0004F612
		public unsafe Transform CashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600A4EC RID: 42220 RVA: 0x00294E2C File Offset: 0x0029302C
		// (set) Token: 0x0600A4ED RID: 42221 RVA: 0x00051431 File Offset: 0x0004F631
		public unsafe PhysicsDamageable Damageable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_Damageable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsDamageable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_Damageable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600A4EE RID: 42222 RVA: 0x00294E5C File Offset: 0x0029305C
		// (set) Token: 0x0600A4EF RID: 42223 RVA: 0x00051450 File Offset: 0x0004F650
		public unsafe static float viewLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_viewLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_viewLerpTime, (void*)(&value));
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600A4F0 RID: 42224 RVA: 0x00294E78 File Offset: 0x00293078
		// (set) Token: 0x0600A4F1 RID: 42225 RVA: 0x0005145E File Offset: 0x0004F65E
		public unsafe bool _isInUse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__isInUse_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__isInUse_k__BackingField)) = value;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600A4F2 RID: 42226 RVA: 0x00294EA0 File Offset: 0x002930A0
		// (set) Token: 0x0600A4F3 RID: 42227 RVA: 0x00051479 File Offset: 0x0004F679
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600A4F4 RID: 42228 RVA: 0x00294EC8 File Offset: 0x002930C8
		// (set) Token: 0x0600A4F5 RID: 42229 RVA: 0x00051494 File Offset: 0x0004F694
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600A4F6 RID: 42230 RVA: 0x00294EF0 File Offset: 0x002930F0
		// (set) Token: 0x0600A4F7 RID: 42231 RVA: 0x000514B3 File Offset: 0x0004F6B3
		public unsafe UnityEvent onBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600A4F8 RID: 42232 RVA: 0x00294F20 File Offset: 0x00293120
		// (set) Token: 0x0600A4F9 RID: 42233 RVA: 0x000514D2 File Offset: 0x0004F6D2
		public unsafe UnityEvent onRepair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onRepair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onRepair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x00294F50 File Offset: 0x00293150
		// (set) Token: 0x0600A4FB RID: 42235 RVA: 0x000514F1 File Offset: 0x0004F6F1
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600A4FC RID: 42236 RVA: 0x00294F78 File Offset: 0x00293178
		// (set) Token: 0x0600A4FD RID: 42237 RVA: 0x0005150C File Offset: 0x0004F70C
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006E57 RID: 28247
		private static readonly IntPtr NativeFieldInfoPtr_DepositLimitEnabled;

		// Token: 0x04006E58 RID: 28248
		private static readonly IntPtr NativeFieldInfoPtr_WEEKLY_DEPOSIT_LIMIT;

		// Token: 0x04006E59 RID: 28249
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK;

		// Token: 0x04006E5A RID: 28250
		private static readonly IntPtr NativeFieldInfoPtr_REPAIR_TIME_DAYS;

		// Token: 0x04006E5B RID: 28251
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CASH_DROP;

		// Token: 0x04006E5C RID: 28252
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_DROP;

		// Token: 0x04006E5D RID: 28253
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x04006E5E RID: 28254
		private static readonly IntPtr NativeFieldInfoPtr__IsBroken_k__BackingField;

		// Token: 0x04006E5F RID: 28255
		private static readonly IntPtr NativeFieldInfoPtr__DaysUntilRepair_k__BackingField;

		// Token: 0x04006E60 RID: 28256
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x04006E61 RID: 28257
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04006E62 RID: 28258
		private static readonly IntPtr NativeFieldInfoPtr_camPos;

		// Token: 0x04006E63 RID: 28259
		private static readonly IntPtr NativeFieldInfoPtr_interfaceATM;

		// Token: 0x04006E64 RID: 28260
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04006E65 RID: 28261
		private static readonly IntPtr NativeFieldInfoPtr_CashSpawnPoint;

		// Token: 0x04006E66 RID: 28262
		private static readonly IntPtr NativeFieldInfoPtr_Damageable;

		// Token: 0x04006E67 RID: 28263
		private static readonly IntPtr NativeFieldInfoPtr_viewLerpTime;

		// Token: 0x04006E68 RID: 28264
		private static readonly IntPtr NativeFieldInfoPtr__isInUse_k__BackingField;

		// Token: 0x04006E69 RID: 28265
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04006E6A RID: 28266
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04006E6B RID: 28267
		private static readonly IntPtr NativeFieldInfoPtr_onBreak;

		// Token: 0x04006E6C RID: 28268
		private static readonly IntPtr NativeFieldInfoPtr_onRepair;

		// Token: 0x04006E6D RID: 28269
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006E6E RID: 28270
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006E6F RID: 28271
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0;

		// Token: 0x04006E70 RID: 28272
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0;

		// Token: 0x04006E71 RID: 28273
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0;

		// Token: 0x04006E72 RID: 28274
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0;

		// Token: 0x04006E73 RID: 28275
		private static readonly IntPtr NativeMethodInfoPtr_get_isInUse_Public_get_Boolean_0;

		// Token: 0x04006E74 RID: 28276
		private static readonly IntPtr NativeMethodInfoPtr_set_isInUse_Protected_set_Void_Boolean_0;

		// Token: 0x04006E75 RID: 28277
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04006E76 RID: 28278
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04006E77 RID: 28279
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04006E78 RID: 28280
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006E79 RID: 28281
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006E7A RID: 28282
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006E7B RID: 28283
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04006E7C RID: 28284
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Public_Void_0;

		// Token: 0x04006E7D RID: 28285
		private static readonly IntPtr NativeMethodInfoPtr_WeekPass_Public_Void_0;

		// Token: 0x04006E7E RID: 28286
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006E7F RID: 28287
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006E80 RID: 28288
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_0;

		// Token: 0x04006E81 RID: 28289
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04006E82 RID: 28290
		private static readonly IntPtr NativeMethodInfoPtr_Impacted_Private_Void_Impact_0;

		// Token: 0x04006E83 RID: 28291
		private static readonly IntPtr NativeMethodInfoPtr_SendBreak_Private_Void_0;

		// Token: 0x04006E84 RID: 28292
		private static readonly IntPtr NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0;

		// Token: 0x04006E85 RID: 28293
		private static readonly IntPtr NativeMethodInfoPtr_Repair_Private_Void_0;

		// Token: 0x04006E86 RID: 28294
		private static readonly IntPtr NativeMethodInfoPtr_DropCash_Private_Void_0;

		// Token: 0x04006E87 RID: 28295
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0;

		// Token: 0x04006E88 RID: 28296
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0;

		// Token: 0x04006E89 RID: 28297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E8A RID: 28298
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006E8B RID: 28299
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006E8C RID: 28300
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006E8D RID: 28301
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006E8E RID: 28302
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0;

		// Token: 0x04006E8F RID: 28303
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0;

		// Token: 0x04006E90 RID: 28304
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006E91 RID: 28305
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006E92 RID: 28306
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006E93 RID: 28307
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E94 RID: 28308
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006E95 RID: 28309
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E96 RID: 28310
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0;

		// Token: 0x04006E97 RID: 28311
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0;

		// Token: 0x04006E98 RID: 28312
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E99 RID: 28313
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0;

		// Token: 0x04006E9A RID: 28314
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0;

		// Token: 0x04006E9B RID: 28315
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006E9C RID: 28316
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000BC9 RID: 3017
		[ObfuscatedName("ScheduleOne.Money.ATM+<<Impacted>g__BreakRoutine|45_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DDDF RID: 56799 RVA: 0x00345DD4 File Offset: 0x00343FD4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique()
			{
				Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<<Impacted>g__BreakRoutine|45_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>1__state");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>2__current");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>4__this");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<cashDrop>5__2");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<i>5__3");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683452);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683453);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683454);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683455);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683456);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100683457);
			}

			// Token: 0x0600DDE0 RID: 56800 RVA: 0x00345EDC File Offset: 0x003440DC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE1 RID: 56801 RVA: 0x00345F24 File Offset: 0x00344124
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE2 RID: 56802 RVA: 0x00345F58 File Offset: 0x00344158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287705, XrefRangeEnd = 287731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044C1 RID: 17601
			// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x00345F94 File Offset: 0x00344194
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDE4 RID: 56804 RVA: 0x00345FD4 File Offset: 0x003441D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287731, XrefRangeEnd = 287736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044C2 RID: 17602
			// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x00346008 File Offset: 0x00344208
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDE6 RID: 56806 RVA: 0x0006C258 File Offset: 0x0006A458
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BC RID: 17596
			// (get) Token: 0x0600DDE7 RID: 56807 RVA: 0x00346048 File Offset: 0x00344248
			// (set) Token: 0x0600DDE8 RID: 56808 RVA: 0x0006C261 File Offset: 0x0006A461
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044BD RID: 17597
			// (get) Token: 0x0600DDE9 RID: 56809 RVA: 0x00346070 File Offset: 0x00344270
			// (set) Token: 0x0600DDEA RID: 56810 RVA: 0x0006C27C File Offset: 0x0006A47C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BE RID: 17598
			// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x003460A0 File Offset: 0x003442A0
			// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x0006C29B File Offset: 0x0006A49B
			public unsafe ATM __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BF RID: 17599
			// (get) Token: 0x0600DDED RID: 56813 RVA: 0x003460D0 File Offset: 0x003442D0
			// (set) Token: 0x0600DDEE RID: 56814 RVA: 0x0006C2BA File Offset: 0x0006A4BA
			public unsafe int _cashDrop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2)) = value;
				}
			}

			// Token: 0x170044C0 RID: 17600
			// (get) Token: 0x0600DDEF RID: 56815 RVA: 0x003460F8 File Offset: 0x003442F8
			// (set) Token: 0x0600DDF0 RID: 56816 RVA: 0x0006C2D5 File Offset: 0x0006A4D5
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009493 RID: 38035
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009494 RID: 38036
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009495 RID: 38037
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009496 RID: 38038
			private static readonly IntPtr NativeFieldInfoPtr__cashDrop_5__2;

			// Token: 0x04009497 RID: 38039
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009498 RID: 38040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009499 RID: 38041
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400949A RID: 38042
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400949B RID: 38043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400949C RID: 38044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400949D RID: 38045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
