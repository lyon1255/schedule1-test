using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000287 RID: 647
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x001090AC File Offset: 0x001072AC
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyData()
		{
			Il2CppClassPointerStore<MoneyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoneyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyData>.NativeClassPtr);
			MoneyData.NativeFieldInfoPtr_OnlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "OnlineBalance");
			MoneyData.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "Networth");
			MoneyData.NativeFieldInfoPtr_LifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "LifetimeEarnings");
			MoneyData.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "WeeklyDepositSum");
			MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, 100668795);
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x00109140 File Offset: 0x00107340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130799, RefRangeEnd = 130800, XrefRangeStart = 130798, XrefRangeEnd = 130799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlineBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimeEarnings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weeklyDepositSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0001972F File Offset: 0x0001792F
		public MoneyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x001091B4 File Offset: 0x001073B4
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x00019738 File Offset: 0x00017938
		public unsafe float OnlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance)) = value;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x001091DC File Offset: 0x001073DC
		// (set) Token: 0x06003002 RID: 12290 RVA: 0x00019753 File Offset: 0x00017953
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x00109204 File Offset: 0x00107404
		// (set) Token: 0x06003004 RID: 12292 RVA: 0x0001976E File Offset: 0x0001796E
		public unsafe float LifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings)) = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x0010922C File Offset: 0x0010742C
		// (set) Token: 0x06003006 RID: 12294 RVA: 0x00019789 File Offset: 0x00017989
		public unsafe float WeeklyDepositSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum)) = value;
			}
		}

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalance;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarnings;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
	}
}
