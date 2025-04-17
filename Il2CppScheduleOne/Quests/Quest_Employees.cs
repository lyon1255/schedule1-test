using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BA RID: 442
	public class Quest_Employees : Quest
	{
		// Token: 0x06002631 RID: 9777 RVA: 0x000E86A8 File Offset: 0x000E68A8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Employees()
		{
			Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Employees");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr);
			Quest_Employees.NativeFieldInfoPtr_EmployeeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "EmployeeType");
			Quest_Employees.NativeFieldInfoPtr_AssignBedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "AssignBedEntry");
			Quest_Employees.NativeFieldInfoPtr_PayEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "PayEntry");
			Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667571);
			Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667572);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667573);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667574);
			Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667575);
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000E8778 File Offset: 0x000E6978
		[CallerCount(0)]
		public unsafe virtual List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000E87C4 File Offset: 0x000E69C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116740, RefRangeEnd = 116744, XrefRangeStart = 116734, XrefRangeEnd = 116740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000E8800 File Offset: 0x000E6A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116758, RefRangeEnd = 116759, XrefRangeStart = 116744, XrefRangeEnd = 116758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesAssignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000E883C File Offset: 0x000E6A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116770, RefRangeEnd = 116771, XrefRangeStart = 116759, XrefRangeEnd = 116770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000E8878 File Offset: 0x000E6A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Employees() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000152FE File Offset: 0x000134FE
		public Quest_Employees(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000E88B4 File Offset: 0x000E6AB4
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x00015307 File Offset: 0x00013507
		public unsafe EEmployeeType EmployeeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType)) = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000E88DC File Offset: 0x000E6ADC
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x00015322 File Offset: 0x00013522
		public unsafe QuestEntry AssignBedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000E890C File Offset: 0x000E6B0C
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x00015341 File Offset: 0x00013541
		public unsafe QuestEntry PayEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeType;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_AssignBedEntry;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_PayEntry;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
