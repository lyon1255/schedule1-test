using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C5 RID: 1733
	public class ItemFieldUI : MonoBehaviour
	{
		// Token: 0x06009B97 RID: 39831 RVA: 0x00277554 File Offset: 0x00275754
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldUI()
		{
			Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr);
			ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "ShowNoneAsAny");
			ItemFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "FieldLabel");
			ItemFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "IconImg");
			ItemFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "SelectionLabel");
			ItemFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "NoneSelected");
			ItemFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, "MultipleSelected");
			ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682412);
			ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682413);
			ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682414);
			ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682415);
			ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682416);
			ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682417);
			ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682418);
			ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr, 100682419);
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x002776B0 File Offset: 0x002758B0
		// (set) Token: 0x06009B99 RID: 39833 RVA: 0x002776F0 File Offset: 0x002758F0
		public unsafe List<ItemField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x00277734 File Offset: 0x00275934
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276130, RefRangeEnd = 276134, XrefRangeStart = 276103, XrefRangeEnd = 276130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ItemField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B9B RID: 39835 RVA: 0x00277778 File Offset: 0x00275978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276157, RefRangeEnd = 276158, XrefRangeStart = 276134, XrefRangeEnd = 276157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(ItemDefinition newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B9C RID: 39836 RVA: 0x002777BC File Offset: 0x002759BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276169, RefRangeEnd = 276171, XrefRangeStart = 276158, XrefRangeEnd = 276169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009B9D RID: 39837 RVA: 0x002777F8 File Offset: 0x002759F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276171, XrefRangeEnd = 276243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B9E RID: 39838 RVA: 0x0027782C File Offset: 0x00275A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276243, XrefRangeEnd = 276258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x00277870 File Offset: 0x00275A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276258, XrefRangeEnd = 276266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x0004C36C File Offset: 0x0004A56C
		public ItemFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x06009BA1 RID: 39841 RVA: 0x002778AC File Offset: 0x00275AAC
		// (set) Token: 0x06009BA2 RID: 39842 RVA: 0x0004C375 File Offset: 0x0004A575
		public unsafe List<ItemField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x06009BA3 RID: 39843 RVA: 0x002778DC File Offset: 0x00275ADC
		// (set) Token: 0x06009BA4 RID: 39844 RVA: 0x0004C394 File Offset: 0x0004A594
		public unsafe bool ShowNoneAsAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_ShowNoneAsAny)) = value;
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x06009BA5 RID: 39845 RVA: 0x00277904 File Offset: 0x00275B04
		// (set) Token: 0x06009BA6 RID: 39846 RVA: 0x0004C3AF File Offset: 0x0004A5AF
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x06009BA7 RID: 39847 RVA: 0x00277934 File Offset: 0x00275B34
		// (set) Token: 0x06009BA8 RID: 39848 RVA: 0x0004C3CE File Offset: 0x0004A5CE
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x06009BA9 RID: 39849 RVA: 0x00277964 File Offset: 0x00275B64
		// (set) Token: 0x06009BAA RID: 39850 RVA: 0x0004C3ED File Offset: 0x0004A5ED
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x06009BAB RID: 39851 RVA: 0x00277994 File Offset: 0x00275B94
		// (set) Token: 0x06009BAC RID: 39852 RVA: 0x0004C40C File Offset: 0x0004A60C
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x002779C4 File Offset: 0x00275BC4
		// (set) Token: 0x06009BAE RID: 39854 RVA: 0x0004C42B File Offset: 0x0004A62B
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400688A RID: 26762
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400688B RID: 26763
		private static readonly IntPtr NativeFieldInfoPtr_ShowNoneAsAny;

		// Token: 0x0400688C RID: 26764
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x0400688D RID: 26765
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x0400688E RID: 26766
		private static readonly IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x0400688F RID: 26767
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04006890 RID: 26768
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x04006891 RID: 26769
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ItemField_0;

		// Token: 0x04006892 RID: 26770
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ItemField_0;

		// Token: 0x04006893 RID: 26771
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ItemField_0;

		// Token: 0x04006894 RID: 26772
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_ItemDefinition_0;

		// Token: 0x04006895 RID: 26773
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006896 RID: 26774
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006897 RID: 26775
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_Option_0;

		// Token: 0x04006898 RID: 26776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
