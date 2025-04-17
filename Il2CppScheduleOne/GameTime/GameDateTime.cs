using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000192 RID: 402
	[Serializable]
	[StructLayout(2)]
	public struct GameDateTime
	{
		// Token: 0x060020BB RID: 8379 RVA: 0x000D6324 File Offset: 0x000D4524
		// Note: this type is marked as 'beforefieldinit'.
		static GameDateTime()
		{
			Il2CppClassPointerStore<GameDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "GameDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr);
			GameDateTime.NativeFieldInfoPtr_elapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, "elapsedDays");
			GameDateTime.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, "time");
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666945);
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666946);
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666947);
			GameDateTime.NativeMethodInfoPtr_GetMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666948);
			GameDateTime.NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666949);
			GameDateTime.NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666950);
			GameDateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666951);
			GameDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666952);
			GameDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100666953);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000D6430 File Offset: 0x000D4630
		[CallerCount(93)]
		[CachedScanResults(RefRangeStart = 34314, RefRangeEnd = 34407, XrefRangeStart = 34314, XrefRangeEnd = 34407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(int _elapsedDays, int _time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x000D6470 File Offset: 0x000D4670
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109174, RefRangeEnd = 109177, XrefRangeStart = 109174, XrefRangeEnd = 109174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(int _minSum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _minSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000D64A4 File Offset: 0x000D46A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109177, RefRangeEnd = 109179, XrefRangeStart = 109177, XrefRangeEnd = 109177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(GameDateTimeData data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x000D64DC File Offset: 0x000D46DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109179, RefRangeEnd = 109183, XrefRangeStart = 109179, XrefRangeEnd = 109179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinSum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_GetMinSum_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x000D650C File Offset: 0x000D470C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109183, XrefRangeEnd = 109184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime AddMins(int mins)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000D654C File Offset: 0x000D474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109184, XrefRangeEnd = 109185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000D6598 File Offset: 0x000D4798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109185, XrefRangeEnd = 109186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000D65E4 File Offset: 0x000D47E4
		[CallerCount(0)]
		public unsafe static bool operator >(GameDateTime a, GameDateTime b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000D6630 File Offset: 0x000D4830
		[CallerCount(0)]
		public unsafe static bool operator <(GameDateTime a, GameDateTime b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000126EE File Offset: 0x000108EE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeFieldInfoPtr_elapsedDays;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSum_Public_Int32_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x040015B8 RID: 5560
		[FieldOffset(0)]
		public int elapsedDays;

		// Token: 0x040015B9 RID: 5561
		[FieldOffset(4)]
		public int time;
	}
}
