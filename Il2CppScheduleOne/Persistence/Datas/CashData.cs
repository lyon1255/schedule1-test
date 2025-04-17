using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000262 RID: 610
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x00106B40 File Offset: 0x00104D40
		// Note: this type is marked as 'beforefieldinit'.
		static CashData()
		{
			Il2CppClassPointerStore<CashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashData>.NativeClassPtr);
			CashData.NativeFieldInfoPtr_CashBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashData>.NativeClassPtr, "CashBalance");
			CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashData>.NativeClassPtr, 100668757);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00106B98 File Offset: 0x00104D98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130588, RefRangeEnd = 130590, XrefRangeStart = 130586, XrefRangeEnd = 130588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashData(string iD, int quantity, float cashBalance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cashBalance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00018E53 File Offset: 0x00017053
		public CashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00106C00 File Offset: 0x00104E00
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00018E5C File Offset: 0x0001705C
		public unsafe float CashBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance)) = value;
			}
		}

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_CashBalance;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}
