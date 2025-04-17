using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E7 RID: 1255
	public class VehicleAudio : MonoBehaviour
	{
		// Token: 0x06006ECC RID: 28364 RVA: 0x001E9BA4 File Offset: 0x001E7DA4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAudio()
		{
			Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr);
			VehicleAudio.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Vehicle");
			VehicleAudio.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Lights");
			VehicleAudio.NativeFieldInfoPtr_EngineStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStartSound");
			VehicleAudio.NativeFieldInfoPtr_EngineStopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStopSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOnSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOffSound");
			VehicleAudio.NativeFieldInfoPtr_HornSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HornSound");
			VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677306);
			VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677307);
			VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677308);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677309);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677310);
			VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677311);
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x001E9CD8 File Offset: 0x001E7ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220295, XrefRangeEnd = 220319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x001E9D14 File Offset: 0x001E7F14
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x001E9D50 File Offset: 0x001E7F50
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x001E9D8C File Offset: 0x001E7F8C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x001E9DC8 File Offset: 0x001E7FC8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x001E9E04 File Offset: 0x001E8004
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x000346CE File Offset: 0x000328CE
		public VehicleAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x001E9E40 File Offset: 0x001E8040
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x000346D7 File Offset: 0x000328D7
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x001E9E70 File Offset: 0x001E8070
		// (set) Token: 0x06006ED7 RID: 28375 RVA: 0x000346F6 File Offset: 0x000328F6
		public unsafe VehicleLights Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x001E9EA0 File Offset: 0x001E80A0
		// (set) Token: 0x06006ED9 RID: 28377 RVA: 0x00034715 File Offset: 0x00032915
		public unsafe AudioSource EngineStartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06006EDA RID: 28378 RVA: 0x001E9ED0 File Offset: 0x001E80D0
		// (set) Token: 0x06006EDB RID: 28379 RVA: 0x00034734 File Offset: 0x00032934
		public unsafe AudioSource EngineStopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x001E9F00 File Offset: 0x001E8100
		// (set) Token: 0x06006EDD RID: 28381 RVA: 0x00034753 File Offset: 0x00032953
		public unsafe AudioSource HeadlightsOnSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06006EDE RID: 28382 RVA: 0x001E9F30 File Offset: 0x001E8130
		// (set) Token: 0x06006EDF RID: 28383 RVA: 0x00034772 File Offset: 0x00032972
		public unsafe AudioSource HeadlightsOffSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06006EE0 RID: 28384 RVA: 0x001E9F60 File Offset: 0x001E8160
		// (set) Token: 0x06006EE1 RID: 28385 RVA: 0x00034791 File Offset: 0x00032991
		public unsafe AudioSource HornSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BCC RID: 19404
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04004BCD RID: 19405
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04004BCE RID: 19406
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSound;

		// Token: 0x04004BCF RID: 19407
		private static readonly IntPtr NativeFieldInfoPtr_EngineStopSound;

		// Token: 0x04004BD0 RID: 19408
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOnSound;

		// Token: 0x04004BD1 RID: 19409
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOffSound;

		// Token: 0x04004BD2 RID: 19410
		private static readonly IntPtr NativeFieldInfoPtr_HornSound;

		// Token: 0x04004BD3 RID: 19411
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD4 RID: 19412
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD5 RID: 19413
		private static readonly IntPtr NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD6 RID: 19414
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD7 RID: 19415
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0;

		// Token: 0x04004BD8 RID: 19416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
