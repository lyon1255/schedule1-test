using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000710 RID: 1808
	[Serializable]
	public class ShopListing : Il2CppSystem.Object
	{
		// Token: 0x0600A2C2 RID: 41666 RVA: 0x0028E064 File Offset: 0x0028C264
		// Note: this type is marked as 'beforefieldinit'.
		static ShopListing()
		{
			Il2CppClassPointerStore<ShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing>.NativeClassPtr);
			ShopListing.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "name");
			ShopListing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "Item");
			ShopListing.NativeFieldInfoPtr_OverridePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverridePrice");
			ShopListing.NativeFieldInfoPtr_OverriddenPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverriddenPrice");
			ShopListing.NativeFieldInfoPtr_LimitedStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "LimitedStock");
			ShopListing.NativeFieldInfoPtr_DefaultStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "DefaultStock");
			ShopListing.NativeFieldInfoPtr_RestockRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "RestockRate");
			ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "EnforceMinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "MinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_CanBeDelivered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CanBeDelivered");
			ShopListing.NativeFieldInfoPtr_UseIconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "UseIconTint");
			ShopListing.NativeFieldInfoPtr_IconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "IconTint");
			ShopListing.NativeFieldInfoPtr__Shop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<Shop>k__BackingField");
			ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<CurrentStock>k__BackingField");
			ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<QuantityInCart>k__BackingField");
			ShopListing.NativeFieldInfoPtr_onStockChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "onStockChanged");
			ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683223);
			ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683224);
			ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683225);
			ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683226);
			ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683227);
			ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683228);
			ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683229);
			ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683230);
			ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683231);
			ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683232);
			ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683233);
			ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683234);
			ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683235);
			ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683236);
			ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683237);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683238);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683239);
			ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683240);
			ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683241);
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A2C3 RID: 41667 RVA: 0x0028E350 File Offset: 0x0028C550
		public unsafe bool IsInStock
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x0028E38C File Offset: 0x0028C58C
		public unsafe float Price
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 285371, RefRangeEnd = 285379, XrefRangeStart = 285371, XrefRangeEnd = 285371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A2C5 RID: 41669 RVA: 0x0028E3C8 File Offset: 0x0028C5C8
		public unsafe bool IsUnlimitedStock
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 285379, RefRangeEnd = 285391, XrefRangeStart = 285379, XrefRangeEnd = 285379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A2C6 RID: 41670 RVA: 0x0028E404 File Offset: 0x0028C604
		// (set) Token: 0x0600A2C7 RID: 41671 RVA: 0x0028E444 File Offset: 0x0028C644
		public unsafe ShopInterface Shop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x0028E488 File Offset: 0x0028C688
		// (set) Token: 0x0600A2C9 RID: 41673 RVA: 0x0028E4C4 File Offset: 0x0028C6C4
		public unsafe int CurrentStock
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47045, RefRangeEnd = 47048, XrefRangeStart = 47045, XrefRangeEnd = 47048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48691, RefRangeEnd = 48694, XrefRangeStart = 48691, XrefRangeEnd = 48694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x0028E504 File Offset: 0x0028C704
		// (set) Token: 0x0600A2CB RID: 41675 RVA: 0x0028E540 File Offset: 0x0028C740
		public unsafe int QuantityInCart
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69396, RefRangeEnd = 69397, XrefRangeStart = 69396, XrefRangeEnd = 69397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 257569, RefRangeEnd = 257578, XrefRangeStart = 257569, XrefRangeEnd = 257578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x0028E580 File Offset: 0x0028C780
		public unsafe int CurrentStockMinusCart
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 285391, RefRangeEnd = 285397, XrefRangeStart = 285391, XrefRangeEnd = 285391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x0028E5BC File Offset: 0x0028C7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopInterface shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x0028E600 File Offset: 0x0028C800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285398, RefRangeEnd = 285401, XrefRangeStart = 285397, XrefRangeEnd = 285398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restock(bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x0028E640 File Offset: 0x0028C840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285402, RefRangeEnd = 285403, XrefRangeStart = 285401, XrefRangeEnd = 285402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStock(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x0028E680 File Offset: 0x0028C880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285425, RefRangeEnd = 285429, XrefRangeStart = 285403, XrefRangeEnd = 285425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStock(int quantity, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x0028E6CC File Offset: 0x0028C8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285429, XrefRangeEnd = 285434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x0028E714 File Offset: 0x0028C914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285434, XrefRangeEnd = 285441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x0028E768 File Offset: 0x0028C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285441, XrefRangeEnd = 285445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x0028E7C0 File Offset: 0x0028C9C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285445, RefRangeEnd = 285449, XrefRangeStart = 285445, XrefRangeEnd = 285445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantityInCart(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x0028E800 File Offset: 0x0028CA00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285450, RefRangeEnd = 285452, XrefRangeStart = 285449, XrefRangeEnd = 285450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x000501B5 File Offset: 0x0004E3B5
		public ShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x0028E83C File Offset: 0x0028CA3C
		// (set) Token: 0x0600A2D8 RID: 41688 RVA: 0x000501BE File Offset: 0x0004E3BE
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A2D9 RID: 41689 RVA: 0x0028E864 File Offset: 0x0028CA64
		// (set) Token: 0x0600A2DA RID: 41690 RVA: 0x000501DD File Offset: 0x0004E3DD
		public unsafe StorableItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x0028E894 File Offset: 0x0028CA94
		// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x000501FC File Offset: 0x0004E3FC
		public unsafe bool OverridePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice)) = value;
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x0028E8BC File Offset: 0x0028CABC
		// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x00050217 File Offset: 0x0004E417
		public unsafe float OverriddenPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice)) = value;
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x0028E8E4 File Offset: 0x0028CAE4
		// (set) Token: 0x0600A2E0 RID: 41696 RVA: 0x00050232 File Offset: 0x0004E432
		public unsafe bool LimitedStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock)) = value;
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x0028E90C File Offset: 0x0028CB0C
		// (set) Token: 0x0600A2E2 RID: 41698 RVA: 0x0005024D File Offset: 0x0004E44D
		public unsafe int DefaultStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock)) = value;
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x0028E934 File Offset: 0x0028CB34
		// (set) Token: 0x0600A2E4 RID: 41700 RVA: 0x00050268 File Offset: 0x0004E468
		public unsafe ShopListing.ERestockRate RestockRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate)) = value;
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A2E5 RID: 41701 RVA: 0x0028E95C File Offset: 0x0028CB5C
		// (set) Token: 0x0600A2E6 RID: 41702 RVA: 0x00050283 File Offset: 0x0004E483
		public unsafe bool EnforceMinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600A2E7 RID: 41703 RVA: 0x0028E984 File Offset: 0x0028CB84
		// (set) Token: 0x0600A2E8 RID: 41704 RVA: 0x0005029E File Offset: 0x0004E49E
		public unsafe float MinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A2E9 RID: 41705 RVA: 0x0028E9AC File Offset: 0x0028CBAC
		// (set) Token: 0x0600A2EA RID: 41706 RVA: 0x000502B9 File Offset: 0x0004E4B9
		public unsafe bool CanBeDelivered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered)) = value;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x0028E9D4 File Offset: 0x0028CBD4
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x000502D4 File Offset: 0x0004E4D4
		public unsafe bool UseIconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint)) = value;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x0028E9FC File Offset: 0x0028CBFC
		// (set) Token: 0x0600A2EE RID: 41710 RVA: 0x000502EF File Offset: 0x0004E4EF
		public unsafe Color IconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint)) = value;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A2EF RID: 41711 RVA: 0x0028EA24 File Offset: 0x0028CC24
		// (set) Token: 0x0600A2F0 RID: 41712 RVA: 0x0005030A File Offset: 0x0004E50A
		public unsafe ShopInterface _Shop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x0028EA54 File Offset: 0x0028CC54
		// (set) Token: 0x0600A2F2 RID: 41714 RVA: 0x00050329 File Offset: 0x0004E529
		public unsafe int _CurrentStock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField)) = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x0028EA7C File Offset: 0x0028CC7C
		// (set) Token: 0x0600A2F4 RID: 41716 RVA: 0x00050344 File Offset: 0x0004E544
		public unsafe int _QuantityInCart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField)) = value;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x0028EAA4 File Offset: 0x0028CCA4
		// (set) Token: 0x0600A2F6 RID: 41718 RVA: 0x0005035F File Offset: 0x0004E55F
		public unsafe Action onStockChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D30 RID: 27952
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04006D31 RID: 27953
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04006D32 RID: 27954
		private static readonly IntPtr NativeFieldInfoPtr_OverridePrice;

		// Token: 0x04006D33 RID: 27955
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenPrice;

		// Token: 0x04006D34 RID: 27956
		private static readonly IntPtr NativeFieldInfoPtr_LimitedStock;

		// Token: 0x04006D35 RID: 27957
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStock;

		// Token: 0x04006D36 RID: 27958
		private static readonly IntPtr NativeFieldInfoPtr_RestockRate;

		// Token: 0x04006D37 RID: 27959
		private static readonly IntPtr NativeFieldInfoPtr_EnforceMinimumGameCreationVersion;

		// Token: 0x04006D38 RID: 27960
		private static readonly IntPtr NativeFieldInfoPtr_MinimumGameCreationVersion;

		// Token: 0x04006D39 RID: 27961
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDelivered;

		// Token: 0x04006D3A RID: 27962
		private static readonly IntPtr NativeFieldInfoPtr_UseIconTint;

		// Token: 0x04006D3B RID: 27963
		private static readonly IntPtr NativeFieldInfoPtr_IconTint;

		// Token: 0x04006D3C RID: 27964
		private static readonly IntPtr NativeFieldInfoPtr__Shop_k__BackingField;

		// Token: 0x04006D3D RID: 27965
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStock_k__BackingField;

		// Token: 0x04006D3E RID: 27966
		private static readonly IntPtr NativeFieldInfoPtr__QuantityInCart_k__BackingField;

		// Token: 0x04006D3F RID: 27967
		private static readonly IntPtr NativeFieldInfoPtr_onStockChanged;

		// Token: 0x04006D40 RID: 27968
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0;

		// Token: 0x04006D41 RID: 27969
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006D42 RID: 27970
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0;

		// Token: 0x04006D43 RID: 27971
		private static readonly IntPtr NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0;

		// Token: 0x04006D44 RID: 27972
		private static readonly IntPtr NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0;

		// Token: 0x04006D45 RID: 27973
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0;

		// Token: 0x04006D46 RID: 27974
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0;

		// Token: 0x04006D47 RID: 27975
		private static readonly IntPtr NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0;

		// Token: 0x04006D48 RID: 27976
		private static readonly IntPtr NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0;

		// Token: 0x04006D49 RID: 27977
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0;

		// Token: 0x04006D4A RID: 27978
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0;

		// Token: 0x04006D4B RID: 27979
		private static readonly IntPtr NativeMethodInfoPtr_Restock_Public_Void_Boolean_0;

		// Token: 0x04006D4C RID: 27980
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0;

		// Token: 0x04006D4D RID: 27981
		private static readonly IntPtr NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0;

		// Token: 0x04006D4E RID: 27982
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04006D4F RID: 27983
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0;

		// Token: 0x04006D50 RID: 27984
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04006D51 RID: 27985
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0;

		// Token: 0x04006D52 RID: 27986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBD RID: 3005
		[Serializable]
		public class CategoryInstance : Il2CppSystem.Object
		{
			// Token: 0x0600DD81 RID: 56705 RVA: 0x00344E6C File Offset: 0x0034306C
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInstance()
			{
				Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CategoryInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr);
				ShopListing.CategoryInstance.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, "Category");
				ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, 100683242);
			}

			// Token: 0x0600DD82 RID: 56706 RVA: 0x00344EC0 File Offset: 0x003430C0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD83 RID: 56707 RVA: 0x0006BF0E File Offset: 0x0006A10E
			public CategoryInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A3 RID: 17571
			// (get) Token: 0x0600DD84 RID: 56708 RVA: 0x00344EFC File Offset: 0x003430FC
			// (set) Token: 0x0600DD85 RID: 56709 RVA: 0x0006BF17 File Offset: 0x0006A117
			public unsafe EShopCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x04009460 RID: 37984
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x04009461 RID: 37985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BBE RID: 3006
		[OriginalName("Assembly-CSharp.dll", "", "ERestockRate")]
		public enum ERestockRate
		{
			// Token: 0x04009463 RID: 37987
			Daily,
			// Token: 0x04009464 RID: 37988
			Weekly,
			// Token: 0x04009465 RID: 37989
			Never
		}

		// Token: 0x02000BBF RID: 3007
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopListing+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD86 RID: 56710 RVA: 0x00344F24 File Offset: 0x00343124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr);
				ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, "category");
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683243);
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683244);
			}

			// Token: 0x0600DD87 RID: 56711 RVA: 0x00344F8C File Offset: 0x0034318C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD88 RID: 56712 RVA: 0x00344FC8 File Offset: 0x003431C8
			[CallerCount(0)]
			public unsafe bool _DoesListingMatchCategoryFilter_b__0(ShopListing.CategoryInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD89 RID: 56713 RVA: 0x0006BF32 File Offset: 0x0006A132
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A4 RID: 17572
			// (get) Token: 0x0600DD8A RID: 56714 RVA: 0x00345018 File Offset: 0x00343218
			// (set) Token: 0x0600DD8B RID: 56715 RVA: 0x0006BF3B File Offset: 0x0006A13B
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x04009466 RID: 37990
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009467 RID: 37991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009468 RID: 37992
			private static readonly IntPtr NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0;
		}
	}
}
