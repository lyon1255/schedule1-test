﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B6 RID: 438
	public class Quest_CleanCash : Quest
	{
		// Token: 0x06002618 RID: 9752 RVA: 0x000E8194 File Offset: 0x000E6394
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_CleanCash()
		{
			Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_CleanCash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr);
			Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "BuyBusinessEntry");
			Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "GoToBusinessEntry");
			Quest_CleanCash.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667560);
			Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667561);
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x000E8214 File Offset: 0x000E6414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116605, XrefRangeEnd = 116640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_CleanCash.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x000E8250 File Offset: 0x000E6450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116640, XrefRangeEnd = 116644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_CleanCash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x0001527D File Offset: 0x0001347D
		public Quest_CleanCash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000E828C File Offset: 0x000E648C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00015286 File Offset: 0x00013486
		public unsafe QuestEntry BuyBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x000E82BC File Offset: 0x000E64BC
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x000152A5 File Offset: 0x000134A5
		public unsafe QuestEntry GoToBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeFieldInfoPtr_BuyBusinessEntry;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeFieldInfoPtr_GoToBusinessEntry;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
