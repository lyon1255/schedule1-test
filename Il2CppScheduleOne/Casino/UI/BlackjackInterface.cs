using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004A9 RID: 1193
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x060068D1 RID: 26833 RVA: 0x001D67DC File Offset: 0x001D49DC
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackInterface()
		{
			Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "BlackjackInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr);
			BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			BlackjackInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "Canvas");
			BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerDisplay");
			BlackjackInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetContainer");
			BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetTitleLabel");
			BlackjackInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetSlider");
			BlackjackInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetAmount");
			BlackjackInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyButton");
			BlackjackInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyLabel");
			BlackjackInterface.NativeFieldInfoPtr_WaitingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingContainer");
			BlackjackInterface.NativeFieldInfoPtr_WaitingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingLabel");
			BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "DealerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_HitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "HitButton");
			BlackjackInterface.NativeFieldInfoPtr_StandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "StandButton");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeIn");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeOut");
			BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "SelectionIndicator");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PositiveOutcomeLabel");
			BlackjackInterface.NativeFieldInfoPtr_PayoutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PayoutLabel");
			BlackjackInterface.NativeFieldInfoPtr_onBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBust");
			BlackjackInterface.NativeFieldInfoPtr_onBlackjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBlackjack");
			BlackjackInterface.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onWin");
			BlackjackInterface.NativeFieldInfoPtr_onLose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onLose");
			BlackjackInterface.NativeFieldInfoPtr_onPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onPush");
			BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676643);
			BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676644);
			BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676645);
			BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676646);
			BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676647);
			BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676648);
			BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676649);
			BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676650);
			BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676651);
			BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676652);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676653);
			BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676654);
			BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676655);
			BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676656);
			BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676657);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676658);
			BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676659);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676660);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676661);
			BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676662);
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x001D6BE0 File Offset: 0x001D4DE0
		// (set) Token: 0x060068D3 RID: 26835 RVA: 0x001D6C20 File Offset: 0x001D4E20
		public unsafe BlackjackGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x001D6C64 File Offset: 0x001D4E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211919, XrefRangeEnd = 211955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x001D6CA0 File Offset: 0x001D4EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211955, XrefRangeEnd = 212001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x001D6CD4 File Offset: 0x001D4ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212091, RefRangeEnd = 212092, XrefRangeStart = 212001, XrefRangeEnd = 212091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BlackjackGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x001D6D18 File Offset: 0x001D4F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212181, RefRangeEnd = 212182, XrefRangeStart = 212092, XrefRangeEnd = 212181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x001D6D4C File Offset: 0x001D4F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212182, XrefRangeEnd = 212187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x001D6D8C File Offset: 0x001D4F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212187, XrefRangeEnd = 212189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x001D6DD8 File Offset: 0x001D4FD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212194, RefRangeEnd = 212197, XrefRangeStart = 212189, XrefRangeEnd = 212194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x001D6E0C File Offset: 0x001D500C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212215, RefRangeEnd = 212216, XrefRangeStart = 212197, XrefRangeEnd = 212215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x001D6E40 File Offset: 0x001D5040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212216, XrefRangeEnd = 212222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerReadyForInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x001D6E74 File Offset: 0x001D5074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212222, XrefRangeEnd = 212225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x001D6EA8 File Offset: 0x001D50A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212225, XrefRangeEnd = 212228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x001D6EDC File Offset: 0x001D50DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212228, XrefRangeEnd = 212244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x001D6F10 File Offset: 0x001D5110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212244, XrefRangeEnd = 212260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x001D6F44 File Offset: 0x001D5144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212260, XrefRangeEnd = 212266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x001D6F78 File Offset: 0x001D5178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212266, XrefRangeEnd = 212268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x001D6FAC File Offset: 0x001D51AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212268, XrefRangeEnd = 212269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerBust()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x001D6FE0 File Offset: 0x001D51E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212269, XrefRangeEnd = 212274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x001D7020 File Offset: 0x001D5220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212274, XrefRangeEnd = 212277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x00031677 File Offset: 0x0002F877
		public BlackjackInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x060068E7 RID: 26855 RVA: 0x001D705C File Offset: 0x001D525C
		// (set) Token: 0x060068E8 RID: 26856 RVA: 0x00031680 File Offset: 0x0002F880
		public unsafe BlackjackGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x001D708C File Offset: 0x001D528C
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x0003169F File Offset: 0x0002F89F
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x001D70BC File Offset: 0x001D52BC
		// (set) Token: 0x060068EC RID: 26860 RVA: 0x000316BE File Offset: 0x0002F8BE
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x060068ED RID: 26861 RVA: 0x001D70EC File Offset: 0x001D52EC
		// (set) Token: 0x060068EE RID: 26862 RVA: 0x000316DD File Offset: 0x0002F8DD
		public unsafe RectTransform BetContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x060068EF RID: 26863 RVA: 0x001D711C File Offset: 0x001D531C
		// (set) Token: 0x060068F0 RID: 26864 RVA: 0x000316FC File Offset: 0x0002F8FC
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x060068F1 RID: 26865 RVA: 0x001D714C File Offset: 0x001D534C
		// (set) Token: 0x060068F2 RID: 26866 RVA: 0x0003171B File Offset: 0x0002F91B
		public unsafe Slider BetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x060068F3 RID: 26867 RVA: 0x001D717C File Offset: 0x001D537C
		// (set) Token: 0x060068F4 RID: 26868 RVA: 0x0003173A File Offset: 0x0002F93A
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x060068F5 RID: 26869 RVA: 0x001D71AC File Offset: 0x001D53AC
		// (set) Token: 0x060068F6 RID: 26870 RVA: 0x00031759 File Offset: 0x0002F959
		public unsafe Button ReadyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x060068F7 RID: 26871 RVA: 0x001D71DC File Offset: 0x001D53DC
		// (set) Token: 0x060068F8 RID: 26872 RVA: 0x00031778 File Offset: 0x0002F978
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x060068F9 RID: 26873 RVA: 0x001D720C File Offset: 0x001D540C
		// (set) Token: 0x060068FA RID: 26874 RVA: 0x00031797 File Offset: 0x0002F997
		public unsafe RectTransform WaitingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x060068FB RID: 26875 RVA: 0x001D723C File Offset: 0x001D543C
		// (set) Token: 0x060068FC RID: 26876 RVA: 0x000317B6 File Offset: 0x0002F9B6
		public unsafe TextMeshProUGUI WaitingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x060068FD RID: 26877 RVA: 0x001D726C File Offset: 0x001D546C
		// (set) Token: 0x060068FE RID: 26878 RVA: 0x000317D5 File Offset: 0x0002F9D5
		public unsafe TextMeshProUGUI DealerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060068FF RID: 26879 RVA: 0x001D729C File Offset: 0x001D549C
		// (set) Token: 0x06006900 RID: 26880 RVA: 0x000317F4 File Offset: 0x0002F9F4
		public unsafe TextMeshProUGUI PlayerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06006901 RID: 26881 RVA: 0x001D72CC File Offset: 0x001D54CC
		// (set) Token: 0x06006902 RID: 26882 RVA: 0x00031813 File Offset: 0x0002FA13
		public unsafe Button HitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x001D72FC File Offset: 0x001D54FC
		// (set) Token: 0x06006904 RID: 26884 RVA: 0x00031832 File Offset: 0x0002FA32
		public unsafe Button StandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06006905 RID: 26885 RVA: 0x001D732C File Offset: 0x001D552C
		// (set) Token: 0x06006906 RID: 26886 RVA: 0x00031851 File Offset: 0x0002FA51
		public unsafe Animation InputContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x001D735C File Offset: 0x001D555C
		// (set) Token: 0x06006908 RID: 26888 RVA: 0x00031870 File Offset: 0x0002FA70
		public unsafe CanvasGroup InputContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06006909 RID: 26889 RVA: 0x001D738C File Offset: 0x001D558C
		// (set) Token: 0x0600690A RID: 26890 RVA: 0x0003188F File Offset: 0x0002FA8F
		public unsafe AnimationClip InputContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x001D73BC File Offset: 0x001D55BC
		// (set) Token: 0x0600690C RID: 26892 RVA: 0x000318AE File Offset: 0x0002FAAE
		public unsafe AnimationClip InputContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600690D RID: 26893 RVA: 0x001D73EC File Offset: 0x001D55EC
		// (set) Token: 0x0600690E RID: 26894 RVA: 0x000318CD File Offset: 0x0002FACD
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x0600690F RID: 26895 RVA: 0x001D741C File Offset: 0x001D561C
		// (set) Token: 0x06006910 RID: 26896 RVA: 0x000318EC File Offset: 0x0002FAEC
		public unsafe Animation ScoresContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06006911 RID: 26897 RVA: 0x001D744C File Offset: 0x001D564C
		// (set) Token: 0x06006912 RID: 26898 RVA: 0x0003190B File Offset: 0x0002FB0B
		public unsafe CanvasGroup ScoresContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x001D747C File Offset: 0x001D567C
		// (set) Token: 0x06006914 RID: 26900 RVA: 0x0003192A File Offset: 0x0002FB2A
		public unsafe TextMeshProUGUI PositiveOutcomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06006915 RID: 26901 RVA: 0x001D74AC File Offset: 0x001D56AC
		// (set) Token: 0x06006916 RID: 26902 RVA: 0x00031949 File Offset: 0x0002FB49
		public unsafe TextMeshProUGUI PayoutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06006917 RID: 26903 RVA: 0x001D74DC File Offset: 0x001D56DC
		// (set) Token: 0x06006918 RID: 26904 RVA: 0x00031968 File Offset: 0x0002FB68
		public unsafe UnityEvent onBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06006919 RID: 26905 RVA: 0x001D750C File Offset: 0x001D570C
		// (set) Token: 0x0600691A RID: 26906 RVA: 0x00031987 File Offset: 0x0002FB87
		public unsafe UnityEvent onBlackjack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x0600691B RID: 26907 RVA: 0x001D753C File Offset: 0x001D573C
		// (set) Token: 0x0600691C RID: 26908 RVA: 0x000319A6 File Offset: 0x0002FBA6
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600691D RID: 26909 RVA: 0x001D756C File Offset: 0x001D576C
		// (set) Token: 0x0600691E RID: 26910 RVA: 0x000319C5 File Offset: 0x0002FBC5
		public unsafe UnityEvent onLose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600691F RID: 26911 RVA: 0x001D759C File Offset: 0x001D579C
		// (set) Token: 0x06006920 RID: 26912 RVA: 0x000319E4 File Offset: 0x0002FBE4
		public unsafe UnityEvent onPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047DC RID: 18396
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x040047DD RID: 18397
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040047DE RID: 18398
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x040047DF RID: 18399
		private static readonly IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x040047E0 RID: 18400
		private static readonly IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x040047E1 RID: 18401
		private static readonly IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x040047E2 RID: 18402
		private static readonly IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x040047E3 RID: 18403
		private static readonly IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x040047E4 RID: 18404
		private static readonly IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x040047E5 RID: 18405
		private static readonly IntPtr NativeFieldInfoPtr_WaitingContainer;

		// Token: 0x040047E6 RID: 18406
		private static readonly IntPtr NativeFieldInfoPtr_WaitingLabel;

		// Token: 0x040047E7 RID: 18407
		private static readonly IntPtr NativeFieldInfoPtr_DealerScoreLabel;

		// Token: 0x040047E8 RID: 18408
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScoreLabel;

		// Token: 0x040047E9 RID: 18409
		private static readonly IntPtr NativeFieldInfoPtr_HitButton;

		// Token: 0x040047EA RID: 18410
		private static readonly IntPtr NativeFieldInfoPtr_StandButton;

		// Token: 0x040047EB RID: 18411
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerAnimation;

		// Token: 0x040047EC RID: 18412
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerCanvasGroup;

		// Token: 0x040047ED RID: 18413
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeIn;

		// Token: 0x040047EE RID: 18414
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeOut;

		// Token: 0x040047EF RID: 18415
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040047F0 RID: 18416
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerAnimation;

		// Token: 0x040047F1 RID: 18417
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerCanvasGroup;

		// Token: 0x040047F2 RID: 18418
		private static readonly IntPtr NativeFieldInfoPtr_PositiveOutcomeLabel;

		// Token: 0x040047F3 RID: 18419
		private static readonly IntPtr NativeFieldInfoPtr_PayoutLabel;

		// Token: 0x040047F4 RID: 18420
		private static readonly IntPtr NativeFieldInfoPtr_onBust;

		// Token: 0x040047F5 RID: 18421
		private static readonly IntPtr NativeFieldInfoPtr_onBlackjack;

		// Token: 0x040047F6 RID: 18422
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x040047F7 RID: 18423
		private static readonly IntPtr NativeFieldInfoPtr_onLose;

		// Token: 0x040047F8 RID: 18424
		private static readonly IntPtr NativeFieldInfoPtr_onPush;

		// Token: 0x040047F9 RID: 18425
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0;

		// Token: 0x040047FA RID: 18426
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0;

		// Token: 0x040047FB RID: 18427
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040047FC RID: 18428
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040047FD RID: 18429
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0;

		// Token: 0x040047FE RID: 18430
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040047FF RID: 18431
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x04004800 RID: 18432
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x04004801 RID: 18433
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x04004802 RID: 18434
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x04004803 RID: 18435
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0;

		// Token: 0x04004804 RID: 18436
		private static readonly IntPtr NativeMethodInfoPtr_ShowScores_Private_Void_0;

		// Token: 0x04004805 RID: 18437
		private static readonly IntPtr NativeMethodInfoPtr_HideScores_Private_Void_0;

		// Token: 0x04004806 RID: 18438
		private static readonly IntPtr NativeMethodInfoPtr_HitClicked_Private_Void_0;

		// Token: 0x04004807 RID: 18439
		private static readonly IntPtr NativeMethodInfoPtr_StandClicked_Private_Void_0;

		// Token: 0x04004808 RID: 18440
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x04004809 RID: 18441
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x0400480A RID: 18442
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0;

		// Token: 0x0400480B RID: 18443
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0;

		// Token: 0x0400480C RID: 18444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
