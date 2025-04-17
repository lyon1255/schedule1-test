using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F7 RID: 1271
	public class VehicleRecorder : MonoBehaviour
	{
		// Token: 0x06007079 RID: 28793 RVA: 0x001EE8A4 File Offset: 0x001ECAA4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecorder()
		{
			Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr);
			VehicleRecorder.NativeFieldInfoPtr_frameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "frameRate");
			VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "IS_RECORDING");
			VehicleRecorder.NativeFieldInfoPtr_keyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "keyFrames");
			VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "vehicleToRecord");
			VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "timeSinceKeyFrame");
			VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677431);
			VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677432);
			VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677433);
			VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677434);
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x001EE988 File Offset: 0x001ECB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221424, XrefRangeEnd = 221451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x001EE9C4 File Offset: 0x001ECBC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221511, RefRangeEnd = 221512, XrefRangeStart = 221451, XrefRangeEnd = 221511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame Capture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame>(intPtr3) : null;
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x001EEA04 File Offset: 0x001ECC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221512, XrefRangeEnd = 221527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame.WheelTransform>(intPtr3) : null;
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x001EEA54 File Offset: 0x001ECC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221527, XrefRangeEnd = 221535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecorder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x0003564D File Offset: 0x0003384D
		public VehicleRecorder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x001EEA90 File Offset: 0x001ECC90
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x00035656 File Offset: 0x00033856
		public unsafe static int frameRate
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&value));
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x001EEAAC File Offset: 0x001ECCAC
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x00035664 File Offset: 0x00033864
		public unsafe bool IS_RECORDING
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING)) = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x001EEAD4 File Offset: 0x001ECCD4
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x0003567F File Offset: 0x0003387F
		public unsafe List<VehicleKeyFrame> keyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x001EEB04 File Offset: 0x001ECD04
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x0003569E File Offset: 0x0003389E
		public unsafe LandVehicle vehicleToRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x001EEB34 File Offset: 0x001ECD34
		// (set) Token: 0x06007088 RID: 28808 RVA: 0x000356BD File Offset: 0x000338BD
		public unsafe float timeSinceKeyFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame)) = value;
			}
		}

		// Token: 0x04004CCF RID: 19663
		private static readonly IntPtr NativeFieldInfoPtr_frameRate;

		// Token: 0x04004CD0 RID: 19664
		private static readonly IntPtr NativeFieldInfoPtr_IS_RECORDING;

		// Token: 0x04004CD1 RID: 19665
		private static readonly IntPtr NativeFieldInfoPtr_keyFrames;

		// Token: 0x04004CD2 RID: 19666
		private static readonly IntPtr NativeFieldInfoPtr_vehicleToRecord;

		// Token: 0x04004CD3 RID: 19667
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceKeyFrame;

		// Token: 0x04004CD4 RID: 19668
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004CD5 RID: 19669
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0;

		// Token: 0x04004CD6 RID: 19670
		private static readonly IntPtr NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0;

		// Token: 0x04004CD7 RID: 19671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
