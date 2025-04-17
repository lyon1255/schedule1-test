using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AF RID: 687
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x0600316E RID: 12654 RVA: 0x0010D524 File Offset: 0x0010B724
		// Note: this type is marked as 'beforefieldinit'.
		static ContractData()
		{
			Il2CppClassPointerStore<ContractData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ContractData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractData>.NativeClassPtr);
			ContractData.NativeFieldInfoPtr_CustomerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "CustomerGUID");
			ContractData.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "Payment");
			ContractData.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "ProductList");
			ContractData.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryLocationGUID");
			ContractData.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryWindow");
			ContractData.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "PickupScheduleIndex");
			ContractData.NativeFieldInfoPtr_AcceptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "AcceptTime");
			ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractData>.NativeClassPtr, 100668837);
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x0010D5F4 File Offset: 0x0010B7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131027, RefRangeEnd = 131028, XrefRangeStart = 131021, XrefRangeEnd = 131027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customerGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptTime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x0001A6BF File Offset: 0x000188BF
		public ContractData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x0010D738 File Offset: 0x0010B938
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x0001A6C8 File Offset: 0x000188C8
		public unsafe string CustomerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x0010D760 File Offset: 0x0010B960
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x0001A6E7 File Offset: 0x000188E7
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x0010D788 File Offset: 0x0010B988
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x0001A702 File Offset: 0x00018902
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x0010D7B8 File Offset: 0x0010B9B8
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x0001A721 File Offset: 0x00018921
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x0010D7E0 File Offset: 0x0010B9E0
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x0001A740 File Offset: 0x00018940
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x0010D810 File Offset: 0x0010BA10
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x0001A75F File Offset: 0x0001895F
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x0010D838 File Offset: 0x0010BA38
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x0001A77A File Offset: 0x0001897A
		public unsafe GameDateTimeData AcceptTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeFieldInfoPtr_CustomerGUID;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_AcceptTime;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0;
	}
}
