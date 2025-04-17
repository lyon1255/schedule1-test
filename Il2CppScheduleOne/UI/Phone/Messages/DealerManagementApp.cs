using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006AD RID: 1709
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x0600997A RID: 39290 RVA: 0x002717D0 File Offset: 0x0026F9D0
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementApp()
		{
			Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealerManagementApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr);
			DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<SelectedDealer>k__BackingField");
			DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NoDealersLabel");
			DealerManagementApp.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "Content");
			DealerManagementApp.NativeFieldInfoPtr_CustomerSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerSelector");
			DealerManagementApp.NativeFieldInfoPtr_SelectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorImage");
			DealerManagementApp.NativeFieldInfoPtr_SelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorTitle");
			DealerManagementApp.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "BackButton");
			DealerManagementApp.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NextButton");
			DealerManagementApp.NativeFieldInfoPtr_CashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CashLabel");
			DealerManagementApp.NativeFieldInfoPtr_CutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CutLabel");
			DealerManagementApp.NativeFieldInfoPtr_HomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "HomeLabel");
			DealerManagementApp.NativeFieldInfoPtr_InventoryEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "InventoryEntries");
			DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerTitleLabel");
			DealerManagementApp.NativeFieldInfoPtr_CustomerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerEntries");
			DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "AssignCustomerButton");
			DealerManagementApp.NativeFieldInfoPtr_dealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "dealers");
			DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682225);
			DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682226);
			DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682227);
			DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682228);
			DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682229);
			DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682230);
			DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682231);
			DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682232);
			DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682233);
			DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682234);
			DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682235);
			DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682236);
			DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682237);
			DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682238);
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600997B RID: 39291 RVA: 0x00271A58 File Offset: 0x0026FC58
		// (set) Token: 0x0600997C RID: 39292 RVA: 0x00271A98 File Offset: 0x0026FC98
		public unsafe Dealer SelectedDealer
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00271ADC File Offset: 0x0026FCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273522, XrefRangeEnd = 273582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x00271B18 File Offset: 0x0026FD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273582, XrefRangeEnd = 273595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x00271B54 File Offset: 0x0026FD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273595, XrefRangeEnd = 273620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x00271B90 File Offset: 0x0026FD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273620, XrefRangeEnd = 273639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x00271BDC File Offset: 0x0026FDDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 273800, RefRangeEnd = 273806, XrefRangeStart = 273639, XrefRangeEnd = 273800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x00271C20 File Offset: 0x0026FE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 273836, RefRangeEnd = 273837, XrefRangeStart = 273806, XrefRangeEnd = 273836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x00271C64 File Offset: 0x0026FE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273837, XrefRangeEnd = 273846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x00271CA8 File Offset: 0x0026FEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273846, XrefRangeEnd = 273849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x00271CEC File Offset: 0x0026FEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273849, XrefRangeEnd = 273856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x00271D20 File Offset: 0x0026FF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273856, XrefRangeEnd = 273864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x00271D54 File Offset: 0x0026FF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273864, XrefRangeEnd = 273866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCustomer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00271D88 File Offset: 0x0026FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273866, XrefRangeEnd = 273879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x0004ADAE File Offset: 0x00048FAE
		public DealerManagementApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600998A RID: 39306 RVA: 0x00271DC4 File Offset: 0x0026FFC4
		// (set) Token: 0x0600998B RID: 39307 RVA: 0x0004ADB7 File Offset: 0x00048FB7
		public unsafe Dealer _SelectedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600998C RID: 39308 RVA: 0x00271DF4 File Offset: 0x0026FFF4
		// (set) Token: 0x0600998D RID: 39309 RVA: 0x0004ADD6 File Offset: 0x00048FD6
		public unsafe Text NoDealersLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600998E RID: 39310 RVA: 0x00271E24 File Offset: 0x00270024
		// (set) Token: 0x0600998F RID: 39311 RVA: 0x0004ADF5 File Offset: 0x00048FF5
		public unsafe RectTransform Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x06009990 RID: 39312 RVA: 0x00271E54 File Offset: 0x00270054
		// (set) Token: 0x06009991 RID: 39313 RVA: 0x0004AE14 File Offset: 0x00049014
		public unsafe CustomerSelector CustomerSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x00271E84 File Offset: 0x00270084
		// (set) Token: 0x06009993 RID: 39315 RVA: 0x0004AE33 File Offset: 0x00049033
		public unsafe Image SelectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x00271EB4 File Offset: 0x002700B4
		// (set) Token: 0x06009995 RID: 39317 RVA: 0x0004AE52 File Offset: 0x00049052
		public unsafe Text SelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x06009996 RID: 39318 RVA: 0x00271EE4 File Offset: 0x002700E4
		// (set) Token: 0x06009997 RID: 39319 RVA: 0x0004AE71 File Offset: 0x00049071
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x00271F14 File Offset: 0x00270114
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x0004AE90 File Offset: 0x00049090
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00271F44 File Offset: 0x00270144
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x0004AEAF File Offset: 0x000490AF
		public unsafe Text CashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x00271F74 File Offset: 0x00270174
		// (set) Token: 0x0600999D RID: 39325 RVA: 0x0004AECE File Offset: 0x000490CE
		public unsafe Text CutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0600999E RID: 39326 RVA: 0x00271FA4 File Offset: 0x002701A4
		// (set) Token: 0x0600999F RID: 39327 RVA: 0x0004AEED File Offset: 0x000490ED
		public unsafe Text HomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x00271FD4 File Offset: 0x002701D4
		// (set) Token: 0x060099A1 RID: 39329 RVA: 0x0004AF0C File Offset: 0x0004910C
		public unsafe Il2CppReferenceArray<RectTransform> InventoryEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x060099A2 RID: 39330 RVA: 0x00272004 File Offset: 0x00270204
		// (set) Token: 0x060099A3 RID: 39331 RVA: 0x0004AF2B File Offset: 0x0004912B
		public unsafe Text CustomerTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x060099A4 RID: 39332 RVA: 0x00272034 File Offset: 0x00270234
		// (set) Token: 0x060099A5 RID: 39333 RVA: 0x0004AF4A File Offset: 0x0004914A
		public unsafe Il2CppReferenceArray<RectTransform> CustomerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x00272064 File Offset: 0x00270264
		// (set) Token: 0x060099A7 RID: 39335 RVA: 0x0004AF69 File Offset: 0x00049169
		public unsafe Button AssignCustomerButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00272094 File Offset: 0x00270294
		// (set) Token: 0x060099A9 RID: 39337 RVA: 0x0004AF88 File Offset: 0x00049188
		public unsafe List<Dealer> dealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006753 RID: 26451
		private static readonly IntPtr NativeFieldInfoPtr__SelectedDealer_k__BackingField;

		// Token: 0x04006754 RID: 26452
		private static readonly IntPtr NativeFieldInfoPtr_NoDealersLabel;

		// Token: 0x04006755 RID: 26453
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04006756 RID: 26454
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSelector;

		// Token: 0x04006757 RID: 26455
		private static readonly IntPtr NativeFieldInfoPtr_SelectorImage;

		// Token: 0x04006758 RID: 26456
		private static readonly IntPtr NativeFieldInfoPtr_SelectorTitle;

		// Token: 0x04006759 RID: 26457
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x0400675A RID: 26458
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x0400675B RID: 26459
		private static readonly IntPtr NativeFieldInfoPtr_CashLabel;

		// Token: 0x0400675C RID: 26460
		private static readonly IntPtr NativeFieldInfoPtr_CutLabel;

		// Token: 0x0400675D RID: 26461
		private static readonly IntPtr NativeFieldInfoPtr_HomeLabel;

		// Token: 0x0400675E RID: 26462
		private static readonly IntPtr NativeFieldInfoPtr_InventoryEntries;

		// Token: 0x0400675F RID: 26463
		private static readonly IntPtr NativeFieldInfoPtr_CustomerTitleLabel;

		// Token: 0x04006760 RID: 26464
		private static readonly IntPtr NativeFieldInfoPtr_CustomerEntries;

		// Token: 0x04006761 RID: 26465
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomerButton;

		// Token: 0x04006762 RID: 26466
		private static readonly IntPtr NativeFieldInfoPtr_dealers;

		// Token: 0x04006763 RID: 26467
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0;

		// Token: 0x04006764 RID: 26468
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0;

		// Token: 0x04006765 RID: 26469
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006766 RID: 26470
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006767 RID: 26471
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006768 RID: 26472
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006769 RID: 26473
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0;

		// Token: 0x0400676A RID: 26474
		private static readonly IntPtr NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0;

		// Token: 0x0400676B RID: 26475
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0;

		// Token: 0x0400676C RID: 26476
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0;

		// Token: 0x0400676D RID: 26477
		private static readonly IntPtr NativeMethodInfoPtr_BackPressed_Private_Void_0;

		// Token: 0x0400676E RID: 26478
		private static readonly IntPtr NativeMethodInfoPtr_NextPressed_Private_Void_0;

		// Token: 0x0400676F RID: 26479
		private static readonly IntPtr NativeMethodInfoPtr_AssignCustomer_Public_Void_0;

		// Token: 0x04006770 RID: 26480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B78 RID: 2936
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB38 RID: 56120 RVA: 0x0033E858 File Offset: 0x0033CA58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr);
				DealerManagementApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__24_0");
				DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682240);
				DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682241);
			}

			// Token: 0x0600DB39 RID: 56121 RVA: 0x0033E8D4 File Offset: 0x0033CAD4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB3A RID: 56122 RVA: 0x0033E910 File Offset: 0x0033CB10
			[CallerCount(0)]
			public unsafe string _AddDealer_b__24_0(Dealer d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DB3B RID: 56123 RVA: 0x0006AC5F File Offset: 0x00068E5F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FF RID: 17407
			// (get) Token: 0x0600DB3C RID: 56124 RVA: 0x0033E958 File Offset: 0x0033CB58
			// (set) Token: 0x0600DB3D RID: 56125 RVA: 0x0006AC68 File Offset: 0x00068E68
			public unsafe static DealerManagementApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0600DB3E RID: 56126 RVA: 0x0033E980 File Offset: 0x0033CB80
			// (set) Token: 0x0600DB3F RID: 56127 RVA: 0x0006AC7A File Offset: 0x00068E7A
			public unsafe static Func<Dealer, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dealer, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400930D RID: 37645
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400930E RID: 37646
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400930F RID: 37647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009310 RID: 37648
			private static readonly IntPtr NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0;
		}

		// Token: 0x02000B79 RID: 2937
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB40 RID: 56128 RVA: 0x0033E9A8 File Offset: 0x0033CBA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr);
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "customer");
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682242);
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682243);
			}

			// Token: 0x0600DB41 RID: 56129 RVA: 0x0033EA24 File Offset: 0x0033CC24
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB42 RID: 56130 RVA: 0x0033EA60 File Offset: 0x0033CC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273519, XrefRangeEnd = 273522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetDisplayedDealer_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB43 RID: 56131 RVA: 0x0006AC8C File Offset: 0x00068E8C
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004401 RID: 17409
			// (get) Token: 0x0600DB44 RID: 56132 RVA: 0x0033EA94 File Offset: 0x0033CC94
			// (set) Token: 0x0600DB45 RID: 56133 RVA: 0x0006AC95 File Offset: 0x00068E95
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004402 RID: 17410
			// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x0033EAC4 File Offset: 0x0033CCC4
			// (set) Token: 0x0600DB47 RID: 56135 RVA: 0x0006ACB4 File Offset: 0x00068EB4
			public unsafe DealerManagementApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009311 RID: 37649
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009312 RID: 37650
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009313 RID: 37651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009314 RID: 37652
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0;
		}
	}
}
