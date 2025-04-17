using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006AA RID: 1706
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x060098DE RID: 39134 RVA: 0x0026FAE4 File Offset: 0x0026DCE4
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryShop()
		{
			Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr);
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_VEHICLE_SLOT_CAPACITY");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MIN");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MAX");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_ITEM_COUNT_DIVISOR");
			DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<MatchingShop>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsExpanded>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsAvailable>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage");
			DeliveryShop.NativeFieldInfoPtr_HeaderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderButton");
			DeliveryShop.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ContentsContainer");
			DeliveryShop.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingContainer");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFeeLabel");
			DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ItemTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButton");
			DeliveryShop.NativeFieldInfoPtr_OrderButtonNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButtonNote");
			DeliveryShop.NativeFieldInfoPtr_DestinationDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DestinationDropdown");
			DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "LoadingDockDropdown");
			DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "MatchingShopInterfaceName");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFee");
			DeliveryShop.NativeFieldInfoPtr_AvailableByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "AvailableByDefault");
			DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingEntryPrefab");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Hidden");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Expanded");
			DeliveryShop.NativeFieldInfoPtr_HeaderArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderArrow");
			DeliveryShop.NativeFieldInfoPtr_listingEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "listingEntries");
			DeliveryShop.NativeFieldInfoPtr_destinationProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "destinationProperty");
			DeliveryShop.NativeFieldInfoPtr_loadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "loadingDockIndex");
			DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682175);
			DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682176);
			DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682177);
			DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682178);
			DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682179);
			DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682180);
			DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682181);
			DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682182);
			DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682183);
			DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682184);
			DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682185);
			DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682186);
			DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682187);
			DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682188);
			DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682189);
			DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682190);
			DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682191);
			DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682192);
			DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682193);
			DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682194);
			DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682195);
			DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682196);
			DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682197);
			DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682198);
			DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682199);
			DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682200);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682201);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682202);
			DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682203);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682204);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682205);
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x060098DF RID: 39135 RVA: 0x0026FFB0 File Offset: 0x0026E1B0
		// (set) Token: 0x060098E0 RID: 39136 RVA: 0x0026FFF0 File Offset: 0x0026E1F0
		public unsafe ShopInterface MatchingShop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x060098E1 RID: 39137 RVA: 0x00270034 File Offset: 0x0026E234
		// (set) Token: 0x060098E2 RID: 39138 RVA: 0x00270070 File Offset: 0x0026E270
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x060098E3 RID: 39139 RVA: 0x002700B0 File Offset: 0x0026E2B0
		// (set) Token: 0x060098E4 RID: 39140 RVA: 0x002700EC File Offset: 0x0026E2EC
		public unsafe bool IsAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x0027012C File Offset: 0x0026E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272860, XrefRangeEnd = 272958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x00270160 File Offset: 0x0026E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272958, XrefRangeEnd = 272964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x00270194 File Offset: 0x0026E394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272977, RefRangeEnd = 272979, XrefRangeStart = 272964, XrefRangeEnd = 272977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsExpanded(bool expanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expanded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x002701D4 File Offset: 0x0026E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272979, XrefRangeEnd = 272987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x00270208 File Offset: 0x0026E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272987, XrefRangeEnd = 273061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x0027023C File Offset: 0x0026E43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273061, XrefRangeEnd = 273067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x00270270 File Offset: 0x0026E470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273086, RefRangeEnd = 273087, XrefRangeStart = 273067, XrefRangeEnd = 273086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x002702A4 File Offset: 0x0026E4A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 273092, RefRangeEnd = 273095, XrefRangeStart = 273087, XrefRangeEnd = 273092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x002702D8 File Offset: 0x0026E4D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273098, RefRangeEnd = 273102, XrefRangeStart = 273095, XrefRangeEnd = 273098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOrderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x0027030C File Offset: 0x0026E50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273125, RefRangeEnd = 273127, XrefRangeStart = 273102, XrefRangeEnd = 273125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOrder(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x00270364 File Offset: 0x0026E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273127, XrefRangeEnd = 273136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActiveDelivery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x002703A0 File Offset: 0x0026E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273136, XrefRangeEnd = 273150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFitInVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x002703DC File Offset: 0x0026E5DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273203, RefRangeEnd = 273205, XrefRangeStart = 273150, XrefRangeEnd = 273203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDestinationUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098F2 RID: 39154 RVA: 0x00270410 File Offset: 0x0026E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273205, XrefRangeEnd = 273217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x00270450 File Offset: 0x0026E650
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 273227, RefRangeEnd = 273232, XrefRangeStart = 273217, XrefRangeEnd = 273227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetPotentialDestinations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00270490 File Offset: 0x0026E690
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273268, RefRangeEnd = 273272, XrefRangeStart = 273232, XrefRangeEnd = 273268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLoadingDockUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x002704C4 File Offset: 0x0026E6C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 49913, RefRangeEnd = 49917, XrefRangeStart = 49913, XrefRangeEnd = 49917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadingDockDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x00270504 File Offset: 0x0026E704
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 273287, RefRangeEnd = 273291, XrefRangeStart = 273272, XrefRangeEnd = 273287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCartCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x00270540 File Offset: 0x0026E740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273291, XrefRangeEnd = 273292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x0027057C File Offset: 0x0026E77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273306, RefRangeEnd = 273307, XrefRangeStart = 273292, XrefRangeEnd = 273306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrderItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x002705B8 File Offset: 0x0026E7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273348, RefRangeEnd = 273350, XrefRangeStart = 273307, XrefRangeEnd = 273348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntryOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FA RID: 39162 RVA: 0x002705EC File Offset: 0x0026E7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273370, RefRangeEnd = 273372, XrefRangeStart = 273350, XrefRangeEnd = 273370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntriesLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FB RID: 39163 RVA: 0x00270620 File Offset: 0x0026E820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273372, XrefRangeEnd = 273384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x0027065C File Offset: 0x0026E85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__37_0(ShopInterface x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x002706AC File Offset: 0x0026E8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273384, XrefRangeEnd = 273385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__37_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x0004A7ED File Offset: 0x000489ED
		public DeliveryShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x060098FF RID: 39167 RVA: 0x002706E0 File Offset: 0x0026E8E0
		// (set) Token: 0x06009900 RID: 39168 RVA: 0x0004A7F6 File Offset: 0x000489F6
		public unsafe static int DELIVERY_VEHICLE_SLOT_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x06009901 RID: 39169 RVA: 0x002706FC File Offset: 0x0026E8FC
		// (set) Token: 0x06009902 RID: 39170 RVA: 0x0004A804 File Offset: 0x00048A04
		public unsafe static int DELIVERY_TIME_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x06009903 RID: 39171 RVA: 0x00270718 File Offset: 0x0026E918
		// (set) Token: 0x06009904 RID: 39172 RVA: 0x0004A812 File Offset: 0x00048A12
		public unsafe static int DELIVERY_TIME_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x06009905 RID: 39173 RVA: 0x00270734 File Offset: 0x0026E934
		// (set) Token: 0x06009906 RID: 39174 RVA: 0x0004A820 File Offset: 0x00048A20
		public unsafe static int DELIVERY_TIME_ITEM_COUNT_DIVISOR
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&value));
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x06009907 RID: 39175 RVA: 0x00270750 File Offset: 0x0026E950
		// (set) Token: 0x06009908 RID: 39176 RVA: 0x0004A82E File Offset: 0x00048A2E
		public unsafe ShopInterface _MatchingShop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x06009909 RID: 39177 RVA: 0x00270780 File Offset: 0x0026E980
		// (set) Token: 0x0600990A RID: 39178 RVA: 0x0004A84D File Offset: 0x00048A4D
		public unsafe bool _IsExpanded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x0600990B RID: 39179 RVA: 0x002707A8 File Offset: 0x0026E9A8
		// (set) Token: 0x0600990C RID: 39180 RVA: 0x0004A868 File Offset: 0x00048A68
		public unsafe bool _IsAvailable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x002707D0 File Offset: 0x0026E9D0
		// (set) Token: 0x0600990E RID: 39182 RVA: 0x0004A883 File Offset: 0x00048A83
		public unsafe Image HeaderImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600990F RID: 39183 RVA: 0x00270800 File Offset: 0x0026EA00
		// (set) Token: 0x06009910 RID: 39184 RVA: 0x0004A8A2 File Offset: 0x00048AA2
		public unsafe Button HeaderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x06009911 RID: 39185 RVA: 0x00270830 File Offset: 0x0026EA30
		// (set) Token: 0x06009912 RID: 39186 RVA: 0x0004A8C1 File Offset: 0x00048AC1
		public unsafe RectTransform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x06009913 RID: 39187 RVA: 0x00270860 File Offset: 0x0026EA60
		// (set) Token: 0x06009914 RID: 39188 RVA: 0x0004A8E0 File Offset: 0x00048AE0
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x06009915 RID: 39189 RVA: 0x00270890 File Offset: 0x0026EA90
		// (set) Token: 0x06009916 RID: 39190 RVA: 0x0004A8FF File Offset: 0x00048AFF
		public unsafe Text DeliveryFeeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x002708C0 File Offset: 0x0026EAC0
		// (set) Token: 0x06009918 RID: 39192 RVA: 0x0004A91E File Offset: 0x00048B1E
		public unsafe Text ItemTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x002708F0 File Offset: 0x0026EAF0
		// (set) Token: 0x0600991A RID: 39194 RVA: 0x0004A93D File Offset: 0x00048B3D
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600991B RID: 39195 RVA: 0x00270920 File Offset: 0x0026EB20
		// (set) Token: 0x0600991C RID: 39196 RVA: 0x0004A95C File Offset: 0x00048B5C
		public unsafe Button OrderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600991D RID: 39197 RVA: 0x00270950 File Offset: 0x0026EB50
		// (set) Token: 0x0600991E RID: 39198 RVA: 0x0004A97B File Offset: 0x00048B7B
		public unsafe Text OrderButtonNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600991F RID: 39199 RVA: 0x00270980 File Offset: 0x0026EB80
		// (set) Token: 0x06009920 RID: 39200 RVA: 0x0004A99A File Offset: 0x00048B9A
		public unsafe Dropdown DestinationDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x06009921 RID: 39201 RVA: 0x002709B0 File Offset: 0x0026EBB0
		// (set) Token: 0x06009922 RID: 39202 RVA: 0x0004A9B9 File Offset: 0x00048BB9
		public unsafe Dropdown LoadingDockDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x06009923 RID: 39203 RVA: 0x002709E0 File Offset: 0x0026EBE0
		// (set) Token: 0x06009924 RID: 39204 RVA: 0x0004A9D8 File Offset: 0x00048BD8
		public unsafe string MatchingShopInterfaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x06009925 RID: 39205 RVA: 0x00270A08 File Offset: 0x0026EC08
		// (set) Token: 0x06009926 RID: 39206 RVA: 0x0004A9F7 File Offset: 0x00048BF7
		public unsafe float DeliveryFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee)) = value;
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x00270A30 File Offset: 0x0026EC30
		// (set) Token: 0x06009928 RID: 39208 RVA: 0x0004AA12 File Offset: 0x00048C12
		public unsafe bool AvailableByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault)) = value;
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x06009929 RID: 39209 RVA: 0x00270A58 File Offset: 0x0026EC58
		// (set) Token: 0x0600992A RID: 39210 RVA: 0x0004AA2D File Offset: 0x00048C2D
		public unsafe ListingEntry ListingEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600992B RID: 39211 RVA: 0x00270A88 File Offset: 0x0026EC88
		// (set) Token: 0x0600992C RID: 39212 RVA: 0x0004AA4C File Offset: 0x00048C4C
		public unsafe Sprite HeaderImage_Hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600992D RID: 39213 RVA: 0x00270AB8 File Offset: 0x0026ECB8
		// (set) Token: 0x0600992E RID: 39214 RVA: 0x0004AA6B File Offset: 0x00048C6B
		public unsafe Sprite HeaderImage_Expanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x00270AE8 File Offset: 0x0026ECE8
		// (set) Token: 0x06009930 RID: 39216 RVA: 0x0004AA8A File Offset: 0x00048C8A
		public unsafe RectTransform HeaderArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00270B18 File Offset: 0x0026ED18
		// (set) Token: 0x06009932 RID: 39218 RVA: 0x0004AAA9 File Offset: 0x00048CA9
		public unsafe List<ListingEntry> listingEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x00270B48 File Offset: 0x0026ED48
		// (set) Token: 0x06009934 RID: 39220 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		public unsafe Property destinationProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x00270B78 File Offset: 0x0026ED78
		// (set) Token: 0x06009936 RID: 39222 RVA: 0x0004AAE7 File Offset: 0x00048CE7
		public unsafe int loadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex)) = value;
			}
		}

		// Token: 0x040066EF RID: 26351
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY;

		// Token: 0x040066F0 RID: 26352
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MIN;

		// Token: 0x040066F1 RID: 26353
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MAX;

		// Token: 0x040066F2 RID: 26354
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR;

		// Token: 0x040066F3 RID: 26355
		private static readonly IntPtr NativeFieldInfoPtr__MatchingShop_k__BackingField;

		// Token: 0x040066F4 RID: 26356
		private static readonly IntPtr NativeFieldInfoPtr__IsExpanded_k__BackingField;

		// Token: 0x040066F5 RID: 26357
		private static readonly IntPtr NativeFieldInfoPtr__IsAvailable_k__BackingField;

		// Token: 0x040066F6 RID: 26358
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage;

		// Token: 0x040066F7 RID: 26359
		private static readonly IntPtr NativeFieldInfoPtr_HeaderButton;

		// Token: 0x040066F8 RID: 26360
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x040066F9 RID: 26361
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x040066FA RID: 26362
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFeeLabel;

		// Token: 0x040066FB RID: 26363
		private static readonly IntPtr NativeFieldInfoPtr_ItemTotalLabel;

		// Token: 0x040066FC RID: 26364
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x040066FD RID: 26365
		private static readonly IntPtr NativeFieldInfoPtr_OrderButton;

		// Token: 0x040066FE RID: 26366
		private static readonly IntPtr NativeFieldInfoPtr_OrderButtonNote;

		// Token: 0x040066FF RID: 26367
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDropdown;

		// Token: 0x04006700 RID: 26368
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockDropdown;

		// Token: 0x04006701 RID: 26369
		private static readonly IntPtr NativeFieldInfoPtr_MatchingShopInterfaceName;

		// Token: 0x04006702 RID: 26370
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFee;

		// Token: 0x04006703 RID: 26371
		private static readonly IntPtr NativeFieldInfoPtr_AvailableByDefault;

		// Token: 0x04006704 RID: 26372
		private static readonly IntPtr NativeFieldInfoPtr_ListingEntryPrefab;

		// Token: 0x04006705 RID: 26373
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Hidden;

		// Token: 0x04006706 RID: 26374
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Expanded;

		// Token: 0x04006707 RID: 26375
		private static readonly IntPtr NativeFieldInfoPtr_HeaderArrow;

		// Token: 0x04006708 RID: 26376
		private static readonly IntPtr NativeFieldInfoPtr_listingEntries;

		// Token: 0x04006709 RID: 26377
		private static readonly IntPtr NativeFieldInfoPtr_destinationProperty;

		// Token: 0x0400670A RID: 26378
		private static readonly IntPtr NativeFieldInfoPtr_loadingDockIndex;

		// Token: 0x0400670B RID: 26379
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0;

		// Token: 0x0400670C RID: 26380
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0;

		// Token: 0x0400670D RID: 26381
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x0400670E RID: 26382
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0;

		// Token: 0x0400670F RID: 26383
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0;

		// Token: 0x04006710 RID: 26384
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0;

		// Token: 0x04006711 RID: 26385
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006712 RID: 26386
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006713 RID: 26387
		private static readonly IntPtr NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0;

		// Token: 0x04006714 RID: 26388
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAvailable_Public_Void_0;

		// Token: 0x04006715 RID: 26389
		private static readonly IntPtr NativeMethodInfoPtr_OrderPressed_Public_Void_0;

		// Token: 0x04006716 RID: 26390
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShop_Public_Void_0;

		// Token: 0x04006717 RID: 26391
		private static readonly IntPtr NativeMethodInfoPtr_ResetCart_Public_Void_0;

		// Token: 0x04006718 RID: 26392
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCart_Private_Void_0;

		// Token: 0x04006719 RID: 26393
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0;

		// Token: 0x0400671A RID: 26394
		private static readonly IntPtr NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0;

		// Token: 0x0400671B RID: 26395
		private static readonly IntPtr NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0;

		// Token: 0x0400671C RID: 26396
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0;

		// Token: 0x0400671D RID: 26397
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0;

		// Token: 0x0400671E RID: 26398
		private static readonly IntPtr NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0;

		// Token: 0x0400671F RID: 26399
		private static readonly IntPtr NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0;

		// Token: 0x04006720 RID: 26400
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0;

		// Token: 0x04006721 RID: 26401
		private static readonly IntPtr NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0;

		// Token: 0x04006722 RID: 26402
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCost_Private_Single_0;

		// Token: 0x04006723 RID: 26403
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_0;

		// Token: 0x04006724 RID: 26404
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0;

		// Token: 0x04006725 RID: 26405
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0;

		// Token: 0x04006726 RID: 26406
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0;

		// Token: 0x04006727 RID: 26407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006728 RID: 26408
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0;

		// Token: 0x04006729 RID: 26409
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_1_Private_Void_0;
	}
}
