using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046B RID: 1131
	public class ValueTracker : Object
	{
		// Token: 0x060061EE RID: 25070 RVA: 0x001BDFC0 File Offset: 0x001BC1C0
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTracker()
		{
			Il2CppClassPointerStore<ValueTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ValueTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr);
			ValueTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "historyDuration");
			ValueTracker.NativeFieldInfoPtr_valueHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "valueHistory");
			ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675728);
			ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675729);
			ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675730);
			ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675731);
			ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675732);
			ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675733);
			ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675734);
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x001BE0A4 File Offset: 0x001BC2A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201422, RefRangeEnd = 201423, XrefRangeStart = 201396, XrefRangeEnd = 201422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTracker(float HistoryDuration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref HistoryDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x001BE0EC File Offset: 0x001BC2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201423, XrefRangeEnd = 201441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x001BE120 File Offset: 0x001BC320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201441, XrefRangeEnd = 201450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x001BE154 File Offset: 0x001BC354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201458, RefRangeEnd = 201459, XrefRangeStart = 201450, XrefRangeEnd = 201458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x001BE194 File Offset: 0x001BC394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201464, RefRangeEnd = 201466, XrefRangeStart = 201459, XrefRangeEnd = 201464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecordedHistoryLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x001BE1D0 File Offset: 0x001BC3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201487, RefRangeEnd = 201489, XrefRangeStart = 201466, XrefRangeEnd = 201487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowestValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x001BE20C File Offset: 0x001BC40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201489, XrefRangeEnd = 201504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x0002E46C File Offset: 0x0002C66C
		public ValueTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x001BE248 File Offset: 0x001BC448
		// (set) Token: 0x060061F8 RID: 25080 RVA: 0x0002E475 File Offset: 0x0002C675
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x001BE270 File Offset: 0x001BC470
		// (set) Token: 0x060061FA RID: 25082 RVA: 0x0002E490 File Offset: 0x0002C690
		public unsafe List<ValueTracker.Value> valueHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTracker.Value>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeFieldInfoPtr_valueHistory;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040042CC RID: 17100
		private static readonly IntPtr NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0;

		// Token: 0x040042CD RID: 17101
		private static readonly IntPtr NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0;

		// Token: 0x040042CE RID: 17102
		private static readonly IntPtr NativeMethodInfoPtr_GetLowestValue_Public_Single_0;

		// Token: 0x040042CF RID: 17103
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageValue_Public_Single_0;

		// Token: 0x02000A19 RID: 2585
		public class Value : Object
		{
			// Token: 0x0600CEEA RID: 52970 RVA: 0x0031BCC4 File Offset: 0x00319EC4
			// Note: this type is marked as 'beforefieldinit'.
			static Value()
			{
				Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "Value");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr);
				ValueTracker.Value.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "val");
				ValueTracker.Value.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "time");
				ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, 100675735);
			}

			// Token: 0x0600CEEB RID: 52971 RVA: 0x0031BD2C File Offset: 0x00319F2C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 95681, RefRangeEnd = 95688, XrefRangeStart = 95681, XrefRangeEnd = 95688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Value(float val, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref val;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEEC RID: 52972 RVA: 0x00064A41 File Offset: 0x00062C41
			public Value(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004058 RID: 16472
			// (get) Token: 0x0600CEED RID: 52973 RVA: 0x0031BD84 File Offset: 0x00319F84
			// (set) Token: 0x0600CEEE RID: 52974 RVA: 0x00064A4A File Offset: 0x00062C4A
			public unsafe float val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x17004059 RID: 16473
			// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x0031BDAC File Offset: 0x00319FAC
			// (set) Token: 0x0600CEF0 RID: 52976 RVA: 0x00064A65 File Offset: 0x00062C65
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008B96 RID: 35734
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008B97 RID: 35735
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008B98 RID: 35736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
		}

		// Token: 0x02000A1A RID: 2586
		[ObfuscatedName("ScheduleOne.DevUtilities.ValueTracker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CEF1 RID: 52977 RVA: 0x0031BDD4 File Offset: 0x00319FD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr);
				ValueTracker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9");
				ValueTracker.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9__8_0");
				ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675737);
				ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675738);
			}

			// Token: 0x0600CEF2 RID: 52978 RVA: 0x0031BE50 File Offset: 0x0031A050
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEF3 RID: 52979 RVA: 0x0031BE8C File Offset: 0x0031A08C
			[CallerCount(0)]
			public unsafe float _GetLowestValue_b__8_0(ValueTracker.Value x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEF4 RID: 52980 RVA: 0x00064A80 File Offset: 0x00062C80
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405A RID: 16474
			// (get) Token: 0x0600CEF5 RID: 52981 RVA: 0x0031BEDC File Offset: 0x0031A0DC
			// (set) Token: 0x0600CEF6 RID: 52982 RVA: 0x00064A89 File Offset: 0x00062C89
			public unsafe static ValueTracker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700405B RID: 16475
			// (get) Token: 0x0600CEF7 RID: 52983 RVA: 0x0031BF04 File Offset: 0x0031A104
			// (set) Token: 0x0600CEF8 RID: 52984 RVA: 0x00064A9B File Offset: 0x00062C9B
			public unsafe static Func<ValueTracker.Value, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTracker.Value, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B99 RID: 35737
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B9A RID: 35738
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008B9B RID: 35739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B9C RID: 35740
			private static readonly IntPtr NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0;
		}
	}
}
