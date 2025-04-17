using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005CD RID: 1485
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x060082F0 RID: 33520 RVA: 0x0022D444 File Offset: 0x0022B644
		// Note: this type is marked as 'beforefieldinit'.
		static CashInstance()
		{
			Il2CppClassPointerStore<CashInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashInstance>.NativeClassPtr);
			CashInstance.NativeFieldInfoPtr_MAX_BALANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "MAX_BALANCE");
			CashInstance.NativeFieldInfoPtr__Balance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "<Balance>k__BackingField");
			CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679684);
			CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679685);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679686);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679687);
			CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679688);
			CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679689);
			CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679690);
			CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679691);
			CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100679692);
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x0022D550 File Offset: 0x0022B750
		// (set) Token: 0x060082F2 RID: 33522 RVA: 0x0022D58C File Offset: 0x0022B78C
		public unsafe float Balance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49120, RefRangeEnd = 49123, XrefRangeStart = 49120, XrefRangeEnd = 49123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x0022D5CC File Offset: 0x0022B7CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206615, RefRangeEnd = 206617, XrefRangeStart = 206615, XrefRangeEnd = 206617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x0022D608 File Offset: 0x0022B808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246888, RefRangeEnd = 246890, XrefRangeStart = 246887, XrefRangeEnd = 246888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x0022D664 File Offset: 0x0022B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246890, XrefRangeEnd = 246895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x0022D6BC File Offset: 0x0022B8BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 246896, RefRangeEnd = 246904, XrefRangeStart = 246895, XrefRangeEnd = 246896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeBalance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x0022D6FC File Offset: 0x0022B8FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 246905, RefRangeEnd = 246912, XrefRangeStart = 246904, XrefRangeEnd = 246905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float newBalance, bool blockClear = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockClear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0022D748 File Offset: 0x0022B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246912, XrefRangeEnd = 246916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0022D794 File Offset: 0x0022B994
		[CallerCount(0)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		public CashInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x0022D7DC File Offset: 0x0022B9DC
		// (set) Token: 0x060082FC RID: 33532 RVA: 0x0003E3D1 File Offset: 0x0003C5D1
		public unsafe static float MAX_BALANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&value));
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x060082FD RID: 33533 RVA: 0x0022D7F8 File Offset: 0x0022B9F8
		// (set) Token: 0x060082FE RID: 33534 RVA: 0x0003E3DF File Offset: 0x0003C5DF
		public unsafe float _Balance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField)) = value;
			}
		}

		// Token: 0x0400591D RID: 22813
		private static readonly IntPtr NativeFieldInfoPtr_MAX_BALANCE;

		// Token: 0x0400591E RID: 22814
		private static readonly IntPtr NativeFieldInfoPtr__Balance_k__BackingField;

		// Token: 0x0400591F RID: 22815
		private static readonly IntPtr NativeMethodInfoPtr_get_Balance_Public_get_Single_0;

		// Token: 0x04005920 RID: 22816
		private static readonly IntPtr NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0;

		// Token: 0x04005921 RID: 22817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005922 RID: 22818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005923 RID: 22819
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005924 RID: 22820
		private static readonly IntPtr NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0;

		// Token: 0x04005925 RID: 22821
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0;

		// Token: 0x04005926 RID: 22822
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005927 RID: 22823
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
