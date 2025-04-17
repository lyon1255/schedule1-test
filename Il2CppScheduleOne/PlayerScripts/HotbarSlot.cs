using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003DE RID: 990
	public class HotbarSlot : ItemSlot
	{
		// Token: 0x06004C95 RID: 19605 RVA: 0x0016FE1C File Offset: 0x0016E01C
		// Note: this type is marked as 'beforefieldinit'.
		static HotbarSlot()
		{
			Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "HotbarSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr);
			HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "<IsEquipped>k__BackingField");
			HotbarSlot.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "Equippable");
			HotbarSlot.NativeFieldInfoPtr_onEquipChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "onEquipChanged");
			HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672746);
			HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672747);
			HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672748);
			HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672749);
			HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672750);
			HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672751);
			HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672752);
			HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, 100672753);
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x0016FF28 File Offset: 0x0016E128
		// (set) Token: 0x06004C97 RID: 19607 RVA: 0x0016FF64 File Offset: 0x0016E164
		public unsafe bool IsEquipped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x0016FFA4 File Offset: 0x0016E1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165767, XrefRangeEnd = 165794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x00170000 File Offset: 0x0016E200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165794, XrefRangeEnd = 165801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x0017004C File Offset: 0x0016E24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165801, XrefRangeEnd = 165823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x00170088 File Offset: 0x0016E288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165823, XrefRangeEnd = 165828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x001700C4 File Offset: 0x0016E2C4
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HotbarSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x0017010C File Offset: 0x0016E30C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165829, RefRangeEnd = 165832, XrefRangeStart = 165828, XrefRangeEnd = 165829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00024D57 File Offset: 0x00022F57
		public HotbarSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00170148 File Offset: 0x0016E348
		// (set) Token: 0x06004CA0 RID: 19616 RVA: 0x00024D60 File Offset: 0x00022F60
		public unsafe bool _IsEquipped_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr__IsEquipped_k__BackingField)) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x00170170 File Offset: 0x0016E370
		// (set) Token: 0x06004CA2 RID: 19618 RVA: 0x00024D7B File Offset: 0x00022F7B
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x001701A0 File Offset: 0x0016E3A0
		// (set) Token: 0x06004CA4 RID: 19620 RVA: 0x00024D9A File Offset: 0x00022F9A
		public unsafe HotbarSlot.EquipEvent onEquipChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot.EquipEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HotbarSlot.NativeFieldInfoPtr_onEquipChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeFieldInfoPtr__IsEquipped_k__BackingField;

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeFieldInfoPtr_onEquipChanged;

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_get_Boolean_0;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEquipped_Protected_set_Void_Boolean_0;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_Void_ItemInstance_Boolean_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200098A RID: 2442
		public sealed class EquipEvent : MulticastDelegate
		{
			// Token: 0x0600CA50 RID: 51792 RVA: 0x0030ECC4 File Offset: 0x0030CEC4
			// Note: this type is marked as 'beforefieldinit'.
			static EquipEvent()
			{
				Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HotbarSlot>.NativeClassPtr, "EquipEvent");
				HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672754);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672755);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672756);
				HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr, 100672757);
			}

			// Token: 0x0600CA51 RID: 51793 RVA: 0x0030ED38 File Offset: 0x0030CF38
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 165720, RefRangeEnd = 165763, XrefRangeStart = 165717, XrefRangeEnd = 165720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EquipEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HotbarSlot.EquipEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA52 RID: 51794 RVA: 0x0030ED94 File Offset: 0x0030CF94
			[CallerCount(0)]
			public unsafe void Invoke(bool equipped)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA53 RID: 51795 RVA: 0x0030EDD4 File Offset: 0x0030CFD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165763, XrefRangeEnd = 165767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool equipped, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref equipped;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA54 RID: 51796 RVA: 0x0030EE44 File Offset: 0x0030D044
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HotbarSlot.EquipEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA55 RID: 51797 RVA: 0x000625C1 File Offset: 0x000607C1
			public EquipEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA56 RID: 51798 RVA: 0x000625CA File Offset: 0x000607CA
			public static implicit operator HotbarSlot.EquipEvent(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<HotbarSlot.EquipEvent>(A_0);
			}

			// Token: 0x0600CA57 RID: 51799 RVA: 0x000625D2 File Offset: 0x000607D2
			public static HotbarSlot.EquipEvent operator +(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<HotbarSlot.EquipEvent>();
			}

			// Token: 0x0600CA58 RID: 51800 RVA: 0x000625E0 File Offset: 0x000607E0
			public static HotbarSlot.EquipEvent operator -(HotbarSlot.EquipEvent A_0, HotbarSlot.EquipEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<HotbarSlot.EquipEvent>();
				}
				return result;
			}

			// Token: 0x040088DC RID: 35036
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088DD RID: 35037
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x040088DE RID: 35038
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x040088DF RID: 35039
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
