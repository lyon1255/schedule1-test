using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EC RID: 1260
	public class VehicleHumanoidCollider : MonoBehaviour
	{
		// Token: 0x06006F2D RID: 28461 RVA: 0x001EAC00 File Offset: 0x001E8E00
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleHumanoidCollider()
		{
			Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleHumanoidCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr);
			VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, "vehicle");
			VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677331);
			VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677332);
			VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677333);
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x001EAC80 File Offset: 0x001E8E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220646, XrefRangeEnd = 220651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x001EACB4 File Offset: 0x001E8EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220651, XrefRangeEnd = 220662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x001EACF8 File Offset: 0x001E8EF8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleHumanoidCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x00034A21 File Offset: 0x00032C21
		public VehicleHumanoidCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06006F32 RID: 28466 RVA: 0x001EAD34 File Offset: 0x001E8F34
		// (set) Token: 0x06006F33 RID: 28467 RVA: 0x00034A2A File Offset: 0x00032C2A
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C04 RID: 19460
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C05 RID: 19461
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004C06 RID: 19462
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x04004C07 RID: 19463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
