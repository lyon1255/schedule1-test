﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043C RID: 1084
	public class DialogueHandler_Customer : DialogueHandler
	{
		// Token: 0x06005F17 RID: 24343 RVA: 0x0002CD47 File Offset: 0x0002AF47
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_Customer()
		{
			Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr);
			DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr, 100675420);
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x001B51DC File Offset: 0x001B33DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0002CD80 File Offset: 0x0002AF80
		public DialogueHandler_Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
