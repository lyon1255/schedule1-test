using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C0 RID: 448
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x0600266F RID: 9839 RVA: 0x000E91AC File Offset: 0x000E73AC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_OnTheGrind()
		{
			Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_OnTheGrind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr);
			Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, "CompleteDealsEntry");
			Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667592);
			Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667593);
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000E9218 File Offset: 0x000E7418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116916, XrefRangeEnd = 116934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000E9254 File Offset: 0x000E7454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116934, XrefRangeEnd = 116938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_OnTheGrind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00015514 File Offset: 0x00013714
		public Quest_OnTheGrind(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000E9290 File Offset: 0x000E7490
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0001551D File Offset: 0x0001371D
		public unsafe QuestEntry CompleteDealsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeFieldInfoPtr_CompleteDealsEntry;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
