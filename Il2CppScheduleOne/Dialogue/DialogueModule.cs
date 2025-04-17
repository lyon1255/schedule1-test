using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000441 RID: 1089
	public class DialogueModule : MonoBehaviour
	{
		// Token: 0x06005F48 RID: 24392 RVA: 0x001B5DAC File Offset: 0x001B3FAC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueModule()
		{
			Il2CppClassPointerStore<DialogueModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr);
			DialogueModule.NativeFieldInfoPtr_ModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "ModuleType");
			DialogueModule.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "Entries");
			DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675461);
			DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675462);
			DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675463);
			DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675464);
			DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, 100675465);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x001B5E68 File Offset: 0x001B4068
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 198334, RefRangeEnd = 198340, XrefRangeStart = 198320, XrefRangeEnd = 198334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Entry(pointer);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x001B5EB0 File Offset: 0x001B40B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198340, XrefRangeEnd = 198349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x001B5F00 File Offset: 0x001B4100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198349, XrefRangeEnd = 198350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_HasChain_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x001B5F50 File Offset: 0x001B4150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198350, XrefRangeEnd = 198355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr_GetLine_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x001B5F98 File Offset: 0x001B4198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198355, XrefRangeEnd = 198363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x0002CEA5 File Offset: 0x0002B0A5
		public DialogueModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06005F4F RID: 24399 RVA: 0x001B5FD4 File Offset: 0x001B41D4
		// (set) Token: 0x06005F50 RID: 24400 RVA: 0x0002CEAE File Offset: 0x0002B0AE
		public unsafe EDialogueModule ModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_ModuleType)) = value;
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x001B5FFC File Offset: 0x001B41FC
		// (set) Token: 0x06005F52 RID: 24402 RVA: 0x0002CEC9 File Offset: 0x0002B0C9
		public unsafe List<Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004123 RID: 16675
		private static readonly IntPtr NativeFieldInfoPtr_ModuleType;

		// Token: 0x04004124 RID: 16676
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004125 RID: 16677
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04004126 RID: 16678
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_String_0;

		// Token: 0x04004127 RID: 16679
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_String_0;

		// Token: 0x04004128 RID: 16680
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_String_0;

		// Token: 0x04004129 RID: 16681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A07 RID: 2567
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueModule+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE76 RID: 52854 RVA: 0x0031A844 File Offset: 0x00318A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueModule>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, "key");
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675466);
				DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr, 100675467);
			}

			// Token: 0x0600CE77 RID: 52855 RVA: 0x0031A8AC File Offset: 0x00318AAC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueModule.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE78 RID: 52856 RVA: 0x0031A8E8 File Offset: 0x00318AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198319, XrefRangeEnd = 198320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEntry_b__0(Entry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueModule.__c__DisplayClass2_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE79 RID: 52857 RVA: 0x000646B3 File Offset: 0x000628B3
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004039 RID: 16441
			// (get) Token: 0x0600CE7A RID: 52858 RVA: 0x0031A93C File Offset: 0x00318B3C
			// (set) Token: 0x0600CE7B RID: 52859 RVA: 0x000646BC File Offset: 0x000628BC
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueModule.__c__DisplayClass2_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B5B RID: 35675
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008B5C RID: 35676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B5D RID: 35677
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_Entry_0;
		}
	}
}
