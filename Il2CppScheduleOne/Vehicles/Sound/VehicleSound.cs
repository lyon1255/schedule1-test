using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Sound
{
	// Token: 0x020004F4 RID: 1268
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x0600702D RID: 28717 RVA: 0x001EDD48 File Offset: 0x001EBF48
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSound()
		{
			Il2CppClassPointerStore<VehicleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Sound", "VehicleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr);
			VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "COLLISION_SOUND_COOLDOWN");
			VehicleSound.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "VolumeMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineStartSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineStartSource");
			VehicleSound.NativeFieldInfoPtr_EngineIdleSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineIdleSource");
			VehicleSound.NativeFieldInfoPtr_EngineLoopSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopSource");
			VehicleSound.NativeFieldInfoPtr_HandbrakeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HandbrakeSource");
			VehicleSound.NativeFieldInfoPtr_HonkSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HonkSource");
			VehicleSound.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "ImpactSound");
			VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MinCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MinCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchCurve");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopVolumeCurve");
			VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "<Vehicle>k__BackingField");
			VehicleSound.NativeFieldInfoPtr_currentIdleVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "currentIdleVolume");
			VehicleSound.NativeFieldInfoPtr_lastCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionTime");
			VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionMomentum");
			VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677418);
			VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677419);
			VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677420);
			VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677421);
			VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677422);
			VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677423);
			VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677424);
			VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677425);
			VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677426);
			VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677427);
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600702E RID: 28718 RVA: 0x001EDFE4 File Offset: 0x001EC1E4
		// (set) Token: 0x0600702F RID: 28719 RVA: 0x001EE024 File Offset: 0x001EC224
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95744, RefRangeEnd = 95745, XrefRangeStart = 95744, XrefRangeEnd = 95745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x001EE068 File Offset: 0x001EC268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221341, XrefRangeEnd = 221371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x001EE0A4 File Offset: 0x001EC2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221371, XrefRangeEnd = 221372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x001EE0E0 File Offset: 0x001EC2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221385, RefRangeEnd = 221386, XrefRangeStart = 221372, XrefRangeEnd = 221385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x001EE114 File Offset: 0x001EC314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221386, XrefRangeEnd = 221387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandbrakeApplied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x001EE148 File Offset: 0x001EC348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221387, XrefRangeEnd = 221388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x001EE17C File Offset: 0x001EC37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221388, XrefRangeEnd = 221389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Honk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x001EE1B0 File Offset: 0x001EC3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221389, XrefRangeEnd = 221407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollision(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x001EE1F4 File Offset: 0x001EC3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221407, XrefRangeEnd = 221408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00035304 File Offset: 0x00033504
		public VehicleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x001EE230 File Offset: 0x001EC430
		// (set) Token: 0x0600703A RID: 28730 RVA: 0x0003530D File Offset: 0x0003350D
		public unsafe static float COLLISION_SOUND_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x001EE24C File Offset: 0x001EC44C
		// (set) Token: 0x0600703C RID: 28732 RVA: 0x0003531B File Offset: 0x0003351B
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x0600703D RID: 28733 RVA: 0x001EE274 File Offset: 0x001EC474
		// (set) Token: 0x0600703E RID: 28734 RVA: 0x00035336 File Offset: 0x00033536
		public unsafe AudioSourceController EngineStartSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x001EE2A4 File Offset: 0x001EC4A4
		// (set) Token: 0x06007040 RID: 28736 RVA: 0x00035355 File Offset: 0x00033555
		public unsafe AudioSourceController EngineIdleSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06007041 RID: 28737 RVA: 0x001EE2D4 File Offset: 0x001EC4D4
		// (set) Token: 0x06007042 RID: 28738 RVA: 0x00035374 File Offset: 0x00033574
		public unsafe AudioSourceController EngineLoopSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x001EE304 File Offset: 0x001EC504
		// (set) Token: 0x06007044 RID: 28740 RVA: 0x00035393 File Offset: 0x00033593
		public unsafe AudioSourceController HandbrakeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06007045 RID: 28741 RVA: 0x001EE334 File Offset: 0x001EC534
		// (set) Token: 0x06007046 RID: 28742 RVA: 0x000353B2 File Offset: 0x000335B2
		public unsafe AudioSourceController HonkSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06007047 RID: 28743 RVA: 0x001EE364 File Offset: 0x001EC564
		// (set) Token: 0x06007048 RID: 28744 RVA: 0x000353D1 File Offset: 0x000335D1
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x001EE394 File Offset: 0x001EC594
		// (set) Token: 0x0600704A RID: 28746 RVA: 0x000353F0 File Offset: 0x000335F0
		public unsafe float MinCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum)) = value;
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x001EE3BC File Offset: 0x001EC5BC
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x0003540B File Offset: 0x0003360B
		public unsafe float MaxCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum)) = value;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x001EE3E4 File Offset: 0x001EC5E4
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x00035426 File Offset: 0x00033626
		public unsafe float MinCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume)) = value;
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x001EE40C File Offset: 0x001EC60C
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x00035441 File Offset: 0x00033641
		public unsafe float MaxCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume)) = value;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06007051 RID: 28753 RVA: 0x001EE434 File Offset: 0x001EC634
		// (set) Token: 0x06007052 RID: 28754 RVA: 0x0003545C File Offset: 0x0003365C
		public unsafe float MinCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch)) = value;
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x001EE45C File Offset: 0x001EC65C
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x00035477 File Offset: 0x00033677
		public unsafe float MaxCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch)) = value;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x001EE484 File Offset: 0x001EC684
		// (set) Token: 0x06007056 RID: 28758 RVA: 0x00035492 File Offset: 0x00033692
		public unsafe AnimationCurve EngineLoopPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x001EE4B4 File Offset: 0x001EC6B4
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x000354B1 File Offset: 0x000336B1
		public unsafe float EngineLoopPitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier)) = value;
			}
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x001EE4DC File Offset: 0x001EC6DC
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x000354CC File Offset: 0x000336CC
		public unsafe AnimationCurve EngineLoopVolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x001EE50C File Offset: 0x001EC70C
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x000354EB File Offset: 0x000336EB
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x001EE53C File Offset: 0x001EC73C
		// (set) Token: 0x0600705E RID: 28766 RVA: 0x0003550A File Offset: 0x0003370A
		public unsafe float currentIdleVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume)) = value;
			}
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x001EE564 File Offset: 0x001EC764
		// (set) Token: 0x06007060 RID: 28768 RVA: 0x00035525 File Offset: 0x00033725
		public unsafe float lastCollisionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime)) = value;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x001EE58C File Offset: 0x001EC78C
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x00035540 File Offset: 0x00033740
		public unsafe float lastCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum)) = value;
			}
		}

		// Token: 0x04004CA6 RID: 19622
		private static readonly IntPtr NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN;

		// Token: 0x04004CA7 RID: 19623
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004CA8 RID: 19624
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSource;

		// Token: 0x04004CA9 RID: 19625
		private static readonly IntPtr NativeFieldInfoPtr_EngineIdleSource;

		// Token: 0x04004CAA RID: 19626
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopSource;

		// Token: 0x04004CAB RID: 19627
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSource;

		// Token: 0x04004CAC RID: 19628
		private static readonly IntPtr NativeFieldInfoPtr_HonkSource;

		// Token: 0x04004CAD RID: 19629
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x04004CAE RID: 19630
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionMomentum;

		// Token: 0x04004CAF RID: 19631
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionMomentum;

		// Token: 0x04004CB0 RID: 19632
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionVolume;

		// Token: 0x04004CB1 RID: 19633
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionVolume;

		// Token: 0x04004CB2 RID: 19634
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionPitch;

		// Token: 0x04004CB3 RID: 19635
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionPitch;

		// Token: 0x04004CB4 RID: 19636
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchCurve;

		// Token: 0x04004CB5 RID: 19637
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchMultiplier;

		// Token: 0x04004CB6 RID: 19638
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopVolumeCurve;

		// Token: 0x04004CB7 RID: 19639
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x04004CB8 RID: 19640
		private static readonly IntPtr NativeFieldInfoPtr_currentIdleVolume;

		// Token: 0x04004CB9 RID: 19641
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionTime;

		// Token: 0x04004CBA RID: 19642
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionMomentum;

		// Token: 0x04004CBB RID: 19643
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x04004CBC RID: 19644
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x04004CBD RID: 19645
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004CBE RID: 19646
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004CBF RID: 19647
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIdle_Private_Void_0;

		// Token: 0x04004CC0 RID: 19648
		private static readonly IntPtr NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0;

		// Token: 0x04004CC1 RID: 19649
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Void_0;

		// Token: 0x04004CC2 RID: 19650
		private static readonly IntPtr NativeMethodInfoPtr_Honk_Public_Void_0;

		// Token: 0x04004CC3 RID: 19651
		private static readonly IntPtr NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0;

		// Token: 0x04004CC4 RID: 19652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
