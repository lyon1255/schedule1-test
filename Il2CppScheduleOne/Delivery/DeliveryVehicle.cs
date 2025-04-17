using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200047B RID: 1147
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x0600634D RID: 25421 RVA: 0x001C296C File Offset: 0x001C0B6C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryVehicle()
		{
			Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr);
			DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<Vehicle>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<ActiveDelivery>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "GUID");
			DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675893);
			DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675894);
			DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675895);
			DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675896);
			DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675897);
			DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675898);
			DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675899);
			DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675900);
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600634E RID: 25422 RVA: 0x001C2A78 File Offset: 0x001C0C78
		// (set) Token: 0x0600634F RID: 25423 RVA: 0x001C2AB8 File Offset: 0x001C0CB8
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x001C2AFC File Offset: 0x001C0CFC
		// (set) Token: 0x06006351 RID: 25425 RVA: 0x001C2B3C File Offset: 0x001C0D3C
		public unsafe DeliveryInstance ActiveDelivery
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x001C2B80 File Offset: 0x001C0D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203263, XrefRangeEnd = 203269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x001C2BB4 File Offset: 0x001C0DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203295, RefRangeEnd = 203296, XrefRangeStart = 203269, XrefRangeEnd = 203295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x001C2BF8 File Offset: 0x001C0DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 203317, RefRangeEnd = 203319, XrefRangeStart = 203296, XrefRangeEnd = 203317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x001C2C2C File Offset: 0x001C0E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203319, XrefRangeEnd = 203323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x0002EF02 File Offset: 0x0002D102
		public DeliveryVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x001C2C68 File Offset: 0x001C0E68
		// (set) Token: 0x06006358 RID: 25432 RVA: 0x0002EF0B File Offset: 0x0002D10B
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x001C2C98 File Offset: 0x001C0E98
		// (set) Token: 0x0600635A RID: 25434 RVA: 0x0002EF2A File Offset: 0x0002D12A
		public unsafe DeliveryInstance _ActiveDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600635B RID: 25435 RVA: 0x001C2CC8 File Offset: 0x001C0EC8
		// (set) Token: 0x0600635C RID: 25436 RVA: 0x0002EF49 File Offset: 0x0002D149
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040043C6 RID: 17350
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x040043C7 RID: 17351
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDelivery_k__BackingField;

		// Token: 0x040043C8 RID: 17352
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x040043C9 RID: 17353
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x040043CA RID: 17354
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x040043CB RID: 17355
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0;

		// Token: 0x040043CC RID: 17356
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0;

		// Token: 0x040043CD RID: 17357
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040043CE RID: 17358
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0;

		// Token: 0x040043CF RID: 17359
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x040043D0 RID: 17360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
