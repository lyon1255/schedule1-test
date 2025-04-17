using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts.Cash;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000647 RID: 1607
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x06008E2A RID: 36394 RVA: 0x0024FB28 File Offset: 0x0024DD28
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingInterface()
		{
			Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LaunderingInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr);
			LaunderingInterface.NativeFieldInfoPtr_fovOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "fovOverride");
			LaunderingInterface.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "lerpTime");
			LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "minLaunderAmount");
			LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<business>k__BackingField");
			LaunderingInterface.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "cameraPosition");
			LaunderingInterface.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "intObj");
			LaunderingInterface.NativeFieldInfoPtr_launderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderButton");
			LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSelectorScreen");
			LaunderingInterface.NativeFieldInfoPtr_amountSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSlider");
			LaunderingInterface.NativeFieldInfoPtr_amountInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountInputField");
			LaunderingInterface.NativeFieldInfoPtr_notchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notchContainer");
			LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "currentTotalAmountLabel");
			LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderCapacityLabel");
			LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "insufficientCashLabel");
			LaunderingInterface.NativeFieldInfoPtr_entryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryContainer");
			LaunderingInterface.NativeFieldInfoPtr_noEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "noEntries");
			LaunderingInterface.NativeFieldInfoPtr_CashStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "CashStacks");
			LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "timelineNotchPrefab");
			LaunderingInterface.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryPrefab");
			LaunderingInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "canvas");
			LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "selectedAmountToLaunder");
			LaunderingInterface.NativeFieldInfoPtr_operationToNotch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToNotch");
			LaunderingInterface.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notches");
			LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "ignoreSliderChange");
			LaunderingInterface.NativeFieldInfoPtr_operationToEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToEntry");
			LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680948);
			LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680949);
			LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680950);
			LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680951);
			LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680952);
			LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680953);
			LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680954);
			LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680955);
			LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680956);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680957);
			LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680958);
			LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680959);
			LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680960);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680961);
			LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680962);
			LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680963);
			LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680964);
			LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680965);
			LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680966);
			LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680967);
			LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680968);
			LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680969);
			LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680970);
			LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680971);
			LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680972);
			LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680973);
			LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100680974);
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x0024FF68 File Offset: 0x0024E168
		public unsafe int maxLaunderAmount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 258474, RefRangeEnd = 258478, XrefRangeStart = 258468, XrefRangeEnd = 258474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x0024FFA4 File Offset: 0x0024E1A4
		// (set) Token: 0x06008E2D RID: 36397 RVA: 0x0024FFE4 File Offset: 0x0024E1E4
		public unsafe Business business
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Business>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00250028 File Offset: 0x0024E228
		public unsafe bool isOpen
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 258482, RefRangeEnd = 258487, XrefRangeStart = 258478, XrefRangeEnd = 258482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x00250064 File Offset: 0x0024E264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258633, RefRangeEnd = 258634, XrefRangeStart = 258487, XrefRangeEnd = 258633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Business bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x002500A8 File Offset: 0x0024E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258634, XrefRangeEnd = 258709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x002500DC File Offset: 0x0024E2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258709, XrefRangeEnd = 258715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x00250118 File Offset: 0x0024E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258715, XrefRangeEnd = 258718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x0025015C File Offset: 0x0024E35C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258822, RefRangeEnd = 258825, XrefRangeStart = 258718, XrefRangeEnd = 258822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x00250190 File Offset: 0x0024E390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258825, XrefRangeEnd = 258828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x002501C4 File Offset: 0x0024E3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258863, RefRangeEnd = 258864, XrefRangeStart = 258828, XrefRangeEnd = 258863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x00250208 File Offset: 0x0024E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258864, XrefRangeEnd = 258886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x0025024C File Offset: 0x0024E44C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258948, RefRangeEnd = 258950, XrefRangeStart = 258886, XrefRangeEnd = 258948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntryTimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x00250280 File Offset: 0x0024E480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258950, XrefRangeEnd = 258955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashStacks(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E39 RID: 36409 RVA: 0x002502C4 File Offset: 0x0024E4C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258982, RefRangeEnd = 258985, XrefRangeStart = 258955, XrefRangeEnd = 258982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLaunderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x002502F8 File Offset: 0x0024E4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258985, XrefRangeEnd = 258993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x0025032C File Offset: 0x0024E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258993, XrefRangeEnd = 258996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x00250360 File Offset: 0x0024E560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258996, XrefRangeEnd = 259025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00250394 File Offset: 0x0024E594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259025, XrefRangeEnd = 259027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SliderValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x002503C8 File Offset: 0x0024E5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259027, XrefRangeEnd = 259033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x002503FC File Offset: 0x0024E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259033, XrefRangeEnd = 259038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00250430 File Offset: 0x0024E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259038, XrefRangeEnd = 259039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x00250464 File Offset: 0x0024E664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259039, XrefRangeEnd = 259083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x002504A0 File Offset: 0x0024E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259083, XrefRangeEnd = 259118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x002504DC File Offset: 0x0024E6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259118, XrefRangeEnd = 259138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E44 RID: 36420 RVA: 0x00250518 File Offset: 0x0024E718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259138, XrefRangeEnd = 259144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x0025054C File Offset: 0x0024E74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259144, XrefRangeEnd = 259149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateTimeline_b__36_0(KeyValuePair<LaunderingOperation, RectTransform> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x000445AC File Offset: 0x000427AC
		public LaunderingInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x002505A0 File Offset: 0x0024E7A0
		// (set) Token: 0x06008E48 RID: 36424 RVA: 0x000445B5 File Offset: 0x000427B5
		public unsafe static float fovOverride
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&value));
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06008E49 RID: 36425 RVA: 0x002505BC File Offset: 0x0024E7BC
		// (set) Token: 0x06008E4A RID: 36426 RVA: 0x000445C3 File Offset: 0x000427C3
		public unsafe static float lerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&value));
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x002505D8 File Offset: 0x0024E7D8
		// (set) Token: 0x06008E4C RID: 36428 RVA: 0x000445D1 File Offset: 0x000427D1
		public unsafe static int minLaunderAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&value));
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x06008E4D RID: 36429 RVA: 0x002505F4 File Offset: 0x0024E7F4
		// (set) Token: 0x06008E4E RID: 36430 RVA: 0x000445DF File Offset: 0x000427DF
		public unsafe Business _business_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x00250624 File Offset: 0x0024E824
		// (set) Token: 0x06008E50 RID: 36432 RVA: 0x000445FE File Offset: 0x000427FE
		public unsafe Transform cameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x06008E51 RID: 36433 RVA: 0x00250654 File Offset: 0x0024E854
		// (set) Token: 0x06008E52 RID: 36434 RVA: 0x0004461D File Offset: 0x0004281D
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06008E53 RID: 36435 RVA: 0x00250684 File Offset: 0x0024E884
		// (set) Token: 0x06008E54 RID: 36436 RVA: 0x0004463C File Offset: 0x0004283C
		public unsafe Button launderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06008E55 RID: 36437 RVA: 0x002506B4 File Offset: 0x0024E8B4
		// (set) Token: 0x06008E56 RID: 36438 RVA: 0x0004465B File Offset: 0x0004285B
		public unsafe GameObject amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x002506E4 File Offset: 0x0024E8E4
		// (set) Token: 0x06008E58 RID: 36440 RVA: 0x0004467A File Offset: 0x0004287A
		public unsafe Slider amountSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x00250714 File Offset: 0x0024E914
		// (set) Token: 0x06008E5A RID: 36442 RVA: 0x00044699 File Offset: 0x00042899
		public unsafe TMP_InputField amountInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x00250744 File Offset: 0x0024E944
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x000446B8 File Offset: 0x000428B8
		public unsafe RectTransform notchContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x00250774 File Offset: 0x0024E974
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x000446D7 File Offset: 0x000428D7
		public unsafe TextMeshProUGUI currentTotalAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x06008E5F RID: 36447 RVA: 0x002507A4 File Offset: 0x0024E9A4
		// (set) Token: 0x06008E60 RID: 36448 RVA: 0x000446F6 File Offset: 0x000428F6
		public unsafe TextMeshProUGUI launderCapacityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06008E61 RID: 36449 RVA: 0x002507D4 File Offset: 0x0024E9D4
		// (set) Token: 0x06008E62 RID: 36450 RVA: 0x00044715 File Offset: 0x00042915
		public unsafe TextMeshProUGUI insufficientCashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06008E63 RID: 36451 RVA: 0x00250804 File Offset: 0x0024EA04
		// (set) Token: 0x06008E64 RID: 36452 RVA: 0x00044734 File Offset: 0x00042934
		public unsafe RectTransform entryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06008E65 RID: 36453 RVA: 0x00250834 File Offset: 0x0024EA34
		// (set) Token: 0x06008E66 RID: 36454 RVA: 0x00044753 File Offset: 0x00042953
		public unsafe RectTransform noEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06008E67 RID: 36455 RVA: 0x00250864 File Offset: 0x0024EA64
		// (set) Token: 0x06008E68 RID: 36456 RVA: 0x00044772 File Offset: 0x00042972
		public unsafe Il2CppReferenceArray<CashStackVisuals> CashStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashStackVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06008E69 RID: 36457 RVA: 0x00250894 File Offset: 0x0024EA94
		// (set) Token: 0x06008E6A RID: 36458 RVA: 0x00044791 File Offset: 0x00042991
		public unsafe GameObject timelineNotchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06008E6B RID: 36459 RVA: 0x002508C4 File Offset: 0x0024EAC4
		// (set) Token: 0x06008E6C RID: 36460 RVA: 0x000447B0 File Offset: 0x000429B0
		public unsafe GameObject entryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06008E6D RID: 36461 RVA: 0x002508F4 File Offset: 0x0024EAF4
		// (set) Token: 0x06008E6E RID: 36462 RVA: 0x000447CF File Offset: 0x000429CF
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06008E6F RID: 36463 RVA: 0x00250924 File Offset: 0x0024EB24
		// (set) Token: 0x06008E70 RID: 36464 RVA: 0x000447EE File Offset: 0x000429EE
		public unsafe int selectedAmountToLaunder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder)) = value;
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06008E71 RID: 36465 RVA: 0x0025094C File Offset: 0x0024EB4C
		// (set) Token: 0x06008E72 RID: 36466 RVA: 0x00044809 File Offset: 0x00042A09
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToNotch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06008E73 RID: 36467 RVA: 0x0025097C File Offset: 0x0024EB7C
		// (set) Token: 0x06008E74 RID: 36468 RVA: 0x00044828 File Offset: 0x00042A28
		public unsafe List<RectTransform> notches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x002509AC File Offset: 0x0024EBAC
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x00044847 File Offset: 0x00042A47
		public unsafe bool ignoreSliderChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange)) = value;
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06008E77 RID: 36471 RVA: 0x002509D4 File Offset: 0x0024EBD4
		// (set) Token: 0x06008E78 RID: 36472 RVA: 0x00044862 File Offset: 0x00042A62
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006041 RID: 24641
		private static readonly IntPtr NativeFieldInfoPtr_fovOverride;

		// Token: 0x04006042 RID: 24642
		private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

		// Token: 0x04006043 RID: 24643
		private static readonly IntPtr NativeFieldInfoPtr_minLaunderAmount;

		// Token: 0x04006044 RID: 24644
		private static readonly IntPtr NativeFieldInfoPtr__business_k__BackingField;

		// Token: 0x04006045 RID: 24645
		private static readonly IntPtr NativeFieldInfoPtr_cameraPosition;

		// Token: 0x04006046 RID: 24646
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04006047 RID: 24647
		private static readonly IntPtr NativeFieldInfoPtr_launderButton;

		// Token: 0x04006048 RID: 24648
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04006049 RID: 24649
		private static readonly IntPtr NativeFieldInfoPtr_amountSlider;

		// Token: 0x0400604A RID: 24650
		private static readonly IntPtr NativeFieldInfoPtr_amountInputField;

		// Token: 0x0400604B RID: 24651
		private static readonly IntPtr NativeFieldInfoPtr_notchContainer;

		// Token: 0x0400604C RID: 24652
		private static readonly IntPtr NativeFieldInfoPtr_currentTotalAmountLabel;

		// Token: 0x0400604D RID: 24653
		private static readonly IntPtr NativeFieldInfoPtr_launderCapacityLabel;

		// Token: 0x0400604E RID: 24654
		private static readonly IntPtr NativeFieldInfoPtr_insufficientCashLabel;

		// Token: 0x0400604F RID: 24655
		private static readonly IntPtr NativeFieldInfoPtr_entryContainer;

		// Token: 0x04006050 RID: 24656
		private static readonly IntPtr NativeFieldInfoPtr_noEntries;

		// Token: 0x04006051 RID: 24657
		private static readonly IntPtr NativeFieldInfoPtr_CashStacks;

		// Token: 0x04006052 RID: 24658
		private static readonly IntPtr NativeFieldInfoPtr_timelineNotchPrefab;

		// Token: 0x04006053 RID: 24659
		private static readonly IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x04006054 RID: 24660
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006055 RID: 24661
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountToLaunder;

		// Token: 0x04006056 RID: 24662
		private static readonly IntPtr NativeFieldInfoPtr_operationToNotch;

		// Token: 0x04006057 RID: 24663
		private static readonly IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04006058 RID: 24664
		private static readonly IntPtr NativeFieldInfoPtr_ignoreSliderChange;

		// Token: 0x04006059 RID: 24665
		private static readonly IntPtr NativeFieldInfoPtr_operationToEntry;

		// Token: 0x0400605A RID: 24666
		private static readonly IntPtr NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0;

		// Token: 0x0400605B RID: 24667
		private static readonly IntPtr NativeMethodInfoPtr_get_business_Public_get_Business_0;

		// Token: 0x0400605C RID: 24668
		private static readonly IntPtr NativeMethodInfoPtr_set_business_Private_set_Void_Business_0;

		// Token: 0x0400605D RID: 24669
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400605E RID: 24670
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Business_0;

		// Token: 0x0400605F RID: 24671
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006060 RID: 24672
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006061 RID: 24673
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0;

		// Token: 0x04006062 RID: 24674
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0;

		// Token: 0x04006063 RID: 24675
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0;

		// Token: 0x04006064 RID: 24676
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006065 RID: 24677
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006066 RID: 24678
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0;

		// Token: 0x04006067 RID: 24679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0;

		// Token: 0x04006068 RID: 24680
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0;

		// Token: 0x04006069 RID: 24681
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0;

		// Token: 0x0400606A RID: 24682
		private static readonly IntPtr NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0;

		// Token: 0x0400606B RID: 24683
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmAmount_Public_Void_0;

		// Token: 0x0400606C RID: 24684
		private static readonly IntPtr NativeMethodInfoPtr_SliderValueChanged_Public_Void_0;

		// Token: 0x0400606D RID: 24685
		private static readonly IntPtr NativeMethodInfoPtr_InputValueChanged_Public_Void_0;

		// Token: 0x0400606E RID: 24686
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400606F RID: 24687
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006070 RID: 24688
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04006071 RID: 24689
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04006072 RID: 24690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006073 RID: 24691
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0;

		// Token: 0x04006074 RID: 24692
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0;

		// Token: 0x02000B2B RID: 2859
		[ObfuscatedName("ScheduleOne.UI.LaunderingInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7CE RID: 55246 RVA: 0x00334914 File Offset: 0x00332B14
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr);
				LaunderingInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9");
				LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9__36_1");
				LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100680976);
				LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100680977);
			}

			// Token: 0x0600D7CF RID: 55247 RVA: 0x00334990 File Offset: 0x00332B90
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D0 RID: 55248 RVA: 0x003349CC File Offset: 0x00332BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258467, XrefRangeEnd = 258468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RectTransform _UpdateTimeline_b__36_1(KeyValuePair<LaunderingOperation, RectTransform> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}

			// Token: 0x0600D7D1 RID: 55249 RVA: 0x0006915C File Offset: 0x0006735C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E4 RID: 17124
			// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x00334A24 File Offset: 0x00332C24
			// (set) Token: 0x0600D7D3 RID: 55251 RVA: 0x00069165 File Offset: 0x00067365
			public unsafe static LaunderingInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunderingInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E5 RID: 17125
			// (get) Token: 0x0600D7D4 RID: 55252 RVA: 0x00334A4C File Offset: 0x00332C4C
			// (set) Token: 0x0600D7D5 RID: 55253 RVA: 0x00069177 File Offset: 0x00067377
			public unsafe static Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform> __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009107 RID: 37127
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009108 RID: 37128
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x04009109 RID: 37129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400910A RID: 37130
			private static readonly IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0;
		}
	}
}
