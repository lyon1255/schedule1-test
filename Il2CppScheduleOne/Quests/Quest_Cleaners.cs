using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B7 RID: 439
	public class Quest_Cleaners : Quest_Employees
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x000E82EC File Offset: 0x000E64EC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Cleaners()
		{
			Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Cleaners");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr);
			Quest_Cleaners.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr, "AssignWorkEntry");
			Quest_Cleaners.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr, 100667562);
			Quest_Cleaners.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr, 100667563);
			Quest_Cleaners.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr, 100667564);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000E836C File Offset: 0x000E656C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116644, XrefRangeEnd = 116668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Cleaners.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000E83A8 File Offset: 0x000E65A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116668, XrefRangeEnd = 116674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Cleaners.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000E83F4 File Offset: 0x000E65F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Cleaners() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Cleaners>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Cleaners.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000152C4 File Offset: 0x000134C4
		public Quest_Cleaners(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x000E8430 File Offset: 0x000E6630
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x000152CD File Offset: 0x000134CD
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Cleaners.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Cleaners.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
