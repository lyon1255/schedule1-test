using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000212 RID: 530
	public class PourOntoTargetTask : PourIntoPotTask
	{
		// Token: 0x06002C27 RID: 11303 RVA: 0x000FC4BC File Offset: 0x000FA6BC
		// Note: this type is marked as 'beforefieldinit'.
		static PourOntoTargetTask()
		{
			Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourOntoTargetTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr);
			PourOntoTargetTask.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "Target");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_THRESHOLD");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_TIME");
			PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "timeOverTarget");
			PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668263);
			PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668264);
			PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668265);
			PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668266);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000FC58C File Offset: 0x000FA78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123445, XrefRangeEnd = 123450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourOntoTargetTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000FC5FC File Offset: 0x000FA7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123450, XrefRangeEnd = 123454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000FC638 File Offset: 0x000FA838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123454, XrefRangeEnd = 123457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000FC674 File Offset: 0x000FA874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123457, XrefRangeEnd = 123463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00017DE0 File Offset: 0x00015FE0
		public PourOntoTargetTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000FC6B0 File Offset: 0x000FA8B0
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x00017DE9 File Offset: 0x00015FE9
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000FC6E0 File Offset: 0x000FA8E0
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x00017E08 File Offset: 0x00016008
		public unsafe float SUCCESS_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000FC708 File Offset: 0x000FA908
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x00017E23 File Offset: 0x00016023
		public unsafe float SUCCESS_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME)) = value;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x000FC730 File Offset: 0x000FA930
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x00017E3E File Offset: 0x0001603E
		public unsafe float timeOverTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget)) = value;
			}
		}

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_THRESHOLD;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_TIME;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_timeOverTarget;

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0;
	}
}
