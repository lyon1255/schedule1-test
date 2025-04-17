using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000633 RID: 1587
	public class DemoIntro : Singleton<DemoIntro>
	{
		// Token: 0x06008C23 RID: 35875 RVA: 0x00249BB0 File Offset: 0x00247DB0
		// Note: this type is marked as 'beforefieldinit'.
		static DemoIntro()
		{
			Il2CppClassPointerStore<DemoIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DemoIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr);
			DemoIntro.NativeFieldInfoPtr_SKIP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SKIP_TIME");
			DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DemoIntro.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "Anim");
			DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "PlayerInitialPosition");
			DemoIntro.NativeFieldInfoPtr_SkipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipContainer");
			DemoIntro.NativeFieldInfoPtr_SkipDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipDial");
			DemoIntro.NativeFieldInfoPtr_SkipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipEvents");
			DemoIntro.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onStart");
			DemoIntro.NativeFieldInfoPtr_onStartAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onStartAsServer");
			DemoIntro.NativeFieldInfoPtr_onCutsceneDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onCutsceneDone");
			DemoIntro.NativeFieldInfoPtr_onIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onIntroDone");
			DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onIntroDoneAsServer");
			DemoIntro.NativeFieldInfoPtr_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "CurrentStep");
			DemoIntro.NativeFieldInfoPtr_MusicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "MusicName");
			DemoIntro.NativeFieldInfoPtr_currentSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "currentSkipTime");
			DemoIntro.NativeFieldInfoPtr_depressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "depressed");
			DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "waitingForCutsceneEnd");
			DemoIntro.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680706);
			DemoIntro.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680707);
			DemoIntro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680708);
			DemoIntro.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680709);
			DemoIntro.NativeMethodInfoPtr_PlayMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680710);
			DemoIntro.NativeMethodInfoPtr_ShowAvatar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680711);
			DemoIntro.NativeMethodInfoPtr_CutsceneDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680712);
			DemoIntro.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680713);
			DemoIntro.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680714);
			DemoIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680715);
			DemoIntro.NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680716);
			DemoIntro.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100680717);
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x06008C24 RID: 35876 RVA: 0x00249E24 File Offset: 0x00248024
		// (set) Token: 0x06008C25 RID: 35877 RVA: 0x00249E60 File Offset: 0x00248060
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x00249EA0 File Offset: 0x002480A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256244, XrefRangeEnd = 256290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x00249ED4 File Offset: 0x002480D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256290, XrefRangeEnd = 256321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x00249F08 File Offset: 0x00248108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256321, XrefRangeEnd = 256339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_PlayMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x00249F3C File Offset: 0x0024813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256339, XrefRangeEnd = 256348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_ShowAvatar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x00249F70 File Offset: 0x00248170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256348, XrefRangeEnd = 256366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CutsceneDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_CutsceneDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x00249FA4 File Offset: 0x002481A4
		[CallerCount(0)]
		public unsafe void PassedStep(int stepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stepIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00249FE4 File Offset: 0x002481E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256366, XrefRangeEnd = 256372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterCreationDone(BasicAvatarSettings avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x0024A028 File Offset: 0x00248228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256372, XrefRangeEnd = 256375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoIntro() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x0024A064 File Offset: 0x00248264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256375, XrefRangeEnd = 256377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayMusic_b__22_0(MusicTrack t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x0024A0B4 File Offset: 0x002482B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256377, XrefRangeEnd = 256382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00043260 File Offset: 0x00041460
		public DemoIntro(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x06008C31 RID: 35889 RVA: 0x0024A0F4 File Offset: 0x002482F4
		// (set) Token: 0x06008C32 RID: 35890 RVA: 0x00043269 File Offset: 0x00041469
		public unsafe static float SKIP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DemoIntro.NativeFieldInfoPtr_SKIP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DemoIntro.NativeFieldInfoPtr_SKIP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x06008C33 RID: 35891 RVA: 0x0024A110 File Offset: 0x00248310
		// (set) Token: 0x06008C34 RID: 35892 RVA: 0x00043277 File Offset: 0x00041477
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x0024A138 File Offset: 0x00248338
		// (set) Token: 0x06008C36 RID: 35894 RVA: 0x00043292 File Offset: 0x00041492
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x06008C37 RID: 35895 RVA: 0x0024A168 File Offset: 0x00248368
		// (set) Token: 0x06008C38 RID: 35896 RVA: 0x000432B1 File Offset: 0x000414B1
		public unsafe Transform PlayerInitialPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x06008C39 RID: 35897 RVA: 0x0024A198 File Offset: 0x00248398
		// (set) Token: 0x06008C3A RID: 35898 RVA: 0x000432D0 File Offset: 0x000414D0
		public unsafe GameObject SkipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x06008C3B RID: 35899 RVA: 0x0024A1C8 File Offset: 0x002483C8
		// (set) Token: 0x06008C3C RID: 35900 RVA: 0x000432EF File Offset: 0x000414EF
		public unsafe Image SkipDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipDial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipDial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x0024A1F8 File Offset: 0x002483F8
		// (set) Token: 0x06008C3E RID: 35902 RVA: 0x0004330E File Offset: 0x0004150E
		public unsafe int SkipEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipEvents)) = value;
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x06008C3F RID: 35903 RVA: 0x0024A220 File Offset: 0x00248420
		// (set) Token: 0x06008C40 RID: 35904 RVA: 0x00043329 File Offset: 0x00041529
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x06008C41 RID: 35905 RVA: 0x0024A250 File Offset: 0x00248450
		// (set) Token: 0x06008C42 RID: 35906 RVA: 0x00043348 File Offset: 0x00041548
		public unsafe UnityEvent onStartAsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStartAsServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStartAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x0024A280 File Offset: 0x00248480
		// (set) Token: 0x06008C44 RID: 35908 RVA: 0x00043367 File Offset: 0x00041567
		public unsafe UnityEvent onCutsceneDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onCutsceneDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onCutsceneDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x06008C45 RID: 35909 RVA: 0x0024A2B0 File Offset: 0x002484B0
		// (set) Token: 0x06008C46 RID: 35910 RVA: 0x00043386 File Offset: 0x00041586
		public unsafe UnityEvent onIntroDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x0024A2E0 File Offset: 0x002484E0
		// (set) Token: 0x06008C48 RID: 35912 RVA: 0x000433A5 File Offset: 0x000415A5
		public unsafe UnityEvent onIntroDoneAsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x0024A310 File Offset: 0x00248510
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x000433C4 File Offset: 0x000415C4
		public unsafe int CurrentStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_CurrentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_CurrentStep)) = value;
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x0024A338 File Offset: 0x00248538
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x000433DF File Offset: 0x000415DF
		public unsafe string MusicName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_MusicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_MusicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x0024A360 File Offset: 0x00248560
		// (set) Token: 0x06008C4E RID: 35918 RVA: 0x000433FE File Offset: 0x000415FE
		public unsafe float currentSkipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_currentSkipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_currentSkipTime)) = value;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x06008C4F RID: 35919 RVA: 0x0024A388 File Offset: 0x00248588
		// (set) Token: 0x06008C50 RID: 35920 RVA: 0x00043419 File Offset: 0x00041619
		public unsafe bool depressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_depressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_depressed)) = value;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x0024A3B0 File Offset: 0x002485B0
		// (set) Token: 0x06008C52 RID: 35922 RVA: 0x00043434 File Offset: 0x00041634
		public unsafe bool waitingForCutsceneEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd)) = value;
			}
		}

		// Token: 0x04005F01 RID: 24321
		private static readonly IntPtr NativeFieldInfoPtr_SKIP_TIME;

		// Token: 0x04005F02 RID: 24322
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04005F03 RID: 24323
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005F04 RID: 24324
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInitialPosition;

		// Token: 0x04005F05 RID: 24325
		private static readonly IntPtr NativeFieldInfoPtr_SkipContainer;

		// Token: 0x04005F06 RID: 24326
		private static readonly IntPtr NativeFieldInfoPtr_SkipDial;

		// Token: 0x04005F07 RID: 24327
		private static readonly IntPtr NativeFieldInfoPtr_SkipEvents;

		// Token: 0x04005F08 RID: 24328
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04005F09 RID: 24329
		private static readonly IntPtr NativeFieldInfoPtr_onStartAsServer;

		// Token: 0x04005F0A RID: 24330
		private static readonly IntPtr NativeFieldInfoPtr_onCutsceneDone;

		// Token: 0x04005F0B RID: 24331
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDone;

		// Token: 0x04005F0C RID: 24332
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDoneAsServer;

		// Token: 0x04005F0D RID: 24333
		private static readonly IntPtr NativeFieldInfoPtr_CurrentStep;

		// Token: 0x04005F0E RID: 24334
		private static readonly IntPtr NativeFieldInfoPtr_MusicName;

		// Token: 0x04005F0F RID: 24335
		private static readonly IntPtr NativeFieldInfoPtr_currentSkipTime;

		// Token: 0x04005F10 RID: 24336
		private static readonly IntPtr NativeFieldInfoPtr_depressed;

		// Token: 0x04005F11 RID: 24337
		private static readonly IntPtr NativeFieldInfoPtr_waitingForCutsceneEnd;

		// Token: 0x04005F12 RID: 24338
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04005F13 RID: 24339
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005F14 RID: 24340
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F15 RID: 24341
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04005F16 RID: 24342
		private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Private_Void_0;

		// Token: 0x04005F17 RID: 24343
		private static readonly IntPtr NativeMethodInfoPtr_ShowAvatar_Public_Void_0;

		// Token: 0x04005F18 RID: 24344
		private static readonly IntPtr NativeMethodInfoPtr_CutsceneDone_Public_Void_0;

		// Token: 0x04005F19 RID: 24345
		private static readonly IntPtr NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0;

		// Token: 0x04005F1A RID: 24346
		private static readonly IntPtr NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0;

		// Token: 0x04005F1B RID: 24347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F1C RID: 24348
		private static readonly IntPtr NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0;

		// Token: 0x04005F1D RID: 24349
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B1A RID: 2842
		[ObfuscatedName("ScheduleOne.UI.DemoIntro+<<CharacterCreationDone>g__Wait|26_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D6F8 RID: 55032 RVA: 0x003323C0 File Offset: 0x003305C0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique()
			{
				Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "<<CharacterCreationDone>g__Wait|26_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>1__state");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>2__current");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>4__this");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680718);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680719);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680720);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680721);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680722);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100680723);
			}

			// Token: 0x0600D6F9 RID: 55033 RVA: 0x003324A0 File Offset: 0x003306A0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6FA RID: 55034 RVA: 0x003324E8 File Offset: 0x003306E8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6FB RID: 55035 RVA: 0x0033251C File Offset: 0x0033071C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256195, XrefRangeEnd = 256239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700429B RID: 17051
			// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x00332558 File Offset: 0x00330758
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6FD RID: 55037 RVA: 0x00332598 File Offset: 0x00330798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256239, XrefRangeEnd = 256244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700429C RID: 17052
			// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x003325CC File Offset: 0x003307CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6FF RID: 55039 RVA: 0x00068A1A File Offset: 0x00066C1A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004298 RID: 17048
			// (get) Token: 0x0600D700 RID: 55040 RVA: 0x0033260C File Offset: 0x0033080C
			// (set) Token: 0x0600D701 RID: 55041 RVA: 0x00068A23 File Offset: 0x00066C23
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004299 RID: 17049
			// (get) Token: 0x0600D702 RID: 55042 RVA: 0x00332634 File Offset: 0x00330834
			// (set) Token: 0x0600D703 RID: 55043 RVA: 0x00068A3E File Offset: 0x00066C3E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429A RID: 17050
			// (get) Token: 0x0600D704 RID: 55044 RVA: 0x00332664 File Offset: 0x00330864
			// (set) Token: 0x0600D705 RID: 55045 RVA: 0x00068A5D File Offset: 0x00066C5D
			public unsafe DemoIntro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DemoIntro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400908A RID: 37002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400908B RID: 37003
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400908C RID: 37004
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400908D RID: 37005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400908E RID: 37006
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400908F RID: 37007
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009090 RID: 37008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009091 RID: 37009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009092 RID: 37010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
