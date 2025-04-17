using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000664 RID: 1636
	public class RankUpCanvas : MonoBehaviour
	{
		// Token: 0x06009214 RID: 37396 RVA: 0x0025B390 File Offset: 0x00259590
		// Note: this type is marked as 'beforefieldinit'.
		static RankUpCanvas()
		{
			Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RankUpCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr);
			RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OpenCloseAnim");
			RankUpCanvas.NativeFieldInfoPtr_RankUpAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "RankUpAnim");
			RankUpCanvas.NativeFieldInfoPtr_OldRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OldRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_NewRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "NewRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "Canvas");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItemsContainer");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItems");
			RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ExtraUnlocksLabel");
			RankUpCanvas.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "SoundEffect");
			RankUpCanvas.NativeFieldInfoPtr_ProgressSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressSlider");
			RankUpCanvas.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressLabel");
			RankUpCanvas.NativeFieldInfoPtr_BlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "BlipSound");
			RankUpCanvas.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ClickSound");
			RankUpCanvas.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "coroutine");
			RankUpCanvas.NativeFieldInfoPtr_queuedRankUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "queuedRankUps");
			RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681435);
			RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681436);
			RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681437);
			RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681438);
			RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681439);
			RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681440);
			RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681441);
			RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681442);
			RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681443);
			RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681444);
			RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681445);
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06009215 RID: 37397 RVA: 0x0025B5F0 File Offset: 0x002597F0
		// (set) Token: 0x06009216 RID: 37398 RVA: 0x0025B62C File Offset: 0x0025982C
		public unsafe virtual bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x06009217 RID: 37399 RVA: 0x0025B66C File Offset: 0x0025986C
		// (set) Token: 0x06009218 RID: 37400 RVA: 0x0025B6A8 File Offset: 0x002598A8
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x0025B6E8 File Offset: 0x002598E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264036, XrefRangeEnd = 264068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x0025B71C File Offset: 0x0025991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264068, XrefRangeEnd = 264074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePostSleepEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x0025B750 File Offset: 0x00259950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264074, XrefRangeEnd = 264157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x0025B784 File Offset: 0x00259984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264157, XrefRangeEnd = 264166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x0025B7B8 File Offset: 0x002599B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264166, XrefRangeEnd = 264175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x0025B804 File Offset: 0x00259A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264230, RefRangeEnd = 264231, XrefRangeStart = 264175, XrefRangeEnd = 264230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x0025B860 File Offset: 0x00259A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264231, XrefRangeEnd = 264239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankUpCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x00046A1E File Offset: 0x00044C1E
		public RankUpCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x0025B89C File Offset: 0x00259A9C
		// (set) Token: 0x06009222 RID: 37410 RVA: 0x00046A27 File Offset: 0x00044C27
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x0025B8C4 File Offset: 0x00259AC4
		// (set) Token: 0x06009224 RID: 37412 RVA: 0x00046A42 File Offset: 0x00044C42
		public unsafe int _Order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x0025B8EC File Offset: 0x00259AEC
		// (set) Token: 0x06009226 RID: 37414 RVA: 0x00046A5D File Offset: 0x00044C5D
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x06009227 RID: 37415 RVA: 0x0025B91C File Offset: 0x00259B1C
		// (set) Token: 0x06009228 RID: 37416 RVA: 0x00046A7C File Offset: 0x00044C7C
		public unsafe Animation RankUpAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x0025B94C File Offset: 0x00259B4C
		// (set) Token: 0x0600922A RID: 37418 RVA: 0x00046A9B File Offset: 0x00044C9B
		public unsafe TextMeshProUGUI OldRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600922B RID: 37419 RVA: 0x0025B97C File Offset: 0x00259B7C
		// (set) Token: 0x0600922C RID: 37420 RVA: 0x00046ABA File Offset: 0x00044CBA
		public unsafe TextMeshProUGUI NewRankLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x0025B9AC File Offset: 0x00259BAC
		// (set) Token: 0x0600922E RID: 37422 RVA: 0x00046AD9 File Offset: 0x00044CD9
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600922F RID: 37423 RVA: 0x0025B9DC File Offset: 0x00259BDC
		// (set) Token: 0x06009230 RID: 37424 RVA: 0x00046AF8 File Offset: 0x00044CF8
		public unsafe GameObject UnlockedItemsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x06009231 RID: 37425 RVA: 0x0025BA0C File Offset: 0x00259C0C
		// (set) Token: 0x06009232 RID: 37426 RVA: 0x00046B17 File Offset: 0x00044D17
		public unsafe Il2CppReferenceArray<RectTransform> UnlockedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x0025BA3C File Offset: 0x00259C3C
		// (set) Token: 0x06009234 RID: 37428 RVA: 0x00046B36 File Offset: 0x00044D36
		public unsafe TextMeshProUGUI ExtraUnlocksLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x0025BA6C File Offset: 0x00259C6C
		// (set) Token: 0x06009236 RID: 37430 RVA: 0x00046B55 File Offset: 0x00044D55
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x06009237 RID: 37431 RVA: 0x0025BA9C File Offset: 0x00259C9C
		// (set) Token: 0x06009238 RID: 37432 RVA: 0x00046B74 File Offset: 0x00044D74
		public unsafe Slider ProgressSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x0025BACC File Offset: 0x00259CCC
		// (set) Token: 0x0600923A RID: 37434 RVA: 0x00046B93 File Offset: 0x00044D93
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600923B RID: 37435 RVA: 0x0025BAFC File Offset: 0x00259CFC
		// (set) Token: 0x0600923C RID: 37436 RVA: 0x00046BB2 File Offset: 0x00044DB2
		public unsafe AudioSourceController BlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600923D RID: 37437 RVA: 0x0025BB2C File Offset: 0x00259D2C
		// (set) Token: 0x0600923E RID: 37438 RVA: 0x00046BD1 File Offset: 0x00044DD1
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600923F RID: 37439 RVA: 0x0025BB5C File Offset: 0x00259D5C
		// (set) Token: 0x06009240 RID: 37440 RVA: 0x00046BF0 File Offset: 0x00044DF0
		public unsafe Coroutine coroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06009241 RID: 37441 RVA: 0x0025BB8C File Offset: 0x00259D8C
		// (set) Token: 0x06009242 RID: 37442 RVA: 0x00046C0F File Offset: 0x00044E0F
		public unsafe List<Tuple<FullRank, FullRank>> queuedRankUps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, FullRank>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040062B6 RID: 25270
		private static readonly IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x040062B7 RID: 25271
		private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x040062B8 RID: 25272
		private static readonly IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x040062B9 RID: 25273
		private static readonly IntPtr NativeFieldInfoPtr_RankUpAnim;

		// Token: 0x040062BA RID: 25274
		private static readonly IntPtr NativeFieldInfoPtr_OldRankLabel;

		// Token: 0x040062BB RID: 25275
		private static readonly IntPtr NativeFieldInfoPtr_NewRankLabel;

		// Token: 0x040062BC RID: 25276
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040062BD RID: 25277
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItemsContainer;

		// Token: 0x040062BE RID: 25278
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedItems;

		// Token: 0x040062BF RID: 25279
		private static readonly IntPtr NativeFieldInfoPtr_ExtraUnlocksLabel;

		// Token: 0x040062C0 RID: 25280
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x040062C1 RID: 25281
		private static readonly IntPtr NativeFieldInfoPtr_ProgressSlider;

		// Token: 0x040062C2 RID: 25282
		private static readonly IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x040062C3 RID: 25283
		private static readonly IntPtr NativeFieldInfoPtr_BlipSound;

		// Token: 0x040062C4 RID: 25284
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x040062C5 RID: 25285
		private static readonly IntPtr NativeFieldInfoPtr_coroutine;

		// Token: 0x040062C6 RID: 25286
		private static readonly IntPtr NativeFieldInfoPtr_queuedRankUps;

		// Token: 0x040062C7 RID: 25287
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040062C8 RID: 25288
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x040062C9 RID: 25289
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040062CA RID: 25290
		private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x040062CB RID: 25291
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040062CC RID: 25292
		private static readonly IntPtr NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0;

		// Token: 0x040062CD RID: 25293
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x040062CE RID: 25294
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x040062CF RID: 25295
		private static readonly IntPtr NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0;

		// Token: 0x040062D0 RID: 25296
		private static readonly IntPtr NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0;

		// Token: 0x040062D1 RID: 25297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4D RID: 2893
		[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D97E RID: 55678 RVA: 0x00339874 File Offset: 0x00337A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr);
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "progressDisplays");
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681446);
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681447);
			}

			// Token: 0x0600D97F RID: 55679 RVA: 0x003398F0 File Offset: 0x00337AF0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D980 RID: 55680 RVA: 0x0033992C File Offset: 0x00337B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264031, XrefRangeEnd = 264036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D981 RID: 55681 RVA: 0x00069EFC File Offset: 0x000680FC
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437C RID: 17276
			// (get) Token: 0x0600D982 RID: 55682 RVA: 0x0033996C File Offset: 0x00337B6C
			// (set) Token: 0x0600D983 RID: 55683 RVA: 0x00069F05 File Offset: 0x00068105
			public unsafe List<Tuple<FullRank, int, int>> progressDisplays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<FullRank, int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437D RID: 17277
			// (get) Token: 0x0600D984 RID: 55684 RVA: 0x0033999C File Offset: 0x00337B9C
			// (set) Token: 0x0600D985 RID: 55685 RVA: 0x00069F24 File Offset: 0x00068124
			public unsafe RankUpCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009217 RID: 37399
			private static readonly IntPtr NativeFieldInfoPtr_progressDisplays;

			// Token: 0x04009218 RID: 37400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009219 RID: 37401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400921A RID: 37402
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C78 RID: 3192
			[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0+<<StartEvent>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E5B5 RID: 58805 RVA: 0x0035CBBC File Offset: 0x0035ADBC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique()
				{
					Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<<StartEvent>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>1__state");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>2__current");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>4__this");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<rankSoundPlayed>5__2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>7__wrap2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<progress>5__4");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<oldRank>5__5");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<newRank>5__6");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<startXP>5__7");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<endXP>5__8");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<lerpTime>5__9");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<xpForRank>5__10");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipSpacing>5__11");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipTime>5__12");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<i>5__13");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681448);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681449);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681450);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681451);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681452);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681453);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681454);
				}

				// Token: 0x0600E5B6 RID: 58806 RVA: 0x0035CDA0 File Offset: 0x0035AFA0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5B7 RID: 58807 RVA: 0x0035CDE8 File Offset: 0x0035AFE8
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 263926, RefRangeEnd = 263927, XrefRangeStart = 263921, XrefRangeEnd = 263926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E5B8 RID: 58808 RVA: 0x0035CE1C File Offset: 0x0035B01C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263927, XrefRangeEnd = 264023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E5B9 RID: 58809 RVA: 0x0035CE58 File Offset: 0x0035B058
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264023, XrefRangeEnd = 264026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004781 RID: 18305
				// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x0035CE8C File Offset: 0x0035B08C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5BB RID: 58811 RVA: 0x0035CECC File Offset: 0x0035B0CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264026, XrefRangeEnd = 264031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004782 RID: 18306
				// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x0035CF00 File Offset: 0x0035B100
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E5BD RID: 58813 RVA: 0x000700D5 File Offset: 0x0006E2D5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004772 RID: 18290
				// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x0035CF40 File Offset: 0x0035B140
				// (set) Token: 0x0600E5BF RID: 58815 RVA: 0x000700DE File Offset: 0x0006E2DE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004773 RID: 18291
				// (get) Token: 0x0600E5C0 RID: 58816 RVA: 0x0035CF68 File Offset: 0x0035B168
				// (set) Token: 0x0600E5C1 RID: 58817 RVA: 0x000700F9 File Offset: 0x0006E2F9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004774 RID: 18292
				// (get) Token: 0x0600E5C2 RID: 58818 RVA: 0x0035CF98 File Offset: 0x0035B198
				// (set) Token: 0x0600E5C3 RID: 58819 RVA: 0x00070118 File Offset: 0x0006E318
				public unsafe RankUpCanvas.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004775 RID: 18293
				// (get) Token: 0x0600E5C4 RID: 58820 RVA: 0x0035CFC8 File Offset: 0x0035B1C8
				// (set) Token: 0x0600E5C5 RID: 58821 RVA: 0x00070137 File Offset: 0x0006E337
				public unsafe bool _rankSoundPlayed_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2)) = value;
					}
				}

				// Token: 0x17004776 RID: 18294
				// (get) Token: 0x0600E5C6 RID: 58822 RVA: 0x0035CFF0 File Offset: 0x0035B1F0
				// (set) Token: 0x0600E5C7 RID: 58823 RVA: 0x00070152 File Offset: 0x0006E352
				public List<Tuple<FullRank, int, int>>.Enumerator __7__wrap2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2);
						return new List<Tuple<FullRank, int, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17004777 RID: 18295
				// (get) Token: 0x0600E5C8 RID: 58824 RVA: 0x0035D020 File Offset: 0x0035B220
				// (set) Token: 0x0600E5C9 RID: 58825 RVA: 0x00070180 File Offset: 0x0006E380
				public unsafe Tuple<FullRank, int, int> _progress_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<FullRank, int, int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004778 RID: 18296
				// (get) Token: 0x0600E5CA RID: 58826 RVA: 0x0035D050 File Offset: 0x0035B250
				// (set) Token: 0x0600E5CB RID: 58827 RVA: 0x0007019F File Offset: 0x0006E39F
				public unsafe FullRank _oldRank_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5)) = value;
					}
				}

				// Token: 0x17004779 RID: 18297
				// (get) Token: 0x0600E5CC RID: 58828 RVA: 0x0035D078 File Offset: 0x0035B278
				// (set) Token: 0x0600E5CD RID: 58829 RVA: 0x000701BA File Offset: 0x0006E3BA
				public unsafe FullRank _newRank_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6)) = value;
					}
				}

				// Token: 0x1700477A RID: 18298
				// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x0035D0A0 File Offset: 0x0035B2A0
				// (set) Token: 0x0600E5CF RID: 58831 RVA: 0x000701D5 File Offset: 0x0006E3D5
				public unsafe int _startXP_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7)) = value;
					}
				}

				// Token: 0x1700477B RID: 18299
				// (get) Token: 0x0600E5D0 RID: 58832 RVA: 0x0035D0C8 File Offset: 0x0035B2C8
				// (set) Token: 0x0600E5D1 RID: 58833 RVA: 0x000701F0 File Offset: 0x0006E3F0
				public unsafe int _endXP_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8)) = value;
					}
				}

				// Token: 0x1700477C RID: 18300
				// (get) Token: 0x0600E5D2 RID: 58834 RVA: 0x0035D0F0 File Offset: 0x0035B2F0
				// (set) Token: 0x0600E5D3 RID: 58835 RVA: 0x0007020B File Offset: 0x0006E40B
				public unsafe float _lerpTime_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9)) = value;
					}
				}

				// Token: 0x1700477D RID: 18301
				// (get) Token: 0x0600E5D4 RID: 58836 RVA: 0x0035D118 File Offset: 0x0035B318
				// (set) Token: 0x0600E5D5 RID: 58837 RVA: 0x00070226 File Offset: 0x0006E426
				public unsafe int _xpForRank_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10)) = value;
					}
				}

				// Token: 0x1700477E RID: 18302
				// (get) Token: 0x0600E5D6 RID: 58838 RVA: 0x0035D140 File Offset: 0x0035B340
				// (set) Token: 0x0600E5D7 RID: 58839 RVA: 0x00070241 File Offset: 0x0006E441
				public unsafe float _blipSpacing_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11)) = value;
					}
				}

				// Token: 0x1700477F RID: 18303
				// (get) Token: 0x0600E5D8 RID: 58840 RVA: 0x0035D168 File Offset: 0x0035B368
				// (set) Token: 0x0600E5D9 RID: 58841 RVA: 0x0007025C File Offset: 0x0006E45C
				public unsafe float _blipTime_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12)) = value;
					}
				}

				// Token: 0x17004780 RID: 18304
				// (get) Token: 0x0600E5DA RID: 58842 RVA: 0x0035D190 File Offset: 0x0035B390
				// (set) Token: 0x0600E5DB RID: 58843 RVA: 0x00070277 File Offset: 0x0006E477
				public unsafe float _i_5__13
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13)) = value;
					}
				}

				// Token: 0x04009994 RID: 39316
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009995 RID: 39317
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009996 RID: 39318
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009997 RID: 39319
				private static readonly IntPtr NativeFieldInfoPtr__rankSoundPlayed_5__2;

				// Token: 0x04009998 RID: 39320
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x04009999 RID: 39321
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__4;

				// Token: 0x0400999A RID: 39322
				private static readonly IntPtr NativeFieldInfoPtr__oldRank_5__5;

				// Token: 0x0400999B RID: 39323
				private static readonly IntPtr NativeFieldInfoPtr__newRank_5__6;

				// Token: 0x0400999C RID: 39324
				private static readonly IntPtr NativeFieldInfoPtr__startXP_5__7;

				// Token: 0x0400999D RID: 39325
				private static readonly IntPtr NativeFieldInfoPtr__endXP_5__8;

				// Token: 0x0400999E RID: 39326
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__9;

				// Token: 0x0400999F RID: 39327
				private static readonly IntPtr NativeFieldInfoPtr__xpForRank_5__10;

				// Token: 0x040099A0 RID: 39328
				private static readonly IntPtr NativeFieldInfoPtr__blipSpacing_5__11;

				// Token: 0x040099A1 RID: 39329
				private static readonly IntPtr NativeFieldInfoPtr__blipTime_5__12;

				// Token: 0x040099A2 RID: 39330
				private static readonly IntPtr NativeFieldInfoPtr__i_5__13;

				// Token: 0x040099A3 RID: 39331
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099A4 RID: 39332
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099A5 RID: 39333
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099A6 RID: 39334
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x040099A7 RID: 39335
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099A8 RID: 39336
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099A9 RID: 39337
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
