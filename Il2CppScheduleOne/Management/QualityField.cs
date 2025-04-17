using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000397 RID: 919
	public class QualityField : ConfigField
	{
		// Token: 0x06004824 RID: 18468 RVA: 0x00160FCC File Offset: 0x0015F1CC
		// Note: this type is marked as 'beforefieldinit'.
		static QualityField()
		{
			Il2CppClassPointerStore<QualityField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "QualityField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityField>.NativeClassPtr);
			QualityField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "<Value>k__BackingField");
			QualityField.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "onValueChanged");
			QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672214);
			QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672215);
			QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672216);
			QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672217);
			QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672218);
			QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672219);
			QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672220);
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x001610B0 File Offset: 0x0015F2B0
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x001610EC File Offset: 0x0015F2EC
		public unsafe EQuality Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29996, RefRangeEnd = 29998, XrefRangeStart = 29996, XrefRangeEnd = 29998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x0016112C File Offset: 0x0015F32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161777, XrefRangeEnd = 161785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x00161178 File Offset: 0x0015F378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161789, RefRangeEnd = 161791, XrefRangeStart = 161785, XrefRangeEnd = 161789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(EQuality value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x001611C4 File Offset: 0x0015F3C4
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x0016120C File Offset: 0x0015F40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161791, XrefRangeEnd = 161795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr3) : null;
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x0016124C File Offset: 0x0015F44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161799, RefRangeEnd = 161800, XrefRangeStart = 161795, XrefRangeEnd = 161799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(QualityFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00022E32 File Offset: 0x00021032
		public QualityField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x00161290 File Offset: 0x0015F490
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x00022E3B File Offset: 0x0002103B
		public unsafe EQuality _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x001612B8 File Offset: 0x0015F4B8
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x00022E56 File Offset: 0x00021056
		public unsafe UnityEvent<EQuality> onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_EQuality_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_QualityFieldData_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0;
	}
}
