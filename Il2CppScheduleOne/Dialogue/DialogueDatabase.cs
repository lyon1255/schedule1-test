using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000437 RID: 1079
	[Serializable]
	public class DialogueDatabase : ScriptableObject
	{
		// Token: 0x06005E98 RID: 24216 RVA: 0x001B3588 File Offset: 0x001B1788
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueDatabase()
		{
			Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr);
			DialogueDatabase.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "Modules");
			DialogueDatabase.NativeFieldInfoPtr_GenericEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "GenericEntries");
			DialogueDatabase.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "handler");
			DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675353);
			DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675354);
			DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675355);
			DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675356);
			DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675357);
			DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675358);
			DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, 100675359);
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001B3680 File Offset: 0x001B1880
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x001B36C0 File Offset: 0x001B18C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DialogueHandler _handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x001B3704 File Offset: 0x001B1904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197342, RefRangeEnd = 197345, XrefRangeStart = 197293, XrefRangeEnd = 197342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule GetModule(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x001B3750 File Offset: 0x001B1950
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 197362, RefRangeEnd = 197377, XrefRangeStart = 197345, XrefRangeEnd = 197362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x001B37B0 File Offset: 0x001B19B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197386, RefRangeEnd = 197387, XrefRangeStart = 197377, XrefRangeEnd = 197386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasChain(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x001B380C File Offset: 0x001B1A0C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 197401, RefRangeEnd = 197436, XrefRangeStart = 197387, XrefRangeEnd = 197401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLine(EDialogueModule moduleType, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x001B3864 File Offset: 0x001B1A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197436, XrefRangeEnd = 197444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x0002C981 File Offset: 0x0002AB81
		public DialogueDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x001B38A0 File Offset: 0x001B1AA0
		// (set) Token: 0x06005EA2 RID: 24226 RVA: 0x0002C98A File Offset: 0x0002AB8A
		public unsafe List<DialogueModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06005EA3 RID: 24227 RVA: 0x001B38D0 File Offset: 0x001B1AD0
		// (set) Token: 0x06005EA4 RID: 24228 RVA: 0x0002C9A9 File Offset: 0x0002ABA9
		public unsafe List<Entry> GenericEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_GenericEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x001B3900 File Offset: 0x001B1B00
		// (set) Token: 0x06005EA6 RID: 24230 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040B0 RID: 16560
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x040040B1 RID: 16561
		private static readonly IntPtr NativeFieldInfoPtr_GenericEntries;

		// Token: 0x040040B2 RID: 16562
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x040040B3 RID: 16563
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeModules_Private_get_List_1_DialogueModule_0;

		// Token: 0x040040B4 RID: 16564
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DialogueHandler_0;

		// Token: 0x040040B5 RID: 16565
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x040040B6 RID: 16566
		private static readonly IntPtr NativeMethodInfoPtr_GetChain_Public_DialogueChain_EDialogueModule_String_0;

		// Token: 0x040040B7 RID: 16567
		private static readonly IntPtr NativeMethodInfoPtr_HasChain_Public_Boolean_EDialogueModule_String_0;

		// Token: 0x040040B8 RID: 16568
		private static readonly IntPtr NativeMethodInfoPtr_GetLine_Public_String_EDialogueModule_String_0;

		// Token: 0x040040B9 RID: 16569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FC RID: 2556
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueDatabase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE29 RID: 52777 RVA: 0x0031997C File Offset: 0x00317B7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueDatabase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr);
				DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, "moduleType");
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675360);
				DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr, 100675361);
			}

			// Token: 0x0600CE2A RID: 52778 RVA: 0x003199E4 File Offset: 0x00317BE4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueDatabase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE2B RID: 52779 RVA: 0x00319A20 File Offset: 0x00317C20
			[CallerCount(0)]
			public unsafe bool _GetModule_b__0(DialogueModule module)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueDatabase.__c__DisplayClass6_0.NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE2C RID: 52780 RVA: 0x000644A6 File Offset: 0x000626A6
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402B RID: 16427
			// (get) Token: 0x0600CE2D RID: 52781 RVA: 0x00319A70 File Offset: 0x00317C70
			// (set) Token: 0x0600CE2E RID: 52782 RVA: 0x000644AF File Offset: 0x000626AF
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueDatabase.__c__DisplayClass6_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008B32 RID: 35634
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008B33 RID: 35635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B34 RID: 35636
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
