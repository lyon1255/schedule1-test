using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000292 RID: 658
	[Serializable]
	public class SupplierData : NPCData
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0010A3FC File Offset: 0x001085FC
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierData()
		{
			Il2CppClassPointerStore<SupplierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SupplierData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierData>.NativeClassPtr);
			SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceMeetingStart");
			SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceLastMeetingEnd");
			SupplierData.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debt");
			SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "minsUntilDeadDropReady");
			SupplierData.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "deaddropItems");
			SupplierData.NativeFieldInfoPtr_debtReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debtReminderSent");
			SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, 100668807);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0010A4B8 File Offset: 0x001086B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130853, RefRangeEnd = 130854, XrefRangeStart = 130850, XrefRangeEnd = 130853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, Il2CppReferenceArray<StringIntPair> _deaddropItems, bool _debtReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceMeetingStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceLastMeetingEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minsUntilDeadDropReady;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_deaddropItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debtReminderSent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00019BA2 File Offset: 0x00017DA2
		public SupplierData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x0010A55C File Offset: 0x0010875C
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00019BAB File Offset: 0x00017DAB
		public unsafe int timeSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x0010A584 File Offset: 0x00108784
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x00019BC6 File Offset: 0x00017DC6
		public unsafe int timeSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x0010A5AC File Offset: 0x001087AC
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x00019BE1 File Offset: 0x00017DE1
		public unsafe float debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x0010A5D4 File Offset: 0x001087D4
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x00019BFC File Offset: 0x00017DFC
		public unsafe int minsUntilDeadDropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady)) = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x0010A5FC File Offset: 0x001087FC
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x00019C17 File Offset: 0x00017E17
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x0010A62C File Offset: 0x0010882C
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x00019C36 File Offset: 0x00017E36
		public unsafe bool debtReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent)) = value;
			}
		}

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceMeetingStart;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastMeetingEnd;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeFieldInfoPtr_minsUntilDeadDropReady;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeFieldInfoPtr_debtReminderSent;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0;
	}
}
