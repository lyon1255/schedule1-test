using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E4 RID: 740
	public class NPCActionList : Object
	{
		// Token: 0x06003780 RID: 14208 RVA: 0x001240B0 File Offset: 0x001222B0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCActionList()
		{
			Il2CppClassPointerStore<NPCActionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCActionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr);
			NPCActionList.NativeFieldInfoPtr_actionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, "actionList");
			NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, 100669678);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00124108 File Offset: 0x00122308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140518, XrefRangeEnd = 140526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCActionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0001CDB5 File Offset: 0x0001AFB5
		public NPCActionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x00124144 File Offset: 0x00122344
		// (set) Token: 0x06003784 RID: 14212 RVA: 0x0001CDBE File Offset: 0x0001AFBE
		public unsafe List<NPCAction> actionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002479 RID: 9337
		private static readonly IntPtr NativeFieldInfoPtr_actionList;

		// Token: 0x0400247A RID: 9338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
