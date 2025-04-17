using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B8 RID: 696
	[Serializable]
	public class TimeData : SaveData
	{
		// Token: 0x060031D1 RID: 12753 RVA: 0x0010E648 File Offset: 0x0010C848
		// Note: this type is marked as 'beforefieldinit'.
		static TimeData()
		{
			Il2CppClassPointerStore<TimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeData>.NativeClassPtr);
			TimeData.NativeFieldInfoPtr_TimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "TimeOfDay");
			TimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "ElapsedDays");
			TimeData.NativeFieldInfoPtr_Playtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeData>.NativeClassPtr, "Playtime");
			TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeData>.NativeClassPtr, 100668852);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0010E6C8 File Offset: 0x0010C8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131197, RefRangeEnd = 131198, XrefRangeStart = 131196, XrefRangeEnd = 131197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeData(int timeOfDay, int elapsedDays, int playtime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeOfDay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playtime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x0001AAC5 File Offset: 0x00018CC5
		public TimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0010E72C File Offset: 0x0010C92C
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x0001AACE File Offset: 0x00018CCE
		public unsafe int TimeOfDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_TimeOfDay)) = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x0010E754 File Offset: 0x0010C954
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x0001AAE9 File Offset: 0x00018CE9
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x0010E77C File Offset: 0x0010C97C
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x0001AB04 File Offset: 0x00018D04
		public unsafe int Playtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeData.NativeFieldInfoPtr_Playtime)) = value;
			}
		}

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDay;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeFieldInfoPtr_Playtime;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
	}
}
