using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006A7 RID: 1703
	public class ProductManagerApp : App<ProductManagerApp>
	{
		// Token: 0x06009875 RID: 39029 RVA: 0x0026E700 File Offset: 0x0026C900
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerApp()
		{
			Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductManagerApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr);
			ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "FavouritesContainer");
			ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "ProductTypeContainers");
			ProductManagerApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "DetailPanel");
			ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "SelectionIndicator");
			ProductManagerApp.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "EntryPrefab");
			ProductManagerApp.NativeFieldInfoPtr_favouriteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "favouriteEntries");
			ProductManagerApp.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "entries");
			ProductManagerApp.NativeFieldInfoPtr_selectedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "selectedEntry");
			ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682103);
			ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682104);
			ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682105);
			ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682106);
			ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682107);
			ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682108);
			ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682109);
			ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682110);
			ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682111);
			ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682112);
			ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682113);
			ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682114);
			ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682115);
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0026E8D4 File Offset: 0x0026CAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272133, XrefRangeEnd = 272138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0026E910 File Offset: 0x0026CB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272138, XrefRangeEnd = 272218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0026E94C File Offset: 0x0026CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272218, XrefRangeEnd = 272226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0026E980 File Offset: 0x0026CB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272226, XrefRangeEnd = 272267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0026E9D0 File Offset: 0x0026CBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272267, XrefRangeEnd = 272268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0026EA14 File Offset: 0x0026CC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272268, XrefRangeEnd = 272269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductUnfavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0026EA58 File Offset: 0x0026CC58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272303, RefRangeEnd = 272305, XrefRangeStart = 272269, XrefRangeEnd = 272303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0026EA9C File Offset: 0x0026CC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272339, RefRangeEnd = 272340, XrefRangeStart = 272305, XrefRangeEnd = 272339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x0026EAE0 File Offset: 0x0026CCE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272346, RefRangeEnd = 272348, XrefRangeStart = 272340, XrefRangeEnd = 272346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedRebuildLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600987F RID: 39039 RVA: 0x0026EB14 File Offset: 0x0026CD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272356, RefRangeEnd = 272357, XrefRangeStart = 272348, XrefRangeEnd = 272356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProduct(ProductEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x0026EB58 File Offset: 0x0026CD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272357, XrefRangeEnd = 272414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009881 RID: 39041 RVA: 0x0026EBA4 File Offset: 0x0026CDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272414, XrefRangeEnd = 272432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009882 RID: 39042 RVA: 0x0026EBE0 File Offset: 0x0026CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272432, XrefRangeEnd = 272437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009883 RID: 39043 RVA: 0x0004A3F8 File Offset: 0x000485F8
		public ProductManagerApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x06009884 RID: 39044 RVA: 0x0026EC20 File Offset: 0x0026CE20
		// (set) Token: 0x06009885 RID: 39045 RVA: 0x0004A401 File Offset: 0x00048601
		public unsafe ProductManagerApp.ProductTypeContainer FavouritesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp.ProductTypeContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x06009886 RID: 39046 RVA: 0x0026EC50 File Offset: 0x0026CE50
		// (set) Token: 0x06009887 RID: 39047 RVA: 0x0004A420 File Offset: 0x00048620
		public unsafe List<ProductManagerApp.ProductTypeContainer> ProductTypeContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductManagerApp.ProductTypeContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x06009888 RID: 39048 RVA: 0x0026EC80 File Offset: 0x0026CE80
		// (set) Token: 0x06009889 RID: 39049 RVA: 0x0004A43F File Offset: 0x0004863F
		public unsafe ProductAppDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductAppDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600988A RID: 39050 RVA: 0x0026ECB0 File Offset: 0x0026CEB0
		// (set) Token: 0x0600988B RID: 39051 RVA: 0x0004A45E File Offset: 0x0004865E
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600988C RID: 39052 RVA: 0x0026ECE0 File Offset: 0x0026CEE0
		// (set) Token: 0x0600988D RID: 39053 RVA: 0x0004A47D File Offset: 0x0004867D
		public unsafe GameObject EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600988E RID: 39054 RVA: 0x0026ED10 File Offset: 0x0026CF10
		// (set) Token: 0x0600988F RID: 39055 RVA: 0x0004A49C File Offset: 0x0004869C
		public unsafe List<ProductEntry> favouriteEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06009890 RID: 39056 RVA: 0x0026ED40 File Offset: 0x0026CF40
		// (set) Token: 0x06009891 RID: 39057 RVA: 0x0004A4BB File Offset: 0x000486BB
		public unsafe List<ProductEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06009892 RID: 39058 RVA: 0x0026ED70 File Offset: 0x0026CF70
		// (set) Token: 0x06009893 RID: 39059 RVA: 0x0004A4DA File Offset: 0x000486DA
		public unsafe ProductEntry selectedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066AD RID: 26285
		private static readonly IntPtr NativeFieldInfoPtr_FavouritesContainer;

		// Token: 0x040066AE RID: 26286
		private static readonly IntPtr NativeFieldInfoPtr_ProductTypeContainers;

		// Token: 0x040066AF RID: 26287
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x040066B0 RID: 26288
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040066B1 RID: 26289
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x040066B2 RID: 26290
		private static readonly IntPtr NativeFieldInfoPtr_favouriteEntries;

		// Token: 0x040066B3 RID: 26291
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040066B4 RID: 26292
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntry;

		// Token: 0x040066B5 RID: 26293
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040066B6 RID: 26294
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040066B7 RID: 26295
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040066B8 RID: 26296
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0;

		// Token: 0x040066B9 RID: 26297
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040066BA RID: 26298
		private static readonly IntPtr NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040066BB RID: 26299
		private static readonly IntPtr NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040066BC RID: 26300
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040066BD RID: 26301
		private static readonly IntPtr NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0;

		// Token: 0x040066BE RID: 26302
		private static readonly IntPtr NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0;

		// Token: 0x040066BF RID: 26303
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040066C0 RID: 26304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040066C1 RID: 26305
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B6D RID: 2925
		[Serializable]
		public class ProductTypeContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DAE2 RID: 56034 RVA: 0x0033D8F0 File Offset: 0x0033BAF0
			// Note: this type is marked as 'beforefieldinit'.
			static ProductTypeContainer()
			{
				Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "ProductTypeContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr);
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "DrugType");
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "Container");
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "NoneDisplay");
				ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, 100682116);
				ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, 100682117);
			}

			// Token: 0x0600DAE3 RID: 56035 RVA: 0x0033D980 File Offset: 0x0033BB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272085, XrefRangeEnd = 272089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RefreshNoneDisplay()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE4 RID: 56036 RVA: 0x0033D9B4 File Offset: 0x0033BBB4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAE5 RID: 56037 RVA: 0x0006A9D9 File Offset: 0x00068BD9
			public ProductTypeContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043EA RID: 17386
			// (get) Token: 0x0600DAE6 RID: 56038 RVA: 0x0033D9F0 File Offset: 0x0033BBF0
			// (set) Token: 0x0600DAE7 RID: 56039 RVA: 0x0006A9E2 File Offset: 0x00068BE2
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170043EB RID: 17387
			// (get) Token: 0x0600DAE8 RID: 56040 RVA: 0x0033DA18 File Offset: 0x0033BC18
			// (set) Token: 0x0600DAE9 RID: 56041 RVA: 0x0006A9FD File Offset: 0x00068BFD
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EC RID: 17388
			// (get) Token: 0x0600DAEA RID: 56042 RVA: 0x0033DA48 File Offset: 0x0033BC48
			// (set) Token: 0x0600DAEB RID: 56043 RVA: 0x0006AA1C File Offset: 0x00068C1C
			public unsafe RectTransform NoneDisplay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092E0 RID: 37600
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x040092E1 RID: 37601
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x040092E2 RID: 37602
			private static readonly IntPtr NativeFieldInfoPtr_NoneDisplay;

			// Token: 0x040092E3 RID: 37603
			private static readonly IntPtr NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0;

			// Token: 0x040092E4 RID: 37604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B6E RID: 2926
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<<DelayedRebuildLayout>g__Delay|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DAEC RID: 56044 RVA: 0x0033DA78 File Offset: 0x0033BC78
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<<DelayedRebuildLayout>g__Delay|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682118);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682119);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682120);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682121);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682122);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682123);
			}

			// Token: 0x0600DAED RID: 56045 RVA: 0x0033DB58 File Offset: 0x0033BD58
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEE RID: 56046 RVA: 0x0033DBA0 File Offset: 0x0033BDA0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAEF RID: 56047 RVA: 0x0033DBD4 File Offset: 0x0033BDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272089, XrefRangeEnd = 272102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043F0 RID: 17392
			// (get) Token: 0x0600DAF0 RID: 56048 RVA: 0x0033DC10 File Offset: 0x0033BE10
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAF1 RID: 56049 RVA: 0x0033DC50 File Offset: 0x0033BE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272102, XrefRangeEnd = 272107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043F1 RID: 17393
			// (get) Token: 0x0600DAF2 RID: 56050 RVA: 0x0033DC84 File Offset: 0x0033BE84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DAF3 RID: 56051 RVA: 0x0006AA3B File Offset: 0x00068C3B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043ED RID: 17389
			// (get) Token: 0x0600DAF4 RID: 56052 RVA: 0x0033DCC4 File Offset: 0x0033BEC4
			// (set) Token: 0x0600DAF5 RID: 56053 RVA: 0x0006AA44 File Offset: 0x00068C44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043EE RID: 17390
			// (get) Token: 0x0600DAF6 RID: 56054 RVA: 0x0033DCEC File Offset: 0x0033BEEC
			// (set) Token: 0x0600DAF7 RID: 56055 RVA: 0x0006AA5F File Offset: 0x00068C5F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EF RID: 17391
			// (get) Token: 0x0600DAF8 RID: 56056 RVA: 0x0033DD1C File Offset: 0x0033BF1C
			// (set) Token: 0x0600DAF9 RID: 56057 RVA: 0x0006AA7E File Offset: 0x00068C7E
			public unsafe ProductManagerApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092E5 RID: 37605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092E6 RID: 37606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092E7 RID: 37607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092E8 RID: 37608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092E9 RID: 37609
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092EA RID: 37610
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092EB RID: 37611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092EC RID: 37612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092ED RID: 37613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6F RID: 2927
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAFA RID: 56058 RVA: 0x0033DD4C File Offset: 0x0033BF4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, 100682124);
				ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, 100682125);
			}

			// Token: 0x0600DAFB RID: 56059 RVA: 0x0033DDB4 File Offset: 0x0033BFB4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DAFC RID: 56060 RVA: 0x0033DDF0 File Offset: 0x0033BFF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272107, XrefRangeEnd = 272110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateEntry_b__0(ProductManagerApp.ProductTypeContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DAFD RID: 56061 RVA: 0x0006AA9D File Offset: 0x00068C9D
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F2 RID: 17394
			// (get) Token: 0x0600DAFE RID: 56062 RVA: 0x0033DE40 File Offset: 0x0033C040
			// (set) Token: 0x0600DAFF RID: 56063 RVA: 0x0006AAA6 File Offset: 0x00068CA6
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092EE RID: 37614
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x040092EF RID: 37615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092F0 RID: 37616
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0;
		}

		// Token: 0x02000B70 RID: 2928
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB00 RID: 56064 RVA: 0x0033DE70 File Offset: 0x0033C070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, 100682126);
				ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, 100682127);
			}

			// Token: 0x0600DB01 RID: 56065 RVA: 0x0033DED8 File Offset: 0x0033C0D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB02 RID: 56066 RVA: 0x0033DF14 File Offset: 0x0033C114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272110, XrefRangeEnd = 272115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB03 RID: 56067 RVA: 0x0006AAC5 File Offset: 0x00068CC5
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F3 RID: 17395
			// (get) Token: 0x0600DB04 RID: 56068 RVA: 0x0033DF64 File Offset: 0x0033C164
			// (set) Token: 0x0600DB05 RID: 56069 RVA: 0x0006AACE File Offset: 0x00068CCE
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092F1 RID: 37617
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x040092F2 RID: 37618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092F3 RID: 37619
			private static readonly IntPtr NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}

		// Token: 0x02000B71 RID: 2929
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB06 RID: 56070 RVA: 0x0033DF94 File Offset: 0x0033C194
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, 100682128);
				ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, 100682129);
			}

			// Token: 0x0600DB07 RID: 56071 RVA: 0x0033DFFC File Offset: 0x0033C1FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB08 RID: 56072 RVA: 0x0033E038 File Offset: 0x0033C238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272115, XrefRangeEnd = 272120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DB09 RID: 56073 RVA: 0x0006AAED File Offset: 0x00068CED
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F4 RID: 17396
			// (get) Token: 0x0600DB0A RID: 56074 RVA: 0x0033E088 File Offset: 0x0033C288
			// (set) Token: 0x0600DB0B RID: 56075 RVA: 0x0006AAF6 File Offset: 0x00068CF6
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092F4 RID: 37620
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x040092F5 RID: 37621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092F6 RID: 37622
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}

		// Token: 0x02000B72 RID: 2930
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB0C RID: 56076 RVA: 0x0033E0B8 File Offset: 0x0033C2B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "layoutGroups");
				ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, 100682130);
				ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, 100682131);
			}

			// Token: 0x0600DB0D RID: 56077 RVA: 0x0033E134 File Offset: 0x0033C334
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB0E RID: 56078 RVA: 0x0033E170 File Offset: 0x0033C370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272128, XrefRangeEnd = 272133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB0F RID: 56079 RVA: 0x0006AB15 File Offset: 0x00068D15
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F5 RID: 17397
			// (get) Token: 0x0600DB10 RID: 56080 RVA: 0x0033E1B0 File Offset: 0x0033C3B0
			// (set) Token: 0x0600DB11 RID: 56081 RVA: 0x0006AB1E File Offset: 0x00068D1E
			public unsafe ProductManagerApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F6 RID: 17398
			// (get) Token: 0x0600DB12 RID: 56082 RVA: 0x0033E1E0 File Offset: 0x0033C3E0
			// (set) Token: 0x0600DB13 RID: 56083 RVA: 0x0006AB3D File Offset: 0x00068D3D
			public unsafe Il2CppReferenceArray<VerticalLayoutGroup> layoutGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VerticalLayoutGroup>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092F7 RID: 37623
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092F8 RID: 37624
			private static readonly IntPtr NativeFieldInfoPtr_layoutGroups;

			// Token: 0x040092F9 RID: 37625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092FA RID: 37626
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7B RID: 3195
			[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass19_0+<<SetOpen>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E60A RID: 58890 RVA: 0x0035D97C File Offset: 0x0035BB7C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "<<SetOpen>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682132);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682133);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682134);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682135);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682136);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682137);
				}

				// Token: 0x0600E60B RID: 58891 RVA: 0x0035DA5C File Offset: 0x0035BC5C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E60C RID: 58892 RVA: 0x0035DAA4 File Offset: 0x0035BCA4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E60D RID: 58893 RVA: 0x0035DAD8 File Offset: 0x0035BCD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272120, XrefRangeEnd = 272123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004799 RID: 18329
				// (get) Token: 0x0600E60E RID: 58894 RVA: 0x0035DB14 File Offset: 0x0035BD14
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E60F RID: 58895 RVA: 0x0035DB54 File Offset: 0x0035BD54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272123, XrefRangeEnd = 272128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700479A RID: 18330
				// (get) Token: 0x0600E610 RID: 58896 RVA: 0x0035DB88 File Offset: 0x0035BD88
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E611 RID: 58897 RVA: 0x0007044D File Offset: 0x0006E64D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004796 RID: 18326
				// (get) Token: 0x0600E612 RID: 58898 RVA: 0x0035DBC8 File Offset: 0x0035BDC8
				// (set) Token: 0x0600E613 RID: 58899 RVA: 0x00070456 File Offset: 0x0006E656
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004797 RID: 18327
				// (get) Token: 0x0600E614 RID: 58900 RVA: 0x0035DBF0 File Offset: 0x0035BDF0
				// (set) Token: 0x0600E615 RID: 58901 RVA: 0x00070471 File Offset: 0x0006E671
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004798 RID: 18328
				// (get) Token: 0x0600E616 RID: 58902 RVA: 0x0035DC20 File Offset: 0x0035BE20
				// (set) Token: 0x0600E617 RID: 58903 RVA: 0x00070490 File Offset: 0x0006E690
				public unsafe ProductManagerApp.__c__DisplayClass19_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040099C5 RID: 39365
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099C6 RID: 39366
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099C7 RID: 39367
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099C8 RID: 39368
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099C9 RID: 39369
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099CA RID: 39370
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099CB RID: 39371
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099CC RID: 39372
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099CD RID: 39373
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
