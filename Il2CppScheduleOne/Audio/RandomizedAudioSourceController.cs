using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D7 RID: 1239
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06006C5E RID: 27742 RVA: 0x001E12C4 File Offset: 0x001DF4C4
		// Note: this type is marked as 'beforefieldinit'.
		static RandomizedAudioSourceController()
		{
			Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "RandomizedAudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr);
			RandomizedAudioSourceController.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, "Clips");
			RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676992);
			RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676993);
			RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676994);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x001E1344 File Offset: 0x001DF544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216817, XrefRangeEnd = 216830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x001E1380 File Offset: 0x001DF580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216830, XrefRangeEnd = 216841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x001E13CC File Offset: 0x001DF5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomizedAudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x000334DE File Offset: 0x000316DE
		public RandomizedAudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x001E1408 File Offset: 0x001DF608
		// (set) Token: 0x06006C64 RID: 27748 RVA: 0x000334E7 File Offset: 0x000316E7
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A17 RID: 18967
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04004A18 RID: 18968
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04004A19 RID: 18969
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004A1A RID: 18970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
