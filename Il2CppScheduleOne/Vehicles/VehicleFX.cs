using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EB RID: 1259
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x06006F26 RID: 28454 RVA: 0x001EAA9C File Offset: 0x001E8C9C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleFX()
		{
			Il2CppClassPointerStore<VehicleFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr);
			VehicleFX.NativeFieldInfoPtr_exhaustFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, "exhaustFX");
			VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677328);
			VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677329);
			VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677330);
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x001EAB1C File Offset: 0x001E8D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220642, XrefRangeEnd = 220644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x001EAB58 File Offset: 0x001E8D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220644, XrefRangeEnd = 220646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x001EAB94 File Offset: 0x001E8D94
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x000349F9 File Offset: 0x00032BF9
		public VehicleFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06006F2B RID: 28459 RVA: 0x001EABD0 File Offset: 0x001E8DD0
		// (set) Token: 0x06006F2C RID: 28460 RVA: 0x00034A02 File Offset: 0x00032C02
		public unsafe Il2CppReferenceArray<ParticleSystem> exhaustFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C00 RID: 19456
		private static readonly IntPtr NativeFieldInfoPtr_exhaustFX;

		// Token: 0x04004C01 RID: 19457
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0;

		// Token: 0x04004C02 RID: 19458
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0;

		// Token: 0x04004C03 RID: 19459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
