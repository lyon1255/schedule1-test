using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Stealth;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000620 RID: 1568
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06008A4D RID: 35405 RVA: 0x002442A8 File Offset: 0x002424A8
		// Note: this type is marked as 'beforefieldinit'.
		static SpottedTremolo()
		{
			Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SpottedTremolo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr);
			SpottedTremolo.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Intensity");
			SpottedTremolo.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "Loop");
			SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "PlayerVisibility");
			SpottedTremolo.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinVolume");
			SpottedTremolo.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxVolume");
			SpottedTremolo.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinPitch");
			SpottedTremolo.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxPitch");
			SpottedTremolo.NativeFieldInfoPtr_SmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "SmoothTime");
			SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "smoothedIntensity");
			SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680491);
			SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100680492);
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x002443B4 File Offset: 0x002425B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254044, XrefRangeEnd = 254053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x002443E8 File Offset: 0x002425E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254053, XrefRangeEnd = 254054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpottedTremolo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x00042232 File Offset: 0x00040432
		public SpottedTremolo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x00244424 File Offset: 0x00242624
		// (set) Token: 0x06008A52 RID: 35410 RVA: 0x0004223B File Offset: 0x0004043B
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x0024444C File Offset: 0x0024264C
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x00042256 File Offset: 0x00040456
		public unsafe AudioSourceController Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_Loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x0024447C File Offset: 0x0024267C
		// (set) Token: 0x06008A56 RID: 35414 RVA: 0x00042275 File Offset: 0x00040475
		public unsafe PlayerVisibility PlayerVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_PlayerVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06008A57 RID: 35415 RVA: 0x002444AC File Offset: 0x002426AC
		// (set) Token: 0x06008A58 RID: 35416 RVA: 0x00042294 File Offset: 0x00040494
		public unsafe float MinVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinVolume)) = value;
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x002444D4 File Offset: 0x002426D4
		// (set) Token: 0x06008A5A RID: 35418 RVA: 0x000422AF File Offset: 0x000404AF
		public unsafe float MaxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxVolume)) = value;
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x002444FC File Offset: 0x002426FC
		// (set) Token: 0x06008A5C RID: 35420 RVA: 0x000422CA File Offset: 0x000404CA
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00244524 File Offset: 0x00242724
		// (set) Token: 0x06008A5E RID: 35422 RVA: 0x000422E5 File Offset: 0x000404E5
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x06008A5F RID: 35423 RVA: 0x0024454C File Offset: 0x0024274C
		// (set) Token: 0x06008A60 RID: 35424 RVA: 0x00042300 File Offset: 0x00040500
		public unsafe float SmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_SmoothTime)) = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06008A61 RID: 35425 RVA: 0x00244574 File Offset: 0x00242774
		// (set) Token: 0x06008A62 RID: 35426 RVA: 0x0004231B File Offset: 0x0004051B
		public unsafe float smoothedIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr_smoothedIntensity)) = value;
			}
		}

		// Token: 0x04005DD8 RID: 24024
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x04005DD9 RID: 24025
		private static readonly IntPtr NativeFieldInfoPtr_Loop;

		// Token: 0x04005DDA RID: 24026
		private static readonly IntPtr NativeFieldInfoPtr_PlayerVisibility;

		// Token: 0x04005DDB RID: 24027
		private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

		// Token: 0x04005DDC RID: 24028
		private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

		// Token: 0x04005DDD RID: 24029
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04005DDE RID: 24030
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04005DDF RID: 24031
		private static readonly IntPtr NativeFieldInfoPtr_SmoothTime;

		// Token: 0x04005DE0 RID: 24032
		private static readonly IntPtr NativeFieldInfoPtr_smoothedIntensity;

		// Token: 0x04005DE1 RID: 24033
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005DE2 RID: 24034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
