using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043D RID: 1085
	public class DialogueHandler_EstateAgent : ControlledDialogueHandler
	{
		// Token: 0x06005F1A RID: 24346 RVA: 0x001B5218 File Offset: 0x001B3418
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_EstateAgent()
		{
			Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_EstateAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr);
			DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "selectedProperty");
			DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "selectedBusiness");
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675421);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675422);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675423);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675424);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675425);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675426);
			DialogueHandler_EstateAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, 100675427);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x001B52FC File Offset: 0x001B34FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197903, XrefRangeEnd = 197946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x001B5370 File Offset: 0x001B3570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197946, XrefRangeEnd = 197984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x001B53C8 File Offset: 0x001B35C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197984, XrefRangeEnd = 198026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x001B5418 File Offset: 0x001B3618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198026, XrefRangeEnd = 198053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DialogueCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x001B5468 File Offset: 0x001B3668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198053, XrefRangeEnd = 198068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x001B54D0 File Offset: 0x001B36D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198068, XrefRangeEnd = 198120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_EstateAgent.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x001B5538 File Offset: 0x001B3738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_EstateAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x0002CD89 File Offset: 0x0002AF89
		public DialogueHandler_EstateAgent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06005F23 RID: 24355 RVA: 0x001B5574 File Offset: 0x001B3774
		// (set) Token: 0x06005F24 RID: 24356 RVA: 0x0002CD92 File Offset: 0x0002AF92
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x001B55A4 File Offset: 0x001B37A4
		// (set) Token: 0x06005F26 RID: 24358 RVA: 0x0002CDB1 File Offset: 0x0002AFB1
		public unsafe Business selectedBusiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.NativeFieldInfoPtr_selectedBusiness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeFieldInfoPtr_selectedBusiness;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_Boolean_String_0;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A00 RID: 2560
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CE48 RID: 52808 RVA: 0x00319EF0 File Offset: 0x003180F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675428);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675429);
				DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr, 100675430);
			}

			// Token: 0x0600CE49 RID: 52809 RVA: 0x00319F6C File Offset: 0x0031816C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE4A RID: 52810 RVA: 0x00319FA8 File Offset: 0x003181A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197899, XrefRangeEnd = 197903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE4B RID: 52811 RVA: 0x00319FF8 File Offset: 0x003181F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE4C RID: 52812 RVA: 0x0006459F File Offset: 0x0006279F
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004032 RID: 16434
			// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x0031A048 File Offset: 0x00318248
			// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x000645A8 File Offset: 0x000627A8
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B42 RID: 35650
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B43 RID: 35651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B44 RID: 35652
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008B45 RID: 35653
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A01 RID: 2561
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600CE4F RID: 52815 RVA: 0x0031A070 File Offset: 0x00318270
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675431);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675432);
				DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr, 100675433);
			}

			// Token: 0x0600CE50 RID: 52816 RVA: 0x0031A0EC File Offset: 0x003182EC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE51 RID: 52817 RVA: 0x0031A128 File Offset: 0x00318328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldChoiceBeShown_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE52 RID: 52818 RVA: 0x0031A178 File Offset: 0x00318378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldChoiceBeShown_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE53 RID: 52819 RVA: 0x000645C7 File Offset: 0x000627C7
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004033 RID: 16435
			// (get) Token: 0x0600CE54 RID: 52820 RVA: 0x0031A1C8 File Offset: 0x003183C8
			// (set) Token: 0x0600CE55 RID: 52821 RVA: 0x000645D0 File Offset: 0x000627D0
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass3_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B46 RID: 35654
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B47 RID: 35655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B48 RID: 35656
			private static readonly IntPtr NativeMethodInfoPtr__ShouldChoiceBeShown_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008B49 RID: 35657
			private static readonly IntPtr NativeMethodInfoPtr__ShouldChoiceBeShown_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A02 RID: 2562
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600CE56 RID: 52822 RVA: 0x0031A1F0 File Offset: 0x003183F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675434);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675435);
				DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr, 100675436);
			}

			// Token: 0x0600CE57 RID: 52823 RVA: 0x0031A26C File Offset: 0x0031846C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE58 RID: 52824 RVA: 0x0031A2A8 File Offset: 0x003184A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE59 RID: 52825 RVA: 0x0031A2F8 File Offset: 0x003184F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE5A RID: 52826 RVA: 0x000645EF File Offset: 0x000627EF
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004034 RID: 16436
			// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x0031A348 File Offset: 0x00318548
			// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x000645F8 File Offset: 0x000627F8
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B4A RID: 35658
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B4B RID: 35659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B4C RID: 35660
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008B4D RID: 35661
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__1_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A03 RID: 2563
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_EstateAgent+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600CE5D RID: 52829 RVA: 0x0031A370 File Offset: 0x00318570
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_EstateAgent>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675437);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675438);
				DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr, 100675439);
			}

			// Token: 0x0600CE5E RID: 52830 RVA: 0x0031A3EC File Offset: 0x003185EC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_EstateAgent.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE5F RID: 52831 RVA: 0x0031A428 File Offset: 0x00318628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE60 RID: 52832 RVA: 0x0031A478 File Offset: 0x00318678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__1(Business x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE61 RID: 52833 RVA: 0x00064617 File Offset: 0x00062817
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004035 RID: 16437
			// (get) Token: 0x0600CE62 RID: 52834 RVA: 0x0031A4C8 File Offset: 0x003186C8
			// (set) Token: 0x0600CE63 RID: 52835 RVA: 0x00064620 File Offset: 0x00062820
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_EstateAgent.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B4E RID: 35662
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B4F RID: 35663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B50 RID: 35664
			private static readonly IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008B51 RID: 35665
			private static readonly IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__1_Internal_Boolean_Business_0;
		}
	}
}
