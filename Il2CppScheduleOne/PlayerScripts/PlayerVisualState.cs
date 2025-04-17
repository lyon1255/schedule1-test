using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003EA RID: 1002
	public class PlayerVisualState : NetworkBehaviour
	{
		// Token: 0x0600521F RID: 21023 RVA: 0x00185100 File Offset: 0x00183300
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisualState()
		{
			Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerVisualState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr);
			PlayerVisualState.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "Suspiciousness");
			PlayerVisualState.NativeFieldInfoPtr_visualStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "visualStates");
			PlayerVisualState.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "player");
			PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "removalRoutinesDict");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673584);
			PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673585);
			PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673586);
			PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673587);
			PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673588);
			PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673589);
			PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673590);
			PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673591);
			PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673592);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673593);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673594);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673595);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673596);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673597);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673598);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673599);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673600);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673601);
			PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673602);
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00185324 File Offset: 0x00183524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177433, XrefRangeEnd = 177449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00185360 File Offset: 0x00183560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177449, XrefRangeEnd = 177477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00185394 File Offset: 0x00183594
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 177479, RefRangeEnd = 177485, XrefRangeStart = 177477, XrefRangeEnd = 177479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyState(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x001853F4 File Offset: 0x001835F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177487, RefRangeEnd = 177490, XrefRangeStart = 177485, XrefRangeEnd = 177487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveState(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00185444 File Offset: 0x00183644
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177505, RefRangeEnd = 177509, XrefRangeStart = 177490, XrefRangeEnd = 177505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState.VisualState GetState(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr3) : null;
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00185494 File Offset: 0x00183694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177509, XrefRangeEnd = 177518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x001854C8 File Offset: 0x001836C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177532, RefRangeEnd = 177533, XrefRangeStart = 177518, XrefRangeEnd = 177532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuspiciousness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x001854FC File Offset: 0x001836FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177533, XrefRangeEnd = 177548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00185538 File Offset: 0x00183738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x0018556C File Offset: 0x0018376C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177548, XrefRangeEnd = 177561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x001855A8 File Offset: 0x001837A8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x001855E4 File Offset: 0x001837E4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00185620 File Offset: 0x00183820
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177575, RefRangeEnd = 177580, XrefRangeStart = 177561, XrefRangeEnd = 177575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00185680 File Offset: 0x00183880
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 177607, RefRangeEnd = 177613, XrefRangeStart = 177580, XrefRangeEnd = 177607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRemoveAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x001856E0 File Offset: 0x001838E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177613, XrefRangeEnd = 177620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ApplyState_868472085(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00185744 File Offset: 0x00183944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 177650, RefRangeEnd = 177657, XrefRangeStart = 177620, XrefRangeEnd = 177650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00185794 File Offset: 0x00183994
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 177671, RefRangeEnd = 177679, XrefRangeStart = 177657, XrefRangeEnd = 177671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x001857E4 File Offset: 0x001839E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177679, XrefRangeEnd = 177685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00185848 File Offset: 0x00183A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177685, XrefRangeEnd = 177700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00027151 File Offset: 0x00025351
		public PlayerVisualState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x0018587C File Offset: 0x00183A7C
		// (set) Token: 0x06005235 RID: 21045 RVA: 0x0002715A File Offset: 0x0002535A
		public unsafe float Suspiciousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x001858A4 File Offset: 0x00183AA4
		// (set) Token: 0x06005237 RID: 21047 RVA: 0x00027175 File Offset: 0x00025375
		public unsafe List<PlayerVisualState.VisualState> visualStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerVisualState.VisualState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x001858D4 File Offset: 0x00183AD4
		// (set) Token: 0x06005239 RID: 21049 RVA: 0x00027194 File Offset: 0x00025394
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600523A RID: 21050 RVA: 0x00185904 File Offset: 0x00183B04
		// (set) Token: 0x0600523B RID: 21051 RVA: 0x000271B3 File Offset: 0x000253B3
		public unsafe Dictionary<string, Coroutine> removalRoutinesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x00185934 File Offset: 0x00183B34
		// (set) Token: 0x0600523D RID: 21053 RVA: 0x000271D2 File Offset: 0x000253D2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x0018595C File Offset: 0x00183B5C
		// (set) Token: 0x0600523F RID: 21055 RVA: 0x000271ED File Offset: 0x000253ED
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeFieldInfoPtr_visualStates;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeFieldInfoPtr_removalRoutinesDict;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_VisualState_String_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr_ClearStates_Public_Void_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020009AA RID: 2474
		[OriginalName("Assembly-CSharp.dll", "", "EVisualState")]
		public enum EVisualState
		{
			// Token: 0x04008995 RID: 35221
			Visible,
			// Token: 0x04008996 RID: 35222
			Suspicious,
			// Token: 0x04008997 RID: 35223
			DisobeyingCurfew,
			// Token: 0x04008998 RID: 35224
			Vandalizing,
			// Token: 0x04008999 RID: 35225
			PettyCrime,
			// Token: 0x0400899A RID: 35226
			DrugDealing,
			// Token: 0x0400899B RID: 35227
			SearchedFor,
			// Token: 0x0400899C RID: 35228
			Wanted,
			// Token: 0x0400899D RID: 35229
			Pickpocketing,
			// Token: 0x0400899E RID: 35230
			DischargingWeapon,
			// Token: 0x0400899F RID: 35231
			Brandishing
		}

		// Token: 0x020009AB RID: 2475
		[Serializable]
		public class VisualState : Il2CppSystem.Object
		{
			// Token: 0x0600CB89 RID: 52105 RVA: 0x003122E8 File Offset: 0x003104E8
			// Note: this type is marked as 'beforefieldinit'.
			static VisualState()
			{
				Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "VisualState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr);
				PlayerVisualState.VisualState.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "state");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "label");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "stateDestroyed");
				PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, 100673603);
			}

			// Token: 0x0600CB8A RID: 52106 RVA: 0x00312364 File Offset: 0x00310564
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB8B RID: 52107 RVA: 0x00062FFF File Offset: 0x000611FF
			public VisualState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F69 RID: 16233
			// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x003123A0 File Offset: 0x003105A0
			// (set) Token: 0x0600CB8D RID: 52109 RVA: 0x00063008 File Offset: 0x00061208
			public unsafe PlayerVisualState.EVisualState state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17003F6A RID: 16234
			// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x003123C8 File Offset: 0x003105C8
			// (set) Token: 0x0600CB8F RID: 52111 RVA: 0x00063023 File Offset: 0x00061223
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F6B RID: 16235
			// (get) Token: 0x0600CB90 RID: 52112 RVA: 0x003123F0 File Offset: 0x003105F0
			// (set) Token: 0x0600CB91 RID: 52113 RVA: 0x00063042 File Offset: 0x00061242
			public unsafe Action stateDestroyed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089A0 RID: 35232
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040089A1 RID: 35233
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089A2 RID: 35234
			private static readonly IntPtr NativeFieldInfoPtr_stateDestroyed;

			// Token: 0x040089A3 RID: 35235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009AC RID: 2476
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB92 RID: 52114 RVA: 0x00312420 File Offset: 0x00310620
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673604);
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673605);
			}

			// Token: 0x0600CB93 RID: 52115 RVA: 0x00312488 File Offset: 0x00310688
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB94 RID: 52116 RVA: 0x003124C4 File Offset: 0x003106C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetState_b__0(PlayerVisualState.VisualState x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB95 RID: 52117 RVA: 0x00063061 File Offset: 0x00061261
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6C RID: 16236
			// (get) Token: 0x0600CB96 RID: 52118 RVA: 0x00312514 File Offset: 0x00310714
			// (set) Token: 0x0600CB97 RID: 52119 RVA: 0x0006306A File Offset: 0x0006126A
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040089A4 RID: 35236
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089A5 RID: 35237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089A6 RID: 35238
			private static readonly IntPtr NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0;
		}

		// Token: 0x020009AD RID: 2477
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB98 RID: 52120 RVA: 0x0031253C File Offset: 0x0031073C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "delay");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "newState");
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673606);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673607);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673608);
			}

			// Token: 0x0600CB99 RID: 52121 RVA: 0x003125F4 File Offset: 0x003107F4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB9A RID: 52122 RVA: 0x00312630 File Offset: 0x00310830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177409, XrefRangeEnd = 177414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CB9B RID: 52123 RVA: 0x00312670 File Offset: 0x00310870
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 177432, RefRangeEnd = 177433, XrefRangeStart = 177414, XrefRangeEnd = 177432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB9C RID: 52124 RVA: 0x00063089 File Offset: 0x00061289
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6D RID: 16237
			// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x003126A4 File Offset: 0x003108A4
			// (set) Token: 0x0600CB9E RID: 52126 RVA: 0x00063092 File Offset: 0x00061292
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003F6E RID: 16238
			// (get) Token: 0x0600CB9F RID: 52127 RVA: 0x003126CC File Offset: 0x003108CC
			// (set) Token: 0x0600CBA0 RID: 52128 RVA: 0x000630AD File Offset: 0x000612AD
			public unsafe PlayerVisualState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F6F RID: 16239
			// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x003126FC File Offset: 0x003108FC
			// (set) Token: 0x0600CBA2 RID: 52130 RVA: 0x000630CC File Offset: 0x000612CC
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F70 RID: 16240
			// (get) Token: 0x0600CBA3 RID: 52131 RVA: 0x00312724 File Offset: 0x00310924
			// (set) Token: 0x0600CBA4 RID: 52132 RVA: 0x000630EB File Offset: 0x000612EB
			public unsafe PlayerVisualState.VisualState newState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089A7 RID: 35239
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040089A8 RID: 35240
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089A9 RID: 35241
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040089AA RID: 35242
			private static readonly IntPtr NativeFieldInfoPtr_newState;

			// Token: 0x040089AB RID: 35243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089AC RID: 35244
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040089AD RID: 35245
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000C47 RID: 3143
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0+<<RemoveState>g__DelayedRemove|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E299 RID: 58009 RVA: 0x00353538 File Offset: 0x00351738
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<<RemoveState>g__DelayedRemove|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673609);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673610);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673611);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673612);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673613);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673614);
				}

				// Token: 0x0600E29A RID: 58010 RVA: 0x00353618 File Offset: 0x00351818
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E29B RID: 58011 RVA: 0x00353660 File Offset: 0x00351860
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E29C RID: 58012 RVA: 0x00353694 File Offset: 0x00351894
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177398, XrefRangeEnd = 177404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700464C RID: 17996
				// (get) Token: 0x0600E29D RID: 58013 RVA: 0x003536D0 File Offset: 0x003518D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E29E RID: 58014 RVA: 0x00353710 File Offset: 0x00351910
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177404, XrefRangeEnd = 177409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700464D RID: 17997
				// (get) Token: 0x0600E29F RID: 58015 RVA: 0x00353744 File Offset: 0x00351944
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2A0 RID: 58016 RVA: 0x0006E7BE File Offset: 0x0006C9BE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004649 RID: 17993
				// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x00353784 File Offset: 0x00351984
				// (set) Token: 0x0600E2A2 RID: 58018 RVA: 0x0006E7C7 File Offset: 0x0006C9C7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700464A RID: 17994
				// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x003537AC File Offset: 0x003519AC
				// (set) Token: 0x0600E2A4 RID: 58020 RVA: 0x0006E7E2 File Offset: 0x0006C9E2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700464B RID: 17995
				// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x003537DC File Offset: 0x003519DC
				// (set) Token: 0x0600E2A6 RID: 58022 RVA: 0x0006E801 File Offset: 0x0006CA01
				public unsafe PlayerVisualState.__c__DisplayClass9_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097AA RID: 38826
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097AB RID: 38827
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097AC RID: 38828
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097AD RID: 38829
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097AE RID: 38830
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097AF RID: 38831
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097B0 RID: 38832
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097B1 RID: 38833
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097B2 RID: 38834
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
