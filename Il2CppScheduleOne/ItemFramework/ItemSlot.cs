using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EA RID: 1514
	[Serializable]
	public class ItemSlot : Object
	{
		// Token: 0x06008430 RID: 33840 RVA: 0x00231A14 File Offset: 0x0022FC14
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlot()
		{
			Il2CppClassPointerStore<ItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr);
			ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ItemInstance>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SlotOwner>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onItemDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemDataChanged");
			ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemInstanceChanged");
			ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ActiveLock>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onLocked");
			ItemSlot.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onUnlocked");
			ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsRemovalLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsAddLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<Filters>k__BackingField");
			ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679839);
			ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679840);
			ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679841);
			ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679842);
			ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679843);
			ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679844);
			ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679845);
			ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679846);
			ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679847);
			ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679848);
			ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679849);
			ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679850);
			ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679851);
			ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679852);
			ItemSlot.NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679853);
			ItemSlot.NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679854);
			ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679855);
			ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679856);
			ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679857);
			ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679858);
			ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679859);
			ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679860);
			ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679861);
			ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679862);
			ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679863);
			ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679864);
			ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679865);
			ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679866);
			ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679867);
			ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679868);
			ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679869);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679870);
			ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679871);
			ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679872);
			ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679873);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100679874);
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x06008431 RID: 33841 RVA: 0x00231DDC File Offset: 0x0022FFDC
		// (set) Token: 0x06008432 RID: 33842 RVA: 0x00231E1C File Offset: 0x0023001C
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x06008433 RID: 33843 RVA: 0x00231E60 File Offset: 0x00230060
		// (set) Token: 0x06008434 RID: 33844 RVA: 0x00231EA0 File Offset: 0x002300A0
		public unsafe IItemSlotOwner SlotOwner
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x06008435 RID: 33845 RVA: 0x00231EE4 File Offset: 0x002300E4
		public unsafe int SlotIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248313, XrefRangeEnd = 248320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x06008436 RID: 33846 RVA: 0x00231F20 File Offset: 0x00230120
		public unsafe int Quantity
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 248320, RefRangeEnd = 248407, XrefRangeStart = 248320, XrefRangeEnd = 248320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x06008437 RID: 33847 RVA: 0x00231F5C File Offset: 0x0023015C
		public unsafe bool IsAtCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x06008438 RID: 33848 RVA: 0x00231F98 File Offset: 0x00230198
		public unsafe bool IsLocked
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 154940, RefRangeEnd = 154973, XrefRangeStart = 154940, XrefRangeEnd = 154973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x06008439 RID: 33849 RVA: 0x00231FD4 File Offset: 0x002301D4
		// (set) Token: 0x0600843A RID: 33850 RVA: 0x00232014 File Offset: 0x00230214
		public unsafe ItemSlotLock ActiveLock
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x00232058 File Offset: 0x00230258
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x00232094 File Offset: 0x00230294
		public unsafe bool IsRemovalLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x002320D4 File Offset: 0x002302D4
		// (set) Token: 0x0600843E RID: 33854 RVA: 0x00232110 File Offset: 0x00230310
		public unsafe bool IsAddLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 50966, RefRangeEnd = 50976, XrefRangeStart = 50966, XrefRangeEnd = 50976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600843F RID: 33855 RVA: 0x00232150 File Offset: 0x00230350
		// (set) Token: 0x06008440 RID: 33856 RVA: 0x00232190 File Offset: 0x00230390
		public unsafe List<ItemFilter> Filters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x002321D4 File Offset: 0x002303D4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 248417, RefRangeEnd = 248442, XrefRangeStart = 248407, XrefRangeEnd = 248417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotOwner(IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00232218 File Offset: 0x00230418
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248451, RefRangeEnd = 248456, XrefRangeStart = 248442, XrefRangeEnd = 248451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStoredInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x0023224C File Offset: 0x0023044C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248473, RefRangeEnd = 248474, XrefRangeStart = 248456, XrefRangeEnd = 248473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x002322A8 File Offset: 0x002304A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248474, XrefRangeEnd = 248482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x002322F8 File Offset: 0x002304F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248482, XrefRangeEnd = 248490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(ItemInstance item, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x00232354 File Offset: 0x00230554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248503, RefRangeEnd = 248504, XrefRangeStart = 248490, XrefRangeEnd = 248503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x002323A0 File Offset: 0x002305A0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 248521, RefRangeEnd = 248546, XrefRangeStart = 248504, XrefRangeEnd = 248521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int amount, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x002323EC File Offset: 0x002305EC
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 248564, RefRangeEnd = 248605, XrefRangeStart = 248546, XrefRangeEnd = 248564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x00232438 File Offset: 0x00230638
		[CallerCount(0)]
		public unsafe virtual void ItemDataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x00232474 File Offset: 0x00230674
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248605, RefRangeEnd = 248608, XrefRangeStart = 248605, XrefRangeEnd = 248605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItemInstanceRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x002324B0 File Offset: 0x002306B0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 248614, RefRangeEnd = 248633, XrefRangeStart = 248608, XrefRangeEnd = 248614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFilter(ItemFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x002324F4 File Offset: 0x002306F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 248655, RefRangeEnd = 248668, XrefRangeStart = 248633, XrefRangeEnd = 248655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x00232558 File Offset: 0x00230758
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 248679, RefRangeEnd = 248692, XrefRangeStart = 248668, XrefRangeEnd = 248679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLock(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x00232598 File Offset: 0x00230798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsRemovalLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x002325D8 File Offset: 0x002307D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 50966, RefRangeEnd = 50976, XrefRangeStart = 50966, XrefRangeEnd = 50976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAddLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x00232618 File Offset: 0x00230818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248692, XrefRangeEnd = 248703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008451 RID: 33873 RVA: 0x00232670 File Offset: 0x00230870
		[CallerCount(0)]
		public unsafe virtual int GetCapacityForItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x002326C8 File Offset: 0x002308C8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x00232710 File Offset: 0x00230910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248728, RefRangeEnd = 248729, XrefRangeStart = 248703, XrefRangeEnd = 248728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ItemSlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x00232764 File Offset: 0x00230964
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 248737, RefRangeEnd = 248757, XrefRangeStart = 248729, XrefRangeEnd = 248737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x0003EB1F File Offset: 0x0003CD1F
		public ItemSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x06008456 RID: 33878 RVA: 0x002327A0 File Offset: 0x002309A0
		// (set) Token: 0x06008457 RID: 33879 RVA: 0x0003EB28 File Offset: 0x0003CD28
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F1 RID: 10225
		// (get) Token: 0x06008458 RID: 33880 RVA: 0x002327D0 File Offset: 0x002309D0
		// (set) Token: 0x06008459 RID: 33881 RVA: 0x0003EB47 File Offset: 0x0003CD47
		public unsafe IItemSlotOwner _SlotOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F2 RID: 10226
		// (get) Token: 0x0600845A RID: 33882 RVA: 0x00232800 File Offset: 0x00230A00
		// (set) Token: 0x0600845B RID: 33883 RVA: 0x0003EB66 File Offset: 0x0003CD66
		public unsafe Action onItemDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600845C RID: 33884 RVA: 0x00232830 File Offset: 0x00230A30
		// (set) Token: 0x0600845D RID: 33885 RVA: 0x0003EB85 File Offset: 0x0003CD85
		public unsafe Action onItemInstanceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600845E RID: 33886 RVA: 0x00232860 File Offset: 0x00230A60
		// (set) Token: 0x0600845F RID: 33887 RVA: 0x0003EBA4 File Offset: 0x0003CDA4
		public unsafe ItemSlotLock _ActiveLock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x06008460 RID: 33888 RVA: 0x00232890 File Offset: 0x00230A90
		// (set) Token: 0x06008461 RID: 33889 RVA: 0x0003EBC3 File Offset: 0x0003CDC3
		public unsafe Action onLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06008462 RID: 33890 RVA: 0x002328C0 File Offset: 0x00230AC0
		// (set) Token: 0x06008463 RID: 33891 RVA: 0x0003EBE2 File Offset: 0x0003CDE2
		public unsafe Action onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x06008464 RID: 33892 RVA: 0x002328F0 File Offset: 0x00230AF0
		// (set) Token: 0x06008465 RID: 33893 RVA: 0x0003EC01 File Offset: 0x0003CE01
		public unsafe bool _IsRemovalLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x06008466 RID: 33894 RVA: 0x00232918 File Offset: 0x00230B18
		// (set) Token: 0x06008467 RID: 33895 RVA: 0x0003EC1C File Offset: 0x0003CE1C
		public unsafe bool _IsAddLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x06008468 RID: 33896 RVA: 0x00232940 File Offset: 0x00230B40
		// (set) Token: 0x06008469 RID: 33897 RVA: 0x0003EC37 File Offset: 0x0003CE37
		public unsafe List<ItemFilter> _Filters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__Filters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A03 RID: 23043
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x04005A04 RID: 23044
		private static readonly IntPtr NativeFieldInfoPtr__SlotOwner_k__BackingField;

		// Token: 0x04005A05 RID: 23045
		private static readonly IntPtr NativeFieldInfoPtr_onItemDataChanged;

		// Token: 0x04005A06 RID: 23046
		private static readonly IntPtr NativeFieldInfoPtr_onItemInstanceChanged;

		// Token: 0x04005A07 RID: 23047
		private static readonly IntPtr NativeFieldInfoPtr__ActiveLock_k__BackingField;

		// Token: 0x04005A08 RID: 23048
		private static readonly IntPtr NativeFieldInfoPtr_onLocked;

		// Token: 0x04005A09 RID: 23049
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04005A0A RID: 23050
		private static readonly IntPtr NativeFieldInfoPtr__IsRemovalLocked_k__BackingField;

		// Token: 0x04005A0B RID: 23051
		private static readonly IntPtr NativeFieldInfoPtr__IsAddLocked_k__BackingField;

		// Token: 0x04005A0C RID: 23052
		private static readonly IntPtr NativeFieldInfoPtr__Filters_k__BackingField;

		// Token: 0x04005A0D RID: 23053
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04005A0E RID: 23054
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x04005A0F RID: 23055
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0;

		// Token: 0x04005A10 RID: 23056
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0;

		// Token: 0x04005A11 RID: 23057
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0;

		// Token: 0x04005A12 RID: 23058
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04005A13 RID: 23059
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0;

		// Token: 0x04005A14 RID: 23060
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0;

		// Token: 0x04005A15 RID: 23061
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0;

		// Token: 0x04005A16 RID: 23062
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0;

		// Token: 0x04005A17 RID: 23063
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0;

		// Token: 0x04005A18 RID: 23064
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005A19 RID: 23065
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0;

		// Token: 0x04005A1A RID: 23066
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005A1B RID: 23067
		private static readonly IntPtr NativeMethodInfoPtr_get_Filters_Protected_get_List_1_ItemFilter_0;

		// Token: 0x04005A1C RID: 23068
		private static readonly IntPtr NativeMethodInfoPtr_set_Filters_Protected_set_Void_List_1_ItemFilter_0;

		// Token: 0x04005A1D RID: 23069
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0;

		// Token: 0x04005A1E RID: 23070
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0;

		// Token: 0x04005A1F RID: 23071
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005A20 RID: 23072
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005A21 RID: 23073
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005A22 RID: 23074
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005A23 RID: 23075
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005A24 RID: 23076
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005A25 RID: 23077
		private static readonly IntPtr NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0;

		// Token: 0x04005A26 RID: 23078
		private static readonly IntPtr NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04005A27 RID: 23079
		private static readonly IntPtr NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0;

		// Token: 0x04005A28 RID: 23080
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04005A29 RID: 23081
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0;

		// Token: 0x04005A2A RID: 23082
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0;

		// Token: 0x04005A2B RID: 23083
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0;

		// Token: 0x04005A2C RID: 23084
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005A2D RID: 23085
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_0;

		// Token: 0x04005A2E RID: 23086
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0;

		// Token: 0x04005A2F RID: 23087
		private static readonly IntPtr NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0;

		// Token: 0x04005A30 RID: 23088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
