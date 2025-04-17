using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E0 RID: 1504
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x06008373 RID: 33651 RVA: 0x0022F0B0 File Offset: 0x0022D2B0
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemInstance()
		{
			Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr);
			IntegerItemInstance.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, "Value");
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679742);
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679743);
			IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679744);
			IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679745);
			IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679746);
			IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100679747);
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0022F16C File Offset: 0x0022D36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206615, RefRangeEnd = 206617, XrefRangeStart = 206615, XrefRangeEnd = 206617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0022F1A8 File Offset: 0x0022D3A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206618, RefRangeEnd = 206623, XrefRangeStart = 206618, XrefRangeEnd = 206623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance(ItemDefinition definition, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0022F210 File Offset: 0x0022D410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247182, XrefRangeEnd = 247187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0022F268 File Offset: 0x0022D468
		[CallerCount(0)]
		public unsafe void ChangeValue(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0022F2A8 File Offset: 0x0022D4A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247187, RefRangeEnd = 247192, XrefRangeStart = 247187, XrefRangeEnd = 247187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x0022F2E8 File Offset: 0x0022D4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247192, XrefRangeEnd = 247196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x0003E695 File Offset: 0x0003C895
		public IntegerItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600837B RID: 33659 RVA: 0x0022F334 File Offset: 0x0022D534
		// (set) Token: 0x0600837C RID: 33660 RVA: 0x0003E69E File Offset: 0x0003C89E
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04005975 RID: 22901
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04005976 RID: 22902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005977 RID: 22903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0;

		// Token: 0x04005978 RID: 22904
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005979 RID: 22905
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0;

		// Token: 0x0400597A RID: 22906
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

		// Token: 0x0400597B RID: 22907
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
