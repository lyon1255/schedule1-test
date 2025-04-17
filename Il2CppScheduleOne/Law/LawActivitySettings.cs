using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public class LawActivitySettings : Object
	{
		// Token: 0x06004BCC RID: 19404 RVA: 0x0016DAD0 File Offset: 0x0016BCD0
		// Note: this type is marked as 'beforefieldinit'.
		static LawActivitySettings()
		{
			Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawActivitySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr);
			LawActivitySettings.NativeFieldInfoPtr_Patrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Patrols");
			LawActivitySettings.NativeFieldInfoPtr_Checkpoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Checkpoints");
			LawActivitySettings.NativeFieldInfoPtr_Curfews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Curfews");
			LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "VehiclePatrols");
			LawActivitySettings.NativeFieldInfoPtr_Sentries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, "Sentries");
			LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672681);
			LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672682);
			LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672683);
			LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr, 100672684);
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x0016DBB4 File Offset: 0x0016BDB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165048, RefRangeEnd = 165049, XrefRangeStart = 165016, XrefRangeEnd = 165048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x0016DBE8 File Offset: 0x0016BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165049, XrefRangeEnd = 165050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x0016DC1C File Offset: 0x0016BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165050, XrefRangeEnd = 165065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr_OnLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x0016DC50 File Offset: 0x0016BE50
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawActivitySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawActivitySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x000246FE File Offset: 0x000228FE
		public LawActivitySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x0016DC8C File Offset: 0x0016BE8C
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x00024707 File Offset: 0x00022907
		public unsafe Il2CppReferenceArray<PatrolInstance> Patrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Patrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x0016DCBC File Offset: 0x0016BEBC
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x00024726 File Offset: 0x00022926
		public unsafe Il2CppReferenceArray<CheckpointInstance> Checkpoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CheckpointInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Checkpoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x0016DCEC File Offset: 0x0016BEEC
		// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x00024745 File Offset: 0x00022945
		public unsafe Il2CppReferenceArray<CurfewInstance> Curfews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CurfewInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Curfews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0016DD1C File Offset: 0x0016BF1C
		// (set) Token: 0x06004BD9 RID: 19417 RVA: 0x00024764 File Offset: 0x00022964
		public unsafe Il2CppReferenceArray<VehiclePatrolInstance> VehiclePatrols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehiclePatrolInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_VehiclePatrols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0016DD4C File Offset: 0x0016BF4C
		// (set) Token: 0x06004BDB RID: 19419 RVA: 0x00024783 File Offset: 0x00022983
		public unsafe Il2CppReferenceArray<SentryInstance> Sentries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SentryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawActivitySettings.NativeFieldInfoPtr_Sentries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeFieldInfoPtr_Patrols;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeFieldInfoPtr_Checkpoints;

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeFieldInfoPtr_Curfews;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePatrols;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeFieldInfoPtr_Sentries;

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr_OnLoaded_Public_Void_0;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
