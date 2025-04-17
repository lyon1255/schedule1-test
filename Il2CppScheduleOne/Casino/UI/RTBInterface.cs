using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004AB RID: 1195
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x0600692E RID: 26926 RVA: 0x001D7848 File Offset: 0x001D5A48
		// Note: this type is marked as 'beforefieldinit'.
		static RTBInterface()
		{
			Il2CppClassPointerStore<RTBInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "RTBInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr);
			RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			RTBInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "Canvas");
			RTBInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "PlayerDisplay");
			RTBInterface.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "StatusLabel");
			RTBInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetContainer");
			RTBInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetTitleLabel");
			RTBInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetSlider");
			RTBInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetAmount");
			RTBInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyButton");
			RTBInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyLabel");
			RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "WinningsMultiplierLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainer");
			RTBInterface.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionLabel");
			RTBInterface.NativeFieldInfoPtr_TimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "TimerSlider");
			RTBInterface.NativeFieldInfoPtr_AnswerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerButtons");
			RTBInterface.NativeFieldInfoPtr_AnswerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerLabels");
			RTBInterface.NativeFieldInfoPtr_ForfeitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitButton");
			RTBInterface.NativeFieldInfoPtr_ForfeitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerAnimation");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeIn");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeOut");
			RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionCanvasGroup");
			RTBInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "SelectionIndicator");
			RTBInterface.NativeFieldInfoPtr_onCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onCorrect");
			RTBInterface.NativeFieldInfoPtr_onFinalCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onFinalCorrect");
			RTBInterface.NativeFieldInfoPtr_onIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onIncorrect");
			RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676668);
			RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676669);
			RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676670);
			RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676671);
			RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676672);
			RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676673);
			RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676674);
			RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676675);
			RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676676);
			RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676677);
			RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676678);
			RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676679);
			RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676680);
			RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676681);
			RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676682);
			RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676683);
			RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676684);
			RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676685);
			RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676686);
			RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676687);
			RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100676688);
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x0600692F RID: 26927 RVA: 0x001D7C24 File Offset: 0x001D5E24
		// (set) Token: 0x06006930 RID: 26928 RVA: 0x001D7C64 File Offset: 0x001D5E64
		public unsafe RTBGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x001D7CA8 File Offset: 0x001D5EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212401, XrefRangeEnd = 212443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x001D7CE4 File Offset: 0x001D5EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212443, XrefRangeEnd = 212463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x001D7D18 File Offset: 0x001D5F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212473, RefRangeEnd = 212474, XrefRangeStart = 212463, XrefRangeEnd = 212473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x001D7D50 File Offset: 0x001D5F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212563, RefRangeEnd = 212564, XrefRangeStart = 212474, XrefRangeEnd = 212563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(RTBGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x001D7D94 File Offset: 0x001D5F94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212653, RefRangeEnd = 212654, XrefRangeStart = 212564, XrefRangeEnd = 212653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x001D7DC8 File Offset: 0x001D5FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212654, XrefRangeEnd = 212658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x001D7E08 File Offset: 0x001D6008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212658, XrefRangeEnd = 212660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x001D7E54 File Offset: 0x001D6054
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212665, RefRangeEnd = 212668, XrefRangeStart = 212660, XrefRangeEnd = 212665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x001D7E88 File Offset: 0x001D6088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212668, XrefRangeEnd = 212686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x001D7EBC File Offset: 0x001D60BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212686, XrefRangeEnd = 212708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionReady(string question, Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(question);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x001D7F10 File Offset: 0x001D6110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212708, XrefRangeEnd = 212717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnswerButtonClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x001D7F50 File Offset: 0x001D6150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212717, XrefRangeEnd = 212728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForfeitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x001D7F84 File Offset: 0x001D6184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212728, XrefRangeEnd = 212732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x001D7FB8 File Offset: 0x001D61B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212732, XrefRangeEnd = 212736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x001D7FEC File Offset: 0x001D61EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212736, XrefRangeEnd = 212742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Correct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x001D8020 File Offset: 0x001D6220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212742, XrefRangeEnd = 212743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incorrect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x001D8054 File Offset: 0x001D6254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212743, XrefRangeEnd = 212754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x001D8088 File Offset: 0x001D6288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212754, XrefRangeEnd = 212757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x001D80C4 File Offset: 0x001D62C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212757, XrefRangeEnd = 212762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x00031A69 File Offset: 0x0002FC69
		public RTBInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006945 RID: 26949 RVA: 0x001D8104 File Offset: 0x001D6304
		// (set) Token: 0x06006946 RID: 26950 RVA: 0x00031A72 File Offset: 0x0002FC72
		public unsafe RTBGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006947 RID: 26951 RVA: 0x001D8134 File Offset: 0x001D6334
		// (set) Token: 0x06006948 RID: 26952 RVA: 0x00031A91 File Offset: 0x0002FC91
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006949 RID: 26953 RVA: 0x001D8164 File Offset: 0x001D6364
		// (set) Token: 0x0600694A RID: 26954 RVA: 0x00031AB0 File Offset: 0x0002FCB0
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x001D8194 File Offset: 0x001D6394
		// (set) Token: 0x0600694C RID: 26956 RVA: 0x00031ACF File Offset: 0x0002FCCF
		public unsafe TextMeshProUGUI StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600694D RID: 26957 RVA: 0x001D81C4 File Offset: 0x001D63C4
		// (set) Token: 0x0600694E RID: 26958 RVA: 0x00031AEE File Offset: 0x0002FCEE
		public unsafe RectTransform BetContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600694F RID: 26959 RVA: 0x001D81F4 File Offset: 0x001D63F4
		// (set) Token: 0x06006950 RID: 26960 RVA: 0x00031B0D File Offset: 0x0002FD0D
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006951 RID: 26961 RVA: 0x001D8224 File Offset: 0x001D6424
		// (set) Token: 0x06006952 RID: 26962 RVA: 0x00031B2C File Offset: 0x0002FD2C
		public unsafe Slider BetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006953 RID: 26963 RVA: 0x001D8254 File Offset: 0x001D6454
		// (set) Token: 0x06006954 RID: 26964 RVA: 0x00031B4B File Offset: 0x0002FD4B
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x001D8284 File Offset: 0x001D6484
		// (set) Token: 0x06006956 RID: 26966 RVA: 0x00031B6A File Offset: 0x0002FD6A
		public unsafe Button ReadyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x001D82B4 File Offset: 0x001D64B4
		// (set) Token: 0x06006958 RID: 26968 RVA: 0x00031B89 File Offset: 0x0002FD89
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x001D82E4 File Offset: 0x001D64E4
		// (set) Token: 0x0600695A RID: 26970 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		public unsafe TextMeshProUGUI WinningsMultiplierLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x001D8314 File Offset: 0x001D6514
		// (set) Token: 0x0600695C RID: 26972 RVA: 0x00031BC7 File Offset: 0x0002FDC7
		public unsafe RectTransform QuestionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x001D8344 File Offset: 0x001D6544
		// (set) Token: 0x0600695E RID: 26974 RVA: 0x00031BE6 File Offset: 0x0002FDE6
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x0600695F RID: 26975 RVA: 0x001D8374 File Offset: 0x001D6574
		// (set) Token: 0x06006960 RID: 26976 RVA: 0x00031C05 File Offset: 0x0002FE05
		public unsafe Slider TimerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x001D83A4 File Offset: 0x001D65A4
		// (set) Token: 0x06006962 RID: 26978 RVA: 0x00031C24 File Offset: 0x0002FE24
		public unsafe Il2CppReferenceArray<Button> AnswerButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06006963 RID: 26979 RVA: 0x001D83D4 File Offset: 0x001D65D4
		// (set) Token: 0x06006964 RID: 26980 RVA: 0x00031C43 File Offset: 0x0002FE43
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> AnswerLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06006965 RID: 26981 RVA: 0x001D8404 File Offset: 0x001D6604
		// (set) Token: 0x06006966 RID: 26982 RVA: 0x00031C62 File Offset: 0x0002FE62
		public unsafe Button ForfeitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06006967 RID: 26983 RVA: 0x001D8434 File Offset: 0x001D6634
		// (set) Token: 0x06006968 RID: 26984 RVA: 0x00031C81 File Offset: 0x0002FE81
		public unsafe TextMeshProUGUI ForfeitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006969 RID: 26985 RVA: 0x001D8464 File Offset: 0x001D6664
		// (set) Token: 0x0600696A RID: 26986 RVA: 0x00031CA0 File Offset: 0x0002FEA0
		public unsafe Animation QuestionContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x001D8494 File Offset: 0x001D6694
		// (set) Token: 0x0600696C RID: 26988 RVA: 0x00031CBF File Offset: 0x0002FEBF
		public unsafe AnimationClip QuestionContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x0600696D RID: 26989 RVA: 0x001D84C4 File Offset: 0x001D66C4
		// (set) Token: 0x0600696E RID: 26990 RVA: 0x00031CDE File Offset: 0x0002FEDE
		public unsafe AnimationClip QuestionContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x0600696F RID: 26991 RVA: 0x001D84F4 File Offset: 0x001D66F4
		// (set) Token: 0x06006970 RID: 26992 RVA: 0x00031CFD File Offset: 0x0002FEFD
		public unsafe CanvasGroup QuestionCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x001D8524 File Offset: 0x001D6724
		// (set) Token: 0x06006972 RID: 26994 RVA: 0x00031D1C File Offset: 0x0002FF1C
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x001D8554 File Offset: 0x001D6754
		// (set) Token: 0x06006974 RID: 26996 RVA: 0x00031D3B File Offset: 0x0002FF3B
		public unsafe UnityEvent onCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x001D8584 File Offset: 0x001D6784
		// (set) Token: 0x06006976 RID: 26998 RVA: 0x00031D5A File Offset: 0x0002FF5A
		public unsafe UnityEvent onFinalCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x001D85B4 File Offset: 0x001D67B4
		// (set) Token: 0x06006978 RID: 27000 RVA: 0x00031D79 File Offset: 0x0002FF79
		public unsafe UnityEvent onIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004815 RID: 18453
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x04004816 RID: 18454
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04004817 RID: 18455
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x04004818 RID: 18456
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x04004819 RID: 18457
		private static readonly IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x0400481A RID: 18458
		private static readonly IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x0400481B RID: 18459
		private static readonly IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x0400481C RID: 18460
		private static readonly IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x0400481D RID: 18461
		private static readonly IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x0400481E RID: 18462
		private static readonly IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x0400481F RID: 18463
		private static readonly IntPtr NativeFieldInfoPtr_WinningsMultiplierLabel;

		// Token: 0x04004820 RID: 18464
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainer;

		// Token: 0x04004821 RID: 18465
		private static readonly IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x04004822 RID: 18466
		private static readonly IntPtr NativeFieldInfoPtr_TimerSlider;

		// Token: 0x04004823 RID: 18467
		private static readonly IntPtr NativeFieldInfoPtr_AnswerButtons;

		// Token: 0x04004824 RID: 18468
		private static readonly IntPtr NativeFieldInfoPtr_AnswerLabels;

		// Token: 0x04004825 RID: 18469
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitButton;

		// Token: 0x04004826 RID: 18470
		private static readonly IntPtr NativeFieldInfoPtr_ForfeitLabel;

		// Token: 0x04004827 RID: 18471
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerAnimation;

		// Token: 0x04004828 RID: 18472
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeIn;

		// Token: 0x04004829 RID: 18473
		private static readonly IntPtr NativeFieldInfoPtr_QuestionContainerFadeOut;

		// Token: 0x0400482A RID: 18474
		private static readonly IntPtr NativeFieldInfoPtr_QuestionCanvasGroup;

		// Token: 0x0400482B RID: 18475
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x0400482C RID: 18476
		private static readonly IntPtr NativeFieldInfoPtr_onCorrect;

		// Token: 0x0400482D RID: 18477
		private static readonly IntPtr NativeFieldInfoPtr_onFinalCorrect;

		// Token: 0x0400482E RID: 18478
		private static readonly IntPtr NativeFieldInfoPtr_onIncorrect;

		// Token: 0x0400482F RID: 18479
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0;

		// Token: 0x04004830 RID: 18480
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0;

		// Token: 0x04004831 RID: 18481
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004832 RID: 18482
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004833 RID: 18483
		private static readonly IntPtr NativeMethodInfoPtr_GetStatusText_Private_String_0;

		// Token: 0x04004834 RID: 18484
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0;

		// Token: 0x04004835 RID: 18485
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004836 RID: 18486
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x04004837 RID: 18487
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x04004838 RID: 18488
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x04004839 RID: 18489
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x0400483A RID: 18490
		private static readonly IntPtr NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400483B RID: 18491
		private static readonly IntPtr NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0;

		// Token: 0x0400483C RID: 18492
		private static readonly IntPtr NativeMethodInfoPtr_ForfeitClicked_Private_Void_0;

		// Token: 0x0400483D RID: 18493
		private static readonly IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x0400483E RID: 18494
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x0400483F RID: 18495
		private static readonly IntPtr NativeMethodInfoPtr_Correct_Private_Void_0;

		// Token: 0x04004840 RID: 18496
		private static readonly IntPtr NativeMethodInfoPtr_Incorrect_Private_Void_0;

		// Token: 0x04004841 RID: 18497
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x04004842 RID: 18498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004843 RID: 18499
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A4F RID: 2639
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<<QuestionReady>g__Routine|38_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D025 RID: 53285 RVA: 0x0031F0F8 File Offset: 0x0031D2F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique()
			{
				Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<<QuestionReady>g__Routine|38_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>1__state");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>2__current");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>4__this");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676689);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676690);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676691);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676692);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676693);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100676694);
			}

			// Token: 0x0600D026 RID: 53286 RVA: 0x0031F1D8 File Offset: 0x0031D3D8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D027 RID: 53287 RVA: 0x0031F220 File Offset: 0x0031D420
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D028 RID: 53288 RVA: 0x0031F254 File Offset: 0x0031D454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212378, XrefRangeEnd = 212387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040A9 RID: 16553
			// (get) Token: 0x0600D029 RID: 53289 RVA: 0x0031F290 File Offset: 0x0031D490
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D02A RID: 53290 RVA: 0x0031F2D0 File Offset: 0x0031D4D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212387, XrefRangeEnd = 212392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040AA RID: 16554
			// (get) Token: 0x0600D02B RID: 53291 RVA: 0x0031F304 File Offset: 0x0031D504
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D02C RID: 53292 RVA: 0x000654AD File Offset: 0x000636AD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A6 RID: 16550
			// (get) Token: 0x0600D02D RID: 53293 RVA: 0x0031F344 File Offset: 0x0031D544
			// (set) Token: 0x0600D02E RID: 53294 RVA: 0x000654B6 File Offset: 0x000636B6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040A7 RID: 16551
			// (get) Token: 0x0600D02F RID: 53295 RVA: 0x0031F36C File Offset: 0x0031D56C
			// (set) Token: 0x0600D030 RID: 53296 RVA: 0x000654D1 File Offset: 0x000636D1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A8 RID: 16552
			// (get) Token: 0x0600D031 RID: 53297 RVA: 0x0031F39C File Offset: 0x0031D59C
			// (set) Token: 0x0600D032 RID: 53298 RVA: 0x000654F0 File Offset: 0x000636F0
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C7B RID: 35963
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C7C RID: 35964
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C7D RID: 35965
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C7E RID: 35966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C7F RID: 35967
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C80 RID: 35968
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C81 RID: 35969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C82 RID: 35970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C83 RID: 35971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A50 RID: 2640
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D033 RID: 53299 RVA: 0x0031F3CC File Offset: 0x0031D5CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr);
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "index");
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100676695);
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100676696);
			}

			// Token: 0x0600D034 RID: 53300 RVA: 0x0031F448 File Offset: 0x0031D648
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D035 RID: 53301 RVA: 0x0031F484 File Offset: 0x0031D684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212392, XrefRangeEnd = 212401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D036 RID: 53302 RVA: 0x0006550F File Offset: 0x0006370F
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040AB RID: 16555
			// (get) Token: 0x0600D037 RID: 53303 RVA: 0x0031F4B8 File Offset: 0x0031D6B8
			// (set) Token: 0x0600D038 RID: 53304 RVA: 0x00065518 File Offset: 0x00063718
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170040AC RID: 16556
			// (get) Token: 0x0600D039 RID: 53305 RVA: 0x0031F4E0 File Offset: 0x0031D6E0
			// (set) Token: 0x0600D03A RID: 53306 RVA: 0x00065533 File Offset: 0x00063733
			public unsafe RTBInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C84 RID: 35972
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008C85 RID: 35973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C86 RID: 35974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C87 RID: 35975
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
