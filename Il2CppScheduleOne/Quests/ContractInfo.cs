using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class ContractInfo : Object
	{
		// Token: 0x0600248B RID: 9355 RVA: 0x000E1F78 File Offset: 0x000E0178
		// Note: this type is marked as 'beforefieldinit'.
		static ContractInfo()
		{
			Il2CppClassPointerStore<ContractInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "ContractInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr);
			ContractInfo.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Payment");
			ContractInfo.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Products");
			ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryLocationGUID");
			ContractInfo.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryWindow");
			ContractInfo.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Expires");
			ContractInfo.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "ExpiresAfter");
			ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "PickupScheduleIndex");
			ContractInfo.NativeFieldInfoPtr_IsCounterOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "IsCounterOffer");
			ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "<DeliveryLocation>k__BackingField");
			ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667347);
			ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667348);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667349);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667350);
			ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667351);
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000E20C0 File Offset: 0x000E02C0
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x000E2100 File Offset: 0x000E0300
		public unsafe DeliveryLocation DeliveryLocation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000E2144 File Offset: 0x000E0344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113610, RefRangeEnd = 113612, XrefRangeStart = 113595, XrefRangeEnd = 113610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiresAfter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCounterOffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000E21FC File Offset: 0x000E03FC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000E2238 File Offset: 0x000E0438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113680, RefRangeEnd = 113683, XrefRangeStart = 113612, XrefRangeEnd = 113680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000147D6 File Offset: 0x000129D6
		public ContractInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000E2288 File Offset: 0x000E0488
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x000147DF File Offset: 0x000129DF
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000E22B0 File Offset: 0x000E04B0
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x000147FA File Offset: 0x000129FA
		public unsafe ProductList Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x000E22E0 File Offset: 0x000E04E0
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00014819 File Offset: 0x00012A19
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x000E2308 File Offset: 0x000E0508
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00014838 File Offset: 0x00012A38
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x000E2338 File Offset: 0x000E0538
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x00014857 File Offset: 0x00012A57
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000E2360 File Offset: 0x000E0560
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x00014872 File Offset: 0x00012A72
		public unsafe int ExpiresAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000E2388 File Offset: 0x000E0588
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0001488D File Offset: 0x00012A8D
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000E23B0 File Offset: 0x000E05B0
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x000148A8 File Offset: 0x00012AA8
		public unsafe bool IsCounterOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer)) = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000E23D8 File Offset: 0x000E05D8
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x000148C3 File Offset: 0x00012AC3
		public unsafe DeliveryLocation _DeliveryLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_IsCounterOffer;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryLocation_k__BackingField;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0;
	}
}
