using System;
using Il2CppFishNet.Managing;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078E RID: 1934
	public class FishySteamworks : Transport
	{
		// Token: 0x0600B71F RID: 46879 RVA: 0x002D74B4 File Offset: 0x002D56B4
		// Note: this type is marked as 'beforefieldinit'.
		static FishySteamworks()
		{
			Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "FishySteamworks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr);
			FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "LocalUserSteamID");
			FishySteamworks.NativeFieldInfoPtr__serverBindAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_serverBindAddress");
			FishySteamworks.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_port");
			FishySteamworks.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_maximumClients");
			FishySteamworks.NativeFieldInfoPtr__peerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_peerToPeer");
			FishySteamworks.NativeFieldInfoPtr__clientAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientAddress");
			FishySteamworks.NativeFieldInfoPtr__mtus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_mtus");
			FishySteamworks.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_client");
			FishySteamworks.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientHost");
			FishySteamworks.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_server");
			FishySteamworks.NativeFieldInfoPtr__shutdownCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_shutdownCalled");
			FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "CLIENT_HOST_ID");
			FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnRemoteConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientReceivedData");
			FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerReceivedData");
			FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685790);
			FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685791);
			FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685792);
			FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685793);
			FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685794);
			FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685795);
			FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685796);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685797);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685798);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685799);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685800);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685801);
			FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685802);
			FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685803);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685804);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685805);
			FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685806);
			FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685807);
			FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685808);
			FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685809);
			FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685810);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685811);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685812);
			FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685813);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685814);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685815);
			FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685816);
			FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685817);
			FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685818);
			FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685819);
			FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685820);
			FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685821);
			FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685822);
			FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685823);
			FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685824);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685825);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685826);
			FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685827);
			FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685828);
			FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685829);
			FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685830);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685831);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685832);
			FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685833);
			FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685834);
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x002D79BC File Offset: 0x002D5BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311731, XrefRangeEnd = 311734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x002D79F8 File Offset: 0x002D5BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311734, XrefRangeEnd = 311814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(NetworkManager networkManager, int transportIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transportIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x002D7A54 File Offset: 0x002D5C54
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x002D7A88 File Offset: 0x002D5C88
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x002D7ABC File Offset: 0x002D5CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311814, XrefRangeEnd = 311820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChannelData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x002D7AF0 File Offset: 0x002D5CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311824, RefRangeEnd = 311825, XrefRangeStart = 311820, XrefRangeEnd = 311824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InitializeRelayNetworkAccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x002D7B2C File Offset: 0x002D5D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311827, RefRangeEnd = 311829, XrefRangeStart = 311825, XrefRangeEnd = 311827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNetworkAccessAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x002D7B68 File Offset: 0x002D5D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311829, XrefRangeEnd = 311842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x002D7BB8 File Offset: 0x002D5DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311842, XrefRangeEnd = 311847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x002D7C08 File Offset: 0x002D5E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311847, XrefRangeEnd = 311852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x002D7C58 File Offset: 0x002D5E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311852, XrefRangeEnd = 311857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x002D7CA8 File Offset: 0x002D5EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311857, XrefRangeEnd = 311862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x002D7CF8 File Offset: 0x002D5EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311862, XrefRangeEnd = 311867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x002D7D48 File Offset: 0x002D5F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311867, XrefRangeEnd = 311872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002D7D98 File Offset: 0x002D5F98
		[CallerCount(0)]
		public unsafe override LocalConnectionState GetConnectionState(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x002D7DEC File Offset: 0x002D5FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311872, XrefRangeEnd = 311876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x002D7E40 File Offset: 0x002D6040
		[CallerCount(0)]
		public unsafe override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x002D7E8C File Offset: 0x002D608C
		[CallerCount(0)]
		public unsafe override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x002D7ED8 File Offset: 0x002D60D8
		[CallerCount(0)]
		public unsafe override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x002D7F24 File Offset: 0x002D6124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311876, XrefRangeEnd = 311894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateIncoming(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x002D7F70 File Offset: 0x002D6170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311894, XrefRangeEnd = 311895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateOutgoing(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x002D7FBC File Offset: 0x002D61BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311895, XrefRangeEnd = 311900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x002D800C File Offset: 0x002D620C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311900, XrefRangeEnd = 311905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002D805C File Offset: 0x002D625C
		[CallerCount(0)]
		public unsafe override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002D80B0 File Offset: 0x002D62B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311905, XrefRangeEnd = 311910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x002D8100 File Offset: 0x002D6300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311910, XrefRangeEnd = 311915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x002D8150 File Offset: 0x002D6350
		[CallerCount(0)]
		public unsafe override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x002D81A4 File Offset: 0x002D63A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311915, XrefRangeEnd = 311943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x002D8204 File Offset: 0x002D6404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311943, XrefRangeEnd = 311944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x002D8274 File Offset: 0x002D6474
		[CallerCount(0)]
		public unsafe override int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x002D82BC File Offset: 0x002D64BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311944, XrefRangeEnd = 311948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x002D8308 File Offset: 0x002D6508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetClientAddress(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x002D8358 File Offset: 0x002D6558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetServerBindAddress(string address, IPAddressType addressType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addressType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x002D83B4 File Offset: 0x002D65B4
		[CallerCount(0)]
		public unsafe override void SetPort(ushort port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x002D8400 File Offset: 0x002D6600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311948, XrefRangeEnd = 311950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StartConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x002D8454 File Offset: 0x002D6654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311950, XrefRangeEnd = 311952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x002D84A8 File Offset: 0x002D66A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311952, XrefRangeEnd = 311963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x002D850C File Offset: 0x002D670C
		[CallerCount(0)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x002D8548 File Offset: 0x002D6748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311976, RefRangeEnd = 311977, XrefRangeStart = 311963, XrefRangeEnd = 311976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x002D8584 File Offset: 0x002D6784
		[CallerCount(0)]
		public unsafe bool StopServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x002D85C0 File Offset: 0x002D67C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311982, RefRangeEnd = 311983, XrefRangeStart = 311977, XrefRangeEnd = 311982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartClient(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x002D8610 File Offset: 0x002D6810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311983, XrefRangeEnd = 311985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x002D864C File Offset: 0x002D684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311985, XrefRangeEnd = 311996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x002D86A4 File Offset: 0x002D68A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311996, XrefRangeEnd = 311999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMTU(byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x002D86F8 File Offset: 0x002D68F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311999, XrefRangeEnd = 312005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishySteamworks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x00059F50 File Offset: 0x00058150
		public FishySteamworks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x002D8734 File Offset: 0x002D6934
		// (set) Token: 0x0600B74F RID: 46927 RVA: 0x00059F59 File Offset: 0x00058159
		public unsafe ulong LocalUserSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID)) = value;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x002D875C File Offset: 0x002D695C
		// (set) Token: 0x0600B751 RID: 46929 RVA: 0x00059F74 File Offset: 0x00058174
		public unsafe string _serverBindAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600B752 RID: 46930 RVA: 0x002D8784 File Offset: 0x002D6984
		// (set) Token: 0x0600B753 RID: 46931 RVA: 0x00059F93 File Offset: 0x00058193
		public unsafe ushort _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x002D87AC File Offset: 0x002D69AC
		// (set) Token: 0x0600B755 RID: 46933 RVA: 0x00059FAE File Offset: 0x000581AE
		public unsafe ushort _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x002D87D4 File Offset: 0x002D69D4
		// (set) Token: 0x0600B757 RID: 46935 RVA: 0x00059FC9 File Offset: 0x000581C9
		public unsafe bool _peerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer)) = value;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600B758 RID: 46936 RVA: 0x002D87FC File Offset: 0x002D69FC
		// (set) Token: 0x0600B759 RID: 46937 RVA: 0x00059FE4 File Offset: 0x000581E4
		public unsafe string _clientAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600B75A RID: 46938 RVA: 0x002D8824 File Offset: 0x002D6A24
		// (set) Token: 0x0600B75B RID: 46939 RVA: 0x0005A003 File Offset: 0x00058203
		public unsafe Il2CppStructArray<int> _mtus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600B75C RID: 46940 RVA: 0x002D8854 File Offset: 0x002D6A54
		// (set) Token: 0x0600B75D RID: 46941 RVA: 0x0005A022 File Offset: 0x00058222
		public unsafe ClientSocket _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600B75E RID: 46942 RVA: 0x002D8884 File Offset: 0x002D6A84
		// (set) Token: 0x0600B75F RID: 46943 RVA: 0x0005A041 File Offset: 0x00058241
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x002D88B4 File Offset: 0x002D6AB4
		// (set) Token: 0x0600B761 RID: 46945 RVA: 0x0005A060 File Offset: 0x00058260
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600B762 RID: 46946 RVA: 0x002D88E4 File Offset: 0x002D6AE4
		// (set) Token: 0x0600B763 RID: 46947 RVA: 0x0005A07F File Offset: 0x0005827F
		public unsafe bool _shutdownCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled)) = value;
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x002D890C File Offset: 0x002D6B0C
		// (set) Token: 0x0600B765 RID: 46949 RVA: 0x0005A09A File Offset: 0x0005829A
		public unsafe static int CLIENT_HOST_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&value));
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x002D8928 File Offset: 0x002D6B28
		// (set) Token: 0x0600B767 RID: 46951 RVA: 0x0005A0A8 File Offset: 0x000582A8
		public unsafe Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x002D8958 File Offset: 0x002D6B58
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x0005A0C7 File Offset: 0x000582C7
		public unsafe Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600B76A RID: 46954 RVA: 0x002D8988 File Offset: 0x002D6B88
		// (set) Token: 0x0600B76B RID: 46955 RVA: 0x0005A0E6 File Offset: 0x000582E6
		public unsafe Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemoteConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x002D89B8 File Offset: 0x002D6BB8
		// (set) Token: 0x0600B76D RID: 46957 RVA: 0x0005A105 File Offset: 0x00058305
		public unsafe Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600B76E RID: 46958 RVA: 0x002D89E8 File Offset: 0x002D6BE8
		// (set) Token: 0x0600B76F RID: 46959 RVA: 0x0005A124 File Offset: 0x00058324
		public unsafe Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B52 RID: 31570
		private static readonly IntPtr NativeFieldInfoPtr_LocalUserSteamID;

		// Token: 0x04007B53 RID: 31571
		private static readonly IntPtr NativeFieldInfoPtr__serverBindAddress;

		// Token: 0x04007B54 RID: 31572
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x04007B55 RID: 31573
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x04007B56 RID: 31574
		private static readonly IntPtr NativeFieldInfoPtr__peerToPeer;

		// Token: 0x04007B57 RID: 31575
		private static readonly IntPtr NativeFieldInfoPtr__clientAddress;

		// Token: 0x04007B58 RID: 31576
		private static readonly IntPtr NativeFieldInfoPtr__mtus;

		// Token: 0x04007B59 RID: 31577
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x04007B5A RID: 31578
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x04007B5B RID: 31579
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04007B5C RID: 31580
		private static readonly IntPtr NativeFieldInfoPtr__shutdownCalled;

		// Token: 0x04007B5D RID: 31581
		private static readonly IntPtr NativeFieldInfoPtr_CLIENT_HOST_ID;

		// Token: 0x04007B5E RID: 31582
		private static readonly IntPtr NativeFieldInfoPtr_OnClientConnectionState;

		// Token: 0x04007B5F RID: 31583
		private static readonly IntPtr NativeFieldInfoPtr_OnServerConnectionState;

		// Token: 0x04007B60 RID: 31584
		private static readonly IntPtr NativeFieldInfoPtr_OnRemoteConnectionState;

		// Token: 0x04007B61 RID: 31585
		private static readonly IntPtr NativeFieldInfoPtr_OnClientReceivedData;

		// Token: 0x04007B62 RID: 31586
		private static readonly IntPtr NativeFieldInfoPtr_OnServerReceivedData;

		// Token: 0x04007B63 RID: 31587
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04007B64 RID: 31588
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0;

		// Token: 0x04007B65 RID: 31589
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007B66 RID: 31590
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007B67 RID: 31591
		private static readonly IntPtr NativeMethodInfoPtr_CreateChannelData_Private_Void_0;

		// Token: 0x04007B68 RID: 31592
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0;

		// Token: 0x04007B69 RID: 31593
		private static readonly IntPtr NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0;

		// Token: 0x04007B6A RID: 31594
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0;

		// Token: 0x04007B6B RID: 31595
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x04007B6C RID: 31596
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x04007B6D RID: 31597
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x04007B6E RID: 31598
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x04007B6F RID: 31599
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x04007B70 RID: 31600
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x04007B71 RID: 31601
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0;

		// Token: 0x04007B72 RID: 31602
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0;

		// Token: 0x04007B73 RID: 31603
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0;

		// Token: 0x04007B74 RID: 31604
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0;

		// Token: 0x04007B75 RID: 31605
		private static readonly IntPtr NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0;

		// Token: 0x04007B76 RID: 31606
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007B77 RID: 31607
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007B78 RID: 31608
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x04007B79 RID: 31609
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x04007B7A RID: 31610
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0;

		// Token: 0x04007B7B RID: 31611
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x04007B7C RID: 31612
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x04007B7D RID: 31613
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0;

		// Token: 0x04007B7E RID: 31614
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007B7F RID: 31615
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x04007B80 RID: 31616
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0;

		// Token: 0x04007B81 RID: 31617
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0;

		// Token: 0x04007B82 RID: 31618
		private static readonly IntPtr NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0;

		// Token: 0x04007B83 RID: 31619
		private static readonly IntPtr NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0;

		// Token: 0x04007B84 RID: 31620
		private static readonly IntPtr NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0;

		// Token: 0x04007B85 RID: 31621
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x04007B86 RID: 31622
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x04007B87 RID: 31623
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0;

		// Token: 0x04007B88 RID: 31624
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x04007B89 RID: 31625
		private static readonly IntPtr NativeMethodInfoPtr_StartServer_Private_Boolean_0;

		// Token: 0x04007B8A RID: 31626
		private static readonly IntPtr NativeMethodInfoPtr_StopServer_Private_Boolean_0;

		// Token: 0x04007B8B RID: 31627
		private static readonly IntPtr NativeMethodInfoPtr_StartClient_Private_Boolean_String_0;

		// Token: 0x04007B8C RID: 31628
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_0;

		// Token: 0x04007B8D RID: 31629
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0;

		// Token: 0x04007B8E RID: 31630
		private static readonly IntPtr NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0;

		// Token: 0x04007B8F RID: 31631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
