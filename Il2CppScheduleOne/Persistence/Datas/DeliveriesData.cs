using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025D RID: 605
	public class DeliveriesData : SaveData
	{
		// Token: 0x06002EE5 RID: 12005 RVA: 0x001060B0 File Offset: 0x001042B0
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesData()
		{
			Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeliveriesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr);
			DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "ActiveDeliveries");
			DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, 100668730);
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00106108 File Offset: 0x00104308
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesData(Il2CppReferenceArray<DeliveryInstance> deliveries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(deliveries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00018C88 File Offset: 0x00016E88
		public DeliveriesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x00106154 File Offset: 0x00104354
		// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x00018C91 File Offset: 0x00016E91
		public unsafe Il2CppReferenceArray<DeliveryInstance> ActiveDeliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDeliveries;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_0;
	}
}
