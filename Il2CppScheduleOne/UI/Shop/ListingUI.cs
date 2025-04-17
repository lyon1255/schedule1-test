using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070B RID: 1803
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x0600A1D1 RID: 41425 RVA: 0x0028B024 File Offset: 0x00289224
		// Note: this type is marked as 'beforefieldinit'.
		static ListingUI()
		{
			Il2CppClassPointerStore<ListingUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ListingUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingUI>.NativeClassPtr);
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_Normal");
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_NoStock");
			ListingUI.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "<Listing>k__BackingField");
			ListingUI.NativeFieldInfoPtr_StockLabelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelDefault");
			ListingUI.NativeFieldInfoPtr_StockLabelNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelNone");
			ListingUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Icon");
			ListingUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "NameLabel");
			ListingUI.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabel");
			ListingUI.NativeFieldInfoPtr_StockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabel");
			ListingUI.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "LockedContainer");
			ListingUI.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "BuyButton");
			ListingUI.NativeFieldInfoPtr_DropdownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownButton");
			ListingUI.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Trigger");
			ListingUI.NativeFieldInfoPtr_DetailPanelAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DetailPanelAnchor");
			ListingUI.NativeFieldInfoPtr_DropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownAnchor");
			ListingUI.NativeFieldInfoPtr_TopDropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "TopDropdownAnchor");
			ListingUI.NativeFieldInfoPtr_hoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverStart");
			ListingUI.NativeFieldInfoPtr_hoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverEnd");
			ListingUI.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onClicked");
			ListingUI.NativeFieldInfoPtr_onDropdownClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onDropdownClicked");
			ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683096);
			ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683097);
			ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683098);
			ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683099);
			ListingUI.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683100);
			ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683101);
			ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683102);
			ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683103);
			ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683104);
			ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683105);
			ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683106);
			ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683107);
			ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683108);
			ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683109);
			ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683110);
			ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683111);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683113);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683114);
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A1D2 RID: 41426 RVA: 0x0028B34C File Offset: 0x0028954C
		// (set) Token: 0x0600A1D3 RID: 41427 RVA: 0x0028B38C File Offset: 0x0028958C
		public unsafe ShopListing Listing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x0028B3D0 File Offset: 0x002895D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284034, XrefRangeEnd = 284104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x0028B420 File Offset: 0x00289620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284104, XrefRangeEnd = 284115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform GetIconCopy(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x0028B47C File Offset: 0x0028967C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284115, XrefRangeEnd = 284119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0028B4B0 File Offset: 0x002896B0
		[CallerCount(0)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x0028B4E4 File Offset: 0x002896E4
		[CallerCount(0)]
		public unsafe void DropdownClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x0028B518 File Offset: 0x00289718
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x0028B54C File Offset: 0x0028974C
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x0028B580 File Offset: 0x00289780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284119, XrefRangeEnd = 284122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StockChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x0028B5B4 File Offset: 0x002897B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284128, RefRangeEnd = 284130, XrefRangeStart = 284122, XrefRangeEnd = 284128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x0028B5E8 File Offset: 0x002897E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284147, RefRangeEnd = 284149, XrefRangeStart = 284130, XrefRangeEnd = 284147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x0028B61C File Offset: 0x0028981C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284155, RefRangeEnd = 284157, XrefRangeStart = 284149, XrefRangeEnd = 284155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x0028B650 File Offset: 0x00289850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284157, XrefRangeEnd = 284158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x0028B68C File Offset: 0x0028988C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284158, XrefRangeEnd = 284162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x0028B6C0 File Offset: 0x002898C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284162, XrefRangeEnd = 284163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x0028B6FC File Offset: 0x002898FC
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x0028B740 File Offset: 0x00289940
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x0004F995 File Offset: 0x0004DB95
		public ListingUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x0028B784 File Offset: 0x00289984
		// (set) Token: 0x0600A1E6 RID: 41446 RVA: 0x0004F99E File Offset: 0x0004DB9E
		public unsafe static Color32 PriceLabelColor_Normal
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&value));
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x0028B7A0 File Offset: 0x002899A0
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x0004F9AC File Offset: 0x0004DBAC
		public unsafe static Color32 PriceLabelColor_NoStock
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&value));
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x0028B7BC File Offset: 0x002899BC
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x0004F9BA File Offset: 0x0004DBBA
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x0028B7EC File Offset: 0x002899EC
		// (set) Token: 0x0600A1EC RID: 41452 RVA: 0x0004F9D9 File Offset: 0x0004DBD9
		public unsafe Color32 StockLabelDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault)) = value;
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600A1ED RID: 41453 RVA: 0x0028B814 File Offset: 0x00289A14
		// (set) Token: 0x0600A1EE RID: 41454 RVA: 0x0004F9F4 File Offset: 0x0004DBF4
		public unsafe Color32 StockLabelNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone)) = value;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x0028B83C File Offset: 0x00289A3C
		// (set) Token: 0x0600A1F0 RID: 41456 RVA: 0x0004FA0F File Offset: 0x0004DC0F
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A1F1 RID: 41457 RVA: 0x0028B86C File Offset: 0x00289A6C
		// (set) Token: 0x0600A1F2 RID: 41458 RVA: 0x0004FA2E File Offset: 0x0004DC2E
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x0028B89C File Offset: 0x00289A9C
		// (set) Token: 0x0600A1F4 RID: 41460 RVA: 0x0004FA4D File Offset: 0x0004DC4D
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x0028B8CC File Offset: 0x00289ACC
		// (set) Token: 0x0600A1F6 RID: 41462 RVA: 0x0004FA6C File Offset: 0x0004DC6C
		public unsafe TextMeshProUGUI StockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A1F7 RID: 41463 RVA: 0x0028B8FC File Offset: 0x00289AFC
		// (set) Token: 0x0600A1F8 RID: 41464 RVA: 0x0004FA8B File Offset: 0x0004DC8B
		public unsafe GameObject LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x0028B92C File Offset: 0x00289B2C
		// (set) Token: 0x0600A1FA RID: 41466 RVA: 0x0004FAAA File Offset: 0x0004DCAA
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x0028B95C File Offset: 0x00289B5C
		// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x0004FAC9 File Offset: 0x0004DCC9
		public unsafe Button DropdownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x0028B98C File Offset: 0x00289B8C
		// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x0028B9BC File Offset: 0x00289BBC
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x0004FB07 File Offset: 0x0004DD07
		public unsafe RectTransform DetailPanelAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x0028B9EC File Offset: 0x00289BEC
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x0004FB26 File Offset: 0x0004DD26
		public unsafe RectTransform DropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x0028BA1C File Offset: 0x00289C1C
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x0004FB45 File Offset: 0x0004DD45
		public unsafe RectTransform TopDropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x0028BA4C File Offset: 0x00289C4C
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x0004FB64 File Offset: 0x0004DD64
		public unsafe Action hoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x0028BA7C File Offset: 0x00289C7C
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x0004FB83 File Offset: 0x0004DD83
		public unsafe Action hoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x0028BAAC File Offset: 0x00289CAC
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x0004FBA2 File Offset: 0x0004DDA2
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x0028BADC File Offset: 0x00289CDC
		// (set) Token: 0x0600A20C RID: 41484 RVA: 0x0004FBC1 File Offset: 0x0004DDC1
		public unsafe Action onDropdownClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C8E RID: 27790
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_Normal;

		// Token: 0x04006C8F RID: 27791
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_NoStock;

		// Token: 0x04006C90 RID: 27792
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006C91 RID: 27793
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelDefault;

		// Token: 0x04006C92 RID: 27794
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelNone;

		// Token: 0x04006C93 RID: 27795
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006C94 RID: 27796
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006C95 RID: 27797
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006C96 RID: 27798
		private static readonly IntPtr NativeFieldInfoPtr_StockLabel;

		// Token: 0x04006C97 RID: 27799
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006C98 RID: 27800
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006C99 RID: 27801
		private static readonly IntPtr NativeFieldInfoPtr_DropdownButton;

		// Token: 0x04006C9A RID: 27802
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04006C9B RID: 27803
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanelAnchor;

		// Token: 0x04006C9C RID: 27804
		private static readonly IntPtr NativeFieldInfoPtr_DropdownAnchor;

		// Token: 0x04006C9D RID: 27805
		private static readonly IntPtr NativeFieldInfoPtr_TopDropdownAnchor;

		// Token: 0x04006C9E RID: 27806
		private static readonly IntPtr NativeFieldInfoPtr_hoverStart;

		// Token: 0x04006C9F RID: 27807
		private static readonly IntPtr NativeFieldInfoPtr_hoverEnd;

		// Token: 0x04006CA0 RID: 27808
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04006CA1 RID: 27809
		private static readonly IntPtr NativeFieldInfoPtr_onDropdownClicked;

		// Token: 0x04006CA2 RID: 27810
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006CA3 RID: 27811
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006CA4 RID: 27812
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0;

		// Token: 0x04006CA5 RID: 27813
		private static readonly IntPtr NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04006CA6 RID: 27814
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006CA7 RID: 27815
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006CA8 RID: 27816
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_0;

		// Token: 0x04006CA9 RID: 27817
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04006CAA RID: 27818
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04006CAB RID: 27819
		private static readonly IntPtr NativeMethodInfoPtr_StockChanged_Private_Void_0;

		// Token: 0x04006CAC RID: 27820
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006CAD RID: 27821
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStock_Private_Void_0;

		// Token: 0x04006CAE RID: 27822
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04006CAF RID: 27823
		private static readonly IntPtr NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0;

		// Token: 0x04006CB0 RID: 27824
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0;

		// Token: 0x04006CB1 RID: 27825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006CB2 RID: 27826
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0;

		// Token: 0x04006CB3 RID: 27827
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0;
	}
}
