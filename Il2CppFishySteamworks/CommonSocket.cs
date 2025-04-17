using System;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078C RID: 1932
	public class CommonSocket : Object
	{
		// Token: 0x0600B6FE RID: 46846 RVA: 0x002D6E10 File Offset: 0x002D5010
		// Note: this type is marked as 'beforefieldinit'.
		static CommonSocket()
		{
			Il2CppClassPointerStore<CommonSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "CommonSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr);
			CommonSocket.NativeFieldInfoPtr__connectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "_connectionState");
			CommonSocket.NativeFieldInfoPtr_PeerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "PeerToPeer");
			CommonSocket.NativeFieldInfoPtr_Transport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "Transport");
			CommonSocket.NativeFieldInfoPtr_MessagePointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MessagePointers");
			CommonSocket.NativeFieldInfoPtr_InboundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "InboundBuffer");
			CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MAX_MESSAGES");
			CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685780);
			CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685781);
			CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685782);
			CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685783);
			CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685784);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685785);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685786);
			CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685787);
			CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685788);
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x002D6F6C File Offset: 0x002D516C
		[CallerCount(0)]
		public unsafe LocalConnectionState GetLocalConnectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x002D6FA8 File Offset: 0x002D51A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311626, RefRangeEnd = 311629, XrefRangeStart = 311625, XrefRangeEnd = 311626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x002D7000 File Offset: 0x002D5200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311629, XrefRangeEnd = 311639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Transport t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x002D7050 File Offset: 0x002D5250
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311647, RefRangeEnd = 311649, XrefRangeStart = 311639, XrefRangeEnd = 311647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetIPBytes(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x002D70A0 File Offset: 0x002D52A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311681, RefRangeEnd = 311684, XrefRangeStart = 311649, XrefRangeEnd = 311681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x002D7110 File Offset: 0x002D5310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311684, XrefRangeEnd = 311692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x002D7154 File Offset: 0x002D5354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311692, XrefRangeEnd = 311701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(Queue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x002D7198 File Offset: 0x002D5398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311713, RefRangeEnd = 311714, XrefRangeStart = 311701, XrefRangeEnd = 311713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMessage(IntPtr ptr, Il2CppStructArray<byte> buffer, out ArraySegment<byte> segment, out byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr3 = &intPtr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &channel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			segment = ((intPtr4 == 0) ? null : new ArraySegment<byte>(intPtr4));
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x002D7218 File Offset: 0x002D5418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311714, XrefRangeEnd = 311719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x00059E36 File Offset: 0x00058036
		public CommonSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600B709 RID: 46857 RVA: 0x002D7254 File Offset: 0x002D5454
		// (set) Token: 0x0600B70A RID: 46858 RVA: 0x00059E3F File Offset: 0x0005803F
		public unsafe LocalConnectionState _connectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState)) = value;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600B70B RID: 46859 RVA: 0x002D727C File Offset: 0x002D547C
		// (set) Token: 0x0600B70C RID: 46860 RVA: 0x00059E5A File Offset: 0x0005805A
		public unsafe bool PeerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer)) = value;
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600B70D RID: 46861 RVA: 0x002D72A4 File Offset: 0x002D54A4
		// (set) Token: 0x0600B70E RID: 46862 RVA: 0x00059E75 File Offset: 0x00058075
		public unsafe Transport Transport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600B70F RID: 46863 RVA: 0x002D72D4 File Offset: 0x002D54D4
		// (set) Token: 0x0600B710 RID: 46864 RVA: 0x00059E94 File Offset: 0x00058094
		public unsafe Il2CppStructArray<IntPtr> MessagePointers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600B711 RID: 46865 RVA: 0x002D7304 File Offset: 0x002D5504
		// (set) Token: 0x0600B712 RID: 46866 RVA: 0x00059EB3 File Offset: 0x000580B3
		public unsafe Il2CppStructArray<byte> InboundBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600B713 RID: 46867 RVA: 0x002D7334 File Offset: 0x002D5534
		// (set) Token: 0x0600B714 RID: 46868 RVA: 0x00059ED2 File Offset: 0x000580D2
		public unsafe static int MAX_MESSAGES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&value));
			}
		}

		// Token: 0x04007B3F RID: 31551
		private static readonly IntPtr NativeFieldInfoPtr__connectionState;

		// Token: 0x04007B40 RID: 31552
		private static readonly IntPtr NativeFieldInfoPtr_PeerToPeer;

		// Token: 0x04007B41 RID: 31553
		private static readonly IntPtr NativeFieldInfoPtr_Transport;

		// Token: 0x04007B42 RID: 31554
		private static readonly IntPtr NativeFieldInfoPtr_MessagePointers;

		// Token: 0x04007B43 RID: 31555
		private static readonly IntPtr NativeFieldInfoPtr_InboundBuffer;

		// Token: 0x04007B44 RID: 31556
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGES;

		// Token: 0x04007B45 RID: 31557
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0;

		// Token: 0x04007B46 RID: 31558
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0;

		// Token: 0x04007B47 RID: 31559
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0;

		// Token: 0x04007B48 RID: 31560
		private static readonly IntPtr NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04007B49 RID: 31561
		private static readonly IntPtr NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0;

		// Token: 0x04007B4A RID: 31562
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0;

		// Token: 0x04007B4B RID: 31563
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0;

		// Token: 0x04007B4C RID: 31564
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0;

		// Token: 0x04007B4D RID: 31565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
