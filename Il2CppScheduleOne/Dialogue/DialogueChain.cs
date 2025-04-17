using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000436 RID: 1078
	[Serializable]
	public class DialogueChain : Object
	{
		// Token: 0x06005E92 RID: 24210 RVA: 0x001B3470 File Offset: 0x001B1670
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChain()
		{
			Il2CppClassPointerStore<DialogueChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr);
			DialogueChain.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, "Lines");
			DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675351);
			DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100675352);
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x001B34DC File Offset: 0x001B16DC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 197279, RefRangeEnd = 197293, XrefRangeStart = 197271, XrefRangeEnd = 197279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetMessageChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x001B351C File Offset: 0x001B171C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0002C959 File Offset: 0x0002AB59
		public DialogueChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06005E96 RID: 24214 RVA: 0x001B3558 File Offset: 0x001B1758
		// (set) Token: 0x06005E97 RID: 24215 RVA: 0x0002C962 File Offset: 0x0002AB62
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040AD RID: 16557
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x040040AE RID: 16558
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0;

		// Token: 0x040040AF RID: 16559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
