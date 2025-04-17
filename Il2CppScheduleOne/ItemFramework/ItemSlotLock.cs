using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EB RID: 1515
	public class ItemSlotLock : Object
	{
		// Token: 0x0600846A RID: 33898 RVA: 0x00232970 File Offset: 0x00230B70
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotLock()
		{
			Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr);
			ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<Slot>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockOwner>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockReason>k__BackingField");
			ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679875);
			ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679876);
			ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679877);
			ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679878);
			ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679879);
			ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679880);
			ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100679881);
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600846B RID: 33899 RVA: 0x00232A68 File Offset: 0x00230C68
		// (set) Token: 0x0600846C RID: 33900 RVA: 0x00232AA8 File Offset: 0x00230CA8
		public unsafe ItemSlot Slot
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x00232AEC File Offset: 0x00230CEC
		// (set) Token: 0x0600846E RID: 33902 RVA: 0x00232B2C File Offset: 0x00230D2C
		public unsafe NetworkObject LockOwner
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x00232B70 File Offset: 0x00230D70
		// (set) Token: 0x06008470 RID: 33904 RVA: 0x00232BA8 File Offset: 0x00230DA8
		public unsafe string LockReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x00232BEC File Offset: 0x00230DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248757, XrefRangeEnd = 248765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x0003EC56 File Offset: 0x0003CE56
		public ItemSlotLock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x00232C5C File Offset: 0x00230E5C
		// (set) Token: 0x06008474 RID: 33908 RVA: 0x0003EC5F File Offset: 0x0003CE5F
		public unsafe ItemSlot _Slot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x00232C8C File Offset: 0x00230E8C
		// (set) Token: 0x06008476 RID: 33910 RVA: 0x0003EC7E File Offset: 0x0003CE7E
		public unsafe NetworkObject _LockOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06008477 RID: 33911 RVA: 0x00232CBC File Offset: 0x00230EBC
		// (set) Token: 0x06008478 RID: 33912 RVA: 0x0003EC9D File Offset: 0x0003CE9D
		public unsafe string _LockReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005A31 RID: 23089
		private static readonly IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

		// Token: 0x04005A32 RID: 23090
		private static readonly IntPtr NativeFieldInfoPtr__LockOwner_k__BackingField;

		// Token: 0x04005A33 RID: 23091
		private static readonly IntPtr NativeFieldInfoPtr__LockReason_k__BackingField;

		// Token: 0x04005A34 RID: 23092
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0;

		// Token: 0x04005A35 RID: 23093
		private static readonly IntPtr NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04005A36 RID: 23094
		private static readonly IntPtr NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0;

		// Token: 0x04005A37 RID: 23095
		private static readonly IntPtr NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0;

		// Token: 0x04005A38 RID: 23096
		private static readonly IntPtr NativeMethodInfoPtr_get_LockReason_Public_get_String_0;

		// Token: 0x04005A39 RID: 23097
		private static readonly IntPtr NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0;

		// Token: 0x04005A3A RID: 23098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0;
	}
}
