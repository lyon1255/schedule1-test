using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003DD RID: 989
	[Serializable]
	public class VehiclePatrolInstance : Object
	{
		// Token: 0x06004C80 RID: 19584 RVA: 0x0016FABC File Offset: 0x0016DCBC
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolInstance()
		{
			Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehiclePatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr);
			VehiclePatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "Route");
			VehiclePatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "StartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "IntensityRequirement");
			VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "activeOfficer");
			VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "latestStartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "startedThisCycle");
			VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672741);
			VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672742);
			VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672743);
			VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672744);
			VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100672745);
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x0016FBDC File Offset: 0x0016DDDC
		public unsafe PoliceStation nearestStation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 165658, RefRangeEnd = 165660, XrefRangeStart = 165652, XrefRangeEnd = 165658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
			}
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x0016FC1C File Offset: 0x0016DE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165678, RefRangeEnd = 165679, XrefRangeStart = 165660, XrefRangeEnd = 165678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x0016FC50 File Offset: 0x0016DE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165679, XrefRangeEnd = 165684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x0016FC84 File Offset: 0x0016DE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165715, RefRangeEnd = 165716, XrefRangeStart = 165684, XrefRangeEnd = 165715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x0016FCB8 File Offset: 0x0016DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165716, XrefRangeEnd = 165717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00024C89 File Offset: 0x00022E89
		public VehiclePatrolInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06004C87 RID: 19591 RVA: 0x0016FCF4 File Offset: 0x0016DEF4
		// (set) Token: 0x06004C88 RID: 19592 RVA: 0x00024C92 File Offset: 0x00022E92
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x0016FD24 File Offset: 0x0016DF24
		// (set) Token: 0x06004C8A RID: 19594 RVA: 0x00024CB1 File Offset: 0x00022EB1
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004C8B RID: 19595 RVA: 0x0016FD4C File Offset: 0x0016DF4C
		// (set) Token: 0x06004C8C RID: 19596 RVA: 0x00024CCC File Offset: 0x00022ECC
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004C8D RID: 19597 RVA: 0x0016FD74 File Offset: 0x0016DF74
		// (set) Token: 0x06004C8E RID: 19598 RVA: 0x00024CE7 File Offset: 0x00022EE7
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x0016FD9C File Offset: 0x0016DF9C
		// (set) Token: 0x06004C90 RID: 19600 RVA: 0x00024D02 File Offset: 0x00022F02
		public unsafe PoliceOfficer activeOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x0016FDCC File Offset: 0x0016DFCC
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x00024D21 File Offset: 0x00022F21
		public unsafe int latestStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime)) = value;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06004C93 RID: 19603 RVA: 0x0016FDF4 File Offset: 0x0016DFF4
		// (set) Token: 0x06004C94 RID: 19604 RVA: 0x00024D3C File Offset: 0x00022F3C
		public unsafe bool startedThisCycle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle)) = value;
			}
		}

		// Token: 0x04003387 RID: 13191
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04003388 RID: 13192
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003389 RID: 13193
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400338A RID: 13194
		private static readonly IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400338B RID: 13195
		private static readonly IntPtr NativeFieldInfoPtr_activeOfficer;

		// Token: 0x0400338C RID: 13196
		private static readonly IntPtr NativeFieldInfoPtr_latestStartTime;

		// Token: 0x0400338D RID: 13197
		private static readonly IntPtr NativeFieldInfoPtr_startedThisCycle;

		// Token: 0x0400338E RID: 13198
		private static readonly IntPtr NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0;

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnd_Private_Void_0;

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
