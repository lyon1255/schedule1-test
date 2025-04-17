using System;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000790 RID: 1936
	public class ClientHostSocket : CommonSocket
	{
		// Token: 0x0600B79E RID: 47006 RVA: 0x002D9464 File Offset: 0x002D7664
		// Note: this type is marked as 'beforefieldinit'.
		static ClientHostSocket()
		{
			Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientHostSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr);
			ClientHostSocket.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_server");
			ClientHostSocket.NativeFieldInfoPtr__incoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_incoming");
			ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685858);
			ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685859);
			ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685860);
			ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685861);
			ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685862);
			ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685863);
			ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685864);
			ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685865);
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x002D955C File Offset: 0x002D775C
		[CallerCount(0)]
		public unsafe void CheckSetStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A0 RID: 47008 RVA: 0x002D9590 File Offset: 0x002D7790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312337, XrefRangeEnd = 312339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(ServerSocket serverSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverSocket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x002D95E0 File Offset: 0x002D77E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312339, XrefRangeEnd = 312343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x002D9638 File Offset: 0x002D7838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312353, RefRangeEnd = 312355, XrefRangeStart = 312343, XrefRangeEnd = 312353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x002D9674 File Offset: 0x002D7874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312355, XrefRangeEnd = 312371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A4 RID: 47012 RVA: 0x002D96A8 File Offset: 0x002D78A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312371, XrefRangeEnd = 312374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromLocalServer(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x002D96F0 File Offset: 0x002D78F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312374, XrefRangeEnd = 312389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x002D9748 File Offset: 0x002D7948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312389, XrefRangeEnd = 312401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientHostSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x0005A2AC File Offset: 0x000584AC
		public ClientHostSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x002D9784 File Offset: 0x002D7984
		// (set) Token: 0x0600B7A9 RID: 47017 RVA: 0x0005A2B5 File Offset: 0x000584B5
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600B7AA RID: 47018 RVA: 0x002D97B4 File Offset: 0x002D79B4
		// (set) Token: 0x0600B7AB RID: 47019 RVA: 0x0005A2D4 File Offset: 0x000584D4
		public unsafe Queue<LocalPacket> _incoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BB0 RID: 31664
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04007BB1 RID: 31665
		private static readonly IntPtr NativeFieldInfoPtr__incoming;

		// Token: 0x04007BB2 RID: 31666
		private static readonly IntPtr NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0;

		// Token: 0x04007BB3 RID: 31667
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0;

		// Token: 0x04007BB4 RID: 31668
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0;

		// Token: 0x04007BB5 RID: 31669
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BB6 RID: 31670
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BB7 RID: 31671
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0;

		// Token: 0x04007BB8 RID: 31672
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007BB9 RID: 31673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
