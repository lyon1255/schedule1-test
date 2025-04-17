using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D6 RID: 1238
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x06006C3E RID: 27710 RVA: 0x001E0D28 File Offset: 0x001DEF28
		// Note: this type is marked as 'beforefieldinit'.
		static MusicTrack()
		{
			Il2CppClassPointerStore<MusicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr);
			MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "<IsPlaying>k__BackingField");
			MusicTrack.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Enabled");
			MusicTrack.NativeFieldInfoPtr_TrackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "TrackName");
			MusicTrack.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Priority");
			MusicTrack.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeInTime");
			MusicTrack.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeOutTime");
			MusicTrack.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Controller");
			MusicTrack.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "VolumeMultiplier");
			MusicTrack.NativeFieldInfoPtr_AutoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "AutoFadeOut");
			MusicTrack.NativeFieldInfoPtr_volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "volumeMultiplier");
			MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676982);
			MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676983);
			MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676984);
			MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676985);
			MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676986);
			MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676987);
			MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676988);
			MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676989);
			MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676990);
			MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100676991);
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x001E0EE8 File Offset: 0x001DF0E8
		// (set) Token: 0x06006C40 RID: 27712 RVA: 0x001E0F24 File Offset: 0x001DF124
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x001E0F64 File Offset: 0x001DF164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216790, XrefRangeEnd = 216799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x001E0F98 File Offset: 0x001DF198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216799, RefRangeEnd = 216803, XrefRangeStart = 216799, XrefRangeEnd = 216799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x001E0FCC File Offset: 0x001DF1CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216803, RefRangeEnd = 216805, XrefRangeStart = 216803, XrefRangeEnd = 216803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x001E1000 File Offset: 0x001DF200
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x001E103C File Offset: 0x001DF23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216810, RefRangeEnd = 216811, XrefRangeStart = 216805, XrefRangeEnd = 216810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x001E1078 File Offset: 0x001DF278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216811, XrefRangeEnd = 216812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x001E10B4 File Offset: 0x001DF2B4
		[CallerCount(0)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C48 RID: 27720 RVA: 0x001E10F0 File Offset: 0x001DF2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216812, XrefRangeEnd = 216817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C49 RID: 27721 RVA: 0x000333BF File Offset: 0x000315BF
		public MusicTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06006C4A RID: 27722 RVA: 0x001E112C File Offset: 0x001DF32C
		// (set) Token: 0x06006C4B RID: 27723 RVA: 0x000333C8 File Offset: 0x000315C8
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06006C4C RID: 27724 RVA: 0x001E1154 File Offset: 0x001DF354
		// (set) Token: 0x06006C4D RID: 27725 RVA: 0x000333E3 File Offset: 0x000315E3
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x001E117C File Offset: 0x001DF37C
		// (set) Token: 0x06006C4F RID: 27727 RVA: 0x000333FE File Offset: 0x000315FE
		public unsafe string TrackName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06006C50 RID: 27728 RVA: 0x001E11A4 File Offset: 0x001DF3A4
		// (set) Token: 0x06006C51 RID: 27729 RVA: 0x0003341D File Offset: 0x0003161D
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06006C52 RID: 27730 RVA: 0x001E11CC File Offset: 0x001DF3CC
		// (set) Token: 0x06006C53 RID: 27731 RVA: 0x00033438 File Offset: 0x00031638
		public unsafe float FadeInTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime)) = value;
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x001E11F4 File Offset: 0x001DF3F4
		// (set) Token: 0x06006C55 RID: 27733 RVA: 0x00033453 File Offset: 0x00031653
		public unsafe float FadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime)) = value;
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06006C56 RID: 27734 RVA: 0x001E121C File Offset: 0x001DF41C
		// (set) Token: 0x06006C57 RID: 27735 RVA: 0x0003346E File Offset: 0x0003166E
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06006C58 RID: 27736 RVA: 0x001E124C File Offset: 0x001DF44C
		// (set) Token: 0x06006C59 RID: 27737 RVA: 0x0003348D File Offset: 0x0003168D
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06006C5A RID: 27738 RVA: 0x001E1274 File Offset: 0x001DF474
		// (set) Token: 0x06006C5B RID: 27739 RVA: 0x000334A8 File Offset: 0x000316A8
		public unsafe bool AutoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut)) = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06006C5C RID: 27740 RVA: 0x001E129C File Offset: 0x001DF49C
		// (set) Token: 0x06006C5D RID: 27741 RVA: 0x000334C3 File Offset: 0x000316C3
		public unsafe float volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier)) = value;
			}
		}

		// Token: 0x04004A03 RID: 18947
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004A04 RID: 18948
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04004A05 RID: 18949
		private static readonly IntPtr NativeFieldInfoPtr_TrackName;

		// Token: 0x04004A06 RID: 18950
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04004A07 RID: 18951
		private static readonly IntPtr NativeFieldInfoPtr_FadeInTime;

		// Token: 0x04004A08 RID: 18952
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutTime;

		// Token: 0x04004A09 RID: 18953
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04004A0A RID: 18954
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004A0B RID: 18955
		private static readonly IntPtr NativeFieldInfoPtr_AutoFadeOut;

		// Token: 0x04004A0C RID: 18956
		private static readonly IntPtr NativeFieldInfoPtr_volumeMultiplier;

		// Token: 0x04004A0D RID: 18957
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004A0E RID: 18958
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004A0F RID: 18959
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004A10 RID: 18960
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04004A11 RID: 18961
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04004A12 RID: 18962
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004A13 RID: 18963
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04004A14 RID: 18964
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x04004A15 RID: 18965
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x04004A16 RID: 18966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
