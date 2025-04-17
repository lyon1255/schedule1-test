using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000428 RID: 1064
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06005D9F RID: 23967 RVA: 0x001AFD3C File Offset: 0x001ADF3C
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRollerDoors()
		{
			Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SensorRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr);
			SensorRollerDoors.NativeFieldInfoPtr_Detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "Detector");
			SensorRollerDoors.NativeFieldInfoPtr_ClipDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "ClipDetector");
			SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "DetectPlayerOccupiedVehiclesOnly");
			SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675211);
			SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675212);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x001AFDD0 File Offset: 0x001ADFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195958, XrefRangeEnd = 195969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x001AFE0C File Offset: 0x001AE00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0002C23C File Offset: 0x0002A43C
		public SensorRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06005DA3 RID: 23971 RVA: 0x001AFE48 File Offset: 0x001AE048
		// (set) Token: 0x06005DA4 RID: 23972 RVA: 0x0002C245 File Offset: 0x0002A445
		public unsafe VehicleDetector Detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06005DA5 RID: 23973 RVA: 0x001AFE78 File Offset: 0x001AE078
		// (set) Token: 0x06005DA6 RID: 23974 RVA: 0x0002C264 File Offset: 0x0002A464
		public unsafe VehicleDetector ClipDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005DA7 RID: 23975 RVA: 0x001AFEA8 File Offset: 0x001AE0A8
		// (set) Token: 0x06005DA8 RID: 23976 RVA: 0x0002C283 File Offset: 0x0002A483
		public unsafe bool DetectPlayerOccupiedVehiclesOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly)) = value;
			}
		}

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeFieldInfoPtr_Detector;

		// Token: 0x04004011 RID: 16401
		private static readonly IntPtr NativeFieldInfoPtr_ClipDetector;

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly;

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
