using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x020006F2 RID: 1778
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x06009EF5 RID: 40693 RVA: 0x00281F30 File Offset: 0x00280130
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreen()
		{
			Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr);
			HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CUSTOMER_SLOT_COUNT");
			HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VEHICLE_MAX_DIST");
			HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentContract>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<Mode>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr_SuccessColorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessColorMap");
			HandoverScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Canvas");
			HandoverScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Container");
			HandoverScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CanvasGroup");
			HandoverScreen.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DescriptionLabel");
			HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSubtitle");
			HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouriteDrugLabel");
			HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouritePropertiesLabel");
			HandoverScreen.NativeFieldInfoPtr_PropertiesEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PropertiesEntries");
			HandoverScreen.NativeFieldInfoPtr_ExpectationEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ExpectationEntries");
			HandoverScreen.NativeFieldInfoPtr_NoVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "NoVehicle");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSubtitle");
			HandoverScreen.NativeFieldInfoPtr_SuccessLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessLabel");
			HandoverScreen.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ErrorLabel");
			HandoverScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "WarningLabel");
			HandoverScreen.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DoneButton");
			HandoverScreen.NativeFieldInfoPtr_VehicleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleContainer");
			HandoverScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TitleLabel");
			HandoverScreen.NativeFieldInfoPtr_PriceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PriceSelector");
			HandoverScreen.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FairPriceLabel");
			HandoverScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialAnimation");
			HandoverScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialContainer");
			HandoverScreen.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DetailPanel");
			HandoverScreen.NativeFieldInfoPtr_onHandoverComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "onHandoverComplete");
			HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessChanceMethod");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlots");
			HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "OriginalItemLocations");
			HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ignoreCustomerChangedEvents");
			HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentCustomer>k__BackingField");
			HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682786);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682787);
			HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682788);
			HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682789);
			HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682790);
			HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682791);
			HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682792);
			HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682793);
			HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682794);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682795);
			HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682796);
			HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682797);
			HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682798);
			HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682799);
			HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682800);
			HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682801);
			HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682802);
			HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682803);
			HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682804);
			HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682805);
			HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682806);
			HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682807);
			HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682808);
			HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682809);
			HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682810);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682811);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682812);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682813);
			HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100682814);
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x06009EF6 RID: 40694 RVA: 0x002824B0 File Offset: 0x002806B0
		// (set) Token: 0x06009EF7 RID: 40695 RVA: 0x002824F0 File Offset: 0x002806F0
		public unsafe Contract CurrentContract
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x06009EF8 RID: 40696 RVA: 0x00282534 File Offset: 0x00280734
		// (set) Token: 0x06009EF9 RID: 40697 RVA: 0x00282570 File Offset: 0x00280770
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x06009EFA RID: 40698 RVA: 0x002825B0 File Offset: 0x002807B0
		// (set) Token: 0x06009EFB RID: 40699 RVA: 0x002825EC File Offset: 0x002807EC
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57500, RefRangeEnd = 57501, XrefRangeStart = 57500, XrefRangeEnd = 57501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x06009EFC RID: 40700 RVA: 0x0028262C File Offset: 0x0028082C
		// (set) Token: 0x06009EFD RID: 40701 RVA: 0x00282668 File Offset: 0x00280868
		public unsafe HandoverScreen.EMode Mode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45633, RefRangeEnd = 45634, XrefRangeStart = 45633, XrefRangeEnd = 45634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x06009EFE RID: 40702 RVA: 0x002826A8 File Offset: 0x002808A8
		// (set) Token: 0x06009EFF RID: 40703 RVA: 0x002826E8 File Offset: 0x002808E8
		public unsafe Customer CurrentCustomer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x0028272C File Offset: 0x0028092C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280834, XrefRangeEnd = 280902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F01 RID: 40705 RVA: 0x00282768 File Offset: 0x00280968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280902, XrefRangeEnd = 280912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F02 RID: 40706 RVA: 0x0028279C File Offset: 0x0028099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280912, XrefRangeEnd = 280917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F03 RID: 40707 RVA: 0x002827D0 File Offset: 0x002809D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280917, XrefRangeEnd = 280921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F04 RID: 40708 RVA: 0x00282804 File Offset: 0x00280A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280921, XrefRangeEnd = 280978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successChanceMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F05 RID: 40709 RVA: 0x00282898 File Offset: 0x00280A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280978, XrefRangeEnd = 281049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F06 RID: 40710 RVA: 0x002828E4 File Offset: 0x00280AE4
		[CallerCount(0)]
		public unsafe void DonePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F07 RID: 40711 RVA: 0x00282918 File Offset: 0x00280B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281049, XrefRangeEnd = 281080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordOriginalLocations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F08 RID: 40712 RVA: 0x0028294C File Offset: 0x00280B4C
		[CallerCount(0)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F09 RID: 40713 RVA: 0x00282990 File Offset: 0x00280B90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 281091, RefRangeEnd = 281099, XrefRangeStart = 281080, XrefRangeEnd = 281091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCustomerSlots(bool returnToOriginals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToOriginals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F0A RID: 40714 RVA: 0x002829D0 File Offset: 0x00280BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281115, RefRangeEnd = 281117, XrefRangeStart = 281099, XrefRangeEnd = 281115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerItemsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F0B RID: 40715 RVA: 0x00282A04 File Offset: 0x00280C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281117, XrefRangeEnd = 281125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoneButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F0C RID: 40716 RVA: 0x00282A38 File Offset: 0x00280C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281140, RefRangeEnd = 281141, XrefRangeStart = 281125, XrefRangeEnd = 281140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F0D RID: 40717 RVA: 0x00282A6C File Offset: 0x00280C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281162, RefRangeEnd = 281164, XrefRangeStart = 281141, XrefRangeEnd = 281162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetError(out string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			err = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009F0E RID: 40718 RVA: 0x00282AC4 File Offset: 0x00280CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281177, RefRangeEnd = 281179, XrefRangeStart = 281164, XrefRangeEnd = 281177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009F0F RID: 40719 RVA: 0x00282B1C File Offset: 0x00280D1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281197, RefRangeEnd = 281200, XrefRangeStart = 281179, XrefRangeEnd = 281197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06009F10 RID: 40720 RVA: 0x00282B68 File Offset: 0x00280D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281222, RefRangeEnd = 281223, XrefRangeStart = 281200, XrefRangeEnd = 281222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCustomerItemsValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F11 RID: 40721 RVA: 0x00282BA4 File Offset: 0x00280DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281234, RefRangeEnd = 281237, XrefRangeStart = 281223, XrefRangeEnd = 281234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F12 RID: 40722 RVA: 0x00282BF0 File Offset: 0x00280DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281237, XrefRangeEnd = 281251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F13 RID: 40723 RVA: 0x0004DFD2 File Offset: 0x0004C1D2
		public HandoverScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x06009F14 RID: 40724 RVA: 0x00282C2C File Offset: 0x00280E2C
		// (set) Token: 0x06009F15 RID: 40725 RVA: 0x0004DFDB File Offset: 0x0004C1DB
		public unsafe static int CUSTOMER_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06009F16 RID: 40726 RVA: 0x00282C48 File Offset: 0x00280E48
		// (set) Token: 0x06009F17 RID: 40727 RVA: 0x0004DFE9 File Offset: 0x0004C1E9
		public unsafe static float VEHICLE_MAX_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&value));
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06009F18 RID: 40728 RVA: 0x00282C64 File Offset: 0x00280E64
		// (set) Token: 0x06009F19 RID: 40729 RVA: 0x0004DFF7 File Offset: 0x0004C1F7
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x06009F1A RID: 40730 RVA: 0x00282C94 File Offset: 0x00280E94
		// (set) Token: 0x06009F1B RID: 40731 RVA: 0x0004E016 File Offset: 0x0004C216
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x06009F1C RID: 40732 RVA: 0x00282CBC File Offset: 0x00280EBC
		// (set) Token: 0x06009F1D RID: 40733 RVA: 0x0004E031 File Offset: 0x0004C231
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06009F1E RID: 40734 RVA: 0x00282CE4 File Offset: 0x00280EE4
		// (set) Token: 0x06009F1F RID: 40735 RVA: 0x0004E04C File Offset: 0x0004C24C
		public unsafe HandoverScreen.EMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06009F20 RID: 40736 RVA: 0x00282D0C File Offset: 0x00280F0C
		// (set) Token: 0x06009F21 RID: 40737 RVA: 0x0004E067 File Offset: 0x0004C267
		public unsafe Gradient SuccessColorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x06009F22 RID: 40738 RVA: 0x00282D3C File Offset: 0x00280F3C
		// (set) Token: 0x06009F23 RID: 40739 RVA: 0x0004E086 File Offset: 0x0004C286
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x06009F24 RID: 40740 RVA: 0x00282D6C File Offset: 0x00280F6C
		// (set) Token: 0x06009F25 RID: 40741 RVA: 0x0004E0A5 File Offset: 0x0004C2A5
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x06009F26 RID: 40742 RVA: 0x00282D9C File Offset: 0x00280F9C
		// (set) Token: 0x06009F27 RID: 40743 RVA: 0x0004E0C4 File Offset: 0x0004C2C4
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06009F28 RID: 40744 RVA: 0x00282DCC File Offset: 0x00280FCC
		// (set) Token: 0x06009F29 RID: 40745 RVA: 0x0004E0E3 File Offset: 0x0004C2E3
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06009F2A RID: 40746 RVA: 0x00282DFC File Offset: 0x00280FFC
		// (set) Token: 0x06009F2B RID: 40747 RVA: 0x0004E102 File Offset: 0x0004C302
		public unsafe TextMeshProUGUI CustomerSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06009F2C RID: 40748 RVA: 0x00282E2C File Offset: 0x0028102C
		// (set) Token: 0x06009F2D RID: 40749 RVA: 0x0004E121 File Offset: 0x0004C321
		public unsafe TextMeshProUGUI FavouriteDrugLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06009F2E RID: 40750 RVA: 0x00282E5C File Offset: 0x0028105C
		// (set) Token: 0x06009F2F RID: 40751 RVA: 0x0004E140 File Offset: 0x0004C340
		public unsafe TextMeshProUGUI FavouritePropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009F30 RID: 40752 RVA: 0x00282E8C File Offset: 0x0028108C
		// (set) Token: 0x06009F31 RID: 40753 RVA: 0x0004E15F File Offset: 0x0004C35F
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> PropertiesEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009F32 RID: 40754 RVA: 0x00282EBC File Offset: 0x002810BC
		// (set) Token: 0x06009F33 RID: 40755 RVA: 0x0004E17E File Offset: 0x0004C37E
		public unsafe Il2CppReferenceArray<RectTransform> ExpectationEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009F34 RID: 40756 RVA: 0x00282EEC File Offset: 0x002810EC
		// (set) Token: 0x06009F35 RID: 40757 RVA: 0x0004E19D File Offset: 0x0004C39D
		public unsafe GameObject NoVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009F36 RID: 40758 RVA: 0x00282F1C File Offset: 0x0028111C
		// (set) Token: 0x06009F37 RID: 40759 RVA: 0x0004E1BC File Offset: 0x0004C3BC
		public unsafe RectTransform VehicleSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009F38 RID: 40760 RVA: 0x00282F4C File Offset: 0x0028114C
		// (set) Token: 0x06009F39 RID: 40761 RVA: 0x0004E1DB File Offset: 0x0004C3DB
		public unsafe RectTransform CustomerSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009F3A RID: 40762 RVA: 0x00282F7C File Offset: 0x0028117C
		// (set) Token: 0x06009F3B RID: 40763 RVA: 0x0004E1FA File Offset: 0x0004C3FA
		public unsafe TextMeshProUGUI VehicleSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06009F3C RID: 40764 RVA: 0x00282FAC File Offset: 0x002811AC
		// (set) Token: 0x06009F3D RID: 40765 RVA: 0x0004E219 File Offset: 0x0004C419
		public unsafe TextMeshProUGUI SuccessLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x06009F3E RID: 40766 RVA: 0x00282FDC File Offset: 0x002811DC
		// (set) Token: 0x06009F3F RID: 40767 RVA: 0x0004E238 File Offset: 0x0004C438
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x06009F40 RID: 40768 RVA: 0x0028300C File Offset: 0x0028120C
		// (set) Token: 0x06009F41 RID: 40769 RVA: 0x0004E257 File Offset: 0x0004C457
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x06009F42 RID: 40770 RVA: 0x0028303C File Offset: 0x0028123C
		// (set) Token: 0x06009F43 RID: 40771 RVA: 0x0004E276 File Offset: 0x0004C476
		public unsafe Button DoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x06009F44 RID: 40772 RVA: 0x0028306C File Offset: 0x0028126C
		// (set) Token: 0x06009F45 RID: 40773 RVA: 0x0004E295 File Offset: 0x0004C495
		public unsafe RectTransform VehicleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x06009F46 RID: 40774 RVA: 0x0028309C File Offset: 0x0028129C
		// (set) Token: 0x06009F47 RID: 40775 RVA: 0x0004E2B4 File Offset: 0x0004C4B4
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009F48 RID: 40776 RVA: 0x002830CC File Offset: 0x002812CC
		// (set) Token: 0x06009F49 RID: 40777 RVA: 0x0004E2D3 File Offset: 0x0004C4D3
		public unsafe HandoverScreenPriceSelector PriceSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenPriceSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009F4A RID: 40778 RVA: 0x002830FC File Offset: 0x002812FC
		// (set) Token: 0x06009F4B RID: 40779 RVA: 0x0004E2F2 File Offset: 0x0004C4F2
		public unsafe TextMeshProUGUI FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x06009F4C RID: 40780 RVA: 0x0028312C File Offset: 0x0028132C
		// (set) Token: 0x06009F4D RID: 40781 RVA: 0x0004E311 File Offset: 0x0004C511
		public unsafe Animation TutorialAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x06009F4E RID: 40782 RVA: 0x0028315C File Offset: 0x0028135C
		// (set) Token: 0x06009F4F RID: 40783 RVA: 0x0004E330 File Offset: 0x0004C530
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x06009F50 RID: 40784 RVA: 0x0028318C File Offset: 0x0028138C
		// (set) Token: 0x06009F51 RID: 40785 RVA: 0x0004E34F File Offset: 0x0004C54F
		public unsafe HandoverScreenDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x06009F52 RID: 40786 RVA: 0x002831BC File Offset: 0x002813BC
		// (set) Token: 0x06009F53 RID: 40787 RVA: 0x0004E36E File Offset: 0x0004C56E
		public unsafe Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x06009F54 RID: 40788 RVA: 0x002831EC File Offset: 0x002813EC
		// (set) Token: 0x06009F55 RID: 40789 RVA: 0x0004E38D File Offset: 0x0004C58D
		public unsafe Func<List<ItemInstance>, float, float> SuccessChanceMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<ItemInstance>, float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x06009F56 RID: 40790 RVA: 0x0028321C File Offset: 0x0028141C
		// (set) Token: 0x06009F57 RID: 40791 RVA: 0x0004E3AC File Offset: 0x0004C5AC
		public unsafe Il2CppReferenceArray<ItemSlotUI> VehicleSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x06009F58 RID: 40792 RVA: 0x0028324C File Offset: 0x0028144C
		// (set) Token: 0x06009F59 RID: 40793 RVA: 0x0004E3CB File Offset: 0x0004C5CB
		public unsafe Il2CppReferenceArray<ItemSlotUI> CustomerSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x0028327C File Offset: 0x0028147C
		// (set) Token: 0x06009F5B RID: 40795 RVA: 0x0004E3EA File Offset: 0x0004C5EA
		public unsafe Il2CppReferenceArray<ItemSlot> CustomerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x002832AC File Offset: 0x002814AC
		// (set) Token: 0x06009F5D RID: 40797 RVA: 0x0004E409 File Offset: 0x0004C609
		public unsafe Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ItemInstance, HandoverScreen.EItemSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002832DC File Offset: 0x002814DC
		// (set) Token: 0x06009F5F RID: 40799 RVA: 0x0004E428 File Offset: 0x0004C628
		public unsafe bool ignoreCustomerChangedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents)) = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x00283304 File Offset: 0x00281504
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x0004E443 File Offset: 0x0004C643
		public unsafe Customer _CurrentCustomer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AA6 RID: 27302
		private static readonly IntPtr NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT;

		// Token: 0x04006AA7 RID: 27303
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_MAX_DIST;

		// Token: 0x04006AA8 RID: 27304
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04006AA9 RID: 27305
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006AAA RID: 27306
		private static readonly IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04006AAB RID: 27307
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04006AAC RID: 27308
		private static readonly IntPtr NativeFieldInfoPtr_SuccessColorMap;

		// Token: 0x04006AAD RID: 27309
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006AAE RID: 27310
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006AAF RID: 27311
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006AB0 RID: 27312
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006AB1 RID: 27313
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSubtitle;

		// Token: 0x04006AB2 RID: 27314
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteDrugLabel;

		// Token: 0x04006AB3 RID: 27315
		private static readonly IntPtr NativeFieldInfoPtr_FavouritePropertiesLabel;

		// Token: 0x04006AB4 RID: 27316
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesEntries;

		// Token: 0x04006AB5 RID: 27317
		private static readonly IntPtr NativeFieldInfoPtr_ExpectationEntries;

		// Token: 0x04006AB6 RID: 27318
		private static readonly IntPtr NativeFieldInfoPtr_NoVehicle;

		// Token: 0x04006AB7 RID: 27319
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSlotContainer;

		// Token: 0x04006AB8 RID: 27320
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotContainer;

		// Token: 0x04006AB9 RID: 27321
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSubtitle;

		// Token: 0x04006ABA RID: 27322
		private static readonly IntPtr NativeFieldInfoPtr_SuccessLabel;

		// Token: 0x04006ABB RID: 27323
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04006ABC RID: 27324
		private static readonly IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x04006ABD RID: 27325
		private static readonly IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x04006ABE RID: 27326
		private static readonly IntPtr NativeFieldInfoPtr_VehicleContainer;

		// Token: 0x04006ABF RID: 27327
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006AC0 RID: 27328
		private static readonly IntPtr NativeFieldInfoPtr_PriceSelector;

		// Token: 0x04006AC1 RID: 27329
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x04006AC2 RID: 27330
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04006AC3 RID: 27331
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04006AC4 RID: 27332
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006AC5 RID: 27333
		private static readonly IntPtr NativeFieldInfoPtr_onHandoverComplete;

		// Token: 0x04006AC6 RID: 27334
		private static readonly IntPtr NativeFieldInfoPtr_SuccessChanceMethod;

		// Token: 0x04006AC7 RID: 27335
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSlotUIs;

		// Token: 0x04006AC8 RID: 27336
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotUIs;

		// Token: 0x04006AC9 RID: 27337
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlots;

		// Token: 0x04006ACA RID: 27338
		private static readonly IntPtr NativeFieldInfoPtr_OriginalItemLocations;

		// Token: 0x04006ACB RID: 27339
		private static readonly IntPtr NativeFieldInfoPtr_ignoreCustomerChangedEvents;

		// Token: 0x04006ACC RID: 27340
		private static readonly IntPtr NativeFieldInfoPtr__CurrentCustomer_k__BackingField;

		// Token: 0x04006ACD RID: 27341
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04006ACE RID: 27342
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04006ACF RID: 27343
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006AD0 RID: 27344
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006AD1 RID: 27345
		private static readonly IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04006AD2 RID: 27346
		private static readonly IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006AD3 RID: 27347
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04006AD4 RID: 27348
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0;

		// Token: 0x04006AD5 RID: 27349
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0;

		// Token: 0x04006AD6 RID: 27350
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0;

		// Token: 0x04006AD7 RID: 27351
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006AD8 RID: 27352
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006AD9 RID: 27353
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04006ADA RID: 27354
		private static readonly IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04006ADB RID: 27355
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0;

		// Token: 0x04006ADC RID: 27356
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0;

		// Token: 0x04006ADD RID: 27357
		private static readonly IntPtr NativeMethodInfoPtr_DonePressed_Public_Void_0;

		// Token: 0x04006ADE RID: 27358
		private static readonly IntPtr NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0;

		// Token: 0x04006ADF RID: 27359
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006AE0 RID: 27360
		private static readonly IntPtr NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0;

		// Token: 0x04006AE1 RID: 27361
		private static readonly IntPtr NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0;

		// Token: 0x04006AE2 RID: 27362
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0;

		// Token: 0x04006AE3 RID: 27363
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0;

		// Token: 0x04006AE4 RID: 27364
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0;

		// Token: 0x04006AE5 RID: 27365
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006AE6 RID: 27366
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0;

		// Token: 0x04006AE7 RID: 27367
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0;

		// Token: 0x04006AE8 RID: 27368
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0;

		// Token: 0x04006AE9 RID: 27369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA0 RID: 2976
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x040093C0 RID: 37824
			Contract,
			// Token: 0x040093C1 RID: 37825
			Sample,
			// Token: 0x040093C2 RID: 37826
			Offer
		}

		// Token: 0x02000BA1 RID: 2977
		[OriginalName("Assembly-CSharp.dll", "", "EHandoverOutcome")]
		public enum EHandoverOutcome
		{
			// Token: 0x040093C4 RID: 37828
			Cancelled,
			// Token: 0x040093C5 RID: 37829
			Finalize
		}

		// Token: 0x02000BA2 RID: 2978
		[OriginalName("Assembly-CSharp.dll", "", "EItemSource")]
		public enum EItemSource
		{
			// Token: 0x040093C7 RID: 37831
			Player,
			// Token: 0x040093C8 RID: 37832
			Vehicle
		}
	}
}
