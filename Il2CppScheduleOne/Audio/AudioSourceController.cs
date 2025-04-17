using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CB RID: 1227
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x06006B85 RID: 27525 RVA: 0x001DEB00 File Offset: 0x001DCD00
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSourceController()
		{
			Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr);
			AudioSourceController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DEBUG");
			AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "<Volume>k__BackingField");
			AudioSourceController.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioSource");
			AudioSourceController.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioType");
			AudioSourceController.NativeFieldInfoPtr_DefaultVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DefaultVolume");
			AudioSourceController.NativeFieldInfoPtr_RandomizePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "RandomizePitch");
			AudioSourceController.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MinPitch");
			AudioSourceController.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MaxPitch");
			AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "VolumeMultiplier");
			AudioSourceController.NativeFieldInfoPtr_PitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "PitchMultiplier");
			AudioSourceController.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "paused");
			AudioSourceController.NativeFieldInfoPtr_isPlayingCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "isPlayingCached");
			AudioSourceController.NativeFieldInfoPtr_basePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "basePitch");
			AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676893);
			AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676894);
			AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676895);
			AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676896);
			AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676897);
			AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676898);
			AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676899);
			AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676900);
			AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676901);
			AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676902);
			AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676903);
			AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676904);
			AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676905);
			AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676906);
			AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676907);
			AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676908);
			AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676909);
			AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100676910);
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x001DED9C File Offset: 0x001DCF9C
		// (set) Token: 0x06006B87 RID: 27527 RVA: 0x001DEDD8 File Offset: 0x001DCFD8
		public unsafe float Volume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06006B88 RID: 27528 RVA: 0x001DEE18 File Offset: 0x001DD018
		public unsafe bool isPlaying
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 215743, RefRangeEnd = 215770, XrefRangeStart = 215741, XrefRangeEnd = 215743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x001DEE54 File Offset: 0x001DD054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215770, XrefRangeEnd = 215774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x001DEE88 File Offset: 0x001DD088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215774, XrefRangeEnd = 215792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x001DEEBC File Offset: 0x001DD0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215831, RefRangeEnd = 215832, XrefRangeStart = 215792, XrefRangeEnd = 215831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPauseStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x001DEEF0 File Offset: 0x001DD0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215832, XrefRangeEnd = 215850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x001DEF24 File Offset: 0x001DD124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215850, XrefRangeEnd = 215858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x001DEF58 File Offset: 0x001DD158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215858, XrefRangeEnd = 215860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x001DEF8C File Offset: 0x001DD18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215860, XrefRangeEnd = 215862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215862, XrefRangeEnd = 215864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unpause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x001DEFF4 File Offset: 0x001DD1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215864, XrefRangeEnd = 215865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x001DF034 File Offset: 0x001DD234
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 215908, RefRangeEnd = 215920, XrefRangeStart = 215865, XrefRangeEnd = 215908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x001DF068 File Offset: 0x001DD268
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 215924, RefRangeEnd = 215929, XrefRangeStart = 215920, XrefRangeEnd = 215924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x001DF09C File Offset: 0x001DD29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215929, XrefRangeEnd = 215933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x001DF0D8 File Offset: 0x001DD2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215967, RefRangeEnd = 215968, XrefRangeStart = 215933, XrefRangeEnd = 215967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x001DF124 File Offset: 0x001DD324
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 215970, RefRangeEnd = 216003, XrefRangeStart = 215968, XrefRangeEnd = 215970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x001DF158 File Offset: 0x001DD358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216003, XrefRangeEnd = 216004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00032E15 File Offset: 0x00031015
		public AudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06006B99 RID: 27545 RVA: 0x001DF194 File Offset: 0x001DD394
		// (set) Token: 0x06006B9A RID: 27546 RVA: 0x00032E1E File Offset: 0x0003101E
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06006B9B RID: 27547 RVA: 0x001DF1BC File Offset: 0x001DD3BC
		// (set) Token: 0x06006B9C RID: 27548 RVA: 0x00032E39 File Offset: 0x00031039
		public unsafe float _Volume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField)) = value;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x001DF1E4 File Offset: 0x001DD3E4
		// (set) Token: 0x06006B9E RID: 27550 RVA: 0x00032E54 File Offset: 0x00031054
		public unsafe AudioSource AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x001DF214 File Offset: 0x001DD414
		// (set) Token: 0x06006BA0 RID: 27552 RVA: 0x00032E73 File Offset: 0x00031073
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x001DF23C File Offset: 0x001DD43C
		// (set) Token: 0x06006BA2 RID: 27554 RVA: 0x00032E8E File Offset: 0x0003108E
		public unsafe float DefaultVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume)) = value;
			}
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x001DF264 File Offset: 0x001DD464
		// (set) Token: 0x06006BA4 RID: 27556 RVA: 0x00032EA9 File Offset: 0x000310A9
		public unsafe bool RandomizePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch)) = value;
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06006BA5 RID: 27557 RVA: 0x001DF28C File Offset: 0x001DD48C
		// (set) Token: 0x06006BA6 RID: 27558 RVA: 0x00032EC4 File Offset: 0x000310C4
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06006BA7 RID: 27559 RVA: 0x001DF2B4 File Offset: 0x001DD4B4
		// (set) Token: 0x06006BA8 RID: 27560 RVA: 0x00032EDF File Offset: 0x000310DF
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x001DF2DC File Offset: 0x001DD4DC
		// (set) Token: 0x06006BAA RID: 27562 RVA: 0x00032EFA File Offset: 0x000310FA
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x001DF304 File Offset: 0x001DD504
		// (set) Token: 0x06006BAC RID: 27564 RVA: 0x00032F15 File Offset: 0x00031115
		public unsafe float PitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier)) = value;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x001DF32C File Offset: 0x001DD52C
		// (set) Token: 0x06006BAE RID: 27566 RVA: 0x00032F30 File Offset: 0x00031130
		public unsafe bool paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused)) = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x001DF354 File Offset: 0x001DD554
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x00032F4B File Offset: 0x0003114B
		public unsafe bool isPlayingCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached)) = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001DF37C File Offset: 0x001DD57C
		// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x00032F66 File Offset: 0x00031166
		public unsafe float basePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch)) = value;
			}
		}

		// Token: 0x04004989 RID: 18825
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x0400498A RID: 18826
		private static readonly IntPtr NativeFieldInfoPtr__Volume_k__BackingField;

		// Token: 0x0400498B RID: 18827
		private static readonly IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x0400498C RID: 18828
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x0400498D RID: 18829
		private static readonly IntPtr NativeFieldInfoPtr_DefaultVolume;

		// Token: 0x0400498E RID: 18830
		private static readonly IntPtr NativeFieldInfoPtr_RandomizePitch;

		// Token: 0x0400498F RID: 18831
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04004990 RID: 18832
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04004991 RID: 18833
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004992 RID: 18834
		private static readonly IntPtr NativeFieldInfoPtr_PitchMultiplier;

		// Token: 0x04004993 RID: 18835
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04004994 RID: 18836
		private static readonly IntPtr NativeFieldInfoPtr_isPlayingCached;

		// Token: 0x04004995 RID: 18837
		private static readonly IntPtr NativeFieldInfoPtr_basePitch;

		// Token: 0x04004996 RID: 18838
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x04004997 RID: 18839
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0;

		// Token: 0x04004998 RID: 18840
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x04004999 RID: 18841
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400499A RID: 18842
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400499B RID: 18843
		private static readonly IntPtr NativeMethodInfoPtr_DoPauseStuff_Private_Void_0;

		// Token: 0x0400499C RID: 18844
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400499D RID: 18845
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400499E RID: 18846
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400499F RID: 18847
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;

		// Token: 0x040049A0 RID: 18848
		private static readonly IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;

		// Token: 0x040049A1 RID: 18849
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_Single_0;

		// Token: 0x040049A2 RID: 18850
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVolume_Public_Void_0;

		// Token: 0x040049A3 RID: 18851
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPitch_Public_Void_0;

		// Token: 0x040049A4 RID: 18852
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x040049A5 RID: 18853
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040049A6 RID: 18854
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040049A7 RID: 18855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
