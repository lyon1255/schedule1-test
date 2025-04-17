using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041A RID: 1050
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x06005C34 RID: 23604 RVA: 0x001AB12C File Offset: 0x001A932C
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocation()
		{
			Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr);
			SupplierLocation.NativeFieldInfoPtr_AllLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "AllLocations");
			SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "<ActiveSupplier>k__BackingField");
			SupplierLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationName");
			SupplierLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationDescription");
			SupplierLocation.NativeFieldInfoPtr_GenericContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "GenericContainer");
			SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "SupplierStandPoint");
			SupplierLocation.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "DeliveryBays");
			SupplierLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "PoI");
			SupplierLocation.NativeFieldInfoPtr_configs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "configs");
			SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675067);
			SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675068);
			SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675069);
			SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675070);
			SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675071);
			SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675072);
			SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100675073);
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x001AB29C File Offset: 0x001A949C
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194593, XrefRangeEnd = 194597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06005C36 RID: 23606 RVA: 0x001AB2D8 File Offset: 0x001A94D8
		// (set) Token: 0x06005C37 RID: 23607 RVA: 0x001AB318 File Offset: 0x001A9518
		public unsafe Supplier ActiveSupplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x001AB35C File Offset: 0x001A955C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194597, XrefRangeEnd = 194622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C39 RID: 23609 RVA: 0x001AB390 File Offset: 0x001A9590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194622, XrefRangeEnd = 194630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C3A RID: 23610 RVA: 0x001AB3C4 File Offset: 0x001A95C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194667, RefRangeEnd = 194670, XrefRangeStart = 194630, XrefRangeEnd = 194667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x001AB408 File Offset: 0x001A9608
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x0002B715 File Offset: 0x00029915
		public SupplierLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x001AB444 File Offset: 0x001A9644
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x0002B71E File Offset: 0x0002991E
		public unsafe static List<SupplierLocation> AllLocations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SupplierLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06005C3F RID: 23615 RVA: 0x001AB46C File Offset: 0x001A966C
		// (set) Token: 0x06005C40 RID: 23616 RVA: 0x0002B730 File Offset: 0x00029930
		public unsafe Supplier _ActiveSupplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06005C41 RID: 23617 RVA: 0x001AB49C File Offset: 0x001A969C
		// (set) Token: 0x06005C42 RID: 23618 RVA: 0x0002B74F File Offset: 0x0002994F
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06005C43 RID: 23619 RVA: 0x001AB4C4 File Offset: 0x001A96C4
		// (set) Token: 0x06005C44 RID: 23620 RVA: 0x0002B76E File Offset: 0x0002996E
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06005C45 RID: 23621 RVA: 0x001AB4EC File Offset: 0x001A96EC
		// (set) Token: 0x06005C46 RID: 23622 RVA: 0x0002B78D File Offset: 0x0002998D
		public unsafe Transform GenericContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06005C47 RID: 23623 RVA: 0x001AB51C File Offset: 0x001A971C
		// (set) Token: 0x06005C48 RID: 23624 RVA: 0x0002B7AC File Offset: 0x000299AC
		public unsafe Transform SupplierStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06005C49 RID: 23625 RVA: 0x001AB54C File Offset: 0x001A974C
		// (set) Token: 0x06005C4A RID: 23626 RVA: 0x0002B7CB File Offset: 0x000299CB
		public unsafe Il2CppReferenceArray<WorldStorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06005C4B RID: 23627 RVA: 0x001AB57C File Offset: 0x001A977C
		// (set) Token: 0x06005C4C RID: 23628 RVA: 0x0002B7EA File Offset: 0x000299EA
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06005C4D RID: 23629 RVA: 0x001AB5AC File Offset: 0x001A97AC
		// (set) Token: 0x06005C4E RID: 23630 RVA: 0x0002B809 File Offset: 0x00029A09
		public unsafe Il2CppReferenceArray<SupplierLocationConfiguration> configs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SupplierLocationConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F17 RID: 16151
		private static readonly IntPtr NativeFieldInfoPtr_AllLocations;

		// Token: 0x04003F18 RID: 16152
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSupplier_k__BackingField;

		// Token: 0x04003F19 RID: 16153
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x04003F1A RID: 16154
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x04003F1B RID: 16155
		private static readonly IntPtr NativeFieldInfoPtr_GenericContainer;

		// Token: 0x04003F1C RID: 16156
		private static readonly IntPtr NativeFieldInfoPtr_SupplierStandPoint;

		// Token: 0x04003F1D RID: 16157
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04003F1E RID: 16158
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003F1F RID: 16159
		private static readonly IntPtr NativeFieldInfoPtr_configs;

		// Token: 0x04003F20 RID: 16160
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04003F21 RID: 16161
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0;

		// Token: 0x04003F22 RID: 16162
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0;

		// Token: 0x04003F23 RID: 16163
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04003F24 RID: 16164
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003F25 RID: 16165
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0;

		// Token: 0x04003F26 RID: 16166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
