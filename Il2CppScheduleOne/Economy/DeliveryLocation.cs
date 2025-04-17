using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000415 RID: 1045
	public class DeliveryLocation : MonoBehaviour
	{
		// Token: 0x06005B89 RID: 23433 RVA: 0x001A8B20 File Offset: 0x001A6D20
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryLocation()
		{
			Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeliveryLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr);
			DeliveryLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationName");
			DeliveryLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "LocationDescription");
			DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "CustomerStandPoint");
			DeliveryLocation.NativeFieldInfoPtr_TeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "TeleportPoint");
			DeliveryLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "PoI");
			DeliveryLocation.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "StaticGUID");
			DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "ScheduledContracts");
			DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, "<GUID>k__BackingField");
			DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674974);
			DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674975);
			DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674976);
			DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674977);
			DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674978);
			DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674979);
			DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr, 100674980);
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001A8C7C File Offset: 0x001A6E7C
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x001A8CB8 File Offset: 0x001A6EB8
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x001A8CF8 File Offset: 0x001A6EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193317, XrefRangeEnd = 193321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x001A8D38 File Offset: 0x001A6F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193321, XrefRangeEnd = 193342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x001A8D6C File Offset: 0x001A6F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x001A8DA0 File Offset: 0x001A6FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryLocation.NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x001A8DE4 File Offset: 0x001A6FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193342, XrefRangeEnd = 193357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x0002B29B File Offset: 0x0002949B
		public DeliveryLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x001A8E20 File Offset: 0x001A7020
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x0002B2A4 File Offset: 0x000294A4
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001A8E48 File Offset: 0x001A7048
		// (set) Token: 0x06005B95 RID: 23445 RVA: 0x0002B2C3 File Offset: 0x000294C3
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x001A8E70 File Offset: 0x001A7070
		// (set) Token: 0x06005B97 RID: 23447 RVA: 0x0002B2E2 File Offset: 0x000294E2
		public unsafe Transform CustomerStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_CustomerStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x001A8EA0 File Offset: 0x001A70A0
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x0002B301 File Offset: 0x00029501
		public unsafe Transform TeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_TeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x001A8ED0 File Offset: 0x001A70D0
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x0002B320 File Offset: 0x00029520
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x001A8F00 File Offset: 0x001A7100
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x0002B33F File Offset: 0x0002953F
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x001A8F28 File Offset: 0x001A7128
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0002B35E File Offset: 0x0002955E
		public unsafe List<Contract> ScheduledContracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr_ScheduledContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x001A8F58 File Offset: 0x001A7158
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0002B37D File Offset: 0x0002957D
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryLocation.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeFieldInfoPtr_CustomerStandPoint;

		// Token: 0x04003E9B RID: 16027
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPoint;

		// Token: 0x04003E9C RID: 16028
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003E9D RID: 16029
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04003E9E RID: 16030
		private static readonly IntPtr NativeFieldInfoPtr_ScheduledContracts;

		// Token: 0x04003E9F RID: 16031
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003EA0 RID: 16032
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003EA1 RID: 16033
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003EA2 RID: 16034
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003EA3 RID: 16035
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003EA4 RID: 16036
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003EA5 RID: 16037
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Virtual_New_String_0;

		// Token: 0x04003EA6 RID: 16038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
