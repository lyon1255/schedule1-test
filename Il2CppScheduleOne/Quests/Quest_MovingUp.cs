using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BE RID: 446
	public class Quest_MovingUp : Quest
	{
		// Token: 0x0600265F RID: 9823 RVA: 0x000E8F04 File Offset: 0x000E7104
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_MovingUp()
		{
			Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_MovingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr);
			Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, "ReachCustomersEntry");
			Quest_MovingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, 100667588);
			Quest_MovingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, 100667589);
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000E8F70 File Offset: 0x000E7170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116864, XrefRangeEnd = 116878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_MovingUp.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000E8FAC File Offset: 0x000E71AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116878, XrefRangeEnd = 116882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_MovingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_MovingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0001548A File Offset: 0x0001368A
		public Quest_MovingUp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000E8FE8 File Offset: 0x000E71E8
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x00015493 File Offset: 0x00013693
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
