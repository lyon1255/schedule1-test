using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200070E RID: 1806
	public class ShopInterface : MonoBehaviour
	{
		// Token: 0x0600A236 RID: 41526 RVA: 0x0028C354 File Offset: 0x0028A554
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterface()
		{
			Il2CppClassPointerStore<ShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr);
			ShopInterface.NativeFieldInfoPtr_AllShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AllShops");
			ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "MAX_ITEM_QUANTITY");
			ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopInterface.NativeFieldInfoPtr_ShopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopName");
			ShopInterface.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopCode");
			ShopInterface.NativeFieldInfoPtr_PaymentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "PaymentType");
			ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShowCurrencyHint");
			ShopInterface.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Listings");
			ShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Canvas");
			ShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Container");
			ShopInterface.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingContainer");
			ShopInterface.NativeFieldInfoPtr_StoreNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "StoreNameLabel");
			ShopInterface.NativeFieldInfoPtr_Cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Cart");
			ShopInterface.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryBays");
			ShopInterface.NativeFieldInfoPtr_LoadingBayDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "LoadingBayDetector");
			ShopInterface.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DetailPanel");
			ShopInterface.NativeFieldInfoPtr_ListingScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingScrollRect");
			ShopInterface.NativeFieldInfoPtr_AmountSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AmountSelector");
			ShopInterface.NativeFieldInfoPtr_DeliveryVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryVehicle");
			ShopInterface.NativeFieldInfoPtr_AddItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AddItemSound");
			ShopInterface.NativeFieldInfoPtr_RemoveItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "RemoveItemSound");
			ShopInterface.NativeFieldInfoPtr_CheckoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "CheckoutSound");
			ShopInterface.NativeFieldInfoPtr_ListingUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingUIPrefab");
			ShopInterface.NativeFieldInfoPtr_onOrderCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "onOrderCompleted");
			ShopInterface.NativeFieldInfoPtr_categoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryButtons");
			ShopInterface.NativeFieldInfoPtr_categoryFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryFilter");
			ShopInterface.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "searchTerm");
			ShopInterface.NativeFieldInfoPtr_listingUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "listingUI");
			ShopInterface.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "selectedListing");
			ShopInterface.NativeFieldInfoPtr_dropdownMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "dropdownMouseUp");
			ShopInterface.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "loader");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<HasChanged>k__BackingField");
			ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683135);
			ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683136);
			ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683137);
			ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683138);
			ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683139);
			ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683140);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683141);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683142);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683143);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683144);
			ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683145);
			ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683146);
			ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683147);
			ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683148);
			ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683149);
			ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683150);
			ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683151);
			ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683152);
			ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683153);
			ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683154);
			ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683155);
			ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683156);
			ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683157);
			ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683158);
			ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683159);
			ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683160);
			ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683161);
			ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683162);
			ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683163);
			ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683164);
			ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683165);
			ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683166);
			ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683167);
			ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683168);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683169);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683170);
			ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683171);
			ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683172);
			ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683173);
			ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683174);
			ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683175);
			ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683176);
			ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683177);
			ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683178);
			ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683179);
			ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683180);
			ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683181);
			ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683182);
			ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683183);
			ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683184);
			ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683186);
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600A237 RID: 41527 RVA: 0x0028CA28 File Offset: 0x0028AC28
		// (set) Token: 0x0600A238 RID: 41528 RVA: 0x0028CA64 File Offset: 0x0028AC64
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600A239 RID: 41529 RVA: 0x0028CAA4 File Offset: 0x0028ACA4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284379, XrefRangeEnd = 284380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600A23A RID: 41530 RVA: 0x0028CADC File Offset: 0x0028ACDC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x0028CB14 File Offset: 0x0028AD14
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A23C RID: 41532 RVA: 0x0028CB54 File Offset: 0x0028AD54
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A23D RID: 41533 RVA: 0x0028CB90 File Offset: 0x0028AD90
		// (set) Token: 0x0600A23E RID: 41534 RVA: 0x0028CBD0 File Offset: 0x0028ADD0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A23F RID: 41535 RVA: 0x0028CC14 File Offset: 0x0028AE14
		// (set) Token: 0x0600A240 RID: 41536 RVA: 0x0028CC54 File Offset: 0x0028AE54
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A241 RID: 41537 RVA: 0x0028CC98 File Offset: 0x0028AE98
		// (set) Token: 0x0600A242 RID: 41538 RVA: 0x0028CCD4 File Offset: 0x0028AED4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x0028CD14 File Offset: 0x0028AF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284380, XrefRangeEnd = 284444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x0028CD50 File Offset: 0x0028AF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284525, RefRangeEnd = 284526, XrefRangeStart = 284444, XrefRangeEnd = 284525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x0028CD8C File Offset: 0x0028AF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284526, XrefRangeEnd = 284532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x0028CDC8 File Offset: 0x0028AFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284532, XrefRangeEnd = 284540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x0028CDFC File Offset: 0x0028AFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284540, XrefRangeEnd = 284604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x0028CE30 File Offset: 0x0028B030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284604, XrefRangeEnd = 284605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x0028CE6C File Offset: 0x0028B06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284605, XrefRangeEnd = 284617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x0028CEA0 File Offset: 0x0028B0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284617, XrefRangeEnd = 284629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x0028CED4 File Offset: 0x0028B0D4
		[CallerCount(0)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x0028CF08 File Offset: 0x0028B108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284629, XrefRangeEnd = 284743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x0028CF54 File Offset: 0x0028B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284743, XrefRangeEnd = 284751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x0028CF88 File Offset: 0x0028B188
		[CallerCount(0)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x0028CFD8 File Offset: 0x0028B1D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284811, RefRangeEnd = 284812, XrefRangeStart = 284751, XrefRangeEnd = 284811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateListingUI(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x0028D01C File Offset: 0x0028B21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284812, XrefRangeEnd = 284840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x0028D05C File Offset: 0x0028B25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284840, XrefRangeEnd = 284844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x0028D0AC File Offset: 0x0028B2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284844, XrefRangeEnd = 284853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCartAnimation(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x0028D0F0 File Offset: 0x0028B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284853, XrefRangeEnd = 284864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CategorySelected(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x0028D130 File Offset: 0x0028B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284864, XrefRangeEnd = 284875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectCurrentCategory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x0028D164 File Offset: 0x0028B364
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284941, RefRangeEnd = 284945, XrefRangeStart = 284875, XrefRangeEnd = 284941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x0028D198 File Offset: 0x0028B398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284945, XrefRangeEnd = 284953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUnlockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x0028D1CC File Offset: 0x0028B3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284968, RefRangeEnd = 284969, XrefRangeStart = 284953, XrefRangeEnd = 284968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestockAllListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x0028D200 File Offset: 0x0028B400
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCartFitItem(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x0028D250 File Offset: 0x0028B450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284969, XrefRangeEnd = 284981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x0028D28C File Offset: 0x0028B48C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285018, RefRangeEnd = 285021, XrefRangeStart = 284981, XrefRangeEnd = 285018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit(List<ItemSlot> availableSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x0028D2DC File Offset: 0x0028B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285021, XrefRangeEnd = 285064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x0028D324 File Offset: 0x0028B524
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285086, RefRangeEnd = 285090, XrefRangeStart = 285064, XrefRangeEnd = 285086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAvailableSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x0028D364 File Offset: 0x0028B564
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285097, RefRangeEnd = 285102, XrefRangeStart = 285090, XrefRangeEnd = 285097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetLoadingBayVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x0028D3A4 File Offset: 0x0028B5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285102, XrefRangeEnd = 285111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItemInDeliveryBay(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x0028D3E8 File Offset: 0x0028B5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285111, XrefRangeEnd = 285124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuantitySelected(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x0028D428 File Offset: 0x0028B628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285137, RefRangeEnd = 285138, XrefRangeStart = 285124, XrefRangeEnd = 285137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x0028D46C File Offset: 0x0028B66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285147, RefRangeEnd = 285148, XrefRangeStart = 285138, XrefRangeEnd = 285147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropdownClicked(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x0028D4B0 File Offset: 0x0028B6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285150, RefRangeEnd = 285151, XrefRangeStart = 285148, XrefRangeEnd = 285150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryHovered(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x0028D4F4 File Offset: 0x0028B6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285151, XrefRangeEnd = 285153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryUnhovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x0028D528 File Offset: 0x0028B728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285153, XrefRangeEnd = 285183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ShopData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x0028D56C File Offset: 0x0028B76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285200, RefRangeEnd = 285201, XrefRangeStart = 285183, XrefRangeEnd = 285200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x0028D5A8 File Offset: 0x0028B7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285201, XrefRangeEnd = 285216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing GetListing(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x0028D5F8 File Offset: 0x0028B7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285216, XrefRangeEnd = 285258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x0028D63C File Offset: 0x0028B83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285308, RefRangeEnd = 285309, XrefRangeStart = 285258, XrefRangeEnd = 285308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x0028D678 File Offset: 0x0028B878
		[CallerCount(0)]
		public unsafe bool _DeselectCurrentCategory_b__72_0(CategoryButton x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x0004FD20 File Offset: 0x0004DF20
		public ShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x0028D6C8 File Offset: 0x0028B8C8
		// (set) Token: 0x0600A26C RID: 41580 RVA: 0x0004FD29 File Offset: 0x0004DF29
		public unsafe static List<ShopInterface> AllShops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_AllShops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopInterface>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_AllShops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A26D RID: 41581 RVA: 0x0028D6F0 File Offset: 0x0028B8F0
		// (set) Token: 0x0600A26E RID: 41582 RVA: 0x0004FD3B File Offset: 0x0004DF3B
		public unsafe static int MAX_ITEM_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600A26F RID: 41583 RVA: 0x0028D70C File Offset: 0x0028B90C
		// (set) Token: 0x0600A270 RID: 41584 RVA: 0x0004FD49 File Offset: 0x0004DF49
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600A271 RID: 41585 RVA: 0x0028D734 File Offset: 0x0028B934
		// (set) Token: 0x0600A272 RID: 41586 RVA: 0x0004FD64 File Offset: 0x0004DF64
		public unsafe string ShopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A273 RID: 41587 RVA: 0x0028D75C File Offset: 0x0028B95C
		// (set) Token: 0x0600A274 RID: 41588 RVA: 0x0004FD83 File Offset: 0x0004DF83
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A275 RID: 41589 RVA: 0x0028D784 File Offset: 0x0028B984
		// (set) Token: 0x0600A276 RID: 41590 RVA: 0x0004FDA2 File Offset: 0x0004DFA2
		public unsafe ShopInterface.EPaymentType PaymentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType)) = value;
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A277 RID: 41591 RVA: 0x0028D7AC File Offset: 0x0028B9AC
		// (set) Token: 0x0600A278 RID: 41592 RVA: 0x0004FDBD File Offset: 0x0004DFBD
		public unsafe bool ShowCurrencyHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint)) = value;
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A279 RID: 41593 RVA: 0x0028D7D4 File Offset: 0x0028B9D4
		// (set) Token: 0x0600A27A RID: 41594 RVA: 0x0004FDD8 File Offset: 0x0004DFD8
		public unsafe List<ShopListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A27B RID: 41595 RVA: 0x0028D804 File Offset: 0x0028BA04
		// (set) Token: 0x0600A27C RID: 41596 RVA: 0x0004FDF7 File Offset: 0x0004DFF7
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0600A27D RID: 41597 RVA: 0x0028D834 File Offset: 0x0028BA34
		// (set) Token: 0x0600A27E RID: 41598 RVA: 0x0004FE16 File Offset: 0x0004E016
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600A27F RID: 41599 RVA: 0x0028D864 File Offset: 0x0028BA64
		// (set) Token: 0x0600A280 RID: 41600 RVA: 0x0004FE35 File Offset: 0x0004E035
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600A281 RID: 41601 RVA: 0x0028D894 File Offset: 0x0028BA94
		// (set) Token: 0x0600A282 RID: 41602 RVA: 0x0004FE54 File Offset: 0x0004E054
		public unsafe TextMeshProUGUI StoreNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A283 RID: 41603 RVA: 0x0028D8C4 File Offset: 0x0028BAC4
		// (set) Token: 0x0600A284 RID: 41604 RVA: 0x0004FE73 File Offset: 0x0004E073
		public unsafe Cart Cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x0028D8F4 File Offset: 0x0028BAF4
		// (set) Token: 0x0600A286 RID: 41606 RVA: 0x0004FE92 File Offset: 0x0004E092
		public unsafe Il2CppReferenceArray<StorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600A287 RID: 41607 RVA: 0x0028D924 File Offset: 0x0028BB24
		// (set) Token: 0x0600A288 RID: 41608 RVA: 0x0004FEB1 File Offset: 0x0004E0B1
		public unsafe VehicleDetector LoadingBayDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600A289 RID: 41609 RVA: 0x0028D954 File Offset: 0x0028BB54
		// (set) Token: 0x0600A28A RID: 41610 RVA: 0x0004FED0 File Offset: 0x0004E0D0
		public unsafe ShopInterfaceDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600A28B RID: 41611 RVA: 0x0028D984 File Offset: 0x0028BB84
		// (set) Token: 0x0600A28C RID: 41612 RVA: 0x0004FEEF File Offset: 0x0004E0EF
		public unsafe ScrollRect ListingScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x0028D9B4 File Offset: 0x0028BBB4
		// (set) Token: 0x0600A28E RID: 41614 RVA: 0x0004FF0E File Offset: 0x0004E10E
		public unsafe ShopAmountSelector AmountSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopAmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A28F RID: 41615 RVA: 0x0028D9E4 File Offset: 0x0028BBE4
		// (set) Token: 0x0600A290 RID: 41616 RVA: 0x0004FF2D File Offset: 0x0004E12D
		public unsafe DeliveryVehicle DeliveryVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A291 RID: 41617 RVA: 0x0028DA14 File Offset: 0x0028BC14
		// (set) Token: 0x0600A292 RID: 41618 RVA: 0x0004FF4C File Offset: 0x0004E14C
		public unsafe AudioSourceController AddItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A293 RID: 41619 RVA: 0x0028DA44 File Offset: 0x0028BC44
		// (set) Token: 0x0600A294 RID: 41620 RVA: 0x0004FF6B File Offset: 0x0004E16B
		public unsafe AudioSourceController RemoveItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600A295 RID: 41621 RVA: 0x0028DA74 File Offset: 0x0028BC74
		// (set) Token: 0x0600A296 RID: 41622 RVA: 0x0004FF8A File Offset: 0x0004E18A
		public unsafe AudioSourceController CheckoutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600A297 RID: 41623 RVA: 0x0028DAA4 File Offset: 0x0028BCA4
		// (set) Token: 0x0600A298 RID: 41624 RVA: 0x0004FFA9 File Offset: 0x0004E1A9
		public unsafe ListingUI ListingUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600A299 RID: 41625 RVA: 0x0028DAD4 File Offset: 0x0028BCD4
		// (set) Token: 0x0600A29A RID: 41626 RVA: 0x0004FFC8 File Offset: 0x0004E1C8
		public unsafe UnityEvent onOrderCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x0028DB04 File Offset: 0x0028BD04
		// (set) Token: 0x0600A29C RID: 41628 RVA: 0x0004FFE7 File Offset: 0x0004E1E7
		public unsafe List<CategoryButton> categoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CategoryButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600A29D RID: 41629 RVA: 0x0028DB34 File Offset: 0x0028BD34
		// (set) Token: 0x0600A29E RID: 41630 RVA: 0x00050006 File Offset: 0x0004E206
		public unsafe EShopCategory categoryFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter)) = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600A29F RID: 41631 RVA: 0x0028DB5C File Offset: 0x0028BD5C
		// (set) Token: 0x0600A2A0 RID: 41632 RVA: 0x00050021 File Offset: 0x0004E221
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x0028DB84 File Offset: 0x0028BD84
		// (set) Token: 0x0600A2A2 RID: 41634 RVA: 0x00050040 File Offset: 0x0004E240
		public unsafe List<ListingUI> listingUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x0028DBB4 File Offset: 0x0028BDB4
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x0005005F File Offset: 0x0004E25F
		public unsafe ListingUI selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x0028DBE4 File Offset: 0x0028BDE4
		// (set) Token: 0x0600A2A6 RID: 41638 RVA: 0x0005007E File Offset: 0x0004E27E
		public unsafe bool dropdownMouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp)) = value;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x0028DC0C File Offset: 0x0028BE0C
		// (set) Token: 0x0600A2A8 RID: 41640 RVA: 0x00050099 File Offset: 0x0004E299
		public unsafe ShopLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x0028DC3C File Offset: 0x0028BE3C
		// (set) Token: 0x0600A2AA RID: 41642 RVA: 0x000500B8 File Offset: 0x0004E2B8
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x0028DC6C File Offset: 0x0028BE6C
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x000500D7 File Offset: 0x0004E2D7
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x0028DC9C File Offset: 0x0028BE9C
		// (set) Token: 0x0600A2AE RID: 41646 RVA: 0x000500F6 File Offset: 0x0004E2F6
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04006CCF RID: 27855
		private static readonly IntPtr NativeFieldInfoPtr_AllShops;

		// Token: 0x04006CD0 RID: 27856
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ITEM_QUANTITY;

		// Token: 0x04006CD1 RID: 27857
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006CD2 RID: 27858
		private static readonly IntPtr NativeFieldInfoPtr_ShopName;

		// Token: 0x04006CD3 RID: 27859
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04006CD4 RID: 27860
		private static readonly IntPtr NativeFieldInfoPtr_PaymentType;

		// Token: 0x04006CD5 RID: 27861
		private static readonly IntPtr NativeFieldInfoPtr_ShowCurrencyHint;

		// Token: 0x04006CD6 RID: 27862
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x04006CD7 RID: 27863
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006CD8 RID: 27864
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CD9 RID: 27865
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x04006CDA RID: 27866
		private static readonly IntPtr NativeFieldInfoPtr_StoreNameLabel;

		// Token: 0x04006CDB RID: 27867
		private static readonly IntPtr NativeFieldInfoPtr_Cart;

		// Token: 0x04006CDC RID: 27868
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04006CDD RID: 27869
		private static readonly IntPtr NativeFieldInfoPtr_LoadingBayDetector;

		// Token: 0x04006CDE RID: 27870
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006CDF RID: 27871
		private static readonly IntPtr NativeFieldInfoPtr_ListingScrollRect;

		// Token: 0x04006CE0 RID: 27872
		private static readonly IntPtr NativeFieldInfoPtr_AmountSelector;

		// Token: 0x04006CE1 RID: 27873
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryVehicle;

		// Token: 0x04006CE2 RID: 27874
		private static readonly IntPtr NativeFieldInfoPtr_AddItemSound;

		// Token: 0x04006CE3 RID: 27875
		private static readonly IntPtr NativeFieldInfoPtr_RemoveItemSound;

		// Token: 0x04006CE4 RID: 27876
		private static readonly IntPtr NativeFieldInfoPtr_CheckoutSound;

		// Token: 0x04006CE5 RID: 27877
		private static readonly IntPtr NativeFieldInfoPtr_ListingUIPrefab;

		// Token: 0x04006CE6 RID: 27878
		private static readonly IntPtr NativeFieldInfoPtr_onOrderCompleted;

		// Token: 0x04006CE7 RID: 27879
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtons;

		// Token: 0x04006CE8 RID: 27880
		private static readonly IntPtr NativeFieldInfoPtr_categoryFilter;

		// Token: 0x04006CE9 RID: 27881
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x04006CEA RID: 27882
		private static readonly IntPtr NativeFieldInfoPtr_listingUI;

		// Token: 0x04006CEB RID: 27883
		private static readonly IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04006CEC RID: 27884
		private static readonly IntPtr NativeFieldInfoPtr_dropdownMouseUp;

		// Token: 0x04006CED RID: 27885
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04006CEE RID: 27886
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04006CEF RID: 27887
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04006CF0 RID: 27888
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04006CF1 RID: 27889
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CF2 RID: 27890
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006CF3 RID: 27891
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006CF4 RID: 27892
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006CF5 RID: 27893
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04006CF6 RID: 27894
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006CF7 RID: 27895
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006CF8 RID: 27896
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006CF9 RID: 27897
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006CFA RID: 27898
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006CFB RID: 27899
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006CFC RID: 27900
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04006CFD RID: 27901
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006CFE RID: 27902
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006CFF RID: 27903
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04006D00 RID: 27904
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006D01 RID: 27905
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006D02 RID: 27906
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006D03 RID: 27907
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Void_0;

		// Token: 0x04006D04 RID: 27908
		private static readonly IntPtr NativeMethodInfoPtr_OnWeekPass_Protected_Void_0;

		// Token: 0x04006D05 RID: 27909
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006D06 RID: 27910
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006D07 RID: 27911
		private static readonly IntPtr NativeMethodInfoPtr_Hint_Private_Void_0;

		// Token: 0x04006D08 RID: 27912
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006D09 RID: 27913
		private static readonly IntPtr NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0;

		// Token: 0x04006D0A RID: 27914
		private static readonly IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0;

		// Token: 0x04006D0B RID: 27915
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0;

		// Token: 0x04006D0C RID: 27916
		private static readonly IntPtr NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0;

		// Token: 0x04006D0D RID: 27917
		private static readonly IntPtr NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0;

		// Token: 0x04006D0E RID: 27918
		private static readonly IntPtr NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0;

		// Token: 0x04006D0F RID: 27919
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownItems_Private_Void_0;

		// Token: 0x04006D10 RID: 27920
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0;

		// Token: 0x04006D11 RID: 27921
		private static readonly IntPtr NativeMethodInfoPtr_RestockAllListings_Private_Void_0;

		// Token: 0x04006D12 RID: 27922
		private static readonly IntPtr NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0;

		// Token: 0x04006D13 RID: 27923
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_0;

		// Token: 0x04006D14 RID: 27924
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0;

		// Token: 0x04006D15 RID: 27925
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0;

		// Token: 0x04006D16 RID: 27926
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04006D17 RID: 27927
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0;

		// Token: 0x04006D18 RID: 27928
		private static readonly IntPtr NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0;

		// Token: 0x04006D19 RID: 27929
		private static readonly IntPtr NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0;

		// Token: 0x04006D1A RID: 27930
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0;

		// Token: 0x04006D1B RID: 27931
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0;

		// Token: 0x04006D1C RID: 27932
		private static readonly IntPtr NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0;

		// Token: 0x04006D1D RID: 27933
		private static readonly IntPtr NativeMethodInfoPtr_EntryUnhovered_Private_Void_0;

		// Token: 0x04006D1E RID: 27934
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ShopData_0;

		// Token: 0x04006D1F RID: 27935
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04006D20 RID: 27936
		private static readonly IntPtr NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0;

		// Token: 0x04006D21 RID: 27937
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04006D22 RID: 27938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D23 RID: 27939
		private static readonly IntPtr NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0;

		// Token: 0x02000BB5 RID: 2997
		[OriginalName("Assembly-CSharp.dll", "", "EPaymentType")]
		public enum EPaymentType
		{
			// Token: 0x04009438 RID: 37944
			Cash,
			// Token: 0x04009439 RID: 37945
			Online,
			// Token: 0x0400943A RID: 37946
			PreferCash,
			// Token: 0x0400943B RID: 37947
			PreferOnline
		}

		// Token: 0x02000BB6 RID: 2998
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DD41 RID: 56641 RVA: 0x00344268 File Offset: 0x00342468
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr);
				ShopInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9");
				ShopInterface.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__55_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_1");
				ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683188);
				ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683189);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683190);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683191);
			}

			// Token: 0x0600DD42 RID: 56642 RVA: 0x00344334 File Offset: 0x00342534
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD43 RID: 56643 RVA: 0x00344370 File Offset: 0x00342570
			[CallerCount(0)]
			public unsafe string _Awake_b__55_0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DD44 RID: 56644 RVA: 0x003443B8 File Offset: 0x003425B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284318, XrefRangeEnd = 284319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshShownItems_b__73_0(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD45 RID: 56645 RVA: 0x00344408 File Offset: 0x00342608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284319, XrefRangeEnd = 284321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RefreshShownItems_b__73_1(ListingUI x, ListingUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD46 RID: 56646 RVA: 0x0006BD59 File Offset: 0x00069F59
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004493 RID: 17555
			// (get) Token: 0x0600DD47 RID: 56647 RVA: 0x00344468 File Offset: 0x00342668
			// (set) Token: 0x0600DD48 RID: 56648 RVA: 0x0006BD62 File Offset: 0x00069F62
			public unsafe static ShopInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004494 RID: 17556
			// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x00344490 File Offset: 0x00342690
			// (set) Token: 0x0600DD4A RID: 56650 RVA: 0x0006BD74 File Offset: 0x00069F74
			public unsafe static Func<ShopListing, string> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ShopListing, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004495 RID: 17557
			// (get) Token: 0x0600DD4B RID: 56651 RVA: 0x003444B8 File Offset: 0x003426B8
			// (set) Token: 0x0600DD4C RID: 56652 RVA: 0x0006BD86 File Offset: 0x00069F86
			public unsafe static Predicate<ListingUI> __9__73_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004496 RID: 17558
			// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x003444E0 File Offset: 0x003426E0
			// (set) Token: 0x0600DD4E RID: 56654 RVA: 0x0006BD98 File Offset: 0x00069F98
			public unsafe static Comparison<ListingUI> __9__73_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400943C RID: 37948
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400943D RID: 37949
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x0400943E RID: 37950
			private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x0400943F RID: 37951
			private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x04009440 RID: 37952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009441 RID: 37953
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0;

			// Token: 0x04009442 RID: 37954
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0;

			// Token: 0x04009443 RID: 37955
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0;
		}

		// Token: 0x02000BB7 RID: 2999
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD4F RID: 56655 RVA: 0x00344508 File Offset: 0x00342708
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "ui");
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683192);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683193);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683194);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683195);
			}

			// Token: 0x0600DD50 RID: 56656 RVA: 0x003445AC File Offset: 0x003427AC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD51 RID: 56657 RVA: 0x003445E8 File Offset: 0x003427E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284321, XrefRangeEnd = 284322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD52 RID: 56658 RVA: 0x0034461C File Offset: 0x0034281C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284322, XrefRangeEnd = 284324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD53 RID: 56659 RVA: 0x00344650 File Offset: 0x00342850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284324, XrefRangeEnd = 284326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD54 RID: 56660 RVA: 0x0006BDAA File Offset: 0x00069FAA
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004497 RID: 17559
			// (get) Token: 0x0600DD55 RID: 56661 RVA: 0x00344684 File Offset: 0x00342884
			// (set) Token: 0x0600DD56 RID: 56662 RVA: 0x0006BDB3 File Offset: 0x00069FB3
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004498 RID: 17560
			// (get) Token: 0x0600DD57 RID: 56663 RVA: 0x003446B4 File Offset: 0x003428B4
			// (set) Token: 0x0600DD58 RID: 56664 RVA: 0x0006BDD2 File Offset: 0x00069FD2
			public unsafe ListingUI ui
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009444 RID: 37956
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009445 RID: 37957
			private static readonly IntPtr NativeFieldInfoPtr_ui;

			// Token: 0x04009446 RID: 37958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009447 RID: 37959
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0;

			// Token: 0x04009448 RID: 37960
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0;

			// Token: 0x04009449 RID: 37961
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0;
		}

		// Token: 0x02000BB8 RID: 3000
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD59 RID: 56665 RVA: 0x003446E4 File Offset: 0x003428E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, "category");
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683196);
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683197);
			}

			// Token: 0x0600DD5A RID: 56666 RVA: 0x0034474C File Offset: 0x0034294C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD5B RID: 56667 RVA: 0x00344788 File Offset: 0x00342988
			[CallerCount(0)]
			public unsafe bool _SelectCategory_b__0(CategoryButton x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x0006BDF1 File Offset: 0x00069FF1
			public __c__DisplayClass68_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004499 RID: 17561
			// (get) Token: 0x0600DD5D RID: 56669 RVA: 0x003447D8 File Offset: 0x003429D8
			// (set) Token: 0x0600DD5E RID: 56670 RVA: 0x0006BDFA File Offset: 0x00069FFA
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x0400944A RID: 37962
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400944B RID: 37963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400944C RID: 37964
			private static readonly IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0;
		}

		// Token: 0x02000BB9 RID: 3001
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD5F RID: 56671 RVA: 0x00344800 File Offset: 0x00342A00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "listing");
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683198);
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683199);
			}

			// Token: 0x0600DD60 RID: 56672 RVA: 0x0034487C File Offset: 0x00342A7C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD61 RID: 56673 RVA: 0x003448B8 File Offset: 0x00342AB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284367, RefRangeEnd = 284368, XrefRangeStart = 284362, XrefRangeEnd = 284367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD62 RID: 56674 RVA: 0x0006BE15 File Offset: 0x0006A015
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449A RID: 17562
			// (get) Token: 0x0600DD63 RID: 56675 RVA: 0x003448F8 File Offset: 0x00342AF8
			// (set) Token: 0x0600DD64 RID: 56676 RVA: 0x0006BE1E File Offset: 0x0006A01E
			public unsafe ListingUI listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449B RID: 17563
			// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x00344928 File Offset: 0x00342B28
			// (set) Token: 0x0600DD66 RID: 56678 RVA: 0x0006BE3D File Offset: 0x0006A03D
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400944D RID: 37965
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x0400944E RID: 37966
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400944F RID: 37967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009450 RID: 37968
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C82 RID: 3202
			[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0+<<ShowCartAnimation>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E68C RID: 59020 RVA: 0x0035F108 File Offset: 0x0035D308
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique()
				{
					Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<<ShowCartAnimation>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>1__state");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>2__current");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>4__this");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<iconRect>5__2");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startPos>5__3");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endPos>5__4");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startScale>5__5");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endScale>5__6");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<lerpTime>5__7");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<i>5__8");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683200);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683201);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683202);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683203);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683204);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683205);
				}

				// Token: 0x0600E68D RID: 59021 RVA: 0x0035F274 File Offset: 0x0035D474
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E68E RID: 59022 RVA: 0x0035F2BC File Offset: 0x0035D4BC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E68F RID: 59023 RVA: 0x0035F2F0 File Offset: 0x0035D4F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284326, XrefRangeEnd = 284357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047D3 RID: 18387
				// (get) Token: 0x0600E690 RID: 59024 RVA: 0x0035F32C File Offset: 0x0035D52C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E691 RID: 59025 RVA: 0x0035F36C File Offset: 0x0035D56C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284357, XrefRangeEnd = 284362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047D4 RID: 18388
				// (get) Token: 0x0600E692 RID: 59026 RVA: 0x0035F3A0 File Offset: 0x0035D5A0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E693 RID: 59027 RVA: 0x000708AB File Offset: 0x0006EAAB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047C9 RID: 18377
				// (get) Token: 0x0600E694 RID: 59028 RVA: 0x0035F3E0 File Offset: 0x0035D5E0
				// (set) Token: 0x0600E695 RID: 59029 RVA: 0x000708B4 File Offset: 0x0006EAB4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047CA RID: 18378
				// (get) Token: 0x0600E696 RID: 59030 RVA: 0x0035F408 File Offset: 0x0035D608
				// (set) Token: 0x0600E697 RID: 59031 RVA: 0x000708CF File Offset: 0x0006EACF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047CB RID: 18379
				// (get) Token: 0x0600E698 RID: 59032 RVA: 0x0035F438 File Offset: 0x0035D638
				// (set) Token: 0x0600E699 RID: 59033 RVA: 0x000708EE File Offset: 0x0006EAEE
				public unsafe ShopInterface.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047CC RID: 18380
				// (get) Token: 0x0600E69A RID: 59034 RVA: 0x0035F468 File Offset: 0x0035D668
				// (set) Token: 0x0600E69B RID: 59035 RVA: 0x0007090D File Offset: 0x0006EB0D
				public unsafe RectTransform _iconRect_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047CD RID: 18381
				// (get) Token: 0x0600E69C RID: 59036 RVA: 0x0035F498 File Offset: 0x0035D698
				// (set) Token: 0x0600E69D RID: 59037 RVA: 0x0007092C File Offset: 0x0006EB2C
				public unsafe Vector3 _startPos_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
					}
				}

				// Token: 0x170047CE RID: 18382
				// (get) Token: 0x0600E69E RID: 59038 RVA: 0x0035F4C0 File Offset: 0x0035D6C0
				// (set) Token: 0x0600E69F RID: 59039 RVA: 0x00070947 File Offset: 0x0006EB47
				public unsafe Vector2 _endPos_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
					}
				}

				// Token: 0x170047CF RID: 18383
				// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x0035F4E8 File Offset: 0x0035D6E8
				// (set) Token: 0x0600E6A1 RID: 59041 RVA: 0x00070962 File Offset: 0x0006EB62
				public unsafe Vector3 _startScale_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5)) = value;
					}
				}

				// Token: 0x170047D0 RID: 18384
				// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x0035F510 File Offset: 0x0035D710
				// (set) Token: 0x0600E6A3 RID: 59043 RVA: 0x0007097D File Offset: 0x0006EB7D
				public unsafe Vector3 _endScale_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6)) = value;
					}
				}

				// Token: 0x170047D1 RID: 18385
				// (get) Token: 0x0600E6A4 RID: 59044 RVA: 0x0035F538 File Offset: 0x0035D738
				// (set) Token: 0x0600E6A5 RID: 59045 RVA: 0x00070998 File Offset: 0x0006EB98
				public unsafe float _lerpTime_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7)) = value;
					}
				}

				// Token: 0x170047D2 RID: 18386
				// (get) Token: 0x0600E6A6 RID: 59046 RVA: 0x0035F560 File Offset: 0x0035D760
				// (set) Token: 0x0600E6A7 RID: 59047 RVA: 0x000709B3 File Offset: 0x0006EBB3
				public unsafe float _i_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x04009A14 RID: 39444
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A15 RID: 39445
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A16 RID: 39446
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A17 RID: 39447
				private static readonly IntPtr NativeFieldInfoPtr__iconRect_5__2;

				// Token: 0x04009A18 RID: 39448
				private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

				// Token: 0x04009A19 RID: 39449
				private static readonly IntPtr NativeFieldInfoPtr__endPos_5__4;

				// Token: 0x04009A1A RID: 39450
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__5;

				// Token: 0x04009A1B RID: 39451
				private static readonly IntPtr NativeFieldInfoPtr__endScale_5__6;

				// Token: 0x04009A1C RID: 39452
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__7;

				// Token: 0x04009A1D RID: 39453
				private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x04009A1E RID: 39454
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A1F RID: 39455
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A20 RID: 39456
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A21 RID: 39457
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A22 RID: 39458
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A23 RID: 39459
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BBA RID: 3002
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD67 RID: 56679 RVA: 0x00344958 File Offset: 0x00342B58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, "stockQuantity");
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683206);
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683207);
			}

			// Token: 0x0600DD68 RID: 56680 RVA: 0x003449C0 File Offset: 0x00342BC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD69 RID: 56681 RVA: 0x003449FC File Offset: 0x00342BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284368, XrefRangeEnd = 284370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD6A RID: 56682 RVA: 0x0006BE5C File Offset: 0x0006A05C
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449C RID: 17564
			// (get) Token: 0x0600DD6B RID: 56683 RVA: 0x00344A4C File Offset: 0x00342C4C
			// (set) Token: 0x0600DD6C RID: 56684 RVA: 0x0006BE65 File Offset: 0x0006A065
			public unsafe StringIntPair stockQuantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009451 RID: 37969
			private static readonly IntPtr NativeFieldInfoPtr_stockQuantity;

			// Token: 0x04009452 RID: 37970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009453 RID: 37971
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0;
		}

		// Token: 0x02000BBB RID: 3003
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD6D RID: 56685 RVA: 0x00344A7C File Offset: 0x00342C7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, "itemID");
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683208);
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683209);
			}

			// Token: 0x0600DD6E RID: 56686 RVA: 0x00344AE4 File Offset: 0x00342CE4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD6F RID: 56687 RVA: 0x00344B20 File Offset: 0x00342D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284370, XrefRangeEnd = 284379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetListing_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD70 RID: 56688 RVA: 0x0006BE84 File Offset: 0x0006A084
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449D RID: 17565
			// (get) Token: 0x0600DD71 RID: 56689 RVA: 0x00344B70 File Offset: 0x00342D70
			// (set) Token: 0x0600DD72 RID: 56690 RVA: 0x0006BE8D File Offset: 0x0006A08D
			public unsafe string itemID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009454 RID: 37972
			private static readonly IntPtr NativeFieldInfoPtr_itemID;

			// Token: 0x04009455 RID: 37973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009456 RID: 37974
			private static readonly IntPtr NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0;
		}
	}
}
