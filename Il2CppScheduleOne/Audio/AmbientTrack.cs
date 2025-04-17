using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C9 RID: 1225
	public class AmbientTrack : MonoBehaviour
	{
		// Token: 0x06006B2A RID: 27434 RVA: 0x001DDA94 File Offset: 0x001DBC94
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientTrack()
		{
			Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr);
			AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MIN_TIME_BETWEEN_AMBIENT_TRACKS");
			AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "LastPlayedTrack");
			AmbientTrack.NativeFieldInfoPtr_TrackQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "TrackQueued");
			AmbientTrack.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Tracks");
			AmbientTrack.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MinTime");
			AmbientTrack.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MaxTime");
			AmbientTrack.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Chance");
			AmbientTrack.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "startTime");
			AmbientTrack.NativeFieldInfoPtr_playTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "playTrack");
			AmbientTrack.NativeFieldInfoPtr_trackRandomized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "trackRandomized");
			AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676864);
			AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676865);
			AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676866);
			AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676867);
			AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100676868);
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x001DDBF0 File Offset: 0x001DBDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215506, XrefRangeEnd = 215519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x001DDC24 File Offset: 0x001DBE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215543, RefRangeEnd = 215544, XrefRangeStart = 215519, XrefRangeEnd = 215543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForcePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x001DDC58 File Offset: 0x001DBE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215544, XrefRangeEnd = 215550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x001DDC8C File Offset: 0x001DBE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215550, XrefRangeEnd = 215633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x001DDCC0 File Offset: 0x001DBEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215633, XrefRangeEnd = 215641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00032B0D File Offset: 0x00030D0D
		public AmbientTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06006B31 RID: 27441 RVA: 0x001DDCFC File Offset: 0x001DBEFC
		// (set) Token: 0x06006B32 RID: 27442 RVA: 0x00032B16 File Offset: 0x00030D16
		public unsafe static float MIN_TIME_BETWEEN_AMBIENT_TRACKS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&value));
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x001DDD18 File Offset: 0x001DBF18
		// (set) Token: 0x06006B34 RID: 27444 RVA: 0x00032B24 File Offset: 0x00030D24
		public unsafe static AmbientTrack LastPlayedTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientTrack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x001DDD40 File Offset: 0x001DBF40
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x00032B36 File Offset: 0x00030D36
		public unsafe static bool TrackQueued
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&value));
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x001DDD5C File Offset: 0x001DBF5C
		// (set) Token: 0x06006B38 RID: 27448 RVA: 0x00032B44 File Offset: 0x00030D44
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x001DDD8C File Offset: 0x001DBF8C
		// (set) Token: 0x06006B3A RID: 27450 RVA: 0x00032B63 File Offset: 0x00030D63
		public unsafe int MinTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime)) = value;
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06006B3B RID: 27451 RVA: 0x001DDDB4 File Offset: 0x001DBFB4
		// (set) Token: 0x06006B3C RID: 27452 RVA: 0x00032B7E File Offset: 0x00030D7E
		public unsafe int MaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime)) = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06006B3D RID: 27453 RVA: 0x001DDDDC File Offset: 0x001DBFDC
		// (set) Token: 0x06006B3E RID: 27454 RVA: 0x00032B99 File Offset: 0x00030D99
		public unsafe float Chance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance)) = value;
			}
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x001DDE04 File Offset: 0x001DC004
		// (set) Token: 0x06006B40 RID: 27456 RVA: 0x00032BB4 File Offset: 0x00030DB4
		public unsafe int startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06006B41 RID: 27457 RVA: 0x001DDE2C File Offset: 0x001DC02C
		// (set) Token: 0x06006B42 RID: 27458 RVA: 0x00032BCF File Offset: 0x00030DCF
		public unsafe bool playTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack)) = value;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06006B43 RID: 27459 RVA: 0x001DDE54 File Offset: 0x001DC054
		// (set) Token: 0x06006B44 RID: 27460 RVA: 0x00032BEA File Offset: 0x00030DEA
		public unsafe bool trackRandomized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized)) = value;
			}
		}

		// Token: 0x0400494F RID: 18767
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS;

		// Token: 0x04004950 RID: 18768
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedTrack;

		// Token: 0x04004951 RID: 18769
		private static readonly IntPtr NativeFieldInfoPtr_TrackQueued;

		// Token: 0x04004952 RID: 18770
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004953 RID: 18771
		private static readonly IntPtr NativeFieldInfoPtr_MinTime;

		// Token: 0x04004954 RID: 18772
		private static readonly IntPtr NativeFieldInfoPtr_MaxTime;

		// Token: 0x04004955 RID: 18773
		private static readonly IntPtr NativeFieldInfoPtr_Chance;

		// Token: 0x04004956 RID: 18774
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04004957 RID: 18775
		private static readonly IntPtr NativeFieldInfoPtr_playTrack;

		// Token: 0x04004958 RID: 18776
		private static readonly IntPtr NativeFieldInfoPtr_trackRandomized;

		// Token: 0x04004959 RID: 18777
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400495A RID: 18778
		private static readonly IntPtr NativeMethodInfoPtr_ForcePlay_Public_Void_0;

		// Token: 0x0400495B RID: 18779
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400495C RID: 18780
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400495D RID: 18781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
