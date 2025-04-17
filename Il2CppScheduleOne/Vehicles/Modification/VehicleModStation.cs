using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x020004FA RID: 1274
	public class VehicleModStation : MonoBehaviour
	{
		// Token: 0x06007090 RID: 28816 RVA: 0x001EECD8 File Offset: 0x001ECED8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleModStation()
		{
			Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleModStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr);
			VehicleModStation.NativeFieldInfoPtr_vehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "vehiclePosition");
			VehicleModStation.NativeFieldInfoPtr_orbitCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "orbitCam");
			VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "<currentVehicle>k__BackingField");
			VehicleModStation.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677444);
			VehicleModStation.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677445);
			VehicleModStation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677446);
			VehicleModStation.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677447);
			VehicleModStation.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677448);
			VehicleModStation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677449);
			VehicleModStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677450);
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x001EEDD0 File Offset: 0x001ECFD0
		// (set) Token: 0x06007092 RID: 28818 RVA: 0x001EEE10 File Offset: 0x001ED010
		public unsafe LandVehicle currentVehicle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x001EEE54 File Offset: 0x001ED054
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221573, XrefRangeEnd = 221577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x001EEE90 File Offset: 0x001ED090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221577, XrefRangeEnd = 221633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x001EEED4 File Offset: 0x001ED0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221633, XrefRangeEnd = 221654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModStation.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x001EEF10 File Offset: 0x001ED110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221654, XrefRangeEnd = 221668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x001EEF44 File Offset: 0x001ED144
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleModStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x00035700 File Offset: 0x00033900
		public VehicleModStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x001EEF80 File Offset: 0x001ED180
		// (set) Token: 0x0600709A RID: 28826 RVA: 0x00035709 File Offset: 0x00033909
		public unsafe Transform vehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_vehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_vehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600709B RID: 28827 RVA: 0x001EEFB0 File Offset: 0x001ED1B0
		// (set) Token: 0x0600709C RID: 28828 RVA: 0x00035728 File Offset: 0x00033928
		public unsafe OrbitCamera orbitCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_orbitCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_orbitCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600709D RID: 28829 RVA: 0x001EEFE0 File Offset: 0x001ED1E0
		// (set) Token: 0x0600709E RID: 28830 RVA: 0x00035747 File Offset: 0x00033947
		public unsafe LandVehicle _currentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CEE RID: 19694
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePosition;

		// Token: 0x04004CEF RID: 19695
		private static readonly IntPtr NativeFieldInfoPtr_orbitCam;

		// Token: 0x04004CF0 RID: 19696
		private static readonly IntPtr NativeFieldInfoPtr__currentVehicle_k__BackingField;

		// Token: 0x04004CF1 RID: 19697
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0;

		// Token: 0x04004CF2 RID: 19698
		private static readonly IntPtr NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04004CF3 RID: 19699
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04004CF4 RID: 19700
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0;

		// Token: 0x04004CF5 RID: 19701
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004CF6 RID: 19702
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004CF7 RID: 19703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
