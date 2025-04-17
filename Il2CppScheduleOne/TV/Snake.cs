using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018B RID: 395
	public class Snake : TVApp
	{
		// Token: 0x06001FDF RID: 8159 RVA: 0x000D39F8 File Offset: 0x000D1BF8
		// Note: this type is marked as 'beforefieldinit'.
		static Snake()
		{
			Il2CppClassPointerStore<Snake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "Snake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snake>.NativeClassPtr);
			Snake.NativeFieldInfoPtr_SIZE_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_X");
			Snake.NativeFieldInfoPtr_SIZE_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "SIZE_Y");
			Snake.NativeFieldInfoPtr_TilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TilePrefab");
			Snake.NativeFieldInfoPtr_TimePerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "TimePerTile");
			Snake.NativeFieldInfoPtr_PlaySpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "PlaySpace");
			Snake.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "Tiles");
			Snake.NativeFieldInfoPtr_ScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "ScoreText");
			Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<HeadPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Tail_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Tail>k__BackingField");
			Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<LastTailPosition>k__BackingField");
			Snake.NativeFieldInfoPtr__Direction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<Direction>k__BackingField");
			Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<QueuedDirection>k__BackingField");
			Snake.NativeFieldInfoPtr__NextDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<NextDirection>k__BackingField");
			Snake.NativeFieldInfoPtr_lastFoodPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "lastFoodPosition");
			Snake.NativeFieldInfoPtr__GameState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "<GameState>k__BackingField");
			Snake.NativeFieldInfoPtr__timeSinceLastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeSinceLastMove");
			Snake.NativeFieldInfoPtr__timeOnGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "_timeOnGameOver");
			Snake.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onStart");
			Snake.NativeFieldInfoPtr_onEat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onEat");
			Snake.NativeFieldInfoPtr_onGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onGameOver");
			Snake.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snake>.NativeClassPtr, "onWin");
			Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666861);
			Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666862);
			Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666863);
			Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666864);
			Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666865);
			Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666866);
			Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666867);
			Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666868);
			Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666869);
			Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666870);
			Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666871);
			Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666872);
			Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666873);
			Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666874);
			Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666875);
			Snake.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666876);
			Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666877);
			Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666878);
			Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666879);
			Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666880);
			Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666881);
			Snake.NativeMethodInfoPtr_Eat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666882);
			Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666883);
			Snake.NativeMethodInfoPtr_GameOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666884);
			Snake.NativeMethodInfoPtr_Win_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666885);
			Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666886);
			Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666887);
			Snake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Snake>.NativeClassPtr, 100666888);
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000D3DFC File Offset: 0x000D1FFC
		// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x000D3E38 File Offset: 0x000D2038
		public unsafe Vector2 HeadPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000D3E78 File Offset: 0x000D2078
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x000D3EB8 File Offset: 0x000D20B8
		public unsafe List<Vector2> Tail
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108446, XrefRangeEnd = 108447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000D3EFC File Offset: 0x000D20FC
		// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x000D3F38 File Offset: 0x000D2138
		public unsafe Vector2 LastTailPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000D3F78 File Offset: 0x000D2178
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x000D3FB4 File Offset: 0x000D21B4
		public unsafe Vector2 Direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x000D3FF4 File Offset: 0x000D21F4
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x000D4030 File Offset: 0x000D2230
		public unsafe Vector2 QueuedDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000D4070 File Offset: 0x000D2270
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x000D40AC File Offset: 0x000D22AC
		public unsafe Vector2 NextDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x000D40EC File Offset: 0x000D22EC
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x000D4128 File Offset: 0x000D2328
		public unsafe Snake.EGameState GameState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 49913, RefRangeEnd = 49917, XrefRangeStart = 49913, XrefRangeEnd = 49917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x000D4168 File Offset: 0x000D2368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108447, XrefRangeEnd = 108448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x000D41A4 File Offset: 0x000D23A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108448, XrefRangeEnd = 108455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000D41D8 File Offset: 0x000D23D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108496, RefRangeEnd = 108497, XrefRangeStart = 108455, XrefRangeEnd = 108496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000D420C File Offset: 0x000D240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108497, XrefRangeEnd = 108499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_UpdateMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000D4240 File Offset: 0x000D2440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108510, RefRangeEnd = 108513, XrefRangeStart = 108499, XrefRangeEnd = 108510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveSnake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_MoveSnake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000D4274 File Offset: 0x000D2474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108513, RefRangeEnd = 108516, XrefRangeStart = 108513, XrefRangeEnd = 108513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile GetTile(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr3) : null;
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000D42C0 File Offset: 0x000D24C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108539, RefRangeEnd = 108540, XrefRangeStart = 108516, XrefRangeEnd = 108539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(Vector2 initialDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initialDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000D4300 File Offset: 0x000D2500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108540, XrefRangeEnd = 108545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Eat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Eat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000D4334 File Offset: 0x000D2534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108562, RefRangeEnd = 108563, XrefRangeStart = 108545, XrefRangeEnd = 108562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnFood()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_SpawnFood_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000D4368 File Offset: 0x000D2568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108563, XrefRangeEnd = 108564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_GameOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000D439C File Offset: 0x000D259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108564, XrefRangeEnd = 108565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_Win_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000D43D0 File Offset: 0x000D25D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108565, XrefRangeEnd = 108567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Snake.NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x000D440C File Offset: 0x000D260C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108567, XrefRangeEnd = 108588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr_CreateTiles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000D4440 File Offset: 0x000D2640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108588, XrefRangeEnd = 108606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Snake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Snake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Snake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00011F97 File Offset: 0x00010197
		public Snake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x000D447C File Offset: 0x000D267C
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00011FA0 File Offset: 0x000101A0
		public unsafe static int SIZE_X
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_X, (void*)(&value));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000D4498 File Offset: 0x000D2698
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x00011FAE File Offset: 0x000101AE
		public unsafe static int SIZE_Y
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Snake.NativeFieldInfoPtr_SIZE_Y, (void*)(&value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x000D44B4 File Offset: 0x000D26B4
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x00011FBC File Offset: 0x000101BC
		public unsafe SnakeTile TilePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SnakeTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TilePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x000D44E4 File Offset: 0x000D26E4
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x00011FDB File Offset: 0x000101DB
		public unsafe float TimePerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_TimePerTile)) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x000D450C File Offset: 0x000D270C
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x00011FF6 File Offset: 0x000101F6
		public unsafe RectTransform PlaySpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_PlaySpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x000D453C File Offset: 0x000D273C
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x00012015 File Offset: 0x00010215
		public unsafe Il2CppReferenceArray<SnakeTile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SnakeTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x000D456C File Offset: 0x000D276C
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00012034 File Offset: 0x00010234
		public unsafe TextMeshProUGUI ScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_ScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x000D459C File Offset: 0x000D279C
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x00012053 File Offset: 0x00010253
		public unsafe Vector2 _HeadPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__HeadPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x000D45C4 File Offset: 0x000D27C4
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x0001206E File Offset: 0x0001026E
		public unsafe List<Vector2> _Tail_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Tail_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x000D45F4 File Offset: 0x000D27F4
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x0001208D File Offset: 0x0001028D
		public unsafe Vector2 _LastTailPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__LastTailPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x000D461C File Offset: 0x000D281C
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x000120A8 File Offset: 0x000102A8
		public unsafe Vector2 _Direction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__Direction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x000D4644 File Offset: 0x000D2844
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x000120C3 File Offset: 0x000102C3
		public unsafe Vector2 _QueuedDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__QueuedDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x000D466C File Offset: 0x000D286C
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x000120DE File Offset: 0x000102DE
		public unsafe Vector2 _NextDirection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__NextDirection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x000D4694 File Offset: 0x000D2894
		// (set) Token: 0x06002018 RID: 8216 RVA: 0x000120F9 File Offset: 0x000102F9
		public unsafe Vector2 lastFoodPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_lastFoodPosition)) = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x000D46BC File Offset: 0x000D28BC
		// (set) Token: 0x0600201A RID: 8218 RVA: 0x00012114 File Offset: 0x00010314
		public unsafe Snake.EGameState _GameState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__GameState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x000D46E4 File Offset: 0x000D28E4
		// (set) Token: 0x0600201C RID: 8220 RVA: 0x0001212F File Offset: 0x0001032F
		public unsafe float _timeSinceLastMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeSinceLastMove)) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x000D470C File Offset: 0x000D290C
		// (set) Token: 0x0600201E RID: 8222 RVA: 0x0001214A File Offset: 0x0001034A
		public unsafe float _timeOnGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr__timeOnGameOver)) = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x000D4734 File Offset: 0x000D2934
		// (set) Token: 0x06002020 RID: 8224 RVA: 0x00012165 File Offset: 0x00010365
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x000D4764 File Offset: 0x000D2964
		// (set) Token: 0x06002022 RID: 8226 RVA: 0x00012184 File Offset: 0x00010384
		public unsafe UnityEvent onEat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onEat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x000D4794 File Offset: 0x000D2994
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x000121A3 File Offset: 0x000103A3
		public unsafe UnityEvent onGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onGameOver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x000D47C4 File Offset: 0x000D29C4
		// (set) Token: 0x06002026 RID: 8230 RVA: 0x000121C2 File Offset: 0x000103C2
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Snake.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_X;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr_SIZE_Y;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr_TilePrefab;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr_TimePerTile;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr_PlaySpace;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr_ScoreText;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeFieldInfoPtr__HeadPosition_k__BackingField;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeFieldInfoPtr__Tail_k__BackingField;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeFieldInfoPtr__LastTailPosition_k__BackingField;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeFieldInfoPtr__Direction_k__BackingField;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeFieldInfoPtr__QueuedDirection_k__BackingField;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeFieldInfoPtr__NextDirection_k__BackingField;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_lastFoodPosition;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr__GameState_k__BackingField;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastMove;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr__timeOnGameOver;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_onEat;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeFieldInfoPtr_onGameOver;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadPosition_Public_get_Vector2_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadPosition_Private_set_Void_Vector2_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_get_Tail_Public_get_List_1_Vector2_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_set_Tail_Private_set_Void_List_1_Vector2_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_get_LastTailPosition_Public_get_Vector2_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_set_LastTailPosition_Private_set_Void_Vector2_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_set_Direction_Private_set_Void_Vector2_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedDirection_Public_get_Vector2_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedDirection_Private_set_Void_Vector2_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_get_NextDirection_Public_get_Vector2_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_set_NextDirection_Private_set_Void_Vector2_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_get_GameState_Public_get_EGameState_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_set_GameState_Private_set_Void_EGameState_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Private_Void_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_MoveSnake_Private_Void_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Private_SnakeTile_Vector2_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Private_Void_Vector2_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_Eat_Private_Void_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_SpawnFood_Private_Void_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_GameOver_Private_Void_0;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeMethodInfoPtr_Win_Private_Void_0;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_Void_0;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr_CreateTiles_Public_Void_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B5 RID: 2229
		[OriginalName("Assembly-CSharp.dll", "", "EGameState")]
		public enum EGameState
		{
			// Token: 0x04008446 RID: 33862
			Ready,
			// Token: 0x04008447 RID: 33863
			Playing
		}
	}
}
