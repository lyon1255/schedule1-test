using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x02000479 RID: 1145
	[Serializable]
	public class DeliveryInstance : Object
	{
		// Token: 0x060062ED RID: 25325 RVA: 0x001C1164 File Offset: 0x001BF364
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryInstance()
		{
			Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr);
			DeliveryInstance.NativeFieldInfoPtr_DeliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DeliveryID");
			DeliveryInstance.NativeFieldInfoPtr_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "StoreName");
			DeliveryInstance.NativeFieldInfoPtr_DestinationCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DestinationCode");
			DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "LoadingDockIndex");
			DeliveryInstance.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Items");
			DeliveryInstance.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Status");
			DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "TimeUntilArrival");
			DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "<ActiveVehicle>k__BackingField");
			DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675833);
			DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675834);
			DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675835);
			DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675836);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675837);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675838);
			DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675839);
			DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675840);
			DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675841);
			DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675842);
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x001C1310 File Offset: 0x001BF510
		// (set) Token: 0x060062EF RID: 25327 RVA: 0x001C1350 File Offset: 0x001BF550
		public unsafe DeliveryVehicle ActiveVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x001C1394 File Offset: 0x001BF594
		public unsafe Property Destination
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 202681, RefRangeEnd = 202688, XrefRangeStart = 202675, XrefRangeEnd = 202681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060062F1 RID: 25329 RVA: 0x001C13D4 File Offset: 0x001BF5D4
		public unsafe LoadingDock LoadingDock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202688, XrefRangeEnd = 202689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadingDock>(intPtr3) : null;
			}
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x001C1414 File Offset: 0x001BF614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202694, RefRangeEnd = 202695, XrefRangeStart = 202689, XrefRangeEnd = 202694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, Il2CppReferenceArray<StringIntPair> items, EDeliveryStatus status, int timeUntilArrival) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUntilArrival;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x001C14C0 File Offset: 0x001BF6C0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x001C14FC File Offset: 0x001BF6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202695, RefRangeEnd = 202696, XrefRangeStart = 202695, XrefRangeEnd = 202695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTimeStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x001C1538 File Offset: 0x001BF738
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202738, RefRangeEnd = 202741, XrefRangeStart = 202696, XrefRangeEnd = 202738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x001C1578 File Offset: 0x001BF778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202750, RefRangeEnd = 202751, XrefRangeStart = 202741, XrefRangeEnd = 202750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemsToDeliveryVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x001C15AC File Offset: 0x001BF7AC
		[CallerCount(0)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_OnMinPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x0002EC9C File Offset: 0x0002CE9C
		public DeliveryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060062F9 RID: 25337 RVA: 0x001C15E0 File Offset: 0x001BF7E0
		// (set) Token: 0x060062FA RID: 25338 RVA: 0x0002ECA5 File Offset: 0x0002CEA5
		public unsafe string DeliveryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x001C1608 File Offset: 0x001BF808
		// (set) Token: 0x060062FC RID: 25340 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
		public unsafe string StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060062FD RID: 25341 RVA: 0x001C1630 File Offset: 0x001BF830
		// (set) Token: 0x060062FE RID: 25342 RVA: 0x0002ECE3 File Offset: 0x0002CEE3
		public unsafe string DestinationCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x060062FF RID: 25343 RVA: 0x001C1658 File Offset: 0x001BF858
		// (set) Token: 0x06006300 RID: 25344 RVA: 0x0002ED02 File Offset: 0x0002CF02
		public unsafe int LoadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex)) = value;
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06006301 RID: 25345 RVA: 0x001C1680 File Offset: 0x001BF880
		// (set) Token: 0x06006302 RID: 25346 RVA: 0x0002ED1D File Offset: 0x0002CF1D
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06006303 RID: 25347 RVA: 0x001C16B0 File Offset: 0x001BF8B0
		// (set) Token: 0x06006304 RID: 25348 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		public unsafe EDeliveryStatus Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x001C16D8 File Offset: 0x001BF8D8
		// (set) Token: 0x06006306 RID: 25350 RVA: 0x0002ED57 File Offset: 0x0002CF57
		public unsafe int TimeUntilArrival
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival)) = value;
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x001C1700 File Offset: 0x001BF900
		// (set) Token: 0x06006308 RID: 25352 RVA: 0x0002ED72 File Offset: 0x0002CF72
		public unsafe DeliveryVehicle _ActiveVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06006309 RID: 25353 RVA: 0x001C1730 File Offset: 0x001BF930
		// (set) Token: 0x0600630A RID: 25354 RVA: 0x0002ED91 File Offset: 0x0002CF91
		public unsafe UnityEvent onDeliveryCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryID;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeFieldInfoPtr_StoreName;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeFieldInfoPtr_DestinationCode;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockIndex;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeFieldInfoPtr_TimeUntilArrival;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeFieldInfoPtr__ActiveVehicle_k__BackingField;

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0;

		// Token: 0x04004388 RID: 17288
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0;

		// Token: 0x04004389 RID: 17289
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_Property_0;

		// Token: 0x0400438A RID: 17290
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0;

		// Token: 0x0400438B RID: 17291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0;

		// Token: 0x0400438C RID: 17292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0;

		// Token: 0x04004390 RID: 17296
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Public_Void_0;
	}
}
