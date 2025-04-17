using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000374 RID: 884
	public class MessagingManager : NetworkSingleton<MessagingManager>
	{
		// Token: 0x060044D5 RID: 17621 RVA: 0x001538E4 File Offset: 0x00151AE4
		// Note: this type is marked as 'beforefieldinit'.
		static MessagingManager()
		{
			Il2CppClassPointerStore<MessagingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MessagingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr);
			MessagingManager.NativeFieldInfoPtr_ConversationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "ConversationMap");
			MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted");
			MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Messaging.MessagingManagerAssembly-CSharp.dll_Excuted");
			MessagingManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671702);
			MessagingManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671703);
			MessagingManager.NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671704);
			MessagingManager.NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671705);
			MessagingManager.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671706);
			MessagingManager.NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671707);
			MessagingManager.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671708);
			MessagingManager.NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671709);
			MessagingManager.NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671710);
			MessagingManager.NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671711);
			MessagingManager.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671712);
			MessagingManager.NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671713);
			MessagingManager.NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671714);
			MessagingManager.NativeMethodInfoPtr_ClearResponses_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671715);
			MessagingManager.NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671716);
			MessagingManager.NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671717);
			MessagingManager.NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671718);
			MessagingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671719);
			MessagingManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671720);
			MessagingManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671721);
			MessagingManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671722);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671723);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671724);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671725);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671726);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671727);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671728);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671729);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671730);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671731);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671732);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671733);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671734);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671735);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671736);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671737);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671738);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671739);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671740);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671741);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671742);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671743);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671744);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671745);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671746);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671747);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671748);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671749);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671750);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671751);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671752);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671753);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671754);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671755);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671756);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671757);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671758);
			MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671759);
			MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671760);
			MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671761);
			MessagingManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, 100671762);
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x00153E14 File Offset: 0x00152014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155524, XrefRangeEnd = 155527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x00153E50 File Offset: 0x00152050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155527, XrefRangeEnd = 155541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x00153EA0 File Offset: 0x001520A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155541, XrefRangeEnd = 155555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation GetConversation(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00153EF0 File Offset: 0x001520F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155555, XrefRangeEnd = 155570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(NPC npc, MSGConversation convs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(convs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00153F44 File Offset: 0x00152144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155570, XrefRangeEnd = 155595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00153FA8 File Offset: 0x001521A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155619, RefRangeEnd = 155620, XrefRangeStart = 155595, XrefRangeEnd = 155619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessage(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x0015400C File Offset: 0x0015220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155620, XrefRangeEnd = 155645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0015407C File Offset: 0x0015227C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155670, RefRangeEnd = 155672, XrefRangeStart = 155645, XrefRangeEnd = 155670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x001540EC File Offset: 0x001522EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155672, XrefRangeEnd = 155697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendResponse(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x0015413C File Offset: 0x0015233C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155721, RefRangeEnd = 155722, XrefRangeStart = 155697, XrefRangeEnd = 155721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveResponse(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x0015418C File Offset: 0x0015238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155722, XrefRangeEnd = 155748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x001541EC File Offset: 0x001523EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155774, RefRangeEnd = 155776, XrefRangeStart = 155748, XrefRangeEnd = 155774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerMessage(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x0015424C File Offset: 0x0015244C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155787, RefRangeEnd = 155788, XrefRangeStart = 155776, XrefRangeEnd = 155787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveMSGConversationData(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x001542B4 File Offset: 0x001524B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155788, XrefRangeEnd = 155807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ClearResponses_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x001542F8 File Offset: 0x001524F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155807, XrefRangeEnd = 155826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveClearResponses(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x0015433C File Offset: 0x0015253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155826, XrefRangeEnd = 155851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x001543A0 File Offset: 0x001525A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155875, RefRangeEnd = 155876, XrefRangeStart = 155851, XrefRangeEnd = 155875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveShowResponses(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00154404 File Offset: 0x00152604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155876, XrefRangeEnd = 155886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x00154440 File Offset: 0x00152640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155886, XrefRangeEnd = 155969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x0015447C File Offset: 0x0015267C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155969, XrefRangeEnd = 155972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x001544B8 File Offset: 0x001526B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001544F4 File Offset: 0x001526F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155972, XrefRangeEnd = 155984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00154558 File Offset: 0x00152758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155619, RefRangeEnd = 155620, XrefRangeStart = 155619, XrefRangeEnd = 155620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x001545BC File Offset: 0x001527BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155984, XrefRangeEnd = 155989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessage_2134336246(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00154620 File Offset: 0x00152820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156001, RefRangeEnd = 156002, XrefRangeStart = 155989, XrefRangeEnd = 156001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00154684 File Offset: 0x00152884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156022, RefRangeEnd = 156026, XrefRangeStart = 156002, XrefRangeEnd = 156022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMessage_2134336246(Message m, bool notify, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x001546E8 File Offset: 0x001528E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156026, XrefRangeEnd = 156031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveMessage_2134336246(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00154738 File Offset: 0x00152938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156031, XrefRangeEnd = 156044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x001547A8 File Offset: 0x001529A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155670, RefRangeEnd = 155672, XrefRangeStart = 155670, XrefRangeEnd = 155672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00154818 File Offset: 0x00152A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156044, XrefRangeEnd = 156050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMessageChain_3949292778(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x0015487C File Offset: 0x00152A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156050, XrefRangeEnd = 156063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x001548EC File Offset: 0x00152AEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156083, RefRangeEnd = 156086, XrefRangeStart = 156063, XrefRangeEnd = 156083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMessageChain_3949292778(MessageChain m, string npcID, float initialDelay, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x0015495C File Offset: 0x00152B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156086, XrefRangeEnd = 156092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveMessageChain_3949292778(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x001549AC File Offset: 0x00152BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156092, XrefRangeEnd = 156113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x001549FC File Offset: 0x00152BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155721, RefRangeEnd = 155722, XrefRangeStart = 155721, XrefRangeEnd = 155722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00154A4C File Offset: 0x00152C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156113, XrefRangeEnd = 156119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendResponse_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00154AB0 File Offset: 0x00152CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156140, RefRangeEnd = 156141, XrefRangeStart = 156119, XrefRangeEnd = 156140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00154B00 File Offset: 0x00152D00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156173, RefRangeEnd = 156177, XrefRangeStart = 156141, XrefRangeEnd = 156173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveResponse_2801973956(int responseIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref responseIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00154B50 File Offset: 0x00152D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156177, XrefRangeEnd = 156183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveResponse_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00154BA0 File Offset: 0x00152DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156183, XrefRangeEnd = 156197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00154C00 File Offset: 0x00152E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155774, RefRangeEnd = 155776, XrefRangeStart = 155774, XrefRangeEnd = 155776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00154C60 File Offset: 0x00152E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156197, XrefRangeEnd = 156205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerMessage_1952281135(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00154CC4 File Offset: 0x00152EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156205, XrefRangeEnd = 156219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00154D24 File Offset: 0x00152F24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156242, RefRangeEnd = 156245, XrefRangeStart = 156219, XrefRangeEnd = 156242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerMessage_1952281135(int sendableIndex, int sentIndex, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00154D84 File Offset: 0x00152F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156245, XrefRangeEnd = 156253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerMessage_1952281135(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00154DD4 File Offset: 0x00152FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155787, RefRangeEnd = 155788, XrefRangeStart = 155787, XrefRangeEnd = 155788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x00154E3C File Offset: 0x0015303C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156253, XrefRangeEnd = 156272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveMSGConversationData_2662241369(NetworkConnection conn, string npcID, MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x00154EA4 File Offset: 0x001530A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156272, XrefRangeEnd = 156289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveMSGConversationData_2662241369(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x00154EF4 File Offset: 0x001530F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x00154F38 File Offset: 0x00153138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x00154F7C File Offset: 0x0015317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156289, XrefRangeEnd = 156301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ClearResponses_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x00154FE0 File Offset: 0x001531E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00155024 File Offset: 0x00153224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156301, XrefRangeEnd = 156324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveClearResponses_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00155068 File Offset: 0x00153268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156324, XrefRangeEnd = 156344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveClearResponses_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x001550B8 File Offset: 0x001532B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156344, XrefRangeEnd = 156356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x0015511C File Offset: 0x0015331C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155875, RefRangeEnd = 155876, XrefRangeStart = 155875, XrefRangeEnd = 155876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00155180 File Offset: 0x00153380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156356, XrefRangeEnd = 156362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ShowResponses_995803534(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x001551E4 File Offset: 0x001533E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156374, RefRangeEnd = 156375, XrefRangeStart = 156362, XrefRangeEnd = 156374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00155248 File Offset: 0x00153448
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 156395, RefRangeEnd = 156399, XrefRangeStart = 156375, XrefRangeEnd = 156395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveShowResponses_995803534(string npcID, List<Response> responses, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x001552AC File Offset: 0x001534AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156399, XrefRangeEnd = 156405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveShowResponses_995803534(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x001552FC File Offset: 0x001534FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156405, XrefRangeEnd = 156408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagingManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x00021963 File Offset: 0x0001FB63
		public MessagingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x00155338 File Offset: 0x00153538
		// (set) Token: 0x06004515 RID: 17685 RVA: 0x0002196C File Offset: 0x0001FB6C
		public unsafe Dictionary<NPC, MSGConversation> ConversationMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_ConversationMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_ConversationMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x00155368 File Offset: 0x00153568
		// (set) Token: 0x06004517 RID: 17687 RVA: 0x0002198B File Offset: 0x0001FB8B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x00155390 File Offset: 0x00153590
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x000219A6 File Offset: 0x0001FBA6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeFieldInfoPtr_ConversationMap;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_GetConversation_Public_MSGConversation_NPC_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_NPC_MSGConversation_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_String_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessage_Private_Void_Message_Boolean_String_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessageChain_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeMethodInfoPtr_SendResponse_Public_Void_Int32_String_0;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveResponse_Private_Void_Int32_String_0;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeMethodInfoPtr_ReceivePlayerMessage_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMSGConversationData_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_String_0;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveClearResponses_Private_Void_String_0;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveShowResponses_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessage_2134336246_Public_Void_Message_Boolean_String_0;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessage_2134336246_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMessage_2134336246_Private_Void_Message_Boolean_String_0;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessage_2134336246_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendMessageChain_3949292778_Public_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMessageChain_3949292778_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMessageChain_3949292778_Private_Void_MessageChain_String_Single_Boolean_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveMessageChain_3949292778_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendResponse_2801973956_Public_Void_Int32_String_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendResponse_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveResponse_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveResponse_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerMessage_1952281135_Public_Void_Int32_Int32_String_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerMessage_1952281135_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerMessage_1952281135_Private_Void_Int32_Int32_String_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerMessage_1952281135_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveMSGConversationData_2662241369_Private_Void_NetworkConnection_String_MSGConversationData_0;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveMSGConversationData_2662241369_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearResponses_3615296227_Public_Void_String_0;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ClearResponses_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveClearResponses_3615296227_Private_Void_String_0;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveClearResponses_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ShowResponses_995803534_Public_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ShowResponses_995803534_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveShowResponses_995803534_Private_Void_String_List_1_Response_Single_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveShowResponses_995803534_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200096A RID: 2410
		[ObfuscatedName("ScheduleOne.Messaging.MessagingManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600C949 RID: 51529 RVA: 0x0030BC1C File Offset: 0x00309E1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagingManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr);
				MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, "connection");
				MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, 100671763);
				MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, 100671764);
				MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, 100671765);
			}

			// Token: 0x0600C94A RID: 51530 RVA: 0x0030BCAC File Offset: 0x00309EAC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C94B RID: 51531 RVA: 0x0030BCE8 File Offset: 0x00309EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155511, XrefRangeEnd = 155516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C94C RID: 51532 RVA: 0x0030BD28 File Offset: 0x00309F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155516, XrefRangeEnd = 155524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C94D RID: 51533 RVA: 0x00061E5C File Offset: 0x0006005C
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECA RID: 16074
			// (get) Token: 0x0600C94E RID: 51534 RVA: 0x0030BD64 File Offset: 0x00309F64
			// (set) Token: 0x0600C94F RID: 51535 RVA: 0x00061E65 File Offset: 0x00060065
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECB RID: 16075
			// (get) Token: 0x0600C950 RID: 51536 RVA: 0x0030BD94 File Offset: 0x00309F94
			// (set) Token: 0x0600C951 RID: 51537 RVA: 0x00061E84 File Offset: 0x00060084
			public unsafe MessagingManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagingManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008843 RID: 34883
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x04008844 RID: 34884
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008845 RID: 34885
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008846 RID: 34886
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008847 RID: 34887
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0;

			// Token: 0x02000C40 RID: 3136
			[ObfuscatedName("ScheduleOne.Messaging.MessagingManager+<>c__DisplayClass2_0+<<OnSpawnServer>g__SendMessages|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600E21F RID: 57887 RVA: 0x00351E8C File Offset: 0x0035008C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0>.NativeClassPtr, "<<OnSpawnServer>g__SendMessages|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671766);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671767);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671768);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671769);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671770);
					MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671771);
				}

				// Token: 0x0600E220 RID: 57888 RVA: 0x00351F6C File Offset: 0x0035016C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E221 RID: 57889 RVA: 0x00351FB4 File Offset: 0x003501B4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E222 RID: 57890 RVA: 0x00351FE8 File Offset: 0x003501E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155466, XrefRangeEnd = 155506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700461D RID: 17949
				// (get) Token: 0x0600E223 RID: 57891 RVA: 0x00352024 File Offset: 0x00350224
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E224 RID: 57892 RVA: 0x00352064 File Offset: 0x00350264
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155506, XrefRangeEnd = 155511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700461E RID: 17950
				// (get) Token: 0x0600E225 RID: 57893 RVA: 0x00352098 File Offset: 0x00350298
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E226 RID: 57894 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700461A RID: 17946
				// (get) Token: 0x0600E227 RID: 57895 RVA: 0x003520D8 File Offset: 0x003502D8
				// (set) Token: 0x0600E228 RID: 57896 RVA: 0x0006E3CD File Offset: 0x0006C5CD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700461B RID: 17947
				// (get) Token: 0x0600E229 RID: 57897 RVA: 0x00352100 File Offset: 0x00350300
				// (set) Token: 0x0600E22A RID: 57898 RVA: 0x0006E3E8 File Offset: 0x0006C5E8
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700461C RID: 17948
				// (get) Token: 0x0600E22B RID: 57899 RVA: 0x00352130 File Offset: 0x00350330
				// (set) Token: 0x0600E22C RID: 57900 RVA: 0x0006E407 File Offset: 0x0006C607
				public unsafe MessagingManager.__c__DisplayClass2_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagingManager.__c__DisplayClass2_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessagingManager.__c__DisplayClass2_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400975F RID: 38751
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009760 RID: 38752
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009761 RID: 38753
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009762 RID: 38754
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009763 RID: 38755
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009764 RID: 38756
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009765 RID: 38757
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009766 RID: 38758
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009767 RID: 38759
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
