using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069C RID: 1692
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x0600969F RID: 38559 RVA: 0x00268F38 File Offset: 0x00267138
		// Note: this type is marked as 'beforefieldinit'.
		static CounterofferInterface()
		{
			Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterofferInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr);
			CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "COUNTEROFFER_SUCCESS_XP");
			CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterofferInterface.NativeFieldInfoPtr_MinQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MaxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinPrice");
			CounterofferInterface.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxPrice");
			CounterofferInterface.NativeFieldInfoPtr_IconAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "IconAlignment");
			CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductEntryPrefab");
			CounterofferInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "Container");
			CounterofferInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "TitleLabel");
			CounterofferInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ConfirmButton");
			CounterofferInterface.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductIcon");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabelRect");
			CounterofferInterface.NativeFieldInfoPtr_PriceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "PriceInput");
			CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "FairPriceLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductSelector");
			CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "orderConfirmedCallback");
			CounterofferInterface.NativeFieldInfoPtr_selectedProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "selectedProduct");
			CounterofferInterface.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "quantity");
			CounterofferInterface.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "price");
			CounterofferInterface.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "productEntries");
			CounterofferInterface.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "mouseUp");
			CounterofferInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "conversation");
			CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681908);
			CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681909);
			CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681910);
			CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681911);
			CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681912);
			CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681913);
			CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681914);
			CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681915);
			CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681916);
			CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681917);
			CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681918);
			CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681919);
			CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681920);
			CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681921);
			CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681922);
			CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681923);
			CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681924);
			CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100681925);
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x060096A0 RID: 38560 RVA: 0x002692B0 File Offset: 0x002674B0
		// (set) Token: 0x060096A1 RID: 38561 RVA: 0x002692EC File Offset: 0x002674EC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x0026932C File Offset: 0x0026752C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269815, XrefRangeEnd = 269845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x00269360 File Offset: 0x00267560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269845, XrefRangeEnd = 269856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x00269394 File Offset: 0x00267594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269856, XrefRangeEnd = 269887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x002693C8 File Offset: 0x002675C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269912, RefRangeEnd = 269913, XrefRangeStart = 269887, XrefRangeEnd = 269912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x0026944C File Offset: 0x0026764C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269931, RefRangeEnd = 269934, XrefRangeStart = 269913, XrefRangeEnd = 269931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x00269480 File Offset: 0x00267680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269934, XrefRangeEnd = 269935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x002694C4 File Offset: 0x002676C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269935, XrefRangeEnd = 269939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x002694F8 File Offset: 0x002676F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269944, RefRangeEnd = 269947, XrefRangeStart = 269939, XrefRangeEnd = 269944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFairPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x0026952C File Offset: 0x0026772C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269947, XrefRangeEnd = 269954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(ProductDefinition newProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00269570 File Offset: 0x00267770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269954, XrefRangeEnd = 269957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayProduct(ProductDefinition tempProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tempProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x002695B4 File Offset: 0x002677B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269957, XrefRangeEnd = 269961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x002695F4 File Offset: 0x002677F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 269968, RefRangeEnd = 269972, XrefRangeStart = 269961, XrefRangeEnd = 269968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceQuantityLabel(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x00269638 File Offset: 0x00267838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269972, XrefRangeEnd = 269975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePrice(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x00269678 File Offset: 0x00267878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269975, XrefRangeEnd = 269979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x002696BC File Offset: 0x002678BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269979, XrefRangeEnd = 269997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenProductSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x002696F0 File Offset: 0x002678F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269997, XrefRangeEnd = 270005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterofferInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060096B2 RID: 38578 RVA: 0x0004920A File Offset: 0x0004740A
		public CounterofferInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x0026972C File Offset: 0x0026792C
		// (set) Token: 0x060096B4 RID: 38580 RVA: 0x00049213 File Offset: 0x00047413
		public unsafe static int COUNTEROFFER_SUCCESS_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&value));
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x060096B5 RID: 38581 RVA: 0x00269748 File Offset: 0x00267948
		// (set) Token: 0x060096B6 RID: 38582 RVA: 0x00049221 File Offset: 0x00047421
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x060096B7 RID: 38583 RVA: 0x00269770 File Offset: 0x00267970
		// (set) Token: 0x060096B8 RID: 38584 RVA: 0x0004923C File Offset: 0x0004743C
		public unsafe static int MinQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x060096B9 RID: 38585 RVA: 0x0026978C File Offset: 0x0026798C
		// (set) Token: 0x060096BA RID: 38586 RVA: 0x0004924A File Offset: 0x0004744A
		public unsafe int MaxQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity)) = value;
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x060096BB RID: 38587 RVA: 0x002697B4 File Offset: 0x002679B4
		// (set) Token: 0x060096BC RID: 38588 RVA: 0x00049265 File Offset: 0x00047465
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x060096BD RID: 38589 RVA: 0x002697D0 File Offset: 0x002679D0
		// (set) Token: 0x060096BE RID: 38590 RVA: 0x00049273 File Offset: 0x00047473
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x17002E2F RID: 11823
		// (get) Token: 0x060096BF RID: 38591 RVA: 0x002697EC File Offset: 0x002679EC
		// (set) Token: 0x060096C0 RID: 38592 RVA: 0x00049281 File Offset: 0x00047481
		public unsafe float IconAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment)) = value;
			}
		}

		// Token: 0x17002E30 RID: 11824
		// (get) Token: 0x060096C1 RID: 38593 RVA: 0x00269814 File Offset: 0x00267A14
		// (set) Token: 0x060096C2 RID: 38594 RVA: 0x0004929C File Offset: 0x0004749C
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E31 RID: 11825
		// (get) Token: 0x060096C3 RID: 38595 RVA: 0x00269844 File Offset: 0x00267A44
		// (set) Token: 0x060096C4 RID: 38596 RVA: 0x000492BB File Offset: 0x000474BB
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x060096C5 RID: 38597 RVA: 0x00269874 File Offset: 0x00267A74
		// (set) Token: 0x060096C6 RID: 38598 RVA: 0x000492DA File Offset: 0x000474DA
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E33 RID: 11827
		// (get) Token: 0x060096C7 RID: 38599 RVA: 0x002698A4 File Offset: 0x00267AA4
		// (set) Token: 0x060096C8 RID: 38600 RVA: 0x000492F9 File Offset: 0x000474F9
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x060096C9 RID: 38601 RVA: 0x002698D4 File Offset: 0x00267AD4
		// (set) Token: 0x060096CA RID: 38602 RVA: 0x00049318 File Offset: 0x00047518
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x00269904 File Offset: 0x00267B04
		// (set) Token: 0x060096CC RID: 38604 RVA: 0x00049337 File Offset: 0x00047537
		public unsafe Text ProductLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x060096CD RID: 38605 RVA: 0x00269934 File Offset: 0x00267B34
		// (set) Token: 0x060096CE RID: 38606 RVA: 0x00049356 File Offset: 0x00047556
		public unsafe RectTransform ProductLabelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x060096CF RID: 38607 RVA: 0x00269964 File Offset: 0x00267B64
		// (set) Token: 0x060096D0 RID: 38608 RVA: 0x00049375 File Offset: 0x00047575
		public unsafe InputField PriceInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x060096D1 RID: 38609 RVA: 0x00269994 File Offset: 0x00267B94
		// (set) Token: 0x060096D2 RID: 38610 RVA: 0x00049394 File Offset: 0x00047594
		public unsafe Text FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x060096D3 RID: 38611 RVA: 0x002699C4 File Offset: 0x00267BC4
		// (set) Token: 0x060096D4 RID: 38612 RVA: 0x000493B3 File Offset: 0x000475B3
		public unsafe CounterOfferProductSelector ProductSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x002699F4 File Offset: 0x00267BF4
		// (set) Token: 0x060096D6 RID: 38614 RVA: 0x000493D2 File Offset: 0x000475D2
		public unsafe Action<ProductDefinition, int, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x060096D7 RID: 38615 RVA: 0x00269A24 File Offset: 0x00267C24
		// (set) Token: 0x060096D8 RID: 38616 RVA: 0x000493F1 File Offset: 0x000475F1
		public unsafe ProductDefinition selectedProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x00269A54 File Offset: 0x00267C54
		// (set) Token: 0x060096DA RID: 38618 RVA: 0x00049410 File Offset: 0x00047610
		public unsafe int quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x00269A7C File Offset: 0x00267C7C
		// (set) Token: 0x060096DC RID: 38620 RVA: 0x0004942B File Offset: 0x0004762B
		public unsafe float price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price)) = value;
			}
		}

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x00269AA4 File Offset: 0x00267CA4
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x00049446 File Offset: 0x00047646
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x00269AD4 File Offset: 0x00267CD4
		// (set) Token: 0x060096E0 RID: 38624 RVA: 0x00049465 File Offset: 0x00047665
		public unsafe bool mouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x060096E1 RID: 38625 RVA: 0x00269AFC File Offset: 0x00267CFC
		// (set) Token: 0x060096E2 RID: 38626 RVA: 0x00049480 File Offset: 0x00047680
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006586 RID: 25990
		private static readonly IntPtr NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP;

		// Token: 0x04006587 RID: 25991
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006588 RID: 25992
		private static readonly IntPtr NativeFieldInfoPtr_MinQuantity;

		// Token: 0x04006589 RID: 25993
		private static readonly IntPtr NativeFieldInfoPtr_MaxQuantity;

		// Token: 0x0400658A RID: 25994
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x0400658B RID: 25995
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x0400658C RID: 25996
		private static readonly IntPtr NativeFieldInfoPtr_IconAlignment;

		// Token: 0x0400658D RID: 25997
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x0400658E RID: 25998
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400658F RID: 25999
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006590 RID: 26000
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x04006591 RID: 26001
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04006592 RID: 26002
		private static readonly IntPtr NativeFieldInfoPtr_ProductLabel;

		// Token: 0x04006593 RID: 26003
		private static readonly IntPtr NativeFieldInfoPtr_ProductLabelRect;

		// Token: 0x04006594 RID: 26004
		private static readonly IntPtr NativeFieldInfoPtr_PriceInput;

		// Token: 0x04006595 RID: 26005
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x04006596 RID: 26006
		private static readonly IntPtr NativeFieldInfoPtr_ProductSelector;

		// Token: 0x04006597 RID: 26007
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x04006598 RID: 26008
		private static readonly IntPtr NativeFieldInfoPtr_selectedProduct;

		// Token: 0x04006599 RID: 26009
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x0400659A RID: 26010
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x0400659B RID: 26011
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x0400659C RID: 26012
		private static readonly IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x0400659D RID: 26013
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x0400659E RID: 26014
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400659F RID: 26015
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040065A0 RID: 26016
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040065A1 RID: 26017
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065A2 RID: 26018
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040065A3 RID: 26019
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0;

		// Token: 0x040065A4 RID: 26020
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040065A5 RID: 26021
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040065A6 RID: 26022
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_0;

		// Token: 0x040065A7 RID: 26023
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0;

		// Token: 0x040065A8 RID: 26024
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040065A9 RID: 26025
		private static readonly IntPtr NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040065AA RID: 26026
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x040065AB RID: 26027
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0;

		// Token: 0x040065AC RID: 26028
		private static readonly IntPtr NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0;

		// Token: 0x040065AD RID: 26029
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0;

		// Token: 0x040065AE RID: 26030
		private static readonly IntPtr NativeMethodInfoPtr_OpenProductSelector_Public_Void_0;

		// Token: 0x040065AF RID: 26031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
