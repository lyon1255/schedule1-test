using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Audio;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D4 RID: 1236
	public class MusicPlayer : PersistentSingleton<MusicPlayer>
	{
		// Token: 0x06006C20 RID: 27680 RVA: 0x001E06E0 File Offset: 0x001DE8E0
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayer()
		{
			Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr);
			MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "TimeSinceLastAmbientTrack");
			MusicPlayer.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "Tracks");
			MusicPlayer.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "MusicMixer");
			MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DefaultSnapshot");
			MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DistortedSnapshot");
			MusicPlayer.NativeFieldInfoPtr__currentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "_currentTrack");
			MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676963);
			MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676964);
			MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676965);
			MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676966);
			MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676967);
			MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676968);
			MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676969);
			MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676970);
			MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676971);
			MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676972);
			MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100676974);
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x001E0864 File Offset: 0x001DEA64
		public unsafe bool IsPlaying
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 216572, RefRangeEnd = 216574, XrefRangeStart = 216568, XrefRangeEnd = 216572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x001E08A0 File Offset: 0x001DEAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216574, XrefRangeEnd = 216595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x001E08D4 File Offset: 0x001DEAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216595, XrefRangeEnd = 216626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x001E0910 File Offset: 0x001DEB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216626, XrefRangeEnd = 216632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x001E0944 File Offset: 0x001DEB44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 216635, RefRangeEnd = 216643, XrefRangeStart = 216632, XrefRangeEnd = 216635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x001E0990 File Offset: 0x001DEB90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216663, RefRangeEnd = 216669, XrefRangeStart = 216643, XrefRangeEnd = 216663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrackEnabled(string trackName, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x001E09E0 File Offset: 0x001DEBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216695, RefRangeEnd = 216696, XrefRangeStart = 216669, XrefRangeEnd = 216695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x001E0A24 File Offset: 0x001DEC24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216710, RefRangeEnd = 216712, XrefRangeStart = 216696, XrefRangeEnd = 216710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAndDisableTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x001E0A58 File Offset: 0x001DEC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216712, XrefRangeEnd = 216748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x001E0A8C File Offset: 0x001DEC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216748, XrefRangeEnd = 216758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x001E0AC8 File Offset: 0x001DECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216758, XrefRangeEnd = 216760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x00033304 File Offset: 0x00031504
		public MusicPlayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x001E0AFC File Offset: 0x001DECFC
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0003330D File Offset: 0x0003150D
		public unsafe static float TimeSinceLastAmbientTrack
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&value));
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x001E0B18 File Offset: 0x001DED18
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x0003331B File Offset: 0x0003151B
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06006C31 RID: 27697 RVA: 0x001E0B48 File Offset: 0x001DED48
		// (set) Token: 0x06006C32 RID: 27698 RVA: 0x0003333A File Offset: 0x0003153A
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x001E0B78 File Offset: 0x001DED78
		// (set) Token: 0x06006C34 RID: 27700 RVA: 0x00033359 File Offset: 0x00031559
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06006C35 RID: 27701 RVA: 0x001E0BA8 File Offset: 0x001DEDA8
		// (set) Token: 0x06006C36 RID: 27702 RVA: 0x00033378 File Offset: 0x00031578
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06006C37 RID: 27703 RVA: 0x001E0BD8 File Offset: 0x001DEDD8
		// (set) Token: 0x06006C38 RID: 27704 RVA: 0x00033397 File Offset: 0x00031597
		public unsafe MusicTrack _currentTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049EF RID: 18927
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastAmbientTrack;

		// Token: 0x040049F0 RID: 18928
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x040049F1 RID: 18929
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x040049F2 RID: 18930
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x040049F3 RID: 18931
		private static readonly IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x040049F4 RID: 18932
		private static readonly IntPtr NativeFieldInfoPtr__currentTrack;

		// Token: 0x040049F5 RID: 18933
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040049F6 RID: 18934
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x040049F7 RID: 18935
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040049F8 RID: 18936
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049F9 RID: 18937
		private static readonly IntPtr NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x040049FA RID: 18938
		private static readonly IntPtr NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0;

		// Token: 0x040049FB RID: 18939
		private static readonly IntPtr NativeMethodInfoPtr_StopTrack_Public_Void_String_0;

		// Token: 0x040049FC RID: 18940
		private static readonly IntPtr NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0;

		// Token: 0x040049FD RID: 18941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTracks_Private_Void_0;

		// Token: 0x040049FE RID: 18942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049FF RID: 18943
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__9_0_Private_Void_0;

		// Token: 0x02000A5F RID: 2655
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600D0A6 RID: 53414 RVA: 0x00320534 File Offset: 0x0031E734
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100676975);
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100676976);
			}

			// Token: 0x0600D0A7 RID: 53415 RVA: 0x0032059C File Offset: 0x0031E79C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0A8 RID: 53416 RVA: 0x003205D8 File Offset: 0x0031E7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetTrackEnabled_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0A9 RID: 53417 RVA: 0x00065968 File Offset: 0x00063B68
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CF RID: 16591
			// (get) Token: 0x0600D0AA RID: 53418 RVA: 0x00320628 File Offset: 0x0031E828
			// (set) Token: 0x0600D0AB RID: 53419 RVA: 0x00065971 File Offset: 0x00063B71
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CD6 RID: 36054
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04008CD7 RID: 36055
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CD8 RID: 36056
			private static readonly IntPtr NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0;
		}

		// Token: 0x02000A60 RID: 2656
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600D0AC RID: 53420 RVA: 0x00320650 File Offset: 0x0031E850
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100676977);
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100676978);
			}

			// Token: 0x0600D0AD RID: 53421 RVA: 0x003206B8 File Offset: 0x0031E8B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0AE RID: 53422 RVA: 0x003206F4 File Offset: 0x0031E8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopTrack_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0AF RID: 53423 RVA: 0x00065990 File Offset: 0x00063B90
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D0 RID: 16592
			// (get) Token: 0x0600D0B0 RID: 53424 RVA: 0x00320744 File Offset: 0x0031E944
			// (set) Token: 0x0600D0B1 RID: 53425 RVA: 0x00065999 File Offset: 0x00063B99
			public unsafe string trackName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CD9 RID: 36057
			private static readonly IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04008CDA RID: 36058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CDB RID: 36059
			private static readonly IntPtr NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0;
		}
	}
}
