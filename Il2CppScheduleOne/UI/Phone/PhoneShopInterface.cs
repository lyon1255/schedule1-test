using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069E RID: 1694
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x06009716 RID: 38678 RVA: 0x0026A4C8 File Offset: 0x002686C8
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneShopInterface()
		{
			Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "PhoneShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr);
			PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryPrefab");
			PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ValidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "InvalidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Container");
			PhoneShopInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "TitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "SubtitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryContainer");
			PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderTotalLabel");
			PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr_DebtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "DebtLabel");
			PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ConfirmButton");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitContainer");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_entries");
			PhoneShopInterface.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_items");
			PhoneShopInterface.NativeFieldInfoPtr__cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_cart");
			PhoneShopInterface.NativeFieldInfoPtr_orderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderLimit");
			PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderConfirmedCallback");
			PhoneShopInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "conversation");
			PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681949);
			PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681950);
			PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681951);
			PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681952);
			PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681953);
			PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681954);
			PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681955);
			PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681956);
			PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681957);
			PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681958);
			PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681959);
			PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681960);
			PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100681961);
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x06009717 RID: 38679 RVA: 0x0026A78C File Offset: 0x0026898C
		// (set) Token: 0x06009718 RID: 38680 RVA: 0x0026A7C8 File Offset: 0x002689C8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x0026A808 File Offset: 0x00268A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270422, XrefRangeEnd = 270443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0026A83C File Offset: 0x00268A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 270572, RefRangeEnd = 270573, XrefRangeStart = 270443, XrefRangeEnd = 270572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _orderLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debt;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x0026A8E4 File Offset: 0x00268AE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270611, RefRangeEnd = 270614, XrefRangeStart = 270573, XrefRangeEnd = 270611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x0026A918 File Offset: 0x00268B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270614, XrefRangeEnd = 270615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x0026A95C File Offset: 0x00268B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270656, RefRangeEnd = 270658, XrefRangeStart = 270615, XrefRangeEnd = 270656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x0026A9AC File Offset: 0x00268BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270672, RefRangeEnd = 270674, XrefRangeStart = 270658, XrefRangeEnd = 270672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x0026A9E0 File Offset: 0x00268BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270674, XrefRangeEnd = 270677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmOrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x0026AA14 File Offset: 0x00268C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270677, XrefRangeEnd = 270678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConfirmOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x0026AA50 File Offset: 0x00268C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270678, XrefRangeEnd = 270687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x0026AA84 File Offset: 0x00268C84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 270701, RefRangeEnd = 270706, XrefRangeStart = 270687, XrefRangeEnd = 270701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal(out int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &itemCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x0026AAD0 File Offset: 0x00268CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270706, XrefRangeEnd = 270728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x0004967B File Offset: 0x0004787B
		public PhoneShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x0026AB0C File Offset: 0x00268D0C
		// (set) Token: 0x06009726 RID: 38694 RVA: 0x00049684 File Offset: 0x00047884
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x0026AB34 File Offset: 0x00268D34
		// (set) Token: 0x06009728 RID: 38696 RVA: 0x0004969F File Offset: 0x0004789F
		public unsafe RectTransform EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0026AB64 File Offset: 0x00268D64
		// (set) Token: 0x0600972A RID: 38698 RVA: 0x000496BE File Offset: 0x000478BE
		public unsafe Color ValidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor)) = value;
			}
		}

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x0026AB8C File Offset: 0x00268D8C
		// (set) Token: 0x0600972C RID: 38700 RVA: 0x000496D9 File Offset: 0x000478D9
		public unsafe Color InvalidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor)) = value;
			}
		}

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0026ABB4 File Offset: 0x00268DB4
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x000496F4 File Offset: 0x000478F4
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0026ABE4 File Offset: 0x00268DE4
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x00049713 File Offset: 0x00047913
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x06009731 RID: 38705 RVA: 0x0026AC14 File Offset: 0x00268E14
		// (set) Token: 0x06009732 RID: 38706 RVA: 0x00049732 File Offset: 0x00047932
		public unsafe Text SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x06009733 RID: 38707 RVA: 0x0026AC44 File Offset: 0x00268E44
		// (set) Token: 0x06009734 RID: 38708 RVA: 0x00049751 File Offset: 0x00047951
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x06009735 RID: 38709 RVA: 0x0026AC74 File Offset: 0x00268E74
		// (set) Token: 0x06009736 RID: 38710 RVA: 0x00049770 File Offset: 0x00047970
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x0026ACA4 File Offset: 0x00268EA4
		// (set) Token: 0x06009738 RID: 38712 RVA: 0x0004978F File Offset: 0x0004798F
		public unsafe Text OrderLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x0026ACD4 File Offset: 0x00268ED4
		// (set) Token: 0x0600973A RID: 38714 RVA: 0x000497AE File Offset: 0x000479AE
		public unsafe Text DebtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x0026AD04 File Offset: 0x00268F04
		// (set) Token: 0x0600973C RID: 38716 RVA: 0x000497CD File Offset: 0x000479CD
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0026AD34 File Offset: 0x00268F34
		// (set) Token: 0x0600973E RID: 38718 RVA: 0x000497EC File Offset: 0x000479EC
		public unsafe GameObject ItemLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0026AD64 File Offset: 0x00268F64
		// (set) Token: 0x06009740 RID: 38720 RVA: 0x0004980B File Offset: 0x00047A0B
		public unsafe Text ItemLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x06009741 RID: 38721 RVA: 0x0026AD94 File Offset: 0x00268F94
		// (set) Token: 0x06009742 RID: 38722 RVA: 0x0004982A File Offset: 0x00047A2A
		public unsafe List<RectTransform> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x06009743 RID: 38723 RVA: 0x0026ADC4 File Offset: 0x00268FC4
		// (set) Token: 0x06009744 RID: 38724 RVA: 0x00049849 File Offset: 0x00047A49
		public unsafe List<PhoneShopInterface.Listing> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x06009745 RID: 38725 RVA: 0x0026ADF4 File Offset: 0x00268FF4
		// (set) Token: 0x06009746 RID: 38726 RVA: 0x00049868 File Offset: 0x00047A68
		public unsafe List<PhoneShopInterface.CartEntry> _cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x06009747 RID: 38727 RVA: 0x0026AE24 File Offset: 0x00269024
		// (set) Token: 0x06009748 RID: 38728 RVA: 0x00049887 File Offset: 0x00047A87
		public unsafe float orderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit)) = value;
			}
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x06009749 RID: 38729 RVA: 0x0026AE4C File Offset: 0x0026904C
		// (set) Token: 0x0600974A RID: 38730 RVA: 0x000498A2 File Offset: 0x00047AA2
		public unsafe Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<PhoneShopInterface.CartEntry>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600974B RID: 38731 RVA: 0x0026AE7C File Offset: 0x0026907C
		// (set) Token: 0x0600974C RID: 38732 RVA: 0x000498C1 File Offset: 0x00047AC1
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065D1 RID: 26065
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040065D2 RID: 26066
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x040065D3 RID: 26067
		private static readonly IntPtr NativeFieldInfoPtr_ValidAmountColor;

		// Token: 0x040065D4 RID: 26068
		private static readonly IntPtr NativeFieldInfoPtr_InvalidAmountColor;

		// Token: 0x040065D5 RID: 26069
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040065D6 RID: 26070
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040065D7 RID: 26071
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040065D8 RID: 26072
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040065D9 RID: 26073
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x040065DA RID: 26074
		private static readonly IntPtr NativeFieldInfoPtr_OrderLimitLabel;

		// Token: 0x040065DB RID: 26075
		private static readonly IntPtr NativeFieldInfoPtr_DebtLabel;

		// Token: 0x040065DC RID: 26076
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x040065DD RID: 26077
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitContainer;

		// Token: 0x040065DE RID: 26078
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitLabel;

		// Token: 0x040065DF RID: 26079
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x040065E0 RID: 26080
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x040065E1 RID: 26081
		private static readonly IntPtr NativeFieldInfoPtr__cart;

		// Token: 0x040065E2 RID: 26082
		private static readonly IntPtr NativeFieldInfoPtr_orderLimit;

		// Token: 0x040065E3 RID: 26083
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x040065E4 RID: 26084
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040065E5 RID: 26085
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040065E6 RID: 26086
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065E7 RID: 26087
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065E8 RID: 26088
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0;

		// Token: 0x040065E9 RID: 26089
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065EA RID: 26090
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040065EB RID: 26091
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0;

		// Token: 0x040065EC RID: 26092
		private static readonly IntPtr NativeMethodInfoPtr_CartChanged_Private_Void_0;

		// Token: 0x040065ED RID: 26093
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0;

		// Token: 0x040065EE RID: 26094
		private static readonly IntPtr NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0;

		// Token: 0x040065EF RID: 26095
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0;

		// Token: 0x040065F0 RID: 26096
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0;

		// Token: 0x040065F1 RID: 26097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B62 RID: 2914
		[Serializable]
		public class Listing : Il2CppSystem.Object
		{
			// Token: 0x0600DA5C RID: 55900 RVA: 0x0033C1F4 File Offset: 0x0033A3F4
			// Note: this type is marked as 'beforefieldinit'.
			static Listing()
			{
				Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Listing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr);
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Item");
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Price");
				PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, 100681962);
			}

			// Token: 0x0600DA5D RID: 55901 RVA: 0x0033C25C File Offset: 0x0033A45C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70198, RefRangeEnd = 70199, XrefRangeStart = 70198, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Listing(ItemDefinition item, float price) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA5E RID: 55902 RVA: 0x0006A522 File Offset: 0x00068722
			public Listing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BB RID: 17339
			// (get) Token: 0x0600DA5F RID: 55903 RVA: 0x0033C2B8 File Offset: 0x0033A4B8
			// (set) Token: 0x0600DA60 RID: 55904 RVA: 0x0006A52B File Offset: 0x0006872B
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BC RID: 17340
			// (get) Token: 0x0600DA61 RID: 55905 RVA: 0x0033C2E8 File Offset: 0x0033A4E8
			// (set) Token: 0x0600DA62 RID: 55906 RVA: 0x0006A54A File Offset: 0x0006874A
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x04009295 RID: 37525
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009296 RID: 37526
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04009297 RID: 37527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0;
		}

		// Token: 0x02000B63 RID: 2915
		[Serializable]
		public class CartEntry : Il2CppSystem.Object
		{
			// Token: 0x0600DA63 RID: 55907 RVA: 0x0033C310 File Offset: 0x0033A510
			// Note: this type is marked as 'beforefieldinit'.
			static CartEntry()
			{
				Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "CartEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr);
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Listing");
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Quantity");
				PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, 100681963);
			}

			// Token: 0x0600DA64 RID: 55908 RVA: 0x0033C378 File Offset: 0x0033A578
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 107228, RefRangeEnd = 107237, XrefRangeStart = 107228, XrefRangeEnd = 107237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CartEntry(PhoneShopInterface.Listing listing, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA65 RID: 55909 RVA: 0x0006A565 File Offset: 0x00068765
			public CartEntry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BD RID: 17341
			// (get) Token: 0x0600DA66 RID: 55910 RVA: 0x0033C3D4 File Offset: 0x0033A5D4
			// (set) Token: 0x0600DA67 RID: 55911 RVA: 0x0006A56E File Offset: 0x0006876E
			public unsafe PhoneShopInterface.Listing Listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BE RID: 17342
			// (get) Token: 0x0600DA68 RID: 55912 RVA: 0x0033C404 File Offset: 0x0033A604
			// (set) Token: 0x0600DA69 RID: 55913 RVA: 0x0006A58D File Offset: 0x0006878D
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009298 RID: 37528
			private static readonly IntPtr NativeFieldInfoPtr_Listing;

			// Token: 0x04009299 RID: 37529
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x0400929A RID: 37530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0;
		}

		// Token: 0x02000B64 RID: 2916
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA6A RID: 55914 RVA: 0x0033C42C File Offset: 0x0033A62C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "entry");
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681964);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681965);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100681966);
			}

			// Token: 0x0600DA6B RID: 55915 RVA: 0x0033C4BC File Offset: 0x0033A6BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6C RID: 55916 RVA: 0x0033C4F8 File Offset: 0x0033A6F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270416, XrefRangeEnd = 270418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6D RID: 55917 RVA: 0x0033C52C File Offset: 0x0033A72C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270418, XrefRangeEnd = 270420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6E RID: 55918 RVA: 0x0006A5A8 File Offset: 0x000687A8
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BF RID: 17343
			// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x0033C560 File Offset: 0x0033A760
			// (set) Token: 0x0600DA70 RID: 55920 RVA: 0x0006A5B1 File Offset: 0x000687B1
			public unsafe PhoneShopInterface.Listing entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C0 RID: 17344
			// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x0033C590 File Offset: 0x0033A790
			// (set) Token: 0x0600DA72 RID: 55922 RVA: 0x0006A5D0 File Offset: 0x000687D0
			public unsafe PhoneShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400929B RID: 37531
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400929C RID: 37532
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400929D RID: 37533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400929E RID: 37534
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;

			// Token: 0x0400929F RID: 37535
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Void_0;
		}

		// Token: 0x02000B65 RID: 2917
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA73 RID: 55923 RVA: 0x0033C5C0 File Offset: 0x0033A7C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, "listing");
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100681967);
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100681968);
			}

			// Token: 0x0600DA74 RID: 55924 RVA: 0x0033C628 File Offset: 0x0033A828
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA75 RID: 55925 RVA: 0x0033C664 File Offset: 0x0033A864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270420, XrefRangeEnd = 270422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeListingQuantity_b__0(PhoneShopInterface.CartEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA76 RID: 55926 RVA: 0x0006A5EF File Offset: 0x000687EF
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C1 RID: 17345
			// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x0033C6B4 File Offset: 0x0033A8B4
			// (set) Token: 0x0600DA78 RID: 55928 RVA: 0x0006A5F8 File Offset: 0x000687F8
			public unsafe PhoneShopInterface.Listing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092A0 RID: 37536
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x040092A1 RID: 37537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092A2 RID: 37538
			private static readonly IntPtr NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
