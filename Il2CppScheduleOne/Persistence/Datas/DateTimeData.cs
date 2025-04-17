using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025C RID: 604
	[Serializable]
	public class DateTimeData : SaveData
	{
		// Token: 0x06002ED5 RID: 11989 RVA: 0x00105E6C File Offset: 0x0010406C
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeData()
		{
			Il2CppClassPointerStore<DateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr);
			DateTimeData.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Year");
			DateTimeData.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Month");
			DateTimeData.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Day");
			DateTimeData.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Hour");
			DateTimeData.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Minute");
			DateTimeData.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, "Second");
			DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668728);
			DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr, 100668729);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00105F3C File Offset: 0x0010413C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130420, RefRangeEnd = 130426, XrefRangeStart = 130410, XrefRangeEnd = 130420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeData(DateTime date) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref date;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00105F84 File Offset: 0x00104184
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130427, RefRangeEnd = 130430, XrefRangeStart = 130426, XrefRangeEnd = 130427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeData.NativeMethodInfoPtr_GetDateTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00018BDD File Offset: 0x00016DDD
		public DateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002ED9 RID: 11993 RVA: 0x00105FC0 File Offset: 0x001041C0
		// (set) Token: 0x06002EDA RID: 11994 RVA: 0x00018BE6 File Offset: 0x00016DE6
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x00105FE8 File Offset: 0x001041E8
		// (set) Token: 0x06002EDC RID: 11996 RVA: 0x00018C01 File Offset: 0x00016E01
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x00106010 File Offset: 0x00104210
		// (set) Token: 0x06002EDE RID: 11998 RVA: 0x00018C1C File Offset: 0x00016E1C
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00106038 File Offset: 0x00104238
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00018C37 File Offset: 0x00016E37
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x00106060 File Offset: 0x00104260
		// (set) Token: 0x06002EE2 RID: 12002 RVA: 0x00018C52 File Offset: 0x00016E52
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002EE3 RID: 12003 RVA: 0x00106088 File Offset: 0x00104288
		// (set) Token: 0x06002EE4 RID: 12004 RVA: 0x00018C6D File Offset: 0x00016E6D
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeData.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_0;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_DateTime_0;
	}
}
