using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025B RID: 603
	public class CustomerData : SaveData
	{
		// Token: 0x06002EB7 RID: 11959 RVA: 0x001059B0 File Offset: 0x00103BB0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_Dependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Dependence");
			CustomerData.NativeFieldInfoPtr_PurchaseableProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PurchaseableProducts");
			CustomerData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "ProductAffinities");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealCompleted");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealOffered");
			CustomerData.NativeFieldInfoPtr_OfferedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedDeals");
			CustomerData.NativeFieldInfoPtr_CompletedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CompletedDeals");
			CustomerData.NativeFieldInfoPtr_IsContractOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "IsContractOffered");
			CustomerData.NativeFieldInfoPtr_OfferedContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContract");
			CustomerData.NativeFieldInfoPtr_OfferedContractTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContractTime");
			CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSincePlayerApproached");
			CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceInstantDealOffered");
			CustomerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "HasBeenRecommended");
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100668726);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100668727);
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00105B0C File Offset: 0x00103D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130407, RefRangeEnd = 130408, XrefRangeStart = 130403, XrefRangeEnd = 130407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData(float dependence, Il2CppStringArray purchaseableProducts, Il2CppStructArray<float> productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, ContractInfo offeredContract, GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchaseableProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productAffinities);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealCompleted;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealOffered;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredDeals;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedDeals;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isContractOffered;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offeredContract);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSincePlayerApproached;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceInstantDealOffered;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00105C10 File Offset: 0x00103E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130409, RefRangeEnd = 130410, XrefRangeStart = 130408, XrefRangeEnd = 130409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00018A69 File Offset: 0x00016C69
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00105C4C File Offset: 0x00103E4C
		// (set) Token: 0x06002EBC RID: 11964 RVA: 0x00018A72 File Offset: 0x00016C72
		public unsafe float Dependence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence)) = value;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x00105C74 File Offset: 0x00103E74
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x00018A8D File Offset: 0x00016C8D
		public unsafe Il2CppStringArray PurchaseableProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PurchaseableProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PurchaseableProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x00105CA4 File Offset: 0x00103EA4
		// (set) Token: 0x06002EC0 RID: 11968 RVA: 0x00018AAC File Offset: 0x00016CAC
		public unsafe Il2CppStructArray<float> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x00105CD4 File Offset: 0x00103ED4
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x00018ACB File Offset: 0x00016CCB
		public unsafe int TimeSinceLastDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted)) = value;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x00105CFC File Offset: 0x00103EFC
		// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x00018AE6 File Offset: 0x00016CE6
		public unsafe int TimeSinceLastDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered)) = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x00105D24 File Offset: 0x00103F24
		// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x00018B01 File Offset: 0x00016D01
		public unsafe int OfferedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals)) = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x00105D4C File Offset: 0x00103F4C
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00018B1C File Offset: 0x00016D1C
		public unsafe int CompletedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals)) = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00105D74 File Offset: 0x00103F74
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00018B37 File Offset: 0x00016D37
		public unsafe bool IsContractOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered)) = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00105D9C File Offset: 0x00103F9C
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x00018B52 File Offset: 0x00016D52
		public unsafe ContractInfo OfferedContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002ECD RID: 11981 RVA: 0x00105DCC File Offset: 0x00103FCC
		// (set) Token: 0x06002ECE RID: 11982 RVA: 0x00018B71 File Offset: 0x00016D71
		public unsafe GameDateTime OfferedContractTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime)) = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x00105DF4 File Offset: 0x00103FF4
		// (set) Token: 0x06002ED0 RID: 11984 RVA: 0x00018B8C File Offset: 0x00016D8C
		public unsafe int TimeSincePlayerApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached)) = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x00105E1C File Offset: 0x0010401C
		// (set) Token: 0x06002ED2 RID: 11986 RVA: 0x00018BA7 File Offset: 0x00016DA7
		public unsafe int TimeSinceInstantDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered)) = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00105E44 File Offset: 0x00104044
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00018BC2 File Offset: 0x00016DC2
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeFieldInfoPtr_Dependence;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseableProducts;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealCompleted;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealOffered;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeFieldInfoPtr_OfferedDeals;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDeals;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeFieldInfoPtr_IsContractOffered;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContract;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContractTime;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePlayerApproached;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceInstantDealOffered;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStringArray_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
