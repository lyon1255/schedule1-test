using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000634 RID: 1588
	[Serializable]
	public class DialogueChoiceEntry : Il2CppSystem.Object
	{
		// Token: 0x06008C53 RID: 35923 RVA: 0x0024A3D8 File Offset: 0x002485D8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceEntry()
		{
			Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueChoiceEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr);
			DialogueChoiceEntry.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "gameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "text");
			DialogueChoiceEntry.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "button");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleGameObject");
			DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "notPossibleText");
			DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, "canvasGroup");
			DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr, 100680724);
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x0024A494 File Offset: 0x00248694
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x0004344F File Offset: 0x0004164F
		public DialogueChoiceEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x06008C56 RID: 35926 RVA: 0x0024A4D0 File Offset: 0x002486D0
		// (set) Token: 0x06008C57 RID: 35927 RVA: 0x00043458 File Offset: 0x00041658
		public unsafe GameObject gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x06008C58 RID: 35928 RVA: 0x0024A500 File Offset: 0x00248700
		// (set) Token: 0x06008C59 RID: 35929 RVA: 0x00043477 File Offset: 0x00041677
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x06008C5A RID: 35930 RVA: 0x0024A530 File Offset: 0x00248730
		// (set) Token: 0x06008C5B RID: 35931 RVA: 0x00043496 File Offset: 0x00041696
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x06008C5C RID: 35932 RVA: 0x0024A560 File Offset: 0x00248760
		// (set) Token: 0x06008C5D RID: 35933 RVA: 0x000434B5 File Offset: 0x000416B5
		public unsafe GameObject notPossibleGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x06008C5E RID: 35934 RVA: 0x0024A590 File Offset: 0x00248790
		// (set) Token: 0x06008C5F RID: 35935 RVA: 0x000434D4 File Offset: 0x000416D4
		public unsafe TextMeshProUGUI notPossibleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_notPossibleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x06008C60 RID: 35936 RVA: 0x0024A5C0 File Offset: 0x002487C0
		// (set) Token: 0x06008C61 RID: 35937 RVA: 0x000434F3 File Offset: 0x000416F3
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEntry.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F1E RID: 24350
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x04005F1F RID: 24351
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04005F20 RID: 24352
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04005F21 RID: 24353
		private static readonly IntPtr NativeFieldInfoPtr_notPossibleGameObject;

		// Token: 0x04005F22 RID: 24354
		private static readonly IntPtr NativeFieldInfoPtr_notPossibleText;

		// Token: 0x04005F23 RID: 24355
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x04005F24 RID: 24356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
