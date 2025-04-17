using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069D RID: 1693
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x060096E3 RID: 38627 RVA: 0x00269B2C File Offset: 0x00267D2C
		// Note: this type is marked as 'beforefieldinit'.
		static CounterOfferProductSelector()
		{
			Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterOfferProductSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr);
			CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ENTRIES_PER_PAGE");
			CounterOfferProductSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "Container");
			CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "SearchBar");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductContainer");
			CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "PageLabel");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductEntryPrefab");
			CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductPreviewed");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductSelected");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntries");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntriesDict");
			CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "searchTerm");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageIndex");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageCount");
			CounterOfferProductSelector.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "results");
			CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "lastPreviewedResult");
			CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681926);
			CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681927);
			CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681928);
			CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681929);
			CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681930);
			CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681931);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681932);
			CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681933);
			CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681934);
			CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681935);
			CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681936);
			CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681937);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681938);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681939);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681940);
			CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681941);
			CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100681942);
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x00269DF0 File Offset: 0x00267FF0
		// (set) Token: 0x060096E5 RID: 38629 RVA: 0x00269E2C File Offset: 0x0026802C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50979, RefRangeEnd = 50982, XrefRangeStart = 50979, XrefRangeEnd = 50982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060096E6 RID: 38630 RVA: 0x00269E6C File Offset: 0x0026806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270018, XrefRangeEnd = 270028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x00269EA0 File Offset: 0x002680A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270028, XrefRangeEnd = 270047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x00269ED4 File Offset: 0x002680D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270047, XrefRangeEnd = 270050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096E9 RID: 38633 RVA: 0x00269F08 File Offset: 0x00268108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270050, XrefRangeEnd = 270059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096EA RID: 38634 RVA: 0x00269F3C File Offset: 0x0026813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270059, XrefRangeEnd = 270071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSearchTerm(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x00269F80 File Offset: 0x00268180
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270107, RefRangeEnd = 270110, XrefRangeStart = 270071, XrefRangeEnd = 270107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildResultsList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x00269FB4 File Offset: 0x002681B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270205, RefRangeEnd = 270206, XrefRangeStart = 270110, XrefRangeEnd = 270205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x0026A004 File Offset: 0x00268204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270228, RefRangeEnd = 270230, XrefRangeStart = 270206, XrefRangeEnd = 270228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureAllEntriesExist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x0026A038 File Offset: 0x00268238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270292, RefRangeEnd = 270293, XrefRangeStart = 270230, XrefRangeEnd = 270292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateProductEntry(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x0026A07C File Offset: 0x0026827C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270293, XrefRangeEnd = 270294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePage(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x0026A0BC File Offset: 0x002682BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270362, RefRangeEnd = 270364, XrefRangeStart = 270294, XrefRangeEnd = 270362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPage(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref page;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x0026A0FC File Offset: 0x002682FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270364, XrefRangeEnd = 270365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductHovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x0026A140 File Offset: 0x00268340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270368, RefRangeEnd = 270369, XrefRangeStart = 270365, XrefRangeEnd = 270368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductSelected(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x0026A184 File Offset: 0x00268384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270369, XrefRangeEnd = 270391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x0026A1C0 File Offset: 0x002683C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270391, XrefRangeEnd = 270416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterOfferProductSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x0004949F File Offset: 0x0004769F
		public CounterOfferProductSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x060096F6 RID: 38646 RVA: 0x0026A1FC File Offset: 0x002683FC
		// (set) Token: 0x060096F7 RID: 38647 RVA: 0x000494A8 File Offset: 0x000476A8
		public unsafe static int ENTRIES_PER_PAGE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&value));
			}
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x060096F8 RID: 38648 RVA: 0x0026A218 File Offset: 0x00268418
		// (set) Token: 0x060096F9 RID: 38649 RVA: 0x000494B6 File Offset: 0x000476B6
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x060096FA RID: 38650 RVA: 0x0026A248 File Offset: 0x00268448
		// (set) Token: 0x060096FB RID: 38651 RVA: 0x000494D5 File Offset: 0x000476D5
		public unsafe InputField SearchBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x060096FC RID: 38652 RVA: 0x0026A278 File Offset: 0x00268478
		// (set) Token: 0x060096FD RID: 38653 RVA: 0x000494F4 File Offset: 0x000476F4
		public unsafe RectTransform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x060096FE RID: 38654 RVA: 0x0026A2A8 File Offset: 0x002684A8
		// (set) Token: 0x060096FF RID: 38655 RVA: 0x00049513 File Offset: 0x00047713
		public unsafe Text PageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x06009700 RID: 38656 RVA: 0x0026A2D8 File Offset: 0x002684D8
		// (set) Token: 0x06009701 RID: 38657 RVA: 0x00049532 File Offset: 0x00047732
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x06009702 RID: 38658 RVA: 0x0026A308 File Offset: 0x00268508
		// (set) Token: 0x06009703 RID: 38659 RVA: 0x00049551 File Offset: 0x00047751
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06009704 RID: 38660 RVA: 0x0026A330 File Offset: 0x00268530
		// (set) Token: 0x06009705 RID: 38661 RVA: 0x0004956C File Offset: 0x0004776C
		public unsafe Action<ProductDefinition> onProductPreviewed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x06009706 RID: 38662 RVA: 0x0026A360 File Offset: 0x00268560
		// (set) Token: 0x06009707 RID: 38663 RVA: 0x0004958B File Offset: 0x0004778B
		public unsafe Action<ProductDefinition> onProductSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x06009708 RID: 38664 RVA: 0x0026A390 File Offset: 0x00268590
		// (set) Token: 0x06009709 RID: 38665 RVA: 0x000495AA File Offset: 0x000477AA
		public unsafe List<RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600970A RID: 38666 RVA: 0x0026A3C0 File Offset: 0x002685C0
		// (set) Token: 0x0600970B RID: 38667 RVA: 0x000495C9 File Offset: 0x000477C9
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntriesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x0026A3F0 File Offset: 0x002685F0
		// (set) Token: 0x0600970D RID: 38669 RVA: 0x000495E8 File Offset: 0x000477E8
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x0026A418 File Offset: 0x00268618
		// (set) Token: 0x0600970F RID: 38671 RVA: 0x00049607 File Offset: 0x00047807
		public unsafe int pageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex)) = value;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x06009710 RID: 38672 RVA: 0x0026A440 File Offset: 0x00268640
		// (set) Token: 0x06009711 RID: 38673 RVA: 0x00049622 File Offset: 0x00047822
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x06009712 RID: 38674 RVA: 0x0026A468 File Offset: 0x00268668
		// (set) Token: 0x06009713 RID: 38675 RVA: 0x0004963D File Offset: 0x0004783D
		public unsafe List<ProductDefinition> results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x06009714 RID: 38676 RVA: 0x0026A498 File Offset: 0x00268698
		// (set) Token: 0x06009715 RID: 38677 RVA: 0x0004965C File Offset: 0x0004785C
		public unsafe ProductDefinition lastPreviewedResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065B0 RID: 26032
		private static readonly IntPtr NativeFieldInfoPtr_ENTRIES_PER_PAGE;

		// Token: 0x040065B1 RID: 26033
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065B2 RID: 26034
		private static readonly IntPtr NativeFieldInfoPtr_SearchBar;

		// Token: 0x040065B3 RID: 26035
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x040065B4 RID: 26036
		private static readonly IntPtr NativeFieldInfoPtr_PageLabel;

		// Token: 0x040065B5 RID: 26037
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x040065B6 RID: 26038
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040065B7 RID: 26039
		private static readonly IntPtr NativeFieldInfoPtr_onProductPreviewed;

		// Token: 0x040065B8 RID: 26040
		private static readonly IntPtr NativeFieldInfoPtr_onProductSelected;

		// Token: 0x040065B9 RID: 26041
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x040065BA RID: 26042
		private static readonly IntPtr NativeFieldInfoPtr_productEntriesDict;

		// Token: 0x040065BB RID: 26043
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x040065BC RID: 26044
		private static readonly IntPtr NativeFieldInfoPtr_pageIndex;

		// Token: 0x040065BD RID: 26045
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x040065BE RID: 26046
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x040065BF RID: 26047
		private static readonly IntPtr NativeFieldInfoPtr_lastPreviewedResult;

		// Token: 0x040065C0 RID: 26048
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040065C1 RID: 26049
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065C2 RID: 26050
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040065C3 RID: 26051
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040065C4 RID: 26052
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065C5 RID: 26053
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040065C6 RID: 26054
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0;

		// Token: 0x040065C7 RID: 26055
		private static readonly IntPtr NativeMethodInfoPtr_RebuildResultsList_Private_Void_0;

		// Token: 0x040065C8 RID: 26056
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0;

		// Token: 0x040065C9 RID: 26057
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0;

		// Token: 0x040065CA RID: 26058
		private static readonly IntPtr NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040065CB RID: 26059
		private static readonly IntPtr NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0;

		// Token: 0x040065CC RID: 26060
		private static readonly IntPtr NativeMethodInfoPtr_SetPage_Private_Void_Int32_0;

		// Token: 0x040065CD RID: 26061
		private static readonly IntPtr NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0;

		// Token: 0x040065CE RID: 26062
		private static readonly IntPtr NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0;

		// Token: 0x040065CF RID: 26063
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0;

		// Token: 0x040065D0 RID: 26064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA4B RID: 55883 RVA: 0x0033BEE8 File Offset: 0x0033A0E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr);
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9");
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9__24_0");
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100681944);
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100681945);
			}

			// Token: 0x0600DA4C RID: 55884 RVA: 0x0033BF64 File Offset: 0x0033A164
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4D RID: 55885 RVA: 0x0033BFA0 File Offset: 0x0033A1A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270005, XrefRangeEnd = 270013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RebuildResultsList_b__24_0(ProductDefinition a, ProductDefinition b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA4E RID: 55886 RVA: 0x0006A4AE File Offset: 0x000686AE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B7 RID: 17335
			// (get) Token: 0x0600DA4F RID: 55887 RVA: 0x0033C000 File Offset: 0x0033A200
			// (set) Token: 0x0600DA50 RID: 55888 RVA: 0x0006A4B7 File Offset: 0x000686B7
			public unsafe static CounterOfferProductSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B8 RID: 17336
			// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x0033C028 File Offset: 0x0033A228
			// (set) Token: 0x0600DA52 RID: 55890 RVA: 0x0006A4C9 File Offset: 0x000686C9
			public unsafe static Comparison<ProductDefinition> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400928C RID: 37516
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400928D RID: 37517
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400928E RID: 37518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400928F RID: 37519
			private static readonly IntPtr NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0;
		}

		// Token: 0x02000B61 RID: 2913
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA53 RID: 55891 RVA: 0x0033C050 File Offset: 0x0033A250
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "product");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681946);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681947);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100681948);
			}

			// Token: 0x0600DA54 RID: 55892 RVA: 0x0033C0E0 File Offset: 0x0033A2E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA55 RID: 55893 RVA: 0x0033C11C File Offset: 0x0033A31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270013, XrefRangeEnd = 270016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA56 RID: 55894 RVA: 0x0033C150 File Offset: 0x0033A350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270016, XrefRangeEnd = 270018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA57 RID: 55895 RVA: 0x0006A4DB File Offset: 0x000686DB
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B9 RID: 17337
			// (get) Token: 0x0600DA58 RID: 55896 RVA: 0x0033C194 File Offset: 0x0033A394
			// (set) Token: 0x0600DA59 RID: 55897 RVA: 0x0006A4E4 File Offset: 0x000686E4
			public unsafe CounterOfferProductSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BA RID: 17338
			// (get) Token: 0x0600DA5A RID: 55898 RVA: 0x0033C1C4 File Offset: 0x0033A3C4
			// (set) Token: 0x0600DA5B RID: 55899 RVA: 0x0006A503 File Offset: 0x00068703
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009290 RID: 37520
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009291 RID: 37521
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04009292 RID: 37522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009293 RID: 37523
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0;

			// Token: 0x04009294 RID: 37524
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
