using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200053E RID: 1342
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x0600770F RID: 30479 RVA: 0x00205020 File Offset: 0x00203220
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalEvent()
		{
			Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "IntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr);
			IntervalEvent.NativeFieldInfoPtr_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Interval");
			IntervalEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Event");
			IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678305);
			IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678306);
			IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678307);
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x002050B4 File Offset: 0x002032B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231370, XrefRangeEnd = 231373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x002050E8 File Offset: 0x002032E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x0020511C File Offset: 0x0020331C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00038631 File Offset: 0x00036831
		public IntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00205158 File Offset: 0x00203358
		// (set) Token: 0x06007715 RID: 30485 RVA: 0x0003863A File Offset: 0x0003683A
		public unsafe float Interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval)) = value;
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x06007716 RID: 30486 RVA: 0x00205180 File Offset: 0x00203380
		// (set) Token: 0x06007717 RID: 30487 RVA: 0x00038655 File Offset: 0x00036855
		public unsafe UnityEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005148 RID: 20808
		private static readonly IntPtr NativeFieldInfoPtr_Interval;

		// Token: 0x04005149 RID: 20809
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x0400514A RID: 20810
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400514B RID: 20811
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x0400514C RID: 20812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
