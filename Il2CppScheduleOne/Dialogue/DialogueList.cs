using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000435 RID: 1077
	[Serializable]
	public class DialogueList : Object
	{
		// Token: 0x06005E8C RID: 24204 RVA: 0x001B3360 File Offset: 0x001B1560
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueList()
		{
			Il2CppClassPointerStore<DialogueList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueList>.NativeClassPtr);
			DialogueList.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, "Lines");
			DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675349);
			DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueList>.NativeClassPtr, 100675350);
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x001B33CC File Offset: 0x001B15CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197269, XrefRangeEnd = 197271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x001B3404 File Offset: 0x001B1604
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0002C931 File Offset: 0x0002AB31
		public DialogueList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06005E90 RID: 24208 RVA: 0x001B3440 File Offset: 0x001B1640
		// (set) Token: 0x06005E91 RID: 24209 RVA: 0x0002C93A File Offset: 0x0002AB3A
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueList.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040AA RID: 16554
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x040040AB RID: 16555
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;

		// Token: 0x040040AC RID: 16556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
