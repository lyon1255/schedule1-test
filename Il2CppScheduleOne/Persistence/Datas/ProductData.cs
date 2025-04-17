using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AB RID: 683
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x06003142 RID: 12610 RVA: 0x0010CDB8 File Offset: 0x0010AFB8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductData()
		{
			Il2CppClassPointerStore<ProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductData>.NativeClassPtr);
			ProductData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Name");
			ProductData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "ID");
			ProductData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "DrugType");
			ProductData.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Properties");
			ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductData>.NativeClassPtr, 100668833);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0010CE4C File Offset: 0x0010B04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131007, RefRangeEnd = 131008, XrefRangeStart = 131003, XrefRangeEnd = 131007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0001A4B7 File Offset: 0x000186B7
		public ProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x0010CECC File Offset: 0x0010B0CC
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x0001A4C0 File Offset: 0x000186C0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0010CEF4 File Offset: 0x0010B0F4
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x0001A4DF File Offset: 0x000186DF
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x0010CF1C File Offset: 0x0010B11C
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x0001A4FE File Offset: 0x000186FE
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x0010CF44 File Offset: 0x0010B144
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x0001A519 File Offset: 0x00018719
		public unsafe Il2CppStringArray Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0;
	}
}
