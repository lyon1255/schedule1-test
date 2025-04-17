using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C7 RID: 1735
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x06009BC8 RID: 39880 RVA: 0x00277EE4 File Offset: 0x002760E4
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldUI()
		{
			Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NumberFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr);
			NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NumberFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "FieldLabel");
			NumberFieldUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "Slider");
			NumberFieldUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "ValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MinValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MinValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MaxValueLabel");
			NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682432);
			NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682433);
			NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682434);
			NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682435);
			NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682436);
			NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682437);
			NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682438);
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x06009BC9 RID: 39881 RVA: 0x00278018 File Offset: 0x00276218
		// (set) Token: 0x06009BCA RID: 39882 RVA: 0x00278058 File Offset: 0x00276258
		public unsafe List<NumberField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x0027809C File Offset: 0x0027629C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276465, RefRangeEnd = 276466, XrefRangeStart = 276407, XrefRangeEnd = 276465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NumberField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x002780E0 File Offset: 0x002762E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276466, XrefRangeEnd = 276477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00278120 File Offset: 0x00276320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276477, XrefRangeEnd = 276484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x0027815C File Offset: 0x0027635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276484, XrefRangeEnd = 276490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x0027819C File Offset: 0x0027639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276490, XrefRangeEnd = 276498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x0004C52C File Offset: 0x0004A72C
		public NumberFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FF5 RID: 12277
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x002781D8 File Offset: 0x002763D8
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x0004C535 File Offset: 0x0004A735
		public unsafe List<NumberField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF6 RID: 12278
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x00278208 File Offset: 0x00276408
		// (set) Token: 0x06009BD4 RID: 39892 RVA: 0x0004C554 File Offset: 0x0004A754
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF7 RID: 12279
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x00278238 File Offset: 0x00276438
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x0004C573 File Offset: 0x0004A773
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF8 RID: 12280
		// (get) Token: 0x06009BD7 RID: 39895 RVA: 0x00278268 File Offset: 0x00276468
		// (set) Token: 0x06009BD8 RID: 39896 RVA: 0x0004C592 File Offset: 0x0004A792
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FF9 RID: 12281
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x00278298 File Offset: 0x00276498
		// (set) Token: 0x06009BDA RID: 39898 RVA: 0x0004C5B1 File Offset: 0x0004A7B1
		public unsafe TextMeshProUGUI MinValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFA RID: 12282
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x002782C8 File Offset: 0x002764C8
		// (set) Token: 0x06009BDC RID: 39900 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
		public unsafe TextMeshProUGUI MaxValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068A9 RID: 26793
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068AA RID: 26794
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068AB RID: 26795
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x040068AC RID: 26796
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040068AD RID: 26797
		private static readonly IntPtr NativeFieldInfoPtr_MinValueLabel;

		// Token: 0x040068AE RID: 26798
		private static readonly IntPtr NativeFieldInfoPtr_MaxValueLabel;

		// Token: 0x040068AF RID: 26799
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0;

		// Token: 0x040068B0 RID: 26800
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0;

		// Token: 0x040068B1 RID: 26801
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0;

		// Token: 0x040068B2 RID: 26802
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_Single_0;

		// Token: 0x040068B3 RID: 26803
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068B4 RID: 26804
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0;

		// Token: 0x040068B5 RID: 26805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
