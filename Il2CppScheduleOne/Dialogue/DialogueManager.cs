using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000440 RID: 1088
	public class DialogueManager : Singleton<DialogueManager>
	{
		// Token: 0x06005F40 RID: 24384 RVA: 0x001B5C44 File Offset: 0x001B3E44
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueManager()
		{
			Il2CppClassPointerStore<DialogueManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr);
			DialogueManager.NativeFieldInfoPtr_DefaultDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultDatabase");
			DialogueManager.NativeFieldInfoPtr_DefaultModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "DefaultModules");
			DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675457);
			DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, 100675458);
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x001B5CC4 File Offset: 0x001B3EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198282, XrefRangeEnd = 198309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueModule Get(EDialogueModule moduleType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moduleType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueModule>(intPtr3) : null;
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x001B5D10 File Offset: 0x001B3F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198309, XrefRangeEnd = 198319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x0002CE5E File Offset: 0x0002B05E
		public DialogueManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06005F44 RID: 24388 RVA: 0x001B5D4C File Offset: 0x001B3F4C
		// (set) Token: 0x06005F45 RID: 24389 RVA: 0x0002CE67 File Offset: 0x0002B067
		public unsafe DialogueDatabase DefaultDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06005F46 RID: 24390 RVA: 0x001B5D7C File Offset: 0x001B3F7C
		// (set) Token: 0x06005F47 RID: 24391 RVA: 0x0002CE86 File Offset: 0x0002B086
		public unsafe List<DialogueModule> DefaultModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.NativeFieldInfoPtr_DefaultModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400411F RID: 16671
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDatabase;

		// Token: 0x04004120 RID: 16672
		private static readonly IntPtr NativeFieldInfoPtr_DefaultModules;

		// Token: 0x04004121 RID: 16673
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_DialogueModule_EDialogueModule_0;

		// Token: 0x04004122 RID: 16674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A06 RID: 2566
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueManager+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CE70 RID: 52848 RVA: 0x0031A728 File Offset: 0x00318928
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueManager>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, "moduleType");
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675459);
				DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr, 100675460);
			}

			// Token: 0x0600CE71 RID: 52849 RVA: 0x0031A790 File Offset: 0x00318990
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueManager.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE72 RID: 52850 RVA: 0x0031A7CC File Offset: 0x003189CC
			[CallerCount(0)]
			public unsafe bool _Get_b__0(DialogueModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueManager.__c__DisplayClass2_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE73 RID: 52851 RVA: 0x0006468F File Offset: 0x0006288F
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004038 RID: 16440
			// (get) Token: 0x0600CE74 RID: 52852 RVA: 0x0031A81C File Offset: 0x00318A1C
			// (set) Token: 0x0600CE75 RID: 52853 RVA: 0x00064698 File Offset: 0x00062898
			public unsafe EDialogueModule moduleType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueManager.__c__DisplayClass2_0.NativeFieldInfoPtr_moduleType)) = value;
				}
			}

			// Token: 0x04008B58 RID: 35672
			private static readonly IntPtr NativeFieldInfoPtr_moduleType;

			// Token: 0x04008B59 RID: 35673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B5A RID: 35674
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_DialogueModule_0;
		}
	}
}
