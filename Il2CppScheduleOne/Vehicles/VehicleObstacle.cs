using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F0 RID: 1264
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x06006FC5 RID: 28613 RVA: 0x001ECC1C File Offset: 0x001EAE1C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleObstacle()
		{
			Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr);
			VehicleObstacle.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "col");
			VehicleObstacle.NativeFieldInfoPtr_twoSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "twoSided");
			VehicleObstacle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "type");
			VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, 100677391);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001ECC9C File Offset: 0x001EAE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221186, XrefRangeEnd = 221187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00034F3A File Offset: 0x0003313A
		public VehicleObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06006FC8 RID: 28616 RVA: 0x001ECCD8 File Offset: 0x001EAED8
		// (set) Token: 0x06006FC9 RID: 28617 RVA: 0x00034F43 File Offset: 0x00033143
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x001ECD08 File Offset: 0x001EAF08
		// (set) Token: 0x06006FCB RID: 28619 RVA: 0x00034F62 File Offset: 0x00033162
		public unsafe bool twoSided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided)) = value;
			}
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006FCC RID: 28620 RVA: 0x001ECD30 File Offset: 0x001EAF30
		// (set) Token: 0x06006FCD RID: 28621 RVA: 0x00034F7D File Offset: 0x0003317D
		public unsafe VehicleObstacle.EObstacleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04004C69 RID: 19561
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04004C6A RID: 19562
		private static readonly IntPtr NativeFieldInfoPtr_twoSided;

		// Token: 0x04004C6B RID: 19563
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04004C6C RID: 19564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6B RID: 2667
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleType")]
		public enum EObstacleType
		{
			// Token: 0x04008D19 RID: 36121
			Generic,
			// Token: 0x04008D1A RID: 36122
			TrafficLight
		}
	}
}
