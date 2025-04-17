using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F1 RID: 1265
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x06006FCE RID: 28622 RVA: 0x001ECD58 File Offset: 0x001EAF58
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecoveryPoint()
		{
			Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleRecoveryPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr);
			VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, "recoveryPoints");
			VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677392);
			VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677393);
			VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677394);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x001ECDD8 File Offset: 0x001EAFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221187, XrefRangeEnd = 221197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x001ECE14 File Offset: 0x001EB014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221224, RefRangeEnd = 221225, XrefRangeStart = 221197, XrefRangeEnd = 221224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleRecoveryPoint>(intPtr3) : null;
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x001ECE54 File Offset: 0x001EB054
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecoveryPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x00034F98 File Offset: 0x00033198
		public VehicleRecoveryPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x001ECE90 File Offset: 0x001EB090
		// (set) Token: 0x06006FD4 RID: 28628 RVA: 0x00034FA1 File Offset: 0x000331A1
		public unsafe static List<VehicleRecoveryPoint> recoveryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleRecoveryPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C6D RID: 19565
		private static readonly IntPtr NativeFieldInfoPtr_recoveryPoints;

		// Token: 0x04004C6E RID: 19566
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004C6F RID: 19567
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0;

		// Token: 0x04004C70 RID: 19568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
