using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000705 RID: 1797
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x0600A188 RID: 41352 RVA: 0x0028A0D0 File Offset: 0x002882D0
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry()
		{
			Il2CppClassPointerStore<CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry>.NativeClassPtr);
			CartEntry.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "NameLabel");
			CartEntry.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "PriceLabel");
			CartEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "IncrementButton");
			CartEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "DecrementButton");
			CartEntry.NativeFieldInfoPtr_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "RemoveButton");
			CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Quantity>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Cart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Cart>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Listing>k__BackingField");
			CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683063);
			CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683064);
			CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683065);
			CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683066);
			CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683067);
			CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683068);
			CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683069);
			CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683070);
			CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683071);
			CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683072);
			CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683073);
			CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683074);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683075);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683076);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683077);
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A189 RID: 41353 RVA: 0x0028A2CC File Offset: 0x002884CC
		// (set) Token: 0x0600A18A RID: 41354 RVA: 0x0028A308 File Offset: 0x00288508
		public unsafe int Quantity
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 42839, RefRangeEnd = 42843, XrefRangeStart = 42839, XrefRangeEnd = 42843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x0028A348 File Offset: 0x00288548
		// (set) Token: 0x0600A18C RID: 41356 RVA: 0x0028A388 File Offset: 0x00288588
		public unsafe Cart Cart
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x0028A3CC File Offset: 0x002885CC
		// (set) Token: 0x0600A18E RID: 41358 RVA: 0x0028A40C File Offset: 0x0028860C
		public unsafe ShopListing Listing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x0028A450 File Offset: 0x00288650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283832, RefRangeEnd = 283833, XrefRangeStart = 283808, XrefRangeEnd = 283832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cart cart, ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x0028A4B4 File Offset: 0x002886B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283836, RefRangeEnd = 283837, XrefRangeStart = 283833, XrefRangeEnd = 283836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x0028A4F4 File Offset: 0x002886F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283837, XrefRangeEnd = 283841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x0028A530 File Offset: 0x00288730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283841, XrefRangeEnd = 283844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x0028A564 File Offset: 0x00288764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283866, RefRangeEnd = 283868, XrefRangeStart = 283844, XrefRangeEnd = 283866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x0028A5A4 File Offset: 0x002887A4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x0028A5E0 File Offset: 0x002887E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283868, XrefRangeEnd = 283869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x0028A614 File Offset: 0x00288814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283869, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x0028A648 File Offset: 0x00288848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283870, XrefRangeEnd = 283871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0004F7A7 File Offset: 0x0004D9A7
		public CartEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A199 RID: 41369 RVA: 0x0028A67C File Offset: 0x0028887C
		// (set) Token: 0x0600A19A RID: 41370 RVA: 0x0004F7B0 File Offset: 0x0004D9B0
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A19B RID: 41371 RVA: 0x0028A6AC File Offset: 0x002888AC
		// (set) Token: 0x0600A19C RID: 41372 RVA: 0x0004F7CF File Offset: 0x0004D9CF
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A19D RID: 41373 RVA: 0x0028A6DC File Offset: 0x002888DC
		// (set) Token: 0x0600A19E RID: 41374 RVA: 0x0004F7EE File Offset: 0x0004D9EE
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A19F RID: 41375 RVA: 0x0028A70C File Offset: 0x0028890C
		// (set) Token: 0x0600A1A0 RID: 41376 RVA: 0x0004F80D File Offset: 0x0004DA0D
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600A1A1 RID: 41377 RVA: 0x0028A73C File Offset: 0x0028893C
		// (set) Token: 0x0600A1A2 RID: 41378 RVA: 0x0004F82C File Offset: 0x0004DA2C
		public unsafe Button RemoveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600A1A3 RID: 41379 RVA: 0x0028A76C File Offset: 0x0028896C
		// (set) Token: 0x0600A1A4 RID: 41380 RVA: 0x0004F84B File Offset: 0x0004DA4B
		public unsafe int _Quantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField)) = value;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x0028A794 File Offset: 0x00288994
		// (set) Token: 0x0600A1A6 RID: 41382 RVA: 0x0004F866 File Offset: 0x0004DA66
		public unsafe Cart _Cart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A1A7 RID: 41383 RVA: 0x0028A7C4 File Offset: 0x002889C4
		// (set) Token: 0x0600A1A8 RID: 41384 RVA: 0x0004F885 File Offset: 0x0004DA85
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C4B RID: 27723
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006C4C RID: 27724
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006C4D RID: 27725
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006C4E RID: 27726
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006C4F RID: 27727
		private static readonly IntPtr NativeFieldInfoPtr_RemoveButton;

		// Token: 0x04006C50 RID: 27728
		private static readonly IntPtr NativeFieldInfoPtr__Quantity_k__BackingField;

		// Token: 0x04006C51 RID: 27729
		private static readonly IntPtr NativeFieldInfoPtr__Cart_k__BackingField;

		// Token: 0x04006C52 RID: 27730
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006C53 RID: 27731
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04006C54 RID: 27732
		private static readonly IntPtr NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0;

		// Token: 0x04006C55 RID: 27733
		private static readonly IntPtr NativeMethodInfoPtr_get_Cart_Public_get_Cart_0;

		// Token: 0x04006C56 RID: 27734
		private static readonly IntPtr NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0;

		// Token: 0x04006C57 RID: 27735
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006C58 RID: 27736
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006C59 RID: 27737
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0;

		// Token: 0x04006C5A RID: 27738
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x04006C5B RID: 27739
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0;

		// Token: 0x04006C5C RID: 27740
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006C5D RID: 27741
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0;

		// Token: 0x04006C5E RID: 27742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C5F RID: 27743
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0;

		// Token: 0x04006C60 RID: 27744
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0;

		// Token: 0x04006C61 RID: 27745
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0;
	}
}
