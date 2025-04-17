using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000663 RID: 1635
	public class QuestHUDUI : MonoBehaviour
	{
		// Token: 0x060091F1 RID: 37361 RVA: 0x0025AC1C File Offset: 0x00258E1C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestHUDUI()
		{
			Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "QuestHUDUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr);
			QuestHUDUI.NativeFieldInfoPtr_CriticalTimeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "CriticalTimeColor");
			QuestHUDUI.NativeFieldInfoPtr__Quest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "<Quest>k__BackingField");
			QuestHUDUI.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "EntryContainer");
			QuestHUDUI.NativeFieldInfoPtr_MainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "MainLabel");
			QuestHUDUI.NativeFieldInfoPtr_hudUILayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "hudUILayout");
			QuestHUDUI.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "Animation");
			QuestHUDUI.NativeFieldInfoPtr_Shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "Shade");
			QuestHUDUI.NativeFieldInfoPtr_onUpdateUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "onUpdateUI");
			QuestHUDUI.NativeMethodInfoPtr_get_Quest_Public_get_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681400);
			QuestHUDUI.NativeMethodInfoPtr_set_Quest_Private_set_Void_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681401);
			QuestHUDUI.NativeMethodInfoPtr_Initialize_Public_Void_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681402);
			QuestHUDUI.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681403);
			QuestHUDUI.NativeMethodInfoPtr_UpdateUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681404);
			QuestHUDUI.NativeMethodInfoPtr_UpdateMainLabel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681405);
			QuestHUDUI.NativeMethodInfoPtr_UpdateExpiry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681406);
			QuestHUDUI.NativeMethodInfoPtr_UpdateShade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681407);
			QuestHUDUI.NativeMethodInfoPtr_BopIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681408);
			QuestHUDUI.NativeMethodInfoPtr_FadeIn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681409);
			QuestHUDUI.NativeMethodInfoPtr_EntryEnded_Private_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681410);
			QuestHUDUI.NativeMethodInfoPtr_FadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681411);
			QuestHUDUI.NativeMethodInfoPtr_Complete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681412);
			QuestHUDUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681413);
			QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681414);
			QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681415);
			QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, 100681416);
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x060091F2 RID: 37362 RVA: 0x0025AE40 File Offset: 0x00259040
		// (set) Token: 0x060091F3 RID: 37363 RVA: 0x0025AE80 File Offset: 0x00259080
		public unsafe Quest Quest
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_get_Quest_Public_get_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_set_Quest_Private_set_Void_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x0025AEC4 File Offset: 0x002590C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263788, RefRangeEnd = 263789, XrefRangeStart = 263734, XrefRangeEnd = 263788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Quest quest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(quest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Initialize_Public_Void_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x0025AF08 File Offset: 0x00259108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263789, XrefRangeEnd = 263805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x0025AF3C File Offset: 0x0025913C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 263828, RefRangeEnd = 263836, XrefRangeStart = 263805, XrefRangeEnd = 263828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_UpdateUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x0025AF70 File Offset: 0x00259170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263836, XrefRangeEnd = 263838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMainLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_UpdateMainLabel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x0025AFA4 File Offset: 0x002591A4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_UpdateExpiry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x0025AFD8 File Offset: 0x002591D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263838, XrefRangeEnd = 263840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_UpdateShade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x0025B00C File Offset: 0x0025920C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263849, RefRangeEnd = 263851, XrefRangeStart = 263840, XrefRangeEnd = 263849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_BopIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x0025B040 File Offset: 0x00259240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263851, XrefRangeEnd = 263857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_FadeIn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x0025B074 File Offset: 0x00259274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263857, XrefRangeEnd = 263872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryEnded(EQuestState endState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_EntryEnded_Private_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x0025B0B4 File Offset: 0x002592B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263886, RefRangeEnd = 263887, XrefRangeStart = 263872, XrefRangeEnd = 263886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_FadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x0025B0E8 File Offset: 0x002592E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263887, XrefRangeEnd = 263901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Complete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x0025B11C File Offset: 0x0025931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263901, XrefRangeEnd = 263906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestHUDUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x0025B158 File Offset: 0x00259358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263906, XrefRangeEnd = 263911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x0025B198 File Offset: 0x00259398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263911, XrefRangeEnd = 263916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x0025B1D8 File Offset: 0x002593D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263916, XrefRangeEnd = 263921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x0004691D File Offset: 0x00044B1D
		public QuestHUDUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x06009204 RID: 37380 RVA: 0x0025B218 File Offset: 0x00259418
		// (set) Token: 0x06009205 RID: 37381 RVA: 0x00046926 File Offset: 0x00044B26
		public unsafe string CriticalTimeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_CriticalTimeColor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_CriticalTimeColor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x06009206 RID: 37382 RVA: 0x0025B240 File Offset: 0x00259440
		// (set) Token: 0x06009207 RID: 37383 RVA: 0x00046945 File Offset: 0x00044B45
		public unsafe Quest _Quest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr__Quest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr__Quest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x06009208 RID: 37384 RVA: 0x0025B270 File Offset: 0x00259470
		// (set) Token: 0x06009209 RID: 37385 RVA: 0x00046964 File Offset: 0x00044B64
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600920A RID: 37386 RVA: 0x0025B2A0 File Offset: 0x002594A0
		// (set) Token: 0x0600920B RID: 37387 RVA: 0x00046983 File Offset: 0x00044B83
		public unsafe TextMeshProUGUI MainLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_MainLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_MainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0600920C RID: 37388 RVA: 0x0025B2D0 File Offset: 0x002594D0
		// (set) Token: 0x0600920D RID: 37389 RVA: 0x000469A2 File Offset: 0x00044BA2
		public unsafe VerticalLayoutGroup hudUILayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_hudUILayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_hudUILayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0600920E RID: 37390 RVA: 0x0025B300 File Offset: 0x00259500
		// (set) Token: 0x0600920F RID: 37391 RVA: 0x000469C1 File Offset: 0x00044BC1
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x06009210 RID: 37392 RVA: 0x0025B330 File Offset: 0x00259530
		// (set) Token: 0x06009211 RID: 37393 RVA: 0x000469E0 File Offset: 0x00044BE0
		public unsafe RectTransform Shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_Shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_Shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x06009212 RID: 37394 RVA: 0x0025B360 File Offset: 0x00259560
		// (set) Token: 0x06009213 RID: 37395 RVA: 0x000469FF File Offset: 0x00044BFF
		public unsafe Action onUpdateUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_onUpdateUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.NativeFieldInfoPtr_onUpdateUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400629D RID: 25245
		private static readonly IntPtr NativeFieldInfoPtr_CriticalTimeColor;

		// Token: 0x0400629E RID: 25246
		private static readonly IntPtr NativeFieldInfoPtr__Quest_k__BackingField;

		// Token: 0x0400629F RID: 25247
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x040062A0 RID: 25248
		private static readonly IntPtr NativeFieldInfoPtr_MainLabel;

		// Token: 0x040062A1 RID: 25249
		private static readonly IntPtr NativeFieldInfoPtr_hudUILayout;

		// Token: 0x040062A2 RID: 25250
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040062A3 RID: 25251
		private static readonly IntPtr NativeFieldInfoPtr_Shade;

		// Token: 0x040062A4 RID: 25252
		private static readonly IntPtr NativeFieldInfoPtr_onUpdateUI;

		// Token: 0x040062A5 RID: 25253
		private static readonly IntPtr NativeMethodInfoPtr_get_Quest_Public_get_Quest_0;

		// Token: 0x040062A6 RID: 25254
		private static readonly IntPtr NativeMethodInfoPtr_set_Quest_Private_set_Void_Quest_0;

		// Token: 0x040062A7 RID: 25255
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Quest_0;

		// Token: 0x040062A8 RID: 25256
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040062A9 RID: 25257
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Void_0;

		// Token: 0x040062AA RID: 25258
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMainLabel_Public_Void_0;

		// Token: 0x040062AB RID: 25259
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExpiry_Public_Void_0;

		// Token: 0x040062AC RID: 25260
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShade_Public_Void_0;

		// Token: 0x040062AD RID: 25261
		private static readonly IntPtr NativeMethodInfoPtr_BopIcon_Public_Void_0;

		// Token: 0x040062AE RID: 25262
		private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Private_Void_0;

		// Token: 0x040062AF RID: 25263
		private static readonly IntPtr NativeMethodInfoPtr_EntryEnded_Private_Void_EQuestState_0;

		// Token: 0x040062B0 RID: 25264
		private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Private_Void_0;

		// Token: 0x040062B1 RID: 25265
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Private_Void_0;

		// Token: 0x040062B2 RID: 25266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040062B3 RID: 25267
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040062B4 RID: 25268
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x040062B5 RID: 25269
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x02000B4A RID: 2890
		[ObfuscatedName("ScheduleOne.UI.QuestHUDUI+<<Complete>g__Routine|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D954 RID: 55636 RVA: 0x00338FF8 File Offset: 0x003371F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "<<Complete>g__Routine|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681417);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681418);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681419);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681420);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681421);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr, 100681422);
			}

			// Token: 0x0600D955 RID: 55637 RVA: 0x003390D8 File Offset: 0x003372D8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D956 RID: 55638 RVA: 0x00339120 File Offset: 0x00337320
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D957 RID: 55639 RVA: 0x00339154 File Offset: 0x00337354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263702, XrefRangeEnd = 263707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004370 RID: 17264
			// (get) Token: 0x0600D958 RID: 55640 RVA: 0x00339190 File Offset: 0x00337390
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D959 RID: 55641 RVA: 0x003391D0 File Offset: 0x003373D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263707, XrefRangeEnd = 263712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004371 RID: 17265
			// (get) Token: 0x0600D95A RID: 55642 RVA: 0x00339204 File Offset: 0x00337404
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D95B RID: 55643 RVA: 0x00069DD6 File Offset: 0x00067FD6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0600D95C RID: 55644 RVA: 0x00339244 File Offset: 0x00337444
			// (set) Token: 0x0600D95D RID: 55645 RVA: 0x00069DDF File Offset: 0x00067FDF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700436E RID: 17262
			// (get) Token: 0x0600D95E RID: 55646 RVA: 0x0033926C File Offset: 0x0033746C
			// (set) Token: 0x0600D95F RID: 55647 RVA: 0x00069DFA File Offset: 0x00067FFA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436F RID: 17263
			// (get) Token: 0x0600D960 RID: 55648 RVA: 0x0033929C File Offset: 0x0033749C
			// (set) Token: 0x0600D961 RID: 55649 RVA: 0x00069E19 File Offset: 0x00068019
			public unsafe QuestHUDUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091FC RID: 37372
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091FD RID: 37373
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040091FE RID: 37374
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091FF RID: 37375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009200 RID: 37376
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009201 RID: 37377
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009202 RID: 37378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009203 RID: 37379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009204 RID: 37380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B4B RID: 2891
		[ObfuscatedName("ScheduleOne.UI.QuestHUDUI+<<FadeOut>g__Routine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D962 RID: 55650 RVA: 0x003392CC File Offset: 0x003374CC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "<<FadeOut>g__Routine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681423);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681424);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681425);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681426);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681427);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr, 100681428);
			}

			// Token: 0x0600D963 RID: 55651 RVA: 0x003393AC File Offset: 0x003375AC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D964 RID: 55652 RVA: 0x003393F4 File Offset: 0x003375F4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D965 RID: 55653 RVA: 0x00339428 File Offset: 0x00337628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263712, XrefRangeEnd = 263717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004375 RID: 17269
			// (get) Token: 0x0600D966 RID: 55654 RVA: 0x00339464 File Offset: 0x00337664
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D967 RID: 55655 RVA: 0x003394A4 File Offset: 0x003376A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263717, XrefRangeEnd = 263722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004376 RID: 17270
			// (get) Token: 0x0600D968 RID: 55656 RVA: 0x003394D8 File Offset: 0x003376D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D969 RID: 55657 RVA: 0x00069E38 File Offset: 0x00068038
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004372 RID: 17266
			// (get) Token: 0x0600D96A RID: 55658 RVA: 0x00339518 File Offset: 0x00337718
			// (set) Token: 0x0600D96B RID: 55659 RVA: 0x00069E41 File Offset: 0x00068041
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004373 RID: 17267
			// (get) Token: 0x0600D96C RID: 55660 RVA: 0x00339540 File Offset: 0x00337740
			// (set) Token: 0x0600D96D RID: 55661 RVA: 0x00069E5C File Offset: 0x0006805C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0600D96E RID: 55662 RVA: 0x00339570 File Offset: 0x00337770
			// (set) Token: 0x0600D96F RID: 55663 RVA: 0x00069E7B File Offset: 0x0006807B
			public unsafe QuestHUDUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009205 RID: 37381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009206 RID: 37382
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009207 RID: 37383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009208 RID: 37384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009209 RID: 37385
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400920A RID: 37386
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400920B RID: 37387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400920C RID: 37388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400920D RID: 37389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B4C RID: 2892
		[ObfuscatedName("ScheduleOne.UI.QuestHUDUI+<<UpdateUI>g__DelayFix|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600D970 RID: 55664 RVA: 0x003395A0 File Offset: 0x003377A0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2()
			{
				Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestHUDUI>.NativeClassPtr, "<<UpdateUI>g__DelayFix|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, "<>1__state");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, "<>2__current");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, "<>4__this");
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681429);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681430);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681431);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681432);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681433);
				QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr, 100681434);
			}

			// Token: 0x0600D971 RID: 55665 RVA: 0x00339680 File Offset: 0x00337880
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D972 RID: 55666 RVA: 0x003396C8 File Offset: 0x003378C8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D973 RID: 55667 RVA: 0x003396FC File Offset: 0x003378FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263722, XrefRangeEnd = 263729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700437A RID: 17274
			// (get) Token: 0x0600D974 RID: 55668 RVA: 0x00339738 File Offset: 0x00337938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D975 RID: 55669 RVA: 0x00339778 File Offset: 0x00337978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263729, XrefRangeEnd = 263734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700437B RID: 17275
			// (get) Token: 0x0600D976 RID: 55670 RVA: 0x003397AC File Offset: 0x003379AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D977 RID: 55671 RVA: 0x00069E9A File Offset: 0x0006809A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004377 RID: 17271
			// (get) Token: 0x0600D978 RID: 55672 RVA: 0x003397EC File Offset: 0x003379EC
			// (set) Token: 0x0600D979 RID: 55673 RVA: 0x00069EA3 File Offset: 0x000680A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004378 RID: 17272
			// (get) Token: 0x0600D97A RID: 55674 RVA: 0x00339814 File Offset: 0x00337A14
			// (set) Token: 0x0600D97B RID: 55675 RVA: 0x00069EBE File Offset: 0x000680BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004379 RID: 17273
			// (get) Token: 0x0600D97C RID: 55676 RVA: 0x00339844 File Offset: 0x00337A44
			// (set) Token: 0x0600D97D RID: 55677 RVA: 0x00069EDD File Offset: 0x000680DD
			public unsafe QuestHUDUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestHUDUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400920E RID: 37390
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400920F RID: 37391
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009210 RID: 37392
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009211 RID: 37393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009212 RID: 37394
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009213 RID: 37395
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009214 RID: 37396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009215 RID: 37397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009216 RID: 37398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
