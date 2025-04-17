using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200035E RID: 862
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x0600423D RID: 16957 RVA: 0x0014AF2C File Offset: 0x0014912C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCBehaviour()
		{
			Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "NPCBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr);
			NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DEBUG_MODE");
			NPCBehaviour.NativeFieldInfoPtr_ScheduleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ScheduleManager");
			NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CoweringBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RagdollBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CallPoliceBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "GenericDialogueBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "HeavyFlinchBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FacePlayerBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DeadBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "UnconsciousBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "SummonBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ConsumeProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CombatBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FleeBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "StationaryBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RequestProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_behaviourStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "behaviourStack");
			NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<activeBehaviour>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<Npc>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr_summonRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "summonRoutine");
			NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "enabledBehaviours");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671365);
			NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671366);
			NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671367);
			NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671368);
			NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671369);
			NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671370);
			NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671371);
			NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671372);
			NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671373);
			NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671374);
			NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671375);
			NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671376);
			NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671377);
			NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671378);
			NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671379);
			NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671380);
			NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671381);
			NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671382);
			NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671383);
			NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671384);
			NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671385);
			NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671386);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671387);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671388);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671389);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671390);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671391);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671392);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671393);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671394);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671395);
			NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671396);
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600423E RID: 16958 RVA: 0x0014B3A8 File Offset: 0x001495A8
		// (set) Token: 0x0600423F RID: 16959 RVA: 0x0014B3E8 File Offset: 0x001495E8
		public unsafe Behaviour activeBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152268, XrefRangeEnd = 152269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x0014B42C File Offset: 0x0014962C
		// (set) Token: 0x06004241 RID: 16961 RVA: 0x0014B46C File Offset: 0x0014966C
		public unsafe NPC Npc
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 131864, RefRangeEnd = 131874, XrefRangeStart = 131864, XrefRangeEnd = 131874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004242 RID: 16962 RVA: 0x0014B4B0 File Offset: 0x001496B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152269, XrefRangeEnd = 152283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x0014B4EC File Offset: 0x001496EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152283, XrefRangeEnd = 152340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x0014B528 File Offset: 0x00149728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152340, XrefRangeEnd = 152356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x0014B55C File Offset: 0x0014975C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152356, XrefRangeEnd = 152386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0014B598 File Offset: 0x00149798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152386, XrefRangeEnd = 152392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x0014B5E8 File Offset: 0x001497E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152393, RefRangeEnd = 152394, XrefRangeStart = 152392, XrefRangeEnd = 152393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Summon(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x0014B648 File Offset: 0x00149848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152413, RefRangeEnd = 152414, XrefRangeStart = 152394, XrefRangeEnd = 152413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x0014B68C File Offset: 0x0014988C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152414, XrefRangeEnd = 152448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnKnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x0014B6C8 File Offset: 0x001498C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152448, XrefRangeEnd = 152450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x0014B704 File Offset: 0x00149904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152477, RefRangeEnd = 152478, XrefRangeStart = 152450, XrefRangeEnd = 152477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetBehaviour(string BehaviourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(BehaviourName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x0014B754 File Offset: 0x00149954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152478, XrefRangeEnd = 152509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x0014B790 File Offset: 0x00149990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152509, XrefRangeEnd = 152513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x0014B7CC File Offset: 0x001499CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152513, XrefRangeEnd = 152517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x0014B808 File Offset: 0x00149A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152539, RefRangeEnd = 152540, XrefRangeStart = 152517, XrefRangeEnd = 152539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortBehaviourStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x0014B83C File Offset: 0x00149A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152540, XrefRangeEnd = 152543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetEnabledBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0014B87C File Offset: 0x00149A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152543, XrefRangeEnd = 152571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x0014B8C0 File Offset: 0x00149AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152571, XrefRangeEnd = 152599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x0014B904 File Offset: 0x00149B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152599, XrefRangeEnd = 152612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0014B940 File Offset: 0x00149B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152612, XrefRangeEnd = 152625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0014B97C File Offset: 0x00149B7C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0014B9B8 File Offset: 0x00149BB8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0014B9F4 File Offset: 0x00149BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152648, RefRangeEnd = 152649, XrefRangeStart = 152625, XrefRangeEnd = 152648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0014BA54 File Offset: 0x00149C54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152681, RefRangeEnd = 152682, XrefRangeStart = 152649, XrefRangeEnd = 152681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x0014BAB4 File Offset: 0x00149CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152682, XrefRangeEnd = 152688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0014BB18 File Offset: 0x00149D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152413, RefRangeEnd = 152414, XrefRangeStart = 152413, XrefRangeEnd = 152414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0014BB5C File Offset: 0x00149D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152688, XrefRangeEnd = 152691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0014BBA0 File Offset: 0x00149DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152691, XrefRangeEnd = 152695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0014BC04 File Offset: 0x00149E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152695, XrefRangeEnd = 152709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x000207CD File Offset: 0x0001E9CD
		public NPCBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600425F RID: 16991 RVA: 0x0014BC40 File Offset: 0x00149E40
		// (set) Token: 0x06004260 RID: 16992 RVA: 0x000207D6 File Offset: 0x0001E9D6
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06004261 RID: 16993 RVA: 0x0014BC68 File Offset: 0x00149E68
		// (set) Token: 0x06004262 RID: 16994 RVA: 0x000207F1 File Offset: 0x0001E9F1
		public unsafe NPCScheduleManager ScheduleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06004263 RID: 16995 RVA: 0x0014BC98 File Offset: 0x00149E98
		// (set) Token: 0x06004264 RID: 16996 RVA: 0x00020810 File Offset: 0x0001EA10
		public unsafe CoweringBehaviour CoweringBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoweringBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06004265 RID: 16997 RVA: 0x0014BCC8 File Offset: 0x00149EC8
		// (set) Token: 0x06004266 RID: 16998 RVA: 0x0002082F File Offset: 0x0001EA2F
		public unsafe RagdollBehaviour RagdollBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RagdollBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06004267 RID: 16999 RVA: 0x0014BCF8 File Offset: 0x00149EF8
		// (set) Token: 0x06004268 RID: 17000 RVA: 0x0002084E File Offset: 0x0001EA4E
		public unsafe CallPoliceBehaviour CallPoliceBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallPoliceBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06004269 RID: 17001 RVA: 0x0014BD28 File Offset: 0x00149F28
		// (set) Token: 0x0600426A RID: 17002 RVA: 0x0002086D File Offset: 0x0001EA6D
		public unsafe GenericDialogueBehaviour GenericDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDialogueBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600426B RID: 17003 RVA: 0x0014BD58 File Offset: 0x00149F58
		// (set) Token: 0x0600426C RID: 17004 RVA: 0x0002088C File Offset: 0x0001EA8C
		public unsafe HeavyFlinchBehaviour HeavyFlinchBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyFlinchBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x0014BD88 File Offset: 0x00149F88
		// (set) Token: 0x0600426E RID: 17006 RVA: 0x000208AB File Offset: 0x0001EAAB
		public unsafe FacePlayerBehaviour FacePlayerBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacePlayerBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x0014BDB8 File Offset: 0x00149FB8
		// (set) Token: 0x06004270 RID: 17008 RVA: 0x000208CA File Offset: 0x0001EACA
		public unsafe DeadBehaviour DeadBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x0014BDE8 File Offset: 0x00149FE8
		// (set) Token: 0x06004272 RID: 17010 RVA: 0x000208E9 File Offset: 0x0001EAE9
		public unsafe UnconsciousBehaviour UnconsciousBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnconsciousBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x0014BE18 File Offset: 0x0014A018
		// (set) Token: 0x06004274 RID: 17012 RVA: 0x00020908 File Offset: 0x0001EB08
		public unsafe Behaviour SummonBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x0014BE48 File Offset: 0x0014A048
		// (set) Token: 0x06004276 RID: 17014 RVA: 0x00020927 File Offset: 0x0001EB27
		public unsafe ConsumeProductBehaviour ConsumeProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06004277 RID: 17015 RVA: 0x0014BE78 File Offset: 0x0014A078
		// (set) Token: 0x06004278 RID: 17016 RVA: 0x00020946 File Offset: 0x0001EB46
		public unsafe CombatBehaviour CombatBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x0014BEA8 File Offset: 0x0014A0A8
		// (set) Token: 0x0600427A RID: 17018 RVA: 0x00020965 File Offset: 0x0001EB65
		public unsafe FleeBehaviour FleeBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FleeBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x0014BED8 File Offset: 0x0014A0D8
		// (set) Token: 0x0600427C RID: 17020 RVA: 0x00020984 File Offset: 0x0001EB84
		public unsafe StationaryBehaviour StationaryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationaryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x0014BF08 File Offset: 0x0014A108
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x000209A3 File Offset: 0x0001EBA3
		public unsafe RequestProductBehaviour RequestProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600427F RID: 17023 RVA: 0x0014BF38 File Offset: 0x0014A138
		// (set) Token: 0x06004280 RID: 17024 RVA: 0x000209C2 File Offset: 0x0001EBC2
		public unsafe List<Behaviour> behaviourStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x0014BF68 File Offset: 0x0014A168
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x000209E1 File Offset: 0x0001EBE1
		public unsafe Behaviour _activeBehaviour_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x0014BF98 File Offset: 0x0014A198
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x00020A00 File Offset: 0x0001EC00
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06004285 RID: 17029 RVA: 0x0014BFC8 File Offset: 0x0014A1C8
		// (set) Token: 0x06004286 RID: 17030 RVA: 0x00020A1F File Offset: 0x0001EC1F
		public unsafe Coroutine summonRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06004287 RID: 17031 RVA: 0x0014BFF8 File Offset: 0x0014A1F8
		// (set) Token: 0x06004288 RID: 17032 RVA: 0x00020A3E File Offset: 0x0001EC3E
		public unsafe List<Behaviour> enabledBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x0014C028 File Offset: 0x0014A228
		// (set) Token: 0x0600428A RID: 17034 RVA: 0x00020A5D File Offset: 0x0001EC5D
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0014C050 File Offset: 0x0014A250
		// (set) Token: 0x0600428C RID: 17036 RVA: 0x00020A78 File Offset: 0x0001EC78
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeFieldInfoPtr_ScheduleManager;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeFieldInfoPtr_CoweringBehaviour;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeFieldInfoPtr_RagdollBehaviour;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceBehaviour;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogueBehaviour;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeFieldInfoPtr_HeavyFlinchBehaviour;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeFieldInfoPtr_FacePlayerBehaviour;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeFieldInfoPtr_DeadBehaviour;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeFieldInfoPtr_UnconsciousBehaviour;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeFieldInfoPtr_SummonBehaviour;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeProductBehaviour;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeFieldInfoPtr_CombatBehaviour;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeFieldInfoPtr_FleeBehaviour;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeFieldInfoPtr_StationaryBehaviour;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeFieldInfoPtr_RequestProductBehaviour;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeFieldInfoPtr_behaviourStack;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeFieldInfoPtr__activeBehaviour_k__BackingField;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeFieldInfoPtr_summonRoutine;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeFieldInfoPtr_enabledBehaviours;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200095D RID: 2397
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C8E3 RID: 51427 RVA: 0x0030A934 File Offset: 0x00308B34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr);
				NPCBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__40_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__42_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__43_0");
				NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671398);
				NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671399);
				NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671400);
				NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671401);
			}

			// Token: 0x0600C8E4 RID: 51428 RVA: 0x0030AA00 File Offset: 0x00308C00
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8E5 RID: 51429 RVA: 0x0030AA3C File Offset: 0x00308C3C
			[CallerCount(0)]
			public unsafe int _SortBehaviourStack_b__40_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C8E6 RID: 51430 RVA: 0x0030AA8C File Offset: 0x00308C8C
			[CallerCount(0)]
			public unsafe int _AddEnabledBehaviour_b__42_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C8E7 RID: 51431 RVA: 0x0030AADC File Offset: 0x00308CDC
			[CallerCount(0)]
			public unsafe int _RemoveEnabledBehaviour_b__43_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C8E8 RID: 51432 RVA: 0x00061B85 File Offset: 0x0005FD85
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EAD RID: 16045
			// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x0030AB2C File Offset: 0x00308D2C
			// (set) Token: 0x0600C8EA RID: 51434 RVA: 0x00061B8E File Offset: 0x0005FD8E
			public unsafe static NPCBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAE RID: 16046
			// (get) Token: 0x0600C8EB RID: 51435 RVA: 0x0030AB54 File Offset: 0x00308D54
			// (set) Token: 0x0600C8EC RID: 51436 RVA: 0x00061BA0 File Offset: 0x0005FDA0
			public unsafe static Func<Behaviour, int> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAF RID: 16047
			// (get) Token: 0x0600C8ED RID: 51437 RVA: 0x0030AB7C File Offset: 0x00308D7C
			// (set) Token: 0x0600C8EE RID: 51438 RVA: 0x00061BB2 File Offset: 0x0005FDB2
			public unsafe static Func<Behaviour, int> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB0 RID: 16048
			// (get) Token: 0x0600C8EF RID: 51439 RVA: 0x0030ABA4 File Offset: 0x00308DA4
			// (set) Token: 0x0600C8F0 RID: 51440 RVA: 0x00061BC4 File Offset: 0x0005FDC4
			public unsafe static Func<Behaviour, int> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087FB RID: 34811
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087FC RID: 34812
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040087FD RID: 34813
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x040087FE RID: 34814
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x040087FF RID: 34815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008800 RID: 34816
			private static readonly IntPtr NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008801 RID: 34817
			private static readonly IntPtr NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008802 RID: 34818
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0;
		}

		// Token: 0x0200095E RID: 2398
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C8F1 RID: 51441 RVA: 0x0030ABCC File Offset: 0x00308DCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "b");
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671402);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671403);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671404);
			}

			// Token: 0x0600C8F2 RID: 51442 RVA: 0x0030AC5C File Offset: 0x00308E5C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8F3 RID: 51443 RVA: 0x0030AC98 File Offset: 0x00308E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152176, XrefRangeEnd = 152204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8F4 RID: 51444 RVA: 0x0030ACCC File Offset: 0x00308ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152204, XrefRangeEnd = 152232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8F5 RID: 51445 RVA: 0x00061BD6 File Offset: 0x0005FDD6
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB1 RID: 16049
			// (get) Token: 0x0600C8F6 RID: 51446 RVA: 0x0030AD00 File Offset: 0x00308F00
			// (set) Token: 0x0600C8F7 RID: 51447 RVA: 0x00061BDF File Offset: 0x0005FDDF
			public unsafe Behaviour b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB2 RID: 16050
			// (get) Token: 0x0600C8F8 RID: 51448 RVA: 0x0030AD30 File Offset: 0x00308F30
			// (set) Token: 0x0600C8F9 RID: 51449 RVA: 0x00061BFE File Offset: 0x0005FDFE
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008803 RID: 34819
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04008804 RID: 34820
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008805 RID: 34821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008806 RID: 34822
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008807 RID: 34823
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}

		// Token: 0x0200095F RID: 2399
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C8FA RID: 51450 RVA: 0x0030AD60 File Offset: 0x00308F60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "duration");
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671405);
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671406);
			}

			// Token: 0x0600C8FB RID: 51451 RVA: 0x0030ADDC File Offset: 0x00308FDC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8FC RID: 51452 RVA: 0x0030AE18 File Offset: 0x00309018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152245, XrefRangeEnd = 152250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C8FD RID: 51453 RVA: 0x00061C1D File Offset: 0x0005FE1D
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB3 RID: 16051
			// (get) Token: 0x0600C8FE RID: 51454 RVA: 0x0030AE58 File Offset: 0x00309058
			// (set) Token: 0x0600C8FF RID: 51455 RVA: 0x00061C26 File Offset: 0x0005FE26
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB4 RID: 16052
			// (get) Token: 0x0600C900 RID: 51456 RVA: 0x0030AE88 File Offset: 0x00309088
			// (set) Token: 0x0600C901 RID: 51457 RVA: 0x00061C45 File Offset: 0x0005FE45
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008808 RID: 34824
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008809 RID: 34825
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400880A RID: 34826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400880B RID: 34827
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3F RID: 3135
			[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0+<<Summon>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E20F RID: 57871 RVA: 0x00351B7C File Offset: 0x0034FD7C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<<Summon>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<t>5__2");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671407);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671408);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671409);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671410);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671411);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671412);
				}

				// Token: 0x0600E210 RID: 57872 RVA: 0x00351C70 File Offset: 0x0034FE70
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E211 RID: 57873 RVA: 0x00351CB8 File Offset: 0x0034FEB8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E212 RID: 57874 RVA: 0x00351CEC File Offset: 0x0034FEEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152232, XrefRangeEnd = 152240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004618 RID: 17944
				// (get) Token: 0x0600E213 RID: 57875 RVA: 0x00351D28 File Offset: 0x0034FF28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E214 RID: 57876 RVA: 0x00351D68 File Offset: 0x0034FF68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152240, XrefRangeEnd = 152245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004619 RID: 17945
				// (get) Token: 0x0600E215 RID: 57877 RVA: 0x00351D9C File Offset: 0x0034FF9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E216 RID: 57878 RVA: 0x0006E347 File Offset: 0x0006C547
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004614 RID: 17940
				// (get) Token: 0x0600E217 RID: 57879 RVA: 0x00351DDC File Offset: 0x0034FFDC
				// (set) Token: 0x0600E218 RID: 57880 RVA: 0x0006E350 File Offset: 0x0006C550
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004615 RID: 17941
				// (get) Token: 0x0600E219 RID: 57881 RVA: 0x00351E04 File Offset: 0x00350004
				// (set) Token: 0x0600E21A RID: 57882 RVA: 0x0006E36B File Offset: 0x0006C56B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004616 RID: 17942
				// (get) Token: 0x0600E21B RID: 57883 RVA: 0x00351E34 File Offset: 0x00350034
				// (set) Token: 0x0600E21C RID: 57884 RVA: 0x0006E38A File Offset: 0x0006C58A
				public unsafe NPCBehaviour.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004617 RID: 17943
				// (get) Token: 0x0600E21D RID: 57885 RVA: 0x00351E64 File Offset: 0x00350064
				// (set) Token: 0x0600E21E RID: 57886 RVA: 0x0006E3A9 File Offset: 0x0006C5A9
				public unsafe float _t_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
					}
				}

				// Token: 0x04009755 RID: 38741
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009756 RID: 38742
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009757 RID: 38743
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009758 RID: 38744
				private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

				// Token: 0x04009759 RID: 38745
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400975A RID: 38746
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400975B RID: 38747
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400975C RID: 38748
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400975D RID: 38749
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400975E RID: 38750
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000960 RID: 2400
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C902 RID: 51458 RVA: 0x0030AEB0 File Offset: 0x003090B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, "BehaviourName");
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671413);
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671414);
			}

			// Token: 0x0600C903 RID: 51459 RVA: 0x0030AF18 File Offset: 0x00309118
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C904 RID: 51460 RVA: 0x0030AF54 File Offset: 0x00309154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152250, XrefRangeEnd = 152268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBehaviour_b__0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C905 RID: 51461 RVA: 0x00061C60 File Offset: 0x0005FE60
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB5 RID: 16053
			// (get) Token: 0x0600C906 RID: 51462 RVA: 0x0030AFA4 File Offset: 0x003091A4
			// (set) Token: 0x0600C907 RID: 51463 RVA: 0x00061C69 File Offset: 0x0005FE69
			public unsafe string BehaviourName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400880C RID: 34828
			private static readonly IntPtr NativeFieldInfoPtr_BehaviourName;

			// Token: 0x0400880D RID: 34829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400880E RID: 34830
			private static readonly IntPtr NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0;
		}
	}
}
