using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006A6 RID: 1702
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x0600983F RID: 38975 RVA: 0x0026DDD0 File Offset: 0x0026BFD0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductAppDetailPanel()
		{
			Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductAppDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr);
			ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "<ActiveProduct>k__BackingField");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Min");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Max");
			ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NothingSelected");
			ProductAppDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Container");
			ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NameLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ValueLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "SuggestedPriceLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ListedForSale");
			ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "DescLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "PropertyLabels");
			ProductAppDetailPanel.NativeFieldInfoPtr_Listed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Listed");
			ProductAppDetailPanel.NativeFieldInfoPtr_Delisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Delisted");
			ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NotDiscovered");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipesLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipeEntries");
			ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "LayoutGroup");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionSlider");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ScrollRect");
			ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682091);
			ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682092);
			ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682093);
			ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682094);
			ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682095);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682096);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682097);
			ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682098);
			ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682099);
			ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682100);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682101);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682102);
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x06009840 RID: 38976 RVA: 0x0026E080 File Offset: 0x0026C280
		// (set) Token: 0x06009841 RID: 38977 RVA: 0x0026E0C0 File Offset: 0x0026C2C0
		public unsafe ProductDefinition ActiveProduct
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x0026E104 File Offset: 0x0026C304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271788, XrefRangeEnd = 271807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0026E138 File Offset: 0x0026C338
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272002, RefRangeEnd = 272006, XrefRangeStart = 271807, XrefRangeEnd = 272002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveProduct(ProductDefinition productDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x0026E17C File Offset: 0x0026C37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272006, XrefRangeEnd = 272012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x0026E1B0 File Offset: 0x0026C3B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272021, RefRangeEnd = 272024, XrefRangeStart = 272012, XrefRangeEnd = 272021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009846 RID: 38982 RVA: 0x0026E1E4 File Offset: 0x0026C3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272031, RefRangeEnd = 272033, XrefRangeStart = 272024, XrefRangeEnd = 272031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009847 RID: 38983 RVA: 0x0026E218 File Offset: 0x0026C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272033, XrefRangeEnd = 272058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingToggled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x0026E24C File Offset: 0x0026C44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272083, RefRangeEnd = 272084, XrefRangeStart = 272058, XrefRangeEnd = 272083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009849 RID: 38985 RVA: 0x0026E290 File Offset: 0x0026C490
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductAppDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x0026E2CC File Offset: 0x0026C4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_0(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x0026E30C File Offset: 0x0026C50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272084, XrefRangeEnd = 272085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_1(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600984C RID: 38988 RVA: 0x0004A18B File Offset: 0x0004838B
		public ProductAppDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600984D RID: 38989 RVA: 0x0026E350 File Offset: 0x0026C550
		// (set) Token: 0x0600984E RID: 38990 RVA: 0x0004A194 File Offset: 0x00048394
		public unsafe ProductDefinition _ActiveProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600984F RID: 38991 RVA: 0x0026E380 File Offset: 0x0026C580
		// (set) Token: 0x06009850 RID: 38992 RVA: 0x0004A1B3 File Offset: 0x000483B3
		public unsafe Color AddictionColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min)) = value;
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x06009851 RID: 38993 RVA: 0x0026E3A8 File Offset: 0x0026C5A8
		// (set) Token: 0x06009852 RID: 38994 RVA: 0x0004A1CE File Offset: 0x000483CE
		public unsafe Color AddictionColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max)) = value;
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x06009853 RID: 38995 RVA: 0x0026E3D0 File Offset: 0x0026C5D0
		// (set) Token: 0x06009854 RID: 38996 RVA: 0x0004A1E9 File Offset: 0x000483E9
		public unsafe GameObject NothingSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x06009855 RID: 38997 RVA: 0x0026E400 File Offset: 0x0026C600
		// (set) Token: 0x06009856 RID: 38998 RVA: 0x0004A208 File Offset: 0x00048408
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06009857 RID: 38999 RVA: 0x0026E430 File Offset: 0x0026C630
		// (set) Token: 0x06009858 RID: 39000 RVA: 0x0004A227 File Offset: 0x00048427
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06009859 RID: 39001 RVA: 0x0026E460 File Offset: 0x0026C660
		// (set) Token: 0x0600985A RID: 39002 RVA: 0x0004A246 File Offset: 0x00048446
		public unsafe InputField ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600985B RID: 39003 RVA: 0x0026E490 File Offset: 0x0026C690
		// (set) Token: 0x0600985C RID: 39004 RVA: 0x0004A265 File Offset: 0x00048465
		public unsafe Text SuggestedPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600985D RID: 39005 RVA: 0x0026E4C0 File Offset: 0x0026C6C0
		// (set) Token: 0x0600985E RID: 39006 RVA: 0x0004A284 File Offset: 0x00048484
		public unsafe Toggle ListedForSale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600985F RID: 39007 RVA: 0x0026E4F0 File Offset: 0x0026C6F0
		// (set) Token: 0x06009860 RID: 39008 RVA: 0x0004A2A3 File Offset: 0x000484A3
		public unsafe Text DescLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x06009861 RID: 39009 RVA: 0x0026E520 File Offset: 0x0026C720
		// (set) Token: 0x06009862 RID: 39010 RVA: 0x0004A2C2 File Offset: 0x000484C2
		public unsafe Il2CppReferenceArray<Text> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x06009863 RID: 39011 RVA: 0x0026E550 File Offset: 0x0026C750
		// (set) Token: 0x06009864 RID: 39012 RVA: 0x0004A2E1 File Offset: 0x000484E1
		public unsafe RectTransform Listed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x06009865 RID: 39013 RVA: 0x0026E580 File Offset: 0x0026C780
		// (set) Token: 0x06009866 RID: 39014 RVA: 0x0004A300 File Offset: 0x00048500
		public unsafe RectTransform Delisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x0026E5B0 File Offset: 0x0026C7B0
		// (set) Token: 0x06009868 RID: 39016 RVA: 0x0004A31F File Offset: 0x0004851F
		public unsafe RectTransform NotDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x0026E5E0 File Offset: 0x0026C7E0
		// (set) Token: 0x0600986A RID: 39018 RVA: 0x0004A33E File Offset: 0x0004853E
		public unsafe RectTransform RecipesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600986B RID: 39019 RVA: 0x0026E610 File Offset: 0x0026C810
		// (set) Token: 0x0600986C RID: 39020 RVA: 0x0004A35D File Offset: 0x0004855D
		public unsafe Il2CppReferenceArray<RectTransform> RecipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600986D RID: 39021 RVA: 0x0026E640 File Offset: 0x0026C840
		// (set) Token: 0x0600986E RID: 39022 RVA: 0x0004A37C File Offset: 0x0004857C
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x0026E670 File Offset: 0x0026C870
		// (set) Token: 0x06009870 RID: 39024 RVA: 0x0004A39B File Offset: 0x0004859B
		public unsafe Scrollbar AddictionSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0026E6A0 File Offset: 0x0026C8A0
		// (set) Token: 0x06009872 RID: 39026 RVA: 0x0004A3BA File Offset: 0x000485BA
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x06009873 RID: 39027 RVA: 0x0026E6D0 File Offset: 0x0026C8D0
		// (set) Token: 0x06009874 RID: 39028 RVA: 0x0004A3D9 File Offset: 0x000485D9
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400668D RID: 26253
		private static readonly IntPtr NativeFieldInfoPtr__ActiveProduct_k__BackingField;

		// Token: 0x0400668E RID: 26254
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Min;

		// Token: 0x0400668F RID: 26255
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Max;

		// Token: 0x04006690 RID: 26256
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelected;

		// Token: 0x04006691 RID: 26257
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006692 RID: 26258
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006693 RID: 26259
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006694 RID: 26260
		private static readonly IntPtr NativeFieldInfoPtr_SuggestedPriceLabel;

		// Token: 0x04006695 RID: 26261
		private static readonly IntPtr NativeFieldInfoPtr_ListedForSale;

		// Token: 0x04006696 RID: 26262
		private static readonly IntPtr NativeFieldInfoPtr_DescLabel;

		// Token: 0x04006697 RID: 26263
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04006698 RID: 26264
		private static readonly IntPtr NativeFieldInfoPtr_Listed;

		// Token: 0x04006699 RID: 26265
		private static readonly IntPtr NativeFieldInfoPtr_Delisted;

		// Token: 0x0400669A RID: 26266
		private static readonly IntPtr NativeFieldInfoPtr_NotDiscovered;

		// Token: 0x0400669B RID: 26267
		private static readonly IntPtr NativeFieldInfoPtr_RecipesLabel;

		// Token: 0x0400669C RID: 26268
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntries;

		// Token: 0x0400669D RID: 26269
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x0400669E RID: 26270
		private static readonly IntPtr NativeFieldInfoPtr_AddictionSlider;

		// Token: 0x0400669F RID: 26271
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x040066A0 RID: 26272
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x040066A1 RID: 26273
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0;

		// Token: 0x040066A2 RID: 26274
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0;

		// Token: 0x040066A3 RID: 26275
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040066A4 RID: 26276
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0;

		// Token: 0x040066A5 RID: 26277
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040066A6 RID: 26278
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Private_Void_0;

		// Token: 0x040066A7 RID: 26279
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x040066A8 RID: 26280
		private static readonly IntPtr NativeMethodInfoPtr_ListingToggled_Private_Void_0;

		// Token: 0x040066A9 RID: 26281
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0;

		// Token: 0x040066AA RID: 26282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040066AB RID: 26283
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0;

		// Token: 0x040066AC RID: 26284
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0;
	}
}
