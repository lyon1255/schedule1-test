using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050C RID: 1292
	public class LaunderingOperation : Object
	{
		// Token: 0x0600726B RID: 29291 RVA: 0x001F4680 File Offset: 0x001F2880
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingOperation()
		{
			Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "LaunderingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr);
			LaunderingOperation.NativeFieldInfoPtr_business = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "business");
			LaunderingOperation.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "amount");
			LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "minutesSinceStarted");
			LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "completionTime_Minutes");
			LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, 100677659);
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x001F4714 File Offset: 0x001F2914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224292, XrefRangeEnd = 224294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_business);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x0003666D File Offset: 0x0003486D
		public LaunderingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x001F477C File Offset: 0x001F297C
		// (set) Token: 0x0600726F RID: 29295 RVA: 0x00036676 File Offset: 0x00034876
		public unsafe Business business
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x001F47AC File Offset: 0x001F29AC
		// (set) Token: 0x06007271 RID: 29297 RVA: 0x00036695 File Offset: 0x00034895
		public unsafe float amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x001F47D4 File Offset: 0x001F29D4
		// (set) Token: 0x06007273 RID: 29299 RVA: 0x000366B0 File Offset: 0x000348B0
		public unsafe int minutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted)) = value;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06007274 RID: 29300 RVA: 0x001F47FC File Offset: 0x001F29FC
		// (set) Token: 0x06007275 RID: 29301 RVA: 0x000366CB File Offset: 0x000348CB
		public unsafe int completionTime_Minutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes)) = value;
			}
		}

		// Token: 0x04004E19 RID: 19993
		private static readonly IntPtr NativeFieldInfoPtr_business;

		// Token: 0x04004E1A RID: 19994
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04004E1B RID: 19995
		private static readonly IntPtr NativeFieldInfoPtr_minutesSinceStarted;

		// Token: 0x04004E1C RID: 19996
		private static readonly IntPtr NativeFieldInfoPtr_completionTime_Minutes;

		// Token: 0x04004E1D RID: 19997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0;
	}
}
