using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000189 RID: 393
	public class RunnerGame : TVApp
	{
		// Token: 0x06001F8A RID: 8074 RVA: 0x000D2CBC File Offset: 0x000D0EBC
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGame()
		{
			Il2CppClassPointerStore<RunnerGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr);
			RunnerGame.NativeFieldInfoPtr_GameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameSpeed");
			RunnerGame.NativeFieldInfoPtr_MinGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MinGameSpeed");
			RunnerGame.NativeFieldInfoPtr_MaxGameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "MaxGameSpeed");
			RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "SpeedIncreaseRate");
			RunnerGame.NativeFieldInfoPtr_ScoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreRate");
			RunnerGame.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Gravity");
			RunnerGame.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpForce");
			RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GlobalForceMultiplier");
			RunnerGame.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "DropForce");
			RunnerGame.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Character");
			RunnerGame.NativeFieldInfoPtr_CharacterFlipboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CharacterFlipboard");
			RunnerGame.NativeFieldInfoPtr_Ground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "Ground");
			RunnerGame.NativeFieldInfoPtr_CloudSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "CloudSpawner");
			RunnerGame.NativeFieldInfoPtr_ObstacleSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ObstacleSpawner");
			RunnerGame.NativeFieldInfoPtr_ScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "ScoreLabel");
			RunnerGame.NativeFieldInfoPtr_HighScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "HighScoreLabel");
			RunnerGame.NativeFieldInfoPtr_StartScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "StartScreen");
			RunnerGame.NativeFieldInfoPtr_GameOverScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "GameOverScreen");
			RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "NewHighScoreAnimation");
			RunnerGame.NativeFieldInfoPtr_JumpSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "JumpSprite");
			RunnerGame.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isJumping");
			RunnerGame.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isGrounded");
			RunnerGame.NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "isReady");
			RunnerGame.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "score");
			RunnerGame.NativeFieldInfoPtr_yVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "yVelocity");
			RunnerGame.NativeFieldInfoPtr_defaultCharacterY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "defaultCharacterY");
			RunnerGame.NativeFieldInfoPtr_clouds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "clouds");
			RunnerGame.NativeFieldInfoPtr_obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "obstacles");
			RunnerGame.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onJump");
			RunnerGame.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onHit");
			RunnerGame.NativeFieldInfoPtr_onNewHighScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, "onNewHighScore");
			RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666846);
			RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666847);
			RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666848);
			RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666849);
			RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666850);
			RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666851);
			RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666852);
			RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666853);
			RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666854);
			RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666855);
			RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666856);
			RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666857);
			RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr, 100666858);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000D305C File Offset: 0x000D125C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108193, XrefRangeEnd = 108212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000D3098 File Offset: 0x000D1298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108212, XrefRangeEnd = 108214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000D30D4 File Offset: 0x000D12D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108214, XrefRangeEnd = 108216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunnerGame.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x000D3110 File Offset: 0x000D1310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108216, XrefRangeEnd = 108312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x000D3144 File Offset: 0x000D1344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108312, XrefRangeEnd = 108313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_Jump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x000D3178 File Offset: 0x000D1378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108313, XrefRangeEnd = 108322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloudSpawned(GameObject cloud)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloud);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x000D31BC File Offset: 0x000D13BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108322, XrefRangeEnd = 108331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObstacleSpawned(GameObject obstacle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x000D3200 File Offset: 0x000D1400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108343, RefRangeEnd = 108345, XrefRangeStart = 108331, XrefRangeEnd = 108343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshHighScore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_RefreshHighScore_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000D3234 File Offset: 0x000D1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108345, XrefRangeEnd = 108347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerCollided()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_PlayerCollided_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000D3268 File Offset: 0x000D1468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108366, RefRangeEnd = 108368, XrefRangeStart = 108347, XrefRangeEnd = 108366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000D329C File Offset: 0x000D149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108368, XrefRangeEnd = 108372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000D32D0 File Offset: 0x000D14D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108423, RefRangeEnd = 108425, XrefRangeStart = 108372, XrefRangeEnd = 108423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr_ResetGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000D3304 File Offset: 0x000D1504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108425, XrefRangeEnd = 108438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00011BC2 File Offset: 0x0000FDC2
		public RunnerGame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000D3340 File Offset: 0x000D1540
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00011BCB File Offset: 0x0000FDCB
		public unsafe float GameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameSpeed)) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000D3368 File Offset: 0x000D1568
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00011BE6 File Offset: 0x0000FDE6
		public unsafe float MinGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MinGameSpeed)) = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000D3390 File Offset: 0x000D1590
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00011C01 File Offset: 0x0000FE01
		public unsafe float MaxGameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_MaxGameSpeed)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000D33B8 File Offset: 0x000D15B8
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00011C1C File Offset: 0x0000FE1C
		public unsafe float SpeedIncreaseRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_SpeedIncreaseRate)) = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x000D33E0 File Offset: 0x000D15E0
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00011C37 File Offset: 0x0000FE37
		public unsafe int ScoreRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreRate)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x000D3408 File Offset: 0x000D1608
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00011C52 File Offset: 0x0000FE52
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x000D3430 File Offset: 0x000D1630
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x00011C6D File Offset: 0x0000FE6D
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000D3458 File Offset: 0x000D1658
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x00011C88 File Offset: 0x0000FE88
		public unsafe float GlobalForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GlobalForceMultiplier)) = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x000D3480 File Offset: 0x000D1680
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x00011CA3 File Offset: 0x0000FEA3
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000D34A8 File Offset: 0x000D16A8
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00011CBE File Offset: 0x0000FEBE
		public unsafe RectTransform Character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x000D34D8 File Offset: 0x000D16D8
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00011CDD File Offset: 0x0000FEDD
		public unsafe Flipboard CharacterFlipboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CharacterFlipboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x000D3508 File Offset: 0x000D1708
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00011CFC File Offset: 0x0000FEFC
		public unsafe SlidingRect Ground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_Ground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x000D3538 File Offset: 0x000D1738
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00011D1B File Offset: 0x0000FF1B
		public unsafe UISpawner CloudSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_CloudSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000D3568 File Offset: 0x000D1768
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00011D3A File Offset: 0x0000FF3A
		public unsafe UISpawner ObstacleSpawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISpawner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ObstacleSpawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000D3598 File Offset: 0x000D1798
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00011D59 File Offset: 0x0000FF59
		public unsafe TextMeshProUGUI ScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_ScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000D35C8 File Offset: 0x000D17C8
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00011D78 File Offset: 0x0000FF78
		public unsafe TextMeshProUGUI HighScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_HighScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000D35F8 File Offset: 0x000D17F8
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x00011D97 File Offset: 0x0000FF97
		public unsafe GameObject StartScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_StartScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000D3628 File Offset: 0x000D1828
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x00011DB6 File Offset: 0x0000FFB6
		public unsafe GameObject GameOverScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_GameOverScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000D3658 File Offset: 0x000D1858
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00011DD5 File Offset: 0x0000FFD5
		public unsafe Animation NewHighScoreAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_NewHighScoreAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x000D3688 File Offset: 0x000D1888
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		public unsafe Sprite JumpSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_JumpSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x000D36B8 File Offset: 0x000D18B8
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x00011E13 File Offset: 0x00010013
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000D36E0 File Offset: 0x000D18E0
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00011E2E File Offset: 0x0001002E
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000D3708 File Offset: 0x000D1908
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00011E49 File Offset: 0x00010049
		public unsafe bool isReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_isReady)) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000D3730 File Offset: 0x000D1930
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00011E64 File Offset: 0x00010064
		public unsafe float score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000D3758 File Offset: 0x000D1958
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00011E7F File Offset: 0x0001007F
		public unsafe float yVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_yVelocity)) = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000D3780 File Offset: 0x000D1980
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x00011E9A File Offset: 0x0001009A
		public unsafe float defaultCharacterY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_defaultCharacterY)) = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000D37A8 File Offset: 0x000D19A8
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00011EB5 File Offset: 0x000100B5
		public unsafe List<UIMover> clouds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_clouds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000D37D8 File Offset: 0x000D19D8
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00011ED4 File Offset: 0x000100D4
		public unsafe List<UIMover> obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMover>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000D3808 File Offset: 0x000D1A08
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00011EF3 File Offset: 0x000100F3
		public unsafe UnityEvent onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000D3838 File Offset: 0x000D1A38
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00011F12 File Offset: 0x00010112
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000D3868 File Offset: 0x000D1A68
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00011F31 File Offset: 0x00010131
		public unsafe UnityEvent onNewHighScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGame.NativeFieldInfoPtr_onNewHighScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_GameSpeed;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr_MinGameSpeed;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_MaxGameSpeed;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_SpeedIncreaseRate;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeFieldInfoPtr_ScoreRate;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_GlobalForceMultiplier;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr_CharacterFlipboard;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_Ground;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_CloudSpawner;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleSpawner;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_ScoreLabel;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_HighScoreLabel;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_StartScreen;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_GameOverScreen;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_NewHighScoreAnimation;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_JumpSprite;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_isReady;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_yVelocity;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_defaultCharacterY;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_clouds;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_obstacles;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_onNewHighScore;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_CloudSpawned_Private_Void_GameObject_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_ObstacleSpawned_Private_Void_GameObject_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_RefreshHighScore_Private_Void_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCollided_Public_Void_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_ResetGame_Private_Void_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
