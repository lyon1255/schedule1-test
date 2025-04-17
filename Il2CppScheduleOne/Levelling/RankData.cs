using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BF RID: 959
	public class RankData : SaveData
	{
		// Token: 0x06004AC9 RID: 19145 RVA: 0x0016A6F0 File Offset: 0x001688F0
		// Note: this type is marked as 'beforefieldinit'.
		static RankData()
		{
			Il2CppClassPointerStore<RankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "RankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankData>.NativeClassPtr);
			RankData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Rank");
			RankData.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Tier");
			RankData.NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "XP");
			RankData.NativeFieldInfoPtr_TotalXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "TotalXP");
			RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankData>.NativeClassPtr, 100672580);
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0016A784 File Offset: 0x00168984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164437, XrefRangeEnd = 164438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankData(int rank, int tier, int xp, int totalXP) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x00024008 File Offset: 0x00022208
		public RankData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x0016A7F8 File Offset: 0x001689F8
		// (set) Token: 0x06004ACD RID: 19149 RVA: 0x00024011 File Offset: 0x00022211
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x0016A820 File Offset: 0x00168A20
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x0002402C File Offset: 0x0002222C
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x0016A848 File Offset: 0x00168A48
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x00024047 File Offset: 0x00022247
		public unsafe int XP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP)) = value;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x0016A870 File Offset: 0x00168A70
		// (set) Token: 0x06004AD3 RID: 19155 RVA: 0x00024062 File Offset: 0x00022262
		public unsafe int TotalXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP)) = value;
			}
		}

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeFieldInfoPtr_XP;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeFieldInfoPtr_TotalXP;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
