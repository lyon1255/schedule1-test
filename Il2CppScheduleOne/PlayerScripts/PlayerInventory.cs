using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E6 RID: 998
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x060050D0 RID: 20688 RVA: 0x001810F4 File Offset: 0x0017F2F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInventory()
		{
			Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr);
			PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_DISPLAY_TIME");
			PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_FADE_TIME");
			PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "DISCARD_TIME");
			PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "INVENTORY_SLOT_COUNT");
			PlayerInventory.NativeFieldInfoPtr_giveStartupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "giveStartupItems");
			PlayerInventory.NativeFieldInfoPtr_startupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "startupItems");
			PlayerInventory.NativeFieldInfoPtr_equipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "equipContainer");
			PlayerInventory.NativeFieldInfoPtr_hotbarSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "hotbarSlots");
			PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashSlot>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashInstance>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_clipboardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "clipboardSlot");
			PlayerInventory.NativeFieldInfoPtr_slotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "slotUIs");
			PlayerInventory.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "discardSlot");
			PlayerInventory.NativeFieldInfoPtr_ItemVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariables");
			PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippedSlotIndex>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<HotbarEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippingEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<equippable>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onInventoryStateChanged");
			PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PriorEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PreviousEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onPreItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_onItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ManagementSlotEnabled");
			PlayerInventory.NativeFieldInfoPtr_currentEquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentEquipTime");
			PlayerInventory.NativeFieldInfoPtr_currentDiscardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentDiscardTime");
			PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673440);
			PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673441);
			PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673442);
			PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673443);
			PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673444);
			PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673445);
			PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673446);
			PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673447);
			PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673448);
			PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673449);
			PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673450);
			PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673451);
			PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673452);
			PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673453);
			PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673454);
			PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673455);
			PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673456);
			PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673457);
			PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673458);
			PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673459);
			PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673460);
			PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673461);
			PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673462);
			PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673463);
			PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673464);
			PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673465);
			PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673466);
			PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673467);
			PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673468);
			PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673469);
			PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673470);
			PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673471);
			PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673472);
			PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673473);
			PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673474);
			PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673475);
			PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673476);
			PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673477);
			PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673478);
			PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673479);
			PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673480);
			PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673481);
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060050D1 RID: 20689 RVA: 0x00181674 File Offset: 0x0017F874
		public unsafe int TOTAL_SLOT_COUNT
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x001816B0 File Offset: 0x0017F8B0
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x001816F0 File Offset: 0x0017F8F0
		public unsafe CashSlot cashSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060050D4 RID: 20692 RVA: 0x00181734 File Offset: 0x0017F934
		// (set) Token: 0x060050D5 RID: 20693 RVA: 0x00181774 File Offset: 0x0017F974
		public unsafe CashInstance cashInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x001817B8 File Offset: 0x0017F9B8
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x001817F4 File Offset: 0x0017F9F4
		public unsafe int EquippedSlotIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55715, RefRangeEnd = 55716, XrefRangeStart = 55715, XrefRangeEnd = 55716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x00181834 File Offset: 0x0017FA34
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x00181870 File Offset: 0x0017FA70
		public unsafe bool HotbarEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x001818B0 File Offset: 0x0017FAB0
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x001818EC File Offset: 0x0017FAEC
		public unsafe bool EquippingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x0018192C File Offset: 0x0017FB2C
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x0018196C File Offset: 0x0017FB6C
		public unsafe Equippable equippable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x001819B0 File Offset: 0x0017FBB0
		public unsafe HotbarSlot equippedSlot
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 175289, RefRangeEnd = 175304, XrefRangeStart = 175288, XrefRangeEnd = 175289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x060050DF RID: 20703 RVA: 0x001819F0 File Offset: 0x0017FBF0
		public unsafe bool isAnythingEquipped
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 175306, RefRangeEnd = 175314, XrefRangeStart = 175304, XrefRangeEnd = 175306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00181A2C File Offset: 0x0017FC2C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 175316, RefRangeEnd = 175335, XrefRangeStart = 175314, XrefRangeEnd = 175316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot IndexAllSlots(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00181A78 File Offset: 0x0017FC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175335, XrefRangeEnd = 175339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00181AB4 File Offset: 0x0017FCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175465, RefRangeEnd = 175466, XrefRangeStart = 175339, XrefRangeEnd = 175465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInventoryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x00181AE8 File Offset: 0x0017FCE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175547, RefRangeEnd = 175550, XrefRangeStart = 175466, XrefRangeEnd = 175547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00181B1C File Offset: 0x0017FD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175550, XrefRangeEnd = 175615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00181B58 File Offset: 0x0017FD58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175638, RefRangeEnd = 175639, XrefRangeStart = 175615, XrefRangeEnd = 175638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveStartupItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00181B8C File Offset: 0x0017FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175639, XrefRangeEnd = 175686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00181BC8 File Offset: 0x0017FDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175729, RefRangeEnd = 175730, XrefRangeStart = 175686, XrefRangeEnd = 175729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHotbarSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00181BFC File Offset: 0x0017FDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175730, XrefRangeEnd = 175731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip(HotbarSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00181C40 File Offset: 0x0017FE40
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 175739, RefRangeEnd = 175820, XrefRangeStart = 175731, XrefRangeEnd = 175739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00181C80 File Offset: 0x0017FE80
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 175844, RefRangeEnd = 175891, XrefRangeStart = 175820, XrefRangeEnd = 175844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00181CC0 File Offset: 0x0017FEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175891, XrefRangeEnd = 175893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardAcquiredVarChange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00181D00 File Offset: 0x0017FF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagementClipboardEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00181D40 File Offset: 0x0017FF40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175913, RefRangeEnd = 175915, XrefRangeStart = 175893, XrefRangeEnd = 175913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewmodelVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00181D80 File Offset: 0x0017FF80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175927, RefRangeEnd = 175930, XrefRangeStart = 175915, XrefRangeEnd = 175927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00181DDC File Offset: 0x0017FFDC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 175963, RefRangeEnd = 175979, XrefRangeStart = 175930, XrefRangeEnd = 175963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00181E20 File Offset: 0x00180020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175979, XrefRangeEnd = 175992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAmountOfItem(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00181E70 File Offset: 0x00180070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176021, RefRangeEnd = 176024, XrefRangeStart = 175992, XrefRangeEnd = 176021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00181EC0 File Offset: 0x001800C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176031, RefRangeEnd = 176032, XrefRangeStart = 176024, XrefRangeEnd = 176031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00181EF4 File Offset: 0x001800F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176032, XrefRangeEnd = 176053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00181F34 File Offset: 0x00180134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176053, XrefRangeEnd = 176065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRandomItemsFromInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x00181F68 File Offset: 0x00180168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176071, RefRangeEnd = 176075, XrefRangeStart = 176065, XrefRangeEnd = 176071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable(Equippable eq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00181FAC File Offset: 0x001801AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176076, RefRangeEnd = 176077, XrefRangeStart = 176075, XrefRangeEnd = 176076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00181FE0 File Offset: 0x001801E0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 176095, RefRangeEnd = 176112, XrefRangeStart = 176077, XrefRangeEnd = 176095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllInventorySlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x00182020 File Offset: 0x00180220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176203, RefRangeEnd = 176205, XrefRangeStart = 176112, XrefRangeEnd = 176203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInventoryVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00182054 File Offset: 0x00180254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176205, XrefRangeEnd = 176236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerInventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00182090 File Offset: 0x00180290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176236, XrefRangeEnd = 176243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__56_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x000266A3 File Offset: 0x000248A3
		public PlayerInventory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x001820C4 File Offset: 0x001802C4
		// (set) Token: 0x060050FD RID: 20733 RVA: 0x000266AC File Offset: 0x000248AC
		public unsafe static float LABEL_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x001820E0 File Offset: 0x001802E0
		// (set) Token: 0x060050FF RID: 20735 RVA: 0x000266BA File Offset: 0x000248BA
		public unsafe static float LABEL_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x001820FC File Offset: 0x001802FC
		// (set) Token: 0x06005101 RID: 20737 RVA: 0x000266C8 File Offset: 0x000248C8
		public unsafe static float DISCARD_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x00182118 File Offset: 0x00180318
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x000266D6 File Offset: 0x000248D6
		public unsafe static int INVENTORY_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x00182134 File Offset: 0x00180334
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x000266E4 File Offset: 0x000248E4
		public unsafe bool giveStartupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems)) = value;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x0018215C File Offset: 0x0018035C
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x000266FF File Offset: 0x000248FF
		public unsafe List<PlayerInventory.ItemAmount> startupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemAmount>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x0018218C File Offset: 0x0018038C
		// (set) Token: 0x06005109 RID: 20745 RVA: 0x0002671E File Offset: 0x0002491E
		public unsafe Transform equipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x001821BC File Offset: 0x001803BC
		// (set) Token: 0x0600510B RID: 20747 RVA: 0x0002673D File Offset: 0x0002493D
		public unsafe List<HotbarSlot> hotbarSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HotbarSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x001821EC File Offset: 0x001803EC
		// (set) Token: 0x0600510D RID: 20749 RVA: 0x0002675C File Offset: 0x0002495C
		public unsafe CashSlot _cashSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x0018221C File Offset: 0x0018041C
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x0002677B File Offset: 0x0002497B
		public unsafe CashInstance _cashInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x0018224C File Offset: 0x0018044C
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x0002679A File Offset: 0x0002499A
		public unsafe ClipboardSlot clipboardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x0018227C File Offset: 0x0018047C
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x000267B9 File Offset: 0x000249B9
		public unsafe List<ItemSlotUI> slotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x001822AC File Offset: 0x001804AC
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x000267D8 File Offset: 0x000249D8
		public unsafe ItemSlot discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x001822DC File Offset: 0x001804DC
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x000267F7 File Offset: 0x000249F7
		public unsafe List<PlayerInventory.ItemVariable> ItemVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x0018230C File Offset: 0x0018050C
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x00026816 File Offset: 0x00024A16
		public unsafe int _EquippedSlotIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x00182334 File Offset: 0x00180534
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x00026831 File Offset: 0x00024A31
		public unsafe bool _HotbarEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x0018235C File Offset: 0x0018055C
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x0002684C File Offset: 0x00024A4C
		public unsafe bool _EquippingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x00182384 File Offset: 0x00180584
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x00026867 File Offset: 0x00024A67
		public unsafe Equippable _equippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x001823B4 File Offset: 0x001805B4
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x00026886 File Offset: 0x00024A86
		public unsafe Action<bool> onInventoryStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x001823E4 File Offset: 0x001805E4
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x000268A5 File Offset: 0x00024AA5
		public unsafe int PriorEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x0018240C File Offset: 0x0018060C
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x000268C0 File Offset: 0x00024AC0
		public unsafe int PreviousEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00182434 File Offset: 0x00180634
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x000268DB File Offset: 0x00024ADB
		public unsafe UnityEvent onPreItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00182464 File Offset: 0x00180664
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x000268FA File Offset: 0x00024AFA
		public unsafe UnityEvent onItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x00182494 File Offset: 0x00180694
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x00026919 File Offset: 0x00024B19
		public unsafe bool ManagementSlotEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled)) = value;
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x001824BC File Offset: 0x001806BC
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00026934 File Offset: 0x00024B34
		public unsafe float currentEquipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime)) = value;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x001824E4 File Offset: 0x001806E4
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x0002694F File Offset: 0x00024B4F
		public unsafe float currentDiscardTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime)) = value;
			}
		}

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeFieldInfoPtr_LABEL_DISPLAY_TIME;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeFieldInfoPtr_LABEL_FADE_TIME;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeFieldInfoPtr_DISCARD_TIME;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeFieldInfoPtr_INVENTORY_SLOT_COUNT;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeFieldInfoPtr_giveStartupItems;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeFieldInfoPtr_startupItems;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeFieldInfoPtr_equipContainer;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeFieldInfoPtr_hotbarSlots;

		// Token: 0x040036E0 RID: 14048
		private static readonly IntPtr NativeFieldInfoPtr__cashSlot_k__BackingField;

		// Token: 0x040036E1 RID: 14049
		private static readonly IntPtr NativeFieldInfoPtr__cashInstance_k__BackingField;

		// Token: 0x040036E2 RID: 14050
		private static readonly IntPtr NativeFieldInfoPtr_clipboardSlot;

		// Token: 0x040036E3 RID: 14051
		private static readonly IntPtr NativeFieldInfoPtr_slotUIs;

		// Token: 0x040036E4 RID: 14052
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x040036E5 RID: 14053
		private static readonly IntPtr NativeFieldInfoPtr_ItemVariables;

		// Token: 0x040036E6 RID: 14054
		private static readonly IntPtr NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField;

		// Token: 0x040036E7 RID: 14055
		private static readonly IntPtr NativeFieldInfoPtr__HotbarEnabled_k__BackingField;

		// Token: 0x040036E8 RID: 14056
		private static readonly IntPtr NativeFieldInfoPtr__EquippingEnabled_k__BackingField;

		// Token: 0x040036E9 RID: 14057
		private static readonly IntPtr NativeFieldInfoPtr__equippable_k__BackingField;

		// Token: 0x040036EA RID: 14058
		private static readonly IntPtr NativeFieldInfoPtr_onInventoryStateChanged;

		// Token: 0x040036EB RID: 14059
		private static readonly IntPtr NativeFieldInfoPtr_PriorEquippedSlotIndex;

		// Token: 0x040036EC RID: 14060
		private static readonly IntPtr NativeFieldInfoPtr_PreviousEquippedSlotIndex;

		// Token: 0x040036ED RID: 14061
		private static readonly IntPtr NativeFieldInfoPtr_onPreItemEquipped;

		// Token: 0x040036EE RID: 14062
		private static readonly IntPtr NativeFieldInfoPtr_onItemEquipped;

		// Token: 0x040036EF RID: 14063
		private static readonly IntPtr NativeFieldInfoPtr_ManagementSlotEnabled;

		// Token: 0x040036F0 RID: 14064
		private static readonly IntPtr NativeFieldInfoPtr_currentEquipTime;

		// Token: 0x040036F1 RID: 14065
		private static readonly IntPtr NativeFieldInfoPtr_currentDiscardTime;

		// Token: 0x040036F2 RID: 14066
		private static readonly IntPtr NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0;

		// Token: 0x040036F3 RID: 14067
		private static readonly IntPtr NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0;

		// Token: 0x040036F4 RID: 14068
		private static readonly IntPtr NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0;

		// Token: 0x040036F5 RID: 14069
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0;

		// Token: 0x040036F6 RID: 14070
		private static readonly IntPtr NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0;

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeMethodInfoPtr_RepositionUI_Private_Void_0;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeMethodInfoPtr_GiveStartupItems_Private_Void_0;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0;

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeMethodInfoPtr_ClearInventory_Public_Void_0;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0;

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeMethodInfoPtr_Reequip_Public_Void_0;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__56_1_Private_Void_0;

		// Token: 0x020009A0 RID: 2464
		[Serializable]
		public class ItemVariable : Il2CppSystem.Object
		{
			// Token: 0x0600CB2B RID: 52011 RVA: 0x003112C4 File Offset: 0x0030F4C4
			// Note: this type is marked as 'beforefieldinit'.
			static ItemVariable()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr);
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "Definition");
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "VariableName");
				PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, 100673482);
			}

			// Token: 0x0600CB2C RID: 52012 RVA: 0x0031132C File Offset: 0x0030F52C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemVariable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB2D RID: 52013 RVA: 0x00062CE9 File Offset: 0x00060EE9
			public ItemVariable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4D RID: 16205
			// (get) Token: 0x0600CB2E RID: 52014 RVA: 0x00311368 File Offset: 0x0030F568
			// (set) Token: 0x0600CB2F RID: 52015 RVA: 0x00062CF2 File Offset: 0x00060EF2
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F4E RID: 16206
			// (get) Token: 0x0600CB30 RID: 52016 RVA: 0x00311398 File Offset: 0x0030F598
			// (set) Token: 0x0600CB31 RID: 52017 RVA: 0x00062D11 File Offset: 0x00060F11
			public unsafe string VariableName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008962 RID: 35170
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008963 RID: 35171
			private static readonly IntPtr NativeFieldInfoPtr_VariableName;

			// Token: 0x04008964 RID: 35172
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A1 RID: 2465
		[Serializable]
		public class ItemAmount : Il2CppSystem.Object
		{
			// Token: 0x0600CB32 RID: 52018 RVA: 0x003113C0 File Offset: 0x0030F5C0
			// Note: this type is marked as 'beforefieldinit'.
			static ItemAmount()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemAmount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr);
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Definition");
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Amount");
				PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, 100673483);
			}

			// Token: 0x0600CB33 RID: 52019 RVA: 0x00311428 File Offset: 0x0030F628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175280, XrefRangeEnd = 175281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemAmount() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB34 RID: 52020 RVA: 0x00062D30 File Offset: 0x00060F30
			public ItemAmount(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4F RID: 16207
			// (get) Token: 0x0600CB35 RID: 52021 RVA: 0x00311464 File Offset: 0x0030F664
			// (set) Token: 0x0600CB36 RID: 52022 RVA: 0x00062D39 File Offset: 0x00060F39
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F50 RID: 16208
			// (get) Token: 0x0600CB37 RID: 52023 RVA: 0x00311494 File Offset: 0x0030F694
			// (set) Token: 0x0600CB38 RID: 52024 RVA: 0x00062D58 File Offset: 0x00060F58
			public unsafe int Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x04008965 RID: 35173
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008966 RID: 35174
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x04008967 RID: 35175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A2 RID: 2466
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerInventory+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB39 RID: 52025 RVA: 0x003114BC File Offset: 0x0030F6BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr);
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "index");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "slot");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673484);
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673485);
			}

			// Token: 0x0600CB3A RID: 52026 RVA: 0x0031154C File Offset: 0x0030F74C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB3B RID: 52027 RVA: 0x00311588 File Offset: 0x0030F788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175281, XrefRangeEnd = 175288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB3C RID: 52028 RVA: 0x00062D73 File Offset: 0x00060F73
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F51 RID: 16209
			// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x003115BC File Offset: 0x0030F7BC
			// (set) Token: 0x0600CB3E RID: 52030 RVA: 0x00062D7C File Offset: 0x00060F7C
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17003F52 RID: 16210
			// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x003115E4 File Offset: 0x0030F7E4
			// (set) Token: 0x0600CB40 RID: 52032 RVA: 0x00062D97 File Offset: 0x00060F97
			public unsafe HotbarSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F53 RID: 16211
			// (get) Token: 0x0600CB41 RID: 52033 RVA: 0x00311614 File Offset: 0x0030F814
			// (set) Token: 0x0600CB42 RID: 52034 RVA: 0x00062DB6 File Offset: 0x00060FB6
			public unsafe PlayerInventory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInventory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008968 RID: 35176
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008969 RID: 35177
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x0400896A RID: 35178
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400896B RID: 35179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400896C RID: 35180
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
