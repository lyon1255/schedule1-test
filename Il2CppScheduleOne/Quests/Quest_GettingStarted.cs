using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs.CharacterClasses;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BD RID: 445
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x06002654 RID: 9812 RVA: 0x000E8D04 File Offset: 0x000E6F04
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GettingStarted()
		{
			Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GettingStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr);
			Quest_GettingStarted.NativeFieldInfoPtr_CashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashAmount");
			Quest_GettingStarted.NativeFieldInfoPtr_CashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashDrop");
			Quest_GettingStarted.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "Nelson");
			Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667585);
			Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667586);
			Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667587);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000E8DAC File Offset: 0x000E6FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116858, XrefRangeEnd = 116859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000E8DE8 File Offset: 0x000E6FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116859, XrefRangeEnd = 116860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GettingStarted.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000E8E40 File Offset: 0x000E7040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116860, XrefRangeEnd = 116864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GettingStarted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00015428 File Offset: 0x00013628
		public Quest_GettingStarted(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000E8E7C File Offset: 0x000E707C
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x00015431 File Offset: 0x00013631
		public unsafe float CashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount)) = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x000E8EA4 File Offset: 0x000E70A4
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x0001544C File Offset: 0x0001364C
		public unsafe DeadDrop CashDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000E8ED4 File Offset: 0x000E70D4
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x0001546B File Offset: 0x0001366B
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_CashAmount;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_CashDrop;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
