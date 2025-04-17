using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066C RID: 1644
	public class SlidingRect : MonoBehaviour
	{
		// Token: 0x060092C6 RID: 37574 RVA: 0x0025D41C File Offset: 0x0025B61C
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingRect()
		{
			Il2CppClassPointerStore<SlidingRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SlidingRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr);
			SlidingRect.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Rect");
			SlidingRect.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Start");
			SlidingRect.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "End");
			SlidingRect.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "Duration");
			SlidingRect.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "SpeedMultiplier");
			SlidingRect.NativeFieldInfoPtr__time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, "_time");
			SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681508);
			SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr, 100681509);
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x0025D4EC File Offset: 0x0025B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264744, XrefRangeEnd = 264748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x0025D520 File Offset: 0x0025B720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264748, XrefRangeEnd = 264749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingRect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x000470E3 File Offset: 0x000452E3
		public SlidingRect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x060092CA RID: 37578 RVA: 0x0025D55C File Offset: 0x0025B75C
		// (set) Token: 0x060092CB RID: 37579 RVA: 0x000470EC File Offset: 0x000452EC
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x0025D58C File Offset: 0x0025B78C
		// (set) Token: 0x060092CD RID: 37581 RVA: 0x0004710B File Offset: 0x0004530B
		public unsafe Vector2 Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Start)) = value;
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x060092CE RID: 37582 RVA: 0x0025D5B4 File Offset: 0x0025B7B4
		// (set) Token: 0x060092CF RID: 37583 RVA: 0x00047126 File Offset: 0x00045326
		public unsafe Vector2 End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_End)) = value;
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x060092D0 RID: 37584 RVA: 0x0025D5DC File Offset: 0x0025B7DC
		// (set) Token: 0x060092D1 RID: 37585 RVA: 0x00047141 File Offset: 0x00045341
		public unsafe float Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x0025D604 File Offset: 0x0025B804
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x0004715C File Offset: 0x0004535C
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x0025D62C File Offset: 0x0025B82C
		// (set) Token: 0x060092D5 RID: 37589 RVA: 0x00047177 File Offset: 0x00045377
		public unsafe float _time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingRect.NativeFieldInfoPtr__time)) = value;
			}
		}

		// Token: 0x04006321 RID: 25377
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006322 RID: 25378
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x04006323 RID: 25379
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x04006324 RID: 25380
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x04006325 RID: 25381
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04006326 RID: 25382
		private static readonly IntPtr NativeFieldInfoPtr__time;

		// Token: 0x04006327 RID: 25383
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006328 RID: 25384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
