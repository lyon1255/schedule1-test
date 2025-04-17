using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x020003F3 RID: 1011
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		// Token: 0x060053EC RID: 21484 RVA: 0x0018A6C4 File Offset: 0x001888C4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkedInteractableToggleable()
		{
			Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "NetworkedInteractableToggleable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr);
			NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "<IsActivated>k__BackingField");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "ActivateMessage");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "DeactivateMessage");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "CoolDown");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "IntObj");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onToggle");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onActivate");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onDeactivate");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "lastActivated");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted");
			NetworkedInteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673768);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673769);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673770);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673771);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673772);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673773);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_SendToggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673774);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673775);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673776);
			NetworkedInteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673777);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673778);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673779);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673780);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673781);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673782);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673783);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673784);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673785);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673786);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673787);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673788);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100673789);
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x0018A988 File Offset: 0x00188B88
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x0018A9C4 File Offset: 0x00188BC4
		public unsafe bool IsActivated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0018AA04 File Offset: 0x00188C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179483, XrefRangeEnd = 179497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x0018AA38 File Offset: 0x00188C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179497, XrefRangeEnd = 179499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x0018AA88 File Offset: 0x00188C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179499, XrefRangeEnd = 179502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0018AABC File Offset: 0x00188CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179502, XrefRangeEnd = 179503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x0018AAF0 File Offset: 0x00188CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179524, RefRangeEnd = 179526, XrefRangeStart = 179503, XrefRangeEnd = 179524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_SendToggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0018AB24 File Offset: 0x00188D24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 179568, RefRangeEnd = 179572, XrefRangeStart = 179526, XrefRangeEnd = 179568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0018AB74 File Offset: 0x00188D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179572, XrefRangeEnd = 179574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0018ABA8 File Offset: 0x00188DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179574, XrefRangeEnd = 179596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkedInteractableToggleable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x0018ABE4 File Offset: 0x00188DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179596, XrefRangeEnd = 179616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x0018AC20 File Offset: 0x00188E20
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 144708, RefRangeEnd = 144745, XrefRangeStart = 144708, XrefRangeEnd = 144745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x0018AC5C File Offset: 0x00188E5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FA RID: 21498 RVA: 0x0018AC98 File Offset: 0x00188E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179616, XrefRangeEnd = 179634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendToggle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FB RID: 21499 RVA: 0x0018ACCC File Offset: 0x00188ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179634, XrefRangeEnd = 179635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendToggle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FC RID: 21500 RVA: 0x0018AD00 File Offset: 0x00188F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179635, XrefRangeEnd = 179638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x0018AD64 File Offset: 0x00188F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179638, XrefRangeEnd = 179657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FE RID: 21502 RVA: 0x0018ADB4 File Offset: 0x00188FB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179660, RefRangeEnd = 179663, XrefRangeStart = 179657, XrefRangeEnd = 179660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x0018AE04 File Offset: 0x00189004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179663, XrefRangeEnd = 179666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x0018AE54 File Offset: 0x00189054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179666, XrefRangeEnd = 179685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x0018AEA4 File Offset: 0x001890A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179685, XrefRangeEnd = 179688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x0018AEF4 File Offset: 0x001890F4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005403 RID: 21507 RVA: 0x0002821F File Offset: 0x0002641F
		public NetworkedInteractableToggleable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x0018AF30 File Offset: 0x00189130
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x00028228 File Offset: 0x00026428
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x0018AF58 File Offset: 0x00189158
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x00028243 File Offset: 0x00026443
		public unsafe string ActivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x0018AF80 File Offset: 0x00189180
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x00028262 File Offset: 0x00026462
		public unsafe string DeactivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x0018AFA8 File Offset: 0x001891A8
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x00028281 File Offset: 0x00026481
		public unsafe float CoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown)) = value;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x0018AFD0 File Offset: 0x001891D0
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x0002829C File Offset: 0x0002649C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0018B000 File Offset: 0x00189200
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x000282BB File Offset: 0x000264BB
		public unsafe UnityEvent onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x0018B030 File Offset: 0x00189230
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x000282DA File Offset: 0x000264DA
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x0018B060 File Offset: 0x00189260
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x000282F9 File Offset: 0x000264F9
		public unsafe UnityEvent onDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x0018B090 File Offset: 0x00189290
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x00028318 File Offset: 0x00026518
		public unsafe float lastActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated)) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x0018B0B8 File Offset: 0x001892B8
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x00028333 File Offset: 0x00026533
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x0018B0E0 File Offset: 0x001892E0
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x0002834E File Offset: 0x0002654E
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeFieldInfoPtr_ActivateMessage;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeFieldInfoPtr_DeactivateMessage;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivate;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeFieldInfoPtr_lastActivated;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040038EA RID: 14570
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0;

		// Token: 0x040038EB RID: 14571
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x040038EC RID: 14572
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040038ED RID: 14573
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040038EE RID: 14574
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040038EF RID: 14575
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040038F0 RID: 14576
		private static readonly IntPtr NativeMethodInfoPtr_SendToggle_Public_Void_0;

		// Token: 0x040038F1 RID: 14577
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x040038F2 RID: 14578
		private static readonly IntPtr NativeMethodInfoPtr_PoliceDetected_Public_Void_0;

		// Token: 0x040038F3 RID: 14579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038F4 RID: 14580
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0;

		// Token: 0x040038F9 RID: 14585
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040038FA RID: 14586
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040038FB RID: 14587
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040038FF RID: 14591
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
