using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000343 RID: 835
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x06003E0F RID: 15887 RVA: 0x0013ACA8 File Offset: 0x00138EA8
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointBehaviour()
		{
			Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CheckpointBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr);
			CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "LOOK_TIME");
			CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<AssignedCheckpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Checkpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<CurrentSearchedVehicle>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Initiator>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "currentLookTime");
			CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "trunkOpened");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670561);
			CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670562);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670563);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670564);
			CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670565);
			CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670566);
			CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670567);
			CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670568);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670569);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670570);
			CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670571);
			CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670572);
			CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670573);
			CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670574);
			CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670575);
			CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670576);
			CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670577);
			CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670578);
			CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670579);
			CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670580);
			CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670581);
			CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670582);
			CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670583);
			CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670584);
			CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670585);
			CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670586);
			CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670587);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670588);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670589);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670590);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670591);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670592);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670593);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670594);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670595);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670596);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670597);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670598);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670599);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670600);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670601);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670602);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670603);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670604);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670605);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670606);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670607);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670608);
			CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670609);
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06003E10 RID: 15888 RVA: 0x0013B174 File Offset: 0x00139374
		// (set) Token: 0x06003E11 RID: 15889 RVA: 0x0013B1B0 File Offset: 0x001393B0
		public unsafe CheckpointManager.ECheckpointLocation AssignedCheckpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06003E12 RID: 15890 RVA: 0x0013B1F0 File Offset: 0x001393F0
		// (set) Token: 0x06003E13 RID: 15891 RVA: 0x0013B230 File Offset: 0x00139430
		public unsafe RoadCheckpoint Checkpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06003E14 RID: 15892 RVA: 0x0013B274 File Offset: 0x00139474
		// (set) Token: 0x06003E15 RID: 15893 RVA: 0x0013B2B0 File Offset: 0x001394B0
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x0013B2F0 File Offset: 0x001394F0
		// (set) Token: 0x06003E17 RID: 15895 RVA: 0x0013B330 File Offset: 0x00139530
		public unsafe LandVehicle CurrentSearchedVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145715, XrefRangeEnd = 145716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x0013B374 File Offset: 0x00139574
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x0013B3B4 File Offset: 0x001395B4
		public unsafe Player Initiator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145716, XrefRangeEnd = 145717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x0013B3F8 File Offset: 0x001395F8
		public unsafe Transform standPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 145722, RefRangeEnd = 145725, XrefRangeStart = 145717, XrefRangeEnd = 145722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x0013B438 File Offset: 0x00139638
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145725, XrefRangeEnd = 145726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x0013B478 File Offset: 0x00139678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145726, XrefRangeEnd = 145751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x0013B4B4 File Offset: 0x001396B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145751, XrefRangeEnd = 145776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0013B4F0 File Offset: 0x001396F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145776, XrefRangeEnd = 145800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x0013B52C File Offset: 0x0013972C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145800, XrefRangeEnd = 145824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x0013B568 File Offset: 0x00139768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145824, XrefRangeEnd = 145908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x0013B5A4 File Offset: 0x001397A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145928, RefRangeEnd = 145929, XrefRangeStart = 145908, XrefRangeEnd = 145928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x0013B5E4 File Offset: 0x001397E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145929, XrefRangeEnd = 145954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInitiator(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x0013B628 File Offset: 0x00139828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145977, RefRangeEnd = 145978, XrefRangeStart = 145954, XrefRangeEnd = 145977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x0013B67C File Offset: 0x0013987C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145999, RefRangeEnd = 146001, XrefRangeStart = 145978, XrefRangeEnd = 145999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x0013B6B0 File Offset: 0x001398B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146023, RefRangeEnd = 146025, XrefRangeStart = 146001, XrefRangeEnd = 146023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSearching(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x0013B6F0 File Offset: 0x001398F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146030, RefRangeEnd = 146033, XrefRangeStart = 146025, XrefRangeEnd = 146030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetSearchPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x0013B72C File Offset: 0x0013992C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146033, XrefRangeEnd = 146054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcludeSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x0013B760 File Offset: 0x00139960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146107, RefRangeEnd = 146108, XrefRangeStart = 146054, XrefRangeEnd = 146107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesVehicleContainIllicitItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x0013B79C File Offset: 0x0013999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146108, XrefRangeEnd = 146163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerWalkedThroughCheckPoint(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x0013B7E0 File Offset: 0x001399E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x0013B81C File Offset: 0x00139A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146163, XrefRangeEnd = 146202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x0013B858 File Offset: 0x00139A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146202, XrefRangeEnd = 146203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x0013B894 File Offset: 0x00139A94
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0013B8D0 File Offset: 0x00139AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146203, XrefRangeEnd = 146222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0013B910 File Offset: 0x00139B10
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0013B950 File Offset: 0x00139B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146222, XrefRangeEnd = 146225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0013B9A0 File Offset: 0x00139BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146225, XrefRangeEnd = 146244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0013B9E4 File Offset: 0x00139BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146244, XrefRangeEnd = 146249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0013BA28 File Offset: 0x00139C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146249, XrefRangeEnd = 146256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x0013BA78 File Offset: 0x00139C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146256, XrefRangeEnd = 146276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0013BACC File Offset: 0x00139CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146314, RefRangeEnd = 146317, XrefRangeStart = 146276, XrefRangeEnd = 146314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x0013BB20 File Offset: 0x00139D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146317, XrefRangeEnd = 146322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x0013BB84 File Offset: 0x00139D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146322, XrefRangeEnd = 146340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x0013BBB8 File Offset: 0x00139DB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146353, RefRangeEnd = 146355, XrefRangeStart = 146340, XrefRangeEnd = 146353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x0013BBEC File Offset: 0x00139DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146355, XrefRangeEnd = 146358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x0013BC50 File Offset: 0x00139E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146358, XrefRangeEnd = 146377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0013BC90 File Offset: 0x00139E90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146382, RefRangeEnd = 146384, XrefRangeStart = 146377, XrefRangeEnd = 146382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0013BCD0 File Offset: 0x00139ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146384, XrefRangeEnd = 146387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x0013BD20 File Offset: 0x00139F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146387, XrefRangeEnd = 146405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0013BD54 File Offset: 0x00139F54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 146465, RefRangeEnd = 146470, XrefRangeStart = 146405, XrefRangeEnd = 146465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0013BD88 File Offset: 0x00139F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146470, XrefRangeEnd = 146473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0013BDD8 File Offset: 0x00139FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x0001F384 File Offset: 0x0001D584
		public CheckpointBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003E42 RID: 15938 RVA: 0x0013BE14 File Offset: 0x0013A014
		// (set) Token: 0x06003E43 RID: 15939 RVA: 0x0001F38D File Offset: 0x0001D58D
		public unsafe static float LOOK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003E44 RID: 15940 RVA: 0x0013BE30 File Offset: 0x0013A030
		// (set) Token: 0x06003E45 RID: 15941 RVA: 0x0001F39B File Offset: 0x0001D59B
		public unsafe CheckpointManager.ECheckpointLocation _AssignedCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06003E46 RID: 15942 RVA: 0x0013BE58 File Offset: 0x0013A058
		// (set) Token: 0x06003E47 RID: 15943 RVA: 0x0001F3B6 File Offset: 0x0001D5B6
		public unsafe RoadCheckpoint _Checkpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06003E48 RID: 15944 RVA: 0x0013BE88 File Offset: 0x0013A088
		// (set) Token: 0x06003E49 RID: 15945 RVA: 0x0001F3D5 File Offset: 0x0001D5D5
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06003E4A RID: 15946 RVA: 0x0013BEB0 File Offset: 0x0013A0B0
		// (set) Token: 0x06003E4B RID: 15947 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		public unsafe LandVehicle _CurrentSearchedVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003E4C RID: 15948 RVA: 0x0013BEE0 File Offset: 0x0013A0E0
		// (set) Token: 0x06003E4D RID: 15949 RVA: 0x0001F40F File Offset: 0x0001D60F
		public unsafe Player _Initiator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x0013BF10 File Offset: 0x0013A110
		// (set) Token: 0x06003E4F RID: 15951 RVA: 0x0001F42E File Offset: 0x0001D62E
		public unsafe float currentLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime)) = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003E50 RID: 15952 RVA: 0x0013BF38 File Offset: 0x0013A138
		// (set) Token: 0x06003E51 RID: 15953 RVA: 0x0001F449 File Offset: 0x0001D649
		public unsafe bool trunkOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened)) = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003E52 RID: 15954 RVA: 0x0013BF60 File Offset: 0x0013A160
		// (set) Token: 0x06003E53 RID: 15955 RVA: 0x0001F464 File Offset: 0x0001D664
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x0013BF88 File Offset: 0x0013A188
		// (set) Token: 0x06003E55 RID: 15957 RVA: 0x0001F47F File Offset: 0x0001D67F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr_LOOK_TIME;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr__Checkpoint_k__BackingField;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeFieldInfoPtr__Initiator_k__BackingField;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeFieldInfoPtr_currentLookTime;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr_trunkOpened;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_get_Initiator_Public_get_Player_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_StopSearch_Public_Void_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Private_Void_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200093E RID: 2366
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.CheckpointBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C759 RID: 51033 RVA: 0x00305C78 File Offset: 0x00303E78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr);
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9");
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9__39_0");
				CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670611);
				CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670612);
			}

			// Token: 0x0600C75A RID: 51034 RVA: 0x00305CF4 File Offset: 0x00303EF4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C75B RID: 51035 RVA: 0x00305D30 File Offset: 0x00303F30
			[CallerCount(0)]
			public unsafe ItemInstance _DoesVehicleContainIllicitItems_b__39_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}

			// Token: 0x0600C75C RID: 51036 RVA: 0x00061013 File Offset: 0x0005F213
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E1E RID: 15902
			// (get) Token: 0x0600C75D RID: 51037 RVA: 0x00305D80 File Offset: 0x00303F80
			// (set) Token: 0x0600C75E RID: 51038 RVA: 0x0006101C File Offset: 0x0005F21C
			public unsafe static CheckpointBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E1F RID: 15903
			// (get) Token: 0x0600C75F RID: 51039 RVA: 0x00305DA8 File Offset: 0x00303FA8
			// (set) Token: 0x0600C760 RID: 51040 RVA: 0x0006102E File Offset: 0x0005F22E
			public unsafe static Func<ItemSlot, ItemInstance> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, ItemInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086ED RID: 34541
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040086EE RID: 34542
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040086EF RID: 34543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040086F0 RID: 34544
			private static readonly IntPtr NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0;
		}
	}
}
