using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000394 RID: 916
	public class NumberField : ConfigField
	{
		// Token: 0x060047E4 RID: 18404 RVA: 0x001601C0 File Offset: 0x0015E3C0
		// Note: this type is marked as 'beforefieldinit'.
		static NumberField()
		{
			Il2CppClassPointerStore<NumberField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NumberField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberField>.NativeClassPtr);
			NumberField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<Value>k__BackingField");
			NumberField.NativeFieldInfoPtr__MinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MinValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MaxValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<WholeNumbers>k__BackingField");
			NumberField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "onItemChanged");
			NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672186);
			NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672187);
			NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672188);
			NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672189);
			NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672190);
			NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672191);
			NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672192);
			NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672193);
			NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672194);
			NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672195);
			NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672196);
			NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672197);
			NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672198);
			NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672199);
		}

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x0016036C File Offset: 0x0015E56C
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x001603A8 File Offset: 0x0015E5A8
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90255, RefRangeEnd = 90259, XrefRangeStart = 90255, XrefRangeEnd = 90259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x001603E8 File Offset: 0x0015E5E8
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x00160424 File Offset: 0x0015E624
		public unsafe float MinValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29998, RefRangeEnd = 30009, XrefRangeStart = 29998, XrefRangeEnd = 30009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x00160464 File Offset: 0x0015E664
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x001604A0 File Offset: 0x0015E6A0
		public unsafe float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x001604E0 File Offset: 0x0015E6E0
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x0016051C File Offset: 0x0015E71C
		public unsafe bool WholeNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0016055C File Offset: 0x0015E75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161441, XrefRangeEnd = 161449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x001605A8 File Offset: 0x0015E7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161453, RefRangeEnd = 161454, XrefRangeStart = 161449, XrefRangeEnd = 161453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x001605F4 File Offset: 0x0015E7F4
		[CallerCount(0)]
		public unsafe void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeNumbers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00160650 File Offset: 0x0015E850
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x00160698 File Offset: 0x0015E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161454, XrefRangeEnd = 161458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr3) : null;
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x001606D8 File Offset: 0x0015E8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161462, RefRangeEnd = 161463, XrefRangeStart = 161458, XrefRangeEnd = 161462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NumberFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00022C5E File Offset: 0x00020E5E
		public NumberField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x0016071C File Offset: 0x0015E91C
		// (set) Token: 0x060047F5 RID: 18421 RVA: 0x00022C67 File Offset: 0x00020E67
		public unsafe float _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x00160744 File Offset: 0x0015E944
		// (set) Token: 0x060047F7 RID: 18423 RVA: 0x00022C82 File Offset: 0x00020E82
		public unsafe float _MinValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x060047F8 RID: 18424 RVA: 0x0016076C File Offset: 0x0015E96C
		// (set) Token: 0x060047F9 RID: 18425 RVA: 0x00022C9D File Offset: 0x00020E9D
		public unsafe float _MaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x00160794 File Offset: 0x0015E994
		// (set) Token: 0x060047FB RID: 18427 RVA: 0x00022CB8 File Offset: 0x00020EB8
		public unsafe bool _WholeNumbers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField)) = value;
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x060047FC RID: 18428 RVA: 0x001607BC File Offset: 0x0015E9BC
		// (set) Token: 0x060047FD RID: 18429 RVA: 0x00022CD3 File Offset: 0x00020ED3
		public unsafe UnityEvent<float> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeFieldInfoPtr__MinValue_k__BackingField;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeFieldInfoPtr__WholeNumbers_k__BackingField;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_get_Single_0;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NumberFieldData_0;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0;
	}
}
