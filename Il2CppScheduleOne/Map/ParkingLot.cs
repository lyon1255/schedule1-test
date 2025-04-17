using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000782 RID: 1922
	public class ParkingLot : MonoBehaviour
	{
		// Token: 0x0600B5DC RID: 46556 RVA: 0x002D30A8 File Offset: 0x002D12A8
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingLot()
		{
			Il2CppClassPointerStore<ParkingLot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingLot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr);
			ParkingLot.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "BakedGUID");
			ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<GUID>k__BackingField");
			ParkingLot.NativeFieldInfoPtr_ParkingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ParkingSpots");
			ParkingLot.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "EntryPoint");
			ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "HiddenVehicleAccessPoint");
			ParkingLot.NativeFieldInfoPtr_UseExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "UseExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitAlignment");
			ParkingLot.NativeFieldInfoPtr_ExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPointVehicleDetector");
			ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685660);
			ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685661);
			ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685662);
			ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685663);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685664);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685665);
			ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685666);
			ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100685667);
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600B5DD RID: 46557 RVA: 0x002D322C File Offset: 0x002D142C
		// (set) Token: 0x0600B5DE RID: 46558 RVA: 0x002D3268 File Offset: 0x002D1468
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 54188, RefRangeEnd = 54192, XrefRangeStart = 54188, XrefRangeEnd = 54192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B5DF RID: 46559 RVA: 0x002D32A8 File Offset: 0x002D14A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310543, XrefRangeEnd = 310572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x002D32DC File Offset: 0x002D14DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310572, XrefRangeEnd = 310576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x002D331C File Offset: 0x002D151C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310593, RefRangeEnd = 310594, XrefRangeStart = 310576, XrefRangeEnd = 310593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot GetRandomFreeSpot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x002D335C File Offset: 0x002D155C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310603, RefRangeEnd = 310605, XrefRangeStart = 310594, XrefRangeEnd = 310603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomFreeSpotIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x002D3398 File Offset: 0x002D1598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310633, RefRangeEnd = 310635, XrefRangeStart = 310605, XrefRangeEnd = 310633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ParkingSpot> GetFreeParkingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr3) : null;
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x002D33D8 File Offset: 0x002D15D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310635, XrefRangeEnd = 310646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingLot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x00059412 File Offset: 0x00057612
		public ParkingLot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002D3414 File Offset: 0x002D1614
		// (set) Token: 0x0600B5E7 RID: 46567 RVA: 0x0005941B File Offset: 0x0005761B
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x002D343C File Offset: 0x002D163C
		// (set) Token: 0x0600B5E9 RID: 46569 RVA: 0x0005943A File Offset: 0x0005763A
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600B5EA RID: 46570 RVA: 0x002D3464 File Offset: 0x002D1664
		// (set) Token: 0x0600B5EB RID: 46571 RVA: 0x00059455 File Offset: 0x00057655
		public unsafe List<ParkingSpot> ParkingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600B5EC RID: 46572 RVA: 0x002D3494 File Offset: 0x002D1694
		// (set) Token: 0x0600B5ED RID: 46573 RVA: 0x00059474 File Offset: 0x00057674
		public unsafe Transform EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600B5EE RID: 46574 RVA: 0x002D34C4 File Offset: 0x002D16C4
		// (set) Token: 0x0600B5EF RID: 46575 RVA: 0x00059493 File Offset: 0x00057693
		public unsafe Transform HiddenVehicleAccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600B5F0 RID: 46576 RVA: 0x002D34F4 File Offset: 0x002D16F4
		// (set) Token: 0x0600B5F1 RID: 46577 RVA: 0x000594B2 File Offset: 0x000576B2
		public unsafe bool UseExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint)) = value;
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x002D351C File Offset: 0x002D171C
		// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x000594CD File Offset: 0x000576CD
		public unsafe EParkingAlignment ExitAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment)) = value;
			}
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x002D3544 File Offset: 0x002D1744
		// (set) Token: 0x0600B5F5 RID: 46581 RVA: 0x000594E8 File Offset: 0x000576E8
		public unsafe Transform ExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600B5F6 RID: 46582 RVA: 0x002D3574 File Offset: 0x002D1774
		// (set) Token: 0x0600B5F7 RID: 46583 RVA: 0x00059507 File Offset: 0x00057707
		public unsafe VehicleDetector ExitPointVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A88 RID: 31368
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007A89 RID: 31369
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007A8A RID: 31370
		private static readonly IntPtr NativeFieldInfoPtr_ParkingSpots;

		// Token: 0x04007A8B RID: 31371
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04007A8C RID: 31372
		private static readonly IntPtr NativeFieldInfoPtr_HiddenVehicleAccessPoint;

		// Token: 0x04007A8D RID: 31373
		private static readonly IntPtr NativeFieldInfoPtr_UseExitPoint;

		// Token: 0x04007A8E RID: 31374
		private static readonly IntPtr NativeFieldInfoPtr_ExitAlignment;

		// Token: 0x04007A8F RID: 31375
		private static readonly IntPtr NativeFieldInfoPtr_ExitPoint;

		// Token: 0x04007A90 RID: 31376
		private static readonly IntPtr NativeFieldInfoPtr_ExitPointVehicleDetector;

		// Token: 0x04007A91 RID: 31377
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007A92 RID: 31378
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007A93 RID: 31379
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007A94 RID: 31380
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007A95 RID: 31381
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0;

		// Token: 0x04007A96 RID: 31382
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0;

		// Token: 0x04007A97 RID: 31383
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0;

		// Token: 0x04007A98 RID: 31384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C01 RID: 3073
		[ObfuscatedName("ScheduleOne.Map.ParkingLot+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E005 RID: 57349 RVA: 0x0034C18C File Offset: 0x0034A38C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr);
				ParkingLot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9");
				ParkingLot.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9__16_0");
				ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100685669);
				ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100685670);
			}

			// Token: 0x0600E006 RID: 57350 RVA: 0x0034C208 File Offset: 0x0034A408
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E007 RID: 57351 RVA: 0x0034C244 File Offset: 0x0034A444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310539, XrefRangeEnd = 310543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeParkingSpots_b__16_0(ParkingSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E008 RID: 57352 RVA: 0x0006D3A7 File Offset: 0x0006B5A7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456B RID: 17771
			// (get) Token: 0x0600E009 RID: 57353 RVA: 0x0034C294 File Offset: 0x0034A494
			// (set) Token: 0x0600E00A RID: 57354 RVA: 0x0006D3B0 File Offset: 0x0006B5B0
			public unsafe static ParkingLot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456C RID: 17772
			// (get) Token: 0x0600E00B RID: 57355 RVA: 0x0034C2BC File Offset: 0x0034A4BC
			// (set) Token: 0x0600E00C RID: 57356 RVA: 0x0006D3C2 File Offset: 0x0006B5C2
			public unsafe static Func<ParkingSpot, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParkingSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009602 RID: 38402
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009603 RID: 38403
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009604 RID: 38404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009605 RID: 38405
			private static readonly IntPtr NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0;
		}
	}
}
