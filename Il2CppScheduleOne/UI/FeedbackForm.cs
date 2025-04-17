using System;
using Il2CppAeLa.EasyFeedback;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000638 RID: 1592
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x06008CAA RID: 36010 RVA: 0x0024B450 File Offset: 0x00249650
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackForm()
		{
			Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackForm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr);
			FeedbackForm.NativeFieldInfoPtr_ssCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ssCoroutine");
			FeedbackForm.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CanvasGroup");
			FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "ScreenshotToggle");
			FeedbackForm.NativeFieldInfoPtr_SaveFileToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SaveFileToggle");
			FeedbackForm.NativeFieldInfoPtr_SummaryField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "SummaryField");
			FeedbackForm.NativeFieldInfoPtr_DescriptionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "DescriptionField");
			FeedbackForm.NativeFieldInfoPtr_Cog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "Cog");
			FeedbackForm.NativeFieldInfoPtr_CategoryDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "CategoryDropdown");
			FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680763);
			FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680764);
			FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680765);
			FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680766);
			FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680767);
			FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680768);
			FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680769);
			FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680770);
			FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680771);
			FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680772);
			FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680773);
			FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680774);
			FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680775);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680776);
			FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, 100680777);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x0024B64C File Offset: 0x0024984C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256816, XrefRangeEnd = 256843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x0024B688 File Offset: 0x00249888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256843, XrefRangeEnd = 256846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x0024B6BC File Offset: 0x002498BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256846, XrefRangeEnd = 256851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepScreenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_PrepScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x0024B6F0 File Offset: 0x002498F0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenshotToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x0024B730 File Offset: 0x00249930
		[CallerCount(0)]
		public unsafe void OnSaveFileToggle(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x0024B770 File Offset: 0x00249970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256851, XrefRangeEnd = 256865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFormData(string title)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetFormData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x0024B7B4 File Offset: 0x002499B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256865, XrefRangeEnd = 256877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategory(string categoryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_SetCategory_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x0024B7F8 File Offset: 0x002499F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256877, XrefRangeEnd = 257054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_Submit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x0024B834 File Offset: 0x00249A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257054, XrefRangeEnd = 257079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetTextToAppendToTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FeedbackForm.NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x0024B878 File Offset: 0x00249A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257079, XrefRangeEnd = 257085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x0024B8AC File Offset: 0x00249AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257085, XrefRangeEnd = 257090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator ScreenshotAndOpenForm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x0024B8EC File Offset: 0x00249AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257090, XrefRangeEnd = 257091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackForm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x0024B928 File Offset: 0x00249B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257091, XrefRangeEnd = 257096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x0024B968 File Offset: 0x00249B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257096, XrefRangeEnd = 257100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_0(Il2CppStructArray<byte> ss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ss);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x0024B9AC File Offset: 0x00249BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257100, XrefRangeEnd = 257104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScreenshotAndOpenForm_b__18_1(string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(err);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00043770 File Offset: 0x00041970
		public FeedbackForm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x0024B9F0 File Offset: 0x00249BF0
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x00043779 File Offset: 0x00041979
		public new unsafe Coroutine ssCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ssCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x0024BA20 File Offset: 0x00249C20
		// (set) Token: 0x06008CBE RID: 36030 RVA: 0x00043798 File Offset: 0x00041998
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x0024BA50 File Offset: 0x00249C50
		// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x000437B7 File Offset: 0x000419B7
		public unsafe Toggle ScreenshotToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_ScreenshotToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x0024BA80 File Offset: 0x00249C80
		// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x000437D6 File Offset: 0x000419D6
		public unsafe Toggle SaveFileToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SaveFileToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x0024BAB0 File Offset: 0x00249CB0
		// (set) Token: 0x06008CC4 RID: 36036 RVA: 0x000437F5 File Offset: 0x000419F5
		public unsafe TMP_InputField SummaryField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_SummaryField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x0024BAE0 File Offset: 0x00249CE0
		// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x00043814 File Offset: 0x00041A14
		public unsafe TMP_InputField DescriptionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_DescriptionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x0024BB10 File Offset: 0x00249D10
		// (set) Token: 0x06008CC8 RID: 36040 RVA: 0x00043833 File Offset: 0x00041A33
		public unsafe RectTransform Cog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_Cog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06008CC9 RID: 36041 RVA: 0x0024BB40 File Offset: 0x00249D40
		// (set) Token: 0x06008CCA RID: 36042 RVA: 0x00043852 File Offset: 0x00041A52
		public unsafe TMP_Dropdown CategoryDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.NativeFieldInfoPtr_CategoryDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F53 RID: 24403
		private static readonly IntPtr NativeFieldInfoPtr_ssCoroutine;

		// Token: 0x04005F54 RID: 24404
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04005F55 RID: 24405
		private static readonly IntPtr NativeFieldInfoPtr_ScreenshotToggle;

		// Token: 0x04005F56 RID: 24406
		private static readonly IntPtr NativeFieldInfoPtr_SaveFileToggle;

		// Token: 0x04005F57 RID: 24407
		private static readonly IntPtr NativeFieldInfoPtr_SummaryField;

		// Token: 0x04005F58 RID: 24408
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionField;

		// Token: 0x04005F59 RID: 24409
		private static readonly IntPtr NativeFieldInfoPtr_Cog;

		// Token: 0x04005F5A RID: 24410
		private static readonly IntPtr NativeFieldInfoPtr_CategoryDropdown;

		// Token: 0x04005F5B RID: 24411
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005F5C RID: 24412
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F5D RID: 24413
		private static readonly IntPtr NativeMethodInfoPtr_PrepScreenshot_Public_Void_0;

		// Token: 0x04005F5E RID: 24414
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenshotToggle_Private_Void_Boolean_0;

		// Token: 0x04005F5F RID: 24415
		private static readonly IntPtr NativeMethodInfoPtr_OnSaveFileToggle_Private_Void_Boolean_0;

		// Token: 0x04005F60 RID: 24416
		private static readonly IntPtr NativeMethodInfoPtr_SetFormData_Public_Void_String_0;

		// Token: 0x04005F61 RID: 24417
		private static readonly IntPtr NativeMethodInfoPtr_SetCategory_Public_Void_String_0;

		// Token: 0x04005F62 RID: 24418
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Virtual_Void_0;

		// Token: 0x04005F63 RID: 24419
		private static readonly IntPtr NativeMethodInfoPtr_GetTextToAppendToTitle_Protected_Virtual_String_0;

		// Token: 0x04005F64 RID: 24420
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04005F65 RID: 24421
		private static readonly IntPtr NativeMethodInfoPtr_ScreenshotAndOpenForm_Private_IEnumerator_0;

		// Token: 0x04005F66 RID: 24422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F67 RID: 24423
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005F68 RID: 24424
		private static readonly IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_0_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04005F69 RID: 24425
		private static readonly IntPtr NativeMethodInfoPtr__ScreenshotAndOpenForm_b__18_1_Private_Void_String_0;

		// Token: 0x02000B1D RID: 2845
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<<Submit>g__Wait|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D734 RID: 55092 RVA: 0x00332E70 File Offset: 0x00331070
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique()
			{
				Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<<Submit>g__Wait|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>1__state");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>2__current");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, "<>4__this");
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680778);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680779);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680780);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680781);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680782);
				FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr, 100680783);
			}

			// Token: 0x0600D735 RID: 55093 RVA: 0x00332F50 File Offset: 0x00331150
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D736 RID: 55094 RVA: 0x00332F98 File Offset: 0x00331198
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D737 RID: 55095 RVA: 0x00332FCC File Offset: 0x003311CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256786, XrefRangeEnd = 256792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042B3 RID: 17075
			// (get) Token: 0x0600D738 RID: 55096 RVA: 0x00333008 File Offset: 0x00331208
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D739 RID: 55097 RVA: 0x00333048 File Offset: 0x00331248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256792, XrefRangeEnd = 256797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042B4 RID: 17076
			// (get) Token: 0x0600D73A RID: 55098 RVA: 0x0033307C File Offset: 0x0033127C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D73B RID: 55099 RVA: 0x00068C43 File Offset: 0x00066E43
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B0 RID: 17072
			// (get) Token: 0x0600D73C RID: 55100 RVA: 0x003330BC File Offset: 0x003312BC
			// (set) Token: 0x0600D73D RID: 55101 RVA: 0x00068C4C File Offset: 0x00066E4C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042B1 RID: 17073
			// (get) Token: 0x0600D73E RID: 55102 RVA: 0x003330E4 File Offset: 0x003312E4
			// (set) Token: 0x0600D73F RID: 55103 RVA: 0x00068C67 File Offset: 0x00066E67
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B2 RID: 17074
			// (get) Token: 0x0600D740 RID: 55104 RVA: 0x00333114 File Offset: 0x00331314
			// (set) Token: 0x0600D741 RID: 55105 RVA: 0x00068C86 File Offset: 0x00066E86
			public unsafe FeedbackForm __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090AE RID: 37038
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090AF RID: 37039
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090B0 RID: 37040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090B1 RID: 37041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090B2 RID: 37042
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090B3 RID: 37043
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090B4 RID: 37044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090B5 RID: 37045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090B6 RID: 37046
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1E RID: 2846
		[ObfuscatedName("ScheduleOne.UI.FeedbackForm+<ScreenshotAndOpenForm>d__18")]
		public sealed class _ScreenshotAndOpenForm_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D742 RID: 55106 RVA: 0x00333144 File Offset: 0x00331344
			// Note: this type is marked as 'beforefieldinit'.
			static _ScreenshotAndOpenForm_d__18()
			{
				Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FeedbackForm>.NativeClassPtr, "<ScreenshotAndOpenForm>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>1__state");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>2__current");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, "<>4__this");
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680784);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680785);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680786);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680787);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680788);
				FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr, 100680789);
			}

			// Token: 0x0600D743 RID: 55107 RVA: 0x00333224 File Offset: 0x00331424
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ScreenshotAndOpenForm_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackForm._ScreenshotAndOpenForm_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D744 RID: 55108 RVA: 0x0033326C File Offset: 0x0033146C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x003332A0 File Offset: 0x003314A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256797, XrefRangeEnd = 256811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042B8 RID: 17080
			// (get) Token: 0x0600D746 RID: 55110 RVA: 0x003332DC File Offset: 0x003314DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x0033331C File Offset: 0x0033151C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256811, XrefRangeEnd = 256816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042B9 RID: 17081
			// (get) Token: 0x0600D748 RID: 55112 RVA: 0x00333350 File Offset: 0x00331550
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D749 RID: 55113 RVA: 0x00068CA5 File Offset: 0x00066EA5
			public _ScreenshotAndOpenForm_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0600D74A RID: 55114 RVA: 0x00333390 File Offset: 0x00331590
			// (set) Token: 0x0600D74B RID: 55115 RVA: 0x00068CAE File Offset: 0x00066EAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0600D74C RID: 55116 RVA: 0x003333B8 File Offset: 0x003315B8
			// (set) Token: 0x0600D74D RID: 55117 RVA: 0x00068CC9 File Offset: 0x00066EC9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B7 RID: 17079
			// (get) Token: 0x0600D74E RID: 55118 RVA: 0x003333E8 File Offset: 0x003315E8
			// (set) Token: 0x0600D74F RID: 55119 RVA: 0x00068CE8 File Offset: 0x00066EE8
			public unsafe FeedbackForm __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackForm._ScreenshotAndOpenForm_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090B7 RID: 37047
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090B8 RID: 37048
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090B9 RID: 37049
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090BA RID: 37050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090BB RID: 37051
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090BC RID: 37052
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090BD RID: 37053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090BE RID: 37054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090BF RID: 37055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
