using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Intro
{
	// Token: 0x020003EE RID: 1006
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x0600530B RID: 21259 RVA: 0x00187F80 File Offset: 0x00186180
		// Note: this type is marked as 'beforefieldinit'.
		static IntroManager()
		{
			Il2CppClassPointerStore<IntroManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Intro", "IntroManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager>.NativeClassPtr);
			IntroManager.NativeFieldInfoPtr_SKIP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SKIP_TIME");
			IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<IsPlaying>k__BackingField");
			IntroManager.NativeFieldInfoPtr_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CurrentStep");
			IntroManager.NativeFieldInfoPtr_TimeOfDayOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "TimeOfDayOverride");
			IntroManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Container");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition_AfterRVExplosion");
			IntroManager.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CameraContainer");
			IntroManager.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Anim");
			IntroManager.NativeFieldInfoPtr_SkipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipContainer");
			IntroManager.NativeFieldInfoPtr_SkipDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipDial");
			IntroManager.NativeFieldInfoPtr_DisableDuringIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "DisableDuringIntro");
			IntroManager.NativeFieldInfoPtr_rv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "rv");
			IntroManager.NativeFieldInfoPtr_onIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDone");
			IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDoneAsServer");
			IntroManager.NativeFieldInfoPtr_MusicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "MusicName");
			IntroManager.NativeFieldInfoPtr_currentSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "currentSkipTime");
			IntroManager.NativeFieldInfoPtr_depressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "depressed");
			IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673682);
			IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673683);
			IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673684);
			IntroManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673685);
			IntroManager.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673686);
			IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673687);
			IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673688);
			IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673689);
			IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673690);
			IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673691);
			IntroManager.NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673692);
			IntroManager.NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673693);
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x0600530C RID: 21260 RVA: 0x00188208 File Offset: 0x00186408
		// (set) Token: 0x0600530D RID: 21261 RVA: 0x00188244 File Offset: 0x00186444
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00188284 File Offset: 0x00186484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178710, XrefRangeEnd = 178716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x001882C0 File Offset: 0x001864C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178716, XrefRangeEnd = 178739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x001882F4 File Offset: 0x001864F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178803, RefRangeEnd = 178804, XrefRangeStart = 178739, XrefRangeEnd = 178803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00188328 File Offset: 0x00186528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178804, XrefRangeEnd = 178822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x0018835C File Offset: 0x0018655C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178822, XrefRangeEnd = 178835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x001883B0 File Offset: 0x001865B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178835, RefRangeEnd = 178836, XrefRangeStart = 178835, XrefRangeEnd = 178835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassedStep(int stepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stepIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x001883F0 File Offset: 0x001865F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178836, XrefRangeEnd = 178839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntroManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x0018842C File Offset: 0x0018662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178839, XrefRangeEnd = 178844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0018846C File Offset: 0x0018666C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178844, XrefRangeEnd = 178845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Play_b__23_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x001884A8 File Offset: 0x001866A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178845, XrefRangeEnd = 178847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayMusic_b__24_0(MusicTrack t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00027918 File Offset: 0x00025B18
		public IntroManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x001884F8 File Offset: 0x001866F8
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x00027921 File Offset: 0x00025B21
		public unsafe static float SKIP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntroManager.NativeFieldInfoPtr_SKIP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntroManager.NativeFieldInfoPtr_SKIP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x00188514 File Offset: 0x00186714
		// (set) Token: 0x0600531C RID: 21276 RVA: 0x0002792F File Offset: 0x00025B2F
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600531D RID: 21277 RVA: 0x0018853C File Offset: 0x0018673C
		// (set) Token: 0x0600531E RID: 21278 RVA: 0x0002794A File Offset: 0x00025B4A
		public unsafe int CurrentStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep)) = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x00188564 File Offset: 0x00186764
		// (set) Token: 0x06005320 RID: 21280 RVA: 0x00027965 File Offset: 0x00025B65
		public unsafe int TimeOfDayOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride)) = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x06005321 RID: 21281 RVA: 0x0018858C File Offset: 0x0018678C
		// (set) Token: 0x06005322 RID: 21282 RVA: 0x00027980 File Offset: 0x00025B80
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x06005323 RID: 21283 RVA: 0x001885BC File Offset: 0x001867BC
		// (set) Token: 0x06005324 RID: 21284 RVA: 0x0002799F File Offset: 0x00025B9F
		public unsafe Transform PlayerInitialPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x001885EC File Offset: 0x001867EC
		// (set) Token: 0x06005326 RID: 21286 RVA: 0x000279BE File Offset: 0x00025BBE
		public unsafe Transform PlayerInitialPosition_AfterRVExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x0018861C File Offset: 0x0018681C
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x000279DD File Offset: 0x00025BDD
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x0018864C File Offset: 0x0018684C
		// (set) Token: 0x0600532A RID: 21290 RVA: 0x000279FC File Offset: 0x00025BFC
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x0600532B RID: 21291 RVA: 0x0018867C File Offset: 0x0018687C
		// (set) Token: 0x0600532C RID: 21292 RVA: 0x00027A1B File Offset: 0x00025C1B
		public unsafe GameObject SkipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x0600532D RID: 21293 RVA: 0x001886AC File Offset: 0x001868AC
		// (set) Token: 0x0600532E RID: 21294 RVA: 0x00027A3A File Offset: 0x00025C3A
		public unsafe Image SkipDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x0600532F RID: 21295 RVA: 0x001886DC File Offset: 0x001868DC
		// (set) Token: 0x06005330 RID: 21296 RVA: 0x00027A59 File Offset: 0x00025C59
		public unsafe Il2CppReferenceArray<GameObject> DisableDuringIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x0018870C File Offset: 0x0018690C
		// (set) Token: 0x06005332 RID: 21298 RVA: 0x00027A78 File Offset: 0x00025C78
		public unsafe RV rv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x0018873C File Offset: 0x0018693C
		// (set) Token: 0x06005334 RID: 21300 RVA: 0x00027A97 File Offset: 0x00025C97
		public unsafe UnityEvent onIntroDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x0018876C File Offset: 0x0018696C
		// (set) Token: 0x06005336 RID: 21302 RVA: 0x00027AB6 File Offset: 0x00025CB6
		public unsafe UnityEvent onIntroDoneAsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x0018879C File Offset: 0x0018699C
		// (set) Token: 0x06005338 RID: 21304 RVA: 0x00027AD5 File Offset: 0x00025CD5
		public unsafe string MusicName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x001887C4 File Offset: 0x001869C4
		// (set) Token: 0x0600533A RID: 21306 RVA: 0x00027AF4 File Offset: 0x00025CF4
		public unsafe float currentSkipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime)) = value;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x001887EC File Offset: 0x001869EC
		// (set) Token: 0x0600533C RID: 21308 RVA: 0x00027B0F File Offset: 0x00025D0F
		public unsafe bool depressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed)) = value;
			}
		}

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeFieldInfoPtr_SKIP_TIME;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeFieldInfoPtr_CurrentStep;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDayOverride;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInitialPosition;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeFieldInfoPtr_SkipContainer;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeFieldInfoPtr_SkipDial;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeFieldInfoPtr_DisableDuringIntro;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeFieldInfoPtr_rv;

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDone;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDoneAsServer;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeFieldInfoPtr_MusicName;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeFieldInfoPtr_currentSkipTime;

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeFieldInfoPtr_depressed;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Private_Void_0;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0;

		// Token: 0x020009AE RID: 2478
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<<Play>g__Wait|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CBA5 RID: 52133 RVA: 0x00312754 File Offset: 0x00310954
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<<Play>g__Wait|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673694);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673695);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673696);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673697);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673698);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673699);
			}

			// Token: 0x0600CBA6 RID: 52134 RVA: 0x00312834 File Offset: 0x00310A34
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBA7 RID: 52135 RVA: 0x0031287C File Offset: 0x00310A7C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBA8 RID: 52136 RVA: 0x003128B0 File Offset: 0x00310AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178475, XrefRangeEnd = 178600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F74 RID: 16244
			// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x003128EC File Offset: 0x00310AEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBAA RID: 52138 RVA: 0x0031292C File Offset: 0x00310B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178600, XrefRangeEnd = 178605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F75 RID: 16245
			// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x00312960 File Offset: 0x00310B60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CBAC RID: 52140 RVA: 0x0006310A File Offset: 0x0006130A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F71 RID: 16241
			// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x003129A0 File Offset: 0x00310BA0
			// (set) Token: 0x0600CBAE RID: 52142 RVA: 0x00063113 File Offset: 0x00061313
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F72 RID: 16242
			// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x003129C8 File Offset: 0x00310BC8
			// (set) Token: 0x0600CBB0 RID: 52144 RVA: 0x0006312E File Offset: 0x0006132E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F73 RID: 16243
			// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x003129F8 File Offset: 0x00310BF8
			// (set) Token: 0x0600CBB2 RID: 52146 RVA: 0x0006314D File Offset: 0x0006134D
			public unsafe IntroManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089AE RID: 35246
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089AF RID: 35247
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089B0 RID: 35248
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089B1 RID: 35249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089B2 RID: 35250
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089B3 RID: 35251
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089B4 RID: 35252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089B5 RID: 35253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089B6 RID: 35254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009AF RID: 2479
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBB3 RID: 52147 RVA: 0x00312A28 File Offset: 0x00310C28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr);
				IntroManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9");
				IntroManager.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9__23_1");
				IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100673701);
				IntroManager.__c.NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100673702);
			}

			// Token: 0x0600CBB4 RID: 52148 RVA: 0x00312AA4 File Offset: 0x00310CA4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBB5 RID: 52149 RVA: 0x00312AE0 File Offset: 0x00310CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178605, XrefRangeEnd = 178609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__23_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CBB6 RID: 52150 RVA: 0x0006316C File Offset: 0x0006136C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F76 RID: 16246
			// (get) Token: 0x0600CBB7 RID: 52151 RVA: 0x00312B1C File Offset: 0x00310D1C
			// (set) Token: 0x0600CBB8 RID: 52152 RVA: 0x00063175 File Offset: 0x00061375
			public unsafe static IntroManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F77 RID: 16247
			// (get) Token: 0x0600CBB9 RID: 52153 RVA: 0x00312B44 File Offset: 0x00310D44
			// (set) Token: 0x0600CBBA RID: 52154 RVA: 0x00063187 File Offset: 0x00061387
			public unsafe static Func<bool> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089B7 RID: 35255
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089B8 RID: 35256
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x040089B9 RID: 35257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089BA RID: 35258
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0;
		}

		// Token: 0x020009B0 RID: 2480
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBBB RID: 52155 RVA: 0x00312B6C File Offset: 0x00310D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr);
				IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "clothes");
				IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, 100673703);
				IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, 100673704);
			}

			// Token: 0x0600CBBC RID: 52156 RVA: 0x00312BE8 File Offset: 0x00310DE8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CBBD RID: 52157 RVA: 0x00312C24 File Offset: 0x00310E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178705, XrefRangeEnd = 178710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CBBE RID: 52158 RVA: 0x00063199 File Offset: 0x00061399
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F78 RID: 16248
			// (get) Token: 0x0600CBBF RID: 52159 RVA: 0x00312C64 File Offset: 0x00310E64
			// (set) Token: 0x0600CBC0 RID: 52160 RVA: 0x000631A2 File Offset: 0x000613A2
			public unsafe IntroManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F79 RID: 16249
			// (get) Token: 0x0600CBC1 RID: 52161 RVA: 0x00312C94 File Offset: 0x00310E94
			// (set) Token: 0x0600CBC2 RID: 52162 RVA: 0x000631C1 File Offset: 0x000613C1
			public unsafe List<ClothingInstance> clothes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089BB RID: 35259
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089BC RID: 35260
			private static readonly IntPtr NativeFieldInfoPtr_clothes;

			// Token: 0x040089BD RID: 35261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089BE RID: 35262
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C48 RID: 3144
			[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c__DisplayClass25_0+<<CharacterCreationDone>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E2A7 RID: 58023 RVA: 0x0035380C File Offset: 0x00351A0C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "<<CharacterCreationDone>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673705);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673706);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673707);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673708);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673709);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673710);
				}

				// Token: 0x0600E2A8 RID: 58024 RVA: 0x003538EC File Offset: 0x00351AEC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2A9 RID: 58025 RVA: 0x00353934 File Offset: 0x00351B34
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E2AA RID: 58026 RVA: 0x00353968 File Offset: 0x00351B68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178609, XrefRangeEnd = 178700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004651 RID: 18001
				// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x003539A4 File Offset: 0x00351BA4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2AC RID: 58028 RVA: 0x003539E4 File Offset: 0x00351BE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178700, XrefRangeEnd = 178705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004652 RID: 18002
				// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x00353A18 File Offset: 0x00351C18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E2AE RID: 58030 RVA: 0x0006E820 File Offset: 0x0006CA20
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700464E RID: 17998
				// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x00353A58 File Offset: 0x00351C58
				// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x0006E829 File Offset: 0x0006CA29
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700464F RID: 17999
				// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x00353A80 File Offset: 0x00351C80
				// (set) Token: 0x0600E2B2 RID: 58034 RVA: 0x0006E844 File Offset: 0x0006CA44
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004650 RID: 18000
				// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x00353AB0 File Offset: 0x00351CB0
				// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x0006E863 File Offset: 0x0006CA63
				public unsafe IntroManager.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097B3 RID: 38835
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097B4 RID: 38836
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097B5 RID: 38837
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097B6 RID: 38838
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097B7 RID: 38839
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097B8 RID: 38840
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097B9 RID: 38841
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040097BA RID: 38842
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097BB RID: 38843
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
