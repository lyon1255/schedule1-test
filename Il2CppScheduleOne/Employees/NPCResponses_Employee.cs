using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200040B RID: 1035
	public class NPCResponses_Employee : NPCResponses
	{
		// Token: 0x060058A6 RID: 22694 RVA: 0x0019D280 File Offset: 0x0019B480
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_Employee()
		{
			Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "NPCResponses_Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100674496);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100674497);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100674498);
			NPCResponses_Employee.NativeMethodInfoPtr_Ow_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100674499);
			NPCResponses_Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100674500);
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0019D314 File Offset: 0x0019B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186335, XrefRangeEnd = 186337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0019D374 File Offset: 0x0019B574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186337, XrefRangeEnd = 186339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0019D3D4 File Offset: 0x0019B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186339, XrefRangeEnd = 186341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x0019D434 File Offset: 0x0019B634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186349, RefRangeEnd = 186352, XrefRangeStart = 186341, XrefRangeEnd = 186349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ow(Player perpetrator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Employee.NativeMethodInfoPtr_Ow_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x0019D478 File Offset: 0x0019B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x0002A232 File Offset: 0x00028432
		public NPCResponses_Employee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003C5F RID: 15455
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003C60 RID: 15456
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003C61 RID: 15457
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeMethodInfoPtr_Ow_Private_Void_Player_0;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
