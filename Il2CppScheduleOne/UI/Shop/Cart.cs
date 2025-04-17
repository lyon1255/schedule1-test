using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000704 RID: 1796
	public class Cart : MonoBehaviour
	{
		// Token: 0x0600A151 RID: 41297 RVA: 0x00289528 File Offset: 0x00287728
		// Note: this type is marked as 'beforefieldinit'.
		static Cart()
		{
			Il2CppClassPointerStore<Cart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "Cart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart>.NativeClassPtr);
			Cart.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "Shop");
			Cart.NativeFieldInfoPtr_CartIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartIcon");
			Cart.NativeFieldInfoPtr_ViewCartText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ViewCartText");
			Cart.NativeFieldInfoPtr_CartEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartEntryContainer");
			Cart.NativeFieldInfoPtr_ProblemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ProblemText");
			Cart.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "WarningText");
			Cart.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "BuyButton");
			Cart.NativeFieldInfoPtr_CartContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartContainer");
			Cart.NativeFieldInfoPtr_CartArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartArea");
			Cart.NativeFieldInfoPtr_TotalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "TotalText");
			Cart.NativeFieldInfoPtr_LoadVehicleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "LoadVehicleToggle");
			Cart.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "EntryPrefab");
			Cart.NativeFieldInfoPtr_cartDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartDictionary");
			Cart.NativeFieldInfoPtr_cartIconBop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartIconBop");
			Cart.NativeFieldInfoPtr_cartEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartEntries");
			Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683032);
			Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683033);
			Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683034);
			Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683035);
			Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683036);
			Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683037);
			Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683038);
			Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683039);
			Cart.NativeMethodInfoPtr_Buy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683040);
			Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683041);
			Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683042);
			Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683043);
			Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683044);
			Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683045);
			Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683046);
			Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683047);
			Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683048);
			Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683049);
			Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683050);
			Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683051);
			Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683052);
			Cart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683053);
			Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683054);
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x00289850 File Offset: 0x00287A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283343, XrefRangeEnd = 283352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x0028988C File Offset: 0x00287A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283352, XrefRangeEnd = 283362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x002898C8 File Offset: 0x00287AC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 283399, RefRangeEnd = 283404, XrefRangeStart = 283362, XrefRangeEnd = 283399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x00289918 File Offset: 0x00287B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283404, XrefRangeEnd = 283427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x00289968 File Offset: 0x00287B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283449, RefRangeEnd = 283450, XrefRangeStart = 283427, XrefRangeEnd = 283449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x0028999C File Offset: 0x00287B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283450, XrefRangeEnd = 283454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCartCount(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x002899EC File Offset: 0x00287BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283462, RefRangeEnd = 283463, XrefRangeStart = 283454, XrefRangeEnd = 283462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopCartIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x00289A20 File Offset: 0x00287C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283463, XrefRangeEnd = 283465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlayerAffordCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00289A5C File Offset: 0x00287C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283465, XrefRangeEnd = 283522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Buy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A15B RID: 41307 RVA: 0x00289A90 File Offset: 0x00287C90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 283594, RefRangeEnd = 283599, XrefRangeStart = 283522, XrefRangeEnd = 283594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x00289AC4 File Offset: 0x00287CC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 283623, RefRangeEnd = 283627, XrefRangeStart = 283599, XrefRangeEnd = 283623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x00289AF8 File Offset: 0x00287CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283637, RefRangeEnd = 283640, XrefRangeStart = 283627, XrefRangeEnd = 283637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProblem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x00289B2C File Offset: 0x00287D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283657, RefRangeEnd = 283659, XrefRangeStart = 283640, XrefRangeEnd = 283657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCheckout(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A15F RID: 41311 RVA: 0x00289B84 File Offset: 0x00287D84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283677, RefRangeEnd = 283678, XrefRangeStart = 283659, XrefRangeEnd = 283677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x00289BDC File Offset: 0x00287DDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 283700, RefRangeEnd = 283705, XrefRangeStart = 283678, XrefRangeEnd = 283700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateViewCartText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x00289C10 File Offset: 0x00287E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283705, XrefRangeEnd = 283713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoadVehicleToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00289C44 File Offset: 0x00287E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283713, XrefRangeEnd = 283727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00289C80 File Offset: 0x00287E80
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 283744, RefRangeEnd = 283752, XrefRangeStart = 283727, XrefRangeEnd = 283744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPriceSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00289CBC File Offset: 0x00287EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283752, XrefRangeEnd = 283767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry GetEntry(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr3) : null;
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00289D0C File Offset: 0x00287F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283767, XrefRangeEnd = 283774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverMenuArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x00289D48 File Offset: 0x00287F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283774, XrefRangeEnd = 283788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSlotRequirement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x00289D84 File Offset: 0x00287F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283788, XrefRangeEnd = 283803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x00289DC0 File Offset: 0x00287FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283803, XrefRangeEnd = 283808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x0004F5CD File Offset: 0x0004D7CD
		public Cart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600A16A RID: 41322 RVA: 0x00289E00 File Offset: 0x00288000
		// (set) Token: 0x0600A16B RID: 41323 RVA: 0x0004F5D6 File Offset: 0x0004D7D6
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600A16C RID: 41324 RVA: 0x00289E30 File Offset: 0x00288030
		// (set) Token: 0x0600A16D RID: 41325 RVA: 0x0004F5F5 File Offset: 0x0004D7F5
		public unsafe Image CartIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x00289E60 File Offset: 0x00288060
		// (set) Token: 0x0600A16F RID: 41327 RVA: 0x0004F614 File Offset: 0x0004D814
		public unsafe TextMeshProUGUI ViewCartText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x00289E90 File Offset: 0x00288090
		// (set) Token: 0x0600A171 RID: 41329 RVA: 0x0004F633 File Offset: 0x0004D833
		public unsafe RectTransform CartEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600A172 RID: 41330 RVA: 0x00289EC0 File Offset: 0x002880C0
		// (set) Token: 0x0600A173 RID: 41331 RVA: 0x0004F652 File Offset: 0x0004D852
		public unsafe TextMeshProUGUI ProblemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600A174 RID: 41332 RVA: 0x00289EF0 File Offset: 0x002880F0
		// (set) Token: 0x0600A175 RID: 41333 RVA: 0x0004F671 File Offset: 0x0004D871
		public unsafe TextMeshProUGUI WarningText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600A176 RID: 41334 RVA: 0x00289F20 File Offset: 0x00288120
		// (set) Token: 0x0600A177 RID: 41335 RVA: 0x0004F690 File Offset: 0x0004D890
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600A178 RID: 41336 RVA: 0x00289F50 File Offset: 0x00288150
		// (set) Token: 0x0600A179 RID: 41337 RVA: 0x0004F6AF File Offset: 0x0004D8AF
		public unsafe RectTransform CartContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600A17A RID: 41338 RVA: 0x00289F80 File Offset: 0x00288180
		// (set) Token: 0x0600A17B RID: 41339 RVA: 0x0004F6CE File Offset: 0x0004D8CE
		public unsafe Image CartArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600A17C RID: 41340 RVA: 0x00289FB0 File Offset: 0x002881B0
		// (set) Token: 0x0600A17D RID: 41341 RVA: 0x0004F6ED File Offset: 0x0004D8ED
		public unsafe TextMeshProUGUI TotalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x00289FE0 File Offset: 0x002881E0
		// (set) Token: 0x0600A17F RID: 41343 RVA: 0x0004F70C File Offset: 0x0004D90C
		public unsafe Toggle LoadVehicleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A180 RID: 41344 RVA: 0x0028A010 File Offset: 0x00288210
		// (set) Token: 0x0600A181 RID: 41345 RVA: 0x0004F72B File Offset: 0x0004D92B
		public unsafe CartEntry EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A182 RID: 41346 RVA: 0x0028A040 File Offset: 0x00288240
		// (set) Token: 0x0600A183 RID: 41347 RVA: 0x0004F74A File Offset: 0x0004D94A
		public unsafe Dictionary<ShopListing, int> cartDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ShopListing, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A184 RID: 41348 RVA: 0x0028A070 File Offset: 0x00288270
		// (set) Token: 0x0600A185 RID: 41349 RVA: 0x0004F769 File Offset: 0x0004D969
		public unsafe Coroutine cartIconBop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x0028A0A0 File Offset: 0x002882A0
		// (set) Token: 0x0600A187 RID: 41351 RVA: 0x0004F788 File Offset: 0x0004D988
		public unsafe List<CartEntry> cartEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C25 RID: 27685
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04006C26 RID: 27686
		private static readonly IntPtr NativeFieldInfoPtr_CartIcon;

		// Token: 0x04006C27 RID: 27687
		private static readonly IntPtr NativeFieldInfoPtr_ViewCartText;

		// Token: 0x04006C28 RID: 27688
		private static readonly IntPtr NativeFieldInfoPtr_CartEntryContainer;

		// Token: 0x04006C29 RID: 27689
		private static readonly IntPtr NativeFieldInfoPtr_ProblemText;

		// Token: 0x04006C2A RID: 27690
		private static readonly IntPtr NativeFieldInfoPtr_WarningText;

		// Token: 0x04006C2B RID: 27691
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006C2C RID: 27692
		private static readonly IntPtr NativeFieldInfoPtr_CartContainer;

		// Token: 0x04006C2D RID: 27693
		private static readonly IntPtr NativeFieldInfoPtr_CartArea;

		// Token: 0x04006C2E RID: 27694
		private static readonly IntPtr NativeFieldInfoPtr_TotalText;

		// Token: 0x04006C2F RID: 27695
		private static readonly IntPtr NativeFieldInfoPtr_LoadVehicleToggle;

		// Token: 0x04006C30 RID: 27696
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04006C31 RID: 27697
		private static readonly IntPtr NativeFieldInfoPtr_cartDictionary;

		// Token: 0x04006C32 RID: 27698
		private static readonly IntPtr NativeFieldInfoPtr_cartIconBop;

		// Token: 0x04006C33 RID: 27699
		private static readonly IntPtr NativeFieldInfoPtr_cartEntries;

		// Token: 0x04006C34 RID: 27700
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006C35 RID: 27701
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006C36 RID: 27702
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006C37 RID: 27703
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006C38 RID: 27704
		private static readonly IntPtr NativeMethodInfoPtr_ClearCart_Public_Void_0;

		// Token: 0x04006C39 RID: 27705
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0;

		// Token: 0x04006C3A RID: 27706
		private static readonly IntPtr NativeMethodInfoPtr_BopCartIcon_Public_Void_0;

		// Token: 0x04006C3B RID: 27707
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0;

		// Token: 0x04006C3C RID: 27708
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Public_Void_0;

		// Token: 0x04006C3D RID: 27709
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntries_Private_Void_0;

		// Token: 0x04006C3E RID: 27710
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTotal_Private_Void_0;

		// Token: 0x04006C3F RID: 27711
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProblem_Private_Void_0;

		// Token: 0x04006C40 RID: 27712
		private static readonly IntPtr NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0;

		// Token: 0x04006C41 RID: 27713
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006C42 RID: 27714
		private static readonly IntPtr NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0;

		// Token: 0x04006C43 RID: 27715
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0;

		// Token: 0x04006C44 RID: 27716
		private static readonly IntPtr NativeMethodInfoPtr_GetItemSum_Private_Int32_0;

		// Token: 0x04006C45 RID: 27717
		private static readonly IntPtr NativeMethodInfoPtr_GetPriceSum_Private_Single_0;

		// Token: 0x04006C46 RID: 27718
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0;

		// Token: 0x04006C47 RID: 27719
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0;

		// Token: 0x04006C48 RID: 27720
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0;

		// Token: 0x04006C49 RID: 27721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C4A RID: 27722
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BB2 RID: 2994
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<<BopCartIcon>g__Routine|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD1C RID: 56604 RVA: 0x00343BE4 File Offset: 0x00341DE4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique()
			{
				Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<<BopCartIcon>g__Routine|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>1__state");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>2__current");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>4__this");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<startScale>5__2");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<endScale>5__3");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<lerpTime>5__4");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<i>5__5");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683055);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683056);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683057);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683058);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683059);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683060);
			}

			// Token: 0x0600DD1D RID: 56605 RVA: 0x00343D14 File Offset: 0x00341F14
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1E RID: 56606 RVA: 0x00343D5C File Offset: 0x00341F5C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD1F RID: 56607 RVA: 0x00343D90 File Offset: 0x00341F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283322, XrefRangeEnd = 283338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700448E RID: 17550
			// (get) Token: 0x0600DD20 RID: 56608 RVA: 0x00343DCC File Offset: 0x00341FCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD21 RID: 56609 RVA: 0x00343E0C File Offset: 0x0034200C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283338, XrefRangeEnd = 283343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700448F RID: 17551
			// (get) Token: 0x0600DD22 RID: 56610 RVA: 0x00343E40 File Offset: 0x00342040
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD23 RID: 56611 RVA: 0x0006BC20 File Offset: 0x00069E20
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004487 RID: 17543
			// (get) Token: 0x0600DD24 RID: 56612 RVA: 0x00343E80 File Offset: 0x00342080
			// (set) Token: 0x0600DD25 RID: 56613 RVA: 0x0006BC29 File Offset: 0x00069E29
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004488 RID: 17544
			// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x00343EA8 File Offset: 0x003420A8
			// (set) Token: 0x0600DD27 RID: 56615 RVA: 0x0006BC44 File Offset: 0x00069E44
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004489 RID: 17545
			// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x00343ED8 File Offset: 0x003420D8
			// (set) Token: 0x0600DD29 RID: 56617 RVA: 0x0006BC63 File Offset: 0x00069E63
			public unsafe Cart __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700448A RID: 17546
			// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x00343F08 File Offset: 0x00342108
			// (set) Token: 0x0600DD2B RID: 56619 RVA: 0x0006BC82 File Offset: 0x00069E82
			public unsafe Vector3 _startScale_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
				}
			}

			// Token: 0x1700448B RID: 17547
			// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x00343F30 File Offset: 0x00342130
			// (set) Token: 0x0600DD2D RID: 56621 RVA: 0x0006BC9D File Offset: 0x00069E9D
			public unsafe Vector3 _endScale_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3)) = value;
				}
			}

			// Token: 0x1700448C RID: 17548
			// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x00343F58 File Offset: 0x00342158
			// (set) Token: 0x0600DD2F RID: 56623 RVA: 0x0006BCB8 File Offset: 0x00069EB8
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x1700448D RID: 17549
			// (get) Token: 0x0600DD30 RID: 56624 RVA: 0x00343F80 File Offset: 0x00342180
			// (set) Token: 0x0600DD31 RID: 56625 RVA: 0x0006BCD3 File Offset: 0x00069ED3
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009422 RID: 37922
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009423 RID: 37923
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009424 RID: 37924
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009425 RID: 37925
			private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

			// Token: 0x04009426 RID: 37926
			private static readonly IntPtr NativeFieldInfoPtr__endScale_5__3;

			// Token: 0x04009427 RID: 37927
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009428 RID: 37928
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04009429 RID: 37929
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400942A RID: 37930
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942B RID: 37931
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400942C RID: 37932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400942D RID: 37933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942E RID: 37934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BB3 RID: 2995
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD32 RID: 56626 RVA: 0x00343FA8 File Offset: 0x003421A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr);
				Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, "listing");
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683061);
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683062);
			}

			// Token: 0x0600DD33 RID: 56627 RVA: 0x00344010 File Offset: 0x00342210
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD34 RID: 56628 RVA: 0x0034404C File Offset: 0x0034224C
			[CallerCount(0)]
			public unsafe bool _GetEntry_b__0(CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD35 RID: 56629 RVA: 0x0006BCEE File Offset: 0x00069EEE
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004490 RID: 17552
			// (get) Token: 0x0600DD36 RID: 56630 RVA: 0x0034409C File Offset: 0x0034229C
			// (set) Token: 0x0600DD37 RID: 56631 RVA: 0x0006BCF7 File Offset: 0x00069EF7
			public unsafe ShopListing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400942F RID: 37935
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x04009430 RID: 37936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009431 RID: 37937
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
