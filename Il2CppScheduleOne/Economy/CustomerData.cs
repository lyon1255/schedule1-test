using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x06005A1A RID: 23066 RVA: 0x001A3574 File Offset: 0x001A1774
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_DefaultAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DefaultAffinityData");
			CustomerData.NativeFieldInfoPtr_PreferredProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredProperties");
			CustomerData.NativeFieldInfoPtr_MinWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MaxWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_OrderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OrderTime");
			CustomerData.NativeFieldInfoPtr_PreferredOrderDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredOrderDay");
			CustomerData.NativeFieldInfoPtr_Standards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Standards");
			CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CanBeDirectlyApproached");
			CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "GuaranteeFirstSampleSuccess");
			CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_CallPoliceChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CallPoliceChance");
			CustomerData.NativeFieldInfoPtr_DependenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DependenceMultiplier");
			CustomerData.NativeFieldInfoPtr_BaseAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "BaseAddiction");
			CustomerData.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "onChanged");
			CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674782);
			CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674783);
			CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674784);
			CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674785);
			CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674786);
			CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674787);
			CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674788);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674789);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x001A3798 File Offset: 0x001A1998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190367, RefRangeEnd = 190369, XrefRangeStart = 190367, XrefRangeEnd = 190367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetQualityScalar(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x001A37D8 File Offset: 0x001A19D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190382, RefRangeEnd = 190385, XrefRangeStart = 190369, XrefRangeEnd = 190382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedRelationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EDay>>(intPtr3) : null;
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x001A3834 File Offset: 0x001A1A34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190392, RefRangeEnd = 190395, XrefRangeStart = 190385, XrefRangeEnd = 190392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedRelationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x001A3880 File Offset: 0x001A1A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190395, XrefRangeEnd = 190443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeAffinities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x001A38B4 File Offset: 0x001A1AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190443, XrefRangeEnd = 190489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x001A38E8 File Offset: 0x001A1AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190489, XrefRangeEnd = 190493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x001A391C File Offset: 0x001A1B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190493, XrefRangeEnd = 190498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x001A3950 File Offset: 0x001A1B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190498, XrefRangeEnd = 190506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x0002A8A4 File Offset: 0x00028AA4
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06005A24 RID: 23076 RVA: 0x001A398C File Offset: 0x001A1B8C
		// (set) Token: 0x06005A25 RID: 23077 RVA: 0x0002A8AD File Offset: 0x00028AAD
		public unsafe CustomerAffinityData DefaultAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06005A26 RID: 23078 RVA: 0x001A39BC File Offset: 0x001A1BBC
		// (set) Token: 0x06005A27 RID: 23079 RVA: 0x0002A8CC File Offset: 0x00028ACC
		public unsafe List<Property> PreferredProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x06005A28 RID: 23080 RVA: 0x001A39EC File Offset: 0x001A1BEC
		// (set) Token: 0x06005A29 RID: 23081 RVA: 0x0002A8EB File Offset: 0x00028AEB
		public unsafe float MinWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x06005A2A RID: 23082 RVA: 0x001A3A14 File Offset: 0x001A1C14
		// (set) Token: 0x06005A2B RID: 23083 RVA: 0x0002A906 File Offset: 0x00028B06
		public unsafe float MaxWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x001A3A3C File Offset: 0x001A1C3C
		// (set) Token: 0x06005A2D RID: 23085 RVA: 0x0002A921 File Offset: 0x00028B21
		public unsafe int MinOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06005A2E RID: 23086 RVA: 0x001A3A64 File Offset: 0x001A1C64
		// (set) Token: 0x06005A2F RID: 23087 RVA: 0x0002A93C File Offset: 0x00028B3C
		public unsafe int MaxOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06005A30 RID: 23088 RVA: 0x001A3A8C File Offset: 0x001A1C8C
		// (set) Token: 0x06005A31 RID: 23089 RVA: 0x0002A957 File Offset: 0x00028B57
		public unsafe int OrderTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime)) = value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06005A32 RID: 23090 RVA: 0x001A3AB4 File Offset: 0x001A1CB4
		// (set) Token: 0x06005A33 RID: 23091 RVA: 0x0002A972 File Offset: 0x00028B72
		public unsafe EDay PreferredOrderDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay)) = value;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x001A3ADC File Offset: 0x001A1CDC
		// (set) Token: 0x06005A35 RID: 23093 RVA: 0x0002A98D File Offset: 0x00028B8D
		public unsafe ECustomerStandard Standards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards)) = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x001A3B04 File Offset: 0x001A1D04
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		public unsafe bool CanBeDirectlyApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached)) = value;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x001A3B2C File Offset: 0x001A1D2C
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x0002A9C3 File Offset: 0x00028BC3
		public unsafe bool GuaranteeFirstSampleSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess)) = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x001A3B54 File Offset: 0x001A1D54
		// (set) Token: 0x06005A3B RID: 23099 RVA: 0x0002A9DE File Offset: 0x00028BDE
		public unsafe float MinMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x001A3B7C File Offset: 0x001A1D7C
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x0002A9F9 File Offset: 0x00028BF9
		public unsafe float MaxMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x001A3BA4 File Offset: 0x001A1DA4
		// (set) Token: 0x06005A3F RID: 23103 RVA: 0x0002AA14 File Offset: 0x00028C14
		public unsafe float CallPoliceChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance)) = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x001A3BCC File Offset: 0x001A1DCC
		// (set) Token: 0x06005A41 RID: 23105 RVA: 0x0002AA2F File Offset: 0x00028C2F
		public unsafe float DependenceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier)) = value;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005A42 RID: 23106 RVA: 0x001A3BF4 File Offset: 0x001A1DF4
		// (set) Token: 0x06005A43 RID: 23107 RVA: 0x0002AA4A File Offset: 0x00028C4A
		public unsafe float BaseAddiction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction)) = value;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x001A3C1C File Offset: 0x001A1E1C
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x0002AA65 File Offset: 0x00028C65
		public unsafe Action onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D88 RID: 15752
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAffinityData;

		// Token: 0x04003D89 RID: 15753
		private static readonly IntPtr NativeFieldInfoPtr_PreferredProperties;

		// Token: 0x04003D8A RID: 15754
		private static readonly IntPtr NativeFieldInfoPtr_MinWeeklySpend;

		// Token: 0x04003D8B RID: 15755
		private static readonly IntPtr NativeFieldInfoPtr_MaxWeeklySpend;

		// Token: 0x04003D8C RID: 15756
		private static readonly IntPtr NativeFieldInfoPtr_MinOrdersPerWeek;

		// Token: 0x04003D8D RID: 15757
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrdersPerWeek;

		// Token: 0x04003D8E RID: 15758
		private static readonly IntPtr NativeFieldInfoPtr_OrderTime;

		// Token: 0x04003D8F RID: 15759
		private static readonly IntPtr NativeFieldInfoPtr_PreferredOrderDay;

		// Token: 0x04003D90 RID: 15760
		private static readonly IntPtr NativeFieldInfoPtr_Standards;

		// Token: 0x04003D91 RID: 15761
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDirectlyApproached;

		// Token: 0x04003D92 RID: 15762
		private static readonly IntPtr NativeFieldInfoPtr_GuaranteeFirstSampleSuccess;

		// Token: 0x04003D93 RID: 15763
		private static readonly IntPtr NativeFieldInfoPtr_MinMutualRelationRequirement;

		// Token: 0x04003D94 RID: 15764
		private static readonly IntPtr NativeFieldInfoPtr_MaxMutualRelationRequirement;

		// Token: 0x04003D95 RID: 15765
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceChance;

		// Token: 0x04003D96 RID: 15766
		private static readonly IntPtr NativeFieldInfoPtr_DependenceMultiplier;

		// Token: 0x04003D97 RID: 15767
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddiction;

		// Token: 0x04003D98 RID: 15768
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04003D99 RID: 15769
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0;

		// Token: 0x04003D9A RID: 15770
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0;

		// Token: 0x04003D9B RID: 15771
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0;

		// Token: 0x04003D9C RID: 15772
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0;

		// Token: 0x04003D9D RID: 15773
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeProperties_Public_Void_0;

		// Token: 0x04003D9E RID: 15774
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeTiming_Public_Void_0;

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeMethodInfoPtr_ClearInvalid_Public_Void_0;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
