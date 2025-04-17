using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CA RID: 1226
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x06006B45 RID: 27461 RVA: 0x001DDE7C File Offset: 0x001DC07C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioManager()
		{
			Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
			AudioManager.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "masterVolume");
			AudioManager.NativeFieldInfoPtr_ambientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "ambientVolume");
			AudioManager.NativeFieldInfoPtr_footstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "footstepsVolume");
			AudioManager.NativeFieldInfoPtr_fxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "fxVolume");
			AudioManager.NativeFieldInfoPtr_uiVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "uiVolume");
			AudioManager.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicVolume");
			AudioManager.NativeFieldInfoPtr_voiceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "voiceVolume");
			AudioManager.NativeFieldInfoPtr_onSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "onSettingsChanged");
			AudioManager.NativeFieldInfoPtr_DoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorOpen");
			AudioManager.NativeFieldInfoPtr_DoorClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorClose");
			AudioManager.NativeFieldInfoPtr_MainGameMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MainGameMixer");
			AudioManager.NativeFieldInfoPtr_MenuMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MenuMixer");
			AudioManager.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MusicMixer");
			AudioManager.NativeFieldInfoPtr_currentGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentGameVolume");
			AudioManager.NativeFieldInfoPtr_minGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "minGameVolume");
			AudioManager.NativeFieldInfoPtr_maxGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "maxGameVolume");
			AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "gameVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DefaultSnapshot");
			AudioManager.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DistortedSnapshot");
			AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676869);
			AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676870);
			AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676871);
			AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676872);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676873);
			AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676874);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676875);
			AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676876);
			AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676877);
			AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676878);
			AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676879);
			AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676880);
			AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676881);
			AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676882);
			AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676883);
			AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676884);
			AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676885);
			AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676886);
			AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676887);
			AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676888);
			AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676889);
			AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676890);
			AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676891);
			AudioManager.NativeMethodInfoPtr__Start_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100676892);
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x001DE208 File Offset: 0x001DC408
		public unsafe float MasterVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06006B47 RID: 27463 RVA: 0x001DE244 File Offset: 0x001DC444
		public unsafe float AmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06006B48 RID: 27464 RVA: 0x001DE280 File Offset: 0x001DC480
		public unsafe float UnscaledAmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06006B49 RID: 27465 RVA: 0x001DE2BC File Offset: 0x001DC4BC
		public unsafe float FootstepsVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x001DE2F8 File Offset: 0x001DC4F8
		public unsafe float UnscaledFootstepsVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30020, RefRangeEnd = 30021, XrefRangeStart = 30020, XrefRangeEnd = 30021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x001DE334 File Offset: 0x001DC534
		public unsafe float FXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x001DE370 File Offset: 0x001DC570
		public unsafe float UnscaledFXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x001DE3AC File Offset: 0x001DC5AC
		public unsafe float UIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x001DE3E8 File Offset: 0x001DC5E8
		public unsafe float UnscaledUIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x001DE424 File Offset: 0x001DC624
		public unsafe float MusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001DE460 File Offset: 0x001DC660
		public unsafe float UnscaledMusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x001DE49C File Offset: 0x001DC69C
		public unsafe float VoiceVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001DE4D8 File Offset: 0x001DC6D8
		public unsafe float UnscaledVoiceVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30023, RefRangeEnd = 30024, XrefRangeStart = 30023, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x001DE514 File Offset: 0x001DC714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215641, XrefRangeEnd = 215659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x001DE550 File Offset: 0x001DC750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215659, XrefRangeEnd = 215686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x001DE58C File Offset: 0x001DC78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215686, XrefRangeEnd = 215702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x001DE5C0 File Offset: 0x001DC7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215702, XrefRangeEnd = 215703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolumeMultipler(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x001DE600 File Offset: 0x001DC800
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 215706, RefRangeEnd = 215714, XrefRangeStart = 215703, XrefRangeEnd = 215706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x001DE64C File Offset: 0x001DC84C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215720, RefRangeEnd = 215724, XrefRangeStart = 215714, XrefRangeEnd = 215720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x001DE68C File Offset: 0x001DC88C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215724, RefRangeEnd = 215725, XrefRangeStart = 215724, XrefRangeEnd = 215724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVolume(EAudioType audioType, bool scaled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref audioType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x001DE6E4 File Offset: 0x001DC8E4
		[CallerCount(0)]
		public unsafe void SetMasterVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B5B RID: 27483 RVA: 0x001DE724 File Offset: 0x001DC924
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 215725, RefRangeEnd = 215731, XrefRangeStart = 215725, XrefRangeEnd = 215725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(EAudioType type, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x001DE770 File Offset: 0x001DC970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215731, XrefRangeEnd = 215739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x001DE7AC File Offset: 0x001DC9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215739, XrefRangeEnd = 215741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__Start_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x00032C05 File Offset: 0x00030E05
		public AudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x001DE7E0 File Offset: 0x001DC9E0
		// (set) Token: 0x06006B60 RID: 27488 RVA: 0x00032C0E File Offset: 0x00030E0E
		public unsafe float masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume)) = value;
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x001DE808 File Offset: 0x001DCA08
		// (set) Token: 0x06006B62 RID: 27490 RVA: 0x00032C29 File Offset: 0x00030E29
		public unsafe float ambientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume)) = value;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x001DE830 File Offset: 0x001DCA30
		// (set) Token: 0x06006B64 RID: 27492 RVA: 0x00032C44 File Offset: 0x00030E44
		public unsafe float footstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume)) = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x001DE858 File Offset: 0x001DCA58
		// (set) Token: 0x06006B66 RID: 27494 RVA: 0x00032C5F File Offset: 0x00030E5F
		public unsafe float fxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume)) = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001DE880 File Offset: 0x001DCA80
		// (set) Token: 0x06006B68 RID: 27496 RVA: 0x00032C7A File Offset: 0x00030E7A
		public unsafe float uiVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume)) = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001DE8A8 File Offset: 0x001DCAA8
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x00032C95 File Offset: 0x00030E95
		public unsafe float musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume)) = value;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x001DE8D0 File Offset: 0x001DCAD0
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x00032CB0 File Offset: 0x00030EB0
		public unsafe float voiceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume)) = value;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x001DE8F8 File Offset: 0x001DCAF8
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x00032CCB File Offset: 0x00030ECB
		public unsafe UnityEvent onSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x001DE928 File Offset: 0x001DCB28
		// (set) Token: 0x06006B70 RID: 27504 RVA: 0x00032CEA File Offset: 0x00030EEA
		public unsafe AudioSourceController DoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x001DE958 File Offset: 0x001DCB58
		// (set) Token: 0x06006B72 RID: 27506 RVA: 0x00032D09 File Offset: 0x00030F09
		public unsafe AudioSourceController DoorClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06006B73 RID: 27507 RVA: 0x001DE988 File Offset: 0x001DCB88
		// (set) Token: 0x06006B74 RID: 27508 RVA: 0x00032D28 File Offset: 0x00030F28
		public unsafe AudioMixerGroup MainGameMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x001DE9B8 File Offset: 0x001DCBB8
		// (set) Token: 0x06006B76 RID: 27510 RVA: 0x00032D47 File Offset: 0x00030F47
		public unsafe AudioMixerGroup MenuMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x001DE9E8 File Offset: 0x001DCBE8
		// (set) Token: 0x06006B78 RID: 27512 RVA: 0x00032D66 File Offset: 0x00030F66
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06006B79 RID: 27513 RVA: 0x001DEA18 File Offset: 0x001DCC18
		// (set) Token: 0x06006B7A RID: 27514 RVA: 0x00032D85 File Offset: 0x00030F85
		public unsafe float currentGameVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume)) = value;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06006B7B RID: 27515 RVA: 0x001DEA40 File Offset: 0x001DCC40
		// (set) Token: 0x06006B7C RID: 27516 RVA: 0x00032DA0 File Offset: 0x00030FA0
		public unsafe static float minGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06006B7D RID: 27517 RVA: 0x001DEA5C File Offset: 0x001DCC5C
		// (set) Token: 0x06006B7E RID: 27518 RVA: 0x00032DAE File Offset: 0x00030FAE
		public unsafe static float maxGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&value));
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06006B7F RID: 27519 RVA: 0x001DEA78 File Offset: 0x001DCC78
		// (set) Token: 0x06006B80 RID: 27520 RVA: 0x00032DBC File Offset: 0x00030FBC
		public unsafe float gameVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06006B81 RID: 27521 RVA: 0x001DEAA0 File Offset: 0x001DCCA0
		// (set) Token: 0x06006B82 RID: 27522 RVA: 0x00032DD7 File Offset: 0x00030FD7
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x001DEAD0 File Offset: 0x001DCCD0
		// (set) Token: 0x06006B84 RID: 27524 RVA: 0x00032DF6 File Offset: 0x00030FF6
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400495E RID: 18782
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x0400495F RID: 18783
		private static readonly IntPtr NativeFieldInfoPtr_ambientVolume;

		// Token: 0x04004960 RID: 18784
		private static readonly IntPtr NativeFieldInfoPtr_footstepsVolume;

		// Token: 0x04004961 RID: 18785
		private static readonly IntPtr NativeFieldInfoPtr_fxVolume;

		// Token: 0x04004962 RID: 18786
		private static readonly IntPtr NativeFieldInfoPtr_uiVolume;

		// Token: 0x04004963 RID: 18787
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x04004964 RID: 18788
		private static readonly IntPtr NativeFieldInfoPtr_voiceVolume;

		// Token: 0x04004965 RID: 18789
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsChanged;

		// Token: 0x04004966 RID: 18790
		private static readonly IntPtr NativeFieldInfoPtr_DoorOpen;

		// Token: 0x04004967 RID: 18791
		private static readonly IntPtr NativeFieldInfoPtr_DoorClose;

		// Token: 0x04004968 RID: 18792
		private static readonly IntPtr NativeFieldInfoPtr_MainGameMixer;

		// Token: 0x04004969 RID: 18793
		private static readonly IntPtr NativeFieldInfoPtr_MenuMixer;

		// Token: 0x0400496A RID: 18794
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x0400496B RID: 18795
		private static readonly IntPtr NativeFieldInfoPtr_currentGameVolume;

		// Token: 0x0400496C RID: 18796
		private static readonly IntPtr NativeFieldInfoPtr_minGameVolume;

		// Token: 0x0400496D RID: 18797
		private static readonly IntPtr NativeFieldInfoPtr_maxGameVolume;

		// Token: 0x0400496E RID: 18798
		private static readonly IntPtr NativeFieldInfoPtr_gameVolumeMultiplier;

		// Token: 0x0400496F RID: 18799
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x04004970 RID: 18800
		private static readonly IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x04004971 RID: 18801
		private static readonly IntPtr NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0;

		// Token: 0x04004972 RID: 18802
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0;

		// Token: 0x04004973 RID: 18803
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0;

		// Token: 0x04004974 RID: 18804
		private static readonly IntPtr NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0;

		// Token: 0x04004975 RID: 18805
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0;

		// Token: 0x04004976 RID: 18806
		private static readonly IntPtr NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0;

		// Token: 0x04004977 RID: 18807
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0;

		// Token: 0x04004978 RID: 18808
		private static readonly IntPtr NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0;

		// Token: 0x04004979 RID: 18809
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0;

		// Token: 0x0400497A RID: 18810
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0;

		// Token: 0x0400497B RID: 18811
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0;

		// Token: 0x0400497C RID: 18812
		private static readonly IntPtr NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0;

		// Token: 0x0400497D RID: 18813
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0;

		// Token: 0x0400497E RID: 18814
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400497F RID: 18815
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004980 RID: 18816
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04004981 RID: 18817
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0;

		// Token: 0x04004982 RID: 18818
		private static readonly IntPtr NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004983 RID: 18819
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0;

		// Token: 0x04004984 RID: 18820
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0;

		// Token: 0x04004985 RID: 18821
		private static readonly IntPtr NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0;

		// Token: 0x04004986 RID: 18822
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0;

		// Token: 0x04004987 RID: 18823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004988 RID: 18824
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__46_0_Private_Void_0;
	}
}
