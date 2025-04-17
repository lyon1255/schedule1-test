using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F2 RID: 754
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x0600390B RID: 14603 RVA: 0x00129EF4 File Offset: 0x001280F4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCUnlockTracker()
		{
			Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCUnlockTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr);
			NPCUnlockTracker.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "Npc");
			NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "onUnlocked");
			NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669937);
			NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669938);
			NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100669939);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00129F88 File Offset: 0x00128188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141770, XrefRangeEnd = 141787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00129FBC File Offset: 0x001281BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141787, XrefRangeEnd = 141788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0012A008 File Offset: 0x00128208
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCUnlockTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0001D534 File Offset: 0x0001B734
		public NPCUnlockTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06003910 RID: 14608 RVA: 0x0012A044 File Offset: 0x00128244
		// (set) Token: 0x06003911 RID: 14609 RVA: 0x0001D53D File Offset: 0x0001B73D
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06003912 RID: 14610 RVA: 0x0012A074 File Offset: 0x00128274
		// (set) Token: 0x06003913 RID: 14611 RVA: 0x0001D55C File Offset: 0x0001B75C
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
