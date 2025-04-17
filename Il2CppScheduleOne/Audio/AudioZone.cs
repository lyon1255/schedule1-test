using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CD RID: 1229
	public class AudioZone : Zone
	{
		// Token: 0x06006BB3 RID: 27571 RVA: 0x001DF3A4 File Offset: 0x001DD5A4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZone()
		{
			Il2CppClassPointerStore<AudioZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone>.NativeClassPtr);
			AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "VOLUME_CHANGE_RATE");
			AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "ROLLOFF_SCALE");
			AudioZone.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "MaxDistance");
			AudioZone.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Tracks");
			AudioZone.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Modifiers");
			AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "<VolumeModifier>k__BackingField");
			AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "CurrentVolumeMultiplier");
			AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676911);
			AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676912);
			AudioZone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676913);
			AudioZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676914);
			AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676915);
			AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676916);
			AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676917);
			AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676918);
			AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676919);
			AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100676920);
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x001DF528 File Offset: 0x001DD728
		// (set) Token: 0x06006BB5 RID: 27573 RVA: 0x001DF564 File Offset: 0x001DD764
		public unsafe float VolumeModifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006BB6 RID: 27574 RVA: 0x001DF5A4 File Offset: 0x001DD7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216021, XrefRangeEnd = 216058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x001DF5D8 File Offset: 0x001DD7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216058, XrefRangeEnd = 216083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x001DF60C File Offset: 0x001DD80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216098, RefRangeEnd = 216099, XrefRangeStart = 216083, XrefRangeEnd = 216098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalVolumeMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BB9 RID: 27577 RVA: 0x001DF648 File Offset: 0x001DD848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216099, XrefRangeEnd = 216124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x001DF67C File Offset: 0x001DD87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216134, RefRangeEnd = 216135, XrefRangeStart = 216124, XrefRangeEnd = 216134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x001DF6CC File Offset: 0x001DD8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216135, XrefRangeEnd = 216141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveModifier(AudioZoneModifierVolume modifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x001DF710 File Offset: 0x001DD910
		[CallerCount(0)]
		public unsafe float GetFalloffFactor(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x001DF75C File Offset: 0x001DD95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216141, XrefRangeEnd = 216156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00032F81 File Offset: 0x00031181
		public AudioZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x001DF798 File Offset: 0x001DD998
		// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x00032F8A File Offset: 0x0003118A
		public unsafe static float VOLUME_CHANGE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&value));
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x001DF7B4 File Offset: 0x001DD9B4
		// (set) Token: 0x06006BC2 RID: 27586 RVA: 0x00032F98 File Offset: 0x00031198
		public unsafe static float ROLLOFF_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x001DF7D0 File Offset: 0x001DD9D0
		// (set) Token: 0x06006BC4 RID: 27588 RVA: 0x00032FA6 File Offset: 0x000311A6
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x001DF7F8 File Offset: 0x001DD9F8
		// (set) Token: 0x06006BC6 RID: 27590 RVA: 0x00032FC1 File Offset: 0x000311C1
		public unsafe List<AudioZone.Track> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone.Track>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x001DF828 File Offset: 0x001DDA28
		// (set) Token: 0x06006BC8 RID: 27592 RVA: 0x00032FE0 File Offset: 0x000311E0
		public unsafe Dictionary<AudioZoneModifierVolume, float> Modifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioZoneModifierVolume, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x001DF858 File Offset: 0x001DDA58
		// (set) Token: 0x06006BCA RID: 27594 RVA: 0x00032FFF File Offset: 0x000311FF
		public unsafe float _VolumeModifier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x001DF880 File Offset: 0x001DDA80
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x0003301A File Offset: 0x0003121A
		public unsafe float CurrentVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier)) = value;
			}
		}

		// Token: 0x040049AF RID: 18863
		private static readonly IntPtr NativeFieldInfoPtr_VOLUME_CHANGE_RATE;

		// Token: 0x040049B0 RID: 18864
		private static readonly IntPtr NativeFieldInfoPtr_ROLLOFF_SCALE;

		// Token: 0x040049B1 RID: 18865
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x040049B2 RID: 18866
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x040049B3 RID: 18867
		private static readonly IntPtr NativeFieldInfoPtr_Modifiers;

		// Token: 0x040049B4 RID: 18868
		private static readonly IntPtr NativeFieldInfoPtr__VolumeModifier_k__BackingField;

		// Token: 0x040049B5 RID: 18869
		private static readonly IntPtr NativeFieldInfoPtr_CurrentVolumeMultiplier;

		// Token: 0x040049B6 RID: 18870
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0;

		// Token: 0x040049B7 RID: 18871
		private static readonly IntPtr NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0;

		// Token: 0x040049B8 RID: 18872
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049B9 RID: 18873
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049BA RID: 18874
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0;

		// Token: 0x040049BB RID: 18875
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040049BC RID: 18876
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0;

		// Token: 0x040049BD RID: 18877
		private static readonly IntPtr NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0;

		// Token: 0x040049BE RID: 18878
		private static readonly IntPtr NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0;

		// Token: 0x040049BF RID: 18879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A59 RID: 2649
		[Serializable]
		public class Track : Object
		{
			// Token: 0x0600D061 RID: 53345 RVA: 0x0031FB00 File Offset: 0x0031DD00
			// Note: this type is marked as 'beforefieldinit'.
			static Track()
			{
				Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Track");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr);
				AudioZone.Track.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Source");
				AudioZone.Track.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Volume");
				AudioZone.Track.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "StartTime");
				AudioZone.Track.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "EndTime");
				AudioZone.Track.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "FadeTime");
				AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "timeVolMultiplier");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEndMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEndMinSum");
				AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676921);
				AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676922);
				AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676923);
				AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100676924);
			}

			// Token: 0x0600D062 RID: 53346 RVA: 0x0031FC94 File Offset: 0x0031DE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216004, XrefRangeEnd = 216012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D063 RID: 53347 RVA: 0x0031FCC8 File Offset: 0x0031DEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216012, XrefRangeEnd = 216015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(float multiplier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref multiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D064 RID: 53348 RVA: 0x0031FD08 File Offset: 0x0031DF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216015, XrefRangeEnd = 216020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTimeMultiplier(int time)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D065 RID: 53349 RVA: 0x0031FD48 File Offset: 0x0031DF48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216020, XrefRangeEnd = 216021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Track() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D066 RID: 53350 RVA: 0x000656AD File Offset: 0x000638AD
			public Track(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B7 RID: 16567
			// (get) Token: 0x0600D067 RID: 53351 RVA: 0x0031FD84 File Offset: 0x0031DF84
			// (set) Token: 0x0600D068 RID: 53352 RVA: 0x000656B6 File Offset: 0x000638B6
			public unsafe AudioSourceController Source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B8 RID: 16568
			// (get) Token: 0x0600D069 RID: 53353 RVA: 0x0031FDB4 File Offset: 0x0031DFB4
			// (set) Token: 0x0600D06A RID: 53354 RVA: 0x000656D5 File Offset: 0x000638D5
			public unsafe float Volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x170040B9 RID: 16569
			// (get) Token: 0x0600D06B RID: 53355 RVA: 0x0031FDDC File Offset: 0x0031DFDC
			// (set) Token: 0x0600D06C RID: 53356 RVA: 0x000656F0 File Offset: 0x000638F0
			public unsafe int StartTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime)) = value;
				}
			}

			// Token: 0x170040BA RID: 16570
			// (get) Token: 0x0600D06D RID: 53357 RVA: 0x0031FE04 File Offset: 0x0031E004
			// (set) Token: 0x0600D06E RID: 53358 RVA: 0x0006570B File Offset: 0x0006390B
			public unsafe int EndTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime)) = value;
				}
			}

			// Token: 0x170040BB RID: 16571
			// (get) Token: 0x0600D06F RID: 53359 RVA: 0x0031FE2C File Offset: 0x0031E02C
			// (set) Token: 0x0600D070 RID: 53360 RVA: 0x00065726 File Offset: 0x00063926
			public unsafe int FadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime)) = value;
				}
			}

			// Token: 0x170040BC RID: 16572
			// (get) Token: 0x0600D071 RID: 53361 RVA: 0x0031FE54 File Offset: 0x0031E054
			// (set) Token: 0x0600D072 RID: 53362 RVA: 0x00065741 File Offset: 0x00063941
			public unsafe float timeVolMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier)) = value;
				}
			}

			// Token: 0x170040BD RID: 16573
			// (get) Token: 0x0600D073 RID: 53363 RVA: 0x0031FE7C File Offset: 0x0031E07C
			// (set) Token: 0x0600D074 RID: 53364 RVA: 0x0006575C File Offset: 0x0006395C
			public unsafe int fadeInStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart)) = value;
				}
			}

			// Token: 0x170040BE RID: 16574
			// (get) Token: 0x0600D075 RID: 53365 RVA: 0x0031FEA4 File Offset: 0x0031E0A4
			// (set) Token: 0x0600D076 RID: 53366 RVA: 0x00065777 File Offset: 0x00063977
			public unsafe int fadeInEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd)) = value;
				}
			}

			// Token: 0x170040BF RID: 16575
			// (get) Token: 0x0600D077 RID: 53367 RVA: 0x0031FECC File Offset: 0x0031E0CC
			// (set) Token: 0x0600D078 RID: 53368 RVA: 0x00065792 File Offset: 0x00063992
			public unsafe int fadeOutStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart)) = value;
				}
			}

			// Token: 0x170040C0 RID: 16576
			// (get) Token: 0x0600D079 RID: 53369 RVA: 0x0031FEF4 File Offset: 0x0031E0F4
			// (set) Token: 0x0600D07A RID: 53370 RVA: 0x000657AD File Offset: 0x000639AD
			public unsafe int fadeOutEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd)) = value;
				}
			}

			// Token: 0x170040C1 RID: 16577
			// (get) Token: 0x0600D07B RID: 53371 RVA: 0x0031FF1C File Offset: 0x0031E11C
			// (set) Token: 0x0600D07C RID: 53372 RVA: 0x000657C8 File Offset: 0x000639C8
			public unsafe int fadeInStartMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum)) = value;
				}
			}

			// Token: 0x170040C2 RID: 16578
			// (get) Token: 0x0600D07D RID: 53373 RVA: 0x0031FF44 File Offset: 0x0031E144
			// (set) Token: 0x0600D07E RID: 53374 RVA: 0x000657E3 File Offset: 0x000639E3
			public unsafe int fadeInEndMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum)) = value;
				}
			}

			// Token: 0x170040C3 RID: 16579
			// (get) Token: 0x0600D07F RID: 53375 RVA: 0x0031FF6C File Offset: 0x0031E16C
			// (set) Token: 0x0600D080 RID: 53376 RVA: 0x000657FE File Offset: 0x000639FE
			public unsafe int fadeOutStartMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum)) = value;
				}
			}

			// Token: 0x170040C4 RID: 16580
			// (get) Token: 0x0600D081 RID: 53377 RVA: 0x0031FF94 File Offset: 0x0031E194
			// (set) Token: 0x0600D082 RID: 53378 RVA: 0x00065819 File Offset: 0x00063A19
			public unsafe int fadeOutEndMinSum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum)) = value;
				}
			}

			// Token: 0x04008CA8 RID: 36008
			private static readonly IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04008CA9 RID: 36009
			private static readonly IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x04008CAA RID: 36010
			private static readonly IntPtr NativeFieldInfoPtr_StartTime;

			// Token: 0x04008CAB RID: 36011
			private static readonly IntPtr NativeFieldInfoPtr_EndTime;

			// Token: 0x04008CAC RID: 36012
			private static readonly IntPtr NativeFieldInfoPtr_FadeTime;

			// Token: 0x04008CAD RID: 36013
			private static readonly IntPtr NativeFieldInfoPtr_timeVolMultiplier;

			// Token: 0x04008CAE RID: 36014
			private static readonly IntPtr NativeFieldInfoPtr_fadeInStart;

			// Token: 0x04008CAF RID: 36015
			private static readonly IntPtr NativeFieldInfoPtr_fadeInEnd;

			// Token: 0x04008CB0 RID: 36016
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutStart;

			// Token: 0x04008CB1 RID: 36017
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutEnd;

			// Token: 0x04008CB2 RID: 36018
			private static readonly IntPtr NativeFieldInfoPtr_fadeInStartMinSum;

			// Token: 0x04008CB3 RID: 36019
			private static readonly IntPtr NativeFieldInfoPtr_fadeInEndMinSum;

			// Token: 0x04008CB4 RID: 36020
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutStartMinSum;

			// Token: 0x04008CB5 RID: 36021
			private static readonly IntPtr NativeFieldInfoPtr_fadeOutEndMinSum;

			// Token: 0x04008CB6 RID: 36022
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

			// Token: 0x04008CB7 RID: 36023
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

			// Token: 0x04008CB8 RID: 36024
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0;

			// Token: 0x04008CB9 RID: 36025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
