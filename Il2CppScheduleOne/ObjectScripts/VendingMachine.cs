using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072B RID: 1835
	public class VendingMachine : NetworkBehaviour
	{
		// Token: 0x0600A5FA RID: 42490 RVA: 0x0029880C File Offset: 0x00296A0C
		// Note: this type is marked as 'beforefieldinit'.
		static VendingMachine()
		{
			Il2CppClassPointerStore<VendingMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VendingMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr);
			VendingMachine.NativeFieldInfoPtr_AllMachines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AllMachines");
			VendingMachine.NativeFieldInfoPtr_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "COST");
			VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "REPAIR_TIME_DAYS");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM_CHANCE");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_BREAK");
			VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MIN_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MAX_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<IsBroken>k__BackingField");
			VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<DaysUntilRepair>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_LitStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitStartTime");
			VendingMachine.NativeFieldInfoPtr_LitOnEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitOnEndTime");
			VendingMachine.NativeFieldInfoPtr_CukePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CukePrefab");
			VendingMachine.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashPrefab");
			VendingMachine.NativeFieldInfoPtr_DoorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorMesh");
			VendingMachine.NativeFieldInfoPtr_BodyMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyMesh");
			VendingMachine.NativeFieldInfoPtr_DoorOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorOffMat");
			VendingMachine.NativeFieldInfoPtr_DoorOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorOnMat");
			VendingMachine.NativeFieldInfoPtr_BodyOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyOffMat");
			VendingMachine.NativeFieldInfoPtr_BodyOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyOnMat");
			VendingMachine.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Lights");
			VendingMachine.NativeFieldInfoPtr_PaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "PaySound");
			VendingMachine.NativeFieldInfoPtr_DispenseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DispenseSound");
			VendingMachine.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Anim");
			VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "ItemSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IntObj");
			VendingMachine.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AccessPoint");
			VendingMachine.NativeFieldInfoPtr_Damageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Damageable");
			VendingMachine.NativeFieldInfoPtr_CashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_onBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onBreak");
			VendingMachine.NativeFieldInfoPtr_onRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onRepair");
			VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<lastDroppedItem>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_isLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "isLit");
			VendingMachine.NativeFieldInfoPtr_purchaseInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "purchaseInProgress");
			VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "timeOnLastFreeItem");
			VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<GUID>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BakedGUID");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683598);
			VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683599);
			VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683600);
			VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683601);
			VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683602);
			VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683603);
			VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683604);
			VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683605);
			VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683606);
			VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683607);
			VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683608);
			VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683609);
			VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683610);
			VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683611);
			VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683612);
			VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683613);
			VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683614);
			VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683615);
			VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683616);
			VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683617);
			VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683618);
			VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683619);
			VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683620);
			VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683621);
			VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683622);
			VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683623);
			VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683624);
			VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683625);
			VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683626);
			VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683627);
			VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683628);
			VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683629);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683631);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683632);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683633);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683634);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683635);
			VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683636);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683637);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683638);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683639);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683640);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683641);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683642);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683643);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683644);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683645);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683646);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683647);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683648);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683649);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683650);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683651);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683652);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683653);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683654);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683655);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683656);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683657);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683658);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683659);
			VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683660);
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x00299020 File Offset: 0x00297220
		// (set) Token: 0x0600A5FC RID: 42492 RVA: 0x0029905C File Offset: 0x0029725C
		public unsafe bool IsBroken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x0029909C File Offset: 0x0029729C
		// (set) Token: 0x0600A5FE RID: 42494 RVA: 0x002990D8 File Offset: 0x002972D8
		public unsafe int DaysUntilRepair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A5FF RID: 42495 RVA: 0x00299118 File Offset: 0x00297318
		// (set) Token: 0x0600A600 RID: 42496 RVA: 0x00299158 File Offset: 0x00297358
		public unsafe ItemPickup lastDroppedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x0029919C File Offset: 0x0029739C
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x002991D8 File Offset: 0x002973D8
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A603 RID: 42499 RVA: 0x00299218 File Offset: 0x00297418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289824, XrefRangeEnd = 289827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A604 RID: 42500 RVA: 0x0029924C File Offset: 0x0029744C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289827, XrefRangeEnd = 289828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x00299288 File Offset: 0x00297488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289828, XrefRangeEnd = 289869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x002992BC File Offset: 0x002974BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289869, XrefRangeEnd = 289871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x0029930C File Offset: 0x0029750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289871, XrefRangeEnd = 289875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x0029934C File Offset: 0x0029754C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289875, XrefRangeEnd = 289902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x00299380 File Offset: 0x00297580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289902, XrefRangeEnd = 289908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x002993B4 File Offset: 0x002975B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289908, XrefRangeEnd = 289917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x002993E8 File Offset: 0x002975E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289917, XrefRangeEnd = 289925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x0029941C File Offset: 0x0029761C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289925, XrefRangeEnd = 289930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x00299450 File Offset: 0x00297650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289956, RefRangeEnd = 289957, XrefRangeStart = 289930, XrefRangeEnd = 289956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x00299484 File Offset: 0x00297684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289957, XrefRangeEnd = 289978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A60F RID: 42511 RVA: 0x002994B8 File Offset: 0x002976B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289999, RefRangeEnd = 290002, XrefRangeStart = 289978, XrefRangeEnd = 289999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PurchaseRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x002994EC File Offset: 0x002976EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290002, XrefRangeEnd = 290020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x00299520 File Offset: 0x00297720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290020, XrefRangeEnd = 290030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLastDropped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x00299554 File Offset: 0x00297754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290030, XrefRangeEnd = 290042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Impacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x00299598 File Offset: 0x00297798
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 290058, RefRangeEnd = 290064, XrefRangeStart = 290042, XrefRangeEnd = 290058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x002995D8 File Offset: 0x002977D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290064, XrefRangeEnd = 290085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A615 RID: 42517 RVA: 0x0029960C File Offset: 0x0029780C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290123, RefRangeEnd = 290128, XrefRangeStart = 290085, XrefRangeEnd = 290123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A616 RID: 42518 RVA: 0x00299650 File Offset: 0x00297850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290128, XrefRangeEnd = 290146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Repair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x00299684 File Offset: 0x00297884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290146, XrefRangeEnd = 290164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x002996B8 File Offset: 0x002978B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290164, XrefRangeEnd = 290171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x002996FC File Offset: 0x002978FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290171, XrefRangeEnd = 290182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x0029973C File Offset: 0x0029793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290182, XrefRangeEnd = 290186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendingMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x00299778 File Offset: 0x00297978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290186, XrefRangeEnd = 290191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x002997B8 File Offset: 0x002979B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290191, XrefRangeEnd = 290196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x002997F8 File Offset: 0x002979F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290196, XrefRangeEnd = 290201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x00299838 File Offset: 0x00297A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290201, XrefRangeEnd = 290251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00299874 File Offset: 0x00297A74
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x002998B0 File Offset: 0x00297AB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x002998EC File Offset: 0x00297AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290251, XrefRangeEnd = 290269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x00299920 File Offset: 0x00297B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289999, RefRangeEnd = 290002, XrefRangeStart = 289999, XrefRangeEnd = 290002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x00299954 File Offset: 0x00297B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290269, XrefRangeEnd = 290272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x002999B8 File Offset: 0x00297BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290272, XrefRangeEnd = 290290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x002999EC File Offset: 0x00297BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290300, RefRangeEnd = 290303, XrefRangeStart = 290290, XrefRangeEnd = 290300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x00299A20 File Offset: 0x00297C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290303, XrefRangeEnd = 290306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x00299A70 File Offset: 0x00297C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x00299AA4 File Offset: 0x00297CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290306, XrefRangeEnd = 290318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x00299AD8 File Offset: 0x00297CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290318, XrefRangeEnd = 290330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x00299B3C File Offset: 0x00297D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290330, XrefRangeEnd = 290348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00299B70 File Offset: 0x00297D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290348, XrefRangeEnd = 290349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x00299BA4 File Offset: 0x00297DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290349, XrefRangeEnd = 290352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00299C08 File Offset: 0x00297E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290352, XrefRangeEnd = 290370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x00299C4C File Offset: 0x00297E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290370, XrefRangeEnd = 290372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x00299C90 File Offset: 0x00297E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290372, XrefRangeEnd = 290376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x00299CE0 File Offset: 0x00297EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290376, XrefRangeEnd = 290394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x00299D24 File Offset: 0x00297F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290394, XrefRangeEnd = 290398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x00299D74 File Offset: 0x00297F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00299DA8 File Offset: 0x00297FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290398, XrefRangeEnd = 290399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x00299DDC File Offset: 0x00297FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290399, XrefRangeEnd = 290401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x00299E2C File Offset: 0x0029802C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x00299E60 File Offset: 0x00298060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290423, RefRangeEnd = 290424, XrefRangeStart = 290401, XrefRangeEnd = 290423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x00299E94 File Offset: 0x00298094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290424, XrefRangeEnd = 290426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x00299EF8 File Offset: 0x002980F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290459, RefRangeEnd = 290460, XrefRangeStart = 290426, XrefRangeEnd = 290459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x00051C94 File Offset: 0x0004FE94
		public VendingMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A63A RID: 42554 RVA: 0x00299F2C File Offset: 0x0029812C
		// (set) Token: 0x0600A63B RID: 42555 RVA: 0x00051C9D File Offset: 0x0004FE9D
		public unsafe static List<VendingMachine> AllMachines
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_AllMachines, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VendingMachine>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_AllMachines, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A63C RID: 42556 RVA: 0x00299F54 File Offset: 0x00298154
		// (set) Token: 0x0600A63D RID: 42557 RVA: 0x00051CAF File Offset: 0x0004FEAF
		public unsafe static float COST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&value));
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A63E RID: 42558 RVA: 0x00299F70 File Offset: 0x00298170
		// (set) Token: 0x0600A63F RID: 42559 RVA: 0x00051CBD File Offset: 0x0004FEBD
		public unsafe static int REPAIR_TIME_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&value));
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A640 RID: 42560 RVA: 0x00299F8C File Offset: 0x0029818C
		// (set) Token: 0x0600A641 RID: 42561 RVA: 0x00051CCB File Offset: 0x0004FECB
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&value));
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A642 RID: 42562 RVA: 0x00299FA8 File Offset: 0x002981A8
		// (set) Token: 0x0600A643 RID: 42563 RVA: 0x00051CD9 File Offset: 0x0004FED9
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x00299FC4 File Offset: 0x002981C4
		// (set) Token: 0x0600A645 RID: 42565 RVA: 0x00051CE7 File Offset: 0x0004FEE7
		public unsafe static float IMPACT_THRESHOLD_BREAK
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&value));
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600A646 RID: 42566 RVA: 0x00299FE0 File Offset: 0x002981E0
		// (set) Token: 0x0600A647 RID: 42567 RVA: 0x00051CF5 File Offset: 0x0004FEF5
		public unsafe static int MIN_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600A648 RID: 42568 RVA: 0x00299FFC File Offset: 0x002981FC
		// (set) Token: 0x0600A649 RID: 42569 RVA: 0x00051D03 File Offset: 0x0004FF03
		public unsafe static int MAX_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x0029A018 File Offset: 0x00298218
		// (set) Token: 0x0600A64B RID: 42571 RVA: 0x00051D11 File Offset: 0x0004FF11
		public unsafe bool _IsBroken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField)) = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600A64C RID: 42572 RVA: 0x0029A040 File Offset: 0x00298240
		// (set) Token: 0x0600A64D RID: 42573 RVA: 0x00051D2C File Offset: 0x0004FF2C
		public unsafe int _DaysUntilRepair_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField)) = value;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x0029A068 File Offset: 0x00298268
		// (set) Token: 0x0600A64F RID: 42575 RVA: 0x00051D47 File Offset: 0x0004FF47
		public unsafe int LitStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime)) = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600A650 RID: 42576 RVA: 0x0029A090 File Offset: 0x00298290
		// (set) Token: 0x0600A651 RID: 42577 RVA: 0x00051D62 File Offset: 0x0004FF62
		public unsafe int LitOnEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime)) = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A652 RID: 42578 RVA: 0x0029A0B8 File Offset: 0x002982B8
		// (set) Token: 0x0600A653 RID: 42579 RVA: 0x00051D7D File Offset: 0x0004FF7D
		public unsafe ItemPickup CukePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x0029A0E8 File Offset: 0x002982E8
		// (set) Token: 0x0600A655 RID: 42581 RVA: 0x00051D9C File Offset: 0x0004FF9C
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A656 RID: 42582 RVA: 0x0029A118 File Offset: 0x00298318
		// (set) Token: 0x0600A657 RID: 42583 RVA: 0x00051DBB File Offset: 0x0004FFBB
		public unsafe MeshRenderer DoorMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A658 RID: 42584 RVA: 0x0029A148 File Offset: 0x00298348
		// (set) Token: 0x0600A659 RID: 42585 RVA: 0x00051DDA File Offset: 0x0004FFDA
		public unsafe MeshRenderer BodyMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A65A RID: 42586 RVA: 0x0029A178 File Offset: 0x00298378
		// (set) Token: 0x0600A65B RID: 42587 RVA: 0x00051DF9 File Offset: 0x0004FFF9
		public unsafe Material DoorOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A65C RID: 42588 RVA: 0x0029A1A8 File Offset: 0x002983A8
		// (set) Token: 0x0600A65D RID: 42589 RVA: 0x00051E18 File Offset: 0x00050018
		public unsafe Material DoorOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x0029A1D8 File Offset: 0x002983D8
		// (set) Token: 0x0600A65F RID: 42591 RVA: 0x00051E37 File Offset: 0x00050037
		public unsafe Material BodyOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A660 RID: 42592 RVA: 0x0029A208 File Offset: 0x00298408
		// (set) Token: 0x0600A661 RID: 42593 RVA: 0x00051E56 File Offset: 0x00050056
		public unsafe Material BodyOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x0029A238 File Offset: 0x00298438
		// (set) Token: 0x0600A663 RID: 42595 RVA: 0x00051E75 File Offset: 0x00050075
		public unsafe Il2CppReferenceArray<OptimizedLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x0029A268 File Offset: 0x00298468
		// (set) Token: 0x0600A665 RID: 42597 RVA: 0x00051E94 File Offset: 0x00050094
		public unsafe AudioSourceController PaySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600A666 RID: 42598 RVA: 0x0029A298 File Offset: 0x00298498
		// (set) Token: 0x0600A667 RID: 42599 RVA: 0x00051EB3 File Offset: 0x000500B3
		public unsafe AudioSourceController DispenseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A668 RID: 42600 RVA: 0x0029A2C8 File Offset: 0x002984C8
		// (set) Token: 0x0600A669 RID: 42601 RVA: 0x00051ED2 File Offset: 0x000500D2
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A66A RID: 42602 RVA: 0x0029A2F8 File Offset: 0x002984F8
		// (set) Token: 0x0600A66B RID: 42603 RVA: 0x00051EF1 File Offset: 0x000500F1
		public unsafe Transform ItemSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A66C RID: 42604 RVA: 0x0029A328 File Offset: 0x00298528
		// (set) Token: 0x0600A66D RID: 42605 RVA: 0x00051F10 File Offset: 0x00050110
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x0029A358 File Offset: 0x00298558
		// (set) Token: 0x0600A66F RID: 42607 RVA: 0x00051F2F File Offset: 0x0005012F
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x0029A388 File Offset: 0x00298588
		// (set) Token: 0x0600A671 RID: 42609 RVA: 0x00051F4E File Offset: 0x0005014E
		public unsafe PhysicsDamageable Damageable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsDamageable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x0029A3B8 File Offset: 0x002985B8
		// (set) Token: 0x0600A673 RID: 42611 RVA: 0x00051F6D File Offset: 0x0005016D
		public unsafe Transform CashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x0029A3E8 File Offset: 0x002985E8
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x00051F8C File Offset: 0x0005018C
		public unsafe UnityEvent onBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x0029A418 File Offset: 0x00298618
		// (set) Token: 0x0600A677 RID: 42615 RVA: 0x00051FAB File Offset: 0x000501AB
		public unsafe UnityEvent onRepair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A678 RID: 42616 RVA: 0x0029A448 File Offset: 0x00298648
		// (set) Token: 0x0600A679 RID: 42617 RVA: 0x00051FCA File Offset: 0x000501CA
		public unsafe ItemPickup _lastDroppedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A67A RID: 42618 RVA: 0x0029A478 File Offset: 0x00298678
		// (set) Token: 0x0600A67B RID: 42619 RVA: 0x00051FE9 File Offset: 0x000501E9
		public unsafe bool isLit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit)) = value;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A67C RID: 42620 RVA: 0x0029A4A0 File Offset: 0x002986A0
		// (set) Token: 0x0600A67D RID: 42621 RVA: 0x00052004 File Offset: 0x00050204
		public unsafe bool purchaseInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress)) = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A67E RID: 42622 RVA: 0x0029A4C8 File Offset: 0x002986C8
		// (set) Token: 0x0600A67F RID: 42623 RVA: 0x0005201F File Offset: 0x0005021F
		public unsafe float timeOnLastFreeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem)) = value;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A680 RID: 42624 RVA: 0x0029A4F0 File Offset: 0x002986F0
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x0005203A File Offset: 0x0005023A
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x0029A518 File Offset: 0x00298718
		// (set) Token: 0x0600A683 RID: 42627 RVA: 0x00052055 File Offset: 0x00050255
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A684 RID: 42628 RVA: 0x0029A540 File Offset: 0x00298740
		// (set) Token: 0x0600A685 RID: 42629 RVA: 0x00052074 File Offset: 0x00050274
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A686 RID: 42630 RVA: 0x0029A568 File Offset: 0x00298768
		// (set) Token: 0x0600A687 RID: 42631 RVA: 0x0005208F File Offset: 0x0005028F
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F4D RID: 28493
		private static readonly IntPtr NativeFieldInfoPtr_AllMachines;

		// Token: 0x04006F4E RID: 28494
		private static readonly IntPtr NativeFieldInfoPtr_COST;

		// Token: 0x04006F4F RID: 28495
		private static readonly IntPtr NativeFieldInfoPtr_REPAIR_TIME_DAYS;

		// Token: 0x04006F50 RID: 28496
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM;

		// Token: 0x04006F51 RID: 28497
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE;

		// Token: 0x04006F52 RID: 28498
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK;

		// Token: 0x04006F53 RID: 28499
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CASH_DROP;

		// Token: 0x04006F54 RID: 28500
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_DROP;

		// Token: 0x04006F55 RID: 28501
		private static readonly IntPtr NativeFieldInfoPtr__IsBroken_k__BackingField;

		// Token: 0x04006F56 RID: 28502
		private static readonly IntPtr NativeFieldInfoPtr__DaysUntilRepair_k__BackingField;

		// Token: 0x04006F57 RID: 28503
		private static readonly IntPtr NativeFieldInfoPtr_LitStartTime;

		// Token: 0x04006F58 RID: 28504
		private static readonly IntPtr NativeFieldInfoPtr_LitOnEndTime;

		// Token: 0x04006F59 RID: 28505
		private static readonly IntPtr NativeFieldInfoPtr_CukePrefab;

		// Token: 0x04006F5A RID: 28506
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x04006F5B RID: 28507
		private static readonly IntPtr NativeFieldInfoPtr_DoorMesh;

		// Token: 0x04006F5C RID: 28508
		private static readonly IntPtr NativeFieldInfoPtr_BodyMesh;

		// Token: 0x04006F5D RID: 28509
		private static readonly IntPtr NativeFieldInfoPtr_DoorOffMat;

		// Token: 0x04006F5E RID: 28510
		private static readonly IntPtr NativeFieldInfoPtr_DoorOnMat;

		// Token: 0x04006F5F RID: 28511
		private static readonly IntPtr NativeFieldInfoPtr_BodyOffMat;

		// Token: 0x04006F60 RID: 28512
		private static readonly IntPtr NativeFieldInfoPtr_BodyOnMat;

		// Token: 0x04006F61 RID: 28513
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04006F62 RID: 28514
		private static readonly IntPtr NativeFieldInfoPtr_PaySound;

		// Token: 0x04006F63 RID: 28515
		private static readonly IntPtr NativeFieldInfoPtr_DispenseSound;

		// Token: 0x04006F64 RID: 28516
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04006F65 RID: 28517
		private static readonly IntPtr NativeFieldInfoPtr_ItemSpawnPoint;

		// Token: 0x04006F66 RID: 28518
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04006F67 RID: 28519
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04006F68 RID: 28520
		private static readonly IntPtr NativeFieldInfoPtr_Damageable;

		// Token: 0x04006F69 RID: 28521
		private static readonly IntPtr NativeFieldInfoPtr_CashSpawnPoint;

		// Token: 0x04006F6A RID: 28522
		private static readonly IntPtr NativeFieldInfoPtr_onBreak;

		// Token: 0x04006F6B RID: 28523
		private static readonly IntPtr NativeFieldInfoPtr_onRepair;

		// Token: 0x04006F6C RID: 28524
		private static readonly IntPtr NativeFieldInfoPtr__lastDroppedItem_k__BackingField;

		// Token: 0x04006F6D RID: 28525
		private static readonly IntPtr NativeFieldInfoPtr_isLit;

		// Token: 0x04006F6E RID: 28526
		private static readonly IntPtr NativeFieldInfoPtr_purchaseInProgress;

		// Token: 0x04006F6F RID: 28527
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastFreeItem;

		// Token: 0x04006F70 RID: 28528
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04006F71 RID: 28529
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04006F72 RID: 28530
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F73 RID: 28531
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F74 RID: 28532
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0;

		// Token: 0x04006F75 RID: 28533
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0;

		// Token: 0x04006F76 RID: 28534
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0;

		// Token: 0x04006F77 RID: 28535
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0;

		// Token: 0x04006F78 RID: 28536
		private static readonly IntPtr NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0;

		// Token: 0x04006F79 RID: 28537
		private static readonly IntPtr NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0;

		// Token: 0x04006F7A RID: 28538
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04006F7B RID: 28539
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04006F7C RID: 28540
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04006F7D RID: 28541
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006F7E RID: 28542
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04006F7F RID: 28543
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006F80 RID: 28544
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04006F81 RID: 28545
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04006F82 RID: 28546
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_1;

		// Token: 0x04006F83 RID: 28547
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Public_Void_0;

		// Token: 0x04006F84 RID: 28548
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006F85 RID: 28549
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006F86 RID: 28550
		private static readonly IntPtr NativeMethodInfoPtr_LocalPurchase_Private_Void_1;

		// Token: 0x04006F87 RID: 28551
		private static readonly IntPtr NativeMethodInfoPtr_SendPurchase_Public_Void_0;

		// Token: 0x04006F88 RID: 28552
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0;

		// Token: 0x04006F89 RID: 28553
		private static readonly IntPtr NativeMethodInfoPtr_DropItem_Public_Void_0;

		// Token: 0x04006F8A RID: 28554
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0;

		// Token: 0x04006F8B RID: 28555
		private static readonly IntPtr NativeMethodInfoPtr_Impacted_Private_Void_Impact_0;

		// Token: 0x04006F8C RID: 28556
		private static readonly IntPtr NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0;

		// Token: 0x04006F8D RID: 28557
		private static readonly IntPtr NativeMethodInfoPtr_SendBreak_Private_Void_1;

		// Token: 0x04006F8E RID: 28558
		private static readonly IntPtr NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0;

		// Token: 0x04006F8F RID: 28559
		private static readonly IntPtr NativeMethodInfoPtr_Repair_Private_Void_1;

		// Token: 0x04006F90 RID: 28560
		private static readonly IntPtr NativeMethodInfoPtr_DropCash_Private_Void_1;

		// Token: 0x04006F91 RID: 28561
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0;

		// Token: 0x04006F92 RID: 28562
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0;

		// Token: 0x04006F93 RID: 28563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F94 RID: 28564
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006F95 RID: 28565
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04006F96 RID: 28566
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04006F97 RID: 28567
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006F98 RID: 28568
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006F99 RID: 28569
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006F9A RID: 28570
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1;

		// Token: 0x04006F9B RID: 28571
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0;

		// Token: 0x04006F9C RID: 28572
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F9D RID: 28573
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1;

		// Token: 0x04006F9E RID: 28574
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0;

		// Token: 0x04006F9F RID: 28575
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FA0 RID: 28576
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1;

		// Token: 0x04006FA1 RID: 28577
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0;

		// Token: 0x04006FA2 RID: 28578
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FA3 RID: 28579
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1;

		// Token: 0x04006FA4 RID: 28580
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1;

		// Token: 0x04006FA5 RID: 28581
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FA6 RID: 28582
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FA7 RID: 28583
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FA8 RID: 28584
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FA9 RID: 28585
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FAA RID: 28586
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FAB RID: 28587
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1;

		// Token: 0x04006FAC RID: 28588
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1;

		// Token: 0x04006FAD RID: 28589
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FAE RID: 28590
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1;

		// Token: 0x04006FAF RID: 28591
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1;

		// Token: 0x04006FB0 RID: 28592
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FB1 RID: 28593
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000BD0 RID: 3024
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__BreakRoutine|64_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE51 RID: 56913 RVA: 0x003471F8 File Offset: 0x003453F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__BreakRoutine|64_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<cashDrop>5__2");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<i>5__3");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683661);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683662);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683663);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683664);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683665);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683666);
			}

			// Token: 0x0600DE52 RID: 56914 RVA: 0x00347300 File Offset: 0x00345500
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE53 RID: 56915 RVA: 0x00347348 File Offset: 0x00345548
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE54 RID: 56916 RVA: 0x0034737C File Offset: 0x0034557C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289772, XrefRangeEnd = 289798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x003473B8 File Offset: 0x003455B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE56 RID: 56918 RVA: 0x003473F8 File Offset: 0x003455F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289798, XrefRangeEnd = 289803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044EF RID: 17647
			// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x0034742C File Offset: 0x0034562C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE58 RID: 56920 RVA: 0x0006C658 File Offset: 0x0006A858
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x0034746C File Offset: 0x0034566C
			// (set) Token: 0x0600DE5A RID: 56922 RVA: 0x0006C661 File Offset: 0x0006A861
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0600DE5B RID: 56923 RVA: 0x00347494 File Offset: 0x00345694
			// (set) Token: 0x0600DE5C RID: 56924 RVA: 0x0006C67C File Offset: 0x0006A87C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x003474C4 File Offset: 0x003456C4
			// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x0006C69B File Offset: 0x0006A89B
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x003474F4 File Offset: 0x003456F4
			// (set) Token: 0x0600DE60 RID: 56928 RVA: 0x0006C6BA File Offset: 0x0006A8BA
			public unsafe int _cashDrop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2)) = value;
				}
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0600DE61 RID: 56929 RVA: 0x0034751C File Offset: 0x0034571C
			// (set) Token: 0x0600DE62 RID: 56930 RVA: 0x0006C6D5 File Offset: 0x0006A8D5
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040094DB RID: 38107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094DC RID: 38108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094DD RID: 38109
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094DE RID: 38110
			private static readonly IntPtr NativeFieldInfoPtr__cashDrop_5__2;

			// Token: 0x040094DF RID: 38111
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040094E0 RID: 38112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094E1 RID: 38113
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E2 RID: 38114
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094E3 RID: 38115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094E4 RID: 38116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094E5 RID: 38117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD1 RID: 3025
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__Drop|64_1>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE63 RID: 56931 RVA: 0x00347544 File Offset: 0x00345744
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__Drop|64_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683667);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683668);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683669);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683670);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683671);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683672);
			}

			// Token: 0x0600DE64 RID: 56932 RVA: 0x00347624 File Offset: 0x00345824
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE65 RID: 56933 RVA: 0x0034766C File Offset: 0x0034586C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE66 RID: 56934 RVA: 0x003476A0 File Offset: 0x003458A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289803, XrefRangeEnd = 289808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044F3 RID: 17651
			// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x003476DC File Offset: 0x003458DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE68 RID: 56936 RVA: 0x0034771C File Offset: 0x0034591C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289808, XrefRangeEnd = 289813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044F4 RID: 17652
			// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x00347750 File Offset: 0x00345950
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE6A RID: 56938 RVA: 0x0006C6F0 File Offset: 0x0006A8F0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F0 RID: 17648
			// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x00347790 File Offset: 0x00345990
			// (set) Token: 0x0600DE6C RID: 56940 RVA: 0x0006C6F9 File Offset: 0x0006A8F9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044F1 RID: 17649
			// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x003477B8 File Offset: 0x003459B8
			// (set) Token: 0x0600DE6E RID: 56942 RVA: 0x0006C714 File Offset: 0x0006A914
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F2 RID: 17650
			// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x003477E8 File Offset: 0x003459E8
			// (set) Token: 0x0600DE70 RID: 56944 RVA: 0x0006C733 File Offset: 0x0006A933
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094E6 RID: 38118
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094E7 RID: 38119
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094E8 RID: 38120
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094E9 RID: 38121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094EA RID: 38122
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094EB RID: 38123
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094EC RID: 38124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094ED RID: 38125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094EE RID: 38126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD2 RID: 3026
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<PurchaseRoutine>g__Routine|61_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600DE71 RID: 56945 RVA: 0x00347818 File Offset: 0x00345A18
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<PurchaseRoutine>g__Routine|61_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683673);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683674);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683675);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683676);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683677);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683678);
			}

			// Token: 0x0600DE72 RID: 56946 RVA: 0x003478F8 File Offset: 0x00345AF8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE73 RID: 56947 RVA: 0x00347940 File Offset: 0x00345B40
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE74 RID: 56948 RVA: 0x00347974 File Offset: 0x00345B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289813, XrefRangeEnd = 289819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044F8 RID: 17656
			// (get) Token: 0x0600DE75 RID: 56949 RVA: 0x003479B0 File Offset: 0x00345BB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE76 RID: 56950 RVA: 0x003479F0 File Offset: 0x00345BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289819, XrefRangeEnd = 289824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044F9 RID: 17657
			// (get) Token: 0x0600DE77 RID: 56951 RVA: 0x00347A24 File Offset: 0x00345C24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE78 RID: 56952 RVA: 0x0006C752 File Offset: 0x0006A952
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F5 RID: 17653
			// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00347A64 File Offset: 0x00345C64
			// (set) Token: 0x0600DE7A RID: 56954 RVA: 0x0006C75B File Offset: 0x0006A95B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044F6 RID: 17654
			// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x00347A8C File Offset: 0x00345C8C
			// (set) Token: 0x0600DE7C RID: 56956 RVA: 0x0006C776 File Offset: 0x0006A976
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F7 RID: 17655
			// (get) Token: 0x0600DE7D RID: 56957 RVA: 0x00347ABC File Offset: 0x00345CBC
			// (set) Token: 0x0600DE7E RID: 56958 RVA: 0x0006C795 File Offset: 0x0006A995
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094EF RID: 38127
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094F0 RID: 38128
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094F1 RID: 38129
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094F2 RID: 38130
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094F3 RID: 38131
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F4 RID: 38132
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094F5 RID: 38133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094F6 RID: 38134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F7 RID: 38135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
