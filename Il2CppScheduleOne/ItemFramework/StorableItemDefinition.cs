using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EE RID: 1518
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x06008489 RID: 33929 RVA: 0x002330E0 File Offset: 0x002312E0
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemDefinition()
		{
			Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "StorableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr);
			StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "BasePurchasePrice");
			StorableItemDefinition.NativeFieldInfoPtr_ShopCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ShopCategories");
			StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiresLevelToPurchase");
			StorableItemDefinition.NativeFieldInfoPtr_RequiredRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiredRank");
			StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ResellMultiplier");
			StorableItemDefinition.NativeFieldInfoPtr_StoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StoredItem");
			StorableItemDefinition.NativeFieldInfoPtr_StationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StationItem");
			StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679890);
			StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679891);
			StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679892);
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600848A RID: 33930 RVA: 0x002331D8 File Offset: 0x002313D8
		public unsafe bool IsPurchasable
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 248809, RefRangeEnd = 248831, XrefRangeStart = 248808, XrefRangeEnd = 248809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x00233214 File Offset: 0x00231414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248831, XrefRangeEnd = 248835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x0023326C File Offset: 0x0023146C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 248843, RefRangeEnd = 248854, XrefRangeStart = 248835, XrefRangeEnd = 248843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x0003ED04 File Offset: 0x0003CF04
		public StorableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600848E RID: 33934 RVA: 0x002332A8 File Offset: 0x002314A8
		// (set) Token: 0x0600848F RID: 33935 RVA: 0x0003ED0D File Offset: 0x0003CF0D
		public unsafe float BasePurchasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice)) = value;
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x06008490 RID: 33936 RVA: 0x002332D0 File Offset: 0x002314D0
		// (set) Token: 0x06008491 RID: 33937 RVA: 0x0003ED28 File Offset: 0x0003CF28
		public unsafe List<ShopListing.CategoryInstance> ShopCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing.CategoryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06008492 RID: 33938 RVA: 0x00233300 File Offset: 0x00231500
		// (set) Token: 0x06008493 RID: 33939 RVA: 0x0003ED47 File Offset: 0x0003CF47
		public unsafe bool RequiresLevelToPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase)) = value;
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x06008494 RID: 33940 RVA: 0x00233328 File Offset: 0x00231528
		// (set) Token: 0x06008495 RID: 33941 RVA: 0x0003ED62 File Offset: 0x0003CF62
		public unsafe FullRank RequiredRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank)) = value;
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x06008496 RID: 33942 RVA: 0x00233350 File Offset: 0x00231550
		// (set) Token: 0x06008497 RID: 33943 RVA: 0x0003ED7D File Offset: 0x0003CF7D
		public unsafe float ResellMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier)) = value;
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x06008498 RID: 33944 RVA: 0x00233378 File Offset: 0x00231578
		// (set) Token: 0x06008499 RID: 33945 RVA: 0x0003ED98 File Offset: 0x0003CF98
		public unsafe StoredItem StoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600849A RID: 33946 RVA: 0x002333A8 File Offset: 0x002315A8
		// (set) Token: 0x0600849B RID: 33947 RVA: 0x0003EDB7 File Offset: 0x0003CFB7
		public unsafe StationItem StationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A45 RID: 23109
		private static readonly IntPtr NativeFieldInfoPtr_BasePurchasePrice;

		// Token: 0x04005A46 RID: 23110
		private static readonly IntPtr NativeFieldInfoPtr_ShopCategories;

		// Token: 0x04005A47 RID: 23111
		private static readonly IntPtr NativeFieldInfoPtr_RequiresLevelToPurchase;

		// Token: 0x04005A48 RID: 23112
		private static readonly IntPtr NativeFieldInfoPtr_RequiredRank;

		// Token: 0x04005A49 RID: 23113
		private static readonly IntPtr NativeFieldInfoPtr_ResellMultiplier;

		// Token: 0x04005A4A RID: 23114
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem;

		// Token: 0x04005A4B RID: 23115
		private static readonly IntPtr NativeFieldInfoPtr_StationItem;

		// Token: 0x04005A4C RID: 23116
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0;

		// Token: 0x04005A4D RID: 23117
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A4E RID: 23118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
