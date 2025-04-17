using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006AE RID: 1710
	public class DealWindowSelector : MonoBehaviour
	{
		// Token: 0x060099AA RID: 39338 RVA: 0x002720C4 File Offset: 0x002702C4
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowSelector()
		{
			Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealWindowSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr);
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_0000");
			DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "TIME_ARM_ROTATION_2400");
			DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "WINDOW_CUTOFF_MINS");
			DealWindowSelector.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "OnSelected");
			DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			DealWindowSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "Container");
			DealWindowSelector.NativeFieldInfoPtr_MorningButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "MorningButton");
			DealWindowSelector.NativeFieldInfoPtr_AfternoonButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "AfternoonButton");
			DealWindowSelector.NativeFieldInfoPtr_NightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "NightButton");
			DealWindowSelector.NativeFieldInfoPtr_LateNightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "LateNightButton");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeArm");
			DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "CurrentTimeLabel");
			DealWindowSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "callback");
			DealWindowSelector.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "buttons");
			DealWindowSelector.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "hintShown");
			DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682244);
			DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682245);
			DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682246);
			DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682247);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682248);
			DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682249);
			DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682250);
			DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682251);
			DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682252);
			DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682253);
			DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682254);
			DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, 100682255);
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x060099AB RID: 39339 RVA: 0x00272310 File Offset: 0x00270510
		// (set) Token: 0x060099AC RID: 39340 RVA: 0x0027234C File Offset: 0x0027054C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x0027238C File Offset: 0x0027058C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273883, XrefRangeEnd = 273920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x002723C0 File Offset: 0x002705C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273920, XrefRangeEnd = 273921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x00272404 File Offset: 0x00270604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273921, XrefRangeEnd = 273922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x00272444 File Offset: 0x00270644
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 273967, RefRangeEnd = 273974, XrefRangeStart = 273922, XrefRangeEnd = 273967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open, MSGConversation conversation, Action<EDealWindow> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x002724A8 File Offset: 0x002706A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273974, XrefRangeEnd = 273976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x002724DC File Offset: 0x002706DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273987, RefRangeEnd = 273989, XrefRangeStart = 273976, XrefRangeEnd = 273987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00272510 File Offset: 0x00270710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274016, RefRangeEnd = 274018, XrefRangeStart = 273989, XrefRangeEnd = 274016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWindowValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x00272544 File Offset: 0x00270744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274018, XrefRangeEnd = 274019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x00272578 File Offset: 0x00270778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274019, XrefRangeEnd = 274023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonClicked(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x002725B8 File Offset: 0x002707B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x0004AFA7 File Offset: 0x000491A7
		public DealWindowSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x002725F4 File Offset: 0x002707F4
		// (set) Token: 0x060099B9 RID: 39353 RVA: 0x0004AFB0 File Offset: 0x000491B0
		public unsafe static float TIME_ARM_ROTATION_0000
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_0000, (void*)(&value));
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x00272610 File Offset: 0x00270810
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x0004AFBE File Offset: 0x000491BE
		public unsafe static float TIME_ARM_ROTATION_2400
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_TIME_ARM_ROTATION_2400, (void*)(&value));
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x0027262C File Offset: 0x0027082C
		// (set) Token: 0x060099BD RID: 39357 RVA: 0x0004AFCC File Offset: 0x000491CC
		public unsafe static int WINDOW_CUTOFF_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowSelector.NativeFieldInfoPtr_WINDOW_CUTOFF_MINS, (void*)(&value));
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00272648 File Offset: 0x00270848
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x0004AFDA File Offset: 0x000491DA
		public unsafe UnityEvent<EDealWindow> OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x00272678 File Offset: 0x00270878
		// (set) Token: 0x060099C1 RID: 39361 RVA: 0x0004AFF9 File Offset: 0x000491F9
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x002726A0 File Offset: 0x002708A0
		// (set) Token: 0x060099C3 RID: 39363 RVA: 0x0004B014 File Offset: 0x00049214
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x060099C4 RID: 39364 RVA: 0x002726D0 File Offset: 0x002708D0
		// (set) Token: 0x060099C5 RID: 39365 RVA: 0x0004B033 File Offset: 0x00049233
		public unsafe WindowSelectorButton MorningButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_MorningButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00272700 File Offset: 0x00270900
		// (set) Token: 0x060099C7 RID: 39367 RVA: 0x0004B052 File Offset: 0x00049252
		public unsafe WindowSelectorButton AfternoonButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_AfternoonButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00272730 File Offset: 0x00270930
		// (set) Token: 0x060099C9 RID: 39369 RVA: 0x0004B071 File Offset: 0x00049271
		public unsafe WindowSelectorButton NightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_NightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x060099CA RID: 39370 RVA: 0x00272760 File Offset: 0x00270960
		// (set) Token: 0x060099CB RID: 39371 RVA: 0x0004B090 File Offset: 0x00049290
		public unsafe WindowSelectorButton LateNightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_LateNightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x060099CC RID: 39372 RVA: 0x00272790 File Offset: 0x00270990
		// (set) Token: 0x060099CD RID: 39373 RVA: 0x0004B0AF File Offset: 0x000492AF
		public unsafe RectTransform CurrentTimeArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x060099CE RID: 39374 RVA: 0x002727C0 File Offset: 0x002709C0
		// (set) Token: 0x060099CF RID: 39375 RVA: 0x0004B0CE File Offset: 0x000492CE
		public unsafe Text CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x002727F0 File Offset: 0x002709F0
		// (set) Token: 0x060099D1 RID: 39377 RVA: 0x0004B0ED File Offset: 0x000492ED
		public unsafe Action<EDealWindow> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EDealWindow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x060099D2 RID: 39378 RVA: 0x00272820 File Offset: 0x00270A20
		// (set) Token: 0x060099D3 RID: 39379 RVA: 0x0004B10C File Offset: 0x0004930C
		public unsafe Il2CppReferenceArray<WindowSelectorButton> buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WindowSelectorButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x060099D4 RID: 39380 RVA: 0x00272850 File Offset: 0x00270A50
		// (set) Token: 0x060099D5 RID: 39381 RVA: 0x0004B12B File Offset: 0x0004932B
		public unsafe bool hintShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.NativeFieldInfoPtr_hintShown)) = value;
			}
		}

		// Token: 0x04006771 RID: 26481
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_0000;

		// Token: 0x04006772 RID: 26482
		private static readonly IntPtr NativeFieldInfoPtr_TIME_ARM_ROTATION_2400;

		// Token: 0x04006773 RID: 26483
		private static readonly IntPtr NativeFieldInfoPtr_WINDOW_CUTOFF_MINS;

		// Token: 0x04006774 RID: 26484
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x04006775 RID: 26485
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006776 RID: 26486
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006777 RID: 26487
		private static readonly IntPtr NativeFieldInfoPtr_MorningButton;

		// Token: 0x04006778 RID: 26488
		private static readonly IntPtr NativeFieldInfoPtr_AfternoonButton;

		// Token: 0x04006779 RID: 26489
		private static readonly IntPtr NativeFieldInfoPtr_NightButton;

		// Token: 0x0400677A RID: 26490
		private static readonly IntPtr NativeFieldInfoPtr_LateNightButton;

		// Token: 0x0400677B RID: 26491
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeArm;

		// Token: 0x0400677C RID: 26492
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x0400677D RID: 26493
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400677E RID: 26494
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400677F RID: 26495
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04006780 RID: 26496
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006781 RID: 26497
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006782 RID: 26498
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006783 RID: 26499
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006784 RID: 26500
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006785 RID: 26501
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_MSGConversation_Action_1_EDealWindow_0;

		// Token: 0x04006786 RID: 26502
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006787 RID: 26503
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Private_Void_0;

		// Token: 0x04006788 RID: 26504
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWindowValidity_Private_Void_0;

		// Token: 0x04006789 RID: 26505
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x0400678A RID: 26506
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_EDealWindow_0;

		// Token: 0x0400678B RID: 26507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7A RID: 2938
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealWindowSelector+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB48 RID: 56136 RVA: 0x0033EAF4 File Offset: 0x0033CCF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealWindowSelector>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr);
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "button");
				DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682256);
				DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr, 100682257);
			}

			// Token: 0x0600DB49 RID: 56137 RVA: 0x0033EB70 File Offset: 0x0033CD70
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealWindowSelector.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB4A RID: 56138 RVA: 0x0033EBAC File Offset: 0x0033CDAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273879, XrefRangeEnd = 273883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowSelector.__c__DisplayClass18_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB4B RID: 56139 RVA: 0x0006ACD3 File Offset: 0x00068ED3
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004403 RID: 17411
			// (get) Token: 0x0600DB4C RID: 56140 RVA: 0x0033EBE0 File Offset: 0x0033CDE0
			// (set) Token: 0x0600DB4D RID: 56141 RVA: 0x0006ACDC File Offset: 0x00068EDC
			public unsafe WindowSelectorButton button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004404 RID: 17412
			// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x0033EC10 File Offset: 0x0033CE10
			// (set) Token: 0x0600DB4F RID: 56143 RVA: 0x0006ACFB File Offset: 0x00068EFB
			public unsafe DealWindowSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealWindowSelector.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009315 RID: 37653
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04009316 RID: 37654
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009317 RID: 37655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009318 RID: 37656
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
