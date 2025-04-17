using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000727 RID: 1831
	public class Transaction : Object
	{
		// Token: 0x0600A566 RID: 42342 RVA: 0x002969F4 File Offset: 0x00294BF4
		// Note: this type is marked as 'beforefieldinit'.
		static Transaction()
		{
			Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "Transaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
			Transaction.NativeFieldInfoPtr_transaction_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Name");
			Transaction.NativeFieldInfoPtr_unit_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "unit_Amount");
			Transaction.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "quantity");
			Transaction.NativeFieldInfoPtr_transaction_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Note");
			Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100683532);
			Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100683533);
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x00296A9C File Offset: 0x00294C9C
		public unsafe float total_Amount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x00296AD8 File Offset: 0x00294CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289061, XrefRangeEnd = 289069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x00051774 File Offset: 0x0004F974
		public Transaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A56A RID: 42346 RVA: 0x00296B54 File Offset: 0x00294D54
		// (set) Token: 0x0600A56B RID: 42347 RVA: 0x0005177D File Offset: 0x0004F97D
		public unsafe string transaction_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x00296B7C File Offset: 0x00294D7C
		// (set) Token: 0x0600A56D RID: 42349 RVA: 0x0005179C File Offset: 0x0004F99C
		public unsafe float unit_Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount)) = value;
			}
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x00296BA4 File Offset: 0x00294DA4
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x000517B7 File Offset: 0x0004F9B7
		public unsafe float quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A570 RID: 42352 RVA: 0x00296BCC File Offset: 0x00294DCC
		// (set) Token: 0x0600A571 RID: 42353 RVA: 0x000517D2 File Offset: 0x0004F9D2
		public unsafe string transaction_Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04006EEC RID: 28396
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Name;

		// Token: 0x04006EED RID: 28397
		private static readonly IntPtr NativeFieldInfoPtr_unit_Amount;

		// Token: 0x04006EEE RID: 28398
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x04006EEF RID: 28399
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Note;

		// Token: 0x04006EF0 RID: 28400
		private static readonly IntPtr NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0;

		// Token: 0x04006EF1 RID: 28401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0;
	}
}
