using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C6 RID: 1222
	public class AmbientLoop : MonoBehaviour
	{
		// Token: 0x06006AF2 RID: 27378 RVA: 0x001DD200 File Offset: 0x001DB400
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoop()
		{
			Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr);
			AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "MUSIC_FADE_MULTIPLIER");
			AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "MUSIC_FADE_TIME");
			AmbientLoop.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "VolumeCurve");
			AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "FadeDuringMusic");
			AmbientLoop.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "audioSourceController");
			AmbientLoop.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "musicScale");
			AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676852);
			AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676853);
			AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100676854);
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x001DD2E4 File Offset: 0x001DB4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215377, XrefRangeEnd = 215382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x001DD318 File Offset: 0x001DB518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215382, XrefRangeEnd = 215398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x001DD34C File Offset: 0x001DB54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215398, XrefRangeEnd = 215399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x000328F3 File Offset: 0x00030AF3
		public AmbientLoop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x001DD388 File Offset: 0x001DB588
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x000328FC File Offset: 0x00030AFC
		public unsafe static float MUSIC_FADE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x001DD3A4 File Offset: 0x001DB5A4
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x0003290A File Offset: 0x00030B0A
		public unsafe static float MUSIC_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x001DD3C0 File Offset: 0x001DB5C0
		// (set) Token: 0x06006AFC RID: 27388 RVA: 0x00032918 File Offset: 0x00030B18
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x001DD3F0 File Offset: 0x001DB5F0
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x00032937 File Offset: 0x00030B37
		public unsafe bool FadeDuringMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic)) = value;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x001DD418 File Offset: 0x001DB618
		// (set) Token: 0x06006B00 RID: 27392 RVA: 0x00032952 File Offset: 0x00030B52
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x001DD448 File Offset: 0x001DB648
		// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00032971 File Offset: 0x00030B71
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x04004930 RID: 18736
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER;

		// Token: 0x04004931 RID: 18737
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_TIME;

		// Token: 0x04004932 RID: 18738
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04004933 RID: 18739
		private static readonly IntPtr NativeFieldInfoPtr_FadeDuringMusic;

		// Token: 0x04004934 RID: 18740
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x04004935 RID: 18741
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x04004936 RID: 18742
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004937 RID: 18743
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004938 RID: 18744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
