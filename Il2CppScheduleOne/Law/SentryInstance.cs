using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DB RID: 987
	[Serializable]
	public class SentryInstance : Object
	{
		// Token: 0x06004C64 RID: 19556 RVA: 0x0016F660 File Offset: 0x0016D860
		// Note: this type is marked as 'beforefieldinit'.
		static SentryInstance()
		{
			Il2CppClassPointerStore<SentryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr);
			SentryInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Location");
			SentryInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Members");
			SentryInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "StartTime");
			SentryInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "EndTime");
			SentryInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "IntensityRequirement");
			SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			SentryInstance.NativeFieldInfoPtr_officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "officers");
			SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672735);
			SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672736);
			SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672737);
			SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672738);
			SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672739);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x0016F780 File Offset: 0x0016D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165548, XrefRangeEnd = 165560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x0016F7B4 File Offset: 0x0016D9B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165597, RefRangeEnd = 165599, XrefRangeStart = 165560, XrefRangeEnd = 165597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x0016F7E8 File Offset: 0x0016D9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165599, XrefRangeEnd = 165605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x0016F81C File Offset: 0x0016DA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165628, RefRangeEnd = 165629, XrefRangeStart = 165605, XrefRangeEnd = 165628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSentry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x0016F850 File Offset: 0x0016DA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165629, XrefRangeEnd = 165637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00024B74 File Offset: 0x00022D74
		public SentryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x06004C6B RID: 19563 RVA: 0x0016F88C File Offset: 0x0016DA8C
		// (set) Token: 0x06004C6C RID: 19564 RVA: 0x00024B7D File Offset: 0x00022D7D
		public unsafe SentryLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x0016F8BC File Offset: 0x0016DABC
		// (set) Token: 0x06004C6E RID: 19566 RVA: 0x00024B9C File Offset: 0x00022D9C
		public unsafe int Members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x0016F8E4 File Offset: 0x0016DAE4
		// (set) Token: 0x06004C70 RID: 19568 RVA: 0x00024BB7 File Offset: 0x00022DB7
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x0016F90C File Offset: 0x0016DB0C
		// (set) Token: 0x06004C72 RID: 19570 RVA: 0x00024BD2 File Offset: 0x00022DD2
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x0016F934 File Offset: 0x0016DB34
		// (set) Token: 0x06004C74 RID: 19572 RVA: 0x00024BED File Offset: 0x00022DED
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x0016F95C File Offset: 0x0016DB5C
		// (set) Token: 0x06004C76 RID: 19574 RVA: 0x00024C08 File Offset: 0x00022E08
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x0016F984 File Offset: 0x0016DB84
		// (set) Token: 0x06004C78 RID: 19576 RVA: 0x00024C23 File Offset: 0x00022E23
		public unsafe List<PoliceOfficer> officers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003378 RID: 13176
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04003379 RID: 13177
		private static readonly IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x0400337A RID: 13178
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400337B RID: 13179
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x0400337C RID: 13180
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400337D RID: 13181
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400337E RID: 13182
		private static readonly IntPtr NativeFieldInfoPtr_officers;

		// Token: 0x0400337F RID: 13183
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003380 RID: 13184
		private static readonly IntPtr NativeMethodInfoPtr_StartEntry_Public_Void_0;

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeMethodInfoPtr_EndSentry_Public_Void_0;

		// Token: 0x04003383 RID: 13187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
