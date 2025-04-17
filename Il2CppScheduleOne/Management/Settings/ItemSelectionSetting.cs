using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Settings
{
	// Token: 0x020003A9 RID: 937
	[Serializable]
	public class ItemSelectionSetting : Object
	{
		// Token: 0x06004945 RID: 18757 RVA: 0x0016554C File Offset: 0x0016374C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectionSetting()
		{
			Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Settings", "ItemSelectionSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr);
			ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, "<SelectedItems>k__BackingField");
			ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672384);
			ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672385);
			ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672386);
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x001655CC File Offset: 0x001637CC
		// (set) Token: 0x06004947 RID: 18759 RVA: 0x0016560C File Offset: 0x0016380C
		public unsafe List<string> SelectedItems
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x00165650 File Offset: 0x00163850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163092, XrefRangeEnd = 163100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectionSetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x000234D3 File Offset: 0x000216D3
		public ItemSelectionSetting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600494A RID: 18762 RVA: 0x0016568C File Offset: 0x0016388C
		// (set) Token: 0x0600494B RID: 18763 RVA: 0x000234DC File Offset: 0x000216DC
		public unsafe List<string> _SelectedItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItems_k__BackingField;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
