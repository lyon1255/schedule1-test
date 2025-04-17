using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E8 RID: 1256
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x06006EE2 RID: 28386 RVA: 0x001E9F90 File Offset: 0x001E8190
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAxle()
		{
			Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAxle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr);
			VehicleAxle.NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "wheel");
			VehicleAxle.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "model");
			VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677312);
			VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677313);
			VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677314);
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x001EA024 File Offset: 0x001E8224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220319, XrefRangeEnd = 220325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x001EA060 File Offset: 0x001E8260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220325, XrefRangeEnd = 220343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x001EA09C File Offset: 0x001E829C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAxle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x000347B0 File Offset: 0x000329B0
		public VehicleAxle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006EE7 RID: 28391 RVA: 0x001EA0D8 File Offset: 0x001E82D8
		// (set) Token: 0x06006EE8 RID: 28392 RVA: 0x000347B9 File Offset: 0x000329B9
		public unsafe Wheel wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006EE9 RID: 28393 RVA: 0x001EA108 File Offset: 0x001E8308
		// (set) Token: 0x06006EEA RID: 28394 RVA: 0x000347D8 File Offset: 0x000329D8
		public unsafe Transform model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BD9 RID: 19417
		private static readonly IntPtr NativeFieldInfoPtr_wheel;

		// Token: 0x04004BDA RID: 19418
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x04004BDB RID: 19419
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004BDC RID: 19420
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004BDD RID: 19421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
