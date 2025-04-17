using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A5 RID: 1445
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition
	{
		// Token: 0x06007E3E RID: 32318 RVA: 0x0021C574 File Offset: 0x0021A774
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDefinition()
		{
			Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr);
			ProductDefinition.NativeFieldInfoPtr_DrugTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "DrugTypes");
			ProductDefinition.NativeFieldInfoPtr_LawIntensityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "LawIntensityChange");
			ProductDefinition.NativeFieldInfoPtr_BasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BasePrice");
			ProductDefinition.NativeFieldInfoPtr_MarketValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "MarketValue");
			ProductDefinition.NativeFieldInfoPtr_FunctionalProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "FunctionalProduct");
			ProductDefinition.NativeFieldInfoPtr_EffectsDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "EffectsDuration");
			ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BaseAddictiveness");
			ProductDefinition.NativeFieldInfoPtr_ValidPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "ValidPackaging");
			ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<Recipes>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<HasChanged>k__BackingField");
			ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679084);
			ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679085);
			ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679086);
			ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679087);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679088);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679089);
			ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679090);
			ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679091);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679092);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679093);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679094);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679095);
			ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679096);
			ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679097);
			ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679098);
			ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679099);
			ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679100);
			ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679101);
			ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679102);
			ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679103);
			ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679104);
			ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679105);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679106);
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06007E3F RID: 32319 RVA: 0x0021C860 File Offset: 0x0021AA60
		public unsafe EDrugType DrugType
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 238896, RefRangeEnd = 238914, XrefRangeStart = 238893, XrefRangeEnd = 238896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06007E40 RID: 32320 RVA: 0x0021C89C File Offset: 0x0021AA9C
		public unsafe float Price
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 238920, RefRangeEnd = 238923, XrefRangeStart = 238914, XrefRangeEnd = 238920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06007E41 RID: 32321 RVA: 0x0021C8D8 File Offset: 0x0021AAD8
		// (set) Token: 0x06007E42 RID: 32322 RVA: 0x0021C918 File Offset: 0x0021AB18
		public unsafe List<StationRecipe> Recipes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x0021C95C File Offset: 0x0021AB5C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238923, XrefRangeEnd = 238924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06007E44 RID: 32324 RVA: 0x0021C994 File Offset: 0x0021AB94
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x0021C9CC File Offset: 0x0021ABCC
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06007E46 RID: 32326 RVA: 0x0021CA0C File Offset: 0x0021AC0C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x0021CA48 File Offset: 0x0021AC48
		// (set) Token: 0x06007E48 RID: 32328 RVA: 0x0021CA88 File Offset: 0x0021AC88
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x0021CACC File Offset: 0x0021ACCC
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x0021CB0C File Offset: 0x0021AD0C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06007E4B RID: 32331 RVA: 0x0021CB50 File Offset: 0x0021AD50
		// (set) Token: 0x06007E4C RID: 32332 RVA: 0x0021CB8C File Offset: 0x0021AD8C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x0021CBCC File Offset: 0x0021ADCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238924, XrefRangeEnd = 238928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x0021CC24 File Offset: 0x0021AE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238928, XrefRangeEnd = 238933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0021CC58 File Offset: 0x0021AE58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238962, RefRangeEnd = 238965, XrefRangeStart = 238933, XrefRangeEnd = 238962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0021CCAC File Offset: 0x0021AEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238965, XrefRangeEnd = 238971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0021CCE8 File Offset: 0x0021AEE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 238976, RefRangeEnd = 238980, XrefRangeStart = 238971, XrefRangeEnd = 238976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x0021CD24 File Offset: 0x0021AF24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238991, RefRangeEnd = 238994, XrefRangeStart = 238980, XrefRangeEnd = 238991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x0021CD58 File Offset: 0x0021AF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238994, XrefRangeEnd = 239006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x0021CD9C File Offset: 0x0021AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239006, XrefRangeEnd = 239024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x0021CDE0 File Offset: 0x0021AFE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239044, RefRangeEnd = 239047, XrefRangeStart = 239024, XrefRangeEnd = 239044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0003BFFC File Offset: 0x0003A1FC
		public ProductDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x0021CE1C File Offset: 0x0021B01C
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x0003C005 File Offset: 0x0003A205
		public unsafe List<DrugTypeContainer> DrugTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DrugTypeContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x0021CE4C File Offset: 0x0021B04C
		// (set) Token: 0x06007E5A RID: 32346 RVA: 0x0003C024 File Offset: 0x0003A224
		public unsafe float LawIntensityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange)) = value;
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007E5B RID: 32347 RVA: 0x0021CE74 File Offset: 0x0021B074
		// (set) Token: 0x06007E5C RID: 32348 RVA: 0x0003C03F File Offset: 0x0003A23F
		public unsafe float BasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice)) = value;
			}
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0021CE9C File Offset: 0x0021B09C
		// (set) Token: 0x06007E5E RID: 32350 RVA: 0x0003C05A File Offset: 0x0003A25A
		public unsafe float MarketValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue)) = value;
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x0021CEC4 File Offset: 0x0021B0C4
		// (set) Token: 0x06007E60 RID: 32352 RVA: 0x0003C075 File Offset: 0x0003A275
		public unsafe FunctionalProduct FunctionalProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x0021CEF4 File Offset: 0x0021B0F4
		// (set) Token: 0x06007E62 RID: 32354 RVA: 0x0003C094 File Offset: 0x0003A294
		public unsafe int EffectsDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration)) = value;
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0021CF1C File Offset: 0x0021B11C
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x0003C0AF File Offset: 0x0003A2AF
		public unsafe float BaseAddictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness)) = value;
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06007E65 RID: 32357 RVA: 0x0021CF44 File Offset: 0x0021B144
		// (set) Token: 0x06007E66 RID: 32358 RVA: 0x0003C0CA File Offset: 0x0003A2CA
		public unsafe Il2CppReferenceArray<PackagingDefinition> ValidPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06007E67 RID: 32359 RVA: 0x0021CF74 File Offset: 0x0021B174
		// (set) Token: 0x06007E68 RID: 32360 RVA: 0x0003C0E9 File Offset: 0x0003A2E9
		public unsafe List<StationRecipe> _Recipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06007E69 RID: 32361 RVA: 0x0021CFA4 File Offset: 0x0021B1A4
		// (set) Token: 0x06007E6A RID: 32362 RVA: 0x0003C108 File Offset: 0x0003A308
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06007E6B RID: 32363 RVA: 0x0021CFD4 File Offset: 0x0021B1D4
		// (set) Token: 0x06007E6C RID: 32364 RVA: 0x0003C127 File Offset: 0x0003A327
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06007E6D RID: 32365 RVA: 0x0021D004 File Offset: 0x0021B204
		// (set) Token: 0x06007E6E RID: 32366 RVA: 0x0003C146 File Offset: 0x0003A346
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x040055E8 RID: 21992
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypes;

		// Token: 0x040055E9 RID: 21993
		private static readonly IntPtr NativeFieldInfoPtr_LawIntensityChange;

		// Token: 0x040055EA RID: 21994
		private static readonly IntPtr NativeFieldInfoPtr_BasePrice;

		// Token: 0x040055EB RID: 21995
		private static readonly IntPtr NativeFieldInfoPtr_MarketValue;

		// Token: 0x040055EC RID: 21996
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalProduct;

		// Token: 0x040055ED RID: 21997
		private static readonly IntPtr NativeFieldInfoPtr_EffectsDuration;

		// Token: 0x040055EE RID: 21998
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddictiveness;

		// Token: 0x040055EF RID: 21999
		private static readonly IntPtr NativeFieldInfoPtr_ValidPackaging;

		// Token: 0x040055F0 RID: 22000
		private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

		// Token: 0x040055F1 RID: 22001
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040055F2 RID: 22002
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040055F3 RID: 22003
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040055F4 RID: 22004
		private static readonly IntPtr NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0;

		// Token: 0x040055F5 RID: 22005
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x040055F6 RID: 22006
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0;

		// Token: 0x040055F7 RID: 22007
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0;

		// Token: 0x040055F8 RID: 22008
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040055F9 RID: 22009
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040055FA RID: 22010
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040055FB RID: 22011
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040055FC RID: 22012
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040055FD RID: 22013
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040055FE RID: 22014
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040055FF RID: 22015
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005600 RID: 22016
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005601 RID: 22017
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04005602 RID: 22018
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005603 RID: 22019
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04005604 RID: 22020
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0;

		// Token: 0x04005605 RID: 22021
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04005606 RID: 22022
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Single_0;

		// Token: 0x04005607 RID: 22023
		private static readonly IntPtr NativeMethodInfoPtr_CleanRecipes_Public_Void_0;

		// Token: 0x04005608 RID: 22024
		private static readonly IntPtr NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04005609 RID: 22025
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400560A RID: 22026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
