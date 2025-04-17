using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D7 RID: 727
	public class NPCInventory : NetworkBehaviour
	{
		// Token: 0x0600346F RID: 13423 RVA: 0x00118770 File Offset: 0x00116970
		// Note: this type is marked as 'beforefieldinit'.
		static NPCInventory()
		{
			Il2CppClassPointerStore<NPCInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr);
			NPCInventory.NativeFieldInfoPtr_PickpocketIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "PickpocketIntObj");
			NPCInventory.NativeFieldInfoPtr_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "COOLDOWN");
			NPCInventory.NativeFieldInfoPtr_SlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "SlotCount");
			NPCInventory.NativeFieldInfoPtr_CanBePickpocketed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "CanBePickpocketed");
			NPCInventory.NativeFieldInfoPtr_ClearInventoryEachNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "ClearInventoryEachNight");
			NPCInventory.NativeFieldInfoPtr_TestItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "TestItems");
			NPCInventory.NativeFieldInfoPtr_RandomCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomCash");
			NPCInventory.NativeFieldInfoPtr_RandomCashMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomCashMin");
			NPCInventory.NativeFieldInfoPtr_RandomCashMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomCashMax");
			NPCInventory.NativeFieldInfoPtr_RandomItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomItems");
			NPCInventory.NativeFieldInfoPtr_RandomItemDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomItemDefinitions");
			NPCInventory.NativeFieldInfoPtr_RandomItemMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomItemMin");
			NPCInventory.NativeFieldInfoPtr_RandomItemMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "RandomItemMax");
			NPCInventory.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "npc");
			NPCInventory.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "<ItemSlots>k__BackingField");
			NPCInventory.NativeFieldInfoPtr_onContentsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "onContentsChanged");
			NPCInventory.NativeFieldInfoPtr_timeOnLastExpire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "timeOnLastExpire");
			NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted");
			NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCInventoryAssembly-CSharp.dll_Excuted");
			NPCInventory.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669212);
			NPCInventory.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669213);
			NPCInventory.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669214);
			NPCInventory.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669215);
			NPCInventory.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669216);
			NPCInventory.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669217);
			NPCInventory.NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669218);
			NPCInventory.NativeMethodInfoPtr_GetItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669219);
			NPCInventory.NativeMethodInfoPtr__GetItemAmount_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669220);
			NPCInventory.NativeMethodInfoPtr_GetIdenticalItemAmount_Public_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669221);
			NPCInventory.NativeMethodInfoPtr_GetMaxItemCount_Public_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669222);
			NPCInventory.NativeMethodInfoPtr_CanItemFit_Public_Boolean_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669223);
			NPCInventory.NativeMethodInfoPtr_HowManyCanFit_Public_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669224);
			NPCInventory.NativeMethodInfoPtr_InsertItem_Public_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669225);
			NPCInventory.NativeMethodInfoPtr_GetFirstItem_Public_ItemInstance_String_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669226);
			NPCInventory.NativeMethodInfoPtr_GetFirstIdenticalItem_Public_ItemInstance_ItemInstance_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669227);
			NPCInventory.NativeMethodInfoPtr_InventoryContentsChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669228);
			NPCInventory.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669229);
			NPCInventory.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669230);
			NPCInventory.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669231);
			NPCInventory.NativeMethodInfoPtr_StartPickpocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669232);
			NPCInventory.NativeMethodInfoPtr_ExpirePickpocket_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669233);
			NPCInventory.NativeMethodInfoPtr_CanPickpocket_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669234);
			NPCInventory.NativeMethodInfoPtr_PrintInventoryContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669235);
			NPCInventory.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669236);
			NPCInventory.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669237);
			NPCInventory.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669238);
			NPCInventory.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669239);
			NPCInventory.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669240);
			NPCInventory.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669241);
			NPCInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669242);
			NPCInventory.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669243);
			NPCInventory.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669244);
			NPCInventory.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669245);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669246);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669247);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669248);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669249);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669250);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669251);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669252);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669253);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669254);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669255);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669256);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669257);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669258);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669259);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669260);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669261);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669262);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669263);
			NPCInventory.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669264);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669265);
			NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669266);
			NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669267);
			NPCInventory.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, 100669268);
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00118D90 File Offset: 0x00116F90
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x00118DD0 File Offset: 0x00116FD0
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00118E14 File Offset: 0x00117014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135573, XrefRangeEnd = 135574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00118E50 File Offset: 0x00117050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135574, XrefRangeEnd = 135591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00118E8C File Offset: 0x0011708C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135591, XrefRangeEnd = 135596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00118EDC File Offset: 0x001170DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135596, XrefRangeEnd = 135608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00118F10 File Offset: 0x00117110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135608, XrefRangeEnd = 135640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00118F4C File Offset: 0x0011714C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135640, XrefRangeEnd = 135643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00118F88 File Offset: 0x00117188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135646, RefRangeEnd = 135648, XrefRangeStart = 135643, XrefRangeEnd = 135646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetItemAmount(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr__GetItemAmount_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00118FD8 File Offset: 0x001171D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135659, RefRangeEnd = 135661, XrefRangeStart = 135648, XrefRangeEnd = 135659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIdenticalItemAmount(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetIdenticalItemAmount_Public_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00119028 File Offset: 0x00117228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135670, RefRangeEnd = 135671, XrefRangeStart = 135661, XrefRangeEnd = 135670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMaxItemCount(Il2CppStringArray ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetMaxItemCount_Public_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00119078 File Offset: 0x00117278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135672, RefRangeEnd = 135674, XrefRangeStart = 135671, XrefRangeEnd = 135672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_CanItemFit_Public_Boolean_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x001190D4 File Offset: 0x001172D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135691, RefRangeEnd = 135693, XrefRangeStart = 135674, XrefRangeEnd = 135691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int HowManyCanFit(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_HowManyCanFit_Public_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00119124 File Offset: 0x00117324
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 135723, RefRangeEnd = 135736, XrefRangeStart = 135693, XrefRangeEnd = 135723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertItem(ItemInstance item, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_InsertItem_Public_Void_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00119174 File Offset: 0x00117374
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135748, RefRangeEnd = 135752, XrefRangeStart = 135736, XrefRangeEnd = 135748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetFirstItem(string id, NPCInventory.ItemFilter filter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetFirstItem_Public_ItemInstance_String_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x001191D8 File Offset: 0x001173D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135763, RefRangeEnd = 135765, XrefRangeStart = 135752, XrefRangeEnd = 135763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetFirstIdenticalItem(ItemInstance item, NPCInventory.ItemFilter filter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetFirstIdenticalItem_Public_ItemInstance_ItemInstance_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x0011923C File Offset: 0x0011743C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135765, XrefRangeEnd = 135766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InventoryContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_InventoryContentsChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00119278 File Offset: 0x00117478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135773, RefRangeEnd = 135775, XrefRangeStart = 135766, XrefRangeEnd = 135773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetTotalItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x001192B4 File Offset: 0x001174B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135775, XrefRangeEnd = 135777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x001192E8 File Offset: 0x001174E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135777, XrefRangeEnd = 135783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x0011931C File Offset: 0x0011751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135783, XrefRangeEnd = 135789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPickpocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_StartPickpocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00119350 File Offset: 0x00117550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135790, RefRangeEnd = 135791, XrefRangeStart = 135789, XrefRangeEnd = 135790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpirePickpocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_ExpirePickpocket_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00119384 File Offset: 0x00117584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135803, RefRangeEnd = 135805, XrefRangeStart = 135791, XrefRangeEnd = 135803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPickpocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_CanPickpocket_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x001193C0 File Offset: 0x001175C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135805, XrefRangeEnd = 135838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintInventoryContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_PrintInventoryContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x001193F4 File Offset: 0x001175F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135838, XrefRangeEnd = 135865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00119458 File Offset: 0x00117658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 135890, RefRangeEnd = 135893, XrefRangeStart = 135865, XrefRangeEnd = 135890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x001194BC File Offset: 0x001176BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135893, XrefRangeEnd = 135918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00119508 File Offset: 0x00117708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 135946, RefRangeEnd = 135949, XrefRangeStart = 135918, XrefRangeEnd = 135946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00119554 File Offset: 0x00117754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135949, XrefRangeEnd = 135978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x001195D8 File Offset: 0x001177D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136028, RefRangeEnd = 136031, XrefRangeStart = 135978, XrefRangeEnd = 136028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x0011965C File Offset: 0x0011785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136031, XrefRangeEnd = 136039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCInventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00119698 File Offset: 0x00117898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136039, XrefRangeEnd = 136089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x001196D4 File Offset: 0x001178D4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00119710 File Offset: 0x00117910
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0011974C File Offset: 0x0011794C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136089, XrefRangeEnd = 136102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x001197B0 File Offset: 0x001179B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136102, XrefRangeEnd = 136106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00119814 File Offset: 0x00117A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136106, XrefRangeEnd = 136114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00119878 File Offset: 0x00117A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136114, XrefRangeEnd = 136135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x001198DC File Offset: 0x00117ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136135, XrefRangeEnd = 136141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00119940 File Offset: 0x00117B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136141, XrefRangeEnd = 136149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00119990 File Offset: 0x00117B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136149, XrefRangeEnd = 136161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x001199F4 File Offset: 0x00117BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136161, XrefRangeEnd = 136170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00119A44 File Offset: 0x00117C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136170, XrefRangeEnd = 136192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00119A90 File Offset: 0x00117C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136192, XrefRangeEnd = 136193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00119ADC File Offset: 0x00117CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136193, XrefRangeEnd = 136200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00119B40 File Offset: 0x00117D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136200, XrefRangeEnd = 136222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00119B8C File Offset: 0x00117D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136227, RefRangeEnd = 136228, XrefRangeStart = 136222, XrefRangeEnd = 136227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00119BD8 File Offset: 0x00117DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136228, XrefRangeEnd = 136235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00119C28 File Offset: 0x00117E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136235, XrefRangeEnd = 136250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00119CAC File Offset: 0x00117EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136250, XrefRangeEnd = 136254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00119D30 File Offset: 0x00117F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136254, XrefRangeEnd = 136263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00119D94 File Offset: 0x00117F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136263, XrefRangeEnd = 136277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00119E18 File Offset: 0x00118018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136285, RefRangeEnd = 136288, XrefRangeStart = 136277, XrefRangeEnd = 136285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00119E9C File Offset: 0x0011809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136288, XrefRangeEnd = 136296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00119EEC File Offset: 0x001180EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136296, XrefRangeEnd = 136319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00119F70 File Offset: 0x00118170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136319, XrefRangeEnd = 136326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00119FC0 File Offset: 0x001181C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136367, RefRangeEnd = 136368, XrefRangeStart = 136326, XrefRangeEnd = 136367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCInventory.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x0001BAF5 File Offset: 0x00019CF5
		public NPCInventory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x00119FFC File Offset: 0x001181FC
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x0001BAFE File Offset: 0x00019CFE
		public unsafe InteractableObject PickpocketIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_PickpocketIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_PickpocketIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x0011A02C File Offset: 0x0011822C
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x0001BB1D File Offset: 0x00019D1D
		public unsafe static float COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCInventory.NativeFieldInfoPtr_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCInventory.NativeFieldInfoPtr_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x0011A048 File Offset: 0x00118248
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x0001BB2B File Offset: 0x00019D2B
		public unsafe int SlotCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_SlotCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_SlotCount)) = value;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x0011A070 File Offset: 0x00118270
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0001BB46 File Offset: 0x00019D46
		public unsafe bool CanBePickpocketed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_CanBePickpocketed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_CanBePickpocketed)) = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x0011A098 File Offset: 0x00118298
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0001BB61 File Offset: 0x00019D61
		public unsafe bool ClearInventoryEachNight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_ClearInventoryEachNight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_ClearInventoryEachNight)) = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x0011A0C0 File Offset: 0x001182C0
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x0001BB7C File Offset: 0x00019D7C
		public unsafe Il2CppReferenceArray<ItemDefinition> TestItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_TestItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_TestItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x0011A0F0 File Offset: 0x001182F0
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0001BB9B File Offset: 0x00019D9B
		public unsafe bool RandomCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCash)) = value;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x0011A118 File Offset: 0x00118318
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0001BBB6 File Offset: 0x00019DB6
		public unsafe int RandomCashMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCashMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCashMin)) = value;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x0011A140 File Offset: 0x00118340
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x0001BBD1 File Offset: 0x00019DD1
		public unsafe int RandomCashMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCashMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomCashMax)) = value;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0011A168 File Offset: 0x00118368
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x0001BBEC File Offset: 0x00019DEC
		public unsafe bool RandomItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItems)) = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x0011A190 File Offset: 0x00118390
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x0001BC07 File Offset: 0x00019E07
		public unsafe Il2CppReferenceArray<StorableItemDefinition> RandomItemDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorableItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x0011A1C0 File Offset: 0x001183C0
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x0001BC26 File Offset: 0x00019E26
		public unsafe int RandomItemMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemMin)) = value;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x0011A1E8 File Offset: 0x001183E8
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x0001BC41 File Offset: 0x00019E41
		public unsafe int RandomItemMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_RandomItemMax)) = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x0011A210 File Offset: 0x00118410
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x0001BC5C File Offset: 0x00019E5C
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x0011A240 File Offset: 0x00118440
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x0001BC7B File Offset: 0x00019E7B
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x0011A270 File Offset: 0x00118470
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x0001BC9A File Offset: 0x00019E9A
		public unsafe UnityEvent onContentsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_onContentsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_onContentsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x0011A2A0 File Offset: 0x001184A0
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		public unsafe float timeOnLastExpire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_timeOnLastExpire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_timeOnLastExpire)) = value;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x0011A2C8 File Offset: 0x001184C8
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x0011A2F0 File Offset: 0x001184F0
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x0001BCEF File Offset: 0x00019EEF
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCInventory.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeFieldInfoPtr_PickpocketIntObj;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeFieldInfoPtr_SlotCount;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeFieldInfoPtr_CanBePickpocketed;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeFieldInfoPtr_ClearInventoryEachNight;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeFieldInfoPtr_TestItems;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeFieldInfoPtr_RandomCash;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeFieldInfoPtr_RandomCashMin;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeFieldInfoPtr_RandomCashMax;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr_RandomItems;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr_RandomItemDefinitions;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeFieldInfoPtr_RandomItemMin;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeFieldInfoPtr_RandomItemMax;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeFieldInfoPtr_onContentsChanged;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastExpire;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_GetItemCount_Public_Int32_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr__GetItemAmount_Public_Int32_String_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_GetIdenticalItemAmount_Public_Int32_ItemInstance_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxItemCount_Public_Int32_Il2CppStringArray_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_CanItemFit_Public_Boolean_ItemInstance_Int32_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_HowManyCanFit_Public_Int32_ItemInstance_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Public_Void_ItemInstance_Boolean_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstItem_Public_ItemInstance_String_ItemFilter_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstIdenticalItem_Public_ItemInstance_ItemInstance_ItemFilter_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_InventoryContentsChanged_Protected_Virtual_New_Void_1;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_StartPickpocket_Private_Void_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_ExpirePickpocket_Public_Void_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_CanPickpocket_Private_Boolean_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_PrintInventoryContents_Public_Void_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200091C RID: 2332
		public sealed class ItemFilter : MulticastDelegate
		{
			// Token: 0x0600C636 RID: 50742 RVA: 0x003026B4 File Offset: 0x003008B4
			// Note: this type is marked as 'beforefieldinit'.
			static ItemFilter()
			{
				Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCInventory>.NativeClassPtr, "ItemFilter");
				NPCInventory.ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr, 100669269);
				NPCInventory.ItemFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr, 100669270);
				NPCInventory.ItemFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ItemInstance_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr, 100669271);
				NPCInventory.ItemFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr, 100669272);
			}

			// Token: 0x0600C637 RID: 50743 RVA: 0x00302728 File Offset: 0x00300928
			[CallerCount(480)]
			[CachedScanResults(RefRangeStart = 135093, RefRangeEnd = 135573, XrefRangeStart = 135084, XrefRangeEnd = 135093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemFilter(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCInventory.ItemFilter>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C638 RID: 50744 RVA: 0x00302784 File Offset: 0x00300984
			[CallerCount(0)]
			public unsafe bool Invoke(ItemInstance item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.ItemFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C639 RID: 50745 RVA: 0x003027D4 File Offset: 0x003009D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ItemInstance item, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.ItemFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ItemInstance_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C63A RID: 50746 RVA: 0x00302848 File Offset: 0x00300A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCInventory.ItemFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C63B RID: 50747 RVA: 0x000607CE File Offset: 0x0005E9CE
			public ItemFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C63C RID: 50748 RVA: 0x000607D7 File Offset: 0x0005E9D7
			public static implicit operator NPCInventory.ItemFilter(Func<ItemInstance, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<NPCInventory.ItemFilter>(A_0);
			}

			// Token: 0x0600C63D RID: 50749 RVA: 0x000607DF File Offset: 0x0005E9DF
			public static NPCInventory.ItemFilter operator +(NPCInventory.ItemFilter A_0, NPCInventory.ItemFilter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NPCInventory.ItemFilter>();
			}

			// Token: 0x0600C63E RID: 50750 RVA: 0x000607ED File Offset: 0x0005E9ED
			public static NPCInventory.ItemFilter operator -(NPCInventory.ItemFilter A_0, NPCInventory.ItemFilter A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NPCInventory.ItemFilter>();
				}
				return result;
			}

			// Token: 0x0400862E RID: 34350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400862F RID: 34351
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ItemInstance_0;

			// Token: 0x04008630 RID: 34352
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ItemInstance_AsyncCallback_Object_0;

			// Token: 0x04008631 RID: 34353
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}
	}
}
