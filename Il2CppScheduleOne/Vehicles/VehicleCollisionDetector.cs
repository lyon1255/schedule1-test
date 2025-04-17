using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004EA RID: 1258
	public class VehicleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06006F20 RID: 28448 RVA: 0x001EA980 File Offset: 0x001E8B80
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCollisionDetector()
		{
			Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr);
			VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, "onCollisionEnter");
			VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677326);
			VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677327);
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x001EA9EC File Offset: 0x001E8BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220639, XrefRangeEnd = 220642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x001EAA30 File Offset: 0x001E8C30
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x000349D1 File Offset: 0x00032BD1
		public VehicleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06006F24 RID: 28452 RVA: 0x001EAA6C File Offset: 0x001E8C6C
		// (set) Token: 0x06006F25 RID: 28453 RVA: 0x000349DA File Offset: 0x00032BDA
		public unsafe UnityEvent<Collision> onCollisionEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BFD RID: 19453
		private static readonly IntPtr NativeFieldInfoPtr_onCollisionEnter;

		// Token: 0x04004BFE RID: 19454
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04004BFF RID: 19455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
