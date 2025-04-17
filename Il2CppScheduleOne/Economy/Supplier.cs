using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000419 RID: 1049
	public class Supplier : NPC
	{
		// Token: 0x06005BAA RID: 23466 RVA: 0x001A9124 File Offset: 0x001A7324
		// Note: this type is marked as 'beforefieldinit'.
		static Supplier()
		{
			Il2CppClassPointerStore<Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier>.NativeClassPtr);
			Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_DURATION_MINS");
			Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETING_COOLDOWN_MINS");
			Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_WAIT_PER_ITEM");
			Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_MAX_WAIT");
			Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_ITEM_LIMIT");
			Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DELIVERY_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_SupplierLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierLabelColor");
			Supplier.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<Status>k__BackingField");
			Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<DeliveriesEnabled>k__BackingField");
			Supplier.NativeFieldInfoPtr_MinOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MinOrderLimit");
			Supplier.NativeFieldInfoPtr_MaxOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MaxOrderLimit");
			Supplier.NativeFieldInfoPtr_OnlineShopItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "OnlineShopItems");
			Supplier.NativeFieldInfoPtr_SupplierRecommendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierRecommendMessage");
			Supplier.NativeFieldInfoPtr_SupplierUnlockHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierUnlockHint");
			Supplier.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Shop");
			Supplier.NativeFieldInfoPtr_Stash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Stash");
			Supplier.NativeFieldInfoPtr_onDeaddropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "onDeaddropReady");
			Supplier.NativeFieldInfoPtr_minsSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceMeetingStart");
			Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceLastMeetingEnd");
			Supplier.NativeFieldInfoPtr_currentLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "currentLocation");
			Supplier.NativeFieldInfoPtr_dialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "dialogueController");
			Supplier.NativeFieldInfoPtr_meetingGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingGreeting");
			Supplier.NativeFieldInfoPtr_meetingChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingChoice");
			Supplier.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "debt");
			Supplier.NativeFieldInfoPtr_deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deadDropPreparing");
			Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<minsUntilDeaddropReady>k__BackingField");
			Supplier.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deaddropItems");
			Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceDeaddropOrder");
			Supplier.NativeFieldInfoPtr_repaymentReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "repaymentReminderSent");
			Supplier.NativeFieldInfoPtr_syncVar___debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___debt");
			Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___deadDropPreparing");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674985);
			Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674986);
			Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674987);
			Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674988);
			Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674989);
			Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674990);
			Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674991);
			Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674992);
			Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674993);
			Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674994);
			Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674995);
			Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674996);
			Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674997);
			Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674998);
			Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674999);
			Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675000);
			Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675001);
			Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675002);
			Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675003);
			Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675004);
			Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675005);
			Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675006);
			Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675007);
			Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675008);
			Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675009);
			Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675010);
			Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675011);
			Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675012);
			Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675013);
			Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675014);
			Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675015);
			Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675016);
			Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675017);
			Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675018);
			Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675019);
			Supplier.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675020);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675021);
			Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675022);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675024);
			Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675025);
			Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675026);
			Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675027);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675028);
			Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675029);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675030);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675031);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675032);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675033);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675034);
			Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675035);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675036);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675037);
			Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675038);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675039);
			Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675040);
			Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675041);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675042);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675043);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675044);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675045);
			Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675046);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675047);
			Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675048);
			Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675049);
			Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675050);
			Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675051);
			Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675052);
			Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675053);
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06005BAB RID: 23467 RVA: 0x001A994C File Offset: 0x001A7B4C
		// (set) Token: 0x06005BAC RID: 23468 RVA: 0x001A9988 File Offset: 0x001A7B88
		public unsafe Supplier.ESupplierStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x001A99C8 File Offset: 0x001A7BC8
		// (set) Token: 0x06005BAE RID: 23470 RVA: 0x001A9A04 File Offset: 0x001A7C04
		public unsafe bool DeliveriesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x001A9A44 File Offset: 0x001A7C44
		public unsafe float Debt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x001A9A80 File Offset: 0x001A7C80
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x001A9ABC File Offset: 0x001A7CBC
		public unsafe int minsUntilDeaddropReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x001A9AFC File Offset: 0x001A7CFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x001A9B38 File Offset: 0x001A7D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193405, XrefRangeEnd = 193541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x001A9B74 File Offset: 0x001A7D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193541, XrefRangeEnd = 193552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x001A9BC4 File Offset: 0x001A7DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193570, RefRangeEnd = 193571, XrefRangeStart = 193552, XrefRangeEnd = 193570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB6 RID: 23478 RVA: 0x001A9BF8 File Offset: 0x001A7DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193571, XrefRangeEnd = 193589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x001A9C2C File Offset: 0x001A7E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193589, XrefRangeEnd = 193602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x001A9C68 File Offset: 0x001A7E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193602, XrefRangeEnd = 193619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x001A9C9C File Offset: 0x001A7E9C
		[CallerCount(0)]
		public unsafe void OnTimeSkip(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSlept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x001A9CDC File Offset: 0x001A7EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193645, RefRangeEnd = 193647, XrefRangeStart = 193619, XrefRangeEnd = 193645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x001A9D3C File Offset: 0x001A7F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193647, XrefRangeEnd = 193655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x001A9D70 File Offset: 0x001A7F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193655, XrefRangeEnd = 193661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x001A9DC8 File Offset: 0x001A7FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193661, XrefRangeEnd = 193688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x001A9E14 File Offset: 0x001A8014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193725, RefRangeEnd = 193727, XrefRangeStart = 193688, XrefRangeEnd = 193725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableDeliveries(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x001A9E58 File Offset: 0x001A8058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193727, XrefRangeEnd = 193733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlockMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x001A9E8C File Offset: 0x001A808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193733, XrefRangeEnd = 193788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x001A9EC8 File Offset: 0x001A80C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193788, XrefRangeEnd = 193805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x001A9F04 File Offset: 0x001A8104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193927, RefRangeEnd = 193928, XrefRangeStart = 193805, XrefRangeEnd = 193927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x001A9F60 File Offset: 0x001A8160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193949, RefRangeEnd = 193951, XrefRangeStart = 193928, XrefRangeEnd = 193949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeaddrop(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x001A9FB0 File Offset: 0x001A81B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193973, RefRangeEnd = 193975, XrefRangeStart = 193951, XrefRangeEnd = 193973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeDebt(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x001A9FF0 File Offset: 0x001A81F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194015, RefRangeEnd = 194016, XrefRangeStart = 193975, XrefRangeEnd = 194015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRecoverDebt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x001AA024 File Offset: 0x001A8224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194093, RefRangeEnd = 194094, XrefRangeStart = 194016, XrefRangeEnd = 194093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeaddrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x001AA058 File Offset: 0x001A8258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194094, XrefRangeEnd = 194109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDebtReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x001AA08C File Offset: 0x001A828C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194109, XrefRangeEnd = 194127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MeetupRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x001AA0C8 File Offset: 0x001A82C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194127, XrefRangeEnd = 194142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PayDebtRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x001AA104 File Offset: 0x001A8304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194227, RefRangeEnd = 194228, XrefRangeStart = 194142, XrefRangeEnd = 194227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr3) : null;
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x001AA150 File Offset: 0x001A8350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194228, XrefRangeEnd = 194232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x001AA1B8 File Offset: 0x001A83B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194232, XrefRangeEnd = 194238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x001AA220 File Offset: 0x001A8420
		[CallerCount(0)]
		public unsafe virtual float GetDeadDropLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x001AA268 File Offset: 0x001A8468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194238, XrefRangeEnd = 194243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x001AA2AC File Offset: 0x001A84AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194243, XrefRangeEnd = 194270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x001AA30C File Offset: 0x001A850C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194279, RefRangeEnd = 194282, XrefRangeStart = 194270, XrefRangeEnd = 194279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x001AA348 File Offset: 0x001A8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194282, XrefRangeEnd = 194287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x001AA388 File Offset: 0x001A8588
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194357, RefRangeEnd = 194360, XrefRangeStart = 194287, XrefRangeEnd = 194357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x001AA3C4 File Offset: 0x001A85C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194361, RefRangeEnd = 194364, XrefRangeStart = 194360, XrefRangeEnd = 194361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x001AA400 File Offset: 0x001A8600
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x001AA43C File Offset: 0x001A863C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193570, RefRangeEnd = 193571, XrefRangeStart = 193570, XrefRangeEnd = 193571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x001AA470 File Offset: 0x001A8670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x001AA4A4 File Offset: 0x001A86A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194364, XrefRangeEnd = 194374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x001AA508 File Offset: 0x001A8708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x001AA53C File Offset: 0x001A873C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194374, XrefRangeEnd = 194375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x001AA570 File Offset: 0x001A8770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194375, XrefRangeEnd = 194376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x001AA5C0 File Offset: 0x001A87C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194376, XrefRangeEnd = 194390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x001AA620 File Offset: 0x001A8820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194437, RefRangeEnd = 194439, XrefRangeStart = 194390, XrefRangeEnd = 194437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x001AA680 File Offset: 0x001A8880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194439, XrefRangeEnd = 194447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x001AA6D0 File Offset: 0x001A88D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194447, XrefRangeEnd = 194465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x001AA714 File Offset: 0x001A8914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194476, RefRangeEnd = 194479, XrefRangeStart = 194465, XrefRangeEnd = 194476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x001AA758 File Offset: 0x001A8958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194479, XrefRangeEnd = 194482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x001AA7A8 File Offset: 0x001A89A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194482, XrefRangeEnd = 194500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x001AA7EC File Offset: 0x001A89EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194500, XrefRangeEnd = 194503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x001AA83C File Offset: 0x001A8A3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193949, RefRangeEnd = 193951, XrefRangeStart = 193949, XrefRangeEnd = 193951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x001AA88C File Offset: 0x001A8A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194503, XrefRangeEnd = 194519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x001AA8DC File Offset: 0x001A8ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194519, XrefRangeEnd = 194537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x001AA940 File Offset: 0x001A8B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194537, XrefRangeEnd = 194556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x001AA980 File Offset: 0x001A8B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194564, RefRangeEnd = 194566, XrefRangeStart = 194556, XrefRangeEnd = 194564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x001AA9C0 File Offset: 0x001A8BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194566, XrefRangeEnd = 194570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06005BE9 RID: 23529 RVA: 0x001AAA24 File Offset: 0x001A8C24
		// (set) Token: 0x06005BEA RID: 23530 RVA: 0x001AAA60 File Offset: 0x001A8C60
		public unsafe float SyncAccessor_debt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 194578, RefRangeEnd = 194579, XrefRangeStart = 194570, XrefRangeEnd = 194578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x001AAAAC File Offset: 0x001A8CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194579, XrefRangeEnd = 194584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x001AAB20 File Offset: 0x001A8D20
		// (set) Token: 0x06005BED RID: 23533 RVA: 0x001AAB5C File Offset: 0x001A8D5C
		public unsafe bool SyncAccessor_deadDropPreparing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194584, XrefRangeEnd = 194592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x001AABA8 File Offset: 0x001A8DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194592, XrefRangeEnd = 194593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x0002B3AA File Offset: 0x000295AA
		public Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06005BF0 RID: 23536 RVA: 0x001AABE4 File Offset: 0x001A8DE4
		// (set) Token: 0x06005BF1 RID: 23537 RVA: 0x0002B3B3 File Offset: 0x000295B3
		public unsafe static float MEETUP_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06005BF2 RID: 23538 RVA: 0x001AAC00 File Offset: 0x001A8E00
		// (set) Token: 0x06005BF3 RID: 23539 RVA: 0x0002B3C1 File Offset: 0x000295C1
		public unsafe static int MEETUP_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x001AAC1C File Offset: 0x001A8E1C
		// (set) Token: 0x06005BF5 RID: 23541 RVA: 0x0002B3CF File Offset: 0x000295CF
		public unsafe static int MEETING_COOLDOWN_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x001AAC38 File Offset: 0x001A8E38
		// (set) Token: 0x06005BF7 RID: 23543 RVA: 0x0002B3DD File Offset: 0x000295DD
		public unsafe static int DEADDROP_WAIT_PER_ITEM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&value));
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06005BF8 RID: 23544 RVA: 0x001AAC54 File Offset: 0x001A8E54
		// (set) Token: 0x06005BF9 RID: 23545 RVA: 0x0002B3EB File Offset: 0x000295EB
		public unsafe static int DEADDROP_MAX_WAIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&value));
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x001AAC70 File Offset: 0x001A8E70
		// (set) Token: 0x06005BFB RID: 23547 RVA: 0x0002B3F9 File Offset: 0x000295F9
		public unsafe static int DEADDROP_ITEM_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x001AAC8C File Offset: 0x001A8E8C
		// (set) Token: 0x06005BFD RID: 23549 RVA: 0x0002B407 File Offset: 0x00029607
		public unsafe static float DELIVERY_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x001AACA8 File Offset: 0x001A8EA8
		// (set) Token: 0x06005BFF RID: 23551 RVA: 0x0002B415 File Offset: 0x00029615
		public unsafe static Color32 SupplierLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x001AACC4 File Offset: 0x001A8EC4
		// (set) Token: 0x06005C01 RID: 23553 RVA: 0x0002B423 File Offset: 0x00029623
		public unsafe Supplier.ESupplierStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06005C02 RID: 23554 RVA: 0x001AACEC File Offset: 0x001A8EEC
		// (set) Token: 0x06005C03 RID: 23555 RVA: 0x0002B43E File Offset: 0x0002963E
		public unsafe bool _DeliveriesEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x001AAD14 File Offset: 0x001A8F14
		// (set) Token: 0x06005C05 RID: 23557 RVA: 0x0002B459 File Offset: 0x00029659
		public unsafe float MinOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit)) = value;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x001AAD3C File Offset: 0x001A8F3C
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x0002B474 File Offset: 0x00029674
		public unsafe float MaxOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit)) = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x001AAD64 File Offset: 0x001A8F64
		// (set) Token: 0x06005C09 RID: 23561 RVA: 0x0002B48F File Offset: 0x0002968F
		public unsafe Il2CppReferenceArray<PhoneShopInterface.Listing> OnlineShopItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x001AAD94 File Offset: 0x001A8F94
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x0002B4AE File Offset: 0x000296AE
		public unsafe string SupplierRecommendMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x001AADBC File Offset: 0x001A8FBC
		// (set) Token: 0x06005C0D RID: 23565 RVA: 0x0002B4CD File Offset: 0x000296CD
		public unsafe string SupplierUnlockHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x001AADE4 File Offset: 0x001A8FE4
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x0002B4EC File Offset: 0x000296EC
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x001AAE14 File Offset: 0x001A9014
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x0002B50B File Offset: 0x0002970B
		public unsafe SupplierStash Stash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierStash>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x001AAE44 File Offset: 0x001A9044
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x0002B52A File Offset: 0x0002972A
		public unsafe UnityEvent onDeaddropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x001AAE74 File Offset: 0x001A9074
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x0002B549 File Offset: 0x00029749
		public unsafe int minsSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x001AAE9C File Offset: 0x001A909C
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x0002B564 File Offset: 0x00029764
		public unsafe int minsSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x001AAEC4 File Offset: 0x001A90C4
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x0002B57F File Offset: 0x0002977F
		public unsafe SupplierLocation currentLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x001AAEF4 File Offset: 0x001A90F4
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x0002B59E File Offset: 0x0002979E
		public unsafe DialogueController dialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x001AAF24 File Offset: 0x001A9124
		// (set) Token: 0x06005C1D RID: 23581 RVA: 0x0002B5BD File Offset: 0x000297BD
		public unsafe DialogueController.GreetingOverride meetingGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x001AAF54 File Offset: 0x001A9154
		// (set) Token: 0x06005C1F RID: 23583 RVA: 0x0002B5DC File Offset: 0x000297DC
		public unsafe DialogueController.DialogueChoice meetingChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x001AAF84 File Offset: 0x001A9184
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x0002B5FB File Offset: 0x000297FB
		public unsafe float debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x001AAFAC File Offset: 0x001A91AC
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x0002B616 File Offset: 0x00029816
		public unsafe bool deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing)) = value;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x001AAFD4 File Offset: 0x001A91D4
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x0002B631 File Offset: 0x00029831
		public unsafe int _minsUntilDeaddropReady_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x001AAFFC File Offset: 0x001A91FC
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x0002B64C File Offset: 0x0002984C
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x001AB02C File Offset: 0x001A922C
		// (set) Token: 0x06005C29 RID: 23593 RVA: 0x0002B66B File Offset: 0x0002986B
		public unsafe int minsSinceDeaddropOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder)) = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x001AB054 File Offset: 0x001A9254
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x0002B686 File Offset: 0x00029886
		public unsafe bool repaymentReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent)) = value;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x001AB07C File Offset: 0x001A927C
		// (set) Token: 0x06005C2D RID: 23597 RVA: 0x0002B6A1 File Offset: 0x000298A1
		public unsafe SyncVar<float> syncVar___debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06005C2E RID: 23598 RVA: 0x001AB0AC File Offset: 0x001A92AC
		// (set) Token: 0x06005C2F RID: 23599 RVA: 0x0002B6C0 File Offset: 0x000298C0
		public unsafe SyncVar<bool> syncVar___deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x001AB0DC File Offset: 0x001A92DC
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x0002B6DF File Offset: 0x000298DF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x001AB104 File Offset: 0x001A9304
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x0002B6FA File Offset: 0x000298FA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003EB1 RID: 16049
		private static readonly IntPtr NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04003EB2 RID: 16050
		private static readonly IntPtr NativeFieldInfoPtr_MEETUP_DURATION_MINS;

		// Token: 0x04003EB3 RID: 16051
		private static readonly IntPtr NativeFieldInfoPtr_MEETING_COOLDOWN_MINS;

		// Token: 0x04003EB4 RID: 16052
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM;

		// Token: 0x04003EB5 RID: 16053
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_MAX_WAIT;

		// Token: 0x04003EB6 RID: 16054
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT;

		// Token: 0x04003EB7 RID: 16055
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04003EB8 RID: 16056
		private static readonly IntPtr NativeFieldInfoPtr_SupplierLabelColor;

		// Token: 0x04003EB9 RID: 16057
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04003EBA RID: 16058
		private static readonly IntPtr NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField;

		// Token: 0x04003EBB RID: 16059
		private static readonly IntPtr NativeFieldInfoPtr_MinOrderLimit;

		// Token: 0x04003EBC RID: 16060
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrderLimit;

		// Token: 0x04003EBD RID: 16061
		private static readonly IntPtr NativeFieldInfoPtr_OnlineShopItems;

		// Token: 0x04003EBE RID: 16062
		private static readonly IntPtr NativeFieldInfoPtr_SupplierRecommendMessage;

		// Token: 0x04003EBF RID: 16063
		private static readonly IntPtr NativeFieldInfoPtr_SupplierUnlockHint;

		// Token: 0x04003EC0 RID: 16064
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04003EC1 RID: 16065
		private static readonly IntPtr NativeFieldInfoPtr_Stash;

		// Token: 0x04003EC2 RID: 16066
		private static readonly IntPtr NativeFieldInfoPtr_onDeaddropReady;

		// Token: 0x04003EC3 RID: 16067
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceMeetingStart;

		// Token: 0x04003EC4 RID: 16068
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceLastMeetingEnd;

		// Token: 0x04003EC5 RID: 16069
		private static readonly IntPtr NativeFieldInfoPtr_currentLocation;

		// Token: 0x04003EC6 RID: 16070
		private static readonly IntPtr NativeFieldInfoPtr_dialogueController;

		// Token: 0x04003EC7 RID: 16071
		private static readonly IntPtr NativeFieldInfoPtr_meetingGreeting;

		// Token: 0x04003EC8 RID: 16072
		private static readonly IntPtr NativeFieldInfoPtr_meetingChoice;

		// Token: 0x04003EC9 RID: 16073
		private static readonly IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x04003ECA RID: 16074
		private static readonly IntPtr NativeFieldInfoPtr_deadDropPreparing;

		// Token: 0x04003ECB RID: 16075
		private static readonly IntPtr NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField;

		// Token: 0x04003ECC RID: 16076
		private static readonly IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x04003ECD RID: 16077
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceDeaddropOrder;

		// Token: 0x04003ECE RID: 16078
		private static readonly IntPtr NativeFieldInfoPtr_repaymentReminderSent;

		// Token: 0x04003ECF RID: 16079
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___debt;

		// Token: 0x04003ED0 RID: 16080
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___deadDropPreparing;

		// Token: 0x04003ED1 RID: 16081
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003ED2 RID: 16082
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003ED3 RID: 16083
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0;

		// Token: 0x04003ED4 RID: 16084
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0;

		// Token: 0x04003ED5 RID: 16085
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0;

		// Token: 0x04003ED6 RID: 16086
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04003ED7 RID: 16087
		private static readonly IntPtr NativeMethodInfoPtr_get_Debt_Public_get_Single_0;

		// Token: 0x04003ED8 RID: 16088
		private static readonly IntPtr NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0;

		// Token: 0x04003ED9 RID: 16089
		private static readonly IntPtr NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0;

		// Token: 0x04003EDA RID: 16090
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003EDB RID: 16091
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003EDC RID: 16092
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003EDD RID: 16093
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x04003EDE RID: 16094
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_0;

		// Token: 0x04003EDF RID: 16095
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04003EE0 RID: 16096
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Protected_Void_0;

		// Token: 0x04003EE1 RID: 16097
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x04003EE2 RID: 16098
		private static readonly IntPtr NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003EE3 RID: 16099
		private static readonly IntPtr NativeMethodInfoPtr_EndMeeting_Public_Void_0;

		// Token: 0x04003EE4 RID: 16100
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003EE5 RID: 16101
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04003EE6 RID: 16102
		private static readonly IntPtr NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0;

		// Token: 0x04003EE7 RID: 16103
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0;

		// Token: 0x04003EE8 RID: 16104
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1;

		// Token: 0x04003EE9 RID: 16105
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EEA RID: 16106
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0;

		// Token: 0x04003EEB RID: 16107
		private static readonly IntPtr NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003EEC RID: 16108
		private static readonly IntPtr NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0;

		// Token: 0x04003EED RID: 16109
		private static readonly IntPtr NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0;

		// Token: 0x04003EEE RID: 16110
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0;

		// Token: 0x04003EEF RID: 16111
		private static readonly IntPtr NativeMethodInfoPtr_SendDebtReminder_Private_Void_0;

		// Token: 0x04003EF0 RID: 16112
		private static readonly IntPtr NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly IntPtr NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly IntPtr NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0;

		// Token: 0x04003EF3 RID: 16115
		private static readonly IntPtr NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04003EF4 RID: 16116
		private static readonly IntPtr NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04003EF5 RID: 16117
		private static readonly IntPtr NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0;

		// Token: 0x04003EF6 RID: 16118
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003EF7 RID: 16119
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003EFB RID: 16123
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003EFC RID: 16124
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003EFD RID: 16125
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003EFE RID: 16126
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x04003EFF RID: 16127
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F00 RID: 16128
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003F01 RID: 16129
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003F02 RID: 16130
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F03 RID: 16131
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003F04 RID: 16132
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003F05 RID: 16133
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F06 RID: 16134
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F07 RID: 16135
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F08 RID: 16136
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F09 RID: 16137
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F0A RID: 16138
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F0B RID: 16139
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003F0C RID: 16140
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003F0D RID: 16141
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F0E RID: 16142
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04003F0F RID: 16143
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04003F10 RID: 16144
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F11 RID: 16145
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0;

		// Token: 0x04003F12 RID: 16146
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003F13 RID: 16147
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003F14 RID: 16148
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0;

		// Token: 0x04003F15 RID: 16149
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003F16 RID: 16150
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009EB RID: 2539
		[OriginalName("Assembly-CSharp.dll", "", "ESupplierStatus")]
		public enum ESupplierStatus
		{
			// Token: 0x04008AD3 RID: 35539
			Idle,
			// Token: 0x04008AD4 RID: 35540
			PreppingDeadDrop,
			// Token: 0x04008AD5 RID: 35541
			Meeting
		}

		// Token: 0x020009EC RID: 2540
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<EnableDeliveries>g__Wait|54_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CD85 RID: 52613 RVA: 0x00317DE4 File Offset: 0x00315FE4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<EnableDeliveries>g__Wait|54_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675054);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675055);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675056);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675057);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675058);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675059);
			}

			// Token: 0x0600CD86 RID: 52614 RVA: 0x00317EC4 File Offset: 0x003160C4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD87 RID: 52615 RVA: 0x00317F0C File Offset: 0x0031610C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD88 RID: 52616 RVA: 0x00317F40 File Offset: 0x00316140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193374, XrefRangeEnd = 193395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FFA RID: 16378
			// (get) Token: 0x0600CD89 RID: 52617 RVA: 0x00317F7C File Offset: 0x0031617C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CD8A RID: 52618 RVA: 0x00317FBC File Offset: 0x003161BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193395, XrefRangeEnd = 193400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0600CD8B RID: 52619 RVA: 0x00317FF0 File Offset: 0x003161F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CD8C RID: 52620 RVA: 0x00063F24 File Offset: 0x00062124
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF7 RID: 16375
			// (get) Token: 0x0600CD8D RID: 52621 RVA: 0x00318030 File Offset: 0x00316230
			// (set) Token: 0x0600CD8E RID: 52622 RVA: 0x00063F2D File Offset: 0x0006212D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FF8 RID: 16376
			// (get) Token: 0x0600CD8F RID: 52623 RVA: 0x00318058 File Offset: 0x00316258
			// (set) Token: 0x0600CD90 RID: 52624 RVA: 0x00063F48 File Offset: 0x00062148
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF9 RID: 16377
			// (get) Token: 0x0600CD91 RID: 52625 RVA: 0x00318088 File Offset: 0x00316288
			// (set) Token: 0x0600CD92 RID: 52626 RVA: 0x00063F67 File Offset: 0x00062167
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD6 RID: 35542
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AD7 RID: 35543
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AD8 RID: 35544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AD9 RID: 35545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008ADA RID: 35546
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ADB RID: 35547
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008ADC RID: 35548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ADD RID: 35549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ADE RID: 35550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009ED RID: 2541
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD93 RID: 52627 RVA: 0x003180B8 File Offset: 0x003162B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr);
				Supplier.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9");
				Supplier.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__54_1");
				Supplier.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__58_0");
				Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675061);
				Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675062);
				Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675063);
			}

			// Token: 0x0600CD94 RID: 52628 RVA: 0x0031815C File Offset: 0x0031635C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD95 RID: 52629 RVA: 0x00318198 File Offset: 0x00316398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193400, XrefRangeEnd = 193403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnableDeliveries_b__54_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD96 RID: 52630 RVA: 0x003181D4 File Offset: 0x003163D4
			[CallerCount(0)]
			public unsafe int _DeaddropConfirmed_b__58_0(PhoneShopInterface.CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD97 RID: 52631 RVA: 0x00063F86 File Offset: 0x00062186
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0600CD98 RID: 52632 RVA: 0x00318224 File Offset: 0x00316424
			// (set) Token: 0x0600CD99 RID: 52633 RVA: 0x00063F8F File Offset: 0x0006218F
			public unsafe static Supplier.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFD RID: 16381
			// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x0031824C File Offset: 0x0031644C
			// (set) Token: 0x0600CD9B RID: 52635 RVA: 0x00063FA1 File Offset: 0x000621A1
			public unsafe static Func<bool> __9__54_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFE RID: 16382
			// (get) Token: 0x0600CD9C RID: 52636 RVA: 0x00318274 File Offset: 0x00316474
			// (set) Token: 0x0600CD9D RID: 52637 RVA: 0x00063FB3 File Offset: 0x000621B3
			public unsafe static Func<PhoneShopInterface.CartEntry, int> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PhoneShopInterface.CartEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ADF RID: 35551
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008AE0 RID: 35552
			private static readonly IntPtr NativeFieldInfoPtr___9__54_1;

			// Token: 0x04008AE1 RID: 35553
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04008AE2 RID: 35554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AE3 RID: 35555
			private static readonly IntPtr NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0;

			// Token: 0x04008AE4 RID: 35556
			private static readonly IntPtr NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0;
		}

		// Token: 0x020009EE RID: 2542
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD9E RID: 52638 RVA: 0x0031829C File Offset: 0x0031649C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr);
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "orderCompleteDialogue");
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675064);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675065);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675066);
			}

			// Token: 0x0600CD9F RID: 52639 RVA: 0x0031832C File Offset: 0x0031652C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDA0 RID: 52640 RVA: 0x00318368 File Offset: 0x00316568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193403, XrefRangeEnd = 193404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDA1 RID: 52641 RVA: 0x0031839C File Offset: 0x0031659C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193404, XrefRangeEnd = 193405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDA2 RID: 52642 RVA: 0x00063FC5 File Offset: 0x000621C5
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFF RID: 16383
			// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x003183D0 File Offset: 0x003165D0
			// (set) Token: 0x0600CDA4 RID: 52644 RVA: 0x00063FCE File Offset: 0x000621CE
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004000 RID: 16384
			// (get) Token: 0x0600CDA5 RID: 52645 RVA: 0x00318400 File Offset: 0x00316600
			// (set) Token: 0x0600CDA6 RID: 52646 RVA: 0x00063FED File Offset: 0x000621ED
			public unsafe string orderCompleteDialogue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008AE5 RID: 35557
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AE6 RID: 35558
			private static readonly IntPtr NativeFieldInfoPtr_orderCompleteDialogue;

			// Token: 0x04008AE7 RID: 35559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AE8 RID: 35560
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008AE9 RID: 35561
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}
	}
}
