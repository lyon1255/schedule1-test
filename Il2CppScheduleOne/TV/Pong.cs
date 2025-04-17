using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000186 RID: 390
	public class Pong : TVApp
	{
		// Token: 0x06001F1C RID: 7964 RVA: 0x000D19C0 File Offset: 0x000CFBC0
		// Note: this type is marked as 'beforefieldinit'.
		static Pong()
		{
			Il2CppClassPointerStore<Pong>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Pong");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pong>.NativeClassPtr);
			Pong.NativeFieldInfoPtr__GameMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<GameMode>k__BackingField");
			Pong.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<State>k__BackingField");
			Pong.NativeFieldInfoPtr__LeftScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<LeftScore>k__BackingField");
			Pong.NativeFieldInfoPtr__RightScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "<RightScore>k__BackingField");
			Pong.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Rect");
			Pong.NativeFieldInfoPtr_LeftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftPaddle");
			Pong.NativeFieldInfoPtr_RightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightPaddle");
			Pong.NativeFieldInfoPtr_Ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "Ball");
			Pong.NativeFieldInfoPtr_LeftScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "LeftScoreLabel");
			Pong.NativeFieldInfoPtr_RightScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "RightScoreLabel");
			Pong.NativeFieldInfoPtr_WinnerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "WinnerLabel");
			Pong.NativeFieldInfoPtr_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "InitialVelocity");
			Pong.NativeFieldInfoPtr_VelocityGainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "VelocityGainPerSecond");
			Pong.NativeFieldInfoPtr_MaxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "MaxVelocity");
			Pong.NativeFieldInfoPtr_GoalsToWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "GoalsToWin");
			Pong.NativeFieldInfoPtr_ReactionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ReactionTime");
			Pong.NativeFieldInfoPtr_TargetRandomization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "TargetRandomization");
			Pong.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "SpeedMultiplier");
			Pong.NativeFieldInfoPtr_onServe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onServe");
			Pong.NativeFieldInfoPtr_onLeftScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLeftScore");
			Pong.NativeFieldInfoPtr_onRightScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onRightScore");
			Pong.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onGameOver");
			Pong.NativeFieldInfoPtr_onLocalPlayerWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onLocalPlayerWin");
			Pong.NativeFieldInfoPtr_onReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "onReset");
			Pong.NativeFieldInfoPtr_nextBallSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "nextBallSide");
			Pong.NativeFieldInfoPtr_ballVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "ballVelocity");
			Pong.NativeFieldInfoPtr_reactionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pong>.NativeClassPtr, "reactionTimer");
			Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666816);
			Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666817);
			Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666818);
			Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666819);
			Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666820);
			Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666821);
			Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666822);
			Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666823);
			Pong.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666824);
			Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666825);
			Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666826);
			Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666827);
			Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666828);
			Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666829);
			Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666830);
			Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666831);
			Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666832);
			Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666833);
			Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666834);
			Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666835);
			Pong.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pong>.NativeClassPtr, 100666836);
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000D1DB0 File Offset: 0x000CFFB0
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x000D1DEC File Offset: 0x000CFFEC
		public unsafe Pong.EGameMode GameMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 69387, RefRangeEnd = 69396, XrefRangeStart = 69387, XrefRangeEnd = 69396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x000D1E2C File Offset: 0x000D002C
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x000D1E68 File Offset: 0x000D0068
		public unsafe Pong.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_State_Public_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x000D1EA8 File Offset: 0x000D00A8
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x000D1EE4 File Offset: 0x000D00E4
		public unsafe int LeftScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55715, RefRangeEnd = 55716, XrefRangeStart = 55715, XrefRangeEnd = 55716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x000D1F24 File Offset: 0x000D0124
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x000D1F60 File Offset: 0x000D0160
		public unsafe int RightScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 108052, RefRangeEnd = 108053, XrefRangeStart = 108052, XrefRangeEnd = 108052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x000D1FA0 File Offset: 0x000D01A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108053, XrefRangeEnd = 108056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x000D1FD4 File Offset: 0x000D01D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108056, XrefRangeEnd = 108068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x000D2008 File Offset: 0x000D0208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108068, XrefRangeEnd = 108071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x000D2044 File Offset: 0x000D0244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108083, RefRangeEnd = 108084, XrefRangeStart = 108071, XrefRangeEnd = 108083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateInputs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x000D2078 File Offset: 0x000D0278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108092, RefRangeEnd = 108093, XrefRangeStart = 108084, XrefRangeEnd = 108092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_UpdateAI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x000D20AC File Offset: 0x000D02AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108102, RefRangeEnd = 108103, XrefRangeStart = 108093, XrefRangeEnd = 108102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoalHit(Pong.ESide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x000D20EC File Offset: 0x000D02EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108115, RefRangeEnd = 108116, XrefRangeStart = 108103, XrefRangeEnd = 108115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win(Pong.ESide winner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref winner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_Win_Private_Void_ESide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000D212C File Offset: 0x000D032C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108133, RefRangeEnd = 108136, XrefRangeStart = 108116, XrefRangeEnd = 108133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000D2160 File Offset: 0x000D0360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108136, XrefRangeEnd = 108144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServeBall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ServeBall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000D2194 File Offset: 0x000D0394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108144, XrefRangeEnd = 108150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x000D21C8 File Offset: 0x000D03C8
		[CallerCount(0)]
		public unsafe void SetPaddleTargetY(Pong.ESide player, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref player;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x000D2214 File Offset: 0x000D0414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108150, XrefRangeEnd = 108152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pong.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x000D2250 File Offset: 0x000D0450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108152, XrefRangeEnd = 108155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pong() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pong>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pong.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00011792 File Offset: 0x0000F992
		public Pong(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x000D228C File Offset: 0x000D048C
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0001179B File Offset: 0x0000F99B
		public unsafe Pong.EGameMode _GameMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__GameMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x000D22B4 File Offset: 0x000D04B4
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x000117B6 File Offset: 0x0000F9B6
		public unsafe Pong.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x000D22DC File Offset: 0x000D04DC
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x000117D1 File Offset: 0x0000F9D1
		public unsafe int _LeftScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__LeftScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000D2304 File Offset: 0x000D0504
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x000117EC File Offset: 0x0000F9EC
		public unsafe int _RightScore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr__RightScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x000D232C File Offset: 0x000D052C
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00011807 File Offset: 0x0000FA07
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x000D235C File Offset: 0x000D055C
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00011826 File Offset: 0x0000FA26
		public unsafe PongPaddle LeftPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x000D238C File Offset: 0x000D058C
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00011845 File Offset: 0x0000FA45
		public unsafe PongPaddle RightPaddle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongPaddle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightPaddle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x000D23BC File Offset: 0x000D05BC
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00011864 File Offset: 0x0000FA64
		public unsafe PongBall Ball
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PongBall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_Ball), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x000D23EC File Offset: 0x000D05EC
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x00011883 File Offset: 0x0000FA83
		public unsafe TextMeshProUGUI LeftScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_LeftScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x000D241C File Offset: 0x000D061C
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x000118A2 File Offset: 0x0000FAA2
		public unsafe TextMeshProUGUI RightScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_RightScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x000D244C File Offset: 0x000D064C
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x000118C1 File Offset: 0x0000FAC1
		public unsafe TextMeshProUGUI WinnerLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_WinnerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x000D247C File Offset: 0x000D067C
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x000118E0 File Offset: 0x0000FAE0
		public unsafe float InitialVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_InitialVelocity)) = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000D24A4 File Offset: 0x000D06A4
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x000118FB File Offset: 0x0000FAFB
		public unsafe float VelocityGainPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_VelocityGainPerSecond)) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000D24CC File Offset: 0x000D06CC
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00011916 File Offset: 0x0000FB16
		public unsafe float MaxVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_MaxVelocity)) = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x000D24F4 File Offset: 0x000D06F4
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00011931 File Offset: 0x0000FB31
		public unsafe int GoalsToWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_GoalsToWin)) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x000D251C File Offset: 0x000D071C
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0001194C File Offset: 0x0000FB4C
		public unsafe float ReactionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ReactionTime)) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x000D2544 File Offset: 0x000D0744
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00011967 File Offset: 0x0000FB67
		public unsafe float TargetRandomization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_TargetRandomization)) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x000D256C File Offset: 0x000D076C
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00011982 File Offset: 0x0000FB82
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x000D2594 File Offset: 0x000D0794
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x0001199D File Offset: 0x0000FB9D
		public unsafe UnityEvent onServe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onServe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x000D25C4 File Offset: 0x000D07C4
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x000119BC File Offset: 0x0000FBBC
		public unsafe UnityEvent onLeftScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLeftScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x000D25F4 File Offset: 0x000D07F4
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x000119DB File Offset: 0x0000FBDB
		public unsafe UnityEvent onRightScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onRightScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x000D2624 File Offset: 0x000D0824
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x000119FA File Offset: 0x0000FBFA
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000D2654 File Offset: 0x000D0854
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00011A19 File Offset: 0x0000FC19
		public unsafe UnityEvent onLocalPlayerWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onLocalPlayerWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000D2684 File Offset: 0x000D0884
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00011A38 File Offset: 0x0000FC38
		public unsafe UnityEvent onReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_onReset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000D26B4 File Offset: 0x000D08B4
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x00011A57 File Offset: 0x0000FC57
		public unsafe Pong.ESide nextBallSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_nextBallSide)) = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x000D26DC File Offset: 0x000D08DC
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x00011A72 File Offset: 0x0000FC72
		public unsafe Vector3 ballVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_ballVelocity)) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x000D2704 File Offset: 0x000D0904
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x00011A8D File Offset: 0x0000FC8D
		public unsafe float reactionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pong.NativeFieldInfoPtr_reactionTimer)) = value;
			}
		}

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr__GameMode_k__BackingField;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeFieldInfoPtr__LeftScore_k__BackingField;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr__RightScore_k__BackingField;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_LeftPaddle;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_RightPaddle;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_Ball;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_LeftScoreLabel;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_RightScoreLabel;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_WinnerLabel;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_InitialVelocity;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_VelocityGainPerSecond;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_MaxVelocity;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_GoalsToWin;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_ReactionTime;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_TargetRandomization;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_onServe;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_onLeftScore;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_onRightScore;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_onLocalPlayerWin;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_onReset;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_nextBallSide;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_ballVelocity;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_reactionTimer;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_get_GameMode_Public_get_EGameMode_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_set_GameMode_Public_set_Void_EGameMode_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_EState_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftScore_Public_get_Int32_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftScore_Public_set_Void_Int32_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_get_RightScore_Public_get_Int32_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_set_RightScore_Public_set_Void_Int32_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Public_Void_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAI_Private_Void_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_GoalHit_Public_Void_ESide_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_ESide_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_ResetBall_Private_Void_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_ServeBall_Private_Void_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_SetPaddleTargetY_Public_Void_ESide_Single_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B2 RID: 2226
		[OriginalName("Assembly-CSharp.dll", "", "EGameMode")]
		public enum EGameMode
		{
			// Token: 0x0400843C RID: 33852
			SinglePlayer,
			// Token: 0x0400843D RID: 33853
			MultiPlayer
		}

		// Token: 0x020008B3 RID: 2227
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x0400843F RID: 33855
			Left,
			// Token: 0x04008440 RID: 33856
			Right
		}

		// Token: 0x020008B4 RID: 2228
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008442 RID: 33858
			Ready,
			// Token: 0x04008443 RID: 33859
			Playing,
			// Token: 0x04008444 RID: 33860
			GameOver
		}
	}
}
