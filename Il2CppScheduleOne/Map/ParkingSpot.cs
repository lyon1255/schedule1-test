using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000783 RID: 1923
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x0600B5F8 RID: 46584 RVA: 0x002D35A4 File Offset: 0x002D17A4
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingSpot()
		{
			Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr);
			ParkingSpot.NativeFieldInfoPtr_ParentLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "ParentLot");
			ParkingSpot.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "AlignmentPoint");
			ParkingSpot.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "Alignment");
			ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "OccupantVehicle_Readonly");
			ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "<OccupantVehicle>k__BackingField");
			ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685671);
			ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685672);
			ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685673);
			ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685674);
			ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685675);
			ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100685676);
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600B5F9 RID: 46585 RVA: 0x002D36B0 File Offset: 0x002D18B0
		// (set) Token: 0x0600B5FA RID: 46586 RVA: 0x002D36F0 File Offset: 0x002D18F0
		public unsafe LandVehicle OccupantVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x002D3734 File Offset: 0x002D1934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310646, XrefRangeEnd = 310678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5FC RID: 46588 RVA: 0x002D3768 File Offset: 0x002D1968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310678, XrefRangeEnd = 310701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x002D379C File Offset: 0x002D199C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310703, RefRangeEnd = 310705, XrefRangeStart = 310701, XrefRangeEnd = 310703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x002D37E0 File Offset: 0x002D19E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5FF RID: 46591 RVA: 0x00059526 File Offset: 0x00057726
		public ParkingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600B600 RID: 46592 RVA: 0x002D381C File Offset: 0x002D1A1C
		// (set) Token: 0x0600B601 RID: 46593 RVA: 0x0005952F File Offset: 0x0005772F
		public unsafe ParkingLot ParentLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600B602 RID: 46594 RVA: 0x002D384C File Offset: 0x002D1A4C
		// (set) Token: 0x0600B603 RID: 46595 RVA: 0x0005954E File Offset: 0x0005774E
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600B604 RID: 46596 RVA: 0x002D387C File Offset: 0x002D1A7C
		// (set) Token: 0x0600B605 RID: 46597 RVA: 0x0005956D File Offset: 0x0005776D
		public unsafe EParkingAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600B606 RID: 46598 RVA: 0x002D38A4 File Offset: 0x002D1AA4
		// (set) Token: 0x0600B607 RID: 46599 RVA: 0x00059588 File Offset: 0x00057788
		public unsafe LandVehicle OccupantVehicle_Readonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x002D38D4 File Offset: 0x002D1AD4
		// (set) Token: 0x0600B609 RID: 46601 RVA: 0x000595A7 File Offset: 0x000577A7
		public unsafe LandVehicle _OccupantVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A99 RID: 31385
		private static readonly IntPtr NativeFieldInfoPtr_ParentLot;

		// Token: 0x04007A9A RID: 31386
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04007A9B RID: 31387
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04007A9C RID: 31388
		private static readonly IntPtr NativeFieldInfoPtr_OccupantVehicle_Readonly;

		// Token: 0x04007A9D RID: 31389
		private static readonly IntPtr NativeFieldInfoPtr__OccupantVehicle_k__BackingField;

		// Token: 0x04007A9E RID: 31390
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0;

		// Token: 0x04007A9F RID: 31391
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04007AA0 RID: 31392
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007AA1 RID: 31393
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007AA2 RID: 31394
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0;

		// Token: 0x04007AA3 RID: 31395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
