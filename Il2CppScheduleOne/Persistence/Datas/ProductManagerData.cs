using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AD RID: 685
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x06003152 RID: 12626 RVA: 0x0010D090 File Offset: 0x0010B290
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerData()
		{
			Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr);
			ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "DiscoveredProducts");
			ProductManagerData.NativeFieldInfoPtr_ListedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ListedProducts");
			ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ActiveMixOperation");
			ProductManagerData.NativeFieldInfoPtr_IsMixComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "IsMixComplete");
			ProductManagerData.NativeFieldInfoPtr_MixRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "MixRecipes");
			ProductManagerData.NativeFieldInfoPtr_ProductPrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ProductPrices");
			ProductManagerData.NativeFieldInfoPtr_FavouritedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "FavouritedProducts");
			ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, 100668835);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0010D160 File Offset: 0x0010B360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131015, RefRangeEnd = 131016, XrefRangeStart = 131008, XrefRangeEnd = 131015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerData(Il2CppStringArray discoveredProducts, Il2CppStringArray listedProducts, NewMixOperation activeOperation, bool isMixComplete, Il2CppReferenceArray<MixRecipeData> mixRecipes, Il2CppReferenceArray<StringIntPair> productPrices, Il2CppStringArray favouritedProducts) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(discoveredProducts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeOperation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMixComplete;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixRecipes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productPrices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(favouritedProducts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0001A560 File Offset: 0x00018760
		public ProductManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x0010D218 File Offset: 0x0010B418
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x0001A569 File Offset: 0x00018769
		public unsafe Il2CppStringArray DiscoveredProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x0010D248 File Offset: 0x0010B448
		// (set) Token: 0x06003158 RID: 12632 RVA: 0x0001A588 File Offset: 0x00018788
		public unsafe Il2CppStringArray ListedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x0010D278 File Offset: 0x0010B478
		// (set) Token: 0x0600315A RID: 12634 RVA: 0x0001A5A7 File Offset: 0x000187A7
		public unsafe NewMixOperation ActiveMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600315B RID: 12635 RVA: 0x0010D2A8 File Offset: 0x0010B4A8
		// (set) Token: 0x0600315C RID: 12636 RVA: 0x0001A5C6 File Offset: 0x000187C6
		public unsafe bool IsMixComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete)) = value;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0010D2D0 File Offset: 0x0010B4D0
		// (set) Token: 0x0600315E RID: 12638 RVA: 0x0001A5E1 File Offset: 0x000187E1
		public unsafe Il2CppReferenceArray<MixRecipeData> MixRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MixRecipeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600315F RID: 12639 RVA: 0x0010D300 File Offset: 0x0010B500
		// (set) Token: 0x06003160 RID: 12640 RVA: 0x0001A600 File Offset: 0x00018800
		public unsafe Il2CppReferenceArray<StringIntPair> ProductPrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x0010D330 File Offset: 0x0010B530
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x0001A61F File Offset: 0x0001881F
		public unsafe Il2CppStringArray FavouritedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_DiscoveredProducts;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_ListedProducts;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMixOperation;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeFieldInfoPtr_IsMixComplete;

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_MixRecipes;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrices;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedProducts;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_0;
	}
}
