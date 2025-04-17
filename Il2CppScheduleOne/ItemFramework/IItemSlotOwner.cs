using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DE RID: 1502
	public class IItemSlotOwner : Il2CppObjectBase
	{
		// Token: 0x06008363 RID: 33635 RVA: 0x0022EBDC File Offset: 0x0022CDDC
		// Note: this type is marked as 'beforefieldinit'.
		static IItemSlotOwner()
		{
			Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IItemSlotOwner");
			IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679729);
			IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679730);
			IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679731);
			IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679732);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679733);
			IItemSlotOwner.NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679734);
			IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679735);
			IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100679736);
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x06008364 RID: 33636 RVA: 0x0022ECA4 File Offset: 0x0022CEA4
		// (set) Token: 0x06008365 RID: 33637 RVA: 0x0022ECF0 File Offset: 0x0022CEF0
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008366 RID: 33638 RVA: 0x0022ED40 File Offset: 0x0022CF40
		[CallerCount(0)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x0022EDB0 File Offset: 0x0022CFB0
		[CallerCount(0)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x0022EE08 File Offset: 0x0022D008
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008369 RID: 33641 RVA: 0x0022EE98 File Offset: 0x0022D098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247102, XrefRangeEnd = 247135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendItemsToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600836A RID: 33642 RVA: 0x0022EEE8 File Offset: 0x0022D0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247135, XrefRangeEnd = 247156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetTotalItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x0022EF30 File Offset: 0x0022D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247156, XrefRangeEnd = 247178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetItemCount(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0003E668 File Offset: 0x0003C868
		public IItemSlotOwner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400596A RID: 22890
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x0400596B RID: 22891
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400596C RID: 22892
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400596D RID: 22893
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400596E RID: 22894
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400596F RID: 22895
		private static readonly IntPtr NativeMethodInfoPtr_SendItemsToClient_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005970 RID: 22896
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0;

		// Token: 0x04005971 RID: 22897
		private static readonly IntPtr NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x02000AE6 RID: 2790
		[ObfuscatedName("ScheduleOne.ItemFramework.IItemSlotOwner+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D538 RID: 54584 RVA: 0x0032D478 File Offset: 0x0032B678
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr);
				IItemSlotOwner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9");
				IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9__7_0");
				IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100679738);
				IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100679739);
			}

			// Token: 0x0600D539 RID: 54585 RVA: 0x0032D4F4 File Offset: 0x0032B6F4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53A RID: 54586 RVA: 0x0032D530 File Offset: 0x0032B730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247100, XrefRangeEnd = 247102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTotalItemCount_b__7_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x00067BE5 File Offset: 0x00065DE5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004212 RID: 16914
			// (get) Token: 0x0600D53C RID: 54588 RVA: 0x0032D580 File Offset: 0x0032B780
			// (set) Token: 0x0600D53D RID: 54589 RVA: 0x00067BEE File Offset: 0x00065DEE
			public unsafe static IItemSlotOwner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004213 RID: 16915
			// (get) Token: 0x0600D53E RID: 54590 RVA: 0x0032D5A8 File Offset: 0x0032B7A8
			// (set) Token: 0x0600D53F RID: 54591 RVA: 0x00067C00 File Offset: 0x00065E00
			public unsafe static Func<ItemSlot, int> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F74 RID: 36724
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F75 RID: 36725
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04008F76 RID: 36726
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F77 RID: 36727
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalItemCount_b__7_0_Internal_Int32_ItemSlot_0;
		}
	}
}
