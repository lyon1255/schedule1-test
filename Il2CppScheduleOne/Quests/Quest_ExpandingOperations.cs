using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BB RID: 443
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x0600263E RID: 9790 RVA: 0x000E893C File Offset: 0x000E6B3C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_ExpandingOperations()
		{
			Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_ExpandingOperations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr);
			Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "SetUpGrowTentsEntry");
			Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "ReachCustomersEntry");
			Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667576);
			Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667577);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000E89BC File Offset: 0x000E6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116771, XrefRangeEnd = 116804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000E89F8 File Offset: 0x000E6BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116804, XrefRangeEnd = 116808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_ExpandingOperations() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00015360 File Offset: 0x00013560
		public Quest_ExpandingOperations(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x000E8A34 File Offset: 0x000E6C34
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x00015369 File Offset: 0x00013569
		public unsafe QuestEntry SetUpGrowTentsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x000E8A64 File Offset: 0x000E6C64
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x00015388 File Offset: 0x00013588
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr_SetUpGrowTentsEntry;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
