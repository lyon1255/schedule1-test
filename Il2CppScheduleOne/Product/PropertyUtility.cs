using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AE RID: 1454
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x06007FD5 RID: 32725 RVA: 0x00223730 File Offset: 0x00221930
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyUtility()
		{
			Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr);
			PropertyUtility.NativeFieldInfoPtr_PropertyDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyDatas");
			PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeDatas");
			PropertyUtility.NativeFieldInfoPtr_AllProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "AllProperties");
			PropertyUtility.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Products");
			PropertyUtility.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Properties");
			PropertyUtility.NativeFieldInfoPtr_PropertiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertiesDict");
			PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679346);
			PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679347);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679348);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679349);
			PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679350);
			PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679351);
			PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679352);
			PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679353);
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00223878 File Offset: 0x00221A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243229, XrefRangeEnd = 243249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x002238B4 File Offset: 0x00221AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243249, XrefRangeEnd = 243252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x002238F0 File Offset: 0x00221AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243252, XrefRangeEnd = 243271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(int tier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x0022393C File Offset: 0x00221B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243339, RefRangeEnd = 243342, XrefRangeStart = 243271, XrefRangeEnd = 243339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(List<string> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x0022398C File Offset: 0x00221B8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243360, RefRangeEnd = 243363, XrefRangeStart = 243342, XrefRangeEnd = 243360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.PropertyData>(intPtr3) : null;
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x002239CC File Offset: 0x00221BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243381, RefRangeEnd = 243384, XrefRangeStart = 243363, XrefRangeEnd = 243381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.DrugTypeData>(intPtr3) : null;
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00223A0C File Offset: 0x00221C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243384, XrefRangeEnd = 243434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Color32> GetOrderedPropertyColors(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr3) : null;
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00223A50 File Offset: 0x00221C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243434, XrefRangeEnd = 243479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x0003C966 File Offset: 0x0003AB66
		public PropertyUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x06007FDF RID: 32735 RVA: 0x00223A8C File Offset: 0x00221C8C
		// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x0003C96F File Offset: 0x0003AB6F
		public unsafe List<PropertyUtility.PropertyData> PropertyDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.PropertyData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x00223ABC File Offset: 0x00221CBC
		// (set) Token: 0x06007FE2 RID: 32738 RVA: 0x0003C98E File Offset: 0x0003AB8E
		public unsafe List<PropertyUtility.DrugTypeData> DrugTypeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.DrugTypeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x00223AEC File Offset: 0x00221CEC
		// (set) Token: 0x06007FE4 RID: 32740 RVA: 0x0003C9AD File Offset: 0x0003ABAD
		public unsafe List<Property> AllProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x00223B1C File Offset: 0x00221D1C
		// (set) Token: 0x06007FE6 RID: 32742 RVA: 0x0003C9CC File Offset: 0x0003ABCC
		public unsafe List<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x06007FE7 RID: 32743 RVA: 0x00223B4C File Offset: 0x00221D4C
		// (set) Token: 0x06007FE8 RID: 32744 RVA: 0x0003C9EB File Offset: 0x0003ABEB
		public unsafe List<PropertyItemDefinition> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x00223B7C File Offset: 0x00221D7C
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x0003CA0A File Offset: 0x0003AC0A
		public unsafe Dictionary<string, Property> PropertiesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400571B RID: 22299
		private static readonly IntPtr NativeFieldInfoPtr_PropertyDatas;

		// Token: 0x0400571C RID: 22300
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypeDatas;

		// Token: 0x0400571D RID: 22301
		private static readonly IntPtr NativeFieldInfoPtr_AllProperties;

		// Token: 0x0400571E RID: 22302
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400571F RID: 22303
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005720 RID: 22304
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesDict;

		// Token: 0x04005721 RID: 22305
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005722 RID: 22306
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005723 RID: 22307
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0;

		// Token: 0x04005724 RID: 22308
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0;

		// Token: 0x04005725 RID: 22309
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0;

		// Token: 0x04005726 RID: 22310
		private static readonly IntPtr NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0;

		// Token: 0x04005727 RID: 22311
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0;

		// Token: 0x04005728 RID: 22312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD5 RID: 2773
		[Serializable]
		public class PropertyData : Il2CppSystem.Object
		{
			// Token: 0x0600D4AA RID: 54442 RVA: 0x0032BAF8 File Offset: 0x00329CF8
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyData()
			{
				Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr);
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Property");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Name");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Description");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Color");
				PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, 100679354);
			}

			// Token: 0x0600D4AB RID: 54443 RVA: 0x0032BB88 File Offset: 0x00329D88
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AC RID: 54444 RVA: 0x000677C2 File Offset: 0x000659C2
			public PropertyData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E8 RID: 16872
			// (get) Token: 0x0600D4AD RID: 54445 RVA: 0x0032BBC4 File Offset: 0x00329DC4
			// (set) Token: 0x0600D4AE RID: 54446 RVA: 0x000677CB File Offset: 0x000659CB
			public unsafe EProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property)) = value;
				}
			}

			// Token: 0x170041E9 RID: 16873
			// (get) Token: 0x0600D4AF RID: 54447 RVA: 0x0032BBEC File Offset: 0x00329DEC
			// (set) Token: 0x0600D4B0 RID: 54448 RVA: 0x000677E6 File Offset: 0x000659E6
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041EA RID: 16874
			// (get) Token: 0x0600D4B1 RID: 54449 RVA: 0x0032BC14 File Offset: 0x00329E14
			// (set) Token: 0x0600D4B2 RID: 54450 RVA: 0x00067805 File Offset: 0x00065A05
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041EB RID: 16875
			// (get) Token: 0x0600D4B3 RID: 54451 RVA: 0x0032BC3C File Offset: 0x00329E3C
			// (set) Token: 0x0600D4B4 RID: 54452 RVA: 0x00067824 File Offset: 0x00065A24
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008F1F RID: 36639
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04008F20 RID: 36640
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008F21 RID: 36641
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x04008F22 RID: 36642
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008F23 RID: 36643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AD6 RID: 2774
		[Serializable]
		public class DrugTypeData : Il2CppSystem.Object
		{
			// Token: 0x0600D4B5 RID: 54453 RVA: 0x0032BC64 File Offset: 0x00329E64
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeData()
			{
				Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr);
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "DrugType");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Name");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Color");
				PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, 100679355);
			}

			// Token: 0x0600D4B6 RID: 54454 RVA: 0x0032BCE0 File Offset: 0x00329EE0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B7 RID: 54455 RVA: 0x0006783F File Offset: 0x00065A3F
			public DrugTypeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EC RID: 16876
			// (get) Token: 0x0600D4B8 RID: 54456 RVA: 0x0032BD1C File Offset: 0x00329F1C
			// (set) Token: 0x0600D4B9 RID: 54457 RVA: 0x00067848 File Offset: 0x00065A48
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170041ED RID: 16877
			// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x0032BD44 File Offset: 0x00329F44
			// (set) Token: 0x0600D4BB RID: 54459 RVA: 0x00067863 File Offset: 0x00065A63
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041EE RID: 16878
			// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x0032BD6C File Offset: 0x00329F6C
			// (set) Token: 0x0600D4BD RID: 54461 RVA: 0x00067882 File Offset: 0x00065A82
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008F24 RID: 36644
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008F25 RID: 36645
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008F26 RID: 36646
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008F27 RID: 36647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AD7 RID: 2775
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4BE RID: 54462 RVA: 0x0032BD94 File Offset: 0x00329F94
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr);
				PropertyUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9");
				PropertyUtility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9__14_0");
				PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679357);
				PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679358);
			}

			// Token: 0x0600D4BF RID: 54463 RVA: 0x0032BE10 File Offset: 0x0032A010
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4C0 RID: 54464 RVA: 0x0032BE4C File Offset: 0x0032A04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedPropertyColors_b__14_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4C1 RID: 54465 RVA: 0x0006789D File Offset: 0x00065A9D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EF RID: 16879
			// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x0032BEAC File Offset: 0x0032A0AC
			// (set) Token: 0x0600D4C3 RID: 54467 RVA: 0x000678A6 File Offset: 0x00065AA6
			public unsafe static PropertyUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F0 RID: 16880
			// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x0032BED4 File Offset: 0x0032A0D4
			// (set) Token: 0x0600D4C5 RID: 54469 RVA: 0x000678B8 File Offset: 0x00065AB8
			public unsafe static Comparison<Property> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F28 RID: 36648
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F29 RID: 36649
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008F2A RID: 36650
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F2B RID: 36651
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0;
		}

		// Token: 0x02000AD8 RID: 2776
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4C6 RID: 54470 RVA: 0x0032BEFC File Offset: 0x0032A0FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "tier");
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "excludePostMixingRework");
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679359);
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679360);
			}

			// Token: 0x0600D4C7 RID: 54471 RVA: 0x0032BF78 File Offset: 0x0032A178
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4C8 RID: 54472 RVA: 0x0032BFB4 File Offset: 0x0032A1B4
			[CallerCount(0)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4C9 RID: 54473 RVA: 0x000678CA File Offset: 0x00065ACA
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F1 RID: 16881
			// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x0032C004 File Offset: 0x0032A204
			// (set) Token: 0x0600D4CB RID: 54475 RVA: 0x000678D3 File Offset: 0x00065AD3
			public unsafe int tier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier)) = value;
				}
			}

			// Token: 0x170041F2 RID: 16882
			// (get) Token: 0x0600D4CC RID: 54476 RVA: 0x0032C02C File Offset: 0x0032A22C
			// (set) Token: 0x0600D4CD RID: 54477 RVA: 0x000678EE File Offset: 0x00065AEE
			public unsafe bool excludePostMixingRework
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework)) = value;
				}
			}

			// Token: 0x04008F2C RID: 36652
			private static readonly IntPtr NativeFieldInfoPtr_tier;

			// Token: 0x04008F2D RID: 36653
			private static readonly IntPtr NativeFieldInfoPtr_excludePostMixingRework;

			// Token: 0x04008F2E RID: 36654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F2F RID: 36655
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4CE RID: 54478 RVA: 0x0032C054 File Offset: 0x0032A254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, "ids");
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679361);
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679362);
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x0032C0BC File Offset: 0x0032A2BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4D0 RID: 54480 RVA: 0x0032C0F8 File Offset: 0x0032A2F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243225, XrefRangeEnd = 243229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4D1 RID: 54481 RVA: 0x00067909 File Offset: 0x00065B09
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F3 RID: 16883
			// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x0032C148 File Offset: 0x0032A348
			// (set) Token: 0x0600D4D3 RID: 54483 RVA: 0x00067912 File Offset: 0x00065B12
			public unsafe List<string> ids
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F30 RID: 36656
			private static readonly IntPtr NativeFieldInfoPtr_ids;

			// Token: 0x04008F31 RID: 36657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F32 RID: 36658
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000ADA RID: 2778
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D4D4 RID: 54484 RVA: 0x0032C178 File Offset: 0x0032A378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, "id");
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679363);
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679364);
			}

			// Token: 0x0600D4D5 RID: 54485 RVA: 0x0032C1E0 File Offset: 0x0032A3E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4D6 RID: 54486 RVA: 0x0032C21C File Offset: 0x0032A41C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__1(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4D7 RID: 54487 RVA: 0x00067931 File Offset: 0x00065B31
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F4 RID: 16884
			// (get) Token: 0x0600D4D8 RID: 54488 RVA: 0x0032C26C File Offset: 0x0032A46C
			// (set) Token: 0x0600D4D9 RID: 54489 RVA: 0x0006793A File Offset: 0x00065B3A
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F33 RID: 36659
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008F34 RID: 36660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F35 RID: 36661
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0;
		}

		// Token: 0x02000ADB RID: 2779
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4DA RID: 54490 RVA: 0x0032C294 File Offset: 0x0032A494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, "property");
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679365);
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679366);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x0032C2FC File Offset: 0x0032A4FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4DC RID: 54492 RVA: 0x0032C338 File Offset: 0x0032A538
			[CallerCount(0)]
			public unsafe bool _GetPropertyData_b__0(PropertyUtility.PropertyData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4DD RID: 54493 RVA: 0x00067959 File Offset: 0x00065B59
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F5 RID: 16885
			// (get) Token: 0x0600D4DE RID: 54494 RVA: 0x0032C388 File Offset: 0x0032A588
			// (set) Token: 0x0600D4DF RID: 54495 RVA: 0x00067962 File Offset: 0x00065B62
			public unsafe EProperty property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property)) = value;
				}
			}

			// Token: 0x04008F36 RID: 36662
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04008F37 RID: 36663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F38 RID: 36664
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0;
		}

		// Token: 0x02000ADC RID: 2780
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4E0 RID: 54496 RVA: 0x0032C3B0 File Offset: 0x0032A5B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, "drugType");
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679367);
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679368);
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x0032C418 File Offset: 0x0032A618
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4E2 RID: 54498 RVA: 0x0032C454 File Offset: 0x0032A654
			[CallerCount(0)]
			public unsafe bool _GetDrugTypeData_b__0(PropertyUtility.DrugTypeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4E3 RID: 54499 RVA: 0x0006797D File Offset: 0x00065B7D
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F6 RID: 16886
			// (get) Token: 0x0600D4E4 RID: 54500 RVA: 0x0032C4A4 File Offset: 0x0032A6A4
			// (set) Token: 0x0600D4E5 RID: 54501 RVA: 0x00067986 File Offset: 0x00065B86
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04008F39 RID: 36665
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04008F3A RID: 36666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3B RID: 36667
			private static readonly IntPtr NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0;
		}
	}
}
