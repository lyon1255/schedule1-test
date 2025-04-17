using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F2 RID: 1266
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x06006FD5 RID: 28629 RVA: 0x001ECEB8 File Offset: 0x001EB0B8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSeat()
		{
			Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr);
			VehicleSeat.NativeFieldInfoPtr_isDriverSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "isDriverSeat");
			VehicleSeat.NativeFieldInfoPtr_Occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "Occupant");
			VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677396);
			VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100677397);
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06006FD6 RID: 28630 RVA: 0x001ECF38 File Offset: 0x001EB138
		public unsafe bool isOccupied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 221229, RefRangeEnd = 221231, XrefRangeStart = 221225, XrefRangeEnd = 221229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x001ECF74 File Offset: 0x001EB174
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FD8 RID: 28632 RVA: 0x00034FB3 File Offset: 0x000331B3
		public VehicleSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x001ECFB0 File Offset: 0x001EB1B0
		// (set) Token: 0x06006FDA RID: 28634 RVA: 0x00034FBC File Offset: 0x000331BC
		public unsafe bool isDriverSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat)) = value;
			}
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x001ECFD8 File Offset: 0x001EB1D8
		// (set) Token: 0x06006FDC RID: 28636 RVA: 0x00034FD7 File Offset: 0x000331D7
		public unsafe Player Occupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C71 RID: 19569
		private static readonly IntPtr NativeFieldInfoPtr_isDriverSeat;

		// Token: 0x04004C72 RID: 19570
		private static readonly IntPtr NativeFieldInfoPtr_Occupant;

		// Token: 0x04004C73 RID: 19571
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004C74 RID: 19572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
