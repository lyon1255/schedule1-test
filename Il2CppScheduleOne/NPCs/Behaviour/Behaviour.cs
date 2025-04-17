using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000340 RID: 832
	public class Behaviour : NetworkBehaviour
	{
		// Token: 0x06003D28 RID: 15656 RVA: 0x0013754C File Offset: 0x0013574C
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			Behaviour.NativeFieldInfoPtr_EnabledOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "EnabledOnAwake");
			Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Enabled>k__BackingField");
			Behaviour.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Name");
			Behaviour.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Priority");
			Behaviour.NativeFieldInfoPtr__Started_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Started>k__BackingField");
			Behaviour.NativeFieldInfoPtr__Active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Active>k__BackingField");
			Behaviour.NativeFieldInfoPtr__beh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<beh>k__BackingField");
			Behaviour.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnable");
			Behaviour.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onDisable");
			Behaviour.NativeFieldInfoPtr_onBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onBegin");
			Behaviour.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnd");
			Behaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "consecutivePathingFailures");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670430);
			Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670431);
			Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670432);
			Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670433);
			Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670434);
			Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670435);
			Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670436);
			Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670437);
			Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670438);
			Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670439);
			Behaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670440);
			Behaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670441);
			Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670442);
			Behaviour.NativeMethodInfoPtr_SendEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670443);
			Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670444);
			Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670445);
			Behaviour.NativeMethodInfoPtr_SendDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670446);
			Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670447);
			Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670448);
			Behaviour.NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670449);
			Behaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670450);
			Behaviour.NativeMethodInfoPtr_SendEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670451);
			Behaviour.NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670452);
			Behaviour.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670453);
			Behaviour.NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670454);
			Behaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670455);
			Behaviour.NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670456);
			Behaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670457);
			Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670458);
			Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670459);
			Behaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670460);
			Behaviour.NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670461);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670462);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670463);
			Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670464);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670465);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670466);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670467);
			Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670468);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670469);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670470);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670471);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670472);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670473);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670474);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670475);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670476);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670477);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670478);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670479);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670480);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670481);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670482);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670483);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670484);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670485);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670486);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670487);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670488);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670489);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670490);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670491);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670492);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670493);
			Behaviour.NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670494);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670495);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670496);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670497);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670498);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670499);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670500);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670501);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670502);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670503);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670504);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670505);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670506);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670507);
			Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670508);
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00137CD4 File Offset: 0x00135ED4
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00137D10 File Offset: 0x00135F10
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x00137D50 File Offset: 0x00135F50
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x00137D8C File Offset: 0x00135F8C
		public unsafe bool Started
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x00137DCC File Offset: 0x00135FCC
		// (set) Token: 0x06003D2E RID: 15662 RVA: 0x00137E08 File Offset: 0x00136008
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x00137E48 File Offset: 0x00136048
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x00137E88 File Offset: 0x00136088
		public unsafe NPCBehaviour beh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143265, XrefRangeEnd = 143266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00137ECC File Offset: 0x001360CC
		public unsafe NPC Npc
		{
			[CallerCount(565)]
			[CachedScanResults(RefRangeStart = 143266, RefRangeEnd = 143831, XrefRangeStart = 143266, XrefRangeEnd = 143266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00137F0C File Offset: 0x0013610C
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 143835, RefRangeEnd = 143882, XrefRangeStart = 143831, XrefRangeEnd = 143835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00137F48 File Offset: 0x00136148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143885, RefRangeEnd = 143887, XrefRangeStart = 143882, XrefRangeEnd = 143885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00137F98 File Offset: 0x00136198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143887, XrefRangeEnd = 143889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00137FD4 File Offset: 0x001361D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143897, RefRangeEnd = 143899, XrefRangeStart = 143889, XrefRangeEnd = 143897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00138010 File Offset: 0x00136210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143920, RefRangeEnd = 143923, XrefRangeStart = 143899, XrefRangeEnd = 143920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00138044 File Offset: 0x00136244
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 143959, RefRangeEnd = 144002, XrefRangeStart = 143923, XrefRangeEnd = 143959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x00138088 File Offset: 0x00136288
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 144010, RefRangeEnd = 144032, XrefRangeStart = 144002, XrefRangeEnd = 144010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x001380C4 File Offset: 0x001362C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 144053, RefRangeEnd = 144060, XrefRangeStart = 144032, XrefRangeEnd = 144053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x001380F8 File Offset: 0x001362F8
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 144096, RefRangeEnd = 144154, XrefRangeStart = 144060, XrefRangeEnd = 144096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x0013813C File Offset: 0x0013633C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 144175, RefRangeEnd = 144180, XrefRangeStart = 144154, XrefRangeEnd = 144175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00138170 File Offset: 0x00136370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144216, RefRangeEnd = 144218, XrefRangeStart = 144180, XrefRangeEnd = 144216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x001381B4 File Offset: 0x001363B4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 144230, RefRangeEnd = 144261, XrefRangeStart = 144218, XrefRangeEnd = 144230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x001381F0 File Offset: 0x001363F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144282, RefRangeEnd = 144283, XrefRangeStart = 144261, XrefRangeEnd = 144282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00138224 File Offset: 0x00136424
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 144319, RefRangeEnd = 144338, XrefRangeStart = 144283, XrefRangeEnd = 144319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00138268 File Offset: 0x00136468
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 144350, RefRangeEnd = 144383, XrefRangeStart = 144338, XrefRangeEnd = 144350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001382A4 File Offset: 0x001364A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144419, RefRangeEnd = 144420, XrefRangeStart = 144383, XrefRangeEnd = 144419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x001382E8 File Offset: 0x001364E8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 144431, RefRangeEnd = 144456, XrefRangeStart = 144420, XrefRangeEnd = 144431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x00138324 File Offset: 0x00136524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144492, RefRangeEnd = 144493, XrefRangeStart = 144456, XrefRangeEnd = 144492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00138368 File Offset: 0x00136568
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 144505, RefRangeEnd = 144532, XrefRangeStart = 144493, XrefRangeEnd = 144505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001383A4 File Offset: 0x001365A4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x001383E0 File Offset: 0x001365E0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourLateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x0013841C File Offset: 0x0013661C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00138458 File Offset: 0x00136658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144532, XrefRangeEnd = 144534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPriority(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00138498 File Offset: 0x00136698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144534, XrefRangeEnd = 144540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitEntity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001384E8 File Offset: 0x001366E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 144557, RefRangeEnd = 144567, XrefRangeStart = 144540, XrefRangeEnd = 144557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00138534 File Offset: 0x00136734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144567, XrefRangeEnd = 144578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00138580 File Offset: 0x00136780
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 143223, RefRangeEnd = 143260, XrefRangeStart = 143223, XrefRangeEnd = 143260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x001385BC File Offset: 0x001367BC
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 144670, RefRangeEnd = 144708, XrefRangeStart = 144578, XrefRangeEnd = 144670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x001385F8 File Offset: 0x001367F8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 144708, RefRangeEnd = 144745, XrefRangeStart = 144708, XrefRangeEnd = 144708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00138634 File Offset: 0x00136834
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00138670 File Offset: 0x00136870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144745, XrefRangeEnd = 144763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEnable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x001386A4 File Offset: 0x001368A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144763, XrefRangeEnd = 144764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEnable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x001386D8 File Offset: 0x001368D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144764, XrefRangeEnd = 144767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEnable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0013873C File Offset: 0x0013693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144767, XrefRangeEnd = 144785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00138780 File Offset: 0x00136980
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 144785, RefRangeEnd = 144827, XrefRangeStart = 144785, XrefRangeEnd = 144785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x001387C4 File Offset: 0x001369C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144827, XrefRangeEnd = 144829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00138814 File Offset: 0x00136A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144829, XrefRangeEnd = 144847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00138858 File Offset: 0x00136A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144847, XrefRangeEnd = 144849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x001388A8 File Offset: 0x00136AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144849, XrefRangeEnd = 144867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDisable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x001388DC File Offset: 0x00136ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144867, XrefRangeEnd = 144868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDisable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00138910 File Offset: 0x00136B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144868, XrefRangeEnd = 144871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDisable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x00138974 File Offset: 0x00136B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144871, XrefRangeEnd = 144889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x001389B8 File Offset: 0x00136BB8
		[CallerCount(0)]
		public unsafe void RpcLogic___Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x001389FC File Offset: 0x00136BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144889, XrefRangeEnd = 144891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00138A4C File Offset: 0x00136C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144891, XrefRangeEnd = 144909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00138A90 File Offset: 0x00136C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144909, XrefRangeEnd = 144911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00138AE0 File Offset: 0x00136CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144911, XrefRangeEnd = 144929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00138B24 File Offset: 0x00136D24
		[CallerCount(0)]
		public unsafe void RpcLogic___Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00138B68 File Offset: 0x00136D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144929, XrefRangeEnd = 144931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00138BB8 File Offset: 0x00136DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144931, XrefRangeEnd = 144949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00138BFC File Offset: 0x00136DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144949, XrefRangeEnd = 144951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x00138C4C File Offset: 0x00136E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144951, XrefRangeEnd = 144969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEnd_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00138C80 File Offset: 0x00136E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144969, XrefRangeEnd = 144970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEnd_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00138CB4 File Offset: 0x00136EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144970, XrefRangeEnd = 144973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEnd_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00138D18 File Offset: 0x00136F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144973, XrefRangeEnd = 144991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00138D5C File Offset: 0x00136F5C
		[CallerCount(0)]
		public unsafe void RpcLogic___End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x00138DA0 File Offset: 0x00136FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144991, XrefRangeEnd = 144993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00138DF0 File Offset: 0x00136FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144993, XrefRangeEnd = 145011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00138E34 File Offset: 0x00137034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145011, XrefRangeEnd = 145013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00138E84 File Offset: 0x00137084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145013, XrefRangeEnd = 145031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00138EC8 File Offset: 0x001370C8
		[CallerCount(0)]
		public unsafe void RpcLogic___Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00138F0C File Offset: 0x0013710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145031, XrefRangeEnd = 145033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00138F5C File Offset: 0x0013715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145033, XrefRangeEnd = 145051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00138FA0 File Offset: 0x001371A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145051, XrefRangeEnd = 145053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00138FF0 File Offset: 0x001371F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145053, XrefRangeEnd = 145071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x00139034 File Offset: 0x00137234
		[CallerCount(0)]
		public unsafe void RpcLogic___Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x00139078 File Offset: 0x00137278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145071, XrefRangeEnd = 145073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D75 RID: 15733 RVA: 0x001390C8 File Offset: 0x001372C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145073, XrefRangeEnd = 145091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x0013910C File Offset: 0x0013730C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145091, XrefRangeEnd = 145093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x0013915C File Offset: 0x0013735C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145093, XrefRangeEnd = 145097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x0001EEAD File Offset: 0x0001D0AD
		public Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00139198 File Offset: 0x00137398
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x0001EEB6 File Offset: 0x0001D0B6
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x001391B4 File Offset: 0x001373B4
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
		public unsafe bool EnabledOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake)) = value;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x001391DC File Offset: 0x001373DC
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x0001EEDF File Offset: 0x0001D0DF
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x00139204 File Offset: 0x00137404
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x0001EEFA File Offset: 0x0001D0FA
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x0013922C File Offset: 0x0013742C
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x0001EF19 File Offset: 0x0001D119
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00139254 File Offset: 0x00137454
		// (set) Token: 0x06003D84 RID: 15748 RVA: 0x0001EF34 File Offset: 0x0001D134
		public unsafe bool _Started_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField)) = value;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x0013927C File Offset: 0x0013747C
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x0001EF4F File Offset: 0x0001D14F
		public unsafe bool _Active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField)) = value;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x001392A4 File Offset: 0x001374A4
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x0001EF6A File Offset: 0x0001D16A
		public unsafe NPCBehaviour _beh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x001392D4 File Offset: 0x001374D4
		// (set) Token: 0x06003D8A RID: 15754 RVA: 0x0001EF89 File Offset: 0x0001D189
		public unsafe UnityEvent onEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003D8B RID: 15755 RVA: 0x00139304 File Offset: 0x00137504
		// (set) Token: 0x06003D8C RID: 15756 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		public unsafe UnityEvent onDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003D8D RID: 15757 RVA: 0x00139334 File Offset: 0x00137534
		// (set) Token: 0x06003D8E RID: 15758 RVA: 0x0001EFC7 File Offset: 0x0001D1C7
		public unsafe UnityEvent onBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x00139364 File Offset: 0x00137564
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x0001EFE6 File Offset: 0x0001D1E6
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00139394 File Offset: 0x00137594
		// (set) Token: 0x06003D92 RID: 15762 RVA: 0x0001F005 File Offset: 0x0001D205
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06003D93 RID: 15763 RVA: 0x001393BC File Offset: 0x001375BC
		// (set) Token: 0x06003D94 RID: 15764 RVA: 0x0001F020 File Offset: 0x0001D220
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x001393E4 File Offset: 0x001375E4
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x0001F03B File Offset: 0x0001D23B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeFieldInfoPtr_EnabledOnAwake;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeFieldInfoPtr__Started_k__BackingField;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeFieldInfoPtr__Active_k__BackingField;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeFieldInfoPtr__beh_k__BackingField;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeFieldInfoPtr_onEnable;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeFieldInfoPtr_onDisable;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeFieldInfoPtr_onBegin;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_get_Started_Public_get_Boolean_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr_SendEnable_Public_Void_0;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeMethodInfoPtr_SendDisable_Public_Void_0;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_SendEnd_Public_Void_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
