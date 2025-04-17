using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074A RID: 1866
	[Serializable]
	public class OvenCookOperation : Object
	{
		// Token: 0x0600AF1A RID: 44826 RVA: 0x002BAB68 File Offset: 0x002B8D68
		// Note: this type is marked as 'beforefieldinit'.
		static OvenCookOperation()
		{
			Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "OvenCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr);
			OvenCookOperation.NativeFieldInfoPtr__itemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_itemDefinition");
			OvenCookOperation.NativeFieldInfoPtr__productionDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_productionDefinition");
			OvenCookOperation.NativeFieldInfoPtr__cookable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_cookable");
			OvenCookOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientID");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuality");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuantity");
			OvenCookOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "ProductID");
			OvenCookOperation.NativeFieldInfoPtr_CookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "CookProgress");
			OvenCookOperation.NativeFieldInfoPtr_cookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "cookDuration");
			OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684814);
			OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684815);
			OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684816);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684817);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684818);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684819);
			OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684820);
			OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684821);
			OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684822);
			OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100684823);
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600AF1B RID: 44827 RVA: 0x002BAD14 File Offset: 0x002B8F14
		public unsafe StorableItemDefinition Ingredient
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 302231, RefRangeEnd = 302238, XrefRangeStart = 302219, XrefRangeEnd = 302231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x002BAD54 File Offset: 0x002B8F54
		public unsafe StorableItemDefinition Product
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 302250, RefRangeEnd = 302253, XrefRangeStart = 302238, XrefRangeEnd = 302250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x002BAD94 File Offset: 0x002B8F94
		public unsafe CookableModule Cookable
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 302262, RefRangeEnd = 302268, XrefRangeStart = 302253, XrefRangeEnd = 302262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr3) : null;
			}
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x002BADD4 File Offset: 0x002B8FD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302271, RefRangeEnd = 302274, XrefRangeStart = 302268, XrefRangeEnd = 302271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x002BAE50 File Offset: 0x002B9050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302277, RefRangeEnd = 302278, XrefRangeStart = 302274, XrefRangeEnd = 302277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x002BAED8 File Offset: 0x002B90D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302279, RefRangeEnd = 302280, XrefRangeStart = 302278, XrefRangeEnd = 302279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x002BAF14 File Offset: 0x002B9114
		[CallerCount(0)]
		public unsafe void UpdateCookProgress(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x002BAF54 File Offset: 0x002B9154
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 302284, RefRangeEnd = 302292, XrefRangeStart = 302280, XrefRangeEnd = 302284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x002BAF90 File Offset: 0x002B9190
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302307, RefRangeEnd = 302310, XrefRangeStart = 302292, XrefRangeEnd = 302307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetProductItem(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x002BAFDC File Offset: 0x002B91DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302314, RefRangeEnd = 302315, XrefRangeStart = 302310, XrefRangeEnd = 302314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x00056127 File Offset: 0x00054327
		public OvenCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x002BB018 File Offset: 0x002B9218
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x00056130 File Offset: 0x00054330
		public unsafe StorableItemDefinition _itemDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x002BB048 File Offset: 0x002B9248
		// (set) Token: 0x0600AF29 RID: 44841 RVA: 0x0005614F File Offset: 0x0005434F
		public unsafe StorableItemDefinition _productionDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x002BB078 File Offset: 0x002B9278
		// (set) Token: 0x0600AF2B RID: 44843 RVA: 0x0005616E File Offset: 0x0005436E
		public unsafe CookableModule _cookable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600AF2C RID: 44844 RVA: 0x002BB0A8 File Offset: 0x002B92A8
		// (set) Token: 0x0600AF2D RID: 44845 RVA: 0x0005618D File Offset: 0x0005438D
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x002BB0D0 File Offset: 0x002B92D0
		// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x000561AC File Offset: 0x000543AC
		public unsafe EQuality IngredientQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality)) = value;
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x002BB0F8 File Offset: 0x002B92F8
		// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x000561C7 File Offset: 0x000543C7
		public unsafe int IngredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity)) = value;
			}
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600AF32 RID: 44850 RVA: 0x002BB120 File Offset: 0x002B9320
		// (set) Token: 0x0600AF33 RID: 44851 RVA: 0x000561E2 File Offset: 0x000543E2
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002BB148 File Offset: 0x002B9348
		// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x00056201 File Offset: 0x00054401
		public unsafe int CookProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress)) = value;
			}
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x002BB170 File Offset: 0x002B9370
		// (set) Token: 0x0600AF37 RID: 44855 RVA: 0x0005621C File Offset: 0x0005441C
		public unsafe int cookDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration)) = value;
			}
		}

		// Token: 0x040075DA RID: 30170
		private static readonly IntPtr NativeFieldInfoPtr__itemDefinition;

		// Token: 0x040075DB RID: 30171
		private static readonly IntPtr NativeFieldInfoPtr__productionDefinition;

		// Token: 0x040075DC RID: 30172
		private static readonly IntPtr NativeFieldInfoPtr__cookable;

		// Token: 0x040075DD RID: 30173
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040075DE RID: 30174
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuality;

		// Token: 0x040075DF RID: 30175
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantity;

		// Token: 0x040075E0 RID: 30176
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040075E1 RID: 30177
		private static readonly IntPtr NativeFieldInfoPtr_CookProgress;

		// Token: 0x040075E2 RID: 30178
		private static readonly IntPtr NativeFieldInfoPtr_cookDuration;

		// Token: 0x040075E3 RID: 30179
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0;

		// Token: 0x040075E4 RID: 30180
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0;

		// Token: 0x040075E5 RID: 30181
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0;

		// Token: 0x040075E6 RID: 30182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0;

		// Token: 0x040075E7 RID: 30183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0;

		// Token: 0x040075E8 RID: 30184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040075E9 RID: 30185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0;

		// Token: 0x040075EA RID: 30186
		private static readonly IntPtr NativeMethodInfoPtr_GetCookDuration_Public_Int32_0;

		// Token: 0x040075EB RID: 30187
		private static readonly IntPtr NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0;

		// Token: 0x040075EC RID: 30188
		private static readonly IntPtr NativeMethodInfoPtr_IsReady_Public_Boolean_0;
	}
}
