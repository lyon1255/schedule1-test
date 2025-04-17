using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Server
{
	// Token: 0x0200078F RID: 1935
	public class ServerSocket : CommonSocket
	{
		// Token: 0x0600B770 RID: 46960 RVA: 0x002D8A18 File Offset: 0x002D6C18
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSocket()
		{
			Il2CppClassPointerStore<ServerSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Server", "ServerSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr);
			ServerSocket.NativeFieldInfoPtr__steamConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamConnections");
			ServerSocket.NativeFieldInfoPtr__steamIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamIds");
			ServerSocket.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_maximumClients");
			ServerSocket.NativeFieldInfoPtr__nextConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_nextConnectionId");
			ServerSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_socket");
			ServerSocket.NativeFieldInfoPtr__clientHostIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostIncoming");
			ServerSocket.NativeFieldInfoPtr__clientHostStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostStarted");
			ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_onRemoteConnectionStateCallback");
			ServerSocket.NativeFieldInfoPtr__cachedConnectionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_cachedConnectionIds");
			ServerSocket.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHost");
			ServerSocket.NativeFieldInfoPtr__iteratingConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_iteratingConnections");
			ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_pendingConnectionChanges");
			ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685835);
			ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685836);
			ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685837);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685838);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685839);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685840);
			ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685841);
			ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685842);
			ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685843);
			ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685844);
			ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685845);
			ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685846);
			ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685847);
			ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685848);
			ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685849);
			ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685850);
			ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685851);
			ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685852);
			ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685853);
			ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685854);
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x002D8CC8 File Offset: 0x002D6EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312013, XrefRangeEnd = 312017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B772 RID: 46962 RVA: 0x002D8D14 File Offset: 0x002D6F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312017, XrefRangeEnd = 312023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInvalidSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B773 RID: 46963 RVA: 0x002D8D48 File Offset: 0x002D6F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312057, RefRangeEnd = 312058, XrefRangeStart = 312023, XrefRangeEnd = 312057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, int maximumClients, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumClients;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x002D8DC0 File Offset: 0x002D6FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312058, XrefRangeEnd = 312074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x002D8DFC File Offset: 0x002D6FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312074, XrefRangeEnd = 312085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x002D8E48 File Offset: 0x002D7048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312085, XrefRangeEnd = 312095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId, HSteamNetConnection socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x002D8EA0 File Offset: 0x002D70A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312095, XrefRangeEnd = 312116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoteConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x002D8EE8 File Offset: 0x002D70E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312133, RefRangeEnd = 312134, XrefRangeStart = 312116, XrefRangeEnd = 312133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConnection(int connectionId, HSteamNetConnection steamConnection, CSteamID steamId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x002D8F44 File Offset: 0x002D7144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312151, RefRangeEnd = 312152, XrefRangeStart = 312134, XrefRangeEnd = 312151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x002D8F84 File Offset: 0x002D7184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312152, XrefRangeEnd = 312174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x002D8FB8 File Offset: 0x002D71B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312207, RefRangeEnd = 312208, XrefRangeStart = 312174, XrefRangeEnd = 312207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x002D8FEC File Offset: 0x002D71EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312230, RefRangeEnd = 312232, XrefRangeStart = 312208, XrefRangeEnd = 312230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPendingConnectionChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x002D9020 File Offset: 0x002D7220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312251, RefRangeEnd = 312252, XrefRangeStart = 312232, XrefRangeEnd = 312251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x002D9084 File Offset: 0x002D7284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312252, XrefRangeEnd = 312265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B77F RID: 46975 RVA: 0x002D90C8 File Offset: 0x002D72C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312265, XrefRangeEnd = 312269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x002D9108 File Offset: 0x002D7308
		[CallerCount(0)]
		public unsafe int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x002D9144 File Offset: 0x002D7344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClientHostSocket(ClientHostSocket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x002D9188 File Offset: 0x002D7388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312292, RefRangeEnd = 312294, XrefRangeStart = 312269, XrefRangeEnd = 312292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClientHostState(bool started)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref started;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x002D91C8 File Offset: 0x002D73C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312294, XrefRangeEnd = 312297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromClientHost(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x002D9210 File Offset: 0x002D7410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312297, XrefRangeEnd = 312337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x0005A143 File Offset: 0x00058343
		public ServerSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600B786 RID: 46982 RVA: 0x002D924C File Offset: 0x002D744C
		// (set) Token: 0x0600B787 RID: 46983 RVA: 0x0005A14C File Offset: 0x0005834C
		public unsafe BidirectionalDictionary<HSteamNetConnection, int> _steamConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<HSteamNetConnection, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600B788 RID: 46984 RVA: 0x002D927C File Offset: 0x002D747C
		// (set) Token: 0x0600B789 RID: 46985 RVA: 0x0005A16B File Offset: 0x0005836B
		public unsafe BidirectionalDictionary<CSteamID, int> _steamIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<CSteamID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600B78A RID: 46986 RVA: 0x002D92AC File Offset: 0x002D74AC
		// (set) Token: 0x0600B78B RID: 46987 RVA: 0x0005A18A File Offset: 0x0005838A
		public unsafe int _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600B78C RID: 46988 RVA: 0x002D92D4 File Offset: 0x002D74D4
		// (set) Token: 0x0600B78D RID: 46989 RVA: 0x0005A1A5 File Offset: 0x000583A5
		public unsafe int _nextConnectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId)) = value;
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600B78E RID: 46990 RVA: 0x002D92FC File Offset: 0x002D74FC
		// (set) Token: 0x0600B78F RID: 46991 RVA: 0x0005A1C0 File Offset: 0x000583C0
		public unsafe HSteamListenSocket _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x002D9324 File Offset: 0x002D7524
		// (set) Token: 0x0600B791 RID: 46993 RVA: 0x0005A1DB File Offset: 0x000583DB
		public unsafe Queue<LocalPacket> _clientHostIncoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600B792 RID: 46994 RVA: 0x002D9354 File Offset: 0x002D7554
		// (set) Token: 0x0600B793 RID: 46995 RVA: 0x0005A1FA File Offset: 0x000583FA
		public unsafe bool _clientHostStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted)) = value;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600B794 RID: 46996 RVA: 0x002D937C File Offset: 0x002D757C
		// (set) Token: 0x0600B795 RID: 46997 RVA: 0x0005A215 File Offset: 0x00058415
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600B796 RID: 46998 RVA: 0x002D93AC File Offset: 0x002D75AC
		// (set) Token: 0x0600B797 RID: 46999 RVA: 0x0005A234 File Offset: 0x00058434
		public unsafe Queue<int> _cachedConnectionIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600B798 RID: 47000 RVA: 0x002D93DC File Offset: 0x002D75DC
		// (set) Token: 0x0600B799 RID: 47001 RVA: 0x0005A253 File Offset: 0x00058453
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x002D940C File Offset: 0x002D760C
		// (set) Token: 0x0600B79B RID: 47003 RVA: 0x0005A272 File Offset: 0x00058472
		public unsafe bool _iteratingConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections)) = value;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600B79C RID: 47004 RVA: 0x002D9434 File Offset: 0x002D7634
		// (set) Token: 0x0600B79D RID: 47005 RVA: 0x0005A28D File Offset: 0x0005848D
		public unsafe List<ServerSocket.ConnectionChange> _pendingConnectionChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServerSocket.ConnectionChange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B90 RID: 31632
		private static readonly IntPtr NativeFieldInfoPtr__steamConnections;

		// Token: 0x04007B91 RID: 31633
		private static readonly IntPtr NativeFieldInfoPtr__steamIds;

		// Token: 0x04007B92 RID: 31634
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x04007B93 RID: 31635
		private static readonly IntPtr NativeFieldInfoPtr__nextConnectionId;

		// Token: 0x04007B94 RID: 31636
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x04007B95 RID: 31637
		private static readonly IntPtr NativeFieldInfoPtr__clientHostIncoming;

		// Token: 0x04007B96 RID: 31638
		private static readonly IntPtr NativeFieldInfoPtr__clientHostStarted;

		// Token: 0x04007B97 RID: 31639
		private static readonly IntPtr NativeFieldInfoPtr__onRemoteConnectionStateCallback;

		// Token: 0x04007B98 RID: 31640
		private static readonly IntPtr NativeFieldInfoPtr__cachedConnectionIds;

		// Token: 0x04007B99 RID: 31641
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x04007B9A RID: 31642
		private static readonly IntPtr NativeFieldInfoPtr__iteratingConnections;

		// Token: 0x04007B9B RID: 31643
		private static readonly IntPtr NativeFieldInfoPtr__pendingConnectionChanges;

		// Token: 0x04007B9C RID: 31644
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0;

		// Token: 0x04007B9D RID: 31645
		private static readonly IntPtr NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0;

		// Token: 0x04007B9E RID: 31646
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0;

		// Token: 0x04007B9F RID: 31647
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BA0 RID: 31648
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0;

		// Token: 0x04007BA1 RID: 31649
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0;

		// Token: 0x04007BA2 RID: 31650
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04007BA3 RID: 31651
		private static readonly IntPtr NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0;

		// Token: 0x04007BA4 RID: 31652
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0;

		// Token: 0x04007BA5 RID: 31653
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04007BA6 RID: 31654
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BA7 RID: 31655
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0;

		// Token: 0x04007BA8 RID: 31656
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x04007BA9 RID: 31657
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0;

		// Token: 0x04007BAA RID: 31658
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0;

		// Token: 0x04007BAB RID: 31659
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0;

		// Token: 0x04007BAC RID: 31660
		private static readonly IntPtr NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0;

		// Token: 0x04007BAD RID: 31661
		private static readonly IntPtr NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0;

		// Token: 0x04007BAE RID: 31662
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0;

		// Token: 0x04007BAF RID: 31663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0A RID: 3082
		[StructLayout(2)]
		public struct ConnectionChange
		{
			// Token: 0x0600E039 RID: 57401 RVA: 0x0034CB28 File Offset: 0x0034AD28
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChange()
			{
				Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "ConnectionChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr);
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_ConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "ConnectionId");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamConnection");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamId");
				ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685855);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685856);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685857);
			}

			// Token: 0x1700457B RID: 17787
			// (get) Token: 0x0600E03A RID: 57402 RVA: 0x0034CBCC File Offset: 0x0034ADCC
			public unsafe bool IsConnect
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312005, XrefRangeEnd = 312009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E03B RID: 57403 RVA: 0x0034CBFC File Offset: 0x0034ADFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312009, XrefRangeEnd = 312013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChange(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E03C RID: 57404 RVA: 0x0034CC30 File Offset: 0x0034AE30
			[CallerCount(0)]
			public unsafe ConnectionChange(int id, HSteamNetConnection steamConnection, CSteamID steamId)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E03D RID: 57405 RVA: 0x0006D4F2 File Offset: 0x0006B6F2
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, ref this));
			}

			// Token: 0x04009630 RID: 38448
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionId;

			// Token: 0x04009631 RID: 38449
			private static readonly IntPtr NativeFieldInfoPtr_SteamConnection;

			// Token: 0x04009632 RID: 38450
			private static readonly IntPtr NativeFieldInfoPtr_SteamId;

			// Token: 0x04009633 RID: 38451
			private static readonly IntPtr NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0;

			// Token: 0x04009634 RID: 38452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009635 RID: 38453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0;

			// Token: 0x04009636 RID: 38454
			[FieldOffset(0)]
			public int ConnectionId;

			// Token: 0x04009637 RID: 38455
			[FieldOffset(4)]
			public HSteamNetConnection SteamConnection;

			// Token: 0x04009638 RID: 38456
			[FieldOffset(8)]
			public CSteamID SteamId;
		}
	}
}
