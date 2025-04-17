using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D2 RID: 1234
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x06006C05 RID: 27653 RVA: 0x001E0270 File Offset: 0x001DE470
		// Note: this type is marked as 'beforefieldinit'.
		static HeartbeatSoundController()
		{
			Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "HeartbeatSoundController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr);
			HeartbeatSoundController.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "sound");
			HeartbeatSoundController.NativeFieldInfoPtr_VolumeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "VolumeController");
			HeartbeatSoundController.NativeFieldInfoPtr_PitchController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "PitchController");
			HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676956);
			HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676957);
			HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676958);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001E0318 File Offset: 0x001DE518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216493, XrefRangeEnd = 216498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001E034C File Offset: 0x001DE54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216498, XrefRangeEnd = 216501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001E0380 File Offset: 0x001DE580
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeartbeatSoundController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00033224 File Offset: 0x00031424
		public HeartbeatSoundController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06006C0A RID: 27658 RVA: 0x001E03BC File Offset: 0x001DE5BC
		// (set) Token: 0x06006C0B RID: 27659 RVA: 0x0003322D File Offset: 0x0003142D
		public unsafe AudioSourceController sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06006C0C RID: 27660 RVA: 0x001E03EC File Offset: 0x001DE5EC
		// (set) Token: 0x06006C0D RID: 27661 RVA: 0x0003324C File Offset: 0x0003144C
		public unsafe FloatSmoother VolumeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06006C0E RID: 27662 RVA: 0x001E041C File Offset: 0x001DE61C
		// (set) Token: 0x06006C0F RID: 27663 RVA: 0x0003326B File Offset: 0x0003146B
		public unsafe FloatSmoother PitchController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049E0 RID: 18912
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x040049E1 RID: 18913
		private static readonly IntPtr NativeFieldInfoPtr_VolumeController;

		// Token: 0x040049E2 RID: 18914
		private static readonly IntPtr NativeFieldInfoPtr_PitchController;

		// Token: 0x040049E3 RID: 18915
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040049E4 RID: 18916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049E5 RID: 18917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
