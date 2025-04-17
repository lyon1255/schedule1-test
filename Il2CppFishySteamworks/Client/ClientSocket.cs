using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000791 RID: 1937
	public class ClientSocket : CommonSocket
	{
		// Token: 0x0600B7AC RID: 47020 RVA: 0x002D97E4 File Offset: 0x002D79E4
		// Note: this type is marked as 'beforefieldinit'.
		static ClientSocket()
		{
			Il2CppClassPointerStore<ClientSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr);
			ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_onLocalConnectionStateCallback");
			ClientSocket.NativeFieldInfoPtr__hostSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_hostSteamID");
			ClientSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_socket");
			ClientSocket.NativeFieldInfoPtr__timeoutThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_timeoutThread");
			ClientSocket.NativeFieldInfoPtr__connectTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_connectTimeout");
			ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "CONNECT_TIMEOUT_DURATION");
			ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685866);
			ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685867);
			ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685868);
			ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685869);
			ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685870);
			ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685871);
			ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685872);
			ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685873);
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x002D992C File Offset: 0x002D7B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312401, XrefRangeEnd = 312432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x002D9960 File Offset: 0x002D7B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312432, XrefRangeEnd = 312469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x002D99CC File Offset: 0x002D7BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312469, XrefRangeEnd = 312480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x002D9A14 File Offset: 0x002D7C14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312499, RefRangeEnd = 312503, XrefRangeStart = 312480, XrefRangeEnd = 312499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x002D9A50 File Offset: 0x002D7C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312517, RefRangeEnd = 312518, XrefRangeStart = 312503, XrefRangeEnd = 312517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x002D9A84 File Offset: 0x002D7C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312518, XrefRangeEnd = 312527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x002D9ADC File Offset: 0x002D7CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312527, XrefRangeEnd = 312528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x002D9B10 File Offset: 0x002D7D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312528, XrefRangeEnd = 312537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x0005A2F3 File Offset: 0x000584F3
		public ClientSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600B7B6 RID: 47030 RVA: 0x002D9B4C File Offset: 0x002D7D4C
		// (set) Token: 0x0600B7B7 RID: 47031 RVA: 0x0005A2FC File Offset: 0x000584FC
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600B7B8 RID: 47032 RVA: 0x002D9B7C File Offset: 0x002D7D7C
		// (set) Token: 0x0600B7B9 RID: 47033 RVA: 0x0005A31B File Offset: 0x0005851B
		public unsafe CSteamID _hostSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID)) = value;
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600B7BA RID: 47034 RVA: 0x002D9BA4 File Offset: 0x002D7DA4
		// (set) Token: 0x0600B7BB RID: 47035 RVA: 0x0005A336 File Offset: 0x00058536
		public unsafe HSteamNetConnection _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x002D9BCC File Offset: 0x002D7DCC
		// (set) Token: 0x0600B7BD RID: 47037 RVA: 0x0005A351 File Offset: 0x00058551
		public unsafe Thread _timeoutThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600B7BE RID: 47038 RVA: 0x002D9BFC File Offset: 0x002D7DFC
		// (set) Token: 0x0600B7BF RID: 47039 RVA: 0x0005A370 File Offset: 0x00058570
		public unsafe float _connectTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout)) = value;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x002D9C24 File Offset: 0x002D7E24
		// (set) Token: 0x0600B7C1 RID: 47041 RVA: 0x0005A38B File Offset: 0x0005858B
		public unsafe static float CONNECT_TIMEOUT_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&value));
			}
		}

		// Token: 0x04007BBA RID: 31674
		private static readonly IntPtr NativeFieldInfoPtr__onLocalConnectionStateCallback;

		// Token: 0x04007BBB RID: 31675
		private static readonly IntPtr NativeFieldInfoPtr__hostSteamID;

		// Token: 0x04007BBC RID: 31676
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x04007BBD RID: 31677
		private static readonly IntPtr NativeFieldInfoPtr__timeoutThread;

		// Token: 0x04007BBE RID: 31678
		private static readonly IntPtr NativeFieldInfoPtr__connectTimeout;

		// Token: 0x04007BBF RID: 31679
		private static readonly IntPtr NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION;

		// Token: 0x04007BC0 RID: 31680
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Private_Void_0;

		// Token: 0x04007BC1 RID: 31681
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0;

		// Token: 0x04007BC2 RID: 31682
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04007BC3 RID: 31683
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BC4 RID: 31684
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BC5 RID: 31685
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007BC6 RID: 31686
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04007BC7 RID: 31687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
