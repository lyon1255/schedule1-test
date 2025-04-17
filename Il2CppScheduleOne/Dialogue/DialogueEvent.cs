using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000439 RID: 1081
	[Serializable]
	public class DialogueEvent : Object
	{
		// Token: 0x06005EB0 RID: 24240 RVA: 0x001B3A88 File Offset: 0x001B1C88
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueEvent()
		{
			Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr);
			DialogueEvent.NativeFieldInfoPtr_Dialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "Dialogue");
			DialogueEvent.NativeFieldInfoPtr_onDialogueEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "onDialogueEnded");
			DialogueEvent.NativeFieldInfoPtr_NodeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "NodeEvents");
			DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, 100675364);
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x001B3B08 File Offset: 0x001B1D08
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x0002CA40 File Offset: 0x0002AC40
		public DialogueEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x001B3B44 File Offset: 0x001B1D44
		// (set) Token: 0x06005EB4 RID: 24244 RVA: 0x0002CA49 File Offset: 0x0002AC49
		public unsafe DialogueContainer Dialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005EB5 RID: 24245 RVA: 0x001B3B74 File Offset: 0x001B1D74
		// (set) Token: 0x06005EB6 RID: 24246 RVA: 0x0002CA68 File Offset: 0x0002AC68
		public unsafe UnityEvent onDialogueEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005EB7 RID: 24247 RVA: 0x001B3BA4 File Offset: 0x001B1DA4
		// (set) Token: 0x06005EB8 RID: 24248 RVA: 0x0002CA87 File Offset: 0x0002AC87
		public unsafe Il2CppReferenceArray<DialogueNodeEvent> NodeEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueNodeEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040BE RID: 16574
		private static readonly IntPtr NativeFieldInfoPtr_Dialogue;

		// Token: 0x040040BF RID: 16575
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueEnded;

		// Token: 0x040040C0 RID: 16576
		private static readonly IntPtr NativeFieldInfoPtr_NodeEvents;

		// Token: 0x040040C1 RID: 16577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
