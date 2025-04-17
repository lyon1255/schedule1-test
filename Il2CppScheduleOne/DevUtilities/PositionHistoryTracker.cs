using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000467 RID: 1127
	public class PositionHistoryTracker : MonoBehaviour
	{
		// Token: 0x060061AF RID: 25007 RVA: 0x001BD3AC File Offset: 0x001BB5AC
		// Note: this type is marked as 'beforefieldinit'.
		static PositionHistoryTracker()
		{
			Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PositionHistoryTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr);
			PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "recordingFrequency");
			PositionHistoryTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "historyDuration");
			PositionHistoryTracker.NativeFieldInfoPtr_positionHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "positionHistory");
			PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, "lastRecordTime");
			PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675707);
			PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675708);
			PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675709);
			PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675710);
			PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675711);
			PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675712);
			PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr, 100675713);
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x001BD4B8 File Offset: 0x001BB6B8
		public unsafe float RecordedTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 201163, RefRangeEnd = 201165, XrefRangeStart = 201162, XrefRangeEnd = 201163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x001BD4F4 File Offset: 0x001BB6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201165, XrefRangeEnd = 201166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x001BD528 File Offset: 0x001BB728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201166, XrefRangeEnd = 201178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x001BD55C File Offset: 0x001BB75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201178, XrefRangeEnd = 201188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x001BD590 File Offset: 0x001BB790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 201193, RefRangeEnd = 201195, XrefRangeStart = 201188, XrefRangeEnd = 201193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionXSecondsAgo(float secondsAgo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref secondsAgo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x001BD5DC File Offset: 0x001BB7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 201196, RefRangeEnd = 201197, XrefRangeStart = 201195, XrefRangeEnd = 201196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr_ClearHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x001BD610 File Offset: 0x001BB810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201197, XrefRangeEnd = 201205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionHistoryTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionHistoryTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionHistoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0002E290 File Offset: 0x0002C490
		public PositionHistoryTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x060061B8 RID: 25016 RVA: 0x001BD64C File Offset: 0x001BB84C
		// (set) Token: 0x060061B9 RID: 25017 RVA: 0x0002E299 File Offset: 0x0002C499
		public unsafe float recordingFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_recordingFrequency)) = value;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x060061BA RID: 25018 RVA: 0x001BD674 File Offset: 0x001BB874
		// (set) Token: 0x060061BB RID: 25019 RVA: 0x0002E2B4 File Offset: 0x0002C4B4
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x060061BC RID: 25020 RVA: 0x001BD69C File Offset: 0x001BB89C
		// (set) Token: 0x060061BD RID: 25021 RVA: 0x0002E2CF File Offset: 0x0002C4CF
		public unsafe List<Vector3> positionHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_positionHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x060061BE RID: 25022 RVA: 0x001BD6CC File Offset: 0x001BB8CC
		// (set) Token: 0x060061BF RID: 25023 RVA: 0x0002E2EE File Offset: 0x0002C4EE
		public unsafe float lastRecordTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PositionHistoryTracker.NativeFieldInfoPtr_lastRecordTime)) = value;
			}
		}

		// Token: 0x040042A1 RID: 17057
		private static readonly IntPtr NativeFieldInfoPtr_recordingFrequency;

		// Token: 0x040042A2 RID: 17058
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x040042A3 RID: 17059
		private static readonly IntPtr NativeFieldInfoPtr_positionHistory;

		// Token: 0x040042A4 RID: 17060
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordTime;

		// Token: 0x040042A5 RID: 17061
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordedTime_Public_get_Single_0;

		// Token: 0x040042A6 RID: 17062
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042A7 RID: 17063
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042A8 RID: 17064
		private static readonly IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

		// Token: 0x040042A9 RID: 17065
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionXSecondsAgo_Public_Vector3_Single_0;

		// Token: 0x040042AA RID: 17066
		private static readonly IntPtr NativeMethodInfoPtr_ClearHistory_Public_Void_0;

		// Token: 0x040042AB RID: 17067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
