using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075C RID: 1884
	[Serializable]
	public class WateringCanInstance : StorableItemInstance
	{
		// Token: 0x0600B33B RID: 45883 RVA: 0x002CB4FC File Offset: 0x002C96FC
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanInstance()
		{
			Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr);
			WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, "CurrentFillAmount");
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685404);
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685405);
			WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685406);
			WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685407);
			WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100685408);
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x002CB5A4 File Offset: 0x002C97A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206615, RefRangeEnd = 206617, XrefRangeStart = 206615, XrefRangeEnd = 206617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x002CB5E0 File Offset: 0x002C97E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308371, RefRangeEnd = 308372, XrefRangeStart = 308370, XrefRangeEnd = 308371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance(ItemDefinition definition, int quantity, float fillAmount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x002CB648 File Offset: 0x002C9848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308372, XrefRangeEnd = 308377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x002CB6A0 File Offset: 0x002C98A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308378, RefRangeEnd = 308379, XrefRangeStart = 308377, XrefRangeEnd = 308378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFillAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x002CB6E0 File Offset: 0x002C98E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308379, XrefRangeEnd = 308383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x00057D13 File Offset: 0x00055F13
		public WateringCanInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x002CB72C File Offset: 0x002C992C
		// (set) Token: 0x0600B343 RID: 45891 RVA: 0x00057D1C File Offset: 0x00055F1C
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x040078EC RID: 30956
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x040078ED RID: 30957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078EE RID: 30958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0;

		// Token: 0x040078EF RID: 30959
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078F0 RID: 30960
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0;

		// Token: 0x040078F1 RID: 30961
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
