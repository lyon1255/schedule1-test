using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065C RID: 1628
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x06009147 RID: 37191 RVA: 0x00258A68 File Offset: 0x00256C68
		// Note: this type is marked as 'beforefieldinit'.
		static SleepCanvas()
		{
			Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SleepCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr);
			SleepCanvas.NativeFieldInfoPtr_MaxSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MaxSleepTime");
			SleepCanvas.NativeFieldInfoPtr_MinSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MinSleepTime");
			SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<IsMenuOpen>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<QueuedSleepMessage>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "QueuedMessageDisplayTime");
			SleepCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Canvas");
			SleepCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Container");
			SleepCanvas.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MenuContainer");
			SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "CurrentTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "IncreaseButton");
			SleepCanvas.NativeFieldInfoPtr_DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "DecreaseButton");
			SleepCanvas.NativeFieldInfoPtr_EndTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "EndTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButton");
			SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButtonLabel");
			SleepCanvas.NativeFieldInfoPtr_BlackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "BlackOverlay");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageGroup");
			SleepCanvas.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "TimeLabel");
			SleepCanvas.NativeFieldInfoPtr_WakeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WakeLabel");
			SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WaitingForHostLabel");
			SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepFullyFaded");
			SleepCanvas.NativeFieldInfoPtr_onSleepEndFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepEndFade");
			SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "queuedPostSleepEvents");
			SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681292);
			SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681293);
			SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681294);
			SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681295);
			SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681296);
			SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681297);
			SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681298);
			SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681299);
			SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681300);
			SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681301);
			SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681302);
			SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681303);
			SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681304);
			SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681305);
			SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681306);
			SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681307);
			SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681308);
			SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681309);
			SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681310);
			SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681311);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681312);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681313);
			SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681314);
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x00258E30 File Offset: 0x00257030
		// (set) Token: 0x06009149 RID: 37193 RVA: 0x00258E6C File Offset: 0x0025706C
		public unsafe bool IsMenuOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600914A RID: 37194 RVA: 0x00258EAC File Offset: 0x002570AC
		// (set) Token: 0x0600914B RID: 37195 RVA: 0x00258EE4 File Offset: 0x002570E4
		public unsafe string QueuedSleepMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x00258F28 File Offset: 0x00257128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262840, XrefRangeEnd = 262893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x00258F64 File Offset: 0x00257164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262893, XrefRangeEnd = 262894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x00258FA8 File Offset: 0x002571A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262974, RefRangeEnd = 262977, XrefRangeStart = 262894, XrefRangeEnd = 262974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x00258FE8 File Offset: 0x002571E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262996, RefRangeEnd = 262997, XrefRangeStart = 262977, XrefRangeEnd = 262996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x0025901C File Offset: 0x0025721C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263011, RefRangeEnd = 263013, XrefRangeStart = 262997, XrefRangeEnd = 263011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(postSleepEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009151 RID: 37201 RVA: 0x00259060 File Offset: 0x00257260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263013, XrefRangeEnd = 263016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHourSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009152 RID: 37202 RVA: 0x00259094 File Offset: 0x00257294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263016, XrefRangeEnd = 263018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x002590C8 File Offset: 0x002572C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263018, XrefRangeEnd = 263028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSleepButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x002590FC File Offset: 0x002572FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263039, RefRangeEnd = 263041, XrefRangeStart = 263028, XrefRangeEnd = 263039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSleepAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x0025913C File Offset: 0x0025733C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263050, RefRangeEnd = 263052, XrefRangeStart = 263041, XrefRangeEnd = 263050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampWakeTime(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x00259188 File Offset: 0x00257388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263052, XrefRangeEnd = 263054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampTime(int time, int startTime, int endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x002591F0 File Offset: 0x002573F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263054, XrefRangeEnd = 263061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x00259224 File Offset: 0x00257424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263061, XrefRangeEnd = 263079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x00259258 File Offset: 0x00257458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263092, RefRangeEnd = 263094, XrefRangeStart = 263079, XrefRangeEnd = 263092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpBlackOverlay(float transparency, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref transparency;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x002592A4 File Offset: 0x002574A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263115, RefRangeEnd = 263118, XrefRangeStart = 263094, XrefRangeEnd = 263115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSleepMessage(string message, float displayTime = 3f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x002592F4 File Offset: 0x002574F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263118, XrefRangeEnd = 263131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SleepCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x00259330 File Offset: 0x00257530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263131, XrefRangeEnd = 263132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00259364 File Offset: 0x00257564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263132, XrefRangeEnd = 263133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x00259398 File Offset: 0x00257598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263133, XrefRangeEnd = 263138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x0004639C File Offset: 0x0004459C
		public SleepCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x002593D8 File Offset: 0x002575D8
		// (set) Token: 0x06009161 RID: 37217 RVA: 0x000463A5 File Offset: 0x000445A5
		public unsafe static int MaxSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x002593F4 File Offset: 0x002575F4
		// (set) Token: 0x06009163 RID: 37219 RVA: 0x000463B3 File Offset: 0x000445B3
		public unsafe static int MinSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x00259410 File Offset: 0x00257610
		// (set) Token: 0x06009165 RID: 37221 RVA: 0x000463C1 File Offset: 0x000445C1
		public unsafe bool _IsMenuOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x06009166 RID: 37222 RVA: 0x00259438 File Offset: 0x00257638
		// (set) Token: 0x06009167 RID: 37223 RVA: 0x000463DC File Offset: 0x000445DC
		public unsafe string _QueuedSleepMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x06009168 RID: 37224 RVA: 0x00259460 File Offset: 0x00257660
		// (set) Token: 0x06009169 RID: 37225 RVA: 0x000463FB File Offset: 0x000445FB
		public unsafe float QueuedMessageDisplayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime)) = value;
			}
		}

		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x00259488 File Offset: 0x00257688
		// (set) Token: 0x0600916B RID: 37227 RVA: 0x00046416 File Offset: 0x00044616
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x002594B8 File Offset: 0x002576B8
		// (set) Token: 0x0600916D RID: 37229 RVA: 0x00046435 File Offset: 0x00044635
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x0600916E RID: 37230 RVA: 0x002594E8 File Offset: 0x002576E8
		// (set) Token: 0x0600916F RID: 37231 RVA: 0x00046454 File Offset: 0x00044654
		public unsafe RectTransform MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x06009170 RID: 37232 RVA: 0x00259518 File Offset: 0x00257718
		// (set) Token: 0x06009171 RID: 37233 RVA: 0x00046473 File Offset: 0x00044673
		public unsafe TextMeshProUGUI CurrentTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x06009172 RID: 37234 RVA: 0x00259548 File Offset: 0x00257748
		// (set) Token: 0x06009173 RID: 37235 RVA: 0x00046492 File Offset: 0x00044692
		public unsafe Button IncreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x00259578 File Offset: 0x00257778
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x000464B1 File Offset: 0x000446B1
		public unsafe Button DecreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x002595A8 File Offset: 0x002577A8
		// (set) Token: 0x06009177 RID: 37239 RVA: 0x000464D0 File Offset: 0x000446D0
		public unsafe TextMeshProUGUI EndTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x002595D8 File Offset: 0x002577D8
		// (set) Token: 0x06009179 RID: 37241 RVA: 0x000464EF File Offset: 0x000446EF
		public unsafe Button SleepButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x00259608 File Offset: 0x00257808
		// (set) Token: 0x0600917B RID: 37243 RVA: 0x0004650E File Offset: 0x0004470E
		public unsafe TextMeshProUGUI SleepButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x00259638 File Offset: 0x00257838
		// (set) Token: 0x0600917D RID: 37245 RVA: 0x0004652D File Offset: 0x0004472D
		public unsafe Image BlackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x0600917E RID: 37246 RVA: 0x00259668 File Offset: 0x00257868
		// (set) Token: 0x0600917F RID: 37247 RVA: 0x0004654C File Offset: 0x0004474C
		public unsafe TextMeshProUGUI SleepMessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x06009180 RID: 37248 RVA: 0x00259698 File Offset: 0x00257898
		// (set) Token: 0x06009181 RID: 37249 RVA: 0x0004656B File Offset: 0x0004476B
		public unsafe CanvasGroup SleepMessageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x002596C8 File Offset: 0x002578C8
		// (set) Token: 0x06009183 RID: 37251 RVA: 0x0004658A File Offset: 0x0004478A
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x06009184 RID: 37252 RVA: 0x002596F8 File Offset: 0x002578F8
		// (set) Token: 0x06009185 RID: 37253 RVA: 0x000465A9 File Offset: 0x000447A9
		public unsafe TextMeshProUGUI WakeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x00259728 File Offset: 0x00257928
		// (set) Token: 0x06009187 RID: 37255 RVA: 0x000465C8 File Offset: 0x000447C8
		public unsafe TextMeshProUGUI WaitingForHostLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x06009188 RID: 37256 RVA: 0x00259758 File Offset: 0x00257958
		// (set) Token: 0x06009189 RID: 37257 RVA: 0x000465E7 File Offset: 0x000447E7
		public unsafe UnityEvent onSleepFullyFaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00259788 File Offset: 0x00257988
		// (set) Token: 0x0600918B RID: 37259 RVA: 0x00046606 File Offset: 0x00044806
		public unsafe UnityEvent onSleepEndFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x002597B8 File Offset: 0x002579B8
		// (set) Token: 0x0600918D RID: 37261 RVA: 0x00046625 File Offset: 0x00044825
		public unsafe List<IPostSleepEvent> queuedPostSleepEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPostSleepEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400622F RID: 25135
		private static readonly IntPtr NativeFieldInfoPtr_MaxSleepTime;

		// Token: 0x04006230 RID: 25136
		private static readonly IntPtr NativeFieldInfoPtr_MinSleepTime;

		// Token: 0x04006231 RID: 25137
		private static readonly IntPtr NativeFieldInfoPtr__IsMenuOpen_k__BackingField;

		// Token: 0x04006232 RID: 25138
		private static readonly IntPtr NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField;

		// Token: 0x04006233 RID: 25139
		private static readonly IntPtr NativeFieldInfoPtr_QueuedMessageDisplayTime;

		// Token: 0x04006234 RID: 25140
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006235 RID: 25141
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006236 RID: 25142
		private static readonly IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x04006237 RID: 25143
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x04006238 RID: 25144
		private static readonly IntPtr NativeFieldInfoPtr_IncreaseButton;

		// Token: 0x04006239 RID: 25145
		private static readonly IntPtr NativeFieldInfoPtr_DecreaseButton;

		// Token: 0x0400623A RID: 25146
		private static readonly IntPtr NativeFieldInfoPtr_EndTimeLabel;

		// Token: 0x0400623B RID: 25147
		private static readonly IntPtr NativeFieldInfoPtr_SleepButton;

		// Token: 0x0400623C RID: 25148
		private static readonly IntPtr NativeFieldInfoPtr_SleepButtonLabel;

		// Token: 0x0400623D RID: 25149
		private static readonly IntPtr NativeFieldInfoPtr_BlackOverlay;

		// Token: 0x0400623E RID: 25150
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageLabel;

		// Token: 0x0400623F RID: 25151
		private static readonly IntPtr NativeFieldInfoPtr_SleepMessageGroup;

		// Token: 0x04006240 RID: 25152
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x04006241 RID: 25153
		private static readonly IntPtr NativeFieldInfoPtr_WakeLabel;

		// Token: 0x04006242 RID: 25154
		private static readonly IntPtr NativeFieldInfoPtr_WaitingForHostLabel;

		// Token: 0x04006243 RID: 25155
		private static readonly IntPtr NativeFieldInfoPtr_onSleepFullyFaded;

		// Token: 0x04006244 RID: 25156
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEndFade;

		// Token: 0x04006245 RID: 25157
		private static readonly IntPtr NativeFieldInfoPtr_queuedPostSleepEvents;

		// Token: 0x04006246 RID: 25158
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0;

		// Token: 0x04006247 RID: 25159
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006248 RID: 25160
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0;

		// Token: 0x04006249 RID: 25161
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0;

		// Token: 0x0400624A RID: 25162
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400624B RID: 25163
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400624C RID: 25164
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400624D RID: 25165
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400624E RID: 25166
		private static readonly IntPtr NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0;

		// Token: 0x0400624F RID: 25167
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0;

		// Token: 0x04006250 RID: 25168
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0;

		// Token: 0x04006251 RID: 25169
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0;

		// Token: 0x04006252 RID: 25170
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0;

		// Token: 0x04006253 RID: 25171
		private static readonly IntPtr NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0;

		// Token: 0x04006254 RID: 25172
		private static readonly IntPtr NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x04006255 RID: 25173
		private static readonly IntPtr NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0;

		// Token: 0x04006256 RID: 25174
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04006257 RID: 25175
		private static readonly IntPtr NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0;

		// Token: 0x04006258 RID: 25176
		private static readonly IntPtr NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0;

		// Token: 0x04006259 RID: 25177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400625A RID: 25178
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0;

		// Token: 0x0400625B RID: 25179
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0;

		// Token: 0x0400625C RID: 25180
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B42 RID: 2882
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<<SleepStart>g__Sleep|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D8EA RID: 55530 RVA: 0x00337C4C File Offset: 0x00335E4C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique()
			{
				Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<<SleepStart>g__Sleep|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>1__state");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>2__current");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>4__this");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>8__1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>7__wrap1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<i>5__4");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681315);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681316);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681317);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681318);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681319);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681320);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681321);
			}

			// Token: 0x0600D8EB RID: 55531 RVA: 0x00337D90 File Offset: 0x00335F90
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8EC RID: 55532 RVA: 0x00337DD8 File Offset: 0x00335FD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262561, RefRangeEnd = 262562, XrefRangeStart = 262556, XrefRangeEnd = 262561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D8ED RID: 55533 RVA: 0x00337E0C File Offset: 0x0033600C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262562, XrefRangeEnd = 262793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D8EE RID: 55534 RVA: 0x00337E48 File Offset: 0x00336048
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262796, RefRangeEnd = 262797, XrefRangeStart = 262793, XrefRangeEnd = 262796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600D8EF RID: 55535 RVA: 0x00337E7C File Offset: 0x0033607C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8F0 RID: 55536 RVA: 0x00337EBC File Offset: 0x003360BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262797, XrefRangeEnd = 262802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600D8F1 RID: 55537 RVA: 0x00337EF0 File Offset: 0x003360F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D8F2 RID: 55538 RVA: 0x00069AA9 File Offset: 0x00067CA9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434C RID: 17228
			// (get) Token: 0x0600D8F3 RID: 55539 RVA: 0x00337F30 File Offset: 0x00336130
			// (set) Token: 0x0600D8F4 RID: 55540 RVA: 0x00069AB2 File Offset: 0x00067CB2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700434D RID: 17229
			// (get) Token: 0x0600D8F5 RID: 55541 RVA: 0x00337F58 File Offset: 0x00336158
			// (set) Token: 0x0600D8F6 RID: 55542 RVA: 0x00069ACD File Offset: 0x00067CCD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434E RID: 17230
			// (get) Token: 0x0600D8F7 RID: 55543 RVA: 0x00337F88 File Offset: 0x00336188
			// (set) Token: 0x0600D8F8 RID: 55544 RVA: 0x00069AEC File Offset: 0x00067CEC
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434F RID: 17231
			// (get) Token: 0x0600D8F9 RID: 55545 RVA: 0x00337FB8 File Offset: 0x003361B8
			// (set) Token: 0x0600D8FA RID: 55546 RVA: 0x00069B0B File Offset: 0x00067D0B
			public unsafe SleepCanvas.__c__DisplayClass41_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004350 RID: 17232
			// (get) Token: 0x0600D8FB RID: 55547 RVA: 0x00337FE8 File Offset: 0x003361E8
			// (set) Token: 0x0600D8FC RID: 55548 RVA: 0x00069B2A File Offset: 0x00067D2A
			public List<IPostSleepEvent>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1);
					return new List<IPostSleepEvent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0600D8FD RID: 55549 RVA: 0x00338018 File Offset: 0x00336218
			// (set) Token: 0x0600D8FE RID: 55550 RVA: 0x00069B58 File Offset: 0x00067D58
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600D8FF RID: 55551 RVA: 0x00338040 File Offset: 0x00336240
			// (set) Token: 0x0600D900 RID: 55552 RVA: 0x00069B73 File Offset: 0x00067D73
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040091BE RID: 37310
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091BF RID: 37311
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091C0 RID: 37312
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091C1 RID: 37313
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040091C2 RID: 37314
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040091C3 RID: 37315
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x040091C4 RID: 37316
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040091C5 RID: 37317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040091C6 RID: 37318
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091C7 RID: 37319
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040091C8 RID: 37320
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040091C9 RID: 37321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040091CA RID: 37322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091CB RID: 37323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B43 RID: 2883
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D901 RID: 55553 RVA: 0x00338068 File Offset: 0x00336268
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr);
				SleepCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_1");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_2");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_3");
				SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681323);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681324);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681325);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681326);
			}

			// Token: 0x0600D902 RID: 55554 RVA: 0x00338134 File Offset: 0x00336334
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D903 RID: 55555 RVA: 0x00338170 File Offset: 0x00336370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262802, XrefRangeEnd = 262806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D904 RID: 55556 RVA: 0x003381AC File Offset: 0x003363AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262806, XrefRangeEnd = 262810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SleepStart_b__41_2(IPostSleepEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D905 RID: 55557 RVA: 0x003381FC File Offset: 0x003363FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262810, XrefRangeEnd = 262814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D906 RID: 55558 RVA: 0x00069B8E File Offset: 0x00067D8E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600D907 RID: 55559 RVA: 0x00338238 File Offset: 0x00336438
			// (set) Token: 0x0600D908 RID: 55560 RVA: 0x00069B97 File Offset: 0x00067D97
			public unsafe static SleepCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600D909 RID: 55561 RVA: 0x00338260 File Offset: 0x00336460
			// (set) Token: 0x0600D90A RID: 55562 RVA: 0x00069BA9 File Offset: 0x00067DA9
			public unsafe static Func<bool> __9__41_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600D90B RID: 55563 RVA: 0x00338288 File Offset: 0x00336488
			// (set) Token: 0x0600D90C RID: 55564 RVA: 0x00069BBB File Offset: 0x00067DBB
			public unsafe static Func<IPostSleepEvent, int> __9__41_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPostSleepEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600D90D RID: 55565 RVA: 0x003382B0 File Offset: 0x003364B0
			// (set) Token: 0x0600D90E RID: 55566 RVA: 0x00069BCD File Offset: 0x00067DCD
			public unsafe static Func<bool> __9__41_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091CC RID: 37324
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091CD RID: 37325
			private static readonly IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x040091CE RID: 37326
			private static readonly IntPtr NativeFieldInfoPtr___9__41_2;

			// Token: 0x040091CF RID: 37327
			private static readonly IntPtr NativeFieldInfoPtr___9__41_3;

			// Token: 0x040091D0 RID: 37328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D1 RID: 37329
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0;

			// Token: 0x040091D2 RID: 37330
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0;

			// Token: 0x040091D3 RID: 37331
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0;
		}

		// Token: 0x02000B44 RID: 2884
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D90F RID: 55567 RVA: 0x003382D8 File Offset: 0x003364D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, "pse");
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681327);
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681328);
			}

			// Token: 0x0600D910 RID: 55568 RVA: 0x00338340 File Offset: 0x00336540
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D911 RID: 55569 RVA: 0x0033837C File Offset: 0x0033657C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262814, XrefRangeEnd = 262817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D912 RID: 55570 RVA: 0x00069BDF File Offset: 0x00067DDF
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600D913 RID: 55571 RVA: 0x003383B8 File Offset: 0x003365B8
			// (set) Token: 0x0600D914 RID: 55572 RVA: 0x00069BE8 File Offset: 0x00067DE8
			public unsafe IPostSleepEvent pse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPostSleepEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091D4 RID: 37332
			private static readonly IntPtr NativeFieldInfoPtr_pse;

			// Token: 0x040091D5 RID: 37333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D6 RID: 37334
			private static readonly IntPtr NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0;
		}

		// Token: 0x02000B45 RID: 2885
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D915 RID: 55573 RVA: 0x003383E8 File Offset: 0x003365E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "transparency");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "lerpTime");
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681329);
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681330);
			}

			// Token: 0x0600D916 RID: 55574 RVA: 0x00338478 File Offset: 0x00336678
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D917 RID: 55575 RVA: 0x003384B4 File Offset: 0x003366B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262835, XrefRangeEnd = 262840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D918 RID: 55576 RVA: 0x00069C07 File Offset: 0x00067E07
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600D919 RID: 55577 RVA: 0x003384F4 File Offset: 0x003366F4
			// (set) Token: 0x0600D91A RID: 55578 RVA: 0x00069C10 File Offset: 0x00067E10
			public unsafe SleepCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600D91B RID: 55579 RVA: 0x00338524 File Offset: 0x00336724
			// (set) Token: 0x0600D91C RID: 55580 RVA: 0x00069C2F File Offset: 0x00067E2F
			public unsafe float transparency
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency)) = value;
				}
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600D91D RID: 55581 RVA: 0x0033854C File Offset: 0x0033674C
			// (set) Token: 0x0600D91E RID: 55582 RVA: 0x00069C4A File Offset: 0x00067E4A
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x040091D7 RID: 37335
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091D8 RID: 37336
			private static readonly IntPtr NativeFieldInfoPtr_transparency;

			// Token: 0x040091D9 RID: 37337
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040091DA RID: 37338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091DB RID: 37339
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C77 RID: 3191
			[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0+<<LerpBlackOverlay>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5A1 RID: 58785 RVA: 0x0035C834 File Offset: 0x0035AA34
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique()
				{
					Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<<LerpBlackOverlay>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>1__state");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>2__current");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>4__this");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<startColor>5__2");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<endColor>5__3");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<i>5__4");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681331);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681332);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681333);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681334);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681335);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681336);
				}

				// Token: 0x0600E5A2 RID: 58786 RVA: 0x0035C950 File Offset: 0x0035AB50
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5A3 RID: 58787 RVA: 0x0035C998 File Offset: 0x0035AB98
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5A4 RID: 58788 RVA: 0x0035C9CC File Offset: 0x0035ABCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262817, XrefRangeEnd = 262830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004770 RID: 18288
				// (get) Token: 0x0600E5A5 RID: 58789 RVA: 0x0035CA08 File Offset: 0x0035AC08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5A6 RID: 58790 RVA: 0x0035CA48 File Offset: 0x0035AC48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262830, XrefRangeEnd = 262835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004771 RID: 18289
				// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x0035CA7C File Offset: 0x0035AC7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5A8 RID: 58792 RVA: 0x00070022 File Offset: 0x0006E222
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700476A RID: 18282
				// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x0035CABC File Offset: 0x0035ACBC
				// (set) Token: 0x0600E5AA RID: 58794 RVA: 0x0007002B File Offset: 0x0006E22B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700476B RID: 18283
				// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x0035CAE4 File Offset: 0x0035ACE4
				// (set) Token: 0x0600E5AC RID: 58796 RVA: 0x00070046 File Offset: 0x0006E246
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700476C RID: 18284
				// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x0035CB14 File Offset: 0x0035AD14
				// (set) Token: 0x0600E5AE RID: 58798 RVA: 0x00070065 File Offset: 0x0006E265
				public unsafe SleepCanvas.__c__DisplayClass42_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass42_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700476D RID: 18285
				// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x0035CB44 File Offset: 0x0035AD44
				// (set) Token: 0x0600E5B0 RID: 58800 RVA: 0x00070084 File Offset: 0x0006E284
				public unsafe Color _startColor_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2)) = value;
					}
				}

				// Token: 0x1700476E RID: 18286
				// (get) Token: 0x0600E5B1 RID: 58801 RVA: 0x0035CB6C File Offset: 0x0035AD6C
				// (set) Token: 0x0600E5B2 RID: 58802 RVA: 0x0007009F File Offset: 0x0006E29F
				public unsafe Color _endColor_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3)) = value;
					}
				}

				// Token: 0x1700476F RID: 18287
				// (get) Token: 0x0600E5B3 RID: 58803 RVA: 0x0035CB94 File Offset: 0x0035AD94
				// (set) Token: 0x0600E5B4 RID: 58804 RVA: 0x000700BA File Offset: 0x0006E2BA
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009988 RID: 39304
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009989 RID: 39305
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400998A RID: 39306
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400998B RID: 39307
				private static readonly IntPtr NativeFieldInfoPtr__startColor_5__2;

				// Token: 0x0400998C RID: 39308
				private static readonly IntPtr NativeFieldInfoPtr__endColor_5__3;

				// Token: 0x0400998D RID: 39309
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400998E RID: 39310
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400998F RID: 39311
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009990 RID: 39312
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009991 RID: 39313
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009992 RID: 39314
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009993 RID: 39315
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
