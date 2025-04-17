using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004C7 RID: 1223
	public class AmbientLoopJukebox : MonoBehaviour
	{
		// Token: 0x06006B03 RID: 27395 RVA: 0x001DD470 File Offset: 0x001DB670
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoopJukebox()
		{
			Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoopJukebox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr);
			AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "VolumeCurve");
			AmbientLoopJukebox.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "Clips");
			AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "audioSourceController");
			AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "currentClipIndex");
			AmbientLoopJukebox.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "musicScale");
			AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676855);
			AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676856);
			AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676857);
			AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100676858);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x001DD554 File Offset: 0x001DB754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215399, XrefRangeEnd = 215427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x001DD588 File Offset: 0x001DB788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215427, XrefRangeEnd = 215434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x001DD5BC File Offset: 0x001DB7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215434, XrefRangeEnd = 215445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x001DD5F0 File Offset: 0x001DB7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215445, XrefRangeEnd = 215453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoopJukebox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x0003298C File Offset: 0x00030B8C
		public AmbientLoopJukebox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x001DD62C File Offset: 0x001DB82C
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x00032995 File Offset: 0x00030B95
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x001DD65C File Offset: 0x001DB85C
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x000329B4 File Offset: 0x00030BB4
		public unsafe List<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x001DD68C File Offset: 0x001DB88C
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x000329D3 File Offset: 0x00030BD3
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x001DD6BC File Offset: 0x001DB8BC
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x000329F2 File Offset: 0x00030BF2
		public unsafe int currentClipIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex)) = value;
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x001DD6E4 File Offset: 0x001DB8E4
		// (set) Token: 0x06006B12 RID: 27410 RVA: 0x00032A0D File Offset: 0x00030C0D
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x04004939 RID: 18745
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x0400493A RID: 18746
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x0400493B RID: 18747
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x0400493C RID: 18748
		private static readonly IntPtr NativeFieldInfoPtr_currentClipIndex;

		// Token: 0x0400493D RID: 18749
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x0400493E RID: 18750
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400493F RID: 18751
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004940 RID: 18752
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004941 RID: 18753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
