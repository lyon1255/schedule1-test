using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Money;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.ATM
{
	// Token: 0x02000702 RID: 1794
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x0600A0CD RID: 41165 RVA: 0x00287808 File Offset: 0x00285A08
		// Note: this type is marked as 'beforefieldinit'.
		static ATMInterface()
		{
			Il2CppClassPointerStore<ATMInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.ATM", "ATMInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr);
			ATMInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "canvas");
			ATMInterface.NativeFieldInfoPtr_atm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "atm");
			ATMInterface.NativeFieldInfoPtr_CompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "CompleteSound");
			ATMInterface.NativeFieldInfoPtr_menuScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menuScreen");
			ATMInterface.NativeFieldInfoPtr_menu_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_TitleText");
			ATMInterface.NativeFieldInfoPtr_menu_DepositButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_DepositButton");
			ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_WithdrawButton");
			ATMInterface.NativeFieldInfoPtr_depositLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitText");
			ATMInterface.NativeFieldInfoPtr_onlineBalanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "onlineBalanceText");
			ATMInterface.NativeFieldInfoPtr_cleanCashText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "cleanCashText");
			ATMInterface.NativeFieldInfoPtr_depositLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitContainer");
			ATMInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorScreen");
			ATMInterface.NativeFieldInfoPtr_amountSelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorTitle");
			ATMInterface.NativeFieldInfoPtr_amountButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountButtons");
			ATMInterface.NativeFieldInfoPtr_amountLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountLabelText");
			ATMInterface.NativeFieldInfoPtr_amountBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountBackground");
			ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedButtonIndicator");
			ATMInterface.NativeFieldInfoPtr_confirmAmountButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmAmountButton");
			ATMInterface.NativeFieldInfoPtr_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmButtonText");
			ATMInterface.NativeFieldInfoPtr_processingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreen");
			ATMInterface.NativeFieldInfoPtr_processingScreenIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreenIndicator");
			ATMInterface.NativeFieldInfoPtr_successScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreen");
			ATMInterface.NativeFieldInfoPtr_successScreenSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreenSubtitle");
			ATMInterface.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "doneButton");
			ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<isOpen>k__BackingField");
			ATMInterface.NativeFieldInfoPtr_activeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "activeScreen");
			ATMInterface.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amounts");
			ATMInterface.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositing");
			ATMInterface.NativeFieldInfoPtr_selectedAmountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmountIndex");
			ATMInterface.NativeFieldInfoPtr_selectedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmount");
			ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682965);
			ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682966);
			ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682967);
			ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682968);
			ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682969);
			ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682970);
			ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682971);
			ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682972);
			ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682973);
			ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682974);
			ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682975);
			ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682976);
			ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682977);
			ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682978);
			ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682979);
			ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682980);
			ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682981);
			ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682982);
			ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682983);
			ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682984);
			ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682985);
			ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682986);
			ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682987);
			ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682988);
			ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682989);
			ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682990);
			ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100682991);
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x00287CAC File Offset: 0x00285EAC
		// (set) Token: 0x0600A0CF RID: 41167 RVA: 0x00287CE8 File Offset: 0x00285EE8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x00287D28 File Offset: 0x00285F28
		public unsafe float relevantBalance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 282614, RefRangeEnd = 282620, XrefRangeStart = 282607, XrefRangeEnd = 282614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x00287D64 File Offset: 0x00285F64
		public unsafe static float remainingAllowedDeposit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282624, RefRangeEnd = 282627, XrefRangeStart = 282620, XrefRangeEnd = 282624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00287D94 File Offset: 0x00285F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282627, XrefRangeEnd = 282662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x00287DC8 File Offset: 0x00285FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282662, XrefRangeEnd = 282682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x00287DFC File Offset: 0x00285FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282682, XrefRangeEnd = 282736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00287E38 File Offset: 0x00286038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282736, XrefRangeEnd = 282742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x00287E6C File Offset: 0x0028606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282742, XrefRangeEnd = 282826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x00287EA8 File Offset: 0x002860A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282826, XrefRangeEnd = 282840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x00287EE4 File Offset: 0x002860E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282840, XrefRangeEnd = 282859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x00287F30 File Offset: 0x00286130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282859, XrefRangeEnd = 282870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00287F80 File Offset: 0x00286180
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 282893, RefRangeEnd = 282899, XrefRangeStart = 282870, XrefRangeEnd = 282893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveScreen(RectTransform screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00287FC4 File Offset: 0x002861C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282909, RefRangeEnd = 282910, XrefRangeStart = 282899, XrefRangeEnd = 282909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00287FF8 File Offset: 0x002861F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282910, XrefRangeEnd = 282914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepositButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x0028802C File Offset: 0x0028622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282914, XrefRangeEnd = 282945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithdrawButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00288060 File Offset: 0x00286260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282945, XrefRangeEnd = 282946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x00288094 File Offset: 0x00286294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282951, RefRangeEnd = 282953, XrefRangeStart = 282946, XrefRangeEnd = 282951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountSelected(int amountIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amountIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x002880D4 File Offset: 0x002862D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282971, RefRangeEnd = 282973, XrefRangeStart = 282953, XrefRangeEnd = 282971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00288114 File Offset: 0x00286314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282986, RefRangeEnd = 282988, XrefRangeStart = 282973, XrefRangeEnd = 282986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAmountFromIndex(int index, bool depositing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00288160 File Offset: 0x00286360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283027, RefRangeEnd = 283028, XrefRangeStart = 282988, XrefRangeEnd = 283027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailableAmounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x00288194 File Offset: 0x00286394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283028, XrefRangeEnd = 283034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x002881C8 File Offset: 0x002863C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283034, XrefRangeEnd = 283035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00288208 File Offset: 0x00286408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283035, XrefRangeEnd = 283040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x00288264 File Offset: 0x00286464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248605, RefRangeEnd = 248608, XrefRangeStart = 248605, XrefRangeEnd = 248608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x00288298 File Offset: 0x00286498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToMenuButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x002882CC File Offset: 0x002864CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283040, XrefRangeEnd = 283048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATMInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x0004F188 File Offset: 0x0004D388
		public ATMInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600A0EA RID: 41194 RVA: 0x00288308 File Offset: 0x00286508
		// (set) Token: 0x0600A0EB RID: 41195 RVA: 0x0004F191 File Offset: 0x0004D391
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600A0EC RID: 41196 RVA: 0x00288338 File Offset: 0x00286538
		// (set) Token: 0x0600A0ED RID: 41197 RVA: 0x0004F1B0 File Offset: 0x0004D3B0
		public unsafe ATM atm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600A0EE RID: 41198 RVA: 0x00288368 File Offset: 0x00286568
		// (set) Token: 0x0600A0EF RID: 41199 RVA: 0x0004F1CF File Offset: 0x0004D3CF
		public unsafe AudioSourceController CompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600A0F0 RID: 41200 RVA: 0x00288398 File Offset: 0x00286598
		// (set) Token: 0x0600A0F1 RID: 41201 RVA: 0x0004F1EE File Offset: 0x0004D3EE
		public unsafe RectTransform menuScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600A0F2 RID: 41202 RVA: 0x002883C8 File Offset: 0x002865C8
		// (set) Token: 0x0600A0F3 RID: 41203 RVA: 0x0004F20D File Offset: 0x0004D40D
		public unsafe Text menu_TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600A0F4 RID: 41204 RVA: 0x002883F8 File Offset: 0x002865F8
		// (set) Token: 0x0600A0F5 RID: 41205 RVA: 0x0004F22C File Offset: 0x0004D42C
		public unsafe Button menu_DepositButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600A0F6 RID: 41206 RVA: 0x00288428 File Offset: 0x00286628
		// (set) Token: 0x0600A0F7 RID: 41207 RVA: 0x0004F24B File Offset: 0x0004D44B
		public unsafe Button menu_WithdrawButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600A0F8 RID: 41208 RVA: 0x00288458 File Offset: 0x00286658
		// (set) Token: 0x0600A0F9 RID: 41209 RVA: 0x0004F26A File Offset: 0x0004D46A
		public unsafe Text depositLimitText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600A0FA RID: 41210 RVA: 0x00288488 File Offset: 0x00286688
		// (set) Token: 0x0600A0FB RID: 41211 RVA: 0x0004F289 File Offset: 0x0004D489
		public unsafe Text onlineBalanceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x002884B8 File Offset: 0x002866B8
		// (set) Token: 0x0600A0FD RID: 41213 RVA: 0x0004F2A8 File Offset: 0x0004D4A8
		public unsafe Text cleanCashText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x002884E8 File Offset: 0x002866E8
		// (set) Token: 0x0600A0FF RID: 41215 RVA: 0x0004F2C7 File Offset: 0x0004D4C7
		public unsafe RectTransform depositLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600A100 RID: 41216 RVA: 0x00288518 File Offset: 0x00286718
		// (set) Token: 0x0600A101 RID: 41217 RVA: 0x0004F2E6 File Offset: 0x0004D4E6
		public unsafe RectTransform amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600A102 RID: 41218 RVA: 0x00288548 File Offset: 0x00286748
		// (set) Token: 0x0600A103 RID: 41219 RVA: 0x0004F305 File Offset: 0x0004D505
		public unsafe Text amountSelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x00288578 File Offset: 0x00286778
		// (set) Token: 0x0600A105 RID: 41221 RVA: 0x0004F324 File Offset: 0x0004D524
		public unsafe List<Button> amountButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x002885A8 File Offset: 0x002867A8
		// (set) Token: 0x0600A107 RID: 41223 RVA: 0x0004F343 File Offset: 0x0004D543
		public unsafe Text amountLabelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x002885D8 File Offset: 0x002867D8
		// (set) Token: 0x0600A109 RID: 41225 RVA: 0x0004F362 File Offset: 0x0004D562
		public unsafe RectTransform amountBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x00288608 File Offset: 0x00286808
		// (set) Token: 0x0600A10B RID: 41227 RVA: 0x0004F381 File Offset: 0x0004D581
		public unsafe RectTransform selectedButtonIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600A10C RID: 41228 RVA: 0x00288638 File Offset: 0x00286838
		// (set) Token: 0x0600A10D RID: 41229 RVA: 0x0004F3A0 File Offset: 0x0004D5A0
		public unsafe Button confirmAmountButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x00288668 File Offset: 0x00286868
		// (set) Token: 0x0600A10F RID: 41231 RVA: 0x0004F3BF File Offset: 0x0004D5BF
		public unsafe Text confirmButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x00288698 File Offset: 0x00286898
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x0004F3DE File Offset: 0x0004D5DE
		public unsafe RectTransform processingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x002886C8 File Offset: 0x002868C8
		// (set) Token: 0x0600A113 RID: 41235 RVA: 0x0004F3FD File Offset: 0x0004D5FD
		public unsafe RectTransform processingScreenIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x002886F8 File Offset: 0x002868F8
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x0004F41C File Offset: 0x0004D61C
		public unsafe RectTransform successScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x00288728 File Offset: 0x00286928
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x0004F43B File Offset: 0x0004D63B
		public unsafe Text successScreenSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x00288758 File Offset: 0x00286958
		// (set) Token: 0x0600A119 RID: 41241 RVA: 0x0004F45A File Offset: 0x0004D65A
		public unsafe Button doneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x00288788 File Offset: 0x00286988
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x0004F479 File Offset: 0x0004D679
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x002887B0 File Offset: 0x002869B0
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x0004F494 File Offset: 0x0004D694
		public unsafe RectTransform activeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x002887E0 File Offset: 0x002869E0
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x0004F4B3 File Offset: 0x0004D6B3
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ATMInterface.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATMInterface.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x00288808 File Offset: 0x00286A08
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x0004F4C5 File Offset: 0x0004D6C5
		public unsafe bool depositing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing)) = value;
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x00288830 File Offset: 0x00286A30
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x0004F4E0 File Offset: 0x0004D6E0
		public unsafe int selectedAmountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex)) = value;
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x00288858 File Offset: 0x00286A58
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x0004F4FB File Offset: 0x0004D6FB
		public unsafe float selectedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount)) = value;
			}
		}

		// Token: 0x04006BC9 RID: 27593
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006BCA RID: 27594
		private static readonly IntPtr NativeFieldInfoPtr_atm;

		// Token: 0x04006BCB RID: 27595
		private static readonly IntPtr NativeFieldInfoPtr_CompleteSound;

		// Token: 0x04006BCC RID: 27596
		private static readonly IntPtr NativeFieldInfoPtr_menuScreen;

		// Token: 0x04006BCD RID: 27597
		private static readonly IntPtr NativeFieldInfoPtr_menu_TitleText;

		// Token: 0x04006BCE RID: 27598
		private static readonly IntPtr NativeFieldInfoPtr_menu_DepositButton;

		// Token: 0x04006BCF RID: 27599
		private static readonly IntPtr NativeFieldInfoPtr_menu_WithdrawButton;

		// Token: 0x04006BD0 RID: 27600
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitText;

		// Token: 0x04006BD1 RID: 27601
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceText;

		// Token: 0x04006BD2 RID: 27602
		private static readonly IntPtr NativeFieldInfoPtr_cleanCashText;

		// Token: 0x04006BD3 RID: 27603
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitContainer;

		// Token: 0x04006BD4 RID: 27604
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04006BD5 RID: 27605
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorTitle;

		// Token: 0x04006BD6 RID: 27606
		private static readonly IntPtr NativeFieldInfoPtr_amountButtons;

		// Token: 0x04006BD7 RID: 27607
		private static readonly IntPtr NativeFieldInfoPtr_amountLabelText;

		// Token: 0x04006BD8 RID: 27608
		private static readonly IntPtr NativeFieldInfoPtr_amountBackground;

		// Token: 0x04006BD9 RID: 27609
		private static readonly IntPtr NativeFieldInfoPtr_selectedButtonIndicator;

		// Token: 0x04006BDA RID: 27610
		private static readonly IntPtr NativeFieldInfoPtr_confirmAmountButton;

		// Token: 0x04006BDB RID: 27611
		private static readonly IntPtr NativeFieldInfoPtr_confirmButtonText;

		// Token: 0x04006BDC RID: 27612
		private static readonly IntPtr NativeFieldInfoPtr_processingScreen;

		// Token: 0x04006BDD RID: 27613
		private static readonly IntPtr NativeFieldInfoPtr_processingScreenIndicator;

		// Token: 0x04006BDE RID: 27614
		private static readonly IntPtr NativeFieldInfoPtr_successScreen;

		// Token: 0x04006BDF RID: 27615
		private static readonly IntPtr NativeFieldInfoPtr_successScreenSubtitle;

		// Token: 0x04006BE0 RID: 27616
		private static readonly IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x04006BE1 RID: 27617
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006BE2 RID: 27618
		private static readonly IntPtr NativeFieldInfoPtr_activeScreen;

		// Token: 0x04006BE3 RID: 27619
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x04006BE4 RID: 27620
		private static readonly IntPtr NativeFieldInfoPtr_depositing;

		// Token: 0x04006BE5 RID: 27621
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountIndex;

		// Token: 0x04006BE6 RID: 27622
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmount;

		// Token: 0x04006BE7 RID: 27623
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006BE8 RID: 27624
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006BE9 RID: 27625
		private static readonly IntPtr NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0;

		// Token: 0x04006BEA RID: 27626
		private static readonly IntPtr NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0;

		// Token: 0x04006BEB RID: 27627
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006BEC RID: 27628
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006BED RID: 27629
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006BEE RID: 27630
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04006BEF RID: 27631
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006BF0 RID: 27632
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006BF1 RID: 27633
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006BF2 RID: 27634
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006BF3 RID: 27635
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0;

		// Token: 0x04006BF4 RID: 27636
		private static readonly IntPtr NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0;

		// Token: 0x04006BF5 RID: 27637
		private static readonly IntPtr NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0;

		// Token: 0x04006BF6 RID: 27638
		private static readonly IntPtr NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0;

		// Token: 0x04006BF7 RID: 27639
		private static readonly IntPtr NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0;

		// Token: 0x04006BF8 RID: 27640
		private static readonly IntPtr NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0;

		// Token: 0x04006BF9 RID: 27641
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0;

		// Token: 0x04006BFA RID: 27642
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0;

		// Token: 0x04006BFB RID: 27643
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0;

		// Token: 0x04006BFC RID: 27644
		private static readonly IntPtr NativeMethodInfoPtr_AmountConfirmed_Public_Void_0;

		// Token: 0x04006BFD RID: 27645
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006BFE RID: 27646
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0;

		// Token: 0x04006BFF RID: 27647
		private static readonly IntPtr NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0;

		// Token: 0x04006C00 RID: 27648
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0;

		// Token: 0x04006C01 RID: 27649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCFC RID: 56572 RVA: 0x00343638 File Offset: 0x00341838
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr);
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "fuckYou");
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100682993);
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100682994);
			}

			// Token: 0x0600DCFD RID: 56573 RVA: 0x003436B4 File Offset: 0x003418B4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCFE RID: 56574 RVA: 0x003436F0 File Offset: 0x003418F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282587, XrefRangeEnd = 282589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCFF RID: 56575 RVA: 0x0006BB1D File Offset: 0x00069D1D
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447D RID: 17533
			// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x00343724 File Offset: 0x00341924
			// (set) Token: 0x0600DD01 RID: 56577 RVA: 0x0006BB26 File Offset: 0x00069D26
			public unsafe int fuckYou
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou)) = value;
				}
			}

			// Token: 0x1700447E RID: 17534
			// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x0034374C File Offset: 0x0034194C
			// (set) Token: 0x0600DD03 RID: 56579 RVA: 0x0006BB41 File Offset: 0x00069D41
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009410 RID: 37904
			private static readonly IntPtr NativeFieldInfoPtr_fuckYou;

			// Token: 0x04009411 RID: 37905
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009412 RID: 37906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009413 RID: 37907
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000BB0 RID: 2992
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<ProcessTransaction>d__56")]
		public sealed class _ProcessTransaction_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600DD04 RID: 56580 RVA: 0x0034377C File Offset: 0x0034197C
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessTransaction_d__56()
			{
				Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<ProcessTransaction>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr);
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>1__state");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>2__current");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>4__this");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "depositing");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "amount");
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100682995);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100682996);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100682997);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100682998);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100682999);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683000);
			}

			// Token: 0x0600DD05 RID: 56581 RVA: 0x00343884 File Offset: 0x00341A84
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessTransaction_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD06 RID: 56582 RVA: 0x003438CC File Offset: 0x00341ACC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD07 RID: 56583 RVA: 0x00343900 File Offset: 0x00341B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282589, XrefRangeEnd = 282602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004484 RID: 17540
			// (get) Token: 0x0600DD08 RID: 56584 RVA: 0x0034393C File Offset: 0x00341B3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD09 RID: 56585 RVA: 0x0034397C File Offset: 0x00341B7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282602, XrefRangeEnd = 282607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004485 RID: 17541
			// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x003439B0 File Offset: 0x00341BB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD0B RID: 56587 RVA: 0x0006BB60 File Offset: 0x00069D60
			public _ProcessTransaction_d__56(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447F RID: 17535
			// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x003439F0 File Offset: 0x00341BF0
			// (set) Token: 0x0600DD0D RID: 56589 RVA: 0x0006BB69 File Offset: 0x00069D69
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004480 RID: 17536
			// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x00343A18 File Offset: 0x00341C18
			// (set) Token: 0x0600DD0F RID: 56591 RVA: 0x0006BB84 File Offset: 0x00069D84
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004481 RID: 17537
			// (get) Token: 0x0600DD10 RID: 56592 RVA: 0x00343A48 File Offset: 0x00341C48
			// (set) Token: 0x0600DD11 RID: 56593 RVA: 0x0006BBA3 File Offset: 0x00069DA3
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004482 RID: 17538
			// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00343A78 File Offset: 0x00341C78
			// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x0006BBC2 File Offset: 0x00069DC2
			public unsafe bool depositing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing)) = value;
				}
			}

			// Token: 0x17004483 RID: 17539
			// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x00343AA0 File Offset: 0x00341CA0
			// (set) Token: 0x0600DD15 RID: 56597 RVA: 0x0006BBDD File Offset: 0x00069DDD
			public unsafe float amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x04009414 RID: 37908
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009415 RID: 37909
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009416 RID: 37910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009417 RID: 37911
			private static readonly IntPtr NativeFieldInfoPtr_depositing;

			// Token: 0x04009418 RID: 37912
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04009419 RID: 37913
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400941A RID: 37914
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400941B RID: 37915
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400941C RID: 37916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400941D RID: 37917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400941E RID: 37918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
