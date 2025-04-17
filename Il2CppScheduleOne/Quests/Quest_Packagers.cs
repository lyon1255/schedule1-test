using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C1 RID: 449
	public class Quest_Packagers : Quest_Employees
	{
		// Token: 0x06002675 RID: 9845 RVA: 0x000E92C0 File Offset: 0x000E74C0
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Packagers()
		{
			Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Packagers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr);
			Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, "AssignWorkEntry");
			Quest_Packagers.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667594);
			Quest_Packagers.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667595);
			Quest_Packagers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667596);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000E9340 File Offset: 0x000E7540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116938, XrefRangeEnd = 116962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Packagers.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000E937C File Offset: 0x000E757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116962, XrefRangeEnd = 116968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Packagers.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000E93C8 File Offset: 0x000E75C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Packagers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Packagers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0001553C File Offset: 0x0001373C
		public Quest_Packagers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000E9404 File Offset: 0x000E7604
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x00015545 File Offset: 0x00013745
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
