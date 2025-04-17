using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063F RID: 1599
	public class HintDisplay : Singleton<HintDisplay>
	{
		// Token: 0x06008D5E RID: 36190 RVA: 0x0024D600 File Offset: 0x0024B800
		// Note: this type is marked as 'beforefieldinit'.
		static HintDisplay()
		{
			Il2CppClassPointerStore<HintDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HintDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr);
			HintDisplay.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FadeTime");
			HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<IsOpen>k__BackingField");
			HintDisplay.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Container");
			HintDisplay.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Label");
			HintDisplay.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Group");
			HintDisplay.NativeFieldInfoPtr_DismissPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "DismissPrompt");
			HintDisplay.NativeFieldInfoPtr_FlashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "FlashAnim");
			HintDisplay.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Padding");
			HintDisplay.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Offset");
			HintDisplay.NativeFieldInfoPtr_autoCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "autoCloseRoutine");
			HintDisplay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "fadeRoutine");
			HintDisplay.NativeFieldInfoPtr_hintQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "hintQueue");
			HintDisplay.NativeFieldInfoPtr_timeSinceOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "timeSinceOpened");
			HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680861);
			HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680862);
			HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680863);
			HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680864);
			HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680865);
			HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680866);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680867);
			HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680868);
			HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680869);
			HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680870);
			HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680871);
			HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680872);
			HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680873);
			HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680874);
			HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680875);
			HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, 100680876);
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x06008D5F RID: 36191 RVA: 0x0024D874 File Offset: 0x0024BA74
		// (set) Token: 0x06008D60 RID: 36192 RVA: 0x0024D8B0 File Offset: 0x0024BAB0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x0024D8F0 File Offset: 0x0024BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257773, XrefRangeEnd = 257780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HintDisplay.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x0024D92C File Offset: 0x0024BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257780, XrefRangeEnd = 257802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0024D960 File Offset: 0x0024BB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257802, XrefRangeEnd = 257803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_10s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x0024D9A4 File Offset: 0x0024BBA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 257804, RefRangeEnd = 257809, XrefRangeStart = 257803, XrefRangeEnd = 257804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_20s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D65 RID: 36197 RVA: 0x0024D9E8 File Offset: 0x0024BBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257809, XrefRangeEnd = 257810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0024DA2C File Offset: 0x0024BC2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 257832, RefRangeEnd = 257838, XrefRangeStart = 257810, XrefRangeEnd = 257832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint(string text, float autoCloseTime = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoCloseTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x0024DA7C File Offset: 0x0024BC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257838, XrefRangeEnd = 257839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x0024DAB0 File Offset: 0x0024BCB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 257855, RefRangeEnd = 257859, XrefRangeStart = 257839, XrefRangeEnd = 257855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D69 RID: 36201 RVA: 0x0024DAF0 File Offset: 0x0024BCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257859, XrefRangeEnd = 257870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_10s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x0024DB34 File Offset: 0x0024BD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257870, XrefRangeEnd = 257881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_20s(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x0024DB78 File Offset: 0x0024BD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257881, XrefRangeEnd = 257889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint(string message, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x0024DBC8 File Offset: 0x0024BDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257931, RefRangeEnd = 257932, XrefRangeStart = 257889, XrefRangeEnd = 257931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x0024DC10 File Offset: 0x0024BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257932, XrefRangeEnd = 257942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HintDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x0024DC4C File Offset: 0x0024BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257942, XrefRangeEnd = 257947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x00043D6B File Offset: 0x00041F6B
		public HintDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x0024DC98 File Offset: 0x0024BE98
		// (set) Token: 0x06008D71 RID: 36209 RVA: 0x00043D74 File Offset: 0x00041F74
		public unsafe static float FadeTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HintDisplay.NativeFieldInfoPtr_FadeTime, (void*)(&value));
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x06008D72 RID: 36210 RVA: 0x0024DCB4 File Offset: 0x0024BEB4
		// (set) Token: 0x06008D73 RID: 36211 RVA: 0x00043D82 File Offset: 0x00041F82
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x06008D74 RID: 36212 RVA: 0x0024DCDC File Offset: 0x0024BEDC
		// (set) Token: 0x06008D75 RID: 36213 RVA: 0x00043D9D File Offset: 0x00041F9D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x06008D76 RID: 36214 RVA: 0x0024DD0C File Offset: 0x0024BF0C
		// (set) Token: 0x06008D77 RID: 36215 RVA: 0x00043DBC File Offset: 0x00041FBC
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06008D78 RID: 36216 RVA: 0x0024DD3C File Offset: 0x0024BF3C
		// (set) Token: 0x06008D79 RID: 36217 RVA: 0x00043DDB File Offset: 0x00041FDB
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06008D7A RID: 36218 RVA: 0x0024DD6C File Offset: 0x0024BF6C
		// (set) Token: 0x06008D7B RID: 36219 RVA: 0x00043DFA File Offset: 0x00041FFA
		public unsafe InputPrompt DismissPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_DismissPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x0024DD9C File Offset: 0x0024BF9C
		// (set) Token: 0x06008D7D RID: 36221 RVA: 0x00043E19 File Offset: 0x00042019
		public unsafe Animation FlashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_FlashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x0024DDCC File Offset: 0x0024BFCC
		// (set) Token: 0x06008D7F RID: 36223 RVA: 0x00043E38 File Offset: 0x00042038
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x06008D80 RID: 36224 RVA: 0x0024DDF4 File Offset: 0x0024BFF4
		// (set) Token: 0x06008D81 RID: 36225 RVA: 0x00043E53 File Offset: 0x00042053
		public unsafe Vector2 Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x06008D82 RID: 36226 RVA: 0x0024DE1C File Offset: 0x0024C01C
		// (set) Token: 0x06008D83 RID: 36227 RVA: 0x00043E6E File Offset: 0x0004206E
		public unsafe Coroutine autoCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_autoCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x0024DE4C File Offset: 0x0024C04C
		// (set) Token: 0x06008D85 RID: 36229 RVA: 0x00043E8D File Offset: 0x0004208D
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x06008D86 RID: 36230 RVA: 0x0024DE7C File Offset: 0x0024C07C
		// (set) Token: 0x06008D87 RID: 36231 RVA: 0x00043EAC File Offset: 0x000420AC
		public unsafe List<HintDisplay.Hint> hintQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HintDisplay.Hint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_hintQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x06008D88 RID: 36232 RVA: 0x0024DEAC File Offset: 0x0024C0AC
		// (set) Token: 0x06008D89 RID: 36233 RVA: 0x00043ECB File Offset: 0x000420CB
		public unsafe float timeSinceOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.NativeFieldInfoPtr_timeSinceOpened)) = value;
			}
		}

		// Token: 0x04005FC5 RID: 24517
		private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

		// Token: 0x04005FC6 RID: 24518
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005FC7 RID: 24519
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005FC8 RID: 24520
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005FC9 RID: 24521
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005FCA RID: 24522
		private static readonly IntPtr NativeFieldInfoPtr_DismissPrompt;

		// Token: 0x04005FCB RID: 24523
		private static readonly IntPtr NativeFieldInfoPtr_FlashAnim;

		// Token: 0x04005FCC RID: 24524
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04005FCD RID: 24525
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04005FCE RID: 24526
		private static readonly IntPtr NativeFieldInfoPtr_autoCloseRoutine;

		// Token: 0x04005FCF RID: 24527
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04005FD0 RID: 24528
		private static readonly IntPtr NativeFieldInfoPtr_hintQueue;

		// Token: 0x04005FD1 RID: 24529
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceOpened;

		// Token: 0x04005FD2 RID: 24530
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005FD3 RID: 24531
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005FD4 RID: 24532
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005FD5 RID: 24533
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005FD6 RID: 24534
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0;

		// Token: 0x04005FD7 RID: 24535
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0;

		// Token: 0x04005FD8 RID: 24536
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_0;

		// Token: 0x04005FD9 RID: 24537
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Void_String_Single_0;

		// Token: 0x04005FDA RID: 24538
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04005FDB RID: 24539
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;

		// Token: 0x04005FDC RID: 24540
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0;

		// Token: 0x04005FDD RID: 24541
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0;

		// Token: 0x04005FDE RID: 24542
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_Public_Void_String_Single_0;

		// Token: 0x04005FDF RID: 24543
		private static readonly IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x04005FE0 RID: 24544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005FE1 RID: 24545
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000B24 RID: 2852
		public class Hint : Il2CppSystem.Object
		{
			// Token: 0x0600D782 RID: 55170 RVA: 0x00333C38 File Offset: 0x00331E38
			// Note: this type is marked as 'beforefieldinit'.
			static Hint()
			{
				Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "Hint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr);
				HintDisplay.Hint.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Text");
				HintDisplay.Hint.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, "Duration");
				HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr, 100680877);
			}

			// Token: 0x0600D783 RID: 55171 RVA: 0x00333CA0 File Offset: 0x00331EA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70198, RefRangeEnd = 70199, XrefRangeStart = 70198, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hint(string text, float duration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.Hint>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.Hint.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D784 RID: 55172 RVA: 0x00068ED4 File Offset: 0x000670D4
			public Hint(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CB RID: 17099
			// (get) Token: 0x0600D785 RID: 55173 RVA: 0x00333CFC File Offset: 0x00331EFC
			// (set) Token: 0x0600D786 RID: 55174 RVA: 0x00068EDD File Offset: 0x000670DD
			public unsafe string Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042CC RID: 17100
			// (get) Token: 0x0600D787 RID: 55175 RVA: 0x00333D24 File Offset: 0x00331F24
			// (set) Token: 0x0600D788 RID: 55176 RVA: 0x00068EFC File Offset: 0x000670FC
			public unsafe float Duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.Hint.NativeFieldInfoPtr_Duration)) = value;
				}
			}

			// Token: 0x040090DE RID: 37086
			private static readonly IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x040090DF RID: 37087
			private static readonly IntPtr NativeFieldInfoPtr_Duration;

			// Token: 0x040090E0 RID: 37088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x02000B25 RID: 2853
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<<ShowHint>g__AutoClose|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D789 RID: 55177 RVA: 0x00333D4C File Offset: 0x00331F4C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique()
			{
				Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<<ShowHint>g__AutoClose|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>1__state");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>2__current");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "time");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, "<>4__this");
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680878);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680879);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680880);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680881);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680882);
				HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr, 100680883);
			}

			// Token: 0x0600D78A RID: 55178 RVA: 0x00333E40 File Offset: 0x00332040
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78B RID: 55179 RVA: 0x00333E88 File Offset: 0x00332088
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78C RID: 55180 RVA: 0x00333EBC File Offset: 0x003320BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257730, XrefRangeEnd = 257735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042D1 RID: 17105
			// (get) Token: 0x0600D78D RID: 55181 RVA: 0x00333EF8 File Offset: 0x003320F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D78E RID: 55182 RVA: 0x00333F38 File Offset: 0x00332138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257735, XrefRangeEnd = 257740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042D2 RID: 17106
			// (get) Token: 0x0600D78F RID: 55183 RVA: 0x00333F6C File Offset: 0x0033216C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D790 RID: 55184 RVA: 0x00068F17 File Offset: 0x00067117
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042CD RID: 17101
			// (get) Token: 0x0600D791 RID: 55185 RVA: 0x00333FAC File Offset: 0x003321AC
			// (set) Token: 0x0600D792 RID: 55186 RVA: 0x00068F20 File Offset: 0x00067120
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042CE RID: 17102
			// (get) Token: 0x0600D793 RID: 55187 RVA: 0x00333FD4 File Offset: 0x003321D4
			// (set) Token: 0x0600D794 RID: 55188 RVA: 0x00068F3B File Offset: 0x0006713B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CF RID: 17103
			// (get) Token: 0x0600D795 RID: 55189 RVA: 0x00334004 File Offset: 0x00332204
			// (set) Token: 0x0600D796 RID: 55190 RVA: 0x00068F5A File Offset: 0x0006715A
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x170042D0 RID: 17104
			// (get) Token: 0x0600D797 RID: 55191 RVA: 0x0033402C File Offset: 0x0033222C
			// (set) Token: 0x0600D798 RID: 55192 RVA: 0x00068F75 File Offset: 0x00067175
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSitiHiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090E1 RID: 37089
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090E2 RID: 37090
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090E3 RID: 37091
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x040090E4 RID: 37092
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090E5 RID: 37093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090E6 RID: 37094
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090E7 RID: 37095
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090E8 RID: 37096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090E9 RID: 37097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090EA RID: 37098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B26 RID: 2854
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D799 RID: 55193 RVA: 0x0033405C File Offset: 0x0033225C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr);
				HintDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9");
				HintDisplay.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, "<>9__28_0");
				HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100680885);
				HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr, 100680886);
			}

			// Token: 0x0600D79A RID: 55194 RVA: 0x003340D8 File Offset: 0x003322D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D79B RID: 55195 RVA: 0x00334114 File Offset: 0x00332314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257740, XrefRangeEnd = 257753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ProcessText_b__28_0(Match match)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c.NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D79C RID: 55196 RVA: 0x00068F94 File Offset: 0x00067194
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D3 RID: 17107
			// (get) Token: 0x0600D79D RID: 55197 RVA: 0x0033415C File Offset: 0x0033235C
			// (set) Token: 0x0600D79E RID: 55198 RVA: 0x00068F9D File Offset: 0x0006719D
			public unsafe static HintDisplay.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D4 RID: 17108
			// (get) Token: 0x0600D79F RID: 55199 RVA: 0x00334184 File Offset: 0x00332384
			// (set) Token: 0x0600D7A0 RID: 55200 RVA: 0x00068FAF File Offset: 0x000671AF
			public unsafe static MatchEvaluator __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchEvaluator>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HintDisplay.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090EB RID: 37099
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090EC RID: 37100
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x040090ED RID: 37101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090EE RID: 37102
			private static readonly IntPtr NativeMethodInfoPtr__ProcessText_b__28_0_Internal_String_Match_0;
		}

		// Token: 0x02000B27 RID: 2855
		[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7A1 RID: 55201 RVA: 0x003341AC File Offset: 0x003323AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr);
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "alpha");
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100680887);
				HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, 100680888);
			}

			// Token: 0x0600D7A2 RID: 55202 RVA: 0x00334228 File Offset: 0x00332428
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7A3 RID: 55203 RVA: 0x00334264 File Offset: 0x00332464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257768, XrefRangeEnd = 257773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D7A4 RID: 55204 RVA: 0x00068FC1 File Offset: 0x000671C1
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D5 RID: 17109
			// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x003342A4 File Offset: 0x003324A4
			// (set) Token: 0x0600D7A6 RID: 55206 RVA: 0x00068FCA File Offset: 0x000671CA
			public unsafe HintDisplay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x003342D4 File Offset: 0x003324D4
			// (set) Token: 0x0600D7A8 RID: 55208 RVA: 0x00068FE9 File Offset: 0x000671E9
			public unsafe float alpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.NativeFieldInfoPtr_alpha)) = value;
				}
			}

			// Token: 0x040090EF RID: 37103
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090F0 RID: 37104
			private static readonly IntPtr NativeFieldInfoPtr_alpha;

			// Token: 0x040090F1 RID: 37105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090F2 RID: 37106
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C73 RID: 3187
			[ObfuscatedName("ScheduleOne.UI.HintDisplay+<>c__DisplayClass24_0+<<SetAlpha>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E559 RID: 58713 RVA: 0x0035BAFC File Offset: 0x00359CFC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0>.NativeClassPtr, "<<SetAlpha>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680889);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680890);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680891);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680892);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680893);
					HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680894);
				}

				// Token: 0x0600E55A RID: 58714 RVA: 0x0035BC04 File Offset: 0x00359E04
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E55B RID: 58715 RVA: 0x0035BC4C File Offset: 0x00359E4C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E55C RID: 58716 RVA: 0x0035BC80 File Offset: 0x00359E80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257753, XrefRangeEnd = 257763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004753 RID: 18259
				// (get) Token: 0x0600E55D RID: 58717 RVA: 0x0035BCBC File Offset: 0x00359EBC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E55E RID: 58718 RVA: 0x0035BCFC File Offset: 0x00359EFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257763, XrefRangeEnd = 257768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004754 RID: 18260
				// (get) Token: 0x0600E55F RID: 58719 RVA: 0x0035BD30 File Offset: 0x00359F30
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E560 RID: 58720 RVA: 0x0006FDBE File Offset: 0x0006DFBE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700474E RID: 18254
				// (get) Token: 0x0600E561 RID: 58721 RVA: 0x0035BD70 File Offset: 0x00359F70
				// (set) Token: 0x0600E562 RID: 58722 RVA: 0x0006FDC7 File Offset: 0x0006DFC7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700474F RID: 18255
				// (get) Token: 0x0600E563 RID: 58723 RVA: 0x0035BD98 File Offset: 0x00359F98
				// (set) Token: 0x0600E564 RID: 58724 RVA: 0x0006FDE2 File Offset: 0x0006DFE2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004750 RID: 18256
				// (get) Token: 0x0600E565 RID: 58725 RVA: 0x0035BDC8 File Offset: 0x00359FC8
				// (set) Token: 0x0600E566 RID: 58726 RVA: 0x0006FE01 File Offset: 0x0006E001
				public unsafe HintDisplay.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<HintDisplay.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004751 RID: 18257
				// (get) Token: 0x0600E567 RID: 58727 RVA: 0x0035BDF8 File Offset: 0x00359FF8
				// (set) Token: 0x0600E568 RID: 58728 RVA: 0x0006FE20 File Offset: 0x0006E020
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004752 RID: 18258
				// (get) Token: 0x0600E569 RID: 58729 RVA: 0x0035BE20 File Offset: 0x0035A020
				// (set) Token: 0x0600E56A RID: 58730 RVA: 0x0006FE3B File Offset: 0x0006E03B
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HintDisplay.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400995C RID: 39260
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400995D RID: 39261
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400995E RID: 39262
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400995F RID: 39263
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009960 RID: 39264
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009961 RID: 39265
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009962 RID: 39266
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009963 RID: 39267
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009964 RID: 39268
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009965 RID: 39269
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009966 RID: 39270
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
