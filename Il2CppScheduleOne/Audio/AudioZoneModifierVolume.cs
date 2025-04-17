using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004CE RID: 1230
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x06006BCD RID: 27597 RVA: 0x001DF8A8 File Offset: 0x001DDAA8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZoneModifierVolume()
		{
			Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZoneModifierVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr);
			AudioZoneModifierVolume.NativeFieldInfoPtr_Zones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "Zones");
			AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "VolumeMultiplier");
			AudioZoneModifierVolume.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "colliders");
			AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676925);
			AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676926);
			AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676927);
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x001DF950 File Offset: 0x001DDB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216156, XrefRangeEnd = 216168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x001DF984 File Offset: 0x001DDB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216168, XrefRangeEnd = 216212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x001DF9B8 File Offset: 0x001DDBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216212, XrefRangeEnd = 216220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZoneModifierVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x00033035 File Offset: 0x00031235
		public AudioZoneModifierVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x001DF9F4 File Offset: 0x001DDBF4
		// (set) Token: 0x06006BD3 RID: 27603 RVA: 0x0003303E File Offset: 0x0003123E
		public unsafe List<AudioZone> Zones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x001DFA24 File Offset: 0x001DDC24
		// (set) Token: 0x06006BD5 RID: 27605 RVA: 0x0003305D File Offset: 0x0003125D
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x001DFA4C File Offset: 0x001DDC4C
		// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x00033078 File Offset: 0x00031278
		public unsafe Il2CppReferenceArray<BoxCollider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C0 RID: 18880
		private static readonly IntPtr NativeFieldInfoPtr_Zones;

		// Token: 0x040049C1 RID: 18881
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040049C2 RID: 18882
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x040049C3 RID: 18883
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049C4 RID: 18884
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x040049C5 RID: 18885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
