using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A4 RID: 932
	public class ManagementItemFilter : Object
	{
		// Token: 0x0600490D RID: 18701 RVA: 0x0016482C File Offset: 0x00162A2C
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementItemFilter()
		{
			Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr);
			ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Mode>k__BackingField");
			ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Items>k__BackingField");
			ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672354);
			ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672355);
			ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672356);
			ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672357);
			ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672358);
			ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672359);
			ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672360);
			ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672361);
			ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672362);
			ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672363);
			ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672364);
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x00164960 File Offset: 0x00162B60
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x0016499C File Offset: 0x00162B9C
		public unsafe ManagementItemFilter.EMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 29969, RefRangeEnd = 29975, XrefRangeStart = 29969, XrefRangeEnd = 29975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x001649DC File Offset: 0x00162BDC
		// (set) Token: 0x06004911 RID: 18705 RVA: 0x00164A1C File Offset: 0x00162C1C
		public unsafe List<ItemDefinition> Items
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00164A60 File Offset: 0x00162C60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162898, RefRangeEnd = 162900, XrefRangeStart = 162885, XrefRangeEnd = 162898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementItemFilter(ManagementItemFilter.EMode mode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00164AA8 File Offset: 0x00162CA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 29969, RefRangeEnd = 29975, XrefRangeStart = 29969, XrefRangeEnd = 29975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(ManagementItemFilter.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00164AE8 File Offset: 0x00162CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162906, RefRangeEnd = 162908, XrefRangeStart = 162900, XrefRangeEnd = 162906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00164B2C File Offset: 0x00162D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162908, XrefRangeEnd = 162912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00164B70 File Offset: 0x00162D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162912, XrefRangeEnd = 162916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x00164BC0 File Offset: 0x00162DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162923, RefRangeEnd = 162924, XrefRangeStart = 162916, XrefRangeEnd = 162923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMeetFilter(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x00164C10 File Offset: 0x00162E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162924, XrefRangeEnd = 162932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x000233B2 File Offset: 0x000215B2
		public ManagementItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x00164C48 File Offset: 0x00162E48
		// (set) Token: 0x0600491B RID: 18715 RVA: 0x000233BB File Offset: 0x000215BB
		public unsafe ManagementItemFilter.EMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x00164C70 File Offset: 0x00162E70
		// (set) Token: 0x0600491D RID: 18717 RVA: 0x000233D6 File Offset: 0x000215D6
		public unsafe List<ItemDefinition> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMode_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_String_0;

		// Token: 0x0200097E RID: 2430
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x0400889E RID: 34974
			Whitelist,
			// Token: 0x0400889F RID: 34975
			Blacklist
		}
	}
}
