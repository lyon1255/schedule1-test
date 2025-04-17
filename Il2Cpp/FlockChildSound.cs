using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000038 RID: 56
	public class FlockChildSound : MonoBehaviour
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x0007CF10 File Offset: 0x0007B110
		// Note: this type is marked as 'beforefieldinit'.
		static FlockChildSound()
		{
			Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockChildSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr);
			FlockChildSound.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "controller");
			FlockChildSound.NativeFieldInfoPtr__idleSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSounds");
			FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_idleSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__flightSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSounds");
			FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flightSoundRandomChance");
			FlockChildSound.NativeFieldInfoPtr__scareSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_scareSounds");
			FlockChildSound.NativeFieldInfoPtr__pitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMin");
			FlockChildSound.NativeFieldInfoPtr__pitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_pitchMax");
			FlockChildSound.NativeFieldInfoPtr__volumeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMin");
			FlockChildSound.NativeFieldInfoPtr__volumeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_volumeMax");
			FlockChildSound.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_flockChild");
			FlockChildSound.NativeFieldInfoPtr__audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_audio");
			FlockChildSound.NativeFieldInfoPtr__hasLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, "_hasLanded");
			FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663676);
			FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663677);
			FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663678);
			FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr, 100663679);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0007D094 File Offset: 0x0007B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74097, XrefRangeEnd = 74112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0007D0C8 File Offset: 0x0007B2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74112, XrefRangeEnd = 74122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRandomSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_PlayRandomSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0007D0FC File Offset: 0x0007B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74122, XrefRangeEnd = 74131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr_ScareSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0007D130 File Offset: 0x0007B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74131, XrefRangeEnd = 74132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockChildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockChildSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000465F File Offset: 0x0000285F
		public FlockChildSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0007D16C File Offset: 0x0007B36C
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00004668 File Offset: 0x00002868
		public unsafe AudioSourceController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0007D19C File Offset: 0x0007B39C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00004687 File Offset: 0x00002887
		public unsafe Il2CppReferenceArray<AudioClip> _idleSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0007D1CC File Offset: 0x0007B3CC
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000046A6 File Offset: 0x000028A6
		public unsafe float _idleSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__idleSoundRandomChance)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0007D1F4 File Offset: 0x0007B3F4
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000046C1 File Offset: 0x000028C1
		public unsafe Il2CppReferenceArray<AudioClip> _flightSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0007D224 File Offset: 0x0007B424
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x000046E0 File Offset: 0x000028E0
		public unsafe float _flightSoundRandomChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flightSoundRandomChance)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0007D24C File Offset: 0x0007B44C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000046FB File Offset: 0x000028FB
		public unsafe Il2CppReferenceArray<AudioClip> _scareSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__scareSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0007D27C File Offset: 0x0007B47C
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000471A File Offset: 0x0000291A
		public unsafe float _pitchMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMin)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0007D2A4 File Offset: 0x0007B4A4
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00004735 File Offset: 0x00002935
		public unsafe float _pitchMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__pitchMax)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0007D2CC File Offset: 0x0007B4CC
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004750 File Offset: 0x00002950
		public unsafe float _volumeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMin)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0007D2F4 File Offset: 0x0007B4F4
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x0000476B File Offset: 0x0000296B
		public unsafe float _volumeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__volumeMax)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0007D31C File Offset: 0x0007B51C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00004786 File Offset: 0x00002986
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0007D34C File Offset: 0x0007B54C
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000047A5 File Offset: 0x000029A5
		public unsafe AudioSource _audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0007D37C File Offset: 0x0007B57C
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000047C4 File Offset: 0x000029C4
		public unsafe bool _hasLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChildSound.NativeFieldInfoPtr__hasLanded)) = value;
			}
		}

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr__idleSounds;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr__idleSoundRandomChance;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr__flightSounds;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr__flightSoundRandomChance;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr__scareSounds;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr__pitchMin;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr__pitchMax;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr__volumeMin;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr__volumeMax;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr__audio;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr__hasLanded;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_PlayRandomSound_Public_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_ScareSound_Public_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
