using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class DialogueNodeEvent : Object
	{
		// Token: 0x06005EB9 RID: 24249 RVA: 0x001B3BD4 File Offset: 0x001B1DD4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeEvent()
		{
			Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr);
			DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "NodeLabel");
			DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "onNodeDisplayed");
			DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, 100675365);
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x001B3C40 File Offset: 0x001B1E40
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x0002CAA6 File Offset: 0x0002ACA6
		public DialogueNodeEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06005EBC RID: 24252 RVA: 0x001B3C7C File Offset: 0x001B1E7C
		// (set) Token: 0x06005EBD RID: 24253 RVA: 0x0002CAAF File Offset: 0x0002ACAF
		public unsafe string NodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06005EBE RID: 24254 RVA: 0x001B3CA4 File Offset: 0x001B1EA4
		// (set) Token: 0x06005EBF RID: 24255 RVA: 0x0002CACE File Offset: 0x0002ACCE
		public unsafe UnityEvent onNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040C2 RID: 16578
		private static readonly IntPtr NativeFieldInfoPtr_NodeLabel;

		// Token: 0x040040C3 RID: 16579
		private static readonly IntPtr NativeFieldInfoPtr_onNodeDisplayed;

		// Token: 0x040040C4 RID: 16580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
