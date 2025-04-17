using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppVLB;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003BA RID: 954
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x06004A47 RID: 19015 RVA: 0x001686E0 File Offset: 0x001668E0
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightTracker()
		{
			Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "VolumetricLightTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr);
			VolumetricLightTracker.NativeFieldInfoPtr_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Override");
			VolumetricLightTracker.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Enabled");
			VolumetricLightTracker.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "light");
			VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "optimizedLight");
			VolumetricLightTracker.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "beam");
			VolumetricLightTracker.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "dust");
			VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672506);
			VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672507);
			VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672508);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x001687C4 File Offset: 0x001669C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163827, XrefRangeEnd = 163856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x001687F8 File Offset: 0x001669F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163856, XrefRangeEnd = 163872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0016882C File Offset: 0x00166A2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00023D33 File Offset: 0x00021F33
		public VolumetricLightTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x00168868 File Offset: 0x00166A68
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x00023D3C File Offset: 0x00021F3C
		public unsafe bool Override
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override)) = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00168890 File Offset: 0x00166A90
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x00023D57 File Offset: 0x00021F57
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x001688B8 File Offset: 0x00166AB8
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x00023D72 File Offset: 0x00021F72
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x001688E8 File Offset: 0x00166AE8
		// (set) Token: 0x06004A53 RID: 19027 RVA: 0x00023D91 File Offset: 0x00021F91
		public unsafe OptimizedLight optimizedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x00168918 File Offset: 0x00166B18
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x00023DB0 File Offset: 0x00021FB0
		public unsafe VolumetricLightBeamSD beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x00168948 File Offset: 0x00166B48
		// (set) Token: 0x06004A57 RID: 19031 RVA: 0x00023DCF File Offset: 0x00021FCF
		public unsafe VolumetricDustParticles dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeFieldInfoPtr_Override;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeFieldInfoPtr_optimizedLight;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
