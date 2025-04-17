using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000532 RID: 1330
	public class CountdownText : MonoBehaviour
	{
		// Token: 0x06007688 RID: 30344 RVA: 0x0020363C File Offset: 0x0020183C
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownText()
		{
			Il2CppClassPointerStore<CountdownText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CountdownText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownText>.NativeClassPtr);
			CountdownText.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "TimeLabel");
			CountdownText.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Year");
			CountdownText.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Month");
			CountdownText.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Day");
			CountdownText.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Hour");
			CountdownText.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Minute");
			CountdownText.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "Second");
			CountdownText.NativeFieldInfoPtr_targetPDTDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, "targetPDTDate");
			CountdownText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678228);
			CountdownText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678229);
			CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678230);
			CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678231);
			CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownText>.NativeClassPtr, 100678232);
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x00203770 File Offset: 0x00201970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230845, XrefRangeEnd = 230856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x002037A4 File Offset: 0x002019A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230856, XrefRangeEnd = 230867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x002037D8 File Offset: 0x002019D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_UpdateCountdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x0020380C File Offset: 0x00201A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230867, XrefRangeEnd = 230892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeSpan;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00203850 File Offset: 0x00201A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230892, XrefRangeEnd = 230893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x0003828A File Offset: 0x0003648A
		public CountdownText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600768F RID: 30351 RVA: 0x0020388C File Offset: 0x00201A8C
		// (set) Token: 0x06007690 RID: 30352 RVA: 0x00038293 File Offset: 0x00036493
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x002038BC File Offset: 0x00201ABC
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x000382B2 File Offset: 0x000364B2
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x002038E4 File Offset: 0x00201AE4
		// (set) Token: 0x06007694 RID: 30356 RVA: 0x000382CD File Offset: 0x000364CD
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x0020390C File Offset: 0x00201B0C
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x000382E8 File Offset: 0x000364E8
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x00203934 File Offset: 0x00201B34
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x00038303 File Offset: 0x00036503
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x0020395C File Offset: 0x00201B5C
		// (set) Token: 0x0600769A RID: 30362 RVA: 0x0003831E File Offset: 0x0003651E
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x00203984 File Offset: 0x00201B84
		// (set) Token: 0x0600769C RID: 30364 RVA: 0x00038339 File Offset: 0x00036539
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600769D RID: 30365 RVA: 0x002039AC File Offset: 0x00201BAC
		// (set) Token: 0x0600769E RID: 30366 RVA: 0x00038354 File Offset: 0x00036554
		public unsafe DateTime targetPDTDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownText.NativeFieldInfoPtr_targetPDTDate)) = value;
			}
		}

		// Token: 0x040050F6 RID: 20726
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x040050F7 RID: 20727
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x040050F8 RID: 20728
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x040050F9 RID: 20729
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x040050FA RID: 20730
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x040050FB RID: 20731
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x040050FC RID: 20732
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x040050FD RID: 20733
		private static readonly IntPtr NativeFieldInfoPtr_targetPDTDate;

		// Token: 0x040050FE RID: 20734
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040050FF RID: 20735
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005100 RID: 20736
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCountdown_Private_Void_0;

		// Token: 0x04005101 RID: 20737
		private static readonly IntPtr NativeMethodInfoPtr_FormatTime_Private_String_TimeSpan_0;

		// Token: 0x04005102 RID: 20738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
